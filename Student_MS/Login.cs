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
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			User.Text = " ";
			Password.Text = " ";
			RePassword.Text = " ";
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			if(User.Text == " " && Password.Text == " " && RePassword.Text == " ")
			{
				MessageBox.Show("Missing Information");
			}
			else if(User.Text == "User" && Password.Text == "123" && RePassword.Text == "123")
			{
				Home obj = new Home();
				obj.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Please Enter the Correct Username and Password");
			}
		}

		private void Login_Load(object sender, EventArgs e)
		{

		}

		private void Password_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
