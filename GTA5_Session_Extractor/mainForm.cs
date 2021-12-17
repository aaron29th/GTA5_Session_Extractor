﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTA5_Session_Extractor
{
	public partial class mainForm : Form
	{
		public mainForm()
		{
			InitializeComponent();

			Output.outputTextbox = outputTextbox;

			Output.write("Version: {0}", Variables.versionStr);

			Functions.checkUpdates();
		}

		private void copySessionBtn_Click(object sender, EventArgs e)
		{
			Session s = Session.extractFromRunningGame();
			if (s == null)
				return;

			Clipboard.SetText(s.serialize());
			Output.write("Session details copied to clipboard");
		}

		private void outputTextbox_LinkClicked(object sender, LinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(e.LinkText);
		}
	}
}
