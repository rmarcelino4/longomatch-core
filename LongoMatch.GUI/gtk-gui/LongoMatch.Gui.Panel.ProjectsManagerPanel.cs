
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Panel
{
	public partial class ProjectsManagerPanel
	{
		private global::Gtk.VBox vbox3;
		private global::LongoMatch.Gui.Panel.PanelHeader panelheader1;
		private global::Gtk.Alignment contentalignment;
		private global::Gtk.Notebook notebook1;
		private global::Gtk.HBox hbox4;
		private global::LongoMatch.Gui.Component.ProjectListWidget projectlistwidget1;
		private global::Gtk.VBox rbox;
		private global::Gtk.VBox descbox;
		private global::Gtk.Frame frame5;
		private global::Gtk.Alignment GtkAlignment1;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Frame frame1;
		private global::Gtk.Alignment GtkAlignment2;
		private global::Gtk.Image homeimage;
		private global::Gtk.Label homelabel;
		private global::Gtk.Frame frame2;
		private global::Gtk.Alignment GtkAlignment11;
		private global::Gtk.Image awayimage;
		private global::Gtk.Label awaylabel;
		private global::Gtk.Label GtkLabel9;
		private global::Gtk.Frame frame4;
		private global::Gtk.Alignment GtkAlignment3;
		private global::Gtk.Table table1;
		private global::Gtk.Entry competitionentry;
		private global::Gtk.Label Competitionlabel;
		private global::LongoMatch.Gui.Component.DatePicker datepicker;
		private global::Gtk.HBox hbox9;
		private global::Gtk.SpinButton localSpinButton;
		private global::Gtk.Label label2;
		private global::Gtk.SpinButton visitorSpinButton;
		private global::Gtk.Label label11;
		private global::Gtk.Label label5;
		private global::Gtk.Label label9;
		private global::Gtk.Entry seasonentry;
		private global::Gtk.Label seasonlabel;
		private global::Gtk.Label templatelabel;
		private global::Gtk.Label GtkLabel3;
		private global::Gtk.Frame frame3;
		private global::Gtk.Alignment GtkAlignment8;
		private global::Gtk.HBox hbox5;
		private global::Gtk.Image fileimage;
		private global::Gtk.VBox vbox1;
		private global::Gtk.Alignment mediafilechooseralignment;
		private global::LongoMatch.Gui.Component.MediaFileChooser mediafilechooser;
		private global::Gtk.Label medialabel;
		private global::Gtk.Label GtkLabel6;
		private global::Gtk.HButtonBox hbuttonbox1;
		private global::Gtk.Button savebutton;
		private global::Gtk.Image savebuttonimage;
		private global::Gtk.Button exportbutton;
		private global::Gtk.Image exportbuttonimage;
		private global::Gtk.Button deletebutton;
		private global::Gtk.Image deletebuttonimage;
		private global::Gtk.Label label1;
		private global::Gtk.Label label3;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Panel.ProjectsManagerPanel
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LongoMatch.Gui.Panel.ProjectsManagerPanel";
			// Container child LongoMatch.Gui.Panel.ProjectsManagerPanel.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.panelheader1 = new global::LongoMatch.Gui.Panel.PanelHeader ();
			this.panelheader1.Events = ((global::Gdk.EventMask)(256));
			this.panelheader1.Name = "panelheader1";
			this.vbox3.Add (this.panelheader1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.panelheader1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.contentalignment = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.contentalignment.Name = "contentalignment";
			this.contentalignment.LeftPadding = ((uint)(12));
			this.contentalignment.RightPadding = ((uint)(12));
			// Container child contentalignment.Gtk.Container+ContainerChild
			this.notebook1 = new global::Gtk.Notebook ();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 0;
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.projectlistwidget1 = new global::LongoMatch.Gui.Component.ProjectListWidget ();
			this.projectlistwidget1.Events = ((global::Gdk.EventMask)(256));
			this.projectlistwidget1.Name = "projectlistwidget1";
			this.hbox4.Add (this.projectlistwidget1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.projectlistwidget1]));
			w2.Position = 0;
			// Container child hbox4.Gtk.Box+BoxChild
			this.rbox = new global::Gtk.VBox ();
			this.rbox.Name = "rbox";
			this.rbox.Spacing = 6;
			// Container child rbox.Gtk.Box+BoxChild
			this.descbox = new global::Gtk.VBox ();
			this.descbox.Name = "descbox";
			this.descbox.Spacing = 15;
			// Container child descbox.Gtk.Box+BoxChild
			this.frame5 = new global::Gtk.Frame ();
			this.frame5.Name = "frame5";
			this.frame5.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame5.Gtk.Container+ContainerChild
			this.GtkAlignment1 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment1.Name = "GtkAlignment1";
			this.GtkAlignment1.LeftPadding = ((uint)(12));
			// Container child GtkAlignment1.Gtk.Container+ContainerChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.frame1 = new global::Gtk.Frame ();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(12));
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			this.homeimage = new global::Gtk.Image ();
			this.homeimage.Name = "homeimage";
			this.GtkAlignment2.Add (this.homeimage);
			this.frame1.Add (this.GtkAlignment2);
			this.homelabel = new global::Gtk.Label ();
			this.homelabel.Name = "homelabel";
			this.homelabel.UseMarkup = true;
			this.frame1.LabelWidget = this.homelabel;
			this.hbox2.Add (this.frame1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.frame1]));
			w5.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.frame2 = new global::Gtk.Frame ();
			this.frame2.Name = "frame2";
			this.frame2.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame2.Gtk.Container+ContainerChild
			this.GtkAlignment11 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment11.Name = "GtkAlignment11";
			this.GtkAlignment11.LeftPadding = ((uint)(12));
			// Container child GtkAlignment11.Gtk.Container+ContainerChild
			this.awayimage = new global::Gtk.Image ();
			this.awayimage.Name = "awayimage";
			this.GtkAlignment11.Add (this.awayimage);
			this.frame2.Add (this.GtkAlignment11);
			this.awaylabel = new global::Gtk.Label ();
			this.awaylabel.Name = "awaylabel";
			this.awaylabel.UseMarkup = true;
			this.frame2.LabelWidget = this.awaylabel;
			this.hbox2.Add (this.frame2);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.frame2]));
			w8.Position = 1;
			this.GtkAlignment1.Add (this.hbox2);
			this.frame5.Add (this.GtkAlignment1);
			this.GtkLabel9 = new global::Gtk.Label ();
			this.GtkLabel9.Name = "GtkLabel9";
			this.GtkLabel9.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Teams</b>");
			this.GtkLabel9.UseMarkup = true;
			this.frame5.LabelWidget = this.GtkLabel9;
			this.descbox.Add (this.frame5);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.descbox [this.frame5]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child descbox.Gtk.Box+BoxChild
			this.frame4 = new global::Gtk.Frame ();
			this.frame4.Name = "frame4";
			this.frame4.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame4.Gtk.Container+ContainerChild
			this.GtkAlignment3 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment3.Name = "GtkAlignment3";
			this.GtkAlignment3.LeftPadding = ((uint)(12));
			// Container child GtkAlignment3.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table (((uint)(3)), ((uint)(4)), true);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.competitionentry = new global::Gtk.Entry ();
			this.competitionentry.CanFocus = true;
			this.competitionentry.Name = "competitionentry";
			this.competitionentry.IsEditable = true;
			this.competitionentry.InvisibleChar = '●';
			this.table1.Add (this.competitionentry);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1 [this.competitionentry]));
			w12.LeftAttach = ((uint)(3));
			w12.RightAttach = ((uint)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.Competitionlabel = new global::Gtk.Label ();
			this.Competitionlabel.Name = "Competitionlabel";
			this.Competitionlabel.Xalign = 1F;
			this.Competitionlabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Competition:");
			this.table1.Add (this.Competitionlabel);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1 [this.Competitionlabel]));
			w13.LeftAttach = ((uint)(2));
			w13.RightAttach = ((uint)(3));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.datepicker = new global::LongoMatch.Gui.Component.DatePicker ();
			this.datepicker.Events = ((global::Gdk.EventMask)(256));
			this.datepicker.Name = "datepicker";
			this.datepicker.Date = new global::System.DateTime (0);
			this.table1.Add (this.datepicker);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1 [this.datepicker]));
			w14.TopAttach = ((uint)(1));
			w14.BottomAttach = ((uint)(2));
			w14.LeftAttach = ((uint)(3));
			w14.RightAttach = ((uint)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox9 = new global::Gtk.HBox ();
			this.hbox9.Name = "hbox9";
			this.hbox9.Spacing = 6;
			// Container child hbox9.Gtk.Box+BoxChild
			this.localSpinButton = new global::Gtk.SpinButton (0, 1000, 1);
			this.localSpinButton.CanFocus = true;
			this.localSpinButton.Name = "localSpinButton";
			this.localSpinButton.Adjustment.PageIncrement = 10;
			this.localSpinButton.ClimbRate = 1;
			this.localSpinButton.Numeric = true;
			this.hbox9.Add (this.localSpinButton);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox9 [this.localSpinButton]));
			w15.Position = 0;
			w15.Fill = false;
			// Container child hbox9.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("-");
			this.hbox9.Add (this.label2);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox9 [this.label2]));
			w16.Position = 1;
			w16.Expand = false;
			w16.Fill = false;
			// Container child hbox9.Gtk.Box+BoxChild
			this.visitorSpinButton = new global::Gtk.SpinButton (0, 1000, 1);
			this.visitorSpinButton.CanFocus = true;
			this.visitorSpinButton.Name = "visitorSpinButton";
			this.visitorSpinButton.Adjustment.PageIncrement = 10;
			this.visitorSpinButton.ClimbRate = 1;
			this.visitorSpinButton.Numeric = true;
			this.hbox9.Add (this.visitorSpinButton);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox9 [this.visitorSpinButton]));
			w17.Position = 2;
			w17.Fill = false;
			this.table1.Add (this.hbox9);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox9]));
			w18.TopAttach = ((uint)(1));
			w18.BottomAttach = ((uint)(2));
			w18.LeftAttach = ((uint)(1));
			w18.RightAttach = ((uint)(2));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label11 = new global::Gtk.Label ();
			this.label11.Name = "label11";
			this.label11.Xalign = 1F;
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("Score:");
			this.table1.Add (this.label11);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table1 [this.label11]));
			w19.TopAttach = ((uint)(1));
			w19.BottomAttach = ((uint)(2));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.Xalign = 1F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Date:");
			this.table1.Add (this.label5);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table1 [this.label5]));
			w20.TopAttach = ((uint)(1));
			w20.BottomAttach = ((uint)(2));
			w20.LeftAttach = ((uint)(2));
			w20.RightAttach = ((uint)(3));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.Xalign = 1F;
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("Analisys Template:");
			this.table1.Add (this.label9);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table1 [this.label9]));
			w21.TopAttach = ((uint)(2));
			w21.BottomAttach = ((uint)(3));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.seasonentry = new global::Gtk.Entry ();
			this.seasonentry.CanFocus = true;
			this.seasonentry.Name = "seasonentry";
			this.seasonentry.IsEditable = true;
			this.seasonentry.InvisibleChar = '●';
			this.table1.Add (this.seasonentry);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table1 [this.seasonentry]));
			w22.LeftAttach = ((uint)(1));
			w22.RightAttach = ((uint)(2));
			w22.XOptions = ((global::Gtk.AttachOptions)(0));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.seasonlabel = new global::Gtk.Label ();
			this.seasonlabel.Name = "seasonlabel";
			this.seasonlabel.Xalign = 1F;
			this.seasonlabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Season:");
			this.table1.Add (this.seasonlabel);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table1 [this.seasonlabel]));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.templatelabel = new global::Gtk.Label ();
			this.templatelabel.Name = "templatelabel";
			this.table1.Add (this.templatelabel);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table1 [this.templatelabel]));
			w24.TopAttach = ((uint)(2));
			w24.BottomAttach = ((uint)(3));
			w24.LeftAttach = ((uint)(1));
			w24.RightAttach = ((uint)(2));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			this.GtkAlignment3.Add (this.table1);
			this.frame4.Add (this.GtkAlignment3);
			this.GtkLabel3 = new global::Gtk.Label ();
			this.GtkLabel3.Name = "GtkLabel3";
			this.GtkLabel3.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Project details</b>");
			this.GtkLabel3.UseMarkup = true;
			this.frame4.LabelWidget = this.GtkLabel3;
			this.descbox.Add (this.frame4);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.descbox [this.frame4]));
			w27.Position = 1;
			w27.Expand = false;
			w27.Fill = false;
			// Container child descbox.Gtk.Box+BoxChild
			this.frame3 = new global::Gtk.Frame ();
			this.frame3.Name = "frame3";
			this.frame3.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame3.Gtk.Container+ContainerChild
			this.GtkAlignment8 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment8.Name = "GtkAlignment8";
			this.GtkAlignment8.LeftPadding = ((uint)(12));
			// Container child GtkAlignment8.Gtk.Container+ContainerChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.fileimage = new global::Gtk.Image ();
			this.fileimage.WidthRequest = 100;
			this.fileimage.HeightRequest = 100;
			this.fileimage.Name = "fileimage";
			this.hbox5.Add (this.fileimage);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.fileimage]));
			w28.Position = 0;
			w28.Expand = false;
			w28.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.mediafilechooseralignment = new global::Gtk.Alignment (0F, 0.5F, 0.5F, 1F);
			this.mediafilechooseralignment.Name = "mediafilechooseralignment";
			// Container child mediafilechooseralignment.Gtk.Container+ContainerChild
			this.mediafilechooser = new global::LongoMatch.Gui.Component.MediaFileChooser ();
			this.mediafilechooser.Events = ((global::Gdk.EventMask)(256));
			this.mediafilechooser.Name = "mediafilechooser";
			this.mediafilechooser.MediaFileMode = true;
			this.mediafilechooseralignment.Add (this.mediafilechooser);
			this.vbox1.Add (this.mediafilechooseralignment);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.mediafilechooseralignment]));
			w30.Position = 0;
			w30.Expand = false;
			w30.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.medialabel = new global::Gtk.Label ();
			this.medialabel.Name = "medialabel";
			this.medialabel.Xalign = 0F;
			this.medialabel.UseMarkup = true;
			this.medialabel.Ellipsize = ((global::Pango.EllipsizeMode)(3));
			this.medialabel.MaxWidthChars = 50;
			this.vbox1.Add (this.medialabel);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.medialabel]));
			w31.Position = 1;
			this.hbox5.Add (this.vbox1);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.vbox1]));
			w32.Position = 1;
			this.GtkAlignment8.Add (this.hbox5);
			this.frame3.Add (this.GtkAlignment8);
			this.GtkLabel6 = new global::Gtk.Label ();
			this.GtkLabel6.Name = "GtkLabel6";
			this.GtkLabel6.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Video file</b>");
			this.GtkLabel6.UseMarkup = true;
			this.frame3.LabelWidget = this.GtkLabel6;
			this.descbox.Add (this.frame3);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.descbox [this.frame3]));
			w35.Position = 2;
			w35.Expand = false;
			w35.Fill = false;
			this.rbox.Add (this.descbox);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.rbox [this.descbox]));
			w36.Position = 0;
			// Container child rbox.Gtk.Box+BoxChild
			this.hbuttonbox1 = new global::Gtk.HButtonBox ();
			// Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
			this.savebutton = new global::Gtk.Button ();
			this.savebutton.TooltipMarkup = "Save";
			this.savebutton.Sensitive = false;
			this.savebutton.CanFocus = true;
			this.savebutton.Name = "savebutton";
			// Container child savebutton.Gtk.Container+ContainerChild
			this.savebuttonimage = new global::Gtk.Image ();
			this.savebuttonimage.Name = "savebuttonimage";
			this.savebutton.Add (this.savebuttonimage);
			this.savebutton.Label = null;
			this.hbuttonbox1.Add (this.savebutton);
			global::Gtk.ButtonBox.ButtonBoxChild w38 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1 [this.savebutton]));
			w38.Expand = false;
			w38.Fill = false;
			// Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
			this.exportbutton = new global::Gtk.Button ();
			this.exportbutton.TooltipMarkup = "Export";
			this.exportbutton.Sensitive = false;
			this.exportbutton.CanFocus = true;
			this.exportbutton.Name = "exportbutton";
			// Container child exportbutton.Gtk.Container+ContainerChild
			this.exportbuttonimage = new global::Gtk.Image ();
			this.exportbuttonimage.Name = "exportbuttonimage";
			this.exportbutton.Add (this.exportbuttonimage);
			this.exportbutton.Label = null;
			this.hbuttonbox1.Add (this.exportbutton);
			global::Gtk.ButtonBox.ButtonBoxChild w40 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1 [this.exportbutton]));
			w40.Position = 1;
			w40.Expand = false;
			w40.Fill = false;
			// Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
			this.deletebutton = new global::Gtk.Button ();
			this.deletebutton.TooltipMarkup = "Delete";
			this.deletebutton.Sensitive = false;
			this.deletebutton.CanFocus = true;
			this.deletebutton.Name = "deletebutton";
			// Container child deletebutton.Gtk.Container+ContainerChild
			this.deletebuttonimage = new global::Gtk.Image ();
			this.deletebuttonimage.Name = "deletebuttonimage";
			this.deletebutton.Add (this.deletebuttonimage);
			this.deletebutton.Label = null;
			this.hbuttonbox1.Add (this.deletebutton);
			global::Gtk.ButtonBox.ButtonBoxChild w42 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1 [this.deletebutton]));
			w42.Position = 2;
			w42.Expand = false;
			w42.Fill = false;
			this.rbox.Add (this.hbuttonbox1);
			global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.rbox [this.hbuttonbox1]));
			w43.Position = 1;
			w43.Expand = false;
			w43.Fill = false;
			this.hbox4.Add (this.rbox);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.rbox]));
			w44.Position = 1;
			w44.Expand = false;
			w44.Fill = false;
			this.notebook1.Add (this.hbox4);
			// Notebook tab
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.notebook1.SetTabLabel (this.hbox4, this.label1);
			this.label1.ShowAll ();
			// Notebook tab
			global::Gtk.Label w46 = new global::Gtk.Label ();
			w46.Visible = true;
			this.notebook1.Add (w46);
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.notebook1.SetTabLabel (w46, this.label3);
			this.label3.ShowAll ();
			this.contentalignment.Add (this.notebook1);
			this.vbox3.Add (this.contentalignment);
			global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.contentalignment]));
			w48.Position = 1;
			this.Add (this.vbox3);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.descbox.Hide ();
			this.rbox.Hide ();
			this.Hide ();
		}
	}
}
