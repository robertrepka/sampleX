namespace sampleX
{
    partial class Prevadzka
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
            System.Windows.Forms.Label telLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prevadzka));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.adr1Label = new System.Windows.Forms.Label();
            this.adr3Label = new System.Windows.Forms.Label();
            this.adr2Label = new System.Windows.Forms.Label();
            this.bn = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bOK = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tSearch = new System.Windows.Forms.ToolStripTextBox();
            this.cFilter = new System.Windows.Forms.ToolStripComboBox();
            this.dg = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bExcel = new System.Windows.Forms.Button();
            this.bSelect = new System.Windows.Forms.Button();
            this.dr = new System.Windows.Forms.GroupBox();
            this.adr4_ = new System.Windows.Forms.TextBox();
            this.adr2_ = new System.Windows.Forms.TextBox();
            this.adr3_ = new System.Windows.Forms.TextBox();
            this.adr1_ = new System.Windows.Forms.TextBox();
            this.id_ = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            telLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bn)).BeginInit();
            this.bn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.dr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // adr1Label
            // 
            this.adr1Label.AutoSize = true;
            this.adr1Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adr1Label.Location = new System.Drawing.Point(11, 22);
            this.adr1Label.Name = "adr1Label";
            this.adr1Label.Size = new System.Drawing.Size(71, 17);
            this.adr1Label.TabIndex = 19;
            this.adr1Label.Text = "prevádzka:";
            this.adr1Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // adr3Label
            // 
            this.adr3Label.AutoSize = true;
            this.adr3Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adr3Label.Location = new System.Drawing.Point(11, 82);
            this.adr3Label.Name = "adr3Label";
            this.adr3Label.Size = new System.Drawing.Size(59, 17);
            this.adr3Label.TabIndex = 23;
            this.adr3Label.Text = "riadok 3:";
            this.adr3Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // telLabel
            // 
            telLabel.AutoSize = true;
            telLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            telLabel.Location = new System.Drawing.Point(11, 112);
            telLabel.Name = "telLabel";
            telLabel.Size = new System.Drawing.Size(59, 17);
            telLabel.TabIndex = 25;
            telLabel.Text = "riadok 4:";
            telLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // adr2Label
            // 
            this.adr2Label.AutoSize = true;
            this.adr2Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adr2Label.Location = new System.Drawing.Point(11, 52);
            this.adr2Label.Name = "adr2Label";
            this.adr2Label.Size = new System.Drawing.Size(59, 17);
            this.adr2Label.TabIndex = 33;
            this.adr2Label.Text = "riadok 2:";
            this.adr2Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bn
            // 
            this.bn.AddNewItem = null;
            this.bn.CountItem = this.bindingNavigatorCountItem;
            this.bn.CountItemFormat = "z {0}";
            this.bn.DeleteItem = null;
            this.bn.Dock = System.Windows.Forms.DockStyle.None;
            this.bn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bOK,
            this.toolStripSeparator1,
            this.tSearch,
            this.cFilter});
            this.bn.Location = new System.Drawing.Point(16, 9);
            this.bn.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn.Name = "bn";
            this.bn.PositionItem = this.bindingNavigatorPositionItem;
            this.bn.Size = new System.Drawing.Size(503, 26);
            this.bn.TabIndex = 0;
            this.bn.Text = "bindingNavigator1";
            this.bn.Validated += new System.EventHandler(this.bn_Validated);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 23);
            this.bindingNavigatorCountItem.Text = "z {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Počet záznamov";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 23);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.ToolTipText = "Prvý záznam";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 23);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.ToolTipText = "Predchádzajúci záznam";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 26);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 26);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Aktuálny záznam";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 23);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.ToolTipText = "Ďalší záznam";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 23);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.ToolTipText = "Posledný záznam";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 26);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 23);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.ToolTipText = "Nový záznam";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 23);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.ToolTipText = "Zmazať záznam";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bOK
            // 
            this.bOK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bOK.Enabled = false;
            this.bOK.Image = global::sampleX.Properties.Resources.edit_icon;
            this.bOK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(23, 23);
            this.bOK.Text = "toolStripButton1";
            this.bOK.ToolTipText = "Zapísať záznam";
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // tSearch
            // 
            this.tSearch.Name = "tSearch";
            this.tSearch.Size = new System.Drawing.Size(100, 26);
            this.tSearch.ToolTipText = "Hľadaný text";
            this.tSearch.TextChanged += new System.EventHandler(this.tSearch_TextChanged);
            // 
            // cFilter
            // 
            this.cFilter.Name = "cFilter";
            this.cFilter.Size = new System.Drawing.Size(121, 26);
            this.cFilter.ToolTipText = "Filter údajov";
            this.cFilter.SelectedIndexChanged += new System.EventHandler(this.cFilter_SelectedIndexChanged);
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg.Location = new System.Drawing.Point(573, 52);
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.RowHeadersVisible = false;
            this.dg.RowTemplate.Height = 24;
            this.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg.Size = new System.Drawing.Size(240, 150);
            this.dg.TabIndex = 0;
            this.dg.Visible = false;
            this.dg.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellEndEdit);
            this.dg.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dg_CellPainting);
            this.dg.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_ColumnHeaderMouseClick);
            this.dg.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dg_DataError);
            this.dg.Click += new System.EventHandler(this.dg_Click);
            this.dg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dg_KeyDown);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 492);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(833, 22);
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
            // bExcel
            // 
            this.bExcel.Image = ((System.Drawing.Image)(resources.GetObject("bExcel.Image")));
            this.bExcel.Location = new System.Drawing.Point(654, 187);
            this.bExcel.Name = "bExcel";
            this.bExcel.Size = new System.Drawing.Size(45, 45);
            this.bExcel.TabIndex = 5;
            this.toolTip1.SetToolTip(this.bExcel, "Export údajov do schránky");
            this.bExcel.UseVisualStyleBackColor = true;
            this.bExcel.Visible = false;
            this.bExcel.Click += new System.EventHandler(this.bExcel_Click);
            // 
            // bSelect
            // 
            this.bSelect.Image = ((System.Drawing.Image)(resources.GetObject("bSelect.Image")));
            this.bSelect.Location = new System.Drawing.Point(705, 187);
            this.bSelect.Name = "bSelect";
            this.bSelect.Size = new System.Drawing.Size(45, 45);
            this.bSelect.TabIndex = 8;
            this.toolTip1.SetToolTip(this.bSelect, "Výber zákazníka");
            this.bSelect.UseVisualStyleBackColor = true;
            this.bSelect.Click += new System.EventHandler(this.bSelect_Click);
            // 
            // dr
            // 
            this.dr.Controls.Add(this.adr2Label);
            this.dr.Controls.Add(telLabel);
            this.dr.Controls.Add(this.adr4_);
            this.dr.Controls.Add(this.adr2_);
            this.dr.Controls.Add(this.adr3Label);
            this.dr.Controls.Add(this.adr3_);
            this.dr.Controls.Add(this.adr1Label);
            this.dr.Controls.Add(this.adr1_);
            this.dr.Location = new System.Drawing.Point(29, 65);
            this.dr.Name = "dr";
            this.dr.Size = new System.Drawing.Size(430, 146);
            this.dr.TabIndex = 6;
            this.dr.TabStop = false;
            // 
            // adr4_
            // 
            this.adr4_.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adr4_.Location = new System.Drawing.Point(85, 109);
            this.adr4_.Name = "adr4_";
            this.adr4_.Size = new System.Drawing.Size(330, 25);
            this.adr4_.TabIndex = 26;
            this.adr4_.Validated += new System.EventHandler(this.poznTextBox_Validated);
            // 
            // adr2_
            // 
            this.adr2_.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adr2_.Location = new System.Drawing.Point(85, 49);
            this.adr2_.Name = "adr2_";
            this.adr2_.Size = new System.Drawing.Size(330, 25);
            this.adr2_.TabIndex = 23;
            this.adr2_.Validated += new System.EventHandler(this.poznTextBox_Validated);
            // 
            // adr3_
            // 
            this.adr3_.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adr3_.Location = new System.Drawing.Point(85, 79);
            this.adr3_.Name = "adr3_";
            this.adr3_.Size = new System.Drawing.Size(330, 25);
            this.adr3_.TabIndex = 24;
            this.adr3_.Validated += new System.EventHandler(this.poznTextBox_Validated);
            // 
            // adr1_
            // 
            this.adr1_.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adr1_.Location = new System.Drawing.Point(85, 19);
            this.adr1_.Name = "adr1_";
            this.adr1_.Size = new System.Drawing.Size(330, 25);
            this.adr1_.TabIndex = 20;
            this.adr1_.Validated += new System.EventHandler(this.poznTextBox_Validated);
            // 
            // id_
            // 
            this.id_.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.id_.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.id_.Location = new System.Drawing.Point(102, 52);
            this.id_.Name = "id_";
            this.id_.Size = new System.Drawing.Size(54, 23);
            this.id_.TabIndex = 1;
            this.id_.Text = "id";
            this.id_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(588, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // Prevadzka
            // 
            this.ClientSize = new System.Drawing.Size(833, 514);
            this.Controls.Add(this.bSelect);
            this.Controls.Add(this.dr);
            this.Controls.Add(this.bExcel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.bn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.id_);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Prevadzka";
            this.Opacity = 0D;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Prevadzka_FormClosing);
            this.Load += new System.EventHandler(this.Prevadzka_Load);
            this.Shown += new System.EventHandler(this.Prevadzka_Shown);
            this.Resize += new System.EventHandler(this.Prevadzka_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.bn)).EndInit();
            this.bn.ResumeLayout(false);
            this.bn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.dr.ResumeLayout(false);
            this.dr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.BindingNavigator bn;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.ToolStripButton bOK;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox tSearch;
        private System.Windows.Forms.ToolStripComboBox cFilter;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bExcel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox dr;
        private System.Windows.Forms.Label id_;
        private System.Windows.Forms.TextBox adr4_;
        private System.Windows.Forms.TextBox adr3_;
        private System.Windows.Forms.TextBox adr1_;
        private System.Windows.Forms.Button bSelect;
        private System.Windows.Forms.TextBox adr2_;
        private System.Windows.Forms.Label adr1Label;
        private System.Windows.Forms.Label adr3Label;
        private System.Windows.Forms.Label adr2Label;
    }
}