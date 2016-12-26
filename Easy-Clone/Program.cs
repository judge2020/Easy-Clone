using System;
using System.Collections.Generic;
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


			System.Diagnostics.Process process = new System.Diagnostics.Process();
			System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
			{
				WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
				FileName = "cmd.exe",
				Arguments = "/C git clone" + Clipboard.GetText()
			};
			process.StartInfo = startInfo;
			process.Start();
		}
	}
}
