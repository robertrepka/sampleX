namespace sampleX
{
    partial class Super
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Super));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bSelect = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dg = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lStatus
            // 
            this.lStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lStatus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(42, 17);
            this.lStatus.Text = "lStatus";
            // 
            // bSelect
            // 
            this.bSelect.Image = ((System.Drawing.Image)(resources.GetObject("bSelect.Image")));
            this.bSelect.Location = new System.Drawing.Point(114, 85);
            this.bSelect.Name = "bSelect";
            this.bSelect.Size = new System.Drawing.Size(45, 45);
            this.bSelect.TabIndex = 8;
            this.toolTip1.SetToolTip(this.bSelect, "Spracovanie výsledkov");
            this.bSelect.UseVisualStyleBackColor = true;
            this.bSelect.Visible = false;
            this.bSelect.Click += new System.EventHandler(this.bSelect_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // dg
            // 
            this.dg.BackColor = System.Drawing.Color.Black;
            this.dg.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dg.ForeColor = System.Drawing.Color.White;
            this.dg.Location = new System.Drawing.Point(12, 12);
            this.dg.Multiline = true;
            this.dg.Name = "dg";
            this.dg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dg.Size = new System.Drawing.Size(147, 67);
            this.dg.TabIndex = 9;
            this.dg.TextChanged += new System.EventHandler(this.dg_TextChanged);
            // 
            // Super
            // 
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bSelect);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Super";
            this.Opacity = 0;
            this.Load += new System.EventHandler(this.Super_Load);
            this.Shown += new System.EventHandler(this.Super_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Super_FormClosing);
            this.Resize += new System.EventHandler(this.Super_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button bSelect;
        private System.Windows.Forms.TextBox dg;
   }
}