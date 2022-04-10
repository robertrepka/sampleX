namespace sampleX
{
    partial class MenuC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuC));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bPrincip = new System.Windows.Forms.Button();
            this.bMatrica = new System.Windows.Forms.Button();
            this.bParameter = new System.Windows.Forms.Button();
            this.bOzn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.bFilter = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.bSuper = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.statusStrip1.SuspendLayout();
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 8, 0);
            this.statusStrip1.Size = new System.Drawing.Size(330, 22);
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
            // bPrincip
            // 
            this.bPrincip.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bPrincip.Location = new System.Drawing.Point(20, 59);
            this.bPrincip.Margin = new System.Windows.Forms.Padding(2);
            this.bPrincip.Name = "bPrincip";
            this.bPrincip.Size = new System.Drawing.Size(130, 35);
            this.bPrincip.TabIndex = 3;
            this.bPrincip.Text = "&Principy";
            this.toolTip1.SetToolTip(this.bPrincip, "Číselník princípov");
            this.bPrincip.UseVisualStyleBackColor = true;
            this.bPrincip.Click += new System.EventHandler(this.bPrincip_Click);
            // 
            // bMatrica
            // 
            this.bMatrica.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bMatrica.Location = new System.Drawing.Point(20, 17);
            this.bMatrica.Margin = new System.Windows.Forms.Padding(2);
            this.bMatrica.Name = "bMatrica";
            this.bMatrica.Size = new System.Drawing.Size(130, 35);
            this.bMatrica.TabIndex = 1;
            this.bMatrica.Text = "&Matrice";
            this.toolTip1.SetToolTip(this.bMatrica, "Číselník matríc");
            this.bMatrica.UseVisualStyleBackColor = true;
            this.bMatrica.Click += new System.EventHandler(this.button6_Click);
            // 
            // bParameter
            // 
            this.bParameter.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bParameter.Location = new System.Drawing.Point(157, 17);
            this.bParameter.Margin = new System.Windows.Forms.Padding(2);
            this.bParameter.Name = "bParameter";
            this.bParameter.Size = new System.Drawing.Size(130, 35);
            this.bParameter.TabIndex = 2;
            this.bParameter.Text = "Pa&rametre";
            this.toolTip1.SetToolTip(this.bParameter, "Číselník parametrov");
            this.bParameter.UseVisualStyleBackColor = true;
            this.bParameter.Click += new System.EventHandler(this.button8_Click);
            // 
            // bOzn
            // 
            this.bOzn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bOzn.Location = new System.Drawing.Point(169, 62);
            this.bOzn.Margin = new System.Windows.Forms.Padding(2);
            this.bOzn.Name = "bOzn";
            this.bOzn.Size = new System.Drawing.Size(130, 35);
            this.bOzn.TabIndex = 4;
            this.bOzn.Text = "Oz&načenie";
            this.toolTip1.SetToolTip(this.bOzn, "Číselník označení");
            this.bOzn.UseVisualStyleBackColor = true;
            this.bOzn.Click += new System.EventHandler(this.bOzn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(20, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "&Vlastné skupiny parametrov";
            this.toolTip1.SetToolTip(this.button1, "Priradenie parametrov do vlastných skupín");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button7.Location = new System.Drawing.Point(169, 104);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(130, 35);
            this.button7.TabIndex = 6;
            this.button7.Text = "Odd&elenie";
            this.toolTip1.SetToolTip(this.button7, "Číselník oddelení");
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // bFilter
            // 
            this.bFilter.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bFilter.Location = new System.Drawing.Point(20, 56);
            this.bFilter.Margin = new System.Windows.Forms.Padding(2);
            this.bFilter.Name = "bFilter";
            this.bFilter.Size = new System.Drawing.Size(267, 35);
            this.bFilter.TabIndex = 10;
            this.bFilter.Text = "Rozsah akreditácie (&A)";
            this.toolTip1.SetToolTip(this.bFilter, "Rozsah akreditácie s neistotami");
            this.bFilter.UseVisualStyleBackColor = true;
            this.bFilter.Click += new System.EventHandler(this.bFilter_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Location = new System.Drawing.Point(20, 101);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 35);
            this.button6.TabIndex = 5;
            this.button6.Text = "&Jednotky";
            this.toolTip1.SetToolTip(this.button6, "Číselník jednotiek");
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // bSuper
            // 
            this.bSuper.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bSuper.Location = new System.Drawing.Point(20, 17);
            this.bSuper.Margin = new System.Windows.Forms.Padding(2);
            this.bSuper.Name = "bSuper";
            this.bSuper.Size = new System.Drawing.Size(267, 35);
            this.bSuper.TabIndex = 139;
            this.bSuper.Text = "&Indexy";
            this.toolTip1.SetToolTip(this.bSuper, "Znaky pre horný a dolný index");
            this.bSuper.UseVisualStyleBackColor = true;
            this.bSuper.Click += new System.EventHandler(this.bSuper_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(20, 97);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(267, 35);
            this.button2.TabIndex = 12;
            this.button2.Text = "Neakreditované skúšky (&N)";
            this.toolTip1.SetToolTip(this.button2, "Rozsah akreditácie s neistotami");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(142, 306);
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
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.bPrincip);
            this.groupBox1.Controls.Add(this.bMatrica);
            this.groupBox1.Controls.Add(this.bParameter);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 148);
            this.groupBox1.TabIndex = 137;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.bFilter);
            this.groupBox2.Location = new System.Drawing.Point(12, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 145);
            this.groupBox2.TabIndex = 138;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bSuper);
            this.groupBox3.Location = new System.Drawing.Point(12, 351);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 63);
            this.groupBox3.TabIndex = 139;
            this.groupBox3.TabStop = false;
            // 
            // MenuC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 446);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.bOzn);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MenuC";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sampleX";
            this.Load += new System.EventHandler(this.MenuC_Load);
            this.Shown += new System.EventHandler(this.MenuC_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.Button bPrincip;
        private System.Windows.Forms.Button bMatrica;
        private System.Windows.Forms.Button bParameter;
        private System.Windows.Forms.Button bOzn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button bFilter;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bSuper;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
    }
}