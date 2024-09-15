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

namespace Student_MS
{
	public partial class Student : Form
	{
		public Student()
		{
			InitializeComponent();
			DisplayStudent();
		}
		readonly SqlConnection Con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\DSA\Student_MS\Student_MS\Student MS.mdf"";Integrated Security=True;Connect Timeout=30");
		private void DisplayStudent()
		{
			/*try
			{
				Con.Open();
				string Query = "Select * from Student";
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
		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void button8_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			Home obj = new Home();
			obj.Show();
			this.Hide();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			StudId.Text = " ";
			StudName.Text = " ";
			Gender.Text = " ";
			Phone.Text = " ";
			Subject.Text = " ";
			Fee.Text = " ";
		}

		private void Student_Load(object sender, EventArgs e)
		{
			DisplayStudent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			try
			{
				if (StudId.Text == " " || StudName.Text == " " || Gender.Text == " " || Phone.Text == " " || Subject.Text == " " || Fee.Text == " ")
				{
					MessageBox.Show("Missing Information");
				}
				else
				{
					Con.Open();
					string query = "insert into Student Values('" + StudId.Text + "' ,' " + StudName.Text + "' ,' " + Gender.Text + "' ,'" + Phone.Text + "' ,' " + Subject.Text + "' ,' " + Fee.Text + "')";
					SqlCommand cmd = new SqlCommand(query, Con);
					cmd.ExecuteNonQuery();
					Con.Close();
					MessageBox.Show("Record Entered Successfully");
					DisplayStudent();
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

		private void button1_Click(object sender, EventArgs e)
		{
			Account obj = new Account();
			obj.Show();
			this.Hide();
		}

		private void label4_Click_1(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			try
			{
				if (StudId.Text == " " || StudName.Text == " " || Gender.Text == " " || Phone.Text == " " || Subject.Text == " " || Fee.Text == " ")
				{
					MessageBox.Show("Missing Information");
				}
				else
				{
					Con.Open();
					string query = "update Student  Set Student name = @Student Name, Gender= @Gender, Phone= @Phone, Subject =@Subject, Fee = @Fee where Student Id = @Student Id";
					SqlCommand cmd = new SqlCommand(query, Con);
					cmd.Parameters.AddWithValue("@Student Id", StudId.Text);
					cmd.Parameters.AddWithValue("@Student Name", StudName.Text);
					cmd.Parameters.AddWithValue("@Gender", Gender.Text);
					cmd.Parameters.AddWithValue("@Phone", Phone.Text);
					cmd.Parameters.AddWithValue("@Subject", Subject.Text);
					cmd.Parameters.AddWithValue("@Fee", Fee.Text);
					cmd.ExecuteNonQuery();
					Con.Close();
					MessageBox.Show("Record Updated Successfully");
					DisplayStudent();
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

		private void button5_Click(object sender, EventArgs e)
		{
			try
			{
				if (StudId.Text == " ")
				{
					MessageBox.Show("Enter the Student Id");
				}
				else
				{
					Con.Open();
					SqlCommand cmd = new SqlCommand("delete from Student where Student Id=@Student Id", Con);
					cmd.Parameters.AddWithValue("@Student Id", StudId.Text);
					cmd.ExecuteNonQuery();
					Con.Close();
					MessageBox.Show("Record Deleted Successfully");
					DisplayStudent();
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

		private void StudId_TextChanged(object sender, EventArgs e)
		{

		}

		private void StudGrid_DoubleClick(object sender, EventArgs e)
		{
			try
			{
				StudId.Text = StudGrid.SelectedRows[0].Cells[0].Value.ToString();
				StudName.Text = StudGrid.SelectedRows[0].Cells[1].Value.ToString();
				Gender.Text = StudGrid.SelectedRows[0].Cells[2].Value.ToString();
				Phone.Text = StudGrid.SelectedRows[0].Cells[3].Value.ToString();
				Subject.Text = StudGrid.SelectedRows[0].Cells[4].Value.ToString();
				Fee.Text = StudGrid.SelectedRows[0].Cells[5].Value.ToString();
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
