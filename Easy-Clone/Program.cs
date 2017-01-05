using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Easy_Clone
{
	public class Program
	{
		[STAThread]
		public static void Main()
		{
			try
			{
				var clipboard = (string) Clipboard.GetData(DataFormats.UnicodeText);
				var reponame = clipboard.Split('/');
				var path = Application.StartupPath + "\\" + reponame.Last().Replace(".git", "");
				Process.Start("cmd.exe",
					" /k git clone " + clipboard + " " +
					path + " && exit");
			}
			catch (Exception e)
			{
				MessageBox.Show("Please make sure you have text in clipboard. " + e.Message);
			}
			finally
			{
				Environment.Exit(0);
			}
		}

		public void Test()
		{
			
		}
	}
}
