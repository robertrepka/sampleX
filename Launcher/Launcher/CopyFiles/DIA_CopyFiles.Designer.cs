namespace Launcher
{
    partial class DIA_CopyFiles
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
            this.But_Cancel = new System.Windows.Forms.Button();
            this.Prog_CurrentFile = new System.Windows.Forms.ProgressBar();
            this.Prog_TotalFiles = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // But_Cancel
            // 
            this.But_Cancel.Location = new System.Drawing.Point(308, 12);
            this.But_Cancel.Name = "But_Cancel";
            this.But_Cancel.Size = new System.Drawing.Size(65, 23);
            this.But_Cancel.TabIndex = 8;
            this.But_Cancel.Text = "Zruš";
            this.But_Cancel.UseVisualStyleBackColor = true;
            this.But_Cancel.Visible = false;
            this.But_Cancel.Click += new System.EventHandler(this.But_Cancel_Click);
            // 
            // Prog_CurrentFile
            // 
            this.Prog_CurrentFile.Location = new System.Drawing.Point(-4, -8);
            this.Prog_CurrentFile.Name = "Prog_CurrentFile";
            this.Prog_CurrentFile.Size = new System.Drawing.Size(377, 60);
            this.Prog_CurrentFile.TabIndex = 7;
            // 
            // Prog_TotalFiles
            // 
            this.Prog_TotalFiles.Location = new System.Drawing.Point(12, 24);
            this.Prog_TotalFiles.Name = "Prog_TotalFiles";
            this.Prog_TotalFiles.Size = new System.Drawing.Size(361, 10);
            this.Prog_TotalFiles.TabIndex = 6;
            this.Prog_TotalFiles.Visible = false;
            // 
            // DIA_CopyFiles
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(374, 47);
            this.ControlBox = false;
            this.Controls.Add(this.But_Cancel);
            this.Controls.Add(this.Prog_CurrentFile);
            this.Controls.Add(this.Prog_TotalFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DIA_CopyFiles";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Kopírujem...";
            this.Load += new System.EventHandler(this.DIA_CopyFiles_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DIA_CopyFiles_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button But_Cancel;
        private System.Windows.Forms.ProgressBar Prog_CurrentFile;
        private System.Windows.Forms.ProgressBar Prog_TotalFiles;
    }
}