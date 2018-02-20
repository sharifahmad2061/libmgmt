namespace libmgmt
{
    partial class adminView
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
            this.seeArtifacts = new System.Windows.Forms.Button();
            this.seeUserData = new System.Windows.Forms.Button();
            this.IssueArtifact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // seeArtifacts
            // 
            this.seeArtifacts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seeArtifacts.Location = new System.Drawing.Point(143, 87);
            this.seeArtifacts.Name = "seeArtifacts";
            this.seeArtifacts.Size = new System.Drawing.Size(200, 40);
            this.seeArtifacts.TabIndex = 0;
            this.seeArtifacts.Text = "See Artifacts";
            this.seeArtifacts.UseVisualStyleBackColor = true;
            this.seeArtifacts.Click += new System.EventHandler(this.button1_Click);
            // 
            // seeUserData
            // 
            this.seeUserData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seeUserData.Location = new System.Drawing.Point(143, 181);
            this.seeUserData.Name = "seeUserData";
            this.seeUserData.Size = new System.Drawing.Size(200, 40);
            this.seeUserData.TabIndex = 1;
            this.seeUserData.Text = "See Users Data";
            this.seeUserData.UseVisualStyleBackColor = true;
            this.seeUserData.Click += new System.EventHandler(this.button2_Click);
            // 
            // IssueArtifact
            // 
            this.IssueArtifact.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueArtifact.Location = new System.Drawing.Point(143, 275);
            this.IssueArtifact.Name = "IssueArtifact";
            this.IssueArtifact.Size = new System.Drawing.Size(200, 40);
            this.IssueArtifact.TabIndex = 2;
            this.IssueArtifact.Text = "Provide An Artifact";
            this.IssueArtifact.UseVisualStyleBackColor = true;
            this.IssueArtifact.Click += new System.EventHandler(this.button3_Click);
            // 
            // adminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.IssueArtifact);
            this.Controls.Add(this.seeUserData);
            this.Controls.Add(this.seeArtifacts);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "adminView";
            this.Text = "adminView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button seeArtifacts;
        private System.Windows.Forms.Button seeUserData;
        private System.Windows.Forms.Button IssueArtifact;
    }
}