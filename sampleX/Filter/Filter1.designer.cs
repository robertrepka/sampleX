namespace sampleX
{
    partial class Filter1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Filter1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cPolozka = new System.Windows.Forms.ComboBox();
            this.cMatrica = new System.Windows.Forms.ComboBox();
            this.cPrincip = new System.Windows.Forms.ComboBox();
            this.cOzn = new System.Windows.Forms.ComboBox();
            this.cJednotka = new System.Windows.Forms.ComboBox();
            this.cOdd = new System.Windows.Forms.ComboBox();
            this.bOdd = new System.Windows.Forms.Button();
            this.bJednotka = new System.Windows.Forms.Button();
            this.bOzn = new System.Windows.Forms.Button();
            this.bPrincip = new System.Windows.Forms.Button();
            this.bMatrica = new System.Windows.Forms.Button();
            this.bPolozka = new System.Windows.Forms.Button();
            this.bClone = new System.Windows.Forms.Button();
            this.bAll = new System.Windows.Forms.Button();
            this.bNew = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bRename = new System.Windows.Forms.Button();
            this.cMain = new System.Windows.Forms.ComboBox();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.dg2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ldg2 = new System.Windows.Forms.Label();
            this.ldg1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dg3 = new System.Windows.Forms.DataGridView();
            this.ldg3 = new System.Windows.Forms.Label();
            this.bAkr = new System.Windows.Forms.Button();
            this.dg4 = new System.Windows.Forms.DataGridView();
            this.ldg4 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg4)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 513);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 8, 0);
            this.statusStrip1.Size = new System.Drawing.Size(955, 22);
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
            // cPolozka
            // 
            this.cPolozka.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cPolozka.FormattingEnabled = true;
            this.cPolozka.Location = new System.Drawing.Point(7, 33);
            this.cPolozka.Name = "cPolozka";
            this.cPolozka.Size = new System.Drawing.Size(314, 25);
            this.cPolozka.TabIndex = 61;
            this.toolTip1.SetToolTip(this.cPolozka, "Položka");
            this.cPolozka.SelectedIndexChanged += new System.EventHandler(this.cPolozka_SelectedIndexChanged);
            this.cPolozka.TextUpdate += new System.EventHandler(this.cPolozka_TextUpdate);
            this.cPolozka.TextChanged += new System.EventHandler(this.cPolozka_TextChanged);
            // 
            // cMatrica
            // 
            this.cMatrica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cMatrica.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cMatrica.FormattingEnabled = true;
            this.cMatrica.Location = new System.Drawing.Point(7, 85);
            this.cMatrica.Name = "cMatrica";
            this.cMatrica.Size = new System.Drawing.Size(314, 25);
            this.cMatrica.TabIndex = 62;
            this.toolTip1.SetToolTip(this.cMatrica, "Matrica");
            this.cMatrica.SelectedIndexChanged += new System.EventHandler(this.cMatrica_SelectedIndexChanged);
            // 
            // cPrincip
            // 
            this.cPrincip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cPrincip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cPrincip.FormattingEnabled = true;
            this.cPrincip.Location = new System.Drawing.Point(7, 137);
            this.cPrincip.Name = "cPrincip";
            this.cPrincip.Size = new System.Drawing.Size(314, 25);
            this.cPrincip.TabIndex = 63;
            this.toolTip1.SetToolTip(this.cPrincip, "Princíp");
            this.cPrincip.SelectedIndexChanged += new System.EventHandler(this.cPrincip_SelectedIndexChanged);
            // 
            // cOzn
            // 
            this.cOzn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cOzn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cOzn.FormattingEnabled = true;
            this.cOzn.Location = new System.Drawing.Point(7, 189);
            this.cOzn.Name = "cOzn";
            this.cOzn.Size = new System.Drawing.Size(314, 25);
            this.cOzn.TabIndex = 64;
            this.toolTip1.SetToolTip(this.cOzn, "Princíp");
            this.cOzn.SelectedIndexChanged += new System.EventHandler(this.cOzn_SelectedIndexChanged);
            // 
            // cJednotka
            // 
            this.cJednotka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cJednotka.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cJednotka.FormattingEnabled = true;
            this.cJednotka.Location = new System.Drawing.Point(7, 242);
            this.cJednotka.Name = "cJednotka";
            this.cJednotka.Size = new System.Drawing.Size(314, 25);
            this.cJednotka.TabIndex = 65;
            this.toolTip1.SetToolTip(this.cJednotka, "Jednotky");
            this.cJednotka.SelectedIndexChanged += new System.EventHandler(this.cJednotka_SelectedIndexChanged);
            // 
            // cOdd
            // 
            this.cOdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cOdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cOdd.FormattingEnabled = true;
            this.cOdd.Location = new System.Drawing.Point(7, 294);
            this.cOdd.Name = "cOdd";
            this.cOdd.Size = new System.Drawing.Size(314, 25);
            this.cOdd.TabIndex = 66;
            this.toolTip1.SetToolTip(this.cOdd, "Oddelenie");
            this.cOdd.SelectedIndexChanged += new System.EventHandler(this.cOdd_SelectedIndexChanged);
            // 
            // bOdd
            // 
            this.bOdd.BackgroundImage = global::sampleX.Properties.Resources.Arrows_icon;
            this.bOdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bOdd.Location = new System.Drawing.Point(922, 350);
            this.bOdd.Name = "bOdd";
            this.bOdd.Size = new System.Drawing.Size(25, 25);
            this.bOdd.TabIndex = 76;
            this.toolTip1.SetToolTip(this.bOdd, "Distribuovať vlastnosť do celej skupiny");
            this.bOdd.UseVisualStyleBackColor = true;
            this.bOdd.Click += new System.EventHandler(this.bOdd_Click);
            // 
            // bJednotka
            // 
            this.bJednotka.BackgroundImage = global::sampleX.Properties.Resources.Arrows_icon;
            this.bJednotka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bJednotka.Location = new System.Drawing.Point(923, 298);
            this.bJednotka.Name = "bJednotka";
            this.bJednotka.Size = new System.Drawing.Size(25, 25);
            this.bJednotka.TabIndex = 75;
            this.toolTip1.SetToolTip(this.bJednotka, "Distribuovať vlastnosť do celej skupiny");
            this.bJednotka.UseVisualStyleBackColor = true;
            this.bJednotka.Click += new System.EventHandler(this.bJednotka_Click);
            // 
            // bOzn
            // 
            this.bOzn.BackgroundImage = global::sampleX.Properties.Resources.Arrows_icon;
            this.bOzn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bOzn.Location = new System.Drawing.Point(923, 245);
            this.bOzn.Name = "bOzn";
            this.bOzn.Size = new System.Drawing.Size(25, 25);
            this.bOzn.TabIndex = 74;
            this.toolTip1.SetToolTip(this.bOzn, "Distribuovať vlastnosť do celej skupiny");
            this.bOzn.UseVisualStyleBackColor = true;
            this.bOzn.Click += new System.EventHandler(this.bOzn_Click);
            // 
            // bPrincip
            // 
            this.bPrincip.BackgroundImage = global::sampleX.Properties.Resources.Arrows_icon;
            this.bPrincip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bPrincip.Location = new System.Drawing.Point(922, 193);
            this.bPrincip.Name = "bPrincip";
            this.bPrincip.Size = new System.Drawing.Size(25, 25);
            this.bPrincip.TabIndex = 73;
            this.toolTip1.SetToolTip(this.bPrincip, "Distribuovať vlastnosť do celej skupiny");
            this.bPrincip.UseVisualStyleBackColor = true;
            this.bPrincip.Click += new System.EventHandler(this.bPrincip_Click);
            // 
            // bMatrica
            // 
            this.bMatrica.BackgroundImage = global::sampleX.Properties.Resources.Arrows_icon;
            this.bMatrica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bMatrica.Location = new System.Drawing.Point(923, 141);
            this.bMatrica.Name = "bMatrica";
            this.bMatrica.Size = new System.Drawing.Size(25, 25);
            this.bMatrica.TabIndex = 72;
            this.toolTip1.SetToolTip(this.bMatrica, "Distribuovať vlastnosť do celej skupiny");
            this.bMatrica.UseVisualStyleBackColor = true;
            this.bMatrica.Click += new System.EventHandler(this.bMatrica_Click);
            // 
            // bPolozka
            // 
            this.bPolozka.BackgroundImage = global::sampleX.Properties.Resources.Arrows_icon;
            this.bPolozka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bPolozka.Location = new System.Drawing.Point(923, 89);
            this.bPolozka.Name = "bPolozka";
            this.bPolozka.Size = new System.Drawing.Size(25, 25);
            this.bPolozka.TabIndex = 71;
            this.toolTip1.SetToolTip(this.bPolozka, "Distribuovať vlastnosť do celej skupiny");
            this.bPolozka.UseVisualStyleBackColor = true;
            this.bPolozka.Click += new System.EventHandler(this.bPolozka_Click);
            // 
            // bClone
            // 
            this.bClone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bClone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bClone.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bClone.Image = ((System.Drawing.Image)(resources.GetObject("bClone.Image")));
            this.bClone.Location = new System.Drawing.Point(581, 6);
            this.bClone.Name = "bClone";
            this.bClone.Size = new System.Drawing.Size(40, 40);
            this.bClone.TabIndex = 2;
            this.toolTip1.SetToolTip(this.bClone, "Vytvoriť klon skupiny");
            this.bClone.UseVisualStyleBackColor = true;
            this.bClone.Click += new System.EventHandler(this.bClone_Click);
            // 
            // bAll
            // 
            this.bAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bAll.BackgroundImage")));
            this.bAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAll.Location = new System.Drawing.Point(923, 396);
            this.bAll.Name = "bAll";
            this.bAll.Size = new System.Drawing.Size(25, 25);
            this.bAll.TabIndex = 77;
            this.toolTip1.SetToolTip(this.bAll, "Použiť vybrané vlastnosti pre parameter");
            this.bAll.UseVisualStyleBackColor = true;
            this.bAll.Visible = false;
            this.bAll.Click += new System.EventHandler(this.bAll_Click);
            // 
            // bNew
            // 
            this.bNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bNew.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bNew.Image = ((System.Drawing.Image)(resources.GetObject("bNew.Image")));
            this.bNew.Location = new System.Drawing.Point(778, 6);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(40, 40);
            this.bNew.TabIndex = 3;
            this.toolTip1.SetToolTip(this.bNew, "Vytvoriť novú skupinu");
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // bDelete
            // 
            this.bDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bDelete.Image = ((System.Drawing.Image)(resources.GetObject("bDelete.Image")));
            this.bDelete.Location = new System.Drawing.Point(862, 6);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(40, 40);
            this.bDelete.TabIndex = 5;
            this.toolTip1.SetToolTip(this.bDelete, "Vymazať skupinu");
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bRename
            // 
            this.bRename.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bRename.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bRename.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bRename.Image = ((System.Drawing.Image)(resources.GetObject("bRename.Image")));
            this.bRename.Location = new System.Drawing.Point(820, 6);
            this.bRename.Name = "bRename";
            this.bRename.Size = new System.Drawing.Size(40, 40);
            this.bRename.TabIndex = 4;
            this.toolTip1.SetToolTip(this.bRename, "Premenovať aktuálnu skupinu");
            this.bRename.UseVisualStyleBackColor = true;
            this.bRename.Click += new System.EventHandler(this.bRename_Click);
            // 
            // cMain
            // 
            this.cMain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cMain.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cMain.FormattingEnabled = true;
            this.cMain.Location = new System.Drawing.Point(12, 6);
            this.cMain.Name = "cMain";
            this.cMain.Size = new System.Drawing.Size(556, 29);
            this.cMain.TabIndex = 1;
            this.cMain.SelectedIndexChanged += new System.EventHandler(this.cMain_SelectedIndexChanged);
            // 
            // dg1
            // 
            this.dg1.AllowUserToAddRows = false;
            this.dg1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dg1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.ColumnHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg1.DefaultCellStyle = dataGridViewCellStyle10;
            this.dg1.Location = new System.Drawing.Point(12, 63);
            this.dg1.MultiSelect = false;
            this.dg1.Name = "dg1";
            this.dg1.ReadOnly = true;
            this.dg1.RowHeadersVisible = false;
            this.dg1.RowTemplate.Height = 24;
            this.dg1.Size = new System.Drawing.Size(240, 428);
            this.dg1.TabIndex = 51;
            this.dg1.Paint += new System.Windows.Forms.PaintEventHandler(this.dg1_Paint);
            this.dg1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dg1_KeyPress);
            // 
            // dg2
            // 
            this.dg2.AllowUserToAddRows = false;
            this.dg2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dg2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg2.ColumnHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg2.DefaultCellStyle = dataGridViewCellStyle12;
            this.dg2.Location = new System.Drawing.Point(328, 63);
            this.dg2.MultiSelect = false;
            this.dg2.Name = "dg2";
            this.dg2.ReadOnly = true;
            this.dg2.RowHeadersVisible = false;
            this.dg2.RowTemplate.Height = 24;
            this.dg2.Size = new System.Drawing.Size(240, 312);
            this.dg2.TabIndex = 56;
            this.dg2.SelectionChanged += new System.EventHandler(this.dg2_SelectionChanged);
            this.dg2.Paint += new System.Windows.Forms.PaintEventHandler(this.dg2_Paint);
            this.dg2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dg2_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(268, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 35);
            this.button1.TabIndex = 53;
            this.button1.Text = ">>>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(268, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 35);
            this.button2.TabIndex = 54;
            this.button2.Text = "<<<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 107;
            this.label1.Text = "Dostupné položky";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(325, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 17);
            this.label2.TabIndex = 108;
            this.label2.Text = "Položky zaradené v skupine";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cOdd);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cJednotka);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cOzn);
            this.groupBox1.Controls.Add(this.cPrincip);
            this.groupBox1.Controls.Add(this.cMatrica);
            this.groupBox1.Controls.Add(this.cPolozka);
            this.groupBox1.Location = new System.Drawing.Point(581, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 330);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(4, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 118;
            this.label9.Text = "Oddelenie";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(4, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 116;
            this.label8.Text = "Jednotky";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(4, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 114;
            this.label7.Text = "Označenie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(4, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 113;
            this.label6.Text = "Princíp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(4, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 112;
            this.label5.Text = "Matrica";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(4, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 111;
            this.label4.Text = "Položka";
            // 
            // ldg2
            // 
            this.ldg2.AutoSize = true;
            this.ldg2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ldg2.Location = new System.Drawing.Point(325, 378);
            this.ldg2.Name = "ldg2";
            this.ldg2.Size = new System.Drawing.Size(27, 13);
            this.ldg2.TabIndex = 127;
            this.ldg2.Text = "dg2";
            // 
            // ldg1
            // 
            this.ldg1.AutoSize = true;
            this.ldg1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ldg1.Location = new System.Drawing.Point(10, 494);
            this.ldg1.Name = "ldg1";
            this.ldg1.Size = new System.Drawing.Size(27, 13);
            this.ldg1.TabIndex = 128;
            this.ldg1.Text = "dg1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(908, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 100;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // dg3
            // 
            this.dg3.AllowUserToAddRows = false;
            this.dg3.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dg3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dg3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dg3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg3.ColumnHeadersVisible = false;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg3.DefaultCellStyle = dataGridViewCellStyle14;
            this.dg3.Location = new System.Drawing.Point(328, 396);
            this.dg3.MultiSelect = false;
            this.dg3.Name = "dg3";
            this.dg3.ReadOnly = true;
            this.dg3.RowHeadersVisible = false;
            this.dg3.RowTemplate.Height = 24;
            this.dg3.Size = new System.Drawing.Size(416, 95);
            this.dg3.TabIndex = 129;
            this.dg3.Visible = false;
            this.dg3.SelectionChanged += new System.EventHandler(this.dg3_SelectionChanged);
            this.dg3.Paint += new System.Windows.Forms.PaintEventHandler(this.dg3_Paint);
            // 
            // ldg3
            // 
            this.ldg3.AutoSize = true;
            this.ldg3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ldg3.Location = new System.Drawing.Point(325, 494);
            this.ldg3.Name = "ldg3";
            this.ldg3.Size = new System.Drawing.Size(27, 13);
            this.ldg3.TabIndex = 130;
            this.ldg3.Text = "dg3";
            this.ldg3.Visible = false;
            // 
            // bAkr
            // 
            this.bAkr.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.bAkr.Location = new System.Drawing.Point(328, 456);
            this.bAkr.Name = "bAkr";
            this.bAkr.Size = new System.Drawing.Size(585, 35);
            this.bAkr.TabIndex = 67;
            this.bAkr.Text = "Prenos vlastností parametra z rozsahu akreditácie";
            this.bAkr.UseVisualStyleBackColor = true;
            this.bAkr.Click += new System.EventHandler(this.bAkr_Click);
            // 
            // dg4
            // 
            this.dg4.AllowUserToAddRows = false;
            this.dg4.AllowUserToDeleteRows = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dg4.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dg4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dg4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg4.ColumnHeadersVisible = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg4.DefaultCellStyle = dataGridViewCellStyle16;
            this.dg4.Location = new System.Drawing.Point(750, 396);
            this.dg4.MultiSelect = false;
            this.dg4.Name = "dg4";
            this.dg4.ReadOnly = true;
            this.dg4.RowHeadersVisible = false;
            this.dg4.RowTemplate.Height = 24;
            this.dg4.Size = new System.Drawing.Size(163, 95);
            this.dg4.TabIndex = 133;
            this.dg4.Visible = false;
            this.dg4.Paint += new System.Windows.Forms.PaintEventHandler(this.dg4_Paint);
            // 
            // ldg4
            // 
            this.ldg4.AutoSize = true;
            this.ldg4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ldg4.Location = new System.Drawing.Point(747, 494);
            this.ldg4.Name = "ldg4";
            this.ldg4.Size = new System.Drawing.Size(27, 13);
            this.ldg4.TabIndex = 134;
            this.ldg4.Text = "dg4";
            this.ldg4.Visible = false;
            // 
            // Filter1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 535);
            this.Controls.Add(this.bRename);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.ldg4);
            this.Controls.Add(this.dg4);
            this.Controls.Add(this.bAkr);
            this.Controls.Add(this.bAll);
            this.Controls.Add(this.ldg3);
            this.Controls.Add(this.dg3);
            this.Controls.Add(this.ldg1);
            this.Controls.Add(this.ldg2);
            this.Controls.Add(this.bOdd);
            this.Controls.Add(this.bJednotka);
            this.Controls.Add(this.bOzn);
            this.Controls.Add(this.bPrincip);
            this.Controls.Add(this.bMatrica);
            this.Controls.Add(this.bPolozka);
            this.Controls.Add(this.bClone);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dg2);
            this.Controls.Add(this.dg1);
            this.Controls.Add(this.cMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Filter1";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sampleX - Hlavné menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Filter1_FormClosed);
            this.Load += new System.EventHandler(this.Filter1_Load);
            this.Shown += new System.EventHandler(this.Filter1_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lStatus;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cMain;
        private System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.DataGridView dg2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cPolozka;
        private System.Windows.Forms.ComboBox cOzn;
        private System.Windows.Forms.ComboBox cPrincip;
        private System.Windows.Forms.ComboBox cMatrica;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cOdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cJednotka;
        private System.Windows.Forms.Button bClone;
        private System.Windows.Forms.Button bPolozka;
        private System.Windows.Forms.Button bMatrica;
        private System.Windows.Forms.Button bPrincip;
        private System.Windows.Forms.Button bOzn;
        private System.Windows.Forms.Button bJednotka;
        private System.Windows.Forms.Button bOdd;
        private System.Windows.Forms.Label ldg2;
        private System.Windows.Forms.Label ldg1;
        private System.Windows.Forms.DataGridView dg3;
        private System.Windows.Forms.Label ldg3;
        private System.Windows.Forms.Button bAll;
        private System.Windows.Forms.Button bAkr;
        private System.Windows.Forms.DataGridView dg4;
        private System.Windows.Forms.Label ldg4;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bRename;
    }
}