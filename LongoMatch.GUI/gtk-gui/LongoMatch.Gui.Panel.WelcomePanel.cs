
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Panel
{
	public partial class WelcomePanel
	{
		private global::Gtk.VBox vbox1;
		
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.Label label3;
		
		private global::Gtk.Button preferencesbutton;
		
		private global::Gtk.Alignment alignment1;
		
		private global::Gtk.Table tablewidget;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Panel.WelcomePanel
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LongoMatch.Gui.Panel.WelcomePanel";
			// Container child LongoMatch.Gui.Panel.WelcomePanel.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Preferences");
			this.hbox1.Add (this.label3);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label3]));
			w1.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.preferencesbutton = new global::Gtk.Button ();
			this.preferencesbutton.Name = "preferencesbutton";
			this.hbox1.Add (this.preferencesbutton);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.preferencesbutton]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			this.vbox1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			this.alignment1.Name = "alignment1";
			// Container child alignment1.Gtk.Container+ContainerChild
			this.tablewidget = new global::Gtk.Table (((uint)(3)), ((uint)(3)), false);
			this.tablewidget.Name = "tablewidget";
			this.tablewidget.RowSpacing = ((uint)(6));
			this.tablewidget.ColumnSpacing = ((uint)(6));
			this.alignment1.Add (this.tablewidget);
			this.vbox1.Add (this.alignment1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.alignment1]));
			w5.Position = 1;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
