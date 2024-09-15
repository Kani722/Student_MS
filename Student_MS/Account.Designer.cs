namespace Student_MS
{
	partial class Account
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
			this.UserId = new System.Windows.Forms.RichTextBox();
			this.StudentId = new System.Windows.Forms.RichTextBox();
			this.Fees = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// UserId
			// 
			this.UserId.BackColor = System.Drawing.Color.LemonChiffon;
			this.UserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UserId.Location = new System.Drawing.Point(61, 159);
			this.UserId.Name = "UserId";
			this.UserId.Size = new System.Drawing.Size(193, 27);
			this.UserId.TabIndex = 10;
			this.UserId.Text = "";
			this.UserId.TextChanged += new System.EventHandler(this.UserId_TextChanged);
			// 
			// StudentId
			// 
			this.StudentId.BackColor = System.Drawing.Color.LemonChiffon;
			this.StudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StudentId.Location = new System.Drawing.Point(325, 159);
			this.StudentId.Name = "StudentId";
			this.StudentId.Size = new System.Drawing.Size(193, 27);
			this.StudentId.TabIndex = 11;
			this.StudentId.Text = "";
			// 
			// Fees
			// 
			this.Fees.BackColor = System.Drawing.Color.LemonChiffon;
			this.Fees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Fees.Location = new System.Drawing.Point(578, 159);
			this.Fees.Name = "Fees";
			this.Fees.Size = new System.Drawing.Size(193, 27);
			this.Fees.TabIndex = 12;
			this.Fees.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(411, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(210, 44);
			this.label1.TabIndex = 13;
			this.label1.Text = "ACCOUNTS";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(56, 111);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 27);
			this.label2.TabIndex = 14;
			this.label2.Text = "User Id";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(320, 111);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(117, 27);
			this.label3.TabIndex = 15;
			this.label3.Text = "Student Id";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(573, 111);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 27);
			this.label4.TabIndex = 16;
			this.label4.Text = "Fees";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(61, 497);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(120, 44);
			this.button3.TabIndex = 25;
			this.button3.Text = "ADD";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.MediumVioletRed;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(325, 497);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(132, 44);
			this.button4.TabIndex = 26;
			this.button4.Text = "UPDATE";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.Location = new System.Drawing.Point(578, 497);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(111, 44);
			this.button7.TabIndex = 29;
			this.button7.Text = "HOME";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.MediumVioletRed;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(821, 497);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(132, 44);
			this.button1.TabIndex = 30;
			this.button1.Text = "STUDENTS";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Account
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LemonChiffon;
			this.ClientSize = new System.Drawing.Size(1052, 568);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Fees);
			this.Controls.Add(this.StudentId);
			this.Controls.Add(this.UserId);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Account";
			this.Text = "Account";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.RichTextBox UserId;
		private System.Windows.Forms.RichTextBox StudentId;
		private System.Windows.Forms.RichTextBox Fees;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button1;
	}
}