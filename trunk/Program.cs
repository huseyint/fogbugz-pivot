using System;
using System.Windows.Forms;
using FogBugzPivot.Properties;

namespace FogBugzPivot
{
	public static class Program
	{
		[STAThread]
		public static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());

			Settings.Default.Save();
		}
	}
}