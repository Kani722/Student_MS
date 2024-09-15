using System;
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
	public partial class Home : Form
	{
		public Home()
		{
			InitializeComponent();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Login login = new Login();
			login.Show();
			this.Hide();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Teacher obj = new Teacher();
			obj.Show();
			this.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Student obj = new Student();
			obj.Show();
			this.Hide();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			User obj = new User();
			obj.Show();
			this.Hide();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Account obj = new Account();
			obj.Show();
			this.Hide();
		}
	}
}
