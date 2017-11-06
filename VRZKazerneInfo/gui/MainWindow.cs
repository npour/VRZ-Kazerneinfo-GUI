using System;
using System.Threading;
using Gtk;
using Pango;

namespace VRZKazerneInfo
{
    public partial class MainWindow : Gtk.Window
    {
        private ClockLabel clockLabel;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        /// <param name="title">Title.</param>
        public MainWindow (string title) : base (title)
        {
            var label = new Label ("Vandaag prachtig weer");
            this.clockLabel = new ClockLabel ();

            var vbox = new VBox ();
            base.ModifyBg (StateType.Normal, new Gdk.Color (0, 0, 0));
            label.ModifyFg (StateType.Normal, new Gdk.Color (12, 237, 4));
	   
            vbox.Add (clockLabel);
            clockLabel.Show ();

            vbox.Add (label);
            label.Show ();
            this.Add (vbox);
            vbox.Show ();
        }

        protected void OnDeleteEvent (object sender, DeleteEventArgs a)
        {
            Application.Quit ();
            a.RetVal = true;
        }
    }

}
