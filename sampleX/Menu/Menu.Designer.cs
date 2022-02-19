namespace sampleX
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bC = new System.Windows.Forms.Button();
            this.bN = new System.Windows.Forms.Button();
            this.bV = new System.Windows.Forms.Button();
            this.bZ = new System.Windows.Forms.Button();
            this.bPassCh = new System.Windows.Forms.Button();
            this.rokUD = new System.Windows.Forms.NumericUpDown();
            this.bSelect = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rokUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 204);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 8, 0);
            this.statusStrip1.Size = new System.Drawing.Size(444, 22);
            this.statusStrip1.TabIndex = 101;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lStatus
            // 
            this.lStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lStatus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(117, 17);
            this.lStatus.Text = "toolStripStatusLabel1";
            // 
            // bC
            // 
            this.bC.Enabled = false;
            this.bC.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bC.Location = new System.Drawing.Point(9, 55);
            this.bC.Margin = new System.Windows.Forms.Padding(2);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(130, 35);
            this.bC.TabIndex = 3;
            this.bC.Text = "Čís&elniky";
            this.toolTip1.SetToolTip(this.bC, "Správa číselníkov");
            this.bC.UseVisualStyleBackColor = true;
            this.bC.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // bN
            // 
            this.bN.Enabled = false;
            this.bN.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bN.Location = new System.Drawing.Point(9, 16);
            this.bN.Margin = new System.Windows.Forms.Padding(2);
            this.bN.Name = "bN";
            this.bN.Size = new System.Drawing.Size(130, 35);
            this.bN.TabIndex = 4;
            this.bN.Text = "&Nastavenia";
            this.toolTip1.SetToolTip(this.bN, "Administrácia");
            this.bN.UseVisualStyleBackColor = true;
            this.bN.Click += new System.EventHandler(this.button1_Click);
            // 
            // bV
            // 
            this.bV.Enabled = false;
            this.bV.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bV.Location = new System.Drawing.Point(9, 55);
            this.bV.Margin = new System.Windows.Forms.Padding(2);
            this.bV.Name = "bV";
            this.bV.Size = new System.Drawing.Size(130, 35);
            this.bV.TabIndex = 2;
            this.bV.Text = "Výs&ledky";
            this.toolTip1.SetToolTip(this.bV, "Zadávanie a oprava výsledkov");
            this.bV.UseVisualStyleBackColor = true;
            this.bV.Click += new System.EventHandler(this.button9_Click);
            // 
            // bZ
            // 
            this.bZ.Enabled = false;
            this.bZ.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bZ.Location = new System.Drawing.Point(9, 16);
            this.bZ.Margin = new System.Windows.Forms.Padding(2);
            this.bZ.Name = "bZ";
            this.bZ.Size = new System.Drawing.Size(130, 35);
            this.bZ.TabIndex = 1;
            this.bZ.Text = "&Zákazky";
            this.toolTip1.SetToolTip(this.bZ, "Správa zákazníkov, objednávok, zmlúv, laboratórnych čísel");
            this.bZ.UseVisualStyleBackColor = true;
            this.bZ.Click += new System.EventHandler(this.button10_Click);
            // 
            // bPassCh
            // 
            this.bPassCh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bPassCh.BackgroundImage")));
            this.bPassCh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bPassCh.FlatAppearance.BorderSize = 0;
            this.bPassCh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bPassCh.Location = new System.Drawing.Point(325, 70);
            this.bPassCh.Margin = new System.Windows.Forms.Padding(2);
            this.bPassCh.Name = "bPassCh";
            this.bPassCh.Size = new System.Drawing.Size(25, 25);
            this.bPassCh.TabIndex = 5;
            this.toolTip1.SetToolTip(this.bPassCh, "Zmena hesla");
            this.bPassCh.UseVisualStyleBackColor = true;
            this.bPassCh.Click += new System.EventHandler(this.bPassCh_Click);
            // 
            // rokUD
            // 
            this.rokUD.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rokUD.Location = new System.Drawing.Point(359, 68);
            this.rokUD.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.rokUD.Minimum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.rokUD.Name = "rokUD";
            this.rokUD.Size = new System.Drawing.Size(73, 27);
            this.rokUD.TabIndex = 121;
            this.rokUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.rokUD, "Nastavenie aktuálneho obdobia");
            this.rokUD.Value = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.rokUD.ValueChanged += new System.EventHandler(this.rokUD_ValueChanged);
            // 
            // bSelect
            // 
            this.bSelect.Image = ((System.Drawing.Image)(resources.GetObject("bSelect.Image")));
            this.bSelect.Location = new System.Drawing.Point(336, 149);
            this.bSelect.Name = "bSelect";
            this.bSelect.Size = new System.Drawing.Size(45, 45);
            this.bSelect.TabIndex = 122;
            this.toolTip1.SetToolTip(this.bSelect, "Vygenerované laboratórne čísla");
            this.bSelect.UseVisualStyleBackColor = true;
            this.bSelect.Click += new System.EventHandler(this.bSelect_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::sampleX.Properties.Resources.Lab_science_ToneMapping;
            this.pictureBox2.Location = new System.Drawing.Point(12, 111);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(420, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 102;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(387, 11);
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
            this.groupBox1.Controls.Add(this.bZ);
            this.groupBox1.Controls.Add(this.bV);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 100);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bN);
            this.groupBox2.Controls.Add(this.bC);
            this.groupBox2.Location = new System.Drawing.Point(167, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 100);
            this.groupBox2.TabIndex = 104;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(387, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 123;
            this.toolTip1.SetToolTip(this.button1, "Vygenerované laboratórne čísla");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 226);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bSelect);
            this.Controls.Add(this.rokUD);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bPassCh);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sampleX - Hlavné menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.Shown += new System.EventHandler(this.Menu_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rokUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lStatus;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button bPassCh;
        private System.Windows.Forms.Button bC;
        private System.Windows.Forms.Button bN;
        private System.Windows.Forms.Button bV;
        private System.Windows.Forms.Button bZ;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown rokUD;
        private System.Windows.Forms.Button bSelect;
        private System.Windows.Forms.Button button1;
    }
}