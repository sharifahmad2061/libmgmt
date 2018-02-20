namespace libmgmt
{
    partial class login
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
            this.loginEmail = new System.Windows.Forms.TextBox();
            this.loginPsd = new System.Windows.Forms.TextBox();
            this.loginToSystemBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginEmail
            // 
            this.loginEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginEmail.Location = new System.Drawing.Point(194, 85);
            this.loginEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginEmail.Name = "loginEmail";
            this.loginEmail.Size = new System.Drawing.Size(233, 26);
            this.loginEmail.TabIndex = 0;
            this.loginEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // loginPsd
            // 
            this.loginPsd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPsd.Location = new System.Drawing.Point(194, 143);
            this.loginPsd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginPsd.Name = "loginPsd";
            this.loginPsd.PasswordChar = '*';
            this.loginPsd.Size = new System.Drawing.Size(233, 26);
            this.loginPsd.TabIndex = 1;
            this.loginPsd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // loginToSystemBtn
            // 
            this.loginToSystemBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginToSystemBtn.ForeColor = System.Drawing.Color.Crimson;
            this.loginToSystemBtn.Location = new System.Drawing.Point(98, 301);
            this.loginToSystemBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginToSystemBtn.Name = "loginToSystemBtn";
            this.loginToSystemBtn.Size = new System.Drawing.Size(200, 40);
            this.loginToSystemBtn.TabIndex = 2;
            this.loginToSystemBtn.Text = "login";
            this.loginToSystemBtn.UseVisualStyleBackColor = true;
            this.loginToSystemBtn.Click += new System.EventHandler(this.loginToSystemBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(66, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(66, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // loginBack
            // 
            this.loginBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBack.ForeColor = System.Drawing.Color.Crimson;
            this.loginBack.Location = new System.Drawing.Point(26, 13);
            this.loginBack.Name = "loginBack";
            this.loginBack.Size = new System.Drawing.Size(40, 30);
            this.loginBack.TabIndex = 5;
            this.loginBack.Text = "<";
            this.loginBack.UseVisualStyleBackColor = true;
            this.loginBack.Click += new System.EventHandler(this.loginBack_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.loginBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginToSystemBtn);
            this.Controls.Add(this.loginPsd);
            this.Controls.Add(this.loginEmail);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginEmail;
        private System.Windows.Forms.TextBox loginPsd;
        private System.Windows.Forms.Button loginToSystemBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginBack;
    }
}