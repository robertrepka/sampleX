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
    public partial class DataC : Form
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
        bool bAkr;
        int iDes = 0;

        public DataC()
        {
            InitializeComponent();
        }

        private void DataC_Load(object sender, EventArgs e)
        {
            RRvar.sFooter = "sampleX verzia: " + Application.ProductVersion + " - " + RRvar.sFullName;
            lStatus.Text = RRvar.sFooter;
            string sSql;
            string sSqlOddNull;
            lMin.Text = "";
            lMax.Text = "";
            lNeistota.Text = "";
            lMin_.Text = "";
            lMax_.Text = "";
            lNeistota_.Text = "";
            lMeral.Text = "";
            HideResult(true);
            bClear.Visible = false;

            sSql = " SELECT data.id AS dataid, polozka, matrica, princip, data.ozn, jednotka, odd, " +
                    " labc.id AS labcid, labc.labc AS labc, labc.rok AS rok, " +
                    " zakazka.ozn AS oznac, " +
                    " partner.nazov as nazov, " +
                    " zakazka.no as zakazka, zakazka.rok as rok_zakazka, " +
                    " obj.no as obj, obj.rok as rok_obj, " +
                    " data.parameter as parid, xparameter.value as parameter " +
                    " , data.result as vysledok, data.neistota, data.akr, data.medza, data.pozn " +
                    " , data.result_id as meral, data.stamp, des " +
                    " from xparameter, data, labc, zakazka, obj, partner, xodd " +
                    " WHERE  " +
                    " data.odd = xodd.id AND  " +
                    " data.parameter = xparameter.id AND  " +
                    " data.labc = labc.id AND  " +
                    " labc.zakazka_id = zakazka.id AND  " +
                    " zakazka.obj_id = obj.id AND  " +
                    " obj.partner_id = partner.id AND " +
                    " labc.id = '" + RRvar.sTemp1 + "' ";

            sSqlOddNull = " SELECT data.id AS dataid, polozka, matrica, princip, data.ozn, jednotka, odd, " +
                        " labc.id AS labcid, labc.labc AS labc, labc.rok AS rok, " +
                        " zakazka.ozn AS oznac, " +
                        " partner.nazov as nazov, " +
                        " zakazka.no as zakazka, zakazka.rok as rok_zakazka, " +
                        " obj.no as obj, obj.rok as rok_obj, " +
                        " data.parameter as parid, xparameter.value as parameter " +
                        " , data.result as vysledok, data.neistota, data.akr, data.medza, data.pozn " +
                        " , data.result_id as meral, data.stamp, des " +
                        " from xparameter, data, labc, zakazka, obj, partner " +
                        " WHERE  " +
                        " data.parameter = xparameter.id AND  " +
                        " data.labc = labc.id AND  " +
                        " labc.zakazka_id = zakazka.id AND  " +
                        " zakazka.obj_id = obj.id AND  " +
                        " obj.partner_id = partner.id AND " +
                        " labc.id = '" + RRvar.sTemp1 + "' AND " +
                        " data.odd IS NULL ";

            if (RRvar.iFilterMeranie == 0)
            {
                Filldt(sSql);
                Filldt2(sSqlOddNull);
                dt.Merge(dt2);
                dg.DataSource = dt;
                try
                {
                    dg.Sort(dg.Columns["dataid"], ListSortDirection.Ascending);
                }
                catch { }
            }

            if (RRvar.iFilterMeranie > 1)
            {
                sSql += " AND data.odd = '" + RRvar.iFilterMeranie + "' ";
                Filldt(sSql);
                dg.DataSource = dt;
                try
                {
                    dg.Sort(dg.Columns["dataid"], ListSortDirection.Ascending);
                }
                catch { }
            }

            if (RRvar.iFilterMeranie == 1)
            {
                Filldt(sSqlOddNull);
                dg.DataSource = dt;
                try
                {
                    dg.Sort(dg.Columns["dataid"], ListSortDirection.Ascending);
                }
                catch { }
            }

            for (int i = 0; i <= 16; i++)
            {
                dg.Columns[i].Visible = false;
            }
            dg.Columns["meral"].Visible = false;
            dg.Columns["stamp"].Visible = false;
            dg.Columns["des"].Visible = false;

            this.dg.Columns["vysledok"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dg.Columns["vysledok"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dg.Columns["neistota"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dg.Columns["neistota"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dg.Columns["medza"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dg.Columns["medza"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dg.Columns.RemoveAt(20);
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "akr";
            chk.Name = "akr";
            chk.DataPropertyName = "akr";
            dg.Columns.Insert(20, chk);

            lPartner.Text = dg.Rows[0].Cells["nazov"].Value.ToString();
            lObj.Text = dg.Rows[0].Cells["obj"].Value.ToString() + "/" + dg.Rows[0].Cells["rok_obj"].Value.ToString();
            lZakazka.Text = dg.Rows[0].Cells["zakazka"].Value.ToString() + "/" + dg.Rows[0].Cells["rok_zakazka"].Value.ToString();
            lLabc.Text = dg.Rows[0].Cells["labc"].Value.ToString() + "/" + dg.Rows[0].Cells["rok"].Value.ToString();
            lOzn.Text = dg.Rows[0].Cells["oznac"].Value.ToString();

            switch (RRvar.iFilterMeranie)
            {
                case 0:
                    lFilter.Text = "Všetky oddelenia";
                    break;
                case 1:
                    lFilter.ForeColor = System.Drawing.Color.Red;
                    lFilter.Text = "Nevyplnené oddelenie";
                    break;
                default:
                    lFilter.ForeColor = System.Drawing.Color.Red;
                    lFilter.Text = RRvar.sFilterMeranie;
                    break;
            }

            this.Text = "Výsledky merania";
            RRcode.Front();
            myButtons();
            FillCombosStart();
            dg.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10);
            dg.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            sSql = "SELECT id, fullname FROM refe;";
            RRdata.MatrixFill(2, sSql, true);
            FillCombos();
            Meral();
            ResultPrepare();
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
            string t;
            string s1 = "", s2 = "", s3 = "", s4 = "", s5 = "", s6 = "";

            bUpdatingCombo = true;
            try
            {
                EnableCombos(true);
            }
            catch { EnableCombos(false); };

            t = dg.SelectedRows[0].Cells[0].Value.ToString();

            s1 = dg.SelectedRows[0].Cells["polozka"].Value.ToString();
            s2 = dg.SelectedRows[0].Cells["matrica"].Value.ToString();
            s3 = dg.SelectedRows[0].Cells["princip"].Value.ToString();
            s4 = dg.SelectedRows[0].Cells["ozn"].Value.ToString();
            s5 = dg.SelectedRows[0].Cells["jednotka"].Value.ToString();
            s6 = dg.SelectedRows[0].Cells["odd"].Value.ToString();

            try
            {
                cPolozka.Text = s1;
                ComboFind(s2, "cMatrica");
                ComboFind(s3, "cPrincip");
                ComboFind(s4, "cOzn");
                ComboFind(s5, "cJednotka");
                ComboFind(s6, "cOdd");
            }
            catch { }

            tMedza.Text = "";
            cAkr.Checked = false;

            if (tResult.Text.Length == 0)
            {
                ResultPrepare();
            }
            bUpdatingCombo = false;
        }

        private void ResultCheck()
        {
            lMin.Text = "";
            lMax.Text = "";
            lNeistota.Text = "";
            lMin_.Text = "";
            lMax_.Text = "";
            lNeistota_.Text = "";
            tMedza.Text = "";
            tNeistota.Text = "";
            tPozn.Text = "";
            bool bFound = false;
            iDes = 0;

            if (tResult.Text.Length > 0)
            {
                bOK.Visible = true;
            }
            else
            {
                bOK.Visible = false;
            }

            try
            {
                double d = Convert.ToDouble(tResult.Text.Replace('.', ','));
                double dValue = 0;
                double dMin = 0;
                double dMax = 0;
                double dNeistota = 0;
                double dMedza = Convert.ToDouble(RRdata.MatrixRead(3, 0, 0));

                tMedza.Text = RRdata.MatrixRead(3, 0, 0);
                bFound = false;

                for (int i = 0; i < RRvar.Matrix3.Count; i++)
                {
                    if (!bFound)
                    {
                        dMin = Convert.ToDouble(RRdata.MatrixRead(3, i, 0));
                        dMax = Convert.ToDouble(RRdata.MatrixRead(3, i, 1));
                        dValue = Convert.ToDouble(RRdata.MatrixRead(3, i, 3));
                        iDes = Convert.ToInt16(RRdata.MatrixRead(3, i, 2));

                        tMedza.Text = RRdata.MatrixRead(3, 0, 0);

                        if (d >= dMin && d <= dMax)
                        {
                            bFound = true;
                            dNeistota = dValue;
                            tNeistota.Text = dValue.ToString();

                            lMin_.Text = "Min:";
                            lMax_.Text = "Max:";
                            lNeistota_.Text = "Neistota:";

                            lMin.Text = dMin.ToString("0.000000");
                            lMax.Text = dMax.ToString("0.000000");
                            lNeistota.Text = dValue.ToString();
                        }

                        if (d < dMedza)
                        {
                            bFound = true;
                            tPozn.Text = "< " + dMedza;
                        }
                    }
                }
            }
            catch { }

            if (bFound)
            {
                cAkr.Checked = true;
            }
            else
            {
                cAkr.Checked = false;
                tMedza.Text = "";
            }
        }

        private void ResultPrepare()
        {
            int i = 0;
            string s, t;
            string s0 = "", s1 = "", s2 = "", s3 = "", s4 = "", s5 = "", s6 = "";
            string sAll = "";
            DataGridViewRow selectedRow = dg.SelectedRows[i];

            s1 = selectedRow.Cells["parid"].Value.ToString();
            s2 = selectedRow.Cells["princip"].Value.ToString();
            s3 = selectedRow.Cells["ozn"].Value.ToString();
            s4 = selectedRow.Cells["odd"].Value.ToString();
            s5 = selectedRow.Cells["jednotka"].Value.ToString();
            s6 = selectedRow.Cells["matrica"].Value.ToString();

            s = "SELECT id from c_all WHERE " +
                " parameter = '" + s1 + "' AND princip = '" + s2 + "' AND " +
                " ozn = '" + s3 + "' AND odd = '" + s4 + "' AND jednotka = '" + s5 + "';";
            bAkr = true;

            try { sAll = RRsql.RunSqlReturn(s).ToString(); }
            catch { sAll = ""; }

            if (sAll.Length > 0)
            {
                s = "SELECT id from c_matrica WHERE " +
                " c_all = '" + sAll + "' AND matrica = '" + s6 + "';";
                try { s0 = RRsql.RunSqlReturn(s).ToString(); }
                catch { s0 = ""; }
                //s0 = RRsql.RunSqlReturn(s).ToString();
                if (!(s0.Length > 0))
                {
                    bAkr = false;
                }
            }
            else
            {
                bAkr = false;
            }

            if (bAkr)
            {
                cAkr.Checked = true;
                s = "SELECT min, max, des, value from c_neistota WHERE " +
                " c_all = '" + sAll + "' ORDER BY min;";
                RRdata.MatrixFill(3, s, true);
                iDes = Convert.ToInt16(RRdata.MatrixRead(3, i, 2));
                tResult.BackColor = Color.Aquamarine;
            }
            else
            {
                cAkr.Checked = false;
                RRdata.MatrixClear(3);
                tResult.BackColor = Color.LavenderBlush;
            }
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

        private void DataC_Shown(object sender, EventArgs e)
        {
            try
            {
                if (dg.SelectedRows[0].Cells["vysledok"].Value.ToString().Length > 0)
                {
                    HideResult(true);
                    bClear.Visible = true;
                }
                else
                {
                    HideResult(false);
                    bClear.Visible = false;
                }
            }
            catch { }
            RRcode.FadeIn(this);
            RRcode.Front();
        }

        private void pictureBox1_MouseHover_1(object sender, EventArgs e)
        {
            RRfun.ShowMyInfoToolTip(pictureBox1.Location.X + 50, pictureBox1.Location.Y + 50, this);
        }

        private void dg_SelectionChanged(object sender, EventArgs e)
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

        private void myButtons()
        {
            int i = dg.Rows.Count;
            if (i == 0)
            {
                bOK.Enabled = false;
                bDel.Enabled = false;
            }
            if (i == 1)
            {
                bOK.Enabled = true;
                bDel.Enabled = true;
            }
            if (i > 1)
            {
                bOK.Enabled = true;
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

            string sId;
            string s = "UPDATE data set result = '" + tResult.Text.Replace(',', '.') + "' "; ;
            DataGridViewRow selectedRow = dg.SelectedRows[0];
            sId = selectedRow.Cells[0].Value.ToString();

            if (tNeistota.Text.Length > 0)
            {
                s += ", neistota = '" + tNeistota.Text.Replace(',', '.') + "' ";
            }

            if (tMedza.Text.Length > 0)
            {
                s += ", medza = '" + tMedza.Text.Replace(',', '.') + "' ";
            }

            if (cAkr.Checked)
            {
                s += ", akr = 'true' ";
                s += ", des = '" + iDes.ToString() + "' ";
            }
            else
            {
                s += ", akr = 'false' ";
            }

            s += ", pozn = '" + tPozn.Text + "' ";
            s += ", result_id = '" + RRvar.idUser.ToString() + "' ";
            s += " WHERE id = '" + sId + "';";

            try
            {
                RRsql.RunSql(s);

                if (tResult.Text.Length > 0)
                {
                    selectedRow.Cells["vysledok"].Value = tResult.Text.Replace('.', ',');
                }
                else
                {
                    selectedRow.Cells["vysledok"].Value = DBNull.Value;
                }

                if (tMedza.Text.Length > 0)
                {
                    selectedRow.Cells["medza"].Value = tMedza.Text.Replace('.', ',');
                }
                else
                {
                    selectedRow.Cells["medza"].Value = DBNull.Value;
                }

                if (tNeistota.Text.Length > 0)
                {
                    selectedRow.Cells["neistota"].Value = tNeistota.Text.Replace('.', ',');
                }
                else
                {
                    selectedRow.Cells["neistota"].Value = DBNull.Value;
                }

                if (cAkr.Checked)
                {
                    selectedRow.Cells["akr"].Value = true;
                    selectedRow.Cells["des"].Value = iDes.ToString();
                }
                else
                {
                    selectedRow.Cells["akr"].Value = false;
                }
                selectedRow.Cells["meral"].Value = RRvar.idUser;
                selectedRow.Cells["pozn"].Value = tPozn.Text.Replace('.', ',');
                selectedRow.Cells["stamp"].Value = DateTime.Now.ToLongTimeString();
                HideResult(true);
                Meral();
                bClear.Visible = true;
            }
            catch
            {
                MessageBox.Show("Chyba pri zápise!");
            }
        }

        private void HideResult(bool bHide)
        {
            if (bHide)
            {
                l1.Visible = false;
                l2.Visible = false;
                l3.Visible = false;
                l4.Visible = false;
                l5.Visible = false;
                tResult.Visible = false;
                tNeistota.Visible = false;
                tMedza.Visible = false;
                tPozn.Visible = false;
                cAkr.Visible = false;
                bOK.Visible = false;
                tResult.Text = string.Empty;
                tNeistota.Text = string.Empty;
                tMedza.Text = string.Empty;
                tPozn.Text = string.Empty;
                EnableCombos(false);
            }
            else
            {
                l1.Visible = true;
                l2.Visible = true;
                l3.Visible = true;
                l4.Visible = true;
                l5.Visible = true;
                tResult.Visible = true;
                tNeistota.Visible = true;
                tMedza.Visible = true;
                tPozn.Visible = true;
                cAkr.Visible = true;
                bOK.Visible = false;
                tResult.Text = string.Empty;
                tNeistota.Text = string.Empty;
                tMedza.Text = string.Empty;
                tPozn.Text = string.Empty;
                EnableCombos(true);
            }
        }

        private void Meral()
        {
            bool bFound = false;
            try
            {
                if (dg.SelectedRows[0].Cells["Meral"].Value.ToString().Length > 0)
                {
                    for (int i = 0; i < RRvar.Matrix2.Count; i++)
                    {
                        if (!bFound)
                        {
                            if (dg.SelectedRows[0].Cells["Meral"].Value.ToString() == RRdata.MatrixRead(2, i, 0))
                            {
                                lMeral.Text = RRdata.MatrixRead(2, i, 1) + " - " + dg.SelectedRows[0].Cells["stamp"].Value.ToString();
                                label14.Visible = true;
                                bFound = true;
                            }
                        }
                    }
                }
                else
                {
                    lMeral.Text = string.Empty;
                    label14.Visible = false;
                }
            }
            catch { }
        }

        private void dg_SelectionChanged_1(object sender, EventArgs e)
        {
            if (!bStart)
            {
                try
                {
                    FillCombos();
                }
                catch { }
            }
            Meral();
            tResult.Text = string.Empty;
            try
            {
                if (dg.SelectedRows[0].Cells["vysledok"].Value.ToString().Length > 0)
                {
                    HideResult(true);
                    bClear.Visible = true;
                }
                else
                {
                    HideResult(false);
                    bClear.Visible = false;
                }
            }
            catch { }
        }

        private void UpdateDataInt(string sColName, string sControl)
        {
            string sIdData;
            string sSql;
            string i;
            string s;

            if (!bStart && !bUpdatingCombo)
            {
                sIdData = dg.SelectedRows[0].Cells[0].Value.ToString();
                Control[] c;
                c = this.Controls.Find(sControl, true);

                i = (c[0] as ComboBox).SelectedValue.ToString();
                s = (c[0] as ComboBox).Text.ToString();

                if (s.Length == 0)
                {
                    sSql = "update data set " + sColName + " = NULL, refe_id='" + RRvar.idUser + "' where id='" + sIdData + "' ";
                }
                else
                {
                    sSql = "update data set " + sColName + " = '" + i + "', refe_id='" + RRvar.idUser + "' where id='" + sIdData + "' ";
                }

                try
                {
                    RRsql.RunSql(sSql);
                    if (s.Length == 0)
                    {
                        dg.SelectedRows[0].Cells[sColName].Value = DBNull.Value;

                    }
                    else
                    {
                        dg.SelectedRows[0].Cells[sColName].Value = i;
                    }

                }
                catch { }
                ResultPrepare();
            }
        }

        private void cOdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataInt("odd", "cOdd");
        }

        private void cJednotka_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataInt("jednotka", "cJednotka");
        }

        private void cOzn_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataInt("ozn", "cOzn");
        }

        private void cPrincip_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataInt("princip", "cPrincip");
        }

        private void cMatrica_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataInt("matrica", "cMatrica");
        }

        private void cPolozka_TextChanged(object sender, EventArgs e)
        {
            string iIdData;
            string sSql;
            string s;
            if (!bStart && !bUpdatingCombo)
            {
                iIdData = dg.SelectedRows[0].Cells[0].Value.ToString();
                s = cPolozka.Text.ToString();

                if (s.Length == 0)
                {
                    sSql = "update data set polozka = NULL, refe_id='" + RRvar.idUser + "' where id='" + iIdData + "' ";
                }
                else
                {
                    sSql = "update data set polozka = '" + s + "', refe_id='" + RRvar.idUser + "' where id='" + iIdData + "' ";
                }

                try
                {
                    RRsql.RunSql(sSql);
                    if (s.Length == 0)
                    {
                        dg.SelectedRows[0].Cells["polozka"].Value = DBNull.Value;
                    }
                    else
                    {
                        dg.SelectedRows[0].Cells["polozka"].Value = cPolozka.Text.ToString();
                    }
                }
                catch { }
                ResultPrepare();
            }
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            int totalRows = dg.Rows.Count;
            string sSql;
            string s = dg.SelectedCells[0].Value.ToString();

            if (MessageBox.Show("Určite chceš vymazať merací záznam pre " + s + " ?", "Mazanie dát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    sSql = "delete from data where id='" + s + "';";
                    RRsql.RunSql(sSql);
                    int rowIndex = dg.SelectedCells[0].OwningRow.Index;
                    dg.Rows.RemoveAt(rowIndex);
                }
                catch { }
            }
        }

        private void tResult_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tNeistota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tMedza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tResult_TextChanged(object sender, EventArgs e)
        {
            ResultCheck();
        }

        private void bClear_Click(object sender, EventArgs e)
        {

            string sId = dg.SelectedRows[0].Cells[0].Value.ToString();
            string s = "UPDATE data set result = NULL, neistota = NULL, medza = NULL, akr = NULL, pozn = NULL , des = NULL " +
                        " WHERE id = '" + sId + "';";

            if (MessageBox.Show("Určite chceš vymazať nameranú hodnotu pre " + dg.SelectedRows[0].Cells["parameter"].Value.ToString() + " ?", "Mazanie dát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    RRsql.RunSql(s);
                    dg.SelectedRows[0].Cells["vysledok"].Value = DBNull.Value;
                    dg.SelectedRows[0].Cells["medza"].Value = DBNull.Value;
                    dg.SelectedRows[0].Cells["neistota"].Value = DBNull.Value;
                    dg.SelectedRows[0].Cells["akr"].Value = false;
                    dg.SelectedRows[0].Cells["pozn"].Value = DBNull.Value;
                    dg.SelectedRows[0].Cells["des"].Value = DBNull.Value;
                    dg.SelectedRows[0].Cells["stamp"].Value = DateTime.Now.ToLongTimeString();
                    HideResult(false);
                    Meral();
                }
                catch
                {
                    MessageBox.Show("Chyba pri zápise!");
                }
            }
        }

        private void dg_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int i = 0; i < (dg.Rows.Count); i++)
            {
                if (dg.Rows[i].Cells["parameter"].Value.ToString().StartsWith(e.KeyChar.ToString(), true, CultureInfo.InvariantCulture))
                {
                    dg.Rows[i].Cells["parameter"].Selected = true;
                    dg.CurrentCell = dg.Rows[i].Cells["parameter"];
                    return;
                }
            }
        }
    }
}