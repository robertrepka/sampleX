using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using MySql.Data.MySqlClient;
//using Microsoft.VisualBasic.PowerPacks;
using System.Runtime.InteropServices;

namespace sampleX
{
    public partial class Zakazka_obj_partner : Form
    {
        #region ******************* BEZ ÚPRAV *******************
        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);

        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags,
        UIntPtr dwExtraInfo);

        int iSort = 0;
        string sFilter = "";
        BindingSource bs = new BindingSource();
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable dt = new DataTable();
        #endregion

        #region UVOD
        string SqlSelectCommand = "SELECT id, no, rok, ozn, labc, obj_no, meno, datum_dod, datum_termin, datum_start, datum_end, datum_protokol, akr, v_meno, v_cas1, v_cas2, v_miesto, v_matrica, pozn, cobj, czml, autor, stamp, obj_datum, obj_rok, obj_id, partner_id, kontakt_meno, kontakt_funkcia, kontakt_email, kontakt_tel, adr1, adr2, adr3, adr4 FROM zakazka_obj_partner " + RRvar.sTemp + " order by id DESC";
        string SqlUpdateCommand = "UPDATE zakazka SET v_matrica = @v_matrica, v_meno = @v_meno, v_cas1 = @v_cas1, v_cas2 = @v_cas2, v_miesto = @v_miesto, labc = @labc, no = @no, rok = @rok, ozn = @ozn, datum_dod = @datum_dod, datum_termin = @datum_termin, datum_start = @datum_start, datum_end = @datum_end, datum_protokol = @datum_protokol, akr = @akr, pozn = @pozn, refe_id = @refe_id WHERE (id = @id)";
        string SqlInsertCommand = "INSERT INTO zakazka (v_meno, v_cas1, v_cas2, v_miesto, v_matrica, no, rok, ozn, obj_id, datum_dod, datum_termin, datum_start, datum_end, datum_protokol, akr, pozn, refe_id, labc) VALUES (@v_meno, @v_cas1, @v_cas2, @v_miesto, @v_matrica, @no, @rok, @ozn, @obj_id, @datum_dod, @datum_termin, @datum_start, @datum_end, @datum_protokol, @akr, @pozn, @refe_id, @labc)";
        string SqlDeleteCommand = "DELETE from zakazka where id = @id";
        string SqlLogCommand = "SELECT CONCAT('id:', id, ' - ', no) from zakazka ORDER BY id DESC LIMIT 1;";

        string sLog1 = "Nová zákazka: ";

        MySqlCommand mySqlSelectCommand;
        MySqlCommand mySqlUpdateCommand;
        MySqlCommand mySqlInsertCommand;
        MySqlCommand mySqlDeleteCommand;

        MySqlConnection con = new MySqlConnection(RRvar.sConStr);
        MySqlConnection MyDataConnect = new MySqlConnection(RRvar.sConStr);

        MySqlCommand cmd;

        ListSortDirection oldSortOrder;
        DataGridViewColumn oldSortCol;
        string oldFilter = "";
        int oldCombo = 0;
        bool bInsertIsRunning = false;
        RRcode RRcode = new RRcode();
        RRfun RRfun = new RRfun();
        RRsql RRsql = new RRsql();
        RRdata RRdata = new RRdata();
        RRstring RRstring = new RRstring();
        #endregion

        #region LOAD & SHOWN
        private void Zakazka_obj_partner_Shown(object sender, EventArgs e)
        {
            Headers();

        }

        private void Zakazka_obj_partner_Load(object sender, EventArgs e)
        {
            if (!RRdata.bAuth("z-rw"))
            {
                dr.Enabled = false;
                bindingNavigatorDeleteItem.Enabled = false;
                bindingNavigatorAddNewItem.Enabled = false;
                bLabc.Enabled = false;
            }
            MyDataConnect.Open();
            mySqlSelectCommand = new MySqlCommand(SqlSelectCommand, MyDataConnect);
            mySqlUpdateCommand = new MySqlCommand(SqlUpdateCommand, MyDataConnect);
            mySqlDeleteCommand = new MySqlCommand(SqlDeleteCommand, MyDataConnect);
            da.SelectCommand = mySqlSelectCommand;
            da.UpdateCommand = mySqlUpdateCommand;
            da.DeleteCommand = mySqlDeleteCommand;
            DGen();
            this.da.Fill(dt);
            MyDataConnect.Close();
            myDataSource();

            this.Text = RRvar.sHeader;
            lStatus.Text = RRvar.sFooter;
            dg.MultiSelect = false;
            //this.Size = new Size(Screen.PrimaryScreen.Bounds.Width - 40, Screen.PrimaryScreen.Bounds.Height - 60);
            //this.Location = new Point(20, 10);
            DoubleBuffered(dg, true);
            this.WindowState = FormWindowState.Maximized;
            RRcode.Front();
            RRcode.FadeIn(this);
            //myFill();
            cFilter.Items.Insert(0, "VŠETKO");
            int i = 0;
            foreach (DataGridViewColumn column in dg.Columns)
            {
                i++;
                cFilter.Items.Insert(i, column.HeaderText);
            }
            cFilter.SelectedIndex = 0;
            dg.Visible = true;
            pictureBox1.Visible = true;
            bExcel.Visible = true;
            bReload.Visible = true;
            bSelect.Visible = true;
            ActiveControl = dg;
            if (RRvar.bDetail)
            {
                bPartner.Enabled = false;
                bindingNavigatorAddNewItem.Enabled = false;
            }
            bindingNavigatorDeleteItem.Enabled = false;
        }
        #endregion

        #region DATAGRIDVIEW - ÚPRAVA AK JE TREBA
        private void Headers()
        {
            //dg.ReadOnly = false;
            //dg.Columns[0].ReadOnly = true;

            dg.Columns[3].Visible = false;
            dg.Columns[21].Visible = false;
            dg.Columns[22].Visible = false;
            dg.Columns[23].Visible = false;
            dg.Columns[24].Visible = false;
            //dg.Columns[20].Visible = false;
            //dg.Columns[21].Visible = false;


            ////dg.Columns["akr"].Visible = false;
            //for (int i = 0; i <= dg.Columns.Count - 1; i++)
            //{
            //    int colw = dg.Columns[i].Width;
            //    dg.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //    dg.Columns[i].Width = colw;
            //}
            //dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }
        //Aby fungovalo musí byť v _Load pred Fill
        private void DGen()
        {
            dg.AutoGenerateColumns = false;
            dg.Columns.Clear();
            //id, no, rok, ozn, labc, obj_no, meno, datum_start, datum_dod, datum_end,
            //akr, pozn, cobj, czml, autor, stamp, obj_datum, obj_rok, obj_id 

            DGen("id", "id", 1);
            DGen("no", "por.č.", 1);
            DGen("rok", "rok", 1);
            DGen("ozn", "označenie", 1);
            DGen("labc", "počet LČ", 1);
            DGen("obj_no", "obj. por.č", 1);
            DGen("meno", "objednávateľ", 1);
            DGen("datum_dod", "d_dodanie", 1);
            DGen("datum_termin", "d_termín", 1);
            DGen("datum_start", "d_začiatok", 1);
            DGen("datum_end", "d_ukončenie", 1);
            DGen("datum_protokol", "d_protokol", 1);
            DGen("v_matrica", "identifikácia", 1);
            DGen("v_meno", "odobral", 1);
            DGen("v_miesto", "lokalita", 1);
            DGen("v_cas1", "odber_zač", 1);
            DGen("v_cas2", "odber_koniec", 1);
            DGen("akr", "akr", 2);
            DGen("pozn", "poznámka", 1);
            DGen("cobj", "objednávka", 1);
            DGen("czml", "zmluva", 1);
            DGen("obj_datum", "obj_datum", 1);
            DGen("obj_rok", "obj_rok", 1);
            DGen("obj_id", "obj_id", 1);
            DGen("partner_id", "partner_id", 1);
            DGen("kontakt_meno", "kontakt", 1);
            DGen("kontakt_funkcia", "funkcia", 1);
            DGen("kontakt_email", "email", 1);
            DGen("kontakt_tel", "telefón", 1);
            DGen("adr1", "adr1", 1);
            DGen("adr2", "adr2", 1);
            DGen("adr3", "adr3", 1);
            DGen("adr4", "adr4", 1);
            DGen("autor", "autor", 1);
            DGen("stamp", "zápis", 1);
        }
        // 1 - textbox, 2 - checkbox
        private void DGen(string Meno, string Popis, int Typ)
        {
            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            DataGridViewCheckBoxColumn c2 = new DataGridViewCheckBoxColumn();

            if (Typ == 1)
            {
                dg.Columns.Add(c1);
                c1.DataPropertyName = Meno;
                c1.Name = Meno;
                c1.HeaderText = Popis;
                c1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            if (Typ == 2)
            {
                dg.Columns.Add(c2);
                c2.DataPropertyName = Meno;
                c2.Name = Meno;
                c2.HeaderText = Popis;
                c2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
        #endregion

        #region DEFINOVANIE DATASOURCE - @pole
        private void myDataSource()
        {
            myDef("id");
            myDef("no");
            myDef("rok");
            myDef("labc");
            myDef("ozn");
            myDef("obj_id");
            myDef("v_matrica");
            myDef("v_meno");
            myDef("v_miesto");
            myDef("v_cas1");
            myDef("v_cas2");
            myDef("akr");
            myDef("obj_no");
            myDef("obj_rok");
            myDef("cobj");
            myDef("czml");
            myDef("obj_datum");
            myDef("meno");
            myDef("datum_dod");
            myDef("datum_termin");
            myDef("datum_start");
            myDef("datum_end");
            myDef("datum_protokol");
            myDef("partner_id");
            myDef("kontakt_meno");
            myDef("kontakt_funkcia");
            myDef("kontakt_email");
            myDef("kontakt_tel");
            myDef("adr1");
            myDef("adr2");
            myDef("adr3");
            myDef("adr4");

            myDef("pozn");
            //mySqlUpdateCommand.Parameters.Add("@refe_id");
            //mySqlUpdateCommand.Parameters.AddWithValue("@pozn", pozn_.Text);
            mySqlUpdateCommand.Parameters.AddWithValue("@refe_id", RRvar.idUser);
            //mySqlUpdateCommand.Parameters.AddWithValue("@stamp", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            //            datum_start_.DataBindings.Add("Text", bs, "datum_start", false, DataSourceUpdateMode.OnPropertyChanged);
            //            datum_end_.DataBindings.Add("Text", bs, "datum_end", false, DataSourceUpdateMode.OnPropertyChanged);
            //            datum_dod_.DataBindings.Add("Text", bs, "datum_dod", false, DataSourceUpdateMode.OnPropertyChanged);

        }
        #endregion 

        #region UPDATE
        private void myTaUpdate()
        {
            mySqlUpdateCommand.Parameters["@id"].Value = id_.Text;
            mySqlUpdateCommand.Parameters["@labc"].Value = labc_.Text;
            mySqlUpdateCommand.Parameters["@no"].Value = no_.Text;
            mySqlUpdateCommand.Parameters["@rok"].Value = rok_.Text;
            mySqlUpdateCommand.Parameters["@ozn"].Value = ozn_.Text;
            mySqlUpdateCommand.Parameters["@datum_dod"].Value = datum_dod_.Text;
            mySqlUpdateCommand.Parameters["@datum_termin"].Value = datum_termin_.Text;
            mySqlUpdateCommand.Parameters["@datum_start"].Value = datum_start_.Text;
            mySqlUpdateCommand.Parameters["@datum_end"].Value = datum_end_.Text;
            mySqlUpdateCommand.Parameters["@datum_protokol"].Value = datum_protokol_.Text;
            mySqlUpdateCommand.Parameters["@akr"].Value = akr_.Text;
            mySqlUpdateCommand.Parameters["@pozn"].Value = pozn_.Text;
            mySqlUpdateCommand.Parameters["@v_matrica"].Value = v_matrica_.Text;
            mySqlUpdateCommand.Parameters["@v_meno"].Value = v_meno_.Text;
            mySqlUpdateCommand.Parameters["@v_cas1"].Value = v_cas1_.Text;
            mySqlUpdateCommand.Parameters["@v_cas2"].Value = v_cas2_.Text;
            mySqlUpdateCommand.Parameters["@v_miesto"].Value = v_miesto_.Text;
            mySqlUpdateCommand.Parameters["@refe_id"].Value = RRvar.idUser;

            try
            {
                da.Update(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region BUTTONS CLICK

        private static DialogResult ShowInputDialog(ref string input)
        {
            System.Drawing.Size size = new System.Drawing.Size(165, 70);
            Form inputBox = new Form();
            inputBox.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            inputBox.ControlBox = false;
            inputBox.TopMost = true;
            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            inputBox.MinimizeBox = false;
            inputBox.ShowIcon = false;
            inputBox.ShowInTaskbar = false;
            inputBox.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            inputBox.StartPosition = FormStartPosition.CenterParent;
            inputBox.ShowInTaskbar = false;
            inputBox.AutoSize = false;
            inputBox.ClientSize = size;
            inputBox.Text = "Počet čísel";

            System.Windows.Forms.NumericUpDown nud = new NumericUpDown();
            nud.Minimum = 1;
            nud.Maximum = 10000;
            nud.Size = new System.Drawing.Size(75, 25);
            nud.Location = new System.Drawing.Point(5, 5);
            nud.Font = new Font("Segoe UI", 10);

            inputBox.Controls.Add(nud);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 28);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(5, 35);
            okButton.Font = new Font("Segoe UI", 10);

            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 28);
            cancelButton.Text = "&Zruš";
            cancelButton.Location = new System.Drawing.Point(85, 35);
            cancelButton.Font = new Font("Segoe UI", 10);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            input = nud.Value.ToString();
            return result;
        }

        private void bLabc_Click(object sender, EventArgs e)
        {
            int iMaxZakazka = 0;
            int iCurZakazka = 0;
            int iMin = 0;
            int iMax = 0;

            iCurZakazka = Convert.ToInt32(id_.Text);
            try
            {
                iMaxZakazka = Convert.ToInt32(RRsql.RunSqlReturn("select max(id) AS maximum from zakazka;"));
            }
            catch { }

            if (iCurZakazka < iMaxZakazka)
            {
                if (MessageBox.Show("Nemáte nastavenú poslednú zákazku.\r\nChcete pokračovať aj napriek tomu?", "Upozornenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }
            }

            string h, s, d, z, r;
            int iLabc = 0;
            Control[] c;

            h = "Zák.: ";

            d = "id";
            s = d + "_";
            c = this.Controls.Find(s, true);
            z = (c[0] as Label).Text;

            d = "labc";
            s = d + "_";
            c = this.Controls.Find(s, true);
            iLabc = Convert.ToInt32((c[0] as Label).Text);

            d = "no";
            s = d + "_";
            c = this.Controls.Find(s, true);
            h += (c[0] as TextBox).Text;

            d = "rok";
            s = d + "_";
            c = this.Controls.Find(s, true);
            h += "/" + (c[0] as TextBox).Text;
            r = (c[0] as TextBox).Text;

            d = "obj_no";
            s = d + "_";
            c = this.Controls.Find(s, true);
            h += " - obj.: " + (c[0] as TextBox).Text;

            d = "meno";
            s = d + "_";
            c = this.Controls.Find(s, true);
            h += " - " + (c[0] as TextBox).Text;

            string sPocet = "";

            string sTemp = lStatus.Text;
            int iStart = 0;
            int iLast = 0;
            int i = 0;
            string sSql;

            sSql = "select hodnota from last where " +
                    "rok = '" + r + "' and nazov = 'L';";
            try
            {
                iLast = Convert.ToInt16(RRsql.RunSqlReturn(sSql));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if (ShowInputDialog(ref sPocet) == DialogResult.OK)
            {
                if (Convert.ToInt32(sPocet) > 0)
                {
                    if (MessageBox.Show("Počet laboratórnych čísel na vygenerovanie: " + sPocet + "\r\n\r\nVygenerujem laboratórne čísla: " + (iLast + 1).ToString() + " - " + (iLast + Convert.ToInt16(sPocet)).ToString(), h, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        iMin = iLast + 1;
                        iMax = iLast + Convert.ToInt16(sPocet);

                        sSql = "select count(id) as total from last where " +
                                "rok = '" + r + "' and nazov = 'L';";

                        i = Convert.ToInt16(RRsql.RunSqlReturn(sSql));

                        if (i == 0)
                        {
                            sSql =
                            "INSERT INTO last (nazov, hodnota, rok) VALUES " +
                            "('L', 0, " + r + ");";
                            try
                            {
                                RRsql.RunSql(sSql);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                        }

                        sSql =
                            "select hodnota from last where " +
                            "rok = '" + r + "' and nazov = 'L';";
                        try
                        {
                            iLast = Convert.ToInt16(RRsql.RunSqlReturn(sSql));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        this.Enabled = false;

                        iStart = iLast + 1;

                        for (int j = 0; j < Convert.ToInt32(sPocet); j++)
                        {
                            iLast++;
                            iLabc++;
                            sSql =
                            "INSERT INTO labc (labc, rok, zakazka_id, pozn, refe_id) VALUES " +
                            "('" + iLast + "', " + r + ", '" + z + "', '" + h + "', '" + RRvar.idUser + "' );";
                            lStatus.Text = "Čakajte prosím, generujem laboratórne čísla: " + (j + 1) + "/" + sPocet + ", laboratórne číslo: " + iLast.ToString() + "/" + r;
                            Application.DoEvents();
                            try
                            {
                                RRsql.RunSql(sSql);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }

                            sSql =
                            "UPDATE last set hodnota = '" + iLast + "' where nazov='L' and rok='" + r + "';";
                            try
                            {
                                RRsql.RunSql(sSql);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                        }

                        sSql =
                            "UPDATE zakazka set labc = '" + iLabc + "' where id=" + z + ";";
                        try
                        {
                            RRsql.RunSql(sSql);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        lStatus.Text = sTemp;
                        labc_.Text = iLabc.ToString();
                        RRcode.Log("Generovanie č. " + sPocet + " ks pre " + h);
                        this.Enabled = true;
                        MessageBox.Show("Hotovo.\r\n\r\nPočet: " + sPocet + "\r\nRozsah: " + iStart.ToString() + " - " + iLast.ToString() + " / " + r + "\r\nSpolu čísel v zákazke: " + iLabc.ToString(), h, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string sPozn = pozn_.Text;
                        pozn_.Text = "LČ: " + iMin.ToString() + " - " + iMax.ToString() + " / " + r.ToString();
                        if (sPozn.Length > 0)
                        {
                            pozn_.Text += "\r\n";
                            pozn_.Text += sPozn;
                        }
                        myBsReload();
                        myEndEdit(true);

                    }
                }
            }
        }

        private void bSelect_Click(object sender, EventArgs e)
        {
            string h, s, d, z, r, id;
            int iLabc = 0;
            Control[] c;

            h = "Zák.: ";

            d = "id";
            s = d + "_";
            c = this.Controls.Find(s, true);
            z = (c[0] as Label).Text;
            id = (c[0] as Label).Text;

            d = "labc";
            s = d + "_";
            c = this.Controls.Find(s, true);
            iLabc = Convert.ToInt32((c[0] as Label).Text);

            d = "no";
            s = d + "_";
            c = this.Controls.Find(s, true);
            h += (c[0] as TextBox).Text;

            d = "rok";
            s = d + "_";
            c = this.Controls.Find(s, true);
            h += "/" + (c[0] as TextBox).Text;
            r = (c[0] as TextBox).Text;

            d = "obj_id";
            s = d + "_";
            c = this.Controls.Find(s, true);
            h += " - obj.: " + (c[0] as Label).Text;

            d = "meno";
            s = d + "_";
            c = this.Controls.Find(s, true);
            h += " - " + (c[0] as TextBox).Text;

            RRvar.sZakazkaId = "";
            if (iLabc == 0)
            {
                MessageBox.Show("Ešte neboli vygenerované žiadne laboratórne čísla!", h, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                RRvar.sZakazkaId = id;
                RRvar.sTemp = " where zakazka_id=" + id + ";";
                RRcode.Log("Laboratórne čísla: " + h);
                RRcode.FadeOut(this);
                this.Visible = false;
                Form Labc_zakazka = new Labc_zakazka();
                Labc_zakazka.Closed += new EventHandler(ChildFormClosed);
                RRvar.sHeader = "Laboratórne čísla: " + h;
                Labc_zakazka.Show();
            }
        }
        #endregion

        #region INSERT - ADDBUTTON OK MYINSERT
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bInsertIsRunning = true;
            oldSortOrder = dg.SortOrder == SortOrder.Ascending ? ListSortDirection.Ascending : ListSortDirection.Descending;
            oldSortCol = dg.SortedColumn;
            oldFilter = tSearch.Text;
            tSearch.Text = "";
            oldCombo = cFilter.SelectedIndex;
            cFilter.SelectedIndex = 0;
            dr.Focus();
            bExcel.Visible = false;
            bReload.Visible = false;
            bSelect.Visible = false;
            bKontakt.Visible = false;
            bPrevadzka.Visible = false;
            bPartner.Size = new Size(332, 30);

            bLabc.Visible = false;
            bs.Position = dg.RowCount;
            dg.Enabled = false;
            dg.Visible = false;
            bOK.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = false;
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorCountItem.Enabled = false;
            bindingNavigatorMoveFirstItem.Enabled = false;
            bindingNavigatorMoveLastItem.Enabled = false;
            bindingNavigatorMoveNextItem.Enabled = false;
            bindingNavigatorMovePreviousItem.Enabled = false;
            bindingNavigatorPositionItem.Enabled = false;

            id_.Text = "NOVÝ";
            foreach (Control ctr in dr.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = "";
                }
            }
            labc_.Text = "0";
            no_.Text = "---";
            obj_id_.Text = "---";
            obj_expired_.Text = "False";
            rok_.Text = RRvar.iRok.ToString();
            ozn_.Focus();
            int i = 0;
            string sSql =
            "select count(id) as total from last where " +
            "rok = '" + RRvar.iRok.ToString() + "' and nazov = 'Z';";

            i = Convert.ToInt16(RRsql.RunSqlReturn(sSql));

            if (i == 0)
            {
                sSql =
                "INSERT INTO last (nazov, hodnota, rok) VALUES " +
                "('Z', 0, " + RRvar.iRok.ToString() + ");";
                try
                {
                    RRsql.RunSql(sSql);
                }
                catch { }
            }
            RRvar.bSelect = true;

        }

        private void bOK_Click(object sender, EventArgs e)
        {
            if (!RRstring.IsNumeric(obj_id_.Text))
            {
                MessageBox.Show("Nie je zvolená objednávka.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);

                return;
            }

            bool bSuccessWrite = true;
            int iNumberNext = 0;
            bInsertIsRunning = true;
            int iNewId = 0;

            akr_.Text = "False";
            labc_.Text = "0";

            string sSql =
            "select hodnota from last where " +
            "rok = '" + RRvar.iRok.ToString() + "' and nazov = 'Z';";

            iNumberNext = Convert.ToInt16(RRsql.RunSqlReturn(sSql));
            iNumberNext++;

            cmd = new MySqlCommand(SqlInsertCommand, con);

            cmd.Parameters.AddWithValue("@no", iNumberNext);
            myIns("rok");
            myIns("ozn");
            myIns("obj_id");
            myIns("datum_dod");
            myIns("datum_termin");
            myIns("datum_start");
            myIns("datum_end");
            myIns("datum_protokol");
            myIns("akr");
            myIns("pozn");
            myIns("labc");
            myIns("v_matrica");
            myIns("v_meno");
            myIns("v_miesto");
            myIns("v_cas1");
            myIns("v_cas2");

            cmd.Parameters.AddWithValue("@refe_id", RRvar.idUser);
            //cmd.Parameters.AddWithValue("@stamp", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            using (System.Transactions.TransactionScope scope = new System.Transactions.TransactionScope())
            {
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    bSuccessWrite = false;
                    MessageBox.Show(ex.ToString());
                }

                con.Close();
                try
                {
                    iNewId = Convert.ToInt32(MySqlHelper.ExecuteScalar(RRvar.sConStr, "SELECT LAST_INSERT_ID();"));
                }
                catch { }
                scope.Complete();
            }

            RRcode.Log(sLog1 + RRsql.RunSqlReturn(SqlLogCommand));

            if (bSuccessWrite)
            {
                sSql =
                "UPDATE last set hodnota = '" + iNumberNext + "' where nazov='Z' and rok='" + RRvar.iRok + "';";
                try
                {
                    RRsql.RunSql(sSql);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            string sLog = RRsql.RunSqlReturn("SELECT CONCAT('id:', id, ' č. ', no, '/', rok, ' - ', meno) from zakazka_obj_partner ORDER BY id DESC LIMIT 1;");
            RRcode.Log("Nová zákazka: " + sLog);

            myDgReload();
            dg.Focus();
            dg.Enabled = true;
            dg.Visible = true;
            bOK.Enabled = false;
            bExcel.Visible = true;
            bReload.Visible = true;
            bSelect.Visible = true;
            bLabc.Visible = true;
            bKontakt.Visible = true;
            bPrevadzka.Visible = true;
            bPartner.Size = new Size(106, 30);
            bindingNavigatorDeleteItem.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = true;
            bindingNavigatorCountItem.Enabled = true;
            bindingNavigatorMoveFirstItem.Enabled = true;
            bindingNavigatorMoveLastItem.Enabled = true;
            bindingNavigatorMoveNextItem.Enabled = true;
            bindingNavigatorMovePreviousItem.Enabled = true;
            bindingNavigatorPositionItem.Enabled = true;
            bInsertIsRunning = false;
            RRvar.bSelect = false;

            try
            {
                if (oldSortCol != null)
                {
                    DataGridViewColumn newCol = dg.Columns[oldSortCol.Name];
                    dg.Sort(newCol, oldSortOrder);
                }
            }
            catch { }

            foreach (DataGridViewRow row in dg.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(iNewId.ToString()))
                {
                    try
                    {
                        dg.Rows[row.Index].Selected = false;
                        dg.Rows[row.Index].Selected = true;
                        bs.Position = row.Index;
                    }
                    catch { }
                    break;
                }
            }
            cFilter.SelectedIndex = oldCombo;
            tSearch.Text = oldFilter;
            myEndEdit(true);
            dg.FirstDisplayedScrollingRowIndex = dg.SelectedRows[0].Index;
            // Headers();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            string sID = dg.CurrentRow.Cells[0].Value.ToString();
            int iIndex = dg.SelectedRows[0].Index;
            if (MessageBox.Show("Určite chceš vymazať záznam č. " + sID + " ?", "Mazanie dát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (MessageBox.Show("Určite vieš, čo robíš?", "Varovanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    myDelete();
                }
            }
            int numRowCount = dg.RowCount;
            if (iIndex >= numRowCount)
            {
                try
                {
                    dg.Rows[iIndex - 1].Selected = false;
                    dg.Rows[iIndex - 1].Cells[0].Selected = true;
                }
                catch { }
            }
            else
            {
                try
                {
                    dg.Rows[iIndex].Selected = false;
                    dg.Rows[iIndex].Cells[0].Selected = true;
                }
                catch { }
            }
        }
        #endregion

        #region ******************* BEZ ÚPRAV ******************* PODPORNE FUNKCIE
        private void myFill()
        {
            dt.Clear();
            this.da.Fill(dt);
        }

        private void myBsReload()
        {
            try
            {
                dg.DataSource = null;
                dg.DataSource = bs;
            }
            catch { }
        }

        private void myDelete()
        {
            try
            {
                bs.EndEdit();

                string s, d;
                Control[] c;
                d = "id";
                s = d + "_";
                c = this.Controls.Find(s, true);
                cmd.Parameters.AddWithValue("@" + d, (c[0] as Label).Text);

                //MessageBox.Show((c[0] as Label).Text);

                using (System.Transactions.TransactionScope scope = new System.Transactions.TransactionScope())
                {
                    con.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                    con.Close();
                    scope.Complete();
                }


                bs.RemoveCurrent();
                myTaUpdate();
            }
            catch { }
        }

        private void myEndEdit(bool bValidate)
        {
            try
            {
                if (bValidate)
                {
                    this.Validate();
                }
                bs.EndEdit();
                myTaUpdate();
            }
            catch { }
        }

        private void myIns(string sElement)
        {
            string s, d;
            Control[] c;

            try
            {
                d = sElement;
                s = d + "_";
                c = this.Controls.Find(s, true);
                cmd.Parameters.AddWithValue("@" + d, (c[0]).Text);
            }
            catch { }
        }

        private void myDef(string sElement)
        {
            string s, d;
            Control[] c;
            d = sElement;
            s = d + "_";
            try
            {
                c = this.Controls.Find(s, true);
                (c[0]).DataBindings.Add("Text", bs, d, false, DataSourceUpdateMode.OnPropertyChanged);
                mySqlUpdateCommand.Parameters.AddWithValue("@" + d, (c[0]).Text);
            }
            catch { }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            RRfun.ShowMyInfoToolTip(pictureBox1.Location.X + 50, pictureBox1.Location.Y + 50, this);
        }

        private void myDgReload()
        {
            try
            {
                myBsReload();
                myFill();
                bs.DataSource = dt;
                bn.BindingSource = bs;
                dg.DataSource = dt;
            }
            catch { }
        }

        private void myResize()
        {
            bn.Location = new Point(5, 5);
            bExcel.Location = new Point(5, dr.Height + bn.Height + 10);
            bSelect.Location = new Point(5 + bExcel.Height + 3, dr.Height + bn.Height + 10);
            bLabc.Location = new Point(5 + bExcel.Height + 150, dr.Height + bn.Height + 10);
            bReload.Location = new Point(5 + bExcel.Height + 200, dr.Height + bn.Height + 10);
            pictureBox1.Location = new Point(5, this.Size.Height - 120);
            dr.Location = new Point(5, 30);
            dg.Location = new Point(5 + 5 + dr.Width, 35);
            dg.Size = new Size(this.Size.Width - 35 - dr.Width, this.Size.Height - 105);
            Application.DoEvents();
        }

        private void dg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F12)
            {
                myClip();
            }
        }

        private void myClip()
        {
            try
            {
                int iX = dg.CurrentCellAddress.X;
                int iLastCell = dg.CurrentCellAddress.Y;
                string strID = dg.Rows[iLastCell].Cells[0].Value.ToString();
                int FirstDisplayedScrollingRowIndex = dg.FirstDisplayedScrollingRowIndex;
                dg.MultiSelect = true;
                dg.SelectAll();
                DataObject dataObj = dg.GetClipboardContent();
                Clipboard.SetDataObject(dataObj, true);
                IDataObject myDataObject = Clipboard.GetDataObject();
                myDataObject.GetData(DataFormats.UnicodeText);
                Clipboard.SetDataObject(myDataObject.GetData(DataFormats.UnicodeText), true);
                dg.MultiSelect = false;
                dg.FirstDisplayedScrollingRowIndex = FirstDisplayedScrollingRowIndex;
                dg.Rows[iLastCell].Selected = true;
                dg.CurrentCell = dg[2, iLastCell];
                dg.CurrentCell = dg[1, iLastCell];
                dg.CurrentCell = dg[iX, iLastCell];
                MessageBox.Show("Údaje z tabuľky boli uložené do schránky...", "Informácia", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch { }
        }

        public static void DoubleBuffered(DataGridView dgv, bool bvalue)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, bvalue, null);
        }

        private void myFilter()
        {
            try
            {
                if (cFilter.SelectedIndex != 0)
                {
                    bs.Filter = "Convert([" + cFilter.Text + "], 'System.String') LIKE '%" + tSearch.Text + "%'";
                }
                else
                {
                    sFilter = "";
                    if (tSearch.Text.Length > 0)
                    {
                        int i = 0;
                        foreach (DataGridViewColumn column in dg.Columns)
                        {
                            if (i > 0) sFilter += " OR ";
                            i++;
                            //cFilter.Items.Insert(i, column.HeaderText);
                            sFilter += "Convert([" + column.Name + "], 'System.String') LIKE '%" + tSearch.Text + "%'";
                        }
                        bs.Filter = sFilter;
                    }
                    else
                    {
                        bs.Filter = null;
                    }
                }
            }
            catch { }
        }

        private void ChildFormClosedFull(object sender, EventArgs e)
        {
            this.Enabled = true;
            RRcode.Front();
        }

        private void tSearch_TextChanged(object sender, EventArgs e)
        {
            myFilter();
        }

        private void cFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            myFilter();
        }

        private void dg_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1 && dg.Columns[e.ColumnIndex].Name != "Id")
                {
                    if (!String.IsNullOrEmpty(tSearch.Text))
                    {
                        String gridCellValue = e.FormattedValue.ToString();
                        int startIndexInCellValue;
                        startIndexInCellValue = gridCellValue.ToLower().IndexOf(tSearch.Text.ToLower());

                        if (startIndexInCellValue >= 0)
                        {
                            try
                            {
                                if (!(e.Value.ToString().ToLower() == "true" || e.Value.ToString().ToLower() == "false"))
                                {
                                    e.Handled = true;
                                    e.PaintBackground(e.CellBounds, true);
                                    //the highlite rectangle  
                                    Rectangle hl_rect = new Rectangle();
                                    hl_rect.Y = e.CellBounds.Y + 2;
                                    hl_rect.Height = e.CellBounds.Height - 5;
                                    String sBeforeSearchword = gridCellValue.Substring(0, startIndexInCellValue);
                                    String sSearchWord = gridCellValue.Substring(startIndexInCellValue, tSearch.Text.Length);
                                    Size s1 = TextRenderer.MeasureText(e.Graphics, sBeforeSearchword, e.CellStyle.Font, e.CellBounds.Size);
                                    Size s2 = TextRenderer.MeasureText(e.Graphics, sSearchWord, e.CellStyle.Font, e.CellBounds.Size);
                                    if (s1.Width > 5)
                                    {
                                        hl_rect.X = e.CellBounds.X + s1.Width - 5;
                                        hl_rect.Width = s2.Width - 6;
                                    }
                                    else
                                    {
                                        hl_rect.X = e.CellBounds.X + 2;
                                        hl_rect.Width = s2.Width - 6;
                                    }

                                    SolidBrush hl_brush;
                                    hl_brush = new SolidBrush(Color.Lime);
                                    e.Graphics.FillRectangle(hl_brush, hl_rect);
                                    hl_brush.Dispose();
                                    e.PaintContent(e.CellBounds);
                                }
                            }
                            catch { }
                        }
                    }
                }
            }
            catch { }
        }

        private void bExcel_Click(object sender, EventArgs e)
        {
            myClip();
        }

        private void dg_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            myEndEdit(true);
        }

        private void Zakazka_obj_partner_Resize(object sender, EventArgs e)
        {
            myResize();
        }

        private void bn_Validated(object sender, EventArgs e)
        {
            myEndEdit(false);
        }

        private void dr_Validated(object sender, EventArgs e)
        {
            myEndEdit(false);
        }

        private void poznTextBox_Validated(object sender, EventArgs e)
        {
            int FirstDisplayedScrollingRowIndex = dg.FirstDisplayedScrollingRowIndex;
            int FirstDisplayedScrollingColumnIndex = dg.FirstDisplayedScrollingColumnIndex;
            if (bInsertIsRunning)
            {
                return;
            }
            myBsReload();
            myEndEdit(true);
            try
            {
                dg.FirstDisplayedScrollingRowIndex = FirstDisplayedScrollingRowIndex;
                dg.FirstDisplayedScrollingColumnIndex = FirstDisplayedScrollingColumnIndex;
            }
            catch { }
            Headers();
        }

        private void Validated()
        {
            if (bInsertIsRunning)
            {
                return;
            }
            myBsReload();
            myEndEdit(true);
        }

        private void Zakazka_obj_partner_FormClosing(object sender, FormClosingEventArgs e)
        {
            RRvar.bDetail = false;
            RRvar.bSelect = false;
            //object o = MySqlHelper.ExecuteScalar(RRvar.sConStr, "delete from refe where (login='' or login is null) and (fullname='' or fullname is null);");
            RRcode.FadeOut(this);
        }

        private void dg_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Chyba zápisu", "Varovanie", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void expired__TextChanged(object sender, EventArgs e)
        {
            if (obj_expired_.Text == "True")
            {
                c_expired_.Checked = true;
            }
            else
            {
                c_expired_.Checked = false;
            }
        }

        private void c_expired__CheckedChanged(object sender, EventArgs e)
        {
            if (c_expired_.Checked)
            {
                obj_expired_.Text = "True";
            }
            else
            {
                obj_expired_.Text = "False";
            }
            if (!bInsertIsRunning) myEndEdit(true);

        }

        private void Obj_partnerClosed(object sender, EventArgs e)
        {
            RRcode.FadeIn(this);
            this.Visible = true;
            RRcode.Front();
        }
        private void Obj_partnerAddClosed(object sender, EventArgs e)
        {
            RRcode.FadeIn(this);
            this.Visible = true;
            if (Convert.ToInt32(RRvar.sIdObjZak) > 0)
            {
                obj_id_.Text = RRvar.sIdObjZak.ToString();
                Application.DoEvents();
                obj_no_.Text = RRvar.sTemp1;
                obj_rok_.Text = RRvar.sTemp2;
                cobj_.Text = RRvar.sTemp3;
                czml_.Text = RRvar.sTemp4;
                meno_.Text = RRvar.sTemp5;
                obj_datum_.Text = RRvar.sTemp6;
                obj_expired_.Text = RRvar.sTemp7;
            }
            //myReload();
            RRcode.Front();
        }

        private void KontaktAddClosed(object sender, EventArgs e)
        {
            RRcode.FadeIn(this);
            this.Visible = true;

            if (RRvar.bKontaktUpdated)
            {
                try
                {
                    RRsql.RunSql("UPDATE zakazka set kontakt_id='" + RRvar.kontakt_id + "' WHERE id = '" + id_.Text + "'");
                }
                catch { }
                myReload();
            }
            RRcode.Front();
        }

        private void PrevadzkaAddClosed(object sender, EventArgs e)
        {
            RRcode.FadeIn(this);
            this.Visible = true;

            if (RRvar.bPrevadzkaUpdated)
            {
                try
                {
                    RRsql.RunSql("UPDATE zakazka set prevadzka_id='" + RRvar.prevadzka_id + "' WHERE id = '" + id_.Text + "'");
                }
                catch { }
                myReload();
            }
            RRcode.Front();
        }

        private void bPartner_Click(object sender, EventArgs e)
        {
            //RRvar.bFilter = true;
            //RRvar.sFilter1 = "nazov1";
            //RRvar.sFilter2 = meno_.Text;

            RRvar.sIdObjZak = "0";
            if (!RRvar.bSelect)
            {
                RRvar.sTemp = " where id='" + obj_id_.Text + "'";
            }

            RRcode.FadeOut(this);
            this.Visible = false;
            Form Obj_partner = new Obj_partner();

            if (RRvar.bSelect)
            {
                RRvar.sTemp = "---";
                RRvar.iID = 0;
                RRvar.sHeader = "Číselník objednávok - pridelenie zákazky ku objednávke";
                Obj_partner.Closed += new EventHandler(Obj_partnerAddClosed);
            }
            else
            {
                RRvar.sHeader = "Číselník objednávok - detail objednávky";
                Obj_partner.Closed += new EventHandler(Obj_partnerClosed);
            }
            Obj_partner.Show();
        }

        private void d_dod_ValueChanged(object sender, EventArgs e)
        {
            datum_dod_.Text = d_dod.Value.ToString("yyyy-MM-dd");
            Validated();
        }

        private void d_termin_ValueChanged(object sender, EventArgs e)
        {
            datum_termin_.Text = d_termin.Value.ToString("yyyy-MM-dd");
            Validated();
        }

        private void d_start_ValueChanged(object sender, EventArgs e)
        {
            datum_start_.Text = d_start.Value.ToString("yyyy-MM-dd");
            Validated();
        }

        private void d_end_ValueChanged(object sender, EventArgs e)
        {
            datum_end_.Text = d_end.Value.ToString("yyyy-MM-dd");
            Validated();
        }

        private void d_protokol_ValueChanged(object sender, EventArgs e)
        {
            datum_protokol_.Text = d_protokol.Value.ToString("yyyy-MM-dd");
            Validated();
        }

        private void b_dod_Click(object sender, EventArgs e)
        {
            datum_dod_.Text = "";
            Validated();
        }

        private void b_termin_Click(object sender, EventArgs e)
        {
            datum_termin_.Text = "";
            Validated();
        }

        private void b_start_Click(object sender, EventArgs e)
        {
            datum_start_.Text = "";
            Validated();
        }

        private void b_end_Click(object sender, EventArgs e)
        {
            datum_end_.Text = "";
            Validated();
        }


        private void b_protokol_Click(object sender, EventArgs e)
        {
            datum_protokol_.Text = "";
            Validated();

        }


        private void datum_start__TextChanged(object sender, EventArgs e)
        {

        }

        private void c_akr_CheckedChanged(object sender, EventArgs e)
        {
            if (c_akr_.Checked)
            {
                akr_.Text = "True";
            }
            else
            {
                akr_.Text = "False";
            }
            if (!bInsertIsRunning) myEndEdit(true);
        }

        private void akr__TextChanged(object sender, EventArgs e)
        {
            if (akr_.Text == "True")
            {
                c_akr_.Checked = true;
            }
            else
            {
                c_akr_.Checked = false;
            }
        }

        public Zakazka_obj_partner()
        {
            InitializeComponent();
            da = new MySqlDataAdapter();
            bs.DataSource = dt;
            dg.DataSource = bs;
            bn.BindingSource = bs;
            //myDataSource();
        }

        private void ChildFormClosed(object sender, EventArgs e)
        {
            RRcode.FadeIn(this);
            this.Visible = true;
            RRcode.Front();
        }

        private void dg_Click(object sender, EventArgs e)
        {
            try
            {
                iSort = Convert.ToInt32(dg.Rows[dg.CurrentRow.Index].Cells[0].Value);
            }
            catch { }
        }

        private void dg_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int iRow = 0;
            foreach (DataGridViewRow row in dg.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(iSort.ToString()))
                {
                    iRow = row.Index;
                    break;
                }
            }
            try
            {
                dg.CurrentCell = dg.Rows[iRow].Cells[0];
                dg.Rows[iRow].Selected = true;
                dg.FirstDisplayedScrollingRowIndex = dg.SelectedRows[0].Index;

            }
            catch { }
        }
        #endregion

        private void myReload()
        {
            oldSortOrder = dg.SortOrder == SortOrder.Ascending ? ListSortDirection.Ascending : ListSortDirection.Descending;
            oldSortCol = dg.SortedColumn;
            oldFilter = tSearch.Text;
            tSearch.Text = "";
            oldCombo = cFilter.SelectedIndex;
            cFilter.SelectedIndex = 0;
            int iIndex = dg.SelectedRows[0].Index;

            myDgReload();
            bn.BindingSource = bs;
            dg.DataSource = bs;

            try
            {
                if (oldSortCol != null)
                {
                    DataGridViewColumn newCol = dg.Columns[oldSortCol.Name];
                    dg.Sort(newCol, oldSortOrder);
                }
            }
            catch { }

            try
            {
                dg.Rows[iIndex].Selected = false;
                dg.Rows[iIndex].Cells[0].Selected = true;
            }
            catch { }

            //foreach (DataGridViewRow row in dg.Rows)
            //{
            //    if (row.Cells[0].Value.ToString().Equals(iNewId.ToString()))
            //    {
            //        try
            //        {
            //            dg.Rows[row.Index].Selected = false;
            //            dg.Rows[row.Index].Selected = true;
            //            bs.Position = row.Index;
            //        }
            //        catch { }
            //        break;
            //    }
            //}

            cFilter.SelectedIndex = oldCombo;
            tSearch.Text = oldFilter;
            myEndEdit(true);

            try
            {
                dg.FirstDisplayedScrollingRowIndex = dg.SelectedRows[0].Index;
            }
            catch { }
        }

        private void bReload_Click(object sender, EventArgs e)
        {
            myReload();
        }

        private void bKontakt_Click(object sender, EventArgs e)
        {
            RRvar.bKontaktUpdated = false;
            RRvar.partner_id = partner_id_.Text;
            RRcode.FadeOut(this);
            this.Visible = false;
            Form Kontakt = new Kontakt();

            RRvar.sTemp = "---";
            RRvar.iID = 0;
            RRvar.sHeader = "Kontakty pre: " + meno_.Text;
            Kontakt.Closed += new EventHandler(KontaktAddClosed);
            Kontakt.Show();

        }

        private void pozn__TextChanged(object sender, EventArgs e)
        {

        }

        private void obj_id__TextChanged(object sender, EventArgs e)
        {
        }

        private void bPrevadzka_Click(object sender, EventArgs e)
        {
            RRvar.bPrevadzkaUpdated = false;
            RRvar.partner_id = partner_id_.Text;
            RRcode.FadeOut(this);
            this.Visible = false;
            Form Prevadzka = new Prevadzka();

            RRvar.sTemp = "---";
            RRvar.iID = 0;
            RRvar.sHeader = "Prevádzkovateľ pre: " + meno_.Text;
            Prevadzka.Closed += new EventHandler(PrevadzkaAddClosed);
            Prevadzka.Show();
        }

        private void b_cas1_Click(object sender, EventArgs e)
        {
            v_cas1_.Text = "";
            v_cas2_.Text = "";
            Validated();
        }

        private void b_cas2_Click(object sender, EventArgs e)
        {
            v_cas2_.Text = "";
            Validated();
        }

        private void d_cas1_ValueChanged(object sender, EventArgs e)
        {
            v_cas1_.Text = d_cas1.Value.ToString("yyyy-MM-dd");
            v_cas2_.Text = d_cas1.Value.ToString("yyyy-MM-dd");
            Validated();
        }

        private void d_cas2_ValueChanged(object sender, EventArgs e)
        {
            v_cas2_.Text = d_cas2.Value.ToString("yyyy-MM-dd");
            Validated();
        }
    }
}
