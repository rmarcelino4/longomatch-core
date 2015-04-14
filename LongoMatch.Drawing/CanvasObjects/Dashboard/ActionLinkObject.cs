﻿//
//  Copyright (C) 2015 Fluendo S.A.
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
using LongoMatch.Core.Common;
using LongoMatch.Core.Handlers.Drawing;
using LongoMatch.Core.Interfaces.Drawing;
using LongoMatch.Core.Store;
using LongoMatch.Core.Store.Drawables;

namespace LongoMatch.Drawing.CanvasObjects.Dashboard
{
	public class ActionLinkObject: CanvasObject, ICanvasSelectableObject
	{
		Line line;
		Point stop;
		int selectionSize = 4;

		public ActionLinkObject (LinkAnchorObject source,
		                         LinkAnchorObject destination,
		                         ActionLink link)
		{
			Link = link;
			Source = source;
			Destination = destination;
			if (destination == null) {
				stop = source.Position;
			} else {
				stop = destination.Position;
			}
			line = new Line ();
			line.Start = source.Position;
			line.Stop = stop;
		}

		public LinkAnchorObject Source {
			get;
			set;
		}

		public ActionLink Link {
			get;
			set;
		}

		public LinkAnchorObject Destination {
			get;
			set;
		}

		public virtual Area Area {
			get {
				line.Start = Source.Position;
				if (Destination != null) {
					line.Stop = Destination.Position;
				} else {
					line.Stop = this.stop;
				}
				Area area = line.Area;
				area.Start.X -= selectionSize + 2;
				area.Start.Y -= selectionSize + 2;
				area.Width += selectionSize * 2 + 4;
				area.Height += selectionSize * 2 + 4;
				return area;
			}
		}

		public Selection GetSelection (Point point, double precision, bool inMotion = false)
		{
			Selection sel = line.GetSelection (point, precision, inMotion);
			if (sel != null) {
				sel.Drawable = this;
			}
			return sel;
		}

		public void Move (Selection s, Point dst, Point start)
		{
			line.Move (s, dst, start);
			stop = line.Stop;
		}

		public override void Draw (IDrawingToolkit tk, Area area)
		{
			Color lineColor;
			int lineWidth = 4;

			if (!UpdateDrawArea (tk, area, Area)) {
				return;
			}

			if (Highlighted) {
				lineColor = Config.Style.PaletteActive;
			} else if (Selected) {
				lineColor = Config.Style.PaletteSelected;
			} else {
				lineColor = Color.Yellow;
			}

			tk.Begin ();
			tk.FillColor = lineColor;
			tk.StrokeColor = lineColor;
			tk.LineWidth = lineWidth;
			tk.LineStyle = LineStyle.Normal;
			tk.DrawLine (line.Start, line.Stop);
			tk.DrawArrow (line.Start, line.Stop, 2, 0.3, true);
			tk.End ();
		}
	}
}
