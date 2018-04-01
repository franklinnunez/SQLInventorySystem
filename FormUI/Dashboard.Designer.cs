namespace FormUI
{
	partial class Dashboard
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
			this.listView1 = new System.Windows.Forms.ListView();
			this.btnsearch = new System.Windows.Forms.Button();
			this.txtsearch = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lstPeopleFound = new System.Windows.Forms.ListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtfirstname = new System.Windows.Forms.TextBox();
			this.txtlastname = new System.Windows.Forms.TextBox();
			this.txtemail = new System.Windows.Forms.TextBox();
			this.txtphone = new System.Windows.Forms.TextBox();
			this.btnsave = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lblcount = new System.Windows.Forms.Label();
			this.btndelete = new System.Windows.Forms.Button();
			this.btnupdate = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.Location = new System.Drawing.Point(17, 108);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(905, 349);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// btnsearch
			// 
			this.btnsearch.BackColor = System.Drawing.Color.Transparent;
			this.btnsearch.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.btnsearch.Location = new System.Drawing.Point(22, 69);
			this.btnsearch.Name = "btnsearch";
			this.btnsearch.Size = new System.Drawing.Size(101, 31);
			this.btnsearch.TabIndex = 1;
			this.btnsearch.Text = "Search";
			this.btnsearch.UseVisualStyleBackColor = false;
			this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
			// 
			// txtsearch
			// 
			this.txtsearch.Location = new System.Drawing.Point(147, 69);
			this.txtsearch.Name = "txtsearch";
			this.txtsearch.Size = new System.Drawing.Size(188, 29);
			this.txtsearch.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(144, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "Enter Last Name";
			// 
			// lstPeopleFound
			// 
			this.lstPeopleFound.FormattingEnabled = true;
			this.lstPeopleFound.ItemHeight = 21;
			this.lstPeopleFound.Location = new System.Drawing.Point(17, 538);
			this.lstPeopleFound.Name = "lstPeopleFound";
			this.lstPeopleFound.Size = new System.Drawing.Size(905, 172);
			this.lstPeopleFound.TabIndex = 4;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnupdate);
			this.groupBox1.Controls.Add(this.btndelete);
			this.groupBox1.Controls.Add(this.lblcount);
			this.groupBox1.Controls.Add(this.listView1);
			this.groupBox1.Controls.Add(this.lstPeopleFound);
			this.groupBox1.Controls.Add(this.btnsearch);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtsearch);
			this.groupBox1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(27, 21);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(938, 743);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Search By Last Name";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.btnsave);
			this.groupBox2.Controls.Add(this.txtphone);
			this.groupBox2.Controls.Add(this.txtemail);
			this.groupBox2.Controls.Add(this.txtlastname);
			this.groupBox2.Controls.Add(this.txtfirstname);
			this.groupBox2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(981, 21);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(335, 247);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Add Person";
			// 
			// txtfirstname
			// 
			this.txtfirstname.Location = new System.Drawing.Point(124, 32);
			this.txtfirstname.Name = "txtfirstname";
			this.txtfirstname.Size = new System.Drawing.Size(188, 29);
			this.txtfirstname.TabIndex = 4;
			// 
			// txtlastname
			// 
			this.txtlastname.Location = new System.Drawing.Point(124, 73);
			this.txtlastname.Name = "txtlastname";
			this.txtlastname.Size = new System.Drawing.Size(188, 29);
			this.txtlastname.TabIndex = 6;
			// 
			// txtemail
			// 
			this.txtemail.Location = new System.Drawing.Point(124, 114);
			this.txtemail.Name = "txtemail";
			this.txtemail.Size = new System.Drawing.Size(188, 29);
			this.txtemail.TabIndex = 8;
			// 
			// txtphone
			// 
			this.txtphone.Location = new System.Drawing.Point(124, 153);
			this.txtphone.Name = "txtphone";
			this.txtphone.Size = new System.Drawing.Size(188, 29);
			this.txtphone.TabIndex = 10;
			// 
			// btnsave
			// 
			this.btnsave.BackColor = System.Drawing.Color.Transparent;
			this.btnsave.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsave.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.btnsave.Location = new System.Drawing.Point(21, 200);
			this.btnsave.Name = "btnsave";
			this.btnsave.Size = new System.Drawing.Size(291, 37);
			this.btnsave.TabIndex = 5;
			this.btnsave.Text = "Save";
			this.btnsave.UseVisualStyleBackColor = false;
			this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(18, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 20);
			this.label2.TabIndex = 11;
			this.label2.Text = "First Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(18, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 20);
			this.label3.TabIndex = 12;
			this.label3.Text = "Last Name";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(18, 122);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 20);
			this.label4.TabIndex = 13;
			this.label4.Text = "e-Mail";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(18, 161);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 20);
			this.label5.TabIndex = 14;
			this.label5.Text = "Phone";
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "ID";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "First Name";
			this.columnHeader2.Width = 103;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Last Name";
			this.columnHeader3.Width = 130;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Email";
			this.columnHeader4.Width = 254;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Phone";
			this.columnHeader5.Width = 315;
			// 
			// lblcount
			// 
			this.lblcount.AutoSize = true;
			this.lblcount.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblcount.Location = new System.Drawing.Point(815, 80);
			this.lblcount.Name = "lblcount";
			this.lblcount.Size = new System.Drawing.Size(50, 20);
			this.lblcount.TabIndex = 5;
			this.lblcount.Text = "Count";
			// 
			// btndelete
			// 
			this.btndelete.BackColor = System.Drawing.Color.Transparent;
			this.btndelete.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.btndelete.Location = new System.Drawing.Point(695, 480);
			this.btndelete.Name = "btndelete";
			this.btndelete.Size = new System.Drawing.Size(101, 31);
			this.btndelete.TabIndex = 6;
			this.btndelete.Text = "Delete";
			this.btndelete.UseVisualStyleBackColor = false;
			this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
			// 
			// btnupdate
			// 
			this.btnupdate.BackColor = System.Drawing.Color.Transparent;
			this.btnupdate.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.btnupdate.Location = new System.Drawing.Point(821, 480);
			this.btnupdate.Name = "btnupdate";
			this.btnupdate.Size = new System.Drawing.Size(101, 31);
			this.btnupdate.TabIndex = 7;
			this.btnupdate.Text = "Uptade";
			this.btnupdate.UseVisualStyleBackColor = false;
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1346, 793);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Dashboard";
			this.Text = "SQL Data Access Demo";
			this.Load += new System.EventHandler(this.Dashboard_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button btnsearch;
		private System.Windows.Forms.TextBox txtsearch;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox lstPeopleFound;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnsave;
		private System.Windows.Forms.TextBox txtphone;
		private System.Windows.Forms.TextBox txtemail;
		private System.Windows.Forms.TextBox txtlastname;
		private System.Windows.Forms.TextBox txtfirstname;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.Label lblcount;
		private System.Windows.Forms.Button btnupdate;
		private System.Windows.Forms.Button btndelete;
	}
}

