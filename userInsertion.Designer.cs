namespace libmgmt
{
    partial class userInsertion
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
            this.userInsert = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.TextBox();
            this.userId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userInsert
            // 
            this.userInsert.ForeColor = System.Drawing.Color.Crimson;
            this.userInsert.Location = new System.Drawing.Point(137, 337);
            this.userInsert.Name = "userInsert";
            this.userInsert.Size = new System.Drawing.Size(200, 30);
            this.userInsert.TabIndex = 33;
            this.userInsert.Text = "Insert User";
            this.userInsert.UseVisualStyleBackColor = true;
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(225, 64);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(200, 21);
            this.userName.TabIndex = 26;
            // 
            // userId
            // 
            this.userId.Location = new System.Drawing.Point(225, 30);
            this.userId.Name = "userId";
            this.userId.Size = new System.Drawing.Size(200, 21);
            this.userId.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "User Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "User Name";
            // 
            // userInsertion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.userInsert);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.userId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "userInsertion";
            this.Text = "userInsertion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.userInsertion_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button userInsert;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox userId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}