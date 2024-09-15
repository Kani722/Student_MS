namespace Student_MS
{
	partial class User
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
			this.label4 = new System.Windows.Forms.Label();
			this.UserId = new System.Windows.Forms.RichTextBox();
			this.UserName = new System.Windows.Forms.RichTextBox();
			this.Password = new System.Windows.Forms.RichTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.UserGrid = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.UserGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(426, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 44);
			this.label1.TabIndex = 2;
			this.label1.Text = "USERS";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 106);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 27);
			this.label2.TabIndex = 3;
			this.label2.Text = "User Id";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 162);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(125, 27);
			this.label3.TabIndex = 4;
			this.label3.Text = "User Name";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 220);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(108, 27);
			this.label4.TabIndex = 5;
			this.label4.Text = "Password";
			// 
			// UserId
			// 
			this.UserId.BackColor = System.Drawing.Color.LemonChiffon;
			this.UserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UserId.Location = new System.Drawing.Point(178, 106);
			this.UserId.Name = "UserId";
			this.UserId.Size = new System.Drawing.Size(193, 27);
			this.UserId.TabIndex = 9;
			this.UserId.Text = "";
			// 
			// UserName
			// 
			this.UserName.BackColor = System.Drawing.Color.LemonChiffon;
			this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UserName.Location = new System.Drawing.Point(178, 162);
			this.UserName.Name = "UserName";
			this.UserName.Size = new System.Drawing.Size(193, 27);
			this.UserName.TabIndex = 10;
			this.UserName.Text = "";
			// 
			// Password
			// 
			this.Password.BackColor = System.Drawing.Color.LemonChiffon;
			this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Password.Location = new System.Drawing.Point(178, 220);
			this.Password.Name = "Password";
			this.Password.Size = new System.Drawing.Size(193, 27);
			this.Password.TabIndex = 11;
			this.Password.Text = "";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(20, 305);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(131, 44);
			this.button1.TabIndex = 12;
			this.button1.Text = "ADD";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(178, 304);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(118, 44);
			this.button2.TabIndex = 13;
			this.button2.Text = "UPDATE";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(327, 304);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(109, 44);
			this.button3.TabIndex = 14;
			this.button3.Text = "DELETE";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.MediumVioletRed;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(90, 375);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(109, 44);
			this.button4.TabIndex = 15;
			this.button4.Text = "CLEAR";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.MediumVioletRed;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(234, 375);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(111, 44);
			this.button5.TabIndex = 16;
			this.button5.Text = "HOME";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.Red;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.Location = new System.Drawing.Point(962, 0);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(45, 44);
			this.button6.TabIndex = 17;
			this.button6.Text = "X";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// UserGrid
			// 
			this.UserGrid.BackgroundColor = System.Drawing.Color.LemonChiffon;
			this.UserGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.UserGrid.Location = new System.Drawing.Point(474, 90);
			this.UserGrid.Name = "UserGrid";
			this.UserGrid.RowHeadersWidth = 51;
			this.UserGrid.RowTemplate.Height = 24;
			this.UserGrid.Size = new System.Drawing.Size(521, 365);
			this.UserGrid.TabIndex = 24;
			this.UserGrid.DoubleClick += new System.EventHandler(this.UserGrid_DoubleClick);
			// 
			// User
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LemonChiffon;
			this.ClientSize = new System.Drawing.Size(1007, 499);
			this.Controls.Add(this.UserGrid);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Password);
			this.Controls.Add(this.UserName);
			this.Controls.Add(this.UserId);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "User";
			this.Text = "User";
			this.Load += new System.EventHandler(this.User_Load);
			((System.ComponentModel.ISupportInitialize)(this.UserGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox UserId;
		private System.Windows.Forms.RichTextBox UserName;
		private System.Windows.Forms.RichTextBox Password;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.DataGridView UserGrid;
	}
}