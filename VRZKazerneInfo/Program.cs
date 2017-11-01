using System;
using Gtk;

namespace VRZKazerneInfo
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Application.Init();
			MainWindow win = new MainWindow("klok");
			win.Show();
			Application.Run();
		}
	}
}