﻿namespace sampleX
{
    partial class DataA
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataA));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cOdd = new System.Windows.Forms.ComboBox();
            this.cJednotka = new System.Windows.Forms.ComboBox();
            this.cOzn = new System.Windows.Forms.ComboBox();
            this.cPrincip = new System.Windows.Forms.ComboBox();
            this.cMatrica = new System.Windows.Forms.ComboBox();
            this.cPolozka = new System.Windows.Forms.ComboBox();
            this.bDel = new System.Windows.Forms.Button();
            this.bDown = new System.Windows.Forms.Button();
            this.bUp = new System.Windows.Forms.Button();
            this.bOK = new System.Windows.Forms.Button();
            this.bAddAll = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bDelLc = new System.Windows.Forms.Button();
            this.cMain = new System.Windows.Forms.ComboBox();
            this.dg2 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lAuto = new System.Windows.Forms.Label();
            this.dg = new System.Windows.Forms.DataGridView();
            this.lManual = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dg3 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.ldg3 = new System.Windows.Forms.Label();
            this.ldg = new System.Windows.Forms.Label();
            this.ldg2 = new System.Windows.Forms.Label();
            this.bMatrica = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg3)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 533);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 8, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1083, 22);
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
            // cOdd
            // 
            this.cOdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cOdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cOdd.FormattingEnabled = true;
            this.cOdd.Location = new System.Drawing.Point(261, 138);
            this.cOdd.Name = "cOdd";
            this.cOdd.Size = new System.Drawing.Size(246, 25);
            this.cOdd.TabIndex = 129;
            this.toolTip1.SetToolTip(this.cOdd, "Oddelenie");
            // 
            // cJednotka
            // 
            this.cJednotka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cJednotka.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cJednotka.FormattingEnabled = true;
            this.cJednotka.Location = new System.Drawing.Point(9, 138);
            this.cJednotka.Name = "cJednotka";
            this.cJednotka.Size = new System.Drawing.Size(246, 25);
            this.cJednotka.TabIndex = 127;
            this.toolTip1.SetToolTip(this.cJednotka, "Jednotky");
            // 
            // cOzn
            // 
            this.cOzn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cOzn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cOzn.FormattingEnabled = true;
            this.cOzn.Location = new System.Drawing.Point(261, 87);
            this.cOzn.Name = "cOzn";
            this.cOzn.Size = new System.Drawing.Size(246, 25);
            this.cOzn.TabIndex = 122;
            this.toolTip1.SetToolTip(this.cOzn, "Princíp");
            // 
            // cPrincip
            // 
            this.cPrincip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cPrincip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cPrincip.FormattingEnabled = true;
            this.cPrincip.Location = new System.Drawing.Point(9, 87);
            this.cPrincip.Name = "cPrincip";
            this.cPrincip.Size = new System.Drawing.Size(246, 25);
            this.cPrincip.TabIndex = 121;
            this.toolTip1.SetToolTip(this.cPrincip, "Princíp");
            // 
            // cMatrica
            // 
            this.cMatrica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cMatrica.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cMatrica.FormattingEnabled = true;
            this.cMatrica.Location = new System.Drawing.Point(261, 36);
            this.cMatrica.Name = "cMatrica";
            this.cMatrica.Size = new System.Drawing.Size(215, 25);
            this.cMatrica.TabIndex = 120;
            this.toolTip1.SetToolTip(this.cMatrica, "Matrica");
            // 
            // cPolozka
            // 
            this.cPolozka.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cPolozka.FormattingEnabled = true;
            this.cPolozka.Location = new System.Drawing.Point(9, 36);
            this.cPolozka.Name = "cPolozka";
            this.cPolozka.Size = new System.Drawing.Size(246, 25);
            this.cPolozka.TabIndex = 119;
            this.toolTip1.SetToolTip(this.cPolozka, "Položka");
            // 
            // bDel
            // 
            this.bDel.Image = global::sampleX.Properties.Resources.Button_Close_icon;
            this.bDel.Location = new System.Drawing.Point(379, 182);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(42, 42);
            this.bDel.TabIndex = 138;
            this.toolTip1.SetToolTip(this.bDel, "Odober prameter");
            this.bDel.UseVisualStyleBackColor = true;
            this.bDel.Click += new System.EventHandler(this.bDel_Click);
            // 
            // bDown
            // 
            this.bDown.Image = global::sampleX.Properties.Resources._down;
            this.bDown.Location = new System.Drawing.Point(465, 182);
            this.bDown.Name = "bDown";
            this.bDown.Size = new System.Drawing.Size(42, 42);
            this.bDown.TabIndex = 137;
            this.toolTip1.SetToolTip(this.bDown, "Presuň záznam nižšie");
            this.bDown.UseVisualStyleBackColor = true;
            this.bDown.Click += new System.EventHandler(this.bDown_Click);
            // 
            // bUp
            // 
            this.bUp.Image = global::sampleX.Properties.Resources._up;
            this.bUp.Location = new System.Drawing.Point(422, 182);
            this.bUp.Name = "bUp";
            this.bUp.Size = new System.Drawing.Size(42, 42);
            this.bUp.TabIndex = 136;
            this.toolTip1.SetToolTip(this.bUp, "Presuň záznam vyššie");
            this.bUp.UseVisualStyleBackColor = true;
            this.bUp.Click += new System.EventHandler(this.bUp_Click);
            // 
            // bOK
            // 
            this.bOK.Image = global::sampleX.Properties.Resources.accept_icon;
            this.bOK.Location = new System.Drawing.Point(1035, 488);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(42, 42);
            this.bOK.TabIndex = 135;
            this.toolTip1.SetToolTip(this.bOK, "Vytvor požiadavku na meranie pre zvolené laboratórne čísla a parametre");
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // bAddAll
            // 
            this.bAddAll.Image = global::sampleX.Properties.Resources.Button_Forward_icon__1_;
            this.bAddAll.Location = new System.Drawing.Point(52, 182);
            this.bAddAll.Name = "bAddAll";
            this.bAddAll.Size = new System.Drawing.Size(42, 42);
            this.bAddAll.TabIndex = 134;
            this.toolTip1.SetToolTip(this.bAddAll, "Pridaj všetky parametre v zozname");
            this.bAddAll.UseVisualStyleBackColor = true;
            this.bAddAll.Click += new System.EventHandler(this.bAddAll_Click);
            // 
            // bAdd
            // 
            this.bAdd.Image = global::sampleX.Properties.Resources.Button_Play_icon__1_;
            this.bAdd.Location = new System.Drawing.Point(9, 182);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(42, 42);
            this.bAdd.TabIndex = 133;
            this.toolTip1.SetToolTip(this.bAdd, "Pridaj zvolený parameter");
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bDelLc
            // 
            this.bDelLc.Image = global::sampleX.Properties.Resources.Button_Close_icon;
            this.bDelLc.Location = new System.Drawing.Point(912, 488);
            this.bDelLc.Name = "bDelLc";
            this.bDelLc.Size = new System.Drawing.Size(42, 42);
            this.bDelLc.TabIndex = 139;
            this.toolTip1.SetToolTip(this.bDelLc, "Odober laboratórne číslo");
            this.bDelLc.UseVisualStyleBackColor = true;
            this.bDelLc.Click += new System.EventHandler(this.bDelLc_Click);
            // 
            // cMain
            // 
            this.cMain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cMain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cMain.FormattingEnabled = true;
            this.cMain.Location = new System.Drawing.Point(12, 10);
            this.cMain.Name = "cMain";
            this.cMain.Size = new System.Drawing.Size(362, 25);
            this.cMain.TabIndex = 102;
            this.cMain.SelectedIndexChanged += new System.EventHandler(this.cMain_SelectedIndexChanged);
            this.cMain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cMain_KeyPress);
            // 
            // dg2
            // 
            this.dg2.AllowUserToAddRows = false;
            this.dg2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dg2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg2.ColumnHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dg2.Location = new System.Drawing.Point(12, 58);
            this.dg2.Name = "dg2";
            this.dg2.ReadOnly = true;
            this.dg2.RowHeadersVisible = false;
            this.dg2.RowTemplate.Height = 24;
            this.dg2.Size = new System.Drawing.Size(362, 207);
            this.dg2.TabIndex = 103;
            this.dg2.SelectionChanged += new System.EventHandler(this.dg2_SelectionChanged);
            this.dg2.Paint += new System.Windows.Forms.PaintEventHandler(this.dg2_Paint);
            this.dg2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dg2_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Location = new System.Drawing.Point(258, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 130;
            this.label9.Text = "Oddelenie";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(6, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 128;
            this.label8.Text = "Jednotky";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(258, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 126;
            this.label7.Text = "Označenie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(6, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 125;
            this.label6.Text = "Princíp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(258, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 124;
            this.label5.Text = "Matrica";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(6, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 123;
            this.label4.Text = "Položka";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bMatrica);
            this.groupBox1.Controls.Add(this.bDel);
            this.groupBox1.Controls.Add(this.bDown);
            this.groupBox1.Controls.Add(this.bUp);
            this.groupBox1.Controls.Add(this.bAddAll);
            this.groupBox1.Controls.Add(this.bAdd);
            this.groupBox1.Controls.Add(this.cMatrica);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cPolozka);
            this.groupBox1.Controls.Add(this.cOdd);
            this.groupBox1.Controls.Add(this.cPrincip);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cOzn);
            this.groupBox1.Controls.Add(this.cJednotka);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(388, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 230);
            this.groupBox1.TabIndex = 131;
            this.groupBox1.TabStop = false;
            // 
            // lAuto
            // 
            this.lAuto.AutoSize = true;
            this.lAuto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lAuto.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lAuto.Location = new System.Drawing.Point(9, 37);
            this.lAuto.Name = "lAuto";
            this.lAuto.Size = new System.Drawing.Size(267, 17);
            this.lAuto.TabIndex = 132;
            this.lAuto.Text = "Zadávanie vlastností merania podľa číselníka";
            this.lAuto.Visible = false;
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(12, 286);
            this.dg.MultiSelect = false;
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.RowHeadersVisible = false;
            this.dg.RowTemplate.Height = 24;
            this.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg.Size = new System.Drawing.Size(892, 229);
            this.dg.TabIndex = 134;
            this.dg.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dg_RowsAdded);
            this.dg.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dg_RowsRemoved);
            this.dg.Paint += new System.Windows.Forms.PaintEventHandler(this.dg_Paint);
            this.dg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dg_KeyPress);
            // 
            // lManual
            // 
            this.lManual.AutoSize = true;
            this.lManual.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lManual.ForeColor = System.Drawing.Color.Red;
            this.lManual.Location = new System.Drawing.Point(9, 37);
            this.lManual.Name = "lManual";
            this.lManual.Size = new System.Drawing.Size(236, 17);
            this.lManual.TabIndex = 135;
            this.lManual.Text = "Manuálne zadávanie vlastností merania";
            this.lManual.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(394, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 139;
            this.label1.Text = "Položka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(394, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 140;
            this.label2.Text = "Položka";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1038, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 109;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover_1);
            // 
            // dg3
            // 
            this.dg3.AllowUserToAddRows = false;
            this.dg3.AllowUserToOrderColumns = true;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dg3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dg3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dg3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg3.Location = new System.Drawing.Point(913, 58);
            this.dg3.Name = "dg3";
            this.dg3.ReadOnly = true;
            this.dg3.RowHeadersVisible = false;
            this.dg3.RowTemplate.Height = 24;
            this.dg3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg3.Size = new System.Drawing.Size(163, 411);
            this.dg3.TabIndex = 141;
            this.dg3.Paint += new System.Windows.Forms.PaintEventHandler(this.dg3_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(910, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 142;
            this.label3.Text = "Laboratórne čísla";
            // 
            // ldg3
            // 
            this.ldg3.AutoSize = true;
            this.ldg3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ldg3.Location = new System.Drawing.Point(910, 472);
            this.ldg3.Name = "ldg3";
            this.ldg3.Size = new System.Drawing.Size(30, 13);
            this.ldg3.TabIndex = 143;
            this.ldg3.Text = "ldg3";
            // 
            // ldg
            // 
            this.ldg.AutoSize = true;
            this.ldg.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ldg.Location = new System.Drawing.Point(9, 517);
            this.ldg.Name = "ldg";
            this.ldg.Size = new System.Drawing.Size(24, 13);
            this.ldg.TabIndex = 144;
            this.ldg.Text = "ldg";
            // 
            // ldg2
            // 
            this.ldg2.AutoSize = true;
            this.ldg2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ldg2.Location = new System.Drawing.Point(9, 268);
            this.ldg2.Name = "ldg2";
            this.ldg2.Size = new System.Drawing.Size(30, 13);
            this.ldg2.TabIndex = 145;
            this.ldg2.Text = "ldg2";
            // 
            // bMatrica
            // 
            this.bMatrica.BackgroundImage = global::sampleX.Properties.Resources.Arrows_icon;
            this.bMatrica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bMatrica.Location = new System.Drawing.Point(482, 36);
            this.bMatrica.Name = "bMatrica";
            this.bMatrica.Size = new System.Drawing.Size(25, 25);
            this.bMatrica.TabIndex = 146;
            this.toolTip1.SetToolTip(this.bMatrica, "Distribuovať vlastnosť do celej skupiny");
            this.bMatrica.UseVisualStyleBackColor = true;
            this.bMatrica.Click += new System.EventHandler(this.bMatrica_Click);
            // 
            // DataA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 555);
            this.Controls.Add(this.ldg2);
            this.Controls.Add(this.ldg);
            this.Controls.Add(this.ldg3);
            this.Controls.Add(this.bDelLc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dg3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lManual);
            this.Controls.Add(this.lAuto);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dg2);
            this.Controls.Add(this.cMain);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "DataA";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sampleX - Hlavné menu";
            this.Load += new System.EventHandler(this.DataA_Load);
            this.Shown += new System.EventHandler(this.DataA_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lStatus;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cMain;
        private System.Windows.Forms.DataGridView dg2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cOdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cJednotka;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cOzn;
        private System.Windows.Forms.ComboBox cPrincip;
        private System.Windows.Forms.ComboBox cMatrica;
        private System.Windows.Forms.ComboBox cPolozka;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lAuto;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bAddAll;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.Label lManual;
        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.Button bDown;
        private System.Windows.Forms.Button bUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dg3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bDelLc;
        private System.Windows.Forms.Label ldg3;
        private System.Windows.Forms.Label ldg;
        private System.Windows.Forms.Label ldg2;
        private System.Windows.Forms.Button bMatrica;
    }
}