
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Component
{
	public partial class CodingWidget
	{
		private global::Gtk.UIManager UIManager;
		private global::Gtk.RadioAction positionMode;
		private global::Gtk.RadioAction timelineMode;
		private global::Gtk.RadioAction autoTaggingMode;
		private global::Gtk.Action zoomFitAction;
		private global::Gtk.RadioAction convertAction;
		private global::Gtk.VBox vbox;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Toolbar codingtoolbar;
		private global::Gtk.Notebook notebook;
		private global::Gtk.HPaned hpaned1;
		private global::Gtk.DrawingArea teamsdrawingarea;
		private global::Gtk.HBox hbox5;
		private global::LongoMatch.Gui.Component.ButtonsWidget buttonswidget;
		private global::Gtk.Label label18;
		private global::LongoMatch.Gui.Component.Timeline timeline;
		private global::Gtk.Label label21;
		private global::LongoMatch.Gui.Component.PlaysPositionViewer playspositionviewer1;
		private global::Gtk.Label label19;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Component.CodingWidget
			Stetic.BinContainer w1 = global::Stetic.BinContainer.Attach (this);
			this.UIManager = new global::Gtk.UIManager ();
			global::Gtk.ActionGroup w2 = new global::Gtk.ActionGroup ("Timeline");
			this.positionMode = new global::Gtk.RadioAction ("positionMode", null, null, "gtk-justify-fill", 0);
			this.positionMode.Group = new global::GLib.SList (global::System.IntPtr.Zero);
			w2.Add (this.positionMode, null);
			this.UIManager.InsertActionGroup (w2, 0);
			global::Gtk.ActionGroup w3 = new global::Gtk.ActionGroup ("Default");
			this.timelineMode = new global::Gtk.RadioAction ("timelineMode", null, global::Mono.Unix.Catalog.GetString ("Timeline view"), "gtk-justify-fill", 0);
			this.timelineMode.Group = this.positionMode.Group;
			w3.Add (this.timelineMode, null);
			this.autoTaggingMode = new global::Gtk.RadioAction ("autoTaggingMode", null, global::Mono.Unix.Catalog.GetString ("Automatic tagging view"), "gtk-select-color", 0);
			this.autoTaggingMode.Group = this.timelineMode.Group;
			w3.Add (this.autoTaggingMode, null);
			this.zoomFitAction = new global::Gtk.Action ("zoomFitAction", null, null, "gtk-zoom-fit");
			w3.Add (this.zoomFitAction, null);
			this.convertAction = new global::Gtk.RadioAction ("convertAction", null, null, "gtk-convert", 0);
			this.convertAction.Group = this.autoTaggingMode.Group;
			w3.Add (this.convertAction, null);
			this.UIManager.InsertActionGroup (w3, 1);
			this.Name = "LongoMatch.Gui.Component.CodingWidget";
			// Container child LongoMatch.Gui.Component.CodingWidget.Gtk.Container+ContainerChild
			this.vbox = new global::Gtk.VBox ();
			this.vbox.Name = "vbox";
			this.vbox.Spacing = 6;
			// Container child vbox.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString ("<ui><toolbar name='codingtoolbar'><toolitem name='autoTaggingMode' action='autoTaggingMode'/><toolitem name='timelineMode' action='timelineMode'/><toolitem name='positionMode' action='positionMode'/></toolbar></ui>");
			this.codingtoolbar = ((global::Gtk.Toolbar)(this.UIManager.GetWidget ("/codingtoolbar")));
			this.codingtoolbar.Name = "codingtoolbar";
			this.codingtoolbar.ShowArrow = false;
			this.hbox1.Add (this.codingtoolbar);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.codingtoolbar]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			this.vbox.Add (this.hbox1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox [this.hbox1]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox.Gtk.Box+BoxChild
			this.notebook = new global::Gtk.Notebook ();
			this.notebook.CanFocus = true;
			this.notebook.Name = "notebook";
			this.notebook.CurrentPage = 2;
			// Container child notebook.Gtk.Notebook+NotebookChild
			this.hpaned1 = new global::Gtk.HPaned ();
			this.hpaned1.CanFocus = true;
			this.hpaned1.Name = "hpaned1";
			this.hpaned1.Position = 276;
			// Container child hpaned1.Gtk.Paned+PanedChild
			this.teamsdrawingarea = new global::Gtk.DrawingArea ();
			this.teamsdrawingarea.Name = "teamsdrawingarea";
			this.hpaned1.Add (this.teamsdrawingarea);
			global::Gtk.Paned.PanedChild w6 = ((global::Gtk.Paned.PanedChild)(this.hpaned1 [this.teamsdrawingarea]));
			w6.Resize = false;
			// Container child hpaned1.Gtk.Paned+PanedChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.buttonswidget = new global::LongoMatch.Gui.Component.ButtonsWidget ();
			this.buttonswidget.Events = ((global::Gdk.EventMask)(256));
			this.buttonswidget.Name = "buttonswidget";
			this.buttonswidget.Edited = false;
			this.hbox5.Add (this.buttonswidget);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.buttonswidget]));
			w7.Position = 0;
			this.hpaned1.Add (this.hbox5);
			this.notebook.Add (this.hpaned1);
			// Notebook tab
			this.label18 = new global::Gtk.Label ();
			this.label18.Name = "label18";
			this.label18.LabelProp = global::Mono.Unix.Catalog.GetString ("page2");
			this.notebook.SetTabLabel (this.hpaned1, this.label18);
			this.label18.ShowAll ();
			// Container child notebook.Gtk.Notebook+NotebookChild
			this.timeline = new global::LongoMatch.Gui.Component.Timeline ();
			this.timeline.Events = ((global::Gdk.EventMask)(256));
			this.timeline.Name = "timeline";
			this.notebook.Add (this.timeline);
			global::Gtk.Notebook.NotebookChild w10 = ((global::Gtk.Notebook.NotebookChild)(this.notebook [this.timeline]));
			w10.Position = 1;
			// Notebook tab
			this.label21 = new global::Gtk.Label ();
			this.label21.Name = "label21";
			this.label21.LabelProp = global::Mono.Unix.Catalog.GetString ("page1");
			this.notebook.SetTabLabel (this.timeline, this.label21);
			this.label21.ShowAll ();
			// Container child notebook.Gtk.Notebook+NotebookChild
			this.playspositionviewer1 = new global::LongoMatch.Gui.Component.PlaysPositionViewer ();
			this.playspositionviewer1.Events = ((global::Gdk.EventMask)(256));
			this.playspositionviewer1.Name = "playspositionviewer1";
			this.notebook.Add (this.playspositionviewer1);
			global::Gtk.Notebook.NotebookChild w11 = ((global::Gtk.Notebook.NotebookChild)(this.notebook [this.playspositionviewer1]));
			w11.Position = 2;
			// Notebook tab
			this.label19 = new global::Gtk.Label ();
			this.label19.Name = "label19";
			this.label19.LabelProp = global::Mono.Unix.Catalog.GetString ("page3");
			this.notebook.SetTabLabel (this.playspositionviewer1, this.label19);
			this.label19.ShowAll ();
			this.vbox.Add (this.notebook);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox [this.notebook]));
			w12.Position = 1;
			this.Add (this.vbox);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			w1.SetUiManager (UIManager);
			this.Hide ();
		}
	}
}
