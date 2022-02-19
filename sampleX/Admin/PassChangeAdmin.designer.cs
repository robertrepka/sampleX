namespace sampleX
{
    partial class PassChangeAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassChangeAdmin));
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tNew1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tNew2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.Control;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnOK.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnOK.Location = new System.Drawing.Point(120, 136);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(94, 32);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnCancel.Location = new System.Drawing.Point(19, 136);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 32);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Zruš";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // tNew1
            // 
            this.tNew1.AcceptsReturn = true;
            this.tNew1.AcceptsTab = true;
            this.tNew1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tNew1.ForeColor = System.Drawing.Color.Black;
            this.tNew1.Location = new System.Drawing.Point(11, 35);
            this.tNew1.Name = "tNew1";
            this.tNew1.Size = new System.Drawing.Size(195, 25);
            this.tNew1.TabIndex = 2;
            this.tNew1.UseSystemPasswordChar = true;
            this.tNew1.TextChanged += new System.EventHandler(this.tNew1_TextChanged);
            this.tNew1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tPass_KeyUp);
            this.tNew1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tPass_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tNew2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tNew1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox1.Location = new System.Drawing.Point(4, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 128);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // tNew2
            // 
            this.tNew2.AcceptsReturn = true;
            this.tNew2.AcceptsTab = true;
            this.tNew2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tNew2.ForeColor = System.Drawing.Color.Black;
            this.tNew2.Location = new System.Drawing.Point(11, 88);
            this.tNew2.Name = "tNew2";
            this.tNew2.Size = new System.Drawing.Size(195, 25);
            this.tNew2.TabIndex = 3;
            this.tNew2.UseSystemPasswordChar = true;
            this.tNew2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tNew2_KeyUp);
            this.tNew2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tNew2_KeyPress);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(8, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nové heslo";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nové heslo";
            // 
            // PassChangeAdmin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(234, 179);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PassChangeAdmin";
            this.Opacity = 0;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SampleX - ZMENA HESLA";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PassChangeAdmin_Load);
            this.Shown += new System.EventHandler(this.PassChangeAdmin_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PassChangeAdmin_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tNew1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tNew2;
        private System.Windows.Forms.Label label2;
    }
}