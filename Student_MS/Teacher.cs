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

namespace Student_MS
{
	public partial class Teacher : Form
	{
		public Teacher()
		{
			InitializeComponent();
		}

		readonly SqlConnection Con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\DSA\Student_MS\Student_MS\Student MS.mdf"";Integrated Security=True;Connect Timeout=30");
		private void DisplayTeacher()
		{
			/*try
			{
				Con.Open();
				string Query = "Select * from Teacher";
				SqlDataAdapter sda = new SqlDataAdapter();
				SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sda);
				var ds = new DataSet();
				sda.Fill(ds);
				TeachGrid.DataSource = ds.Tables[0];
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
				TeachId.Text = " ";
				TeachName.Text = " ";
				Gender.Text = " ";

				Phone.Text = " ";
				Subject.Text = " ";
				Address.Text = " ";
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{

			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			try
			{
				if (TeachId.Text == " ")
				{
					MessageBox.Show("Enter the Teacher Id");
				}
				else
				{
					Con.Open();
					SqlCommand cmd = new SqlCommand("delete from Teacher where Teacher Id=@Teacher Id", Con);
					cmd.Parameters.AddWithValue("@Teacher Id", TeachId.Text);
					cmd.ExecuteNonQuery();
					Con.Close();
					MessageBox.Show("Record Deleted Successfully");
					DisplayTeacher();
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				Con.Close();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				if (TeachId.Text == " " || TeachName.Text == " " || Gender.Text == " " || Phone.Text==" " || Subject.Text==" " || Address.Text == " ")
				{
					MessageBox.Show("Missing Information");
				}
				else
				{
					Con.Open();
					string query = "insert into Teacher Values(' "+TeachId.Text+"', ' "+TeachName.Text+"', ' "+Gender.Text+"', ' "+Phone.Text+"', ' "+Subject.Text+"', ' "+Address.Text+"')";
					SqlCommand cmd = new SqlCommand(query, Con);
					
					cmd.ExecuteNonQuery();
					Con.Close();
					MessageBox.Show("Record Entered Successfully");
					DisplayTeacher();
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				Con.Close();
			}
		}

		private void Teacher_Load(object sender, EventArgs e)
		{
			DisplayTeacher();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				if (TeachId.Text == " " || TeachName.Text == " " || Gender.Text == " " || Phone.Text == " " || Subject.Text == " " || Address.Text == " ")
				{
					MessageBox.Show("Missing Information");
				}
				else
				{
					Con.Open();
					string query = "update Teacher  Set Teacher name = @Teacher Name, Gender= @Gender, Phone= @Phone, Subject =@Subject where Teacher Id = @Teacher Id";
					SqlCommand cmd = new SqlCommand(query, Con);
					cmd.Parameters.AddWithValue("@Teacher Id", TeachId.Text);
					cmd.Parameters.AddWithValue("@Teacher Name", TeachName.Text);
					cmd.Parameters.AddWithValue("@Gender", Gender.Text);
					cmd.Parameters.AddWithValue("@Phone", Phone.Text);
					cmd.Parameters.AddWithValue("@Subject", Subject.Text);
					cmd.Parameters.AddWithValue("@Address", Address.Text);
					cmd.ExecuteNonQuery();
					Con.Close();
					MessageBox.Show("Record Updated Successfully");
					DisplayTeacher();
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

		private void dataGridView1_DoubleClick(object sender, EventArgs e)
		{
			try
			{
				TeachId.Text = TeachGrid.SelectedRows[0].Cells[0].Value.ToString();
				TeachName.Text = TeachGrid.SelectedRows[0].Cells[1].Value.ToString();
				Gender.Text = TeachGrid.SelectedRows[0].Cells[2].Value.ToString();
				Phone.Text = TeachGrid.SelectedRows[0].Cells[3].Value.ToString();
				Subject.Text = TeachGrid.SelectedRows[0].Cells[4].Value.ToString();
				Address.Text = TeachGrid.SelectedRows[0].Cells[5].Value.ToString();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				Con.Close();
			}
		}

		private void TeachGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
