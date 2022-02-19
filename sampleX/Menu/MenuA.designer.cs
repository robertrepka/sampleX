﻿namespace sampleX
{
    partial class MenuA
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuA));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bUsers = new System.Windows.Forms.Button();
            this.bJournal = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 120);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 8, 0);
            this.statusStrip1.Size = new System.Drawing.Size(373, 22);
            this.statusStrip1.TabIndex = 101;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lStatus
            // 
            this.lStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lStatus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(117, 17);
            this.lStatus.Text = "toolStripStatusLabel1";
            // 
            // bUsers
            // 
            this.bUsers.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bUsers.Location = new System.Drawing.Point(9, 18);
            this.bUsers.Margin = new System.Windows.Forms.Padding(2);
            this.bUsers.Name = "bUsers";
            this.bUsers.Size = new System.Drawing.Size(135, 35);
            this.bUsers.TabIndex = 1;
            this.bUsers.Text = "&Používatelia";
            this.toolTip1.SetToolTip(this.bUsers, "Správa používateľov aplikácie");
            this.bUsers.UseVisualStyleBackColor = true;
            this.bUsers.Click += new System.EventHandler(this.bUsers_Click);
            // 
            // bJournal
            // 
            this.bJournal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bJournal.Location = new System.Drawing.Point(9, 60);
            this.bJournal.Margin = new System.Windows.Forms.Padding(2);
            this.bJournal.Name = "bJournal";
            this.bJournal.Size = new System.Drawing.Size(135, 35);
            this.bJournal.TabIndex = 2;
            this.bJournal.Text = "&Denník";
            this.toolTip1.SetToolTip(this.bJournal, "Prezeranie log súboru aplikácie");
            this.bJournal.UseVisualStyleBackColor = true;
            this.bJournal.Click += new System.EventHandler(this.bJournal_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(151, 18);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Čí&sla";
            this.toolTip1.SetToolTip(this.button2, "Naposledy automaticky pridelené čísla ");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(151, 60);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Konfigurácia";
            this.toolTip1.SetToolTip(this.button1, "Konfigurácia systémových parametrov");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(318, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 100;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.bUsers);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.bJournal);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 105);
            this.groupBox1.TabIndex = 121;
            this.groupBox1.TabStop = false;
            // 
            // MenuA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 142);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MenuA";
            this.Opacity = 0;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sampleX";
            this.Load += new System.EventHandler(this.MenuA_Load);
            this.Shown += new System.EventHandler(this.MenuA_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lStatus;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button bUsers;
        private System.Windows.Forms.Button bJournal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}