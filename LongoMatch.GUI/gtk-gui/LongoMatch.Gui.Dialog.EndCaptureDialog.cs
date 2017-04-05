
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Dialog
{
	public partial class EndCaptureDialog
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Image image439;

		private global::Gtk.Label label1;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Button returnbutton;

		private global::Gtk.Button quitbutton;

		private global::Gtk.Button savebutton;

		private global::Gtk.Button buttonCancel;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Dialog.EndCaptureDialog
			this.Name = "LongoMatch.Gui.Dialog.EndCaptureDialog";
			this.Title = "";
			this.Icon = global::Stetic.IconLoader.LoadIcon (this, "longomatch", global::Gtk.IconSize.Menu);
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			// Internal child LongoMatch.Gui.Dialog.EndCaptureDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.image439 = new global::Gtk.Image ();
			this.image439.Name = "image439";
			this.image439.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "stock_dialog-question", global::Gtk.IconSize.Dialog);
			this.hbox2.Add (this.image439);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.image439]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::VAS.Core.Catalog.GetString ("A capture project is actually running.\nYou can continue with the current capture, cancel it or save your project. \n\n<b>Warning: If you cancel the current project all your changes will be lost.</b>");
			this.label1.UseMarkup = true;
			this.label1.Justify = ((global::Gtk.Justification)(2));
			this.hbox2.Add (this.label1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label1]));
			w3.Position = 1;
			this.vbox2.Add (this.hbox2);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox2]));
			w4.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.returnbutton = new global::Gtk.Button ();
			this.returnbutton.CanFocus = true;
			this.returnbutton.Name = "returnbutton";
			this.returnbutton.UseUnderline = true;
			this.returnbutton.Label = global::VAS.Core.Catalog.GetString ("Return");
			global::Gtk.Image w5 = new global::Gtk.Image ();
			w5.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-undo", global::Gtk.IconSize.Button);
			this.returnbutton.Image = w5;
			this.hbox3.Add (this.returnbutton);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.returnbutton]));
			w6.Position = 0;
			w6.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.quitbutton = new global::Gtk.Button ();
			this.quitbutton.CanFocus = true;
			this.quitbutton.Name = "quitbutton";
			this.quitbutton.UseUnderline = true;
			this.quitbutton.Label = global::VAS.Core.Catalog.GetString ("Cancel capture");
			global::Gtk.Image w7 = new global::Gtk.Image ();
			w7.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-cancel", global::Gtk.IconSize.Button);
			this.quitbutton.Image = w7;
			this.hbox3.Add (this.quitbutton);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.quitbutton]));
			w8.Position = 1;
			w8.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.savebutton = new global::Gtk.Button ();
			this.savebutton.CanFocus = true;
			this.savebutton.Name = "savebutton";
			this.savebutton.UseUnderline = true;
			this.savebutton.Label = global::VAS.Core.Catalog.GetString ("Stop capture and save project");
			global::Gtk.Image w9 = new global::Gtk.Image ();
			w9.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-save", global::Gtk.IconSize.Button);
			this.savebutton.Image = w9;
			this.hbox3.Add (this.savebutton);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.savebutton]));
			w10.Position = 2;
			w10.Fill = false;
			this.vbox2.Add (this.hbox3);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox3]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			w1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox2]));
			w12.Position = 0;
			// Internal child LongoMatch.Gui.Dialog.EndCaptureDialog.ActionArea
			global::Gtk.HButtonBox w13 = this.ActionArea;
			w13.Sensitive = false;
			w13.Name = "dialog1_ActionArea";
			w13.Spacing = 6;
			w13.BorderWidth = ((uint)(5));
			w13.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w14 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w13 [this.buttonCancel]));
			w14.Expand = false;
			w14.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 566;
			this.DefaultHeight = 178;
			w13.Hide ();
			this.Show ();
			this.returnbutton.Clicked += new global::System.EventHandler (this.OnQuit);
			this.quitbutton.Clicked += new global::System.EventHandler (this.OnQuit);
			this.savebutton.Clicked += new global::System.EventHandler (this.OnQuit);
		}
	}
}
