using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTA5_Session_Extractor
{
	static class Output
	{
		public static RichTextBox outputTextbox = null;

		public static void write(string text)
		{
			if (outputTextbox == null) return;

			outputTextbox.Text = "[ " + DateTime.Now.ToString("H:mm:ss") + " ] " + text + Environment.NewLine + outputTextbox.Text;
		}

		public static void write(string formatStr, params object[] args)
		{
			write(String.Format(formatStr, args));
		}
	}
}
