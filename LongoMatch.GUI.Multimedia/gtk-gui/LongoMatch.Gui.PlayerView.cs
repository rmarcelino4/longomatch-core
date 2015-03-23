
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui
{
	public partial class PlayerView
	{
		private global::Gtk.VBox vbox3;
		
		private global::Gtk.HBox mainbox;
		
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.HBox videobox;
		
		private global::Gtk.HBox hbox2;
		
		private global::LongoMatch.Gui.VideoWindow videowindow;
		
		private global::Gtk.DrawingArea blackboarddrawingarea;
		
		private global::Gtk.VBox vbox5;
		
		private global::Gtk.VScale ratescale;
		
		private global::Gtk.EventBox lightbackgroundeventbox;
		
		private global::Gtk.HBox controlsbox;
		
		private global::Gtk.HBox buttonsbox;
		
		private global::Gtk.Button closebutton;
		
		private global::Gtk.Image closebuttonimage;
		
		private global::Gtk.Button drawbutton;
		
		private global::Gtk.Image drawbuttonimage;
		
		private global::Gtk.Button playbutton;
		
		private global::Gtk.Image playbuttonimage;
		
		private global::Gtk.Button pausebutton;
		
		private global::Gtk.Image pausebuttonimage;
		
		private global::Gtk.Button prevbutton;
		
		private global::Gtk.Image prevbuttonimage;
		
		private global::Gtk.Button nextbutton;
		
		private global::Gtk.Image nextbuttonimage;
		
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.Label jumplabel;
		
		private global::Gtk.SpinButton jumpspinbutton;
		
		private global::Gtk.Label tlabel;
		
		private global::Gtk.HScale timescale;
		
		private global::Gtk.Label timelabel;
		
		private global::Gtk.Button volumebutton;
		
		private global::Gtk.Image volumebuttonimage;
		
		private global::Gtk.Button detachbutton;
		
		private global::Gtk.Image detachbuttonimage;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.PlayerView
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LongoMatch.Gui.PlayerView";
			// Container child LongoMatch.Gui.PlayerView.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.mainbox = new global::Gtk.HBox ();
			this.mainbox.Name = "mainbox";
			this.mainbox.Spacing = 6;
			// Container child mainbox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.videobox = new global::Gtk.HBox ();
			this.videobox.Name = "videobox";
			this.videobox.Spacing = 6;
			// Container child videobox.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			// Container child hbox2.Gtk.Box+BoxChild
			this.videowindow = new global::LongoMatch.Gui.VideoWindow ();
			this.videowindow.Events = ((global::Gdk.EventMask)(256));
			this.videowindow.Name = "videowindow";
			this.videowindow.Ready = false;
			this.hbox2.Add (this.videowindow);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.videowindow]));
			w1.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.blackboarddrawingarea = new global::Gtk.DrawingArea ();
			this.blackboarddrawingarea.Name = "blackboarddrawingarea";
			this.hbox2.Add (this.blackboarddrawingarea);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.blackboarddrawingarea]));
			w2.Position = 1;
			this.videobox.Add (this.hbox2);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.videobox [this.hbox2]));
			w3.Position = 0;
			this.vbox2.Add (this.videobox);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.videobox]));
			w4.Position = 0;
			this.mainbox.Add (this.vbox2);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.mainbox [this.vbox2]));
			w5.Position = 0;
			// Container child mainbox.Gtk.Box+BoxChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.ratescale = new global::Gtk.VScale (null);
			this.ratescale.TooltipMarkup = "Playback speed";
			this.ratescale.WidthRequest = 36;
			this.ratescale.Sensitive = false;
			this.ratescale.Name = "ratescale";
			this.ratescale.UpdatePolicy = ((global::Gtk.UpdateType)(1));
			this.ratescale.Inverted = true;
			this.ratescale.Adjustment.Lower = 1;
			this.ratescale.Adjustment.Upper = 30;
			this.ratescale.Adjustment.PageIncrement = 3;
			this.ratescale.Adjustment.PageSize = 1;
			this.ratescale.Adjustment.StepIncrement = 1;
			this.ratescale.Adjustment.Value = 25;
			this.ratescale.DrawValue = true;
			this.ratescale.Digits = 0;
			this.ratescale.ValuePos = ((global::Gtk.PositionType)(3));
			this.vbox5.Add (this.ratescale);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.ratescale]));
			w6.Position = 0;
			this.mainbox.Add (this.vbox5);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.mainbox [this.vbox5]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			this.vbox3.Add (this.mainbox);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.mainbox]));
			w8.Position = 0;
			// Container child vbox3.Gtk.Box+BoxChild
			this.lightbackgroundeventbox = new global::Gtk.EventBox ();
			this.lightbackgroundeventbox.Name = "lightbackgroundeventbox";
			// Container child lightbackgroundeventbox.Gtk.Container+ContainerChild
			this.controlsbox = new global::Gtk.HBox ();
			this.controlsbox.Name = "controlsbox";
			this.controlsbox.Spacing = 6;
			// Container child controlsbox.Gtk.Box+BoxChild
			this.buttonsbox = new global::Gtk.HBox ();
			this.buttonsbox.Name = "buttonsbox";
			this.buttonsbox.Homogeneous = true;
			// Container child buttonsbox.Gtk.Box+BoxChild
			this.closebutton = new global::Gtk.Button ();
			this.closebutton.TooltipMarkup = "Close loaded event";
			this.closebutton.Name = "closebutton";
			this.closebutton.Relief = ((global::Gtk.ReliefStyle)(2));
			// Container child closebutton.Gtk.Container+ContainerChild
			this.closebuttonimage = new global::Gtk.Image ();
			this.closebuttonimage.Name = "closebuttonimage";
			this.closebutton.Add (this.closebuttonimage);
			this.buttonsbox.Add (this.closebutton);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.buttonsbox [this.closebutton]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child buttonsbox.Gtk.Box+BoxChild
			this.drawbutton = new global::Gtk.Button ();
			this.drawbutton.TooltipMarkup = "Draw frame";
			this.drawbutton.Name = "drawbutton";
			this.drawbutton.Relief = ((global::Gtk.ReliefStyle)(2));
			// Container child drawbutton.Gtk.Container+ContainerChild
			this.drawbuttonimage = new global::Gtk.Image ();
			this.drawbuttonimage.Name = "drawbuttonimage";
			this.drawbutton.Add (this.drawbuttonimage);
			this.buttonsbox.Add (this.drawbutton);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.buttonsbox [this.drawbutton]));
			w12.Position = 1;
			w12.Expand = false;
			w12.Fill = false;
			// Container child buttonsbox.Gtk.Box+BoxChild
			this.playbutton = new global::Gtk.Button ();
			this.playbutton.TooltipMarkup = "Play";
			this.playbutton.Name = "playbutton";
			this.playbutton.Relief = ((global::Gtk.ReliefStyle)(2));
			// Container child playbutton.Gtk.Container+ContainerChild
			this.playbuttonimage = new global::Gtk.Image ();
			this.playbuttonimage.Name = "playbuttonimage";
			this.playbutton.Add (this.playbuttonimage);
			this.buttonsbox.Add (this.playbutton);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.buttonsbox [this.playbutton]));
			w14.Position = 2;
			w14.Expand = false;
			w14.Fill = false;
			// Container child buttonsbox.Gtk.Box+BoxChild
			this.pausebutton = new global::Gtk.Button ();
			this.pausebutton.TooltipMarkup = "Pause";
			this.pausebutton.Name = "pausebutton";
			this.pausebutton.Relief = ((global::Gtk.ReliefStyle)(2));
			// Container child pausebutton.Gtk.Container+ContainerChild
			this.pausebuttonimage = new global::Gtk.Image ();
			this.pausebuttonimage.Name = "pausebuttonimage";
			this.pausebutton.Add (this.pausebuttonimage);
			this.buttonsbox.Add (this.pausebutton);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.buttonsbox [this.pausebutton]));
			w16.Position = 3;
			w16.Expand = false;
			w16.Fill = false;
			// Container child buttonsbox.Gtk.Box+BoxChild
			this.prevbutton = new global::Gtk.Button ();
			this.prevbutton.TooltipMarkup = "Previous";
			this.prevbutton.Name = "prevbutton";
			this.prevbutton.Relief = ((global::Gtk.ReliefStyle)(2));
			// Container child prevbutton.Gtk.Container+ContainerChild
			this.prevbuttonimage = new global::Gtk.Image ();
			this.prevbuttonimage.Name = "prevbuttonimage";
			this.prevbutton.Add (this.prevbuttonimage);
			this.buttonsbox.Add (this.prevbutton);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.buttonsbox [this.prevbutton]));
			w18.Position = 4;
			w18.Expand = false;
			w18.Fill = false;
			// Container child buttonsbox.Gtk.Box+BoxChild
			this.nextbutton = new global::Gtk.Button ();
			this.nextbutton.TooltipMarkup = "Next";
			this.nextbutton.Sensitive = false;
			this.nextbutton.Name = "nextbutton";
			this.nextbutton.Relief = ((global::Gtk.ReliefStyle)(2));
			// Container child nextbutton.Gtk.Container+ContainerChild
			this.nextbuttonimage = new global::Gtk.Image ();
			this.nextbuttonimage.Name = "nextbuttonimage";
			this.nextbutton.Add (this.nextbuttonimage);
			this.buttonsbox.Add (this.nextbutton);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.buttonsbox [this.nextbutton]));
			w20.Position = 5;
			w20.Expand = false;
			w20.Fill = false;
			this.controlsbox.Add (this.buttonsbox);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.controlsbox [this.buttonsbox]));
			w21.Position = 0;
			w21.Expand = false;
			w21.Fill = false;
			// Container child controlsbox.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.jumplabel = new global::Gtk.Label ();
			this.jumplabel.Name = "jumplabel";
			this.jumplabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Jump (s):");
			this.hbox1.Add (this.jumplabel);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.jumplabel]));
			w22.Position = 0;
			w22.Expand = false;
			w22.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.jumpspinbutton = new global::Gtk.SpinButton (1, 100, 1);
			this.jumpspinbutton.TooltipMarkup = "Jump in seconds. Hold the Shift key with the direction keys to activate it.";
			this.jumpspinbutton.Name = "jumpspinbutton";
			this.jumpspinbutton.Adjustment.PageIncrement = 10;
			this.jumpspinbutton.ClimbRate = 1;
			this.jumpspinbutton.Numeric = true;
			this.jumpspinbutton.Value = 10;
			this.hbox1.Add (this.jumpspinbutton);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.jumpspinbutton]));
			w23.Position = 1;
			w23.Expand = false;
			w23.Fill = false;
			this.controlsbox.Add (this.hbox1);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.controlsbox [this.hbox1]));
			w24.Position = 1;
			w24.Expand = false;
			w24.Fill = false;
			// Container child controlsbox.Gtk.Box+BoxChild
			this.tlabel = new global::Gtk.Label ();
			this.tlabel.Name = "tlabel";
			this.tlabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Time:");
			this.controlsbox.Add (this.tlabel);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.controlsbox [this.tlabel]));
			w25.Position = 2;
			w25.Expand = false;
			w25.Fill = false;
			// Container child controlsbox.Gtk.Box+BoxChild
			this.timescale = new global::Gtk.HScale (null);
			this.timescale.Name = "timescale";
			this.timescale.Adjustment.Upper = 1;
			this.timescale.Adjustment.PageIncrement = 1;
			this.timescale.Adjustment.StepIncrement = 1;
			this.timescale.DrawValue = false;
			this.timescale.Digits = 0;
			this.timescale.ValuePos = ((global::Gtk.PositionType)(2));
			this.controlsbox.Add (this.timescale);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.controlsbox [this.timescale]));
			w26.Position = 3;
			// Container child controlsbox.Gtk.Box+BoxChild
			this.timelabel = new global::Gtk.Label ();
			this.timelabel.Name = "timelabel";
			this.controlsbox.Add (this.timelabel);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.controlsbox [this.timelabel]));
			w27.Position = 4;
			w27.Expand = false;
			// Container child controlsbox.Gtk.Box+BoxChild
			this.volumebutton = new global::Gtk.Button ();
			this.volumebutton.TooltipMarkup = "Volume";
			this.volumebutton.Name = "volumebutton";
			this.volumebutton.Relief = ((global::Gtk.ReliefStyle)(2));
			// Container child volumebutton.Gtk.Container+ContainerChild
			this.volumebuttonimage = new global::Gtk.Image ();
			this.volumebuttonimage.Name = "volumebuttonimage";
			this.volumebutton.Add (this.volumebuttonimage);
			this.controlsbox.Add (this.volumebutton);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.controlsbox [this.volumebutton]));
			w29.Position = 5;
			w29.Expand = false;
			w29.Fill = false;
			// Container child controlsbox.Gtk.Box+BoxChild
			this.detachbutton = new global::Gtk.Button ();
			this.detachbutton.TooltipMarkup = "Detach window";
			this.detachbutton.Name = "detachbutton";
			this.detachbutton.Relief = ((global::Gtk.ReliefStyle)(2));
			// Container child detachbutton.Gtk.Container+ContainerChild
			this.detachbuttonimage = new global::Gtk.Image ();
			this.detachbuttonimage.Name = "detachbuttonimage";
			this.detachbutton.Add (this.detachbuttonimage);
			this.controlsbox.Add (this.detachbutton);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.controlsbox [this.detachbutton]));
			w31.Position = 6;
			w31.Expand = false;
			w31.Fill = false;
			this.lightbackgroundeventbox.Add (this.controlsbox);
			this.vbox3.Add (this.lightbackgroundeventbox);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.lightbackgroundeventbox]));
			w33.Position = 1;
			w33.Expand = false;
			w33.Fill = false;
			this.Add (this.vbox3);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.videowindow.Hide ();
			this.blackboarddrawingarea.Hide ();
			this.closebutton.Hide ();
			this.prevbutton.Hide ();
			this.nextbutton.Hide ();
			this.controlsbox.Hide ();
			this.Show ();
		}
	}
}
