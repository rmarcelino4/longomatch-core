// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace LongoMatch.Widgets.Dialog {
    
    
    public partial class DBManager {
        
        private Gtk.VBox dialog1_VBox1;
        
        private Gtk.HBox hbox2;
        
        private LongoMatch.Widgets.Component.ProjectListWidget projectlistwidget1;
        
        private Gtk.VBox vbox2;
        
        private Gtk.Frame frame1;
        
        private Gtk.Alignment GtkAlignment2;
        
        private LongoMatch.Widgets.Component.FileDescriptionWidget filedescriptionwidget3;
        
        private Gtk.Label GtkLabel6;
        
        private Gtk.Button saveButton;
        
        private Gtk.Button deleteButton;
        
        private Gtk.HSeparator hseparator3;
        
        private Gtk.Button buttonOk;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget LongoMatch.Widgets.Dialog.DBManager
            this.Name = "LongoMatch.Widgets.Dialog.DBManager";
            this.Title = Mono.Unix.Catalog.GetString("DataBase Manager");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.Modal = true;
            this.DestroyWithParent = true;
            this.Gravity = ((Gdk.Gravity)(5));
            this.SkipPagerHint = true;
            this.SkipTaskbarHint = true;
            this.HasSeparator = false;
            // Internal child LongoMatch.Widgets.Dialog.DBManager.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.dialog1_VBox1 = new Gtk.VBox();
            this.dialog1_VBox1.Name = "dialog1_VBox1";
            this.dialog1_VBox1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox1.Gtk.Box+BoxChild
            this.hbox2 = new Gtk.HBox();
            this.hbox2.Name = "hbox2";
            this.hbox2.Spacing = 6;
            // Container child hbox2.Gtk.Box+BoxChild
            this.projectlistwidget1 = new LongoMatch.Widgets.Component.ProjectListWidget();
            this.projectlistwidget1.Events = ((Gdk.EventMask)(256));
            this.projectlistwidget1.Name = "projectlistwidget1";
            this.hbox2.Add(this.projectlistwidget1);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox2[this.projectlistwidget1]));
            w2.Position = 0;
            // Container child hbox2.Gtk.Box+BoxChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            // Container child vbox2.Gtk.Box+BoxChild
            this.frame1 = new Gtk.Frame();
            this.frame1.Name = "frame1";
            this.frame1.ShadowType = ((Gtk.ShadowType)(0));
            // Container child frame1.Gtk.Container+ContainerChild
            this.GtkAlignment2 = new Gtk.Alignment(0F, 0F, 1F, 1F);
            this.GtkAlignment2.Name = "GtkAlignment2";
            this.GtkAlignment2.LeftPadding = ((uint)(12));
            // Container child GtkAlignment2.Gtk.Container+ContainerChild
            this.filedescriptionwidget3 = new LongoMatch.Widgets.Component.FileDescriptionWidget();
            this.filedescriptionwidget3.Sensitive = false;
            this.filedescriptionwidget3.Events = ((Gdk.EventMask)(256));
            this.filedescriptionwidget3.Name = "filedescriptionwidget3";
            this.filedescriptionwidget3.LocalGoals = 0;
            this.filedescriptionwidget3.VisitorGoals = 0;
            this.filedescriptionwidget3.Date = new System.DateTime(0);
            this.GtkAlignment2.Add(this.filedescriptionwidget3);
            this.frame1.Add(this.GtkAlignment2);
            this.GtkLabel6 = new Gtk.Label();
            this.GtkLabel6.Name = "GtkLabel6";
            this.GtkLabel6.LabelProp = Mono.Unix.Catalog.GetString("<b>Propiedades</b>");
            this.GtkLabel6.UseMarkup = true;
            this.frame1.LabelWidget = this.GtkLabel6;
            this.vbox2.Add(this.frame1);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.vbox2[this.frame1]));
            w5.Position = 0;
            // Container child vbox2.Gtk.Box+BoxChild
            this.saveButton = new Gtk.Button();
            this.saveButton.Sensitive = false;
            this.saveButton.CanFocus = true;
            this.saveButton.Name = "saveButton";
            this.saveButton.UseStock = true;
            this.saveButton.UseUnderline = true;
            this.saveButton.Label = "gtk-save";
            this.vbox2.Add(this.saveButton);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.vbox2[this.saveButton]));
            w6.Position = 1;
            w6.Expand = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.deleteButton = new Gtk.Button();
            this.deleteButton.Sensitive = false;
            this.deleteButton.CanFocus = true;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.UseStock = true;
            this.deleteButton.UseUnderline = true;
            this.deleteButton.Label = "gtk-delete";
            this.vbox2.Add(this.deleteButton);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.vbox2[this.deleteButton]));
            w7.Position = 2;
            w7.Expand = false;
            w7.Fill = false;
            this.hbox2.Add(this.vbox2);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.hbox2[this.vbox2]));
            w8.Position = 1;
            w8.Expand = false;
            w8.Fill = false;
            this.dialog1_VBox1.Add(this.hbox2);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.dialog1_VBox1[this.hbox2]));
            w9.Position = 0;
            // Container child dialog1_VBox1.Gtk.Box+BoxChild
            this.hseparator3 = new Gtk.HSeparator();
            this.hseparator3.Name = "hseparator3";
            this.dialog1_VBox1.Add(this.hseparator3);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.dialog1_VBox1[this.hseparator3]));
            w10.PackType = ((Gtk.PackType)(1));
            w10.Position = 1;
            w10.Expand = false;
            w10.Fill = false;
            w1.Add(this.dialog1_VBox1);
            Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(w1[this.dialog1_VBox1]));
            w11.Position = 0;
            // Internal child LongoMatch.Widgets.Dialog.DBManager.ActionArea
            Gtk.HButtonBox w12 = this.ActionArea;
            w12.Name = "dialog1_ActionArea";
            w12.Spacing = 6;
            w12.BorderWidth = ((uint)(5));
            w12.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonOk = new Gtk.Button();
            this.buttonOk.CanDefault = true;
            this.buttonOk.CanFocus = true;
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseStock = true;
            this.buttonOk.UseUnderline = true;
            this.buttonOk.Label = "gtk-quit";
            this.AddActionWidget(this.buttonOk, 0);
            Gtk.ButtonBox.ButtonBoxChild w13 = ((Gtk.ButtonBox.ButtonBoxChild)(w12[this.buttonOk]));
            w13.Expand = false;
            w13.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 1024;
            this.DefaultHeight = 512;
            this.Show();
            this.projectlistwidget1.ProjectSelectedEvent += new LongoMatch.Widgets.Component.ProjectSelectedHandler(this.OnFiledatalistwidget1ProjectSelectedEvent);
            this.saveButton.Pressed += new System.EventHandler(this.OnSaveButtonPressed);
            this.deleteButton.Pressed += new System.EventHandler(this.OnDeleteButtonPressed);
            this.buttonOk.Clicked += new System.EventHandler(this.OnButtonOkClicked);
        }
    }
}
