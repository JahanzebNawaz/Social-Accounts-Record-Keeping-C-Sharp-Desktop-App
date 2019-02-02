namespace Accounts_Registration
{
    partial class account_login
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
            this.checkConnection = new System.Windows.Forms.Label();
            this.uname = new System.Windows.Forms.Label();
            this.upass = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.TextBox();
            this.user_password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkConnection
            // 
            this.checkConnection.AutoSize = true;
            this.checkConnection.Location = new System.Drawing.Point(35, 250);
            this.checkConnection.Name = "checkConnection";
            this.checkConnection.Size = new System.Drawing.Size(0, 13);
            this.checkConnection.TabIndex = 0;
            this.checkConnection.Click += new System.EventHandler(this.label1_Click);
            // 
            // uname
            // 
            this.uname.AutoSize = true;
            this.uname.Location = new System.Drawing.Point(60, 68);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(60, 13);
            this.uname.TabIndex = 1;
            this.uname.Text = "User Name";
            // 
            // upass
            // 
            this.upass.AutoSize = true;
            this.upass.Location = new System.Drawing.Point(62, 116);
            this.upass.Name = "upass";
            this.upass.Size = new System.Drawing.Size(53, 13);
            this.upass.TabIndex = 2;
            this.upass.Text = "Password";
            // 
            // user_name
            // 
            this.user_name.Location = new System.Drawing.Point(130, 65);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(100, 20);
            this.user_name.TabIndex = 3;
            // 
            // user_password
            // 
            this.user_password.Location = new System.Drawing.Point(130, 116);
            this.user_password.Name = "user_password";
            this.user_password.PasswordChar = '*';
            this.user_password.Size = new System.Drawing.Size(100, 20);
            this.user_password.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "log In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // account_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 271);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.user_password);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.upass);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.checkConnection);
            this.Name = "account_login";
            this.Text = "Accounts Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label checkConnection;
        private System.Windows.Forms.Label uname;
        private System.Windows.Forms.Label upass;
        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.TextBox user_password;
        private System.Windows.Forms.Button button1;
    }
}

