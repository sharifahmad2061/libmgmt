namespace libmgmt
{
    partial class IssueArtifact
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
            this.provideArtifact = new System.Windows.Forms.Button();
            this.issueArtifactType = new System.Windows.Forms.ComboBox();
            this.issueArtifactBatch = new System.Windows.Forms.TextBox();
            this.issueArtifactName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // provideArtifact
            // 
            this.provideArtifact.ForeColor = System.Drawing.Color.Crimson;
            this.provideArtifact.Location = new System.Drawing.Point(119, 346);
            this.provideArtifact.Name = "provideArtifact";
            this.provideArtifact.Size = new System.Drawing.Size(200, 30);
            this.provideArtifact.TabIndex = 33;
            this.provideArtifact.Text = "Issue The Artifact";
            this.provideArtifact.UseVisualStyleBackColor = true;
            // 
            // issueArtifactType
            // 
            this.issueArtifactType.FormattingEnabled = true;
            this.issueArtifactType.Items.AddRange(new object[] {
            "Book",
            "Journal",
            "CD/DVD"});
            this.issueArtifactType.Location = new System.Drawing.Point(211, 167);
            this.issueArtifactType.Name = "issueArtifactType";
            this.issueArtifactType.Size = new System.Drawing.Size(200, 24);
            this.issueArtifactType.TabIndex = 31;
            // 
            // issueArtifactBatch
            // 
            this.issueArtifactBatch.Location = new System.Drawing.Point(211, 108);
            this.issueArtifactBatch.Name = "issueArtifactBatch";
            this.issueArtifactBatch.Size = new System.Drawing.Size(200, 21);
            this.issueArtifactBatch.TabIndex = 26;
            // 
            // issueArtifactName
            // 
            this.issueArtifactName.Location = new System.Drawing.Point(211, 49);
            this.issueArtifactName.Name = "issueArtifactName";
            this.issueArtifactName.Size = new System.Drawing.Size(200, 21);
            this.issueArtifactName.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Artifact Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Batch";
            // 
            // IssueArtifact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.provideArtifact);
            this.Controls.Add(this.issueArtifactType);
            this.Controls.Add(this.issueArtifactBatch);
            this.Controls.Add(this.issueArtifactName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "IssueArtifact";
            this.Text = "IssueArtifact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button provideArtifact;
        private System.Windows.Forms.ComboBox issueArtifactType;
        private System.Windows.Forms.TextBox issueArtifactBatch;
        private System.Windows.Forms.TextBox issueArtifactName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}