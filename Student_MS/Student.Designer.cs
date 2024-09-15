namespace Student_MS
{
	partial class Student
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.StudId = new System.Windows.Forms.RichTextBox();
			this.StudName = new System.Windows.Forms.RichTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.Phone = new System.Windows.Forms.RichTextBox();
			this.Fee = new System.Windows.Forms.RichTextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.Subject = new System.Windows.Forms.ComboBox();
			this.button8 = new System.Windows.Forms.Button();
			this.StudGrid = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.Gender = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.StudGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(475, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(200, 44);
			this.label1.TabIndex = 3;
			this.label1.Text = "STUDENTS";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(117, 27);
			this.label2.TabIndex = 5;
			this.label2.Text = "Student Id";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(200, 97);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(158, 27);
			this.label3.TabIndex = 6;
			this.label3.Text = "Student Name";
			// 
			// StudId
			// 
			this.StudId.BackColor = System.Drawing.Color.LemonChiffon;
			this.StudId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StudId.Location = new System.Drawing.Point(17, 136);
			this.StudId.Name = "StudId";
			this.StudId.Size = new System.Drawing.Size(169, 27);
			this.StudId.TabIndex = 12;
			this.StudId.Text = "";
			this.StudId.TextChanged += new System.EventHandler(this.StudId_TextChanged);
			// 
			// StudName
			// 
			this.StudName.BackColor = System.Drawing.Color.LemonChiffon;
			this.StudName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StudName.Location = new System.Drawing.Point(205, 138);
			this.StudName.Name = "StudName";
			this.StudName.Size = new System.Drawing.Size(166, 27);
			this.StudName.TabIndex = 13;
			this.StudName.Text = "";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(582, 97);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(76, 27);
			this.label6.TabIndex = 16;
			this.label6.Text = "Phone";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// Phone
			// 
			this.Phone.BackColor = System.Drawing.Color.LemonChiffon;
			this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Phone.Location = new System.Drawing.Point(587, 138);
			this.Phone.Name = "Phone";
			this.Phone.Size = new System.Drawing.Size(164, 27);
			this.Phone.TabIndex = 17;
			this.Phone.Text = "";
			// 
			// Fee
			// 
			this.Fee.BackColor = System.Drawing.Color.LemonChiffon;
			this.Fee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Fee.Location = new System.Drawing.Point(988, 136);
			this.Fee.Name = "Fee";
			this.Fee.Size = new System.Drawing.Size(166, 27);
			this.Fee.TabIndex = 19;
			this.Fee.Text = "";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(774, 97);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(86, 27);
			this.label7.TabIndex = 20;
			this.label7.Text = "Subject";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(983, 97);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(47, 27);
			this.label8.TabIndex = 21;
			this.label8.Text = "Fee";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.SkyBlue;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(354, 206);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(238, 44);
			this.button1.TabIndex = 22;
			this.button1.Text = "Submitted Fees List";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.SkyBlue;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(644, 206);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(120, 44);
			this.button2.TabIndex = 23;
			this.button2.Text = "Refresh";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(152, 550);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(120, 44);
			this.button3.TabIndex = 24;
			this.button3.Text = "ADD";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.MediumVioletRed;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(324, 550);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(132, 44);
			this.button4.TabIndex = 25;
			this.button4.Text = "UPDATE";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(519, 550);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(115, 44);
			this.button5.TabIndex = 26;
			this.button5.Text = "DELETE";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.MediumVioletRed;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.Location = new System.Drawing.Point(694, 550);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(109, 44);
			this.button6.TabIndex = 27;
			this.button6.Text = "CLEAR";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.Location = new System.Drawing.Point(878, 550);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(111, 44);
			this.button7.TabIndex = 28;
			this.button7.Text = "HOME";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// Subject
			// 
			this.Subject.BackColor = System.Drawing.Color.LemonChiffon;
			this.Subject.FormattingEnabled = true;
			this.Subject.Items.AddRange(new object[] {
            "Mathematics",
            "Science",
            "English",
            "Sinhala",
            "Tamil",
            "Buddhism",
            "History",
            "IT"});
			this.Subject.Location = new System.Drawing.Point(779, 139);
			this.Subject.Name = "Subject";
			this.Subject.Size = new System.Drawing.Size(184, 24);
			this.Subject.TabIndex = 31;
			// 
			// button8
			// 
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button8.Location = new System.Drawing.Point(1128, 0);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(45, 44);
			this.button8.TabIndex = 32;
			this.button8.Text = "X";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// StudGrid
			// 
			this.StudGrid.BackgroundColor = System.Drawing.Color.LemonChiffon;
			this.StudGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.StudGrid.Location = new System.Drawing.Point(39, 256);
			this.StudGrid.Name = "StudGrid";
			this.StudGrid.RowHeadersWidth = 51;
			this.StudGrid.RowTemplate.Height = 24;
			this.StudGrid.Size = new System.Drawing.Size(1092, 271);
			this.StudGrid.TabIndex = 34;
			this.StudGrid.DoubleClick += new System.EventHandler(this.StudGrid_DoubleClick);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(386, 97);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 27);
			this.label4.TabIndex = 35;
			this.label4.Text = "Gender";
			this.label4.Click += new System.EventHandler(this.label4_Click_1);
			// 
			// Gender
			// 
			this.Gender.BackColor = System.Drawing.Color.LemonChiffon;
			this.Gender.FormattingEnabled = true;
			this.Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
			this.Gender.Location = new System.Drawing.Point(391, 141);
			this.Gender.Name = "Gender";
			this.Gender.Size = new System.Drawing.Size(164, 24);
			this.Gender.TabIndex = 36;
			// 
			// Student
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LemonChiffon;
			this.ClientSize = new System.Drawing.Size(1173, 634);
			this.Controls.Add(this.Gender);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.StudGrid);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.Subject);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.Fee);
			this.Controls.Add(this.Phone);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.StudName);
			this.Controls.Add(this.StudId);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Student";
			this.Text = "Student";
			this.Load += new System.EventHandler(this.Student_Load);
			((System.ComponentModel.ISupportInitialize)(this.StudGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RichTextBox StudId;
		private System.Windows.Forms.RichTextBox StudName;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RichTextBox Phone;
		private System.Windows.Forms.RichTextBox Fee;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.ComboBox Subject;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.DataGridView StudGrid;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox Gender;
	}
}