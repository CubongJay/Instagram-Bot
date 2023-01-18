namespace Instagram_Bot
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnFollowers = new System.Windows.Forms.Button();
			this.gridFollowers = new System.Windows.Forms.DataGridView();
			this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtNew = new System.Windows.Forms.TextBox();
			this.btnFollow = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gridFollowers)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Username:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(43, 98);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Password:";
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(150, 60);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(259, 27);
			this.txtUsername.TabIndex = 2;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(150, 93);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(259, 27);
			this.txtPassword.TabIndex = 3;
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(134, 146);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(94, 29);
			this.btnLogin.TabIndex = 4;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnFollowers
			// 
			this.btnFollowers.Location = new System.Drawing.Point(441, 192);
			this.btnFollowers.Name = "btnFollowers";
			this.btnFollowers.Size = new System.Drawing.Size(94, 29);
			this.btnFollowers.TabIndex = 5;
			this.btnFollowers.Text = "button1";
			this.btnFollowers.UseVisualStyleBackColor = true;
			this.btnFollowers.Click += new System.EventHandler(this.btnFollowers_Click);
			// 
			// gridFollowers
			// 
			this.gridFollowers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridFollowers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fullname,
            this.Username});
			this.gridFollowers.Location = new System.Drawing.Point(359, 227);
			this.gridFollowers.Name = "gridFollowers";
			this.gridFollowers.RowHeadersWidth = 51;
			this.gridFollowers.Size = new System.Drawing.Size(398, 188);
			this.gridFollowers.TabIndex = 6;
			// 
			// Fullname
			// 
			this.Fullname.HeaderText = "Fullname";
			this.Fullname.MinimumWidth = 6;
			this.Fullname.Name = "Fullname";
			this.Fullname.Width = 125;
			// 
			// Username
			// 
			this.Username.HeaderText = "Username";
			this.Username.MinimumWidth = 6;
			this.Username.Name = "Username";
			this.Username.Width = 125;
			// 
			// txtNew
			// 
			this.txtNew.Location = new System.Drawing.Point(498, 53);
			this.txtNew.Name = "txtNew";
			this.txtNew.Size = new System.Drawing.Size(259, 27);
			this.txtNew.TabIndex = 7;
			// 
			// btnFollow
			// 
			this.btnFollow.Location = new System.Drawing.Point(586, 86);
			this.btnFollow.Name = "btnFollow";
			this.btnFollow.Size = new System.Drawing.Size(88, 29);
			this.btnFollow.TabIndex = 8;
			this.btnFollow.Text = "Follow Back";
			this.btnFollow.UseVisualStyleBackColor = true;
			this.btnFollow.Click += new System.EventHandler(this.btnFollow_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnFollow);
			this.Controls.Add(this.txtNew);
			this.Controls.Add(this.gridFollowers);
			this.Controls.Add(this.btnFollowers);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridFollowers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox txtUsername;
		private TextBox txtPassword;
		private Button btnLogin;
		private Button btnFollowers;
		private DataGridView gridFollowers;
		private DataGridViewTextBoxColumn Fullname;
		private DataGridViewTextBoxColumn Username;
		private TextBox txtNew;
		private Button btnFollow;
	}
}