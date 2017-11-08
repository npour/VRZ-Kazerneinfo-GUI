using System;
using System.Collections.Generic;
using Gtk;

namespace VRZKazerneInfo
{
	/// <summary>
	/// Main class where the program is executed
	/// </summary>
	class MainClass
	{
		public static void Main(string[] args)
		{
            // TODO: Look at domain model pattern
            //       and look at ways to implement this
			Application.Init();
			MainWindow win = new MainWindow("klok");
            MqttUpdater updater = new MqttUpdater (win);
			win.Show();
			Application.Run();
		}
	}
}