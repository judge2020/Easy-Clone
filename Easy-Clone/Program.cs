using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easy_Clone
{
	static class Program
	{
		static void Main()
		{


			try
			{
				Process.Start("cmd.exe",
					" /k 'git clone " + Clipboard.GetText(TextDataFormat.Text) + " " +
					System.Reflection.Assembly.GetEntryAssembly().Location);

			}
			catch(Exception e)
			{

				MessageBox.Show("Please make sure you have text in clipboard." + e.Message);
			}
			while ( Console.ReadLine() == "")
			{
				
			}
		}
	}
}
