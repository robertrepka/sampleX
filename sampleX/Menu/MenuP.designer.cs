namespace sampleX
{
    partial class MenuP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuP));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nuC = new System.Windows.Forms.NumericUpDown();
            this.nuR = new System.Windows.Forms.NumericUpDown();
            this.nu4 = new System.Windows.Forms.NumericUpDown();
            this.nu3 = new System.Windows.Forms.NumericUpDown();
            this.nu2 = new System.Windows.Forms.NumericUpDown();
            this.nu1 = new System.Windows.Forms.NumericUpDown();
            this.c1 = new System.Windows.Forms.ComboBox();
            this.nuF1 = new System.Windows.Forms.NumericUpDown();
            this.nuF2 = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuF1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuF2)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 419);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 8, 0);
            this.statusStrip1.Size = new System.Drawing.Size(558, 22);
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(506, 368);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 4;
            this.toolTip1.SetToolTip(this.button1, "Konfigurácia systémových parametrov");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(506, 7);
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
            this.groupBox1.Controls.Add(this.nuF2);
            this.groupBox1.Controls.Add(this.nuF1);
            this.groupBox1.Controls.Add(this.nuC);
            this.groupBox1.Controls.Add(this.nuR);
            this.groupBox1.Controls.Add(this.nu4);
            this.groupBox1.Controls.Add(this.nu3);
            this.groupBox1.Controls.Add(this.nu2);
            this.groupBox1.Controls.Add(this.nu1);
            this.groupBox1.Controls.Add(this.c1);
            this.groupBox1.Location = new System.Drawing.Point(7, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 413);
            this.groupBox1.TabIndex = 121;
            this.groupBox1.TabStop = false;
            // 
            // nuC
            // 
            this.nuC.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.nuC.Location = new System.Drawing.Point(362, 54);
            this.nuC.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nuC.Name = "nuC";
            this.nuC.Size = new System.Drawing.Size(73, 27);
            this.nuC.TabIndex = 10;
            this.nuC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nuC.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nuC.ValueChanged += new System.EventHandler(this.nuC_ValueChanged);
            // 
            // nuR
            // 
            this.nuR.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.nuR.Location = new System.Drawing.Point(362, 21);
            this.nuR.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nuR.Name = "nuR";
            this.nuR.Size = new System.Drawing.Size(73, 27);
            this.nuR.TabIndex = 9;
            this.nuR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nuR.Value = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.nuR.ValueChanged += new System.EventHandler(this.nuR_ValueChanged);
            // 
            // nu4
            // 
            this.nu4.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.nu4.Location = new System.Drawing.Point(196, 120);
            this.nu4.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nu4.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nu4.Name = "nu4";
            this.nu4.Size = new System.Drawing.Size(73, 27);
            this.nu4.TabIndex = 8;
            this.nu4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nu4.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nu4.ValueChanged += new System.EventHandler(this.nu4_ValueChanged);
            // 
            // nu3
            // 
            this.nu3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.nu3.Location = new System.Drawing.Point(196, 87);
            this.nu3.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nu3.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nu3.Name = "nu3";
            this.nu3.Size = new System.Drawing.Size(73, 27);
            this.nu3.TabIndex = 7;
            this.nu3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nu3.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nu3.ValueChanged += new System.EventHandler(this.nu3_ValueChanged);
            // 
            // nu2
            // 
            this.nu2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.nu2.Location = new System.Drawing.Point(196, 54);
            this.nu2.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nu2.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nu2.Name = "nu2";
            this.nu2.Size = new System.Drawing.Size(73, 27);
            this.nu2.TabIndex = 6;
            this.nu2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nu2.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nu2.ValueChanged += new System.EventHandler(this.nu2_ValueChanged);
            // 
            // nu1
            // 
            this.nu1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.nu1.Location = new System.Drawing.Point(196, 21);
            this.nu1.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nu1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nu1.Name = "nu1";
            this.nu1.Size = new System.Drawing.Size(73, 27);
            this.nu1.TabIndex = 5;
            this.nu1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nu1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nu1.ValueChanged += new System.EventHandler(this.nu1_ValueChanged);
            // 
            // c1
            // 
            this.c1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.c1.FormattingEnabled = true;
            this.c1.Items.AddRange(new object[] {
            "Typ 1",
            "Typ 2"});
            this.c1.Location = new System.Drawing.Point(362, 377);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(121, 28);
            this.c1.TabIndex = 1;
            // 
            // nuF1
            // 
            this.nuF1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.nuF1.Location = new System.Drawing.Point(362, 87);
            this.nuF1.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.nuF1.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nuF1.Name = "nuF1";
            this.nuF1.Size = new System.Drawing.Size(73, 27);
            this.nuF1.TabIndex = 11;
            this.nuF1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nuF1.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nuF1.ValueChanged += new System.EventHandler(this.nuF1_ValueChanged);
            // 
            // nuF2
            // 
            this.nuF2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.nuF2.Location = new System.Drawing.Point(362, 120);
            this.nuF2.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nuF2.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nuF2.Name = "nuF2";
            this.nuF2.Size = new System.Drawing.Size(73, 27);
            this.nuF2.TabIndex = 12;
            this.nuF2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nuF2.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nuF2.ValueChanged += new System.EventHandler(this.nuF2_ValueChanged);
            // 
            // MenuP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 441);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MenuP";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sampleX";
            this.Load += new System.EventHandler(this.MenuP_Load);
            this.Shown += new System.EventHandler(this.MenuP_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nuC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuF1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuF2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lStatus;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox c1;
        private System.Windows.Forms.NumericUpDown nu4;
        private System.Windows.Forms.NumericUpDown nu3;
        private System.Windows.Forms.NumericUpDown nu2;
        private System.Windows.Forms.NumericUpDown nu1;
        private System.Windows.Forms.NumericUpDown nuC;
        private System.Windows.Forms.NumericUpDown nuR;
        private System.Windows.Forms.NumericUpDown nuF1;
        private System.Windows.Forms.NumericUpDown nuF2;
    }
}