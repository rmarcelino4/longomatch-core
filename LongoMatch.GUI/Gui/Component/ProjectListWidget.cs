// ProjectListWidget.cs
//
//  Copyright (C) 2007-2009 Andoni Morales Alastruey
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA 02110-1301, USA.
//
//
using System;
using System.Collections.Generic;
using Gdk;
using Gtk;
using LongoMatch.Core.Handlers;
using LongoMatch.Core.Store;
using LongoMatch.Core.Common;

namespace LongoMatch.Gui.Component
{
	[System.ComponentModel.Category("LongoMatch")]
	[System.ComponentModel.ToolboxItem(true)]
	public partial class ProjectListWidget : Gtk.Bin
	{
		public event ProjectsSelectedHandler ProjectsSelected;
		public event ProjectSelectedHandler ProjectSelected;

		const int COL_DISPLAY_NAME = 0;
		const int COL_PIXBUF = 1;
		const int COL_PROJECT_DESCRIPTION = 2;
		TreeModelFilter filter;
		List<ProjectDescription> projects;
		ListStore store;
		bool swallowSignals;

		public ProjectListWidget ()
		{
			this.Build ();
			
			//GtkGlue.EntrySetIcon (filterEntry, GtkGlue.EntryIconPosition.Secondary, "gtk-clear");
			store = CreateStore ();
			iconview.TextColumn = COL_DISPLAY_NAME;
			iconview.PixbufColumn = COL_PIXBUF;
			iconview.SelectionChanged += OnSelectionChanged;
			iconview.ItemActivated += HandleItemActivated;
			iconview.ItemWidth = 200;
			sortcombobox.Active = (int)Config.ProjectSortMethod;
			sortcombobox.Changed += (sender, e) => {
				/* Hack to make it actually resort */
				store.SetSortColumnId (-2 , SortType.Ascending);
				store.SetSortColumnId (0, SortType.Ascending);
				Config.ProjectSortMethod = (ProjectSortMethod) sortcombobox.Active;
			};
		}

		public SelectionMode SelectionMode {
			set {
				iconview.SelectionMode = value;
			}
		}

		public void Fill (List<ProjectDescription> projects)
		{
			Pixbuf image;
			swallowSignals = true;
			this.projects = projects;
			store.Clear ();
			foreach (ProjectDescription pdesc in projects) {
				if (pdesc.FileSet.Preview != null) {
					image = pdesc.FileSet.Preview.Value;
				} else {
					image = Stetic.IconLoader.LoadIcon (this, Gtk.Stock.Harddisk, IconSize.Dialog);
				}
				store.AppendValues (pdesc.Title, image, pdesc);
			}
			swallowSignals = false;
		}

		public void RemoveProjects (List<ProjectDescription> projects)
		{
			foreach (ProjectDescription project in projects) {
				this.projects.Remove (project);
			}
			Fill (this.projects);
			if (ProjectsSelected != null) {
				ProjectsSelected (new List<ProjectDescription> ());
			}
		}

		public void ClearSearch ()
		{
			filterEntry.Text = "";
		}

		ListStore CreateStore ()
		{
			store = new ListStore (typeof(string), typeof(Gdk.Pixbuf), typeof(ProjectDescription));
			store.SetSortFunc (0, SortFunc);
			store.SetSortColumnId (0, SortType.Ascending);
			filter = new Gtk.TreeModelFilter (store, null);
			filter.VisibleFunc = new Gtk.TreeModelFilterVisibleFunc (FilterTree);
			iconview.Model = filter;
			return store;
		}

		int CompareString (string s1, string s2)
		{
			if (s1 != null && s2 != null) {
				return s1.CompareTo (s2);
			} else if (s1 != null) {
				return 1;
			} else if (s2 != null) {
				return - 1;
			}
			return 0;
		}

		int SortFunc (TreeModel model, TreeIter a, TreeIter b)
		{
			ProjectDescription p1, p2;
			int ret;
			
			p1 = (ProjectDescription)model.GetValue (a, COL_PROJECT_DESCRIPTION);
			p2 = (ProjectDescription)model.GetValue (b, COL_PROJECT_DESCRIPTION);

			if (p1 == null) {
				return 0;
			} else if (p2 == null) {
				return 0;
			}
			
			if (sortcombobox.Active == 0) {
				ret = CompareString (p1.Title, p2.Title);
				if (ret == 0) {
					ret = (int)(p1.MatchDate.Ticks - p2.MatchDate.Ticks);
				}
				return ret;
			} else if (sortcombobox.Active == 1) {
				ret = (int)(p1.MatchDate.Ticks - p2.MatchDate.Ticks);
				if (ret == 0) {
					ret = (CompareString (p1.Title, p2.Title));
				}
				return ret;
			} else if (sortcombobox.Active == 2) {
				return (int)(p1.LastModified.Ticks - p2.LastModified.Ticks);
			} else if (sortcombobox.Active == 3) {
				ret = CompareString (p1.Season, p2.Season);
				if (ret == 0) {
					ret = CompareString (p1.Title, p2.Title);
				}
				return ret;
			} else if (sortcombobox.Active == 4) {
				ret = CompareString (p1.Competition, p2.Competition);
				if (ret == 0) {
					ret = CompareString (p1.Title, p2.Title);
				}
				return ret;
			} else {
				return p1.Title.CompareTo(p2.Title);
			}
		}

		protected virtual void OnFilterentryChanged (object sender, System.EventArgs e)
		{
			filter.Refilter ();
		}

		private bool FilterTree (Gtk.TreeModel model, Gtk.TreeIter iter)
		{
			StringComparison sc = StringComparison.InvariantCultureIgnoreCase;
			ProjectDescription project = (ProjectDescription)model.GetValue (iter, COL_PROJECT_DESCRIPTION);

			if (project == null)
				return true;

			if (filterEntry.Text == "")
				return true;

			if (project.Title.IndexOf (filterEntry.Text, sc) > -1)
				return true;
			else if (project.Season.IndexOf (filterEntry.Text, sc) > -1)
				return true;
			else if (project.Competition.IndexOf (filterEntry.Text, sc) > -1)
				return true;
			else if (project.LocalName.IndexOf (filterEntry.Text, sc) > -1)
				return true;
			else if (project.VisitorName.IndexOf (filterEntry.Text, sc) > -1)
				return true;
			else
				return false;
		}

		protected virtual void OnSelectionChanged (object o, EventArgs args)
		{
			TreeIter iter;
			List<ProjectDescription> list;
			TreePath[] pathArray;
			
			if (swallowSignals)
				return;

			if (ProjectsSelected != null) {
				list = new List<ProjectDescription> ();
				pathArray = iconview.SelectedItems;
				
				for (int i=0; i< pathArray.Length; i++) {
					iconview.Model.GetIterFromString (out iter, pathArray [i].ToString ());
					list.Add ((ProjectDescription)iconview.Model.GetValue (iter, COL_PROJECT_DESCRIPTION));
				}
				ProjectsSelected (list);
			}
		}

		void HandleItemActivated (object o, ItemActivatedArgs args)
		{
			TreeIter iter;
			ProjectDescription pdesc;
			
			if (swallowSignals)
				return;
				
			if (ProjectSelected != null) {
				iconview.Model.GetIter (out iter, args.Path);
				pdesc = iconview.Model.GetValue (iter, COL_PROJECT_DESCRIPTION) as ProjectDescription;
				if (pdesc != null) {
					ProjectSelected (pdesc);
				}
			}
		}
	}
}
