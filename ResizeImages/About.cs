using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResizeImages
{
	public partial class About : Form
	{
		public About()
		{
			InitializeComponent();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void linkLabelHomePage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.linkLabelHomePage.LinkVisited = true;

			System.Diagnostics.Process.Start("http://www.dajimenezc.com.mx/");
		}
    }
}
