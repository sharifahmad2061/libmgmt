﻿namespace libmgmt
{
    partial class ArtifactsView
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
            this.artifactViewDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.artifactViewDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artifacts";
            // 
            // artifactViewDataGrid
            // 
            this.artifactViewDataGrid.AllowUserToAddRows = false;
            this.artifactViewDataGrid.AllowUserToDeleteRows = false;
            this.artifactViewDataGrid.AllowUserToResizeColumns = false;
            this.artifactViewDataGrid.AllowUserToResizeRows = false;
            this.artifactViewDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.artifactViewDataGrid.Location = new System.Drawing.Point(2, 63);
            this.artifactViewDataGrid.Name = "artifactViewDataGrid";
            this.artifactViewDataGrid.Size = new System.Drawing.Size(480, 345);
            this.artifactViewDataGrid.TabIndex = 1;
            // 
            // ArtifactsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.artifactViewDataGrid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ArtifactsView";
            this.Text = "ArtifactsView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ArtifactsView_FormClosing);
            this.Load += new System.EventHandler(this.ArtifactsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.artifactViewDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView artifactViewDataGrid;
    }
}