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
			Application.Init();
			MainWindow win = new MainWindow("klok");
            int[] numbers = { 1, 4, 3, 10 };
            List<int> list = new List<int> (numbers);
            Sorting.bubbleSort(list);
            System.Console.WriteLine (list);
			win.Show();
			Application.Run();
		}
	}
}