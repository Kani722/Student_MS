﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_MS
{
	public partial class First : Form
	{
		public First()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Login obj = new Login();
			obj.Show();
			this.Hide();
		}
	}
}
