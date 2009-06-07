// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace LongoMatch.Gui.Dialog {
    
    
    public partial class VideoEditionProperties {
        
        private Gtk.VBox vbox2;
        
        private Gtk.HBox hbox1;
        
        private Gtk.Label filenamelabel;
        
        private Gtk.HBox hbox3;
        
        private Gtk.Entry fileentry;
        
        private Gtk.Button openbutton;
        
        private Gtk.HBox hbox2;
        
        private Gtk.Label label1;
        
        private Gtk.ComboBox combobox1;
        
        private Gtk.HBox hbox4;
        
        private Gtk.Label label2;
        
        private Gtk.ComboBox combobox2;
        
        private Gtk.HBox hbox5;
        
        private Gtk.CheckButton descriptioncheckbutton;
        
        private Gtk.CheckButton audiocheckbutton;
        
        private Gtk.Button buttonCancel;
        
        private Gtk.Button buttonOk;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget LongoMatch.Gui.Dialog.VideoEditionProperties
            this.Name = "LongoMatch.Gui.Dialog.VideoEditionProperties";
            this.Title = Mono.Unix.Catalog.GetString("Video Properties");
            this.Icon = Gdk.Pixbuf.LoadFromResource("longomatch_logo.png");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.Modal = true;
            this.Gravity = ((Gdk.Gravity)(5));
            this.SkipPagerHint = true;
            this.SkipTaskbarHint = true;
            this.HasSeparator = false;
            // Internal child LongoMatch.Gui.Dialog.VideoEditionProperties.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            // Container child vbox2.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.filenamelabel = new Gtk.Label();
            this.filenamelabel.Name = "filenamelabel";
            this.filenamelabel.LabelProp = Mono.Unix.Catalog.GetString("File name: ");
            this.hbox1.Add(this.filenamelabel);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox1[this.filenamelabel]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.hbox3 = new Gtk.HBox();
            this.hbox3.Name = "hbox3";
            this.hbox3.Spacing = 6;
            // Container child hbox3.Gtk.Box+BoxChild
            this.fileentry = new Gtk.Entry();
            this.fileentry.CanFocus = true;
            this.fileentry.Name = "fileentry";
            this.fileentry.IsEditable = false;
            this.fileentry.InvisibleChar = '●';
            this.hbox3.Add(this.fileentry);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.hbox3[this.fileentry]));
            w3.Position = 0;
            // Container child hbox3.Gtk.Box+BoxChild
            this.openbutton = new Gtk.Button();
            this.openbutton.CanFocus = true;
            this.openbutton.Name = "openbutton";
            this.openbutton.UseStock = true;
            this.openbutton.UseUnderline = true;
            this.openbutton.Label = "gtk-save-as";
            this.hbox3.Add(this.openbutton);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.hbox3[this.openbutton]));
            w4.Position = 1;
            w4.Expand = false;
            w4.Fill = false;
            this.hbox1.Add(this.hbox3);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.hbox1[this.hbox3]));
            w5.Position = 1;
            this.vbox2.Add(this.hbox1);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
            w6.Position = 0;
            w6.Expand = false;
            w6.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.hbox2 = new Gtk.HBox();
            this.hbox2.Name = "hbox2";
            this.hbox2.Homogeneous = true;
            this.hbox2.Spacing = 6;
            // Container child hbox2.Gtk.Box+BoxChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.Xalign = 0F;
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("Video Quality:");
            this.hbox2.Add(this.label1);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.hbox2[this.label1]));
            w7.Position = 0;
            // Container child hbox2.Gtk.Box+BoxChild
            this.combobox1 = Gtk.ComboBox.NewText();
            this.combobox1.AppendText(Mono.Unix.Catalog.GetString("Low"));
            this.combobox1.AppendText(Mono.Unix.Catalog.GetString("Normal"));
            this.combobox1.AppendText(Mono.Unix.Catalog.GetString("Good"));
            this.combobox1.AppendText(Mono.Unix.Catalog.GetString("Extra"));
            this.combobox1.Name = "combobox1";
            this.combobox1.Active = 2;
            this.hbox2.Add(this.combobox1);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.hbox2[this.combobox1]));
            w8.Position = 1;
            this.vbox2.Add(this.hbox2);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
            w9.Position = 1;
            w9.Expand = false;
            w9.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.hbox4 = new Gtk.HBox();
            this.hbox4.Name = "hbox4";
            this.hbox4.Homogeneous = true;
            this.hbox4.Spacing = 6;
            // Container child hbox4.Gtk.Box+BoxChild
            this.label2 = new Gtk.Label();
            this.label2.Name = "label2";
            this.label2.Xalign = 0F;
            this.label2.LabelProp = Mono.Unix.Catalog.GetString("Format: ");
            this.hbox4.Add(this.label2);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.hbox4[this.label2]));
            w10.Position = 0;
            // Container child hbox4.Gtk.Box+BoxChild
            this.combobox2 = Gtk.ComboBox.NewText();
            this.combobox2.AppendText(Mono.Unix.Catalog.GetString("TV (4:3 - 720x540)"));
            this.combobox2.AppendText(Mono.Unix.Catalog.GetString("HD 720p (16:9 - 1280x720)"));
            this.combobox2.AppendText(Mono.Unix.Catalog.GetString("Full HD 1080p (16:9 - 1920x1080)"));
            this.combobox2.Name = "combobox2";
            this.combobox2.Active = 0;
            this.hbox4.Add(this.combobox2);
            Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.hbox4[this.combobox2]));
            w11.Position = 1;
            this.vbox2.Add(this.hbox4);
            Gtk.Box.BoxChild w12 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox4]));
            w12.Position = 2;
            w12.Expand = false;
            w12.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.hbox5 = new Gtk.HBox();
            this.hbox5.Name = "hbox5";
            this.hbox5.Spacing = 6;
            // Container child hbox5.Gtk.Box+BoxChild
            this.descriptioncheckbutton = new Gtk.CheckButton();
            this.descriptioncheckbutton.CanFocus = true;
            this.descriptioncheckbutton.Name = "descriptioncheckbutton";
            this.descriptioncheckbutton.Label = Mono.Unix.Catalog.GetString("Enable Title Overlay");
            this.descriptioncheckbutton.Active = true;
            this.descriptioncheckbutton.DrawIndicator = true;
            this.descriptioncheckbutton.UseUnderline = true;
            this.hbox5.Add(this.descriptioncheckbutton);
            Gtk.Box.BoxChild w13 = ((Gtk.Box.BoxChild)(this.hbox5[this.descriptioncheckbutton]));
            w13.Position = 0;
            // Container child hbox5.Gtk.Box+BoxChild
            this.audiocheckbutton = new Gtk.CheckButton();
            this.audiocheckbutton.CanFocus = true;
            this.audiocheckbutton.Name = "audiocheckbutton";
            this.audiocheckbutton.Label = Mono.Unix.Catalog.GetString("Enable Sound");
            this.audiocheckbutton.Active = true;
            this.audiocheckbutton.DrawIndicator = true;
            this.audiocheckbutton.UseUnderline = true;
            this.hbox5.Add(this.audiocheckbutton);
            Gtk.Box.BoxChild w14 = ((Gtk.Box.BoxChild)(this.hbox5[this.audiocheckbutton]));
            w14.Position = 1;
            this.vbox2.Add(this.hbox5);
            Gtk.Box.BoxChild w15 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox5]));
            w15.Position = 3;
            w15.Expand = false;
            w15.Fill = false;
            w1.Add(this.vbox2);
            Gtk.Box.BoxChild w16 = ((Gtk.Box.BoxChild)(w1[this.vbox2]));
            w16.Position = 0;
            w16.Expand = false;
            w16.Fill = false;
            // Internal child LongoMatch.Gui.Dialog.VideoEditionProperties.ActionArea
            Gtk.HButtonBox w17 = this.ActionArea;
            w17.Name = "dialog1_ActionArea";
            w17.Spacing = 6;
            w17.BorderWidth = ((uint)(5));
            w17.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonCancel = new Gtk.Button();
            this.buttonCancel.CanDefault = true;
            this.buttonCancel.CanFocus = true;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseStock = true;
            this.buttonCancel.UseUnderline = true;
            this.buttonCancel.Label = "gtk-cancel";
            this.AddActionWidget(this.buttonCancel, -6);
            Gtk.ButtonBox.ButtonBoxChild w18 = ((Gtk.ButtonBox.ButtonBoxChild)(w17[this.buttonCancel]));
            w18.Expand = false;
            w18.Fill = false;
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonOk = new Gtk.Button();
            this.buttonOk.CanDefault = true;
            this.buttonOk.CanFocus = true;
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseStock = true;
            this.buttonOk.UseUnderline = true;
            this.buttonOk.Label = "gtk-ok";
            this.AddActionWidget(this.buttonOk, -5);
            Gtk.ButtonBox.ButtonBoxChild w19 = ((Gtk.ButtonBox.ButtonBoxChild)(w17[this.buttonOk]));
            w19.Position = 1;
            w19.Expand = false;
            w19.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 514;
            this.DefaultHeight = 181;
            this.Show();
            this.openbutton.Clicked += new System.EventHandler(this.OnOpenbuttonClicked);
            this.buttonOk.Clicked += new System.EventHandler(this.OnButtonOkClicked);
        }
    }
}
