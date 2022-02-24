using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace sampleX
{
    public partial class DataA : Form
    {
        private readonly RRcode RRcode = new RRcode();
        private readonly RRfun RRfun = new RRfun();
        private readonly RRdata RRdata = new RRdata();
        private readonly RRsql RRsql = new RRsql();

        BindingSource bs = new BindingSource();
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable dt;
        DataTable dt2;
        DataTable dt3;

        MySqlCommand myCommand;
        MySqlDataAdapter MyAdapter;
        MySqlConnection con = new MySqlConnection(RRvar.sConStr);

        bool bUpdatingCombo;
        bool bStart = true;
        bool bAuto = true;

        string sMatrica;
        string sMatricaId;

        public DataA()
        {
            InitializeComponent();
        }

        private void DataA_Load(object sender, EventArgs e)
        {

            RRvar.sFooter = "sampleX verzia: " + Application.ProductVersion + " - " + RRvar.sFullName;
            lStatus.Text = RRvar.sFooter;
            label1.Text = "Obj.: " + RRvar.sTemp2 +
                            ", Zák.: " + RRvar.sTemp3 + ", Rok: " + RRvar.sTemp5;
            label2.Text = RRvar.sTemp4;
            this.Text = RRvar.sHeader + " - " + RRvar.sTemp1;
            RRcode.Front();
            myButtons();
            FilldtVsetko("select distinct catid as id, catvalue as value from f_cat_par1 order by catvalue");
            // dt.Rows.Add(0, "- všetko -");
            cMain.DisplayMember = "value";
            cMain.ValueMember = "id";
            cMain.DataSource = dt;
            //cMain.SelectedIndex = 0;
            //cMain.SelectedValue = Convert.ToInt32(RRvar.sTemp);
            DoIt1();
            FillCombosStart();

            dg.Columns.Add("parameterid", "parameterid");
            dg.Columns.Add("parameter", "Parameter");

            dg.Columns.Add("polozkaid", "polozkaid");
            dg.Columns.Add("polozka", "Položka");

            dg.Columns.Add("matricaid", "matricaid");
            dg.Columns.Add("matrica", "Matrica");

            dg.Columns.Add("principid", "principid");
            dg.Columns.Add("princip", "Princíp");

            dg.Columns.Add("oznid", "oznid");
            dg.Columns.Add("ozn", "Označenie");

            dg.Columns.Add("jednotkaid", "jednotkaid");
            dg.Columns.Add("jednotka", "Jednotka");

            dg.Columns.Add("oddid", "oddid");
            dg.Columns.Add("odd", "Oddelenie");

            dg.Columns["parameterid"].Visible = false;
            dg.Columns["polozkaid"].Visible = false;
            dg.Columns["matricaid"].Visible = false;
            dg.Columns["principid"].Visible = false;
            dg.Columns["oznid"].Visible = false;
            dg.Columns["jednotkaid"].Visible = false;
            dg.Columns["oddid"].Visible = false;

            dg.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10);
            dg.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            dg3.Columns.Add("id", "id");
            dg3.Columns.Add("labc", "labc");
            dg3.Columns.Add("rok", "rok");
            dg3.Columns.Add("pocet", "počet");
            dg3.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dg3.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10);
            dg3.Columns[0].Visible = false;
            dg3.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            int iDg3 = RRvar.Matrix2.Count;

            for (int i = 0; i < iDg3; i++)
            {
                dg3.Rows.Add(Convert.ToInt32(RRvar.Matrix2[i][0]), RRvar.Matrix2[i][1], RRvar.Matrix2[i][2], RRvar.Matrix2[i][3]);
            }

            try
            {
                dg3.Rows[0].Selected = true;
            }
            catch { }
            dg3.Sort(dg3.Columns[0], ListSortDirection.Ascending);

            //foreach (DataGridViewRow r in dg3.Rows)
            //{

            //  MessageBox.Show(r.Cells[0].Value.ToString());

            //}
            dg3.CurrentCell = dg3.Rows[0].Cells[1];
            bStart = false;
        }

        private void FillOneComboStart(string sSql, string sControl)
        {
            Filldt(sSql);
            List<KeyValuePair<string, string>> data = new List<KeyValuePair<string, string>>();
            data.Add(new KeyValuePair<string, string>("", ""));
            int i = 0;
            foreach (DataRow r in dt.Rows)
            {
                try
                {
                    data.Add(new KeyValuePair<string, string>(r["id"].ToString(), r["value"].ToString()));
                }
                catch
                {
                    i++;
                    data.Add(new KeyValuePair<string, string>(i.ToString(), r["value"].ToString()));
                }
            }
            Control[] c;
            c = this.Controls.Find(sControl, true);
            (c[0] as ComboBox).DataSource = new BindingSource(data, null);
            (c[0] as ComboBox).DisplayMember = "Value";
            (c[0] as ComboBox).ValueMember = "Key";
            (c[0] as ComboBox).SelectedIndex = 0;
        }

        private void FillCombosStart()
        {
            bUpdatingCombo = true;
            //            FillOneComboStart("select c_all.id, CONCAT(polozka, ' - ', xparameter.value) as value from c_all, xparameter where xparameter.id = c_all.parameter order by value", "cPolozka");
            FillOneComboStart("select DISTINCT polozka as value from c_all order by value", "cPolozka");
            FillOneComboStart("select id, value from xmatrica order by value", "cMatrica");
            FillOneComboStart("select id, value from xprincip order by value", "cPrincip");
            FillOneComboStart("select id, CONCAT(value, ' - ', popis) as value from xozn order by value", "cOzn");
            FillOneComboStart("select id, value from xjednotka order by value", "cJednotka");
            FillOneComboStart("select id, value from xodd order by value", "cOdd");
            bUpdatingCombo = false;
        }

        private void EnableCombos(bool bEnable)
        {
            if (bEnable)
            {
                cPolozka.Enabled = true;
                cMatrica.Enabled = true;
                cPrincip.Enabled = true;
                cOzn.Enabled = true;
                cJednotka.Enabled = true;
                cOdd.Enabled = true;
            }
            else
            {
                cPolozka.Enabled = false;
                cMatrica.Enabled = false;
                cPrincip.Enabled = false;
                cOzn.Enabled = false;
                cJednotka.Enabled = false;
                cOdd.Enabled = false;
            }
        }

        private void FillCombos()
        {
            int i = 0;
            string s, t;
            string s0 = "", s1 = "", s2 = "", s3 = "", s4 = "", s5 = "", s6 = "";
            bUpdatingCombo = true;
            try
            {
                i = dg2.SelectedCells[0].RowIndex;
                EnableCombos(true);

            }
            catch { EnableCombos(false); };

            DataGridViewRow selectedRow = dg2.Rows[i];
            t = selectedRow.Cells[0].Value.ToString();
            s0 = selectedRow.Cells[1].Value.ToString();
            s = "select polozkaid, matricaid, principid, oznid, jednotkaid, oddid from f_cat_par where parid='" + t + "' and catid= '" + cMain.SelectedValue + "'";

            Filldt(s);

            try
            {
                foreach (DataRow r in dt.Rows)
                {
                    s1 = r["polozkaid"].ToString();
                    s2 = r["matricaid"].ToString();
                    s3 = r["principid"].ToString();
                    s4 = r["oznid"].ToString();
                    s5 = r["jednotkaid"].ToString();
                    s6 = r["oddid"].ToString();
                }
            }
            catch { }

            try
            {
                cPolozka.Text = s1;
                //ComboFind(s1, "cPolozka");
                ComboFind(s2, "cMatrica");
                ComboFind(s3, "cPrincip");
                ComboFind(s4, "cOzn");
                ComboFind(s5, "cJednotka");
                ComboFind(s6, "cOdd");
            }
            catch { }
            bUpdatingCombo = false;
        }

        private void NullCombos()
        {
            int i = 0;
            bUpdatingCombo = true;
            cPolozka.SelectedIndex = 0;
            cMatrica.SelectedIndex = 0;
            cPrincip.SelectedIndex = 0;
            cOzn.SelectedIndex = 0;
            cJednotka.SelectedIndex = 0;
            cOdd.SelectedIndex = 0;
            bUpdatingCombo = false;
        }

        private string ComboId(string sControl)
        {
            Control[] c;
            c = this.Controls.Find(sControl, true);
            KeyValuePair<string, string> selectedPair = (KeyValuePair<string, string>)(c[0] as ComboBox).SelectedItem;
            return selectedPair.Key;
        }

        private void ComboFindOld(string s, string sControl)
        {
            string sItem;
            Control[] c;
            c = this.Controls.Find(sControl, true);
            (c[0] as ComboBox).SelectedIndex = 0;

            if (s.Length != 0)
            {

                for (int j = 0; j < (c[0] as ComboBox).Items.Count; j++)
                {
                    (c[0] as ComboBox).SelectedIndex = j;
                    sItem = ComboId(sControl);
                    KeyValuePair<string, string> selectedPair = (KeyValuePair<string, string>)(c[0] as ComboBox).SelectedItem;
                    if (sItem == s)
                    { break; }
                }
            }
        }

        private string ComboIdById(string sControl, int iIndex)
        {
            Control[] c;
            c = this.Controls.Find(sControl, true);
            KeyValuePair<string, string> selectedPair = (KeyValuePair<string, string>)(c[0] as ComboBox).Items[iIndex];
            return selectedPair.Key;
        }

        private void ComboFind(string s, string sControl)
        {
            string sItem;
            Control[] c;
            c = this.Controls.Find(sControl, true);
            (c[0] as ComboBox).SelectedIndex = 0;

            if (s.Length != 0)
            {

                for (int j = 0; j < (c[0] as ComboBox).Items.Count; j++)
                {
                    //(c[0] as ComboBox).SelectedIndex = j;

                    sItem = ComboIdById(sControl, j);
                    if (sItem == s)
                    {
                        (c[0] as ComboBox).SelectedIndex = j;
                        break;
                    }
                }
            }
        }



        private void DoIt1()
        {
            string s;
            s = "select id, value from xparameter order by value";
            Filldt(s);
            dg2.DataSource = dt;
            dg2.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dg2.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10);
            dg2.Columns[0].Visible = false;
            dg2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            try
            {
                dg2.Rows[0].Selected = true;
            }
            catch { }

        }

        private void DoIt2()
        {
            string s;
            s = "select parid as id, parvalue as value from f_cat_par1 where catid='" + RRvar.sTemp + "' order by ind";
            Filldt(s);
            dg2.DataSource = dt;
            dg2.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dg2.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10);
            dg2.Columns[0].Visible = false;
            dg2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            try
            {
                dg2.Rows[0].Selected = true;
            }
            catch { }
        }

        private void cMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cMain.SelectedIndex == 0)
            {
                bAddAll.Visible = false;
                bAuto = false;
                lAuto.Visible = false;
                lManual.Visible = true;
            }
            else
            {
                bAddAll.Visible = true;
                bAuto = true;
                lAuto.Visible = true;
                lManual.Visible = false;
            }

            if (!bStart)
            {
                if (cMain.SelectedIndex == 0)
                {
                    DoIt1();

                }
                else
                {
                    RRvar.sTemp = cMain.SelectedValue.ToString();
                    DoIt2();
                }
            }
        }

        private void FilldtVsetko(string sSql)
        {
            myCommand = new MySqlCommand(sSql, con);
            MyAdapter = new MySqlDataAdapter(myCommand);
            dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("value");
            dt.Rows.Add("0", "- všetko -");
            con.Open();
            MyAdapter.Fill(dt);
            con.Close();
            MyAdapter.Dispose();
        }

        private void Filldt(string sSql)
        {
            myCommand = new MySqlCommand(sSql, con);
            MyAdapter = new MySqlDataAdapter(myCommand);
            dt = new DataTable();
            con.Open();
            MyAdapter.Fill(dt);
            con.Close();
            MyAdapter.Dispose();
        }

        private void Filldt2(string sSql)
        {
            MySqlCommand myCommandTemp = new MySqlCommand(sSql, con);
            MySqlDataAdapter MyAdapterTemp = new MySqlDataAdapter(myCommandTemp);
            dt2 = new DataTable();
            con.Open();
            MyAdapterTemp.Fill(dt2);
            con.Close();
            MyAdapterTemp.Dispose();
        }

        private void Filldt3(string sSql)
        {
            MySqlCommand myCommandTemp = new MySqlCommand(sSql, con);
            MySqlDataAdapter MyAdapterTemp = new MySqlDataAdapter(myCommandTemp);
            dt3 = new DataTable();
            con.Open();
            MyAdapterTemp.Fill(dt3);
            con.Close();
            MyAdapterTemp.Dispose();
        }

        private void ChildFormClosedFull(object sender, EventArgs e)
        {
            RRcode.FadeIn(this);
            this.Visible = true;
            RRcode.Front();
        }

        private void DataA_Shown(object sender, EventArgs e)
        {
            RRcode.FadeIn(this);
            RRcode.Front();
        }

        private void pictureBox1_MouseHover_1(object sender, EventArgs e)
        {
            RRfun.ShowMyInfoToolTip(pictureBox1.Location.X + 50, pictureBox1.Location.Y + 50, this);
        }

        private void dg2_SelectionChanged(object sender, EventArgs e)
        {
            if (!bStart && bAuto)
            {
                try
                {
                    FillCombos();
                }
                catch { }
            }
            if (!bStart && !bAuto)
            {
                try
                {
                    NullCombos();
                }
                catch { }
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            string s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15;
            int i;
            i = dg2.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dg2.Rows[i];
            s1 = selectedRow.Cells[0].Value.ToString();
            s2 = selectedRow.Cells[1].Value.ToString();

            s3 = cPolozka.Text.ToString();
            s4 = cPolozka.Text.ToString();

            s5 = cMatrica.SelectedValue.ToString();
            s6 = cMatrica.Text.ToString();

            s7 = cPrincip.SelectedValue.ToString();
            s8 = cPrincip.Text.ToString();

            s9 = cOzn.SelectedValue.ToString();
            s10 = cOzn.Text.ToString();

            s11 = cJednotka.SelectedValue.ToString();
            s12 = cJednotka.Text.ToString();

            s13 = cOdd.SelectedValue.ToString();
            s14 = cOdd.Text.ToString();

            dg.Rows.Add(s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14);

            if (dg.Rows.Count > 0)
            {
                try
                {
                    dg.Rows[dg.Rows.Count - 1].Selected = true;
                    dg.CurrentCell = dg.Rows[dg.Rows.Count - 1].Cells[1];
                }
                catch { }
            }
        }

        private string OneCell(string sSQL, string sColumnName)
        {
            string s;
            try { dt3.Clear(); } catch { }
            Filldt3(sSQL);
            s = "";
            foreach (DataRow dr3 in dt3.Rows)
            {
                try
                {
                    s = dr3[sColumnName].ToString();
                }
                catch { }
            }
            return s;
        }

        private void bAddAll_Click(object sender, EventArgs e)
        {
            string s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14;
            string s = "select f_cat_par.id AS id from f_cat_par, xparameter where catid='" + cMain.SelectedValue + "' and f_cat_par.parid=xparameter.id order by ind";
            // ID vlastnej skupiny
            Filldt(s);

            foreach (DataRow dr in dt.Rows)
            {
                //MessageBox.Show("id riadky mojej kateg. "  + dr["id"].ToString());

                s = dr["id"].ToString();
                s = "select id, catid, parid, polozkaid, matricaid, principid, oznid, oddid, jednotkaid from f_cat_par where id='" + s + "'";
                Filldt2(s);
                foreach (DataRow dr2 in dt2.Rows)
                {

                    s = dr2["parid"].ToString();
                    s1 = s;
                    s = "SELECT xparameter.value from f_cat_par, xparameter WHERE xparameter.id = '" + s + "' AND f_cat_par.parid = xparameter.id";
                    s2 = OneCell(s, "value");

                    s = dr2["polozkaid"].ToString();
                    s3 = s;
                    s4 = s;
                    //s = "select c_all.id, CONCAT(polozka, ' - ', xparameter.value) as value from c_all, xparameter where xparameter.id = c_all.parameter AND c_all.id = '" + s + "'";
                    //s4 = OneCell(s, "value");

                    s = dr2["matricaid"].ToString();
                    s5 = s;
                    s = "SELECT xmatrica.value from f_cat_par, xmatrica WHERE xmatrica.id = '" + s + "' AND f_cat_par.matricaid = xmatrica.id";
                    s6 = OneCell(s, "value");

                    s = dr2["principid"].ToString();
                    s7 = s;
                    s = "SELECT xprincip.value from f_cat_par, xprincip WHERE xprincip.id = '" + s + "' AND f_cat_par.principid = xprincip.id";
                    s8 = OneCell(s, "value");

                    s = dr2["oznid"].ToString();
                    s9 = s;
                    s = "SELECT CONCAT(xozn.value, ' - ', xozn.popis) as value  from f_cat_par, xozn WHERE xozn.id = '" + s + "' AND f_cat_par.oznid = xozn.id";
                    s10 = OneCell(s, "value");

                    s = dr2["jednotkaid"].ToString();
                    s11 = s;
                    s = "SELECT xjednotka.value from f_cat_par, xjednotka WHERE xjednotka.id = '" + s + "' AND f_cat_par.jednotkaid = xjednotka.id";
                    s12 = OneCell(s, "value");

                    s = dr2["oddid"].ToString();
                    s13 = s;
                    s = "SELECT xodd.value from f_cat_par, xodd WHERE xodd.id = '" + s + "' AND f_cat_par.oddid = xodd.id";
                    s14 = OneCell(s, "value");

                    dg.Rows.Add(s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14);

                }
            }
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            int totalRows = dg.Rows.Count;

            try
            {
                int rowIndex = dg.SelectedCells[0].OwningRow.Index;
                dg.Rows.RemoveAt(rowIndex);
            }
            catch { }
        }

        private void bUp_Click(object sender, EventArgs e)
        {
            try
            {
                int totalRows = dg.Rows.Count;
                int rowIndex = dg.SelectedCells[0].OwningRow.Index;
                if (rowIndex == 0)
                    return;
                int colIndex = dg.SelectedCells[1].OwningColumn.Index;
                DataGridViewRow selectedRow = dg.Rows[rowIndex];
                dg.Rows.Remove(selectedRow);
                dg.Rows.Insert(rowIndex - 1, selectedRow);
                dg.ClearSelection();
                dg.Rows[rowIndex - 1].Cells[colIndex].Selected = true;
            }
            catch { }
        }

        private void bDown_Click(object sender, EventArgs e)
        {
            try
            {
                int totalRows = dg.Rows.Count;
                int rowIndex = dg.SelectedCells[0].OwningRow.Index;
                if (rowIndex == totalRows - 1)
                    return;
                int colIndex = dg.SelectedCells[1].OwningColumn.Index;
                DataGridViewRow selectedRow = dg.Rows[rowIndex];
                dg.Rows.Remove(selectedRow);
                dg.Rows.Insert(rowIndex + 1, selectedRow);
                dg.ClearSelection();
                dg.Rows[rowIndex + 1].Cells[colIndex].Selected = true;
            }
            catch { }
        }

        private void myButtons()
        {
            int i = dg.Rows.Count;
            if (i == 0)
            {
                bOK.Enabled = false;
                bUp.Enabled = false;
                bDown.Enabled = false;
                bDel.Enabled = false;
            }
            if (i == 1)
            {
                bOK.Enabled = true;
                bUp.Enabled = false;
                bDown.Enabled = false;
                bDel.Enabled = true;
            }
            if (i > 1)
            {
                bOK.Enabled = true;
                bUp.Enabled = true;
                bDown.Enabled = true;
                bDel.Enabled = true;
            }
        }

        private void dg_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            myButtons();
        }

        private void dg_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            myButtons();
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            int iTotal = 0;
            string s0 = "", s1 = "", s2 = "", s3 = "", s4 = "", s5 = "", s6 = "";
            string s;
            dg.Enabled = false;
            dg2.Enabled = false;
            dg3.Enabled = false;
            foreach (DataGridViewRow r in dg.Rows)
            {
                try
                {
                    s0 = r.Cells["parameterid"].Value.ToString();
                    s1 = r.Cells["polozkaid"].Value.ToString();
                    s2 = r.Cells["matricaid"].Value.ToString();
                    s3 = r.Cells["principid"].Value.ToString();
                    s4 = r.Cells["oznid"].Value.ToString();
                    s5 = r.Cells["jednotkaid"].Value.ToString();
                    s6 = r.Cells["oddid"].Value.ToString();

                    if (s0.Length == 0)
                    {
                        s0 = "NULL";
                    }

                    if (s2.Length == 0)
                    {
                        s2 = "NULL";
                    }

                    if (s3.Length == 0)
                    {
                        s3 = "NULL";
                    }

                    if (s4.Length == 0)
                    {
                        s4 = "NULL";
                    }

                    if (s5.Length == 0)
                    {
                        s5 = "NULL";
                    }

                    if (s6.Length == 0)
                    {
                        s6 = "NULL";
                    }

                    foreach (DataGridViewRow rdg3 in dg3.Rows)
                    {
                        rdg3.Selected = false;
                    }

                    foreach (DataGridViewRow rdg3 in dg3.Rows)
                    {
                        rdg3.Selected = true;
                        Application.DoEvents();
                        s = "INSERT INTO data " +
                        "(parameter, labc, polozka, matrica, princip, ozn, jednotka, odd, refe_id) " +
                        "VALUES ( " +
                        "'" + s0 + "', " +
                        "" + rdg3.Cells[0].Value.ToString() + ", " +
                        "'" + s1 + "', " +
                        "" + s2 + ", " +
                        "" + s3 + ", " +
                        "" + s4 + ", " +
                        "" + s5 + ", " +
                        "" + s6 + ", " +
                        "" + RRvar.idUser + " );";
                        RRsql.RunSql(s);
                        iTotal++;
                        rdg3.Selected = false;
                    }
                }
                catch { }
                r.Visible = false;
                Application.DoEvents();
            }
            dg.Enabled = false;
            dg2.Enabled = false;
            dg3.Enabled = false;
            dg3.CurrentCell = dg3.Rows[0].Cells[1];
            MessageBox.Show("Počet vygenerovaných záznamov: " + iTotal.ToString(), "Rekapitulácia", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bDelLc_Click(object sender, EventArgs e)
        {
            int totalRows = dg3.Rows.Count;
            try
            {
                int rowIndex = dg3.SelectedCells[0].OwningRow.Index;
                dg3.Rows.RemoveAt(rowIndex);
            }
            catch { }
            if (dg3.RowCount == 0)
            {
                this.Close();
            }
        }

        private void dg2_Paint(object sender, PaintEventArgs e)
        {
            ldg2.Text = "Počet: " + dg2.Rows.Count.ToString();
        }

        private void dg_Paint(object sender, PaintEventArgs e)
        {
            ldg.Text = "Počet: " + dg.Rows.Count.ToString();
        }

        private void dg3_Paint(object sender, PaintEventArgs e)
        {
            ldg3.Text = "Počet: " + dg3.Rows.Count.ToString();
        }

        private void dg_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int i = 0; i < (dg.Rows.Count); i++)
            {
                if (dg.Rows[i].Cells[1].Value.ToString().StartsWith(e.KeyChar.ToString(), true, CultureInfo.InvariantCulture))
                {
                    dg.Rows[i].Cells[1].Selected = true;
                    dg.CurrentCell = dg.Rows[i].Cells[1];
                    return;
                }
            }
        }

        private void dg2_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int i = 0; i < (dg2.Rows.Count); i++)
            {
                if (dg2.Rows[i].Cells["value"].Value.ToString().StartsWith(e.KeyChar.ToString(), true, CultureInfo.InvariantCulture))
                {
                    dg2.Rows[i].Cells["value"].Selected = true;
                    dg2.CurrentCell = dg2.Rows[i].Cells["value"];
                    return;
                }
            }
        }

        private void cMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            //for (int i = 0; i < (cMain.Items.Count); i++)
            //{
            //    if (cMain.Text.ToString().StartsWith(e.KeyChar.ToString(), true, CultureInfo.InvariantCulture))
            //    {
            //        cMain.SelectedIndex = i;
            //        return;
            //    }
            //}
        }

        private void bMatrica_Click(object sender, EventArgs e)
        {
            int i = 0;
            string s;


            if (dg.Rows.Count == 0)
            {

                MessageBox.Show("Nie sú zatiaľ pridané žiadne záznamy! ", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Určite mám všade nastaviť " + cMatrica.Text + "???", "Úprava dát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                sMatricaId = cMatrica.SelectedValue.ToString();
                sMatrica = cMatrica.Text.ToString();

                foreach (DataGridViewRow row in dg.Rows)
                {
                    row.Cells["matricaid"].Value = sMatricaId;
                    row.Cells["matrica"].Value = sMatrica;
                }
            }
        }
    }
}