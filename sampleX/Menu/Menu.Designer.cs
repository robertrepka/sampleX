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
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bArchiv = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rokUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 266);
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
            this.bC.TabIndex = 4;
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
            this.bN.TabIndex = 3;
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
            this.bPassCh.Location = new System.Drawing.Point(331, 124);
            this.bPassCh.Margin = new System.Windows.Forms.Padding(2);
            this.bPassCh.Name = "bPassCh";
            this.bPassCh.Size = new System.Drawing.Size(28, 28);
            this.bPassCh.TabIndex = 6;
            this.toolTip1.SetToolTip(this.bPassCh, "Zmena hesla");
            this.bPassCh.UseVisualStyleBackColor = true;
            this.bPassCh.Click += new System.EventHandler(this.bPassCh_Click);
            // 
            // rokUD
            // 
            this.rokUD.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rokUD.Location = new System.Drawing.Point(367, 124);
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
            this.rokUD.Size = new System.Drawing.Size(65, 27);
            this.rokUD.TabIndex = 7;
            this.rokUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.rokUD, "Nastavenie aktuálneho obdobia");
            this.rokUD.Value = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.rokUD.ValueChanged += new System.EventHandler(this.rokUD_ValueChanged);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(92, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 45);
            this.button3.TabIndex = 122;
            this.toolTip1.SetToolTip(this.button3, "Vygenerované laboratórne čísla");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.bSelect_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(155, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 123;
            this.toolTip1.SetToolTip(this.button1, "Vygenerované laboratórne čísla");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(21, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 45);
            this.button2.TabIndex = 124;
            this.toolTip1.SetToolTip(this.button2, "Vygenerované laboratórne čísla");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::sampleX.Properties.Resources.Lab_science_ToneMapping;
            this.pictureBox2.Location = new System.Drawing.Point(12, 174);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(420, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 102;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(367, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 100;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bZ);
            this.groupBox1.Controls.Add(this.bV);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 100);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bN);
            this.groupBox2.Controls.Add(this.bC);
            this.groupBox2.Location = new System.Drawing.Point(167, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 100);
            this.groupBox2.TabIndex = 104;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bArchiv);
            this.groupBox3.Location = new System.Drawing.Point(12, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 63);
            this.groupBox3.TabIndex = 105;
            this.groupBox3.TabStop = false;
            // 
            // bArchiv
            // 
            this.bArchiv.Enabled = false;
            this.bArchiv.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bArchiv.Location = new System.Drawing.Point(9, 16);
            this.bArchiv.Margin = new System.Windows.Forms.Padding(2);
            this.bArchiv.Name = "bArchiv";
            this.bArchiv.Size = new System.Drawing.Size(285, 35);
            this.bArchiv.TabIndex = 5;
            this.bArchiv.Text = "&Vydané protokoly - archív";
            this.toolTip1.SetToolTip(this.bArchiv, "Skeny protokolov a dokumentov");
            this.bArchiv.UseVisualStyleBackColor = true;
            this.bArchiv.Click += new System.EventHandler(this.bArchiv_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 288);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
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
            this.groupBox3.ResumeLayout(false);
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bArchiv;
    }
}