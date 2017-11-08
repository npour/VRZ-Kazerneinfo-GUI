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

            //Placeholder widgets.
            var newsLabel = new Label ("News label.");        
            newsLabel.Show ();

            var newsTabel = new NewsMessageView ();
            //newsTabel.Sensitive = false;
            newsTabel.Show ();

            var weatherLabel = new Label ("Weather label.");
            weatherLabel.Show ();

            this.clockLabel = new ClockLabel ();
            this.clockLabel.Show ();

            var birthdayLabel = new Label ("Birthdays label.");
            birthdayLabel.Show ();

            var traficLabel = new Label ("Trafic label.");
            traficLabel.Show ();

            //widget grid initialisation.
            var mainHbox = new HBox (); //divides the window vertically into n parts. (for our application two parts).
            mainHbox.Add (newsTabel);
            mainHbox.Show ();
            var rightSideVbox = new VBox (); //divides the right part horizontally into n rows. 
            rightSideVbox.Show ();
            mainHbox.Add (rightSideVbox);
            mainHbox.ModifyBg(StateType.Normal, new Gdk.Color (0, 0, 0));
            mainHbox.ModifyFg(StateType.Normal, new Gdk.Color (0, 0, 0));
            var weatherAndTimeHbox = new HBox ();
            weatherAndTimeHbox.Add (weatherLabel);
            weatherAndTimeHbox.Add (this.clockLabel);
            weatherAndTimeHbox.Show ();
            rightSideVbox.Add (weatherAndTimeHbox);
            rightSideVbox.Add (birthdayLabel);
            rightSideVbox.Add (traficLabel);

            //Add the grid to the window.
            this.Add (mainHbox);

            base.ModifyBg (StateType.Normal, new Gdk.Color (0, 0, 0));

            newsTabel.newsMessageListStore.AppendValues ("Klaas", "12-11-2017", "Ik neem een maandje vrij.");
            newsTabel.newsMessageListStore.AppendValues ("Henkie", "11-11-2017", "Ik ben het helemaal beu, ik stop.");

        }

        protected void OnDeleteEvent (object sender, DeleteEventArgs a)
        {
            Application.Quit ();
            a.RetVal = true;
        }
    }

}
