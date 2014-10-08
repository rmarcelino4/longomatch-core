//
//  Copyright (C) 2014 Andoni Morales Alastruey
//
//  This program is free software; you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation; either version 2 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program; if not, write to the Free Software
//  Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA 02110-1301, USA.
//
using System;
using System.Linq;
using System.Collections.Generic;
using LongoMatch.Core.Store;
using LongoMatch.Core.Common;
using LongoMatch.Core.Interfaces;
using LongoMatch.Core.Interfaces.Drawing;
using LongoMatch.Core.Store.Drawables;
using System.IO;

namespace LongoMatch.Drawing.CanvasObjects
{
	public abstract class TimelineObject: CanvasObject, ICanvasSelectableObject
	{
		List<TimeNodeObject> nodes;
		double secondsPerPixel;
		protected Time maxTime;
		protected ISurface selectionBorderL, selectionBorderR;

		public TimelineObject (Time maxTime, double offsetY, Color background)
		{
			this.BackgroundColor = background;
			this.nodes = new List<TimeNodeObject> ();
			this.maxTime = maxTime;
			selectionBorderL = LoadBorder (StyleConf.TimelineSelectionLeft);
			selectionBorderR = LoadBorder (StyleConf.TimelineSelectionRight);

			Visible = true;
			CurrentTime = new Time (0);
			OffsetY = offsetY;
			SecondsPerPixel = 0.1;
		}
		
		protected override void Dispose (bool disposing)
		{
			foreach (TimeNodeObject tn in nodes) {
				tn.Dispose ();
			}
			selectionBorderL.Dispose ();
			selectionBorderR.Dispose ();
			base.Dispose (disposing);
		}

		public double SecondsPerPixel {
			set {
				secondsPerPixel = value;
				foreach (TimeNodeObject to in nodes) {
					to.SecondsPerPixel = secondsPerPixel;
					to.ResetDrawArea ();
				}
			}
			protected get {
				return secondsPerPixel;
			}
		}

		public Color BackgroundColor {
			get;
			set;
		}

		public Time CurrentTime {
			set;
			protected get;
		}
		
		public double Height {
			get {
				return StyleConf.TimelineCategoryHeight;
			}
		}

		public double Width {
			set;
			protected get;
		}

		public double OffsetY {
			set;
			get;
		}

		public void AddNode (TimeNodeObject o)
		{
			nodes.Add (o);
			o.RedrawEvent += HandleRedrawEvent;
		}

		public void RemoveNode (TimeNode node)
		{
			TimeNodeObject to;
			
			to = nodes.FirstOrDefault (n => n.TimeNode == node);
			if (to != null) {
				to.RedrawEvent -= HandleRedrawEvent;
				nodes.Remove (to);
			}
		}
		
		protected virtual bool TimeNodeObjectIsVisible (TimeNodeObject tn)
		{
			return true;
		}
		
		protected virtual void DrawBackground (IDrawingToolkit tk, Area area)
		{
			tk.FillColor = BackgroundColor;
			tk.StrokeColor = BackgroundColor;
			tk.LineWidth = 0;
			
			tk.DrawRectangle (new Point (area.Start.X, OffsetY), area.Width, Height);
		}

		void HandleRedrawEvent (ICanvasObject co, Area area)
		{
			EmitRedrawEvent (co as CanvasObject, area);
		}

		public override void Draw (IDrawingToolkit tk, Area area)
		{
			double position;
			List<TimeNodeObject> selected;
			
			selected = new List<TimeNodeObject> ();

			if (!UpdateDrawArea (tk, area, new Area (new Point (0, OffsetY), Width, Height))) {
				return;
			};

			tk.Begin ();
			DrawBackground (tk, area);
			foreach (TimeNodeObject p in nodes) {
				if (!TimeNodeObjectIsVisible (p))
					continue;
				if (p.Selected) {
					selected.Add (p);
					continue;
				}
				p.OffsetY = OffsetY;
				p.Draw (tk, area);
			}
			foreach (TimeNodeObject p in selected) {
				p.OffsetY = OffsetY;
				p.Draw (tk, area);
			}

			tk.FillColor = Config.Style.PaletteTool;
			tk.StrokeColor = Config.Style.PaletteTool;
			tk.LineWidth = Constants.TIMELINE_LINE_WIDTH;
			position = Utils.TimeToPos (CurrentTime, secondsPerPixel);
			tk.DrawLine (new Point (position, OffsetY),
			             new Point (position, OffsetY + Height));
			
			tk.End ();
		}

		public Selection GetSelection (Point point, double precision, bool inMotion=false)
		{
			Selection selection = null;

			if (point.Y >= OffsetY && point.Y < OffsetY + Height) {
				foreach (TimeNodeObject po in nodes) {
					Selection tmp;
					if (!po.Visible) {
						continue;
					}
					tmp = po.GetSelection (point, precision);
					if (tmp == null) {
						continue;
					}
					if (tmp.Accuracy == 0) {
						selection = tmp;
						break;
					}
					if (selection == null || tmp.Accuracy < selection.Accuracy) {
						selection = tmp;
					}
				}
			}
			return selection;
		}

		public void Move (Selection s, Point p, Point start)
		{
			s.Drawable.Move (s, p, start);
		}
		
		ISurface LoadBorder (string name)
		{
			Image img = Image.LoadFromFile (Path.Combine (Config.IconsDir, name));
			img.Scale (StyleConf.TimelineCategoryHeight, StyleConf.TimelineCategoryHeight);
			return Config.DrawingToolkit.CreateSurface (img.Width, img.Height, img);
		}
	}

	public class CategoryTimeline: TimelineObject
	{
		EventsFilter filter;

		public CategoryTimeline (List<TimelineEvent> plays, Time maxTime, double offsetY, Color background, EventsFilter filter):
			base (maxTime, offsetY, background)
		{
			this.filter = filter;
			foreach (TimelineEvent p in plays) {
				AddPlay (p);
			}
		}

		protected override bool TimeNodeObjectIsVisible (TimeNodeObject tn)
		{
			return filter.IsVisible ((tn as PlayObject).Play);
		}

		public void AddPlay (TimelineEvent play)
		{
			PlayObject po = new PlayObject (play);
			po.SelectionLeft = selectionBorderL; 
			po.SelectionRight = selectionBorderR; 
			po.OffsetY = OffsetY;
			po.SecondsPerPixel = SecondsPerPixel;
			po.MaxTime = maxTime;
			AddNode (po);
		}
	}

	public class TimerTimeline: TimelineObject
	{

		public TimerTimeline (List<Timer> timers, Time maxTime, double offsetY, Color background):
			base (maxTime, offsetY, background)
		{
			foreach (Timer t in timers) {
				foreach (TimeNode tn in t.Nodes) {
					TimeNodeObject to = new TimeNodeObject (tn);
					to.OffsetY = OffsetY;
					to.SecondsPerPixel = SecondsPerPixel;
					to.MaxTime = maxTime;
					to.SelectWhole = false;
					AddNode (to);
				}
			}
		}
		
		protected override void DrawBackground (IDrawingToolkit tk, Area area)
		{
			double linepos;
			base.DrawBackground (tk, area);

			linepos = OffsetY + Height - StyleConf.TimelineLineSize;

			tk.FillColor = Config.Style.PaletteBackgroundDark;
			tk.StrokeColor = Config.Style.PaletteBackgroundDark;
			tk.LineWidth = 4;
			tk.DrawLine (new Point (0, linepos),
			             new Point (Width, linepos));
		}
	}
}

