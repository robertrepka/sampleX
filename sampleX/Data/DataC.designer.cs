namespace sampleX
{
    partial class DataC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataC));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cOdd = new System.Windows.Forms.ComboBox();
            this.cJednotka = new System.Windows.Forms.ComboBox();
            this.cOzn = new System.Windows.Forms.ComboBox();
            this.cPrincip = new System.Windows.Forms.ComboBox();
            this.cMatrica = new System.Windows.Forms.ComboBox();
            this.cPolozka = new System.Windows.Forms.ComboBox();
            this.bClear = new System.Windows.Forms.Button();
            this.bDel = new System.Windows.Forms.Button();
            this.bOK = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dg = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lOzn = new System.Windows.Forms.Label();
            this.lLabc = new System.Windows.Forms.Label();
            this.lZakazka = new System.Windows.Forms.Label();
            this.lObj = new System.Windows.Forms.Label();
            this.lPartner = new System.Windows.Forms.Label();
            this.lFilter = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tResult = new System.Windows.Forms.TextBox();
            this.tNeistota = new System.Windows.Forms.TextBox();
            this.tPozn = new System.Windows.Forms.TextBox();
            this.tMedza = new System.Windows.Forms.TextBox();
            this.cAkr = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lNeistota = new System.Windows.Forms.Label();
            this.lMax = new System.Windows.Forms.Label();
            this.lMin = new System.Windows.Forms.Label();
            this.lMeral = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l5 = new System.Windows.Forms.Label();
            this.lMin_ = new System.Windows.Forms.Label();
            this.lMax_ = new System.Windows.Forms.Label();
            this.lNeistota_ = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 529);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 8, 0);
            this.statusStrip1.Size = new System.Drawing.Size(987, 22);
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
            this.cOdd.SelectedIndexChanged += new System.EventHandler(this.cOdd_SelectedIndexChanged);
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
            this.cJednotka.SelectedIndexChanged += new System.EventHandler(this.cJednotka_SelectedIndexChanged);
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
            this.cOzn.SelectedIndexChanged += new System.EventHandler(this.cOzn_SelectedIndexChanged);
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
            this.cPrincip.SelectedIndexChanged += new System.EventHandler(this.cPrincip_SelectedIndexChanged);
            // 
            // cMatrica
            // 
            this.cMatrica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cMatrica.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cMatrica.FormattingEnabled = true;
            this.cMatrica.Location = new System.Drawing.Point(261, 36);
            this.cMatrica.Name = "cMatrica";
            this.cMatrica.Size = new System.Drawing.Size(246, 25);
            this.cMatrica.TabIndex = 120;
            this.toolTip1.SetToolTip(this.cMatrica, "Matrica");
            this.cMatrica.SelectedIndexChanged += new System.EventHandler(this.cMatrica_SelectedIndexChanged);
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
            this.cPolozka.TextChanged += new System.EventHandler(this.cPolozka_TextChanged);
            // 
            // bClear
            // 
            this.bClear.Image = global::sampleX.Properties.Resources.Clear_icon;
            this.bClear.Location = new System.Drawing.Point(885, 478);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(42, 42);
            this.bClear.TabIndex = 158;
            this.toolTip1.SetToolTip(this.bClear, "Zruš nameranú hodnotu");
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bDel
            // 
            this.bDel.Image = global::sampleX.Properties.Resources.Button_Close_icon;
            this.bDel.Location = new System.Drawing.Point(933, 478);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(42, 42);
            this.bDel.TabIndex = 138;
            this.toolTip1.SetToolTip(this.bDel, "Vymaž záznam");
            this.bDel.UseVisualStyleBackColor = true;
            this.bDel.Click += new System.EventHandler(this.bDel_Click);
            // 
            // bOK
            // 
            this.bOK.Image = global::sampleX.Properties.Resources.accept_icon;
            this.bOK.Location = new System.Drawing.Point(548, 478);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(42, 42);
            this.bOK.TabIndex = 135;
            this.toolTip1.SetToolTip(this.bOK, "Zapíš hodnoty");
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 176);
            this.groupBox1.TabIndex = 131;
            this.groupBox1.TabStop = false;
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(12, 9);
            this.dg.MultiSelect = false;
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.RowHeadersVisible = false;
            this.dg.RowTemplate.Height = 24;
            this.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg.Size = new System.Drawing.Size(963, 258);
            this.dg.TabIndex = 134;
            this.dg.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dg_RowsAdded);
            this.dg.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dg_RowsRemoved);
            this.dg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dg_KeyPress);
            this.dg.SelectionChanged += new System.EventHandler(this.dg_SelectionChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(545, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 141;
            this.label1.Text = "Názov:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(545, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 142;
            this.label2.Text = "Objednávka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(545, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 143;
            this.label3.Text = "Zákazka:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(545, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 144;
            this.label10.Text = "Lab. číslo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(545, 386);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 17);
            this.label11.TabIndex = 145;
            this.label11.Text = "Označenie:";
            // 
            // lOzn
            // 
            this.lOzn.AutoSize = true;
            this.lOzn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lOzn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lOzn.Location = new System.Drawing.Point(628, 386);
            this.lOzn.Name = "lOzn";
            this.lOzn.Size = new System.Drawing.Size(71, 17);
            this.lOzn.TabIndex = 150;
            this.lOzn.Text = "Označenie:";
            // 
            // lLabc
            // 
            this.lLabc.AutoSize = true;
            this.lLabc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lLabc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lLabc.Location = new System.Drawing.Point(626, 299);
            this.lLabc.Name = "lLabc";
            this.lLabc.Size = new System.Drawing.Size(98, 25);
            this.lLabc.TabIndex = 149;
            this.lLabc.Text = "Lab. číslo:";
            // 
            // lZakazka
            // 
            this.lZakazka.AutoSize = true;
            this.lZakazka.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lZakazka.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lZakazka.Location = new System.Drawing.Point(628, 366);
            this.lZakazka.Name = "lZakazka";
            this.lZakazka.Size = new System.Drawing.Size(57, 17);
            this.lZakazka.TabIndex = 148;
            this.lZakazka.Text = "Zákazka:";
            // 
            // lObj
            // 
            this.lObj.AutoSize = true;
            this.lObj.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lObj.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lObj.Location = new System.Drawing.Point(628, 346);
            this.lObj.Name = "lObj";
            this.lObj.Size = new System.Drawing.Size(80, 17);
            this.lObj.TabIndex = 147;
            this.lObj.Text = "Objednávka:";
            // 
            // lPartner
            // 
            this.lPartner.AutoSize = true;
            this.lPartner.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lPartner.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lPartner.Location = new System.Drawing.Point(626, 274);
            this.lPartner.Name = "lPartner";
            this.lPartner.Size = new System.Drawing.Size(73, 25);
            this.lPartner.TabIndex = 146;
            this.lPartner.Text = "Názov:";
            // 
            // lFilter
            // 
            this.lFilter.AutoSize = true;
            this.lFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lFilter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lFilter.Location = new System.Drawing.Point(628, 406);
            this.lFilter.Name = "lFilter";
            this.lFilter.Size = new System.Drawing.Size(39, 17);
            this.lFilter.TabIndex = 152;
            this.lFilter.Text = "Filter:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(545, 406);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 17);
            this.label13.TabIndex = 151;
            this.label13.Text = "Filter:";
            // 
            // tResult
            // 
            this.tResult.BackColor = System.Drawing.Color.Aquamarine;
            this.tResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tResult.Location = new System.Drawing.Point(84, 454);
            this.tResult.Name = "tResult";
            this.tResult.Size = new System.Drawing.Size(129, 29);
            this.tResult.TabIndex = 153;
            this.tResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tResult.TextChanged += new System.EventHandler(this.tResult_TextChanged);
            this.tResult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tResult_KeyPress);
            // 
            // tNeistota
            // 
            this.tNeistota.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tNeistota.Location = new System.Drawing.Point(84, 489);
            this.tNeistota.Name = "tNeistota";
            this.tNeistota.Size = new System.Drawing.Size(129, 29);
            this.tNeistota.TabIndex = 154;
            this.tNeistota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tNeistota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tNeistota_KeyPress);
            // 
            // tPozn
            // 
            this.tPozn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tPozn.Location = new System.Drawing.Point(386, 489);
            this.tPozn.Name = "tPozn";
            this.tPozn.Size = new System.Drawing.Size(133, 29);
            this.tPozn.TabIndex = 156;
            this.tPozn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tMedza
            // 
            this.tMedza.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tMedza.Location = new System.Drawing.Point(386, 454);
            this.tMedza.Name = "tMedza";
            this.tMedza.Size = new System.Drawing.Size(133, 29);
            this.tMedza.TabIndex = 155;
            this.tMedza.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tMedza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tMedza_KeyPress);
            // 
            // cAkr
            // 
            this.cAkr.AutoSize = true;
            this.cAkr.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cAkr.Location = new System.Drawing.Point(253, 490);
            this.cAkr.Name = "cAkr";
            this.cAkr.Size = new System.Drawing.Size(15, 14);
            this.cAkr.TabIndex = 157;
            this.cAkr.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(937, 280);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 109;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover_1);
            // 
            // lNeistota
            // 
            this.lNeistota.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lNeistota.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lNeistota.Location = new System.Drawing.Point(790, 501);
            this.lNeistota.Name = "lNeistota";
            this.lNeistota.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lNeistota.Size = new System.Drawing.Size(80, 17);
            this.lNeistota.TabIndex = 159;
            this.lNeistota.Text = "Objednávka:";
            // 
            // lMax
            // 
            this.lMax.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lMax.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lMax.Location = new System.Drawing.Point(790, 485);
            this.lMax.Name = "lMax";
            this.lMax.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lMax.Size = new System.Drawing.Size(80, 17);
            this.lMax.TabIndex = 160;
            this.lMax.Text = "Objednávka:";
            // 
            // lMin
            // 
            this.lMin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lMin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lMin.Location = new System.Drawing.Point(790, 469);
            this.lMin.Name = "lMin";
            this.lMin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lMin.Size = new System.Drawing.Size(80, 17);
            this.lMin.TabIndex = 161;
            this.lMin.Text = "Objednávka:";
            // 
            // lMeral
            // 
            this.lMeral.AutoSize = true;
            this.lMeral.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lMeral.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lMeral.Location = new System.Drawing.Point(628, 425);
            this.lMeral.Name = "lMeral";
            this.lMeral.Size = new System.Drawing.Size(58, 17);
            this.lMeral.TabIndex = 163;
            this.lMeral.Text = "Pečiatka:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(545, 425);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 17);
            this.label14.TabIndex = 162;
            this.label14.Text = "Pečiatka:";
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.l1.Location = new System.Drawing.Point(18, 460);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(62, 17);
            this.l1.TabIndex = 164;
            this.l1.Text = "Hodnota:";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.l2.Location = new System.Drawing.Point(18, 495);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(60, 17);
            this.l2.TabIndex = 166;
            this.l2.Text = "Neistota:";
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.l4.Location = new System.Drawing.Point(309, 495);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(70, 17);
            this.l4.TabIndex = 168;
            this.l4.Text = "Poznámka:";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.l3.Location = new System.Drawing.Point(309, 460);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(51, 17);
            this.l3.TabIndex = 167;
            this.l3.Text = "Medza:";
            // 
            // l5
            // 
            this.l5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.l5.Location = new System.Drawing.Point(229, 469);
            this.l5.Name = "l5";
            this.l5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.l5.Size = new System.Drawing.Size(51, 17);
            this.l5.TabIndex = 169;
            this.l5.Text = ":.Akr";
            // 
            // lMin_
            // 
            this.lMin_.AutoSize = true;
            this.lMin_.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lMin_.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lMin_.Location = new System.Drawing.Point(704, 469);
            this.lMin_.Name = "lMin_";
            this.lMin_.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lMin_.Size = new System.Drawing.Size(80, 17);
            this.lMin_.TabIndex = 172;
            this.lMin_.Text = "Objednávka:";
            // 
            // lMax_
            // 
            this.lMax_.AutoSize = true;
            this.lMax_.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lMax_.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lMax_.Location = new System.Drawing.Point(704, 485);
            this.lMax_.Name = "lMax_";
            this.lMax_.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lMax_.Size = new System.Drawing.Size(80, 17);
            this.lMax_.TabIndex = 171;
            this.lMax_.Text = "Objednávka:";
            // 
            // lNeistota_
            // 
            this.lNeistota_.AutoSize = true;
            this.lNeistota_.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lNeistota_.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lNeistota_.Location = new System.Drawing.Point(704, 501);
            this.lNeistota_.Name = "lNeistota_";
            this.lNeistota_.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lNeistota_.Size = new System.Drawing.Size(80, 17);
            this.lNeistota_.TabIndex = 170;
            this.lNeistota_.Text = "Objednávka:";
            // 
            // DataC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 551);
            this.Controls.Add(this.lMin_);
            this.Controls.Add(this.lMax_);
            this.Controls.Add(this.lNeistota_);
            this.Controls.Add(this.l5);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.lMeral);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lMin);
            this.Controls.Add(this.lMax);
            this.Controls.Add(this.lNeistota);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bDel);
            this.Controls.Add(this.cAkr);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.tPozn);
            this.Controls.Add(this.tMedza);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tNeistota);
            this.Controls.Add(this.tResult);
            this.Controls.Add(this.lFilter);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lOzn);
            this.Controls.Add(this.lLabc);
            this.Controls.Add(this.lZakazka);
            this.Controls.Add(this.lObj);
            this.Controls.Add(this.lPartner);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "DataC";
            this.Opacity = 0;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sampleX - Hlavné menu";
            this.Load += new System.EventHandler(this.DataC_Load);
            this.Shown += new System.EventHandler(this.DataC_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lStatus;
        private System.Windows.Forms.ToolTip toolTip1;
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
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lOzn;
        private System.Windows.Forms.Label lLabc;
        private System.Windows.Forms.Label lZakazka;
        private System.Windows.Forms.Label lObj;
        private System.Windows.Forms.Label lPartner;
        private System.Windows.Forms.Label lFilter;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tResult;
        private System.Windows.Forms.TextBox tNeistota;
        private System.Windows.Forms.TextBox tPozn;
        private System.Windows.Forms.TextBox tMedza;
        private System.Windows.Forms.CheckBox cAkr;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Label lNeistota;
        private System.Windows.Forms.Label lMax;
        private System.Windows.Forms.Label lMin;
        private System.Windows.Forms.Label lMeral;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l5;
        private System.Windows.Forms.Label lMin_;
        private System.Windows.Forms.Label lMax_;
        private System.Windows.Forms.Label lNeistota_;
    }
}