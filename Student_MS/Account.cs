using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Student_MS
{
	public partial class Account : Form
	{
		public Account()
		{
			InitializeComponent();
		}
		readonly SqlConnection Con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\DSA\Student_MS\Student_MS\Student MS.mdf"";Integrated Security=True;Connect Timeout=30");
		private void DisplayAccounts()
		{
			/*try
			{
				Con.Open();
				string Query = "Select * from Accounts";
				SqlDataAdapter sda = new SqlDataAdapter();
				SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sda);
				var ds = new DataSet();
				sda.Fill(ds);
				StudGrid.DataSource = ds.Tables[0];
				Con.Close();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				Con.Close();
			}*/
		}
		private void UserId_TextChanged(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			try
			{
				if (UserId.Text == " " || StudentId.Text == " " || Fees.Text == " ")
				{
					MessageBox.Show("Missing Information");
				}
				else
				{
					Con.Open();
					string query = "insert into Student Values('" + UserId.Text + "' ,' " + StudentId.Text + "' ,' " + Fees.Text + "')";
					SqlCommand cmd = new SqlCommand(query, Con);
					cmd.ExecuteNonQuery();
					Con.Close();
					MessageBox.Show("Record Entered Successfully");
					DisplayAccounts();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				Con.Close();
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			try
			{
				if (UserId.Text == " " || StudentId.Text == " " || Fees.Text == " " )
				{
					MessageBox.Show("Missing Information");
				}
				else
				{
					Con.Open();
					string query = "update account  Set Student Id = @Student Id, Fees= @Fees where User Id = @User Id";
					SqlCommand cmd = new SqlCommand(query, Con);
					cmd.Parameters.AddWithValue("@User Id", UserId.Text);
					cmd.Parameters.AddWithValue("@Student Id", StudentId.Text);
					cmd.Parameters.AddWithValue("@Fees", Fees.Text);
					cmd.ExecuteNonQuery();
					Con.Close();
					MessageBox.Show("Record Updated Successfully");
					DisplayAccounts();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				Con.Close();
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			Home obj = new Home();
			obj.Show();
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Student obj = new Student();
			obj.Show();
			this.Hide();
		}
	}
}
