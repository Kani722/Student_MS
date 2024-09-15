using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Student_MS
{
	public partial class User : Form
	{
		public User()
		{
			InitializeComponent();
		}
		readonly SqlConnection Con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\DSA\Student_MS\Student_MS\Student MS.mdf"";Integrated Security=True;Connect Timeout=30");
		private void DisplayUser()
		{
			/*try
			{
				Con.Open();
				string Query = "Select * from User";
				SqlDataAdapter sda = new SqlDataAdapter();
				SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sda);
				var ds = new DataSet();
				sda.Fill(ds);
				UserGrid.DataSource = ds.Tables[0];
				Con.Close();

			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				Con.Close();
			}*/
		}
		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void User_Load(object sender, EventArgs e)
		{
			DisplayUser();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Home obj = new Home();
			obj.Show();
			this.Hide();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			try
			{
				UserId.Text = " ";
				UserName.Text = " ";
				Password.Text = " ";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{

			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				if (UserId.Text == " " || UserName.Text == " " || Password.Text == " " )
				{
					MessageBox.Show("Missing Information");
				}
				else
				{
					Con.Open();
					string query = "insert into User Values(' " + UserId.Text + "', ' " + UserName.Text + "', ' " + Password.Text + "')";
					SqlCommand cmd = new SqlCommand(query, Con);

					cmd.ExecuteNonQuery();
					Con.Close();
					MessageBox.Show("Record Entered Successfully");
					DisplayUser();
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

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				if (UserId.Text == " " || UserName.Text == " " || Password.Text == " ")
				{
					MessageBox.Show("Missing Information");
				}
				else
				{
					Con.Open();
					string query = "update Teacher  Set User name = @User Name, Password= @Password";
					SqlCommand cmd = new SqlCommand(query, Con);
					cmd.Parameters.AddWithValue("@User Id", UserId.Text);
					cmd.Parameters.AddWithValue("@User Name", UserName.Text);
					cmd.Parameters.AddWithValue("@Password", Password.Text);
					cmd.ExecuteNonQuery();
					Con.Close();
					MessageBox.Show("Record Updated Successfully");
					DisplayUser();
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

		private void button3_Click(object sender, EventArgs e)
		{
			try
			{
				if (UserId.Text == " ")
				{
					MessageBox.Show("Enter the User Id");
				}
				else
				{
					Con.Open();
					SqlCommand cmd = new SqlCommand("delete from User where User Id=@User Id", Con);
					cmd.Parameters.AddWithValue("@User Id", UserId.Text);
					cmd.ExecuteNonQuery();
					Con.Close();
					MessageBox.Show("Record Deleted Successfully");
					DisplayUser();
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

		private void UserGrid_DoubleClick(object sender, EventArgs e)
		{
			try
			{
				UserId.Text = UserGrid.SelectedRows[0].Cells[0].Value.ToString();
				UserName.Text = UserGrid.SelectedRows[0].Cells[1].Value.ToString();
				Password.Text = UserGrid.SelectedRows[0].Cells[2].Value.ToString();
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
	}
}
