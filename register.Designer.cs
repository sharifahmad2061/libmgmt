namespace libmgmt
{
    partial class register
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
            this.regEmail = new System.Windows.Forms.TextBox();
            this.regPsd = new System.Windows.Forms.TextBox();
            this.registerToSystemBtn = new System.Windows.Forms.Button();
            this.regBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(73, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(73, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // regEmail
            // 
            this.regEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regEmail.Location = new System.Drawing.Point(206, 66);
            this.regEmail.Name = "regEmail";
            this.regEmail.Size = new System.Drawing.Size(200, 27);
            this.regEmail.TabIndex = 2;
            this.regEmail.TextChanged += new System.EventHandler(this.regEmail_TextChanged);
            // 
            // regPsd
            // 
            this.regPsd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regPsd.Location = new System.Drawing.Point(206, 110);
            this.regPsd.Name = "regPsd";
            this.regPsd.Size = new System.Drawing.Size(200, 27);
            this.regPsd.TabIndex = 3;
            // 
            // registerToSystemBtn
            // 
            this.registerToSystemBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerToSystemBtn.ForeColor = System.Drawing.Color.Crimson;
            this.registerToSystemBtn.Location = new System.Drawing.Point(114, 305);
            this.registerToSystemBtn.Name = "registerToSystemBtn";
            this.registerToSystemBtn.Size = new System.Drawing.Size(200, 40);
            this.registerToSystemBtn.TabIndex = 4;
            this.registerToSystemBtn.Text = "Register";
            this.registerToSystemBtn.UseVisualStyleBackColor = true;
            this.registerToSystemBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // regBack
            // 
            this.regBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regBack.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regBack.ForeColor = System.Drawing.Color.Red;
            this.regBack.Location = new System.Drawing.Point(12, 12);
            this.regBack.Name = "regBack";
            this.regBack.Size = new System.Drawing.Size(40, 30);
            this.regBack.TabIndex = 5;
            this.regBack.Text = "<";
            this.regBack.UseVisualStyleBackColor = true;
            this.regBack.Click += new System.EventHandler(this.regBack_Click);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.regBack);
            this.Controls.Add(this.registerToSystemBtn);
            this.Controls.Add(this.regPsd);
            this.Controls.Add(this.regEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "register";
            this.Text = "register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox regEmail;
        private System.Windows.Forms.TextBox regPsd;
        private System.Windows.Forms.Button registerToSystemBtn;
        private System.Windows.Forms.Button regBack;
    }
}