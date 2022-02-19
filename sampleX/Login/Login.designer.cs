namespace sampleX
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tPass = new System.Windows.Forms.TextBox();
            this.tUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.btnOK.Location = new System.Drawing.Point(120, 132);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(94, 32);
            this.btnOK.TabIndex = 3;
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
            this.btnCancel.Location = new System.Drawing.Point(19, 132);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 32);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "&Zruš";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // tPass
            // 
            this.tPass.AcceptsReturn = true;
            this.tPass.AcceptsTab = true;
            this.tPass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tPass.ForeColor = System.Drawing.Color.Black;
            this.tPass.Location = new System.Drawing.Point(12, 82);
            this.tPass.Name = "tPass";
            this.tPass.Size = new System.Drawing.Size(195, 25);
            this.tPass.TabIndex = 2;
            this.tPass.UseSystemPasswordChar = true;
            this.tPass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tPass_KeyUp);
            this.tPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tPass_KeyPress);
            // 
            // tUser
            // 
            this.tUser.AcceptsReturn = true;
            this.tUser.AcceptsTab = true;
            this.tUser.BackColor = System.Drawing.Color.White;
            this.tUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tUser.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tUser.Location = new System.Drawing.Point(12, 31);
            this.tUser.Name = "tUser";
            this.tUser.Size = new System.Drawing.Size(195, 25);
            this.tUser.TabIndex = 1;
            this.tUser.TextChanged += new System.EventHandler(this.tUser_TextChanged);
            this.tUser.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tUser_KeyUp);
            this.tUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tUser_KeyPress);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(9, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Meno";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tPass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tUser);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox1.Location = new System.Drawing.Point(7, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 121);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(9, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Heslo";
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(234, 177);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Opacity = 0;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SampleX - LOGIN";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Login_Load);
            this.Shown += new System.EventHandler(this.Login_Shown);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tPass;
        private System.Windows.Forms.TextBox tUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}