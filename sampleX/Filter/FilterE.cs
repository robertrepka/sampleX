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
using System.Runtime.InteropServices;

using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.HSSF.Util;
using NPOI.XSSF.Util;
using NPOI.POIFS.FileSystem;
using NPOI.HPSF;

namespace sampleX
{
    public partial class FilterE : Form
    {
        private readonly RRcode RRcode = new RRcode();
        private readonly RRfun RRfun = new RRfun();
        private readonly RRdata RRdata = new RRdata();
        private readonly RRsql RRsql = new RRsql();

        BindingSource bs = new BindingSource();
        MySqlDataAdapter da = new MySqlDataAdapter();
        System.Data.DataTable dt;
        System.Data.DataTable dt2;
        System.Data.DataTable dt3;

        MySqlCommand myCommand;
        MySqlDataAdapter MyAdapter;
        MySqlConnection con = new MySqlConnection(RRvar.sConStr);

        bool bUpdatingCombo;
        bool bStart = true;
        bool bAuto = true;


        public FilterE()
        {
            InitializeComponent();
        }

        private void FilterE_Load(object sender, EventArgs e)
        {
            RRvar.sFooter = "sampleX verzia: " + System.Windows.Forms.Application.ProductVersion + " - " + RRvar.sFullName;
            lStatus.Text = RRvar.sFooter;
            this.Text = RRvar.sHeader;
            RRcode.Front();
            myButtons();
            dt = new System.Data.DataTable();
            dt2 = new System.Data.DataTable();
            dt3 = new System.Data.DataTable();
            FilldtVsetko("select distinct catid as id, catvalue as value from f_cat_par1 order by catvalue");
            // dt.Rows.Add(0, "- všetko -");
            cMain.DisplayMember = "value";
            cMain.ValueMember = "id";
            cMain.DataSource = dt;
            //cMain.SelectedIndex = 0;
            //cMain.SelectedValue = Convert.ToInt32(RRvar.sTemp);
            DoIt1();
            FillCombosStart();
            bStart = false;

            //DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            //dg.Columns.Add(btn);
            //btn.HeaderText = "Del";
            //btn.Text = "x";
            //btn.Name = "btn";
            //btn.UseColumnTextForButtonValue = true;

            //DataGridViewButtonColumn bUp = new DataGridViewButtonColumn();
            //dg.Columns.Add(bUp);
            //bUp.HeaderText = "Up";
            //bUp.Text = "Up";
            //bUp.Name = "bUp";
            //bUp.UseColumnTextForButtonValue = true;

            //DataGridViewButtonColumn bDown = new DataGridViewButtonColumn();
            //dg.Columns.Add(bDown);
            //bDown.HeaderText = "Down";
            //bDown.Text = "Down";
            //bDown.Name = "bDown";
            //bDown.UseColumnTextForButtonValue = true;

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

            dg.AlternatingRowsDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
            dg.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);

            if (RRvar.bShowExportPatternAnalyt)
            {
                bAnalyt.Visible = true;
                try
                {
                    cMain.Text = RRvar.sTransferNameOfAnalytGroup;
                }
                catch { }
            }

            if (RRvar.bShowExportPatternData)
            {
                bData.Visible = true;
            }

            RRvar.bShowExportPatternAnalyt = false;
            RRvar.bShowExportPatternData = false;
            RRvar.sTransferNameOfAnalytGroup = "";
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
                    (c[0] as ComboBox).SelectedIndex = j;
                    sItem = ComboId(sControl);
                    KeyValuePair<string, string> selectedPair = (KeyValuePair<string, string>)(c[0] as ComboBox).SelectedItem;
                    if (sItem == s)
                    { break; }
                }
            }
        }

        private void DoIt1()
        {
            string s;
            s = "select id, value from xparameter order by value";
            Filldt(s);
            dg2.DataSource = dt;
            dg2.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
            dg2.AlternatingRowsDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
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
            s = "select parid as id, parvalue as value from f_cat_par1 where catid='" + RRvar.sTemp + "' order by parvalue";
            Filldt(s);
            dg2.DataSource = dt;
            dg2.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
            dg2.AlternatingRowsDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
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
            dt = new System.Data.DataTable();
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
            dt = new System.Data.DataTable();
            con.Open();
            MyAdapter.Fill(dt);
            con.Close();
            MyAdapter.Dispose();
        }

        private void Filldt2(string sSql)
        {
            MySqlCommand myCommandTemp = new MySqlCommand(sSql, con);
            MySqlDataAdapter MyAdapterTemp = new MySqlDataAdapter(myCommandTemp);
            dt2 = new System.Data.DataTable();
            con.Open();
            MyAdapterTemp.Fill(dt2);
            con.Close();
            MyAdapterTemp.Dispose();
        }

        private void Filldt3(string sSql)
        {
            MySqlCommand myCommandTemp = new MySqlCommand(sSql, con);
            MySqlDataAdapter MyAdapterTemp = new MySqlDataAdapter(myCommandTemp);
            dt3 = new System.Data.DataTable();
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

        private void FilterE_Shown(object sender, EventArgs e)
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
            try 
            { 
                dt3.Clear(); 
            } catch { }
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
            string s = "select f_cat_par.id AS id from f_cat_par, xparameter where catid='" + cMain.SelectedValue + "' and f_cat_par.parid=xparameter.id order by xparameter.value";
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
                bData.Enabled = false;
                bAnalyt.Enabled = false;
                bUp.Enabled = false;
                bDown.Enabled = false;
                bDel.Enabled = false;
            }
            if (i == 1)
            {
                bData.Enabled = true;
                bAnalyt.Enabled = true;
                bUp.Enabled = false;
                bDown.Enabled = false;
                bDel.Enabled = true;
            }
            if (i > 1)
            {
                bData.Enabled = true;
                bAnalyt.Enabled = true;
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

        private void dg_Paint(object sender, PaintEventArgs e)
        {
            label1.Text = "Počet: " + dg.Rows.Count.ToString();
        }

        
        private void bOK_Click(object sender, EventArgs e)
        {
            RRdata.MatrixFill(3, "select value from xparameter order by value", true);

            var xBook = new HSSFWorkbook();
            var xSheet = xBook.CreateSheet("sampleX");
            ICell xCell;
            var fontI = xBook.CreateFont();
            fontI.IsItalic = true;

            var fontB = xBook.CreateFont();
            fontB.Boldweight = (short)FontBoldWeight.Bold;

            ICellStyle xTextCellStyle = xBook.CreateCellStyle();
            xTextCellStyle.DataFormat = xBook.CreateDataFormat().GetFormat("text");

            ICellStyle xTextCellStyleB = xBook.CreateCellStyle();
            xTextCellStyleB.DataFormat = xBook.CreateDataFormat().GetFormat("text");
            xTextCellStyleB.SetFont(fontB);

            HSSFCellStyle xTextCellStyleBor = (HSSFCellStyle)xBook.CreateCellStyle();
            xTextCellStyleBor.BorderLeft = NPOI.SS.UserModel.BorderStyle.Medium;
            xTextCellStyleBor.BorderTop = NPOI.SS.UserModel.BorderStyle.Medium;
            xTextCellStyleBor.BorderRight = NPOI.SS.UserModel.BorderStyle.Medium;
            xTextCellStyleBor.BorderBottom = NPOI.SS.UserModel.BorderStyle.Medium;
            xTextCellStyleBor.DataFormat = xBook.CreateDataFormat().GetFormat("text");

            HSSFCellStyle xTextCellStyleBorI = (HSSFCellStyle)xBook.CreateCellStyle();
            xTextCellStyleBorI.BorderLeft = NPOI.SS.UserModel.BorderStyle.Medium;
            xTextCellStyleBorI.BorderTop = NPOI.SS.UserModel.BorderStyle.Medium;
            xTextCellStyleBorI.BorderRight = NPOI.SS.UserModel.BorderStyle.Medium;
            xTextCellStyleBorI.BorderBottom = NPOI.SS.UserModel.BorderStyle.Medium;
            xTextCellStyleBorI.DataFormat = xBook.CreateDataFormat().GetFormat("text");
            xTextCellStyleBorI.SetFont(fontI);

            HSSFCellStyle xTextCellStyleBorB = (HSSFCellStyle)xBook.CreateCellStyle();
            xTextCellStyleBorB.BorderLeft = NPOI.SS.UserModel.BorderStyle.Medium;
            xTextCellStyleBorB.BorderTop = NPOI.SS.UserModel.BorderStyle.Medium;
            xTextCellStyleBorB.BorderRight = NPOI.SS.UserModel.BorderStyle.Medium;
            xTextCellStyleBorB.BorderBottom = NPOI.SS.UserModel.BorderStyle.Medium;
            xTextCellStyleBorB.DataFormat = xBook.CreateDataFormat().GetFormat("text");
            xTextCellStyleBorB.SetFont(fontB);

            HSSFCellStyle xTextCellStyleBorBdole = (HSSFCellStyle)xBook.CreateCellStyle();
            xTextCellStyleBorBdole.BorderBottom = NPOI.SS.UserModel.BorderStyle.Double;
            xTextCellStyleBorBdole.DataFormat = xBook.CreateDataFormat().GetFormat("text");
            xTextCellStyleBorBdole.SetFont(fontB);

            HSSFCellStyle xTextCellStyleBorDole = (HSSFCellStyle)xBook.CreateCellStyle();
            xTextCellStyleBorDole.BorderBottom = NPOI.SS.UserModel.BorderStyle.Double;
            xTextCellStyleBorDole.DataFormat = xBook.CreateDataFormat().GetFormat("text");

            string sRok = DateTime.Now.Year.ToString().Substring(2, 2);

            var iRow = 0;
            var r = xSheet.CreateRow(iRow);
            xCell = r.CreateCell(0);
            xCell.CellStyle = xTextCellStyleBorDole;
            xCell.SetCellValue("Laboratórne číslo / Parameter");

            int iCol = 1;
            foreach (DataGridViewRow dr in dg.Rows)
            {
                xCell = r.CreateCell(iCol);
                xCell.CellStyle = xTextCellStyleBorBdole;
                xCell.SetCellValue(dr.Cells[1].Value.ToString());
                iCol++;
            }

            r = xSheet.CreateRow(1);
            xCell = r.CreateCell(0);
            xCell.CellStyle = xTextCellStyle;
            xCell.SetCellValue("x/" + sRok);

            for (int i = 0; i <= iCol; i++)
            {
                xSheet.AutoSizeColumn(i);
            }

            xSheet = xBook.CreateSheet("Detaily");
            iRow = 0;
            r = xSheet.CreateRow(iRow);

            xCell = r.CreateCell(0);
            xCell.CellStyle = xTextCellStyleB;
            xCell.SetCellValue("Detaily merania:");

            iRow = 2;
            r = xSheet.CreateRow(iRow);
            xCell = r.CreateCell(0);
            xCell.CellStyle = xTextCellStyleBorI;
            xCell.SetCellValue("Parameter");

            xCell = r.CreateCell(1);
            xCell.CellStyle = xTextCellStyleBorI;
            xCell.SetCellValue("Položka");

            xCell = r.CreateCell(2);
            xCell.CellStyle = xTextCellStyleBorI;
            xCell.SetCellValue("Matrica");

            xCell = r.CreateCell(3);
            xCell.CellStyle = xTextCellStyleBorI;
            xCell.SetCellValue("Princíp");

            xCell = r.CreateCell(4);
            xCell.CellStyle = xTextCellStyleBorI;
            xCell.SetCellValue("Označenie");

            xCell = r.CreateCell(5);
            xCell.CellStyle = xTextCellStyleBorI;
            xCell.SetCellValue("Jednotka");

            xCell = r.CreateCell(6);
            xCell.CellStyle = xTextCellStyleBorI;
            xCell.SetCellValue("Oddelenie");

            iRow = 3;
            foreach (DataGridViewRow dr in dg.Rows)
            {
                r = xSheet.CreateRow(iRow);
                xCell = r.CreateCell(0);
                xCell.CellStyle = xTextCellStyleBor;
                xCell.SetCellValue(dr.Cells[1].Value.ToString());

                xCell = r.CreateCell(1);
                xCell.CellStyle = xTextCellStyleBor;
                xCell.SetCellValue(dr.Cells[3].Value.ToString());

                xCell = r.CreateCell(2);
                xCell.CellStyle = xTextCellStyleBor;
                xCell.SetCellValue(dr.Cells[5].Value.ToString());

                xCell = r.CreateCell(3);
                xCell.CellStyle = xTextCellStyleBor;
                xCell.SetCellValue(dr.Cells[7].Value.ToString());

                xCell = r.CreateCell(4);
                xCell.CellStyle = xTextCellStyleBor;
                xCell.SetCellValue(dr.Cells[9].Value.ToString());

                xCell = r.CreateCell(5);
                xCell.CellStyle = xTextCellStyleBor;
                xCell.SetCellValue(dr.Cells[11].Value.ToString());

                xCell = r.CreateCell(6);
                xCell.CellStyle = xTextCellStyleBor;
                xCell.SetCellValue(dr.Cells[13].Value.ToString());

                iRow++;
            }
            iRow++;
            iRow++;
            r = xSheet.CreateRow(iRow);
            xCell = r.CreateCell(0);
            xCell.CellStyle = xTextCellStyleB;
            xCell.SetCellValue("Všetky dostupné parametre:");
            iRow++;
            iRow++;
            for (int i = 0; i < RRvar.Matrix3.Count; i++)
            {
                r = xSheet.CreateRow(iRow);
                xCell = r.CreateCell(0);
                xCell.CellStyle = xTextCellStyleBor;
                xCell.SetCellValue(RRdata.MatrixRead(3, i, 0));
                iRow++;
            }

            for (int i = 0; i < 7; i++)
            {
                xSheet.AutoSizeColumn(i);
            }

            var xDocInfo = NPOI.HPSF.PropertySetFactory.CreateDocumentSummaryInformation();
            var xInfo = NPOI.HPSF.PropertySetFactory.CreateSummaryInformation();
            xInfo.Author = "sampleX © 2022 Róbert Repka";
            xInfo.Subject = "sampleX - šablóna na import údajov";
            xInfo.Comments = "robert@repka.org\r\n+421917799260";
            xInfo.Keywords = "meranie";

            xDocInfo.Company = "Štátny geologický ústav Dionýza Štúra, Odbor geoanalytických laboratórií, Spišská Nová Ves";
            //xDocInfo.Category = "Category";

            xBook.DocumentSummaryInformation = xDocInfo;
            xBook.SummaryInformation = xInfo;

            System.Windows.Forms.SaveFileDialog SD = new System.Windows.Forms.SaveFileDialog();
            SD.Title = "Export XLS šablóny";
            SD.RestoreDirectory = true;
            SD.DefaultExt = "xls";
            SD.Filter = "MS Excel (*.xls)|*.xls";
            SD.CheckPathExists = true;
            SD.FileName = cMain.Text + " - " + DateTime.Now.ToString("yyyy'-'MM'-'dd'_'HH'-'mm'-'ss") + ".xls";

            if (SD.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream stream = new FileStream(SD.FileName, FileMode.Create, FileAccess.Write))
                    {
                        xBook.Write(stream);
                    }
                }
                catch
                {
                    MessageBox.Show("Nepodarilo za mi zapísať súbor.\r\n", "Varovanie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //var xBook = new XSSFWorkbook();
            //var xxSheet = xBook.CreatexxSheet("sampleX");
            //var iRow = 0;
            //var r = xSheet.CreateRow(iRow);

            //string sRok = DateTime.Now.Year.ToString().Substring(2,2);

            //r.CreateCell(0).SetCellValue("Parameter / Laboratórne číslo");
            //r.CreateCell(1).SetCellValue("x/" + sRok);

            //iRow++;
            //foreach (DataGridViewRow row in dg.Rows)
            //{
            //    r = xSheet.CreateRow(iRow);
            //    r.CreateCell(0).SetCellValue(row.Cells[1].Value.ToString());
            //    iRow++;
            //}
            //xSheet.AutoSizeColumn(0);

            //System.Windows.Forms.SaveFileDialog SD = new System.Windows.Forms.SaveFileDialog();
            //SD.Title = "Export XLSX šablóny";
            //SD.RestoreDirectory = true;
            //SD.DefaultExt = "xlsx";
            //SD.Filter = "MS Excel (*.xlsx)|*.xlsx";
            //SD.CheckPathExists = true;
            //SD.FileName = cMain.Text + " - " + DateTime.Now.ToString("yyyy'-'MM'-'dd'_'HH'-'mm'-'ss") + ".xlsx";

            //if (SD.ShowDialog() == DialogResult.OK)
            //{
            //    try
            //    {
            //        using (FileStream stream = new FileStream(SD.FileName, FileMode.Create, FileAccess.Write))
            //        {
            //            xBook.Write(stream);
            //        }
            //    }
            //    catch 
            //    {
            //            MessageBox.Show("Nepodarilo za mi zapísať súbor.\r\n", "Varovanie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}  
        }
        private void bAnalyt_Click(object sender, EventArgs e)
        {
            RRdata.MatrixFill(3, "select value from xparameter order by value", true);

            var xBook = new HSSFWorkbook();
            var xSheet = xBook.CreateSheet("sampleX");
            ICell xCell;
            var fontI = xBook.CreateFont();
            fontI.IsItalic = true;

            var fontB = xBook.CreateFont();
            fontB.Boldweight = (short)FontBoldWeight.Bold;

            ICellStyle xTextCellStyle = xBook.CreateCellStyle();
            xTextCellStyle.DataFormat = xBook.CreateDataFormat().GetFormat("text");

            ICellStyle xTextCellStyleB = xBook.CreateCellStyle();
            xTextCellStyleB.DataFormat = xBook.CreateDataFormat().GetFormat("text");
            xTextCellStyleB.SetFont(fontB);

            HSSFCellStyle xTextCellStyleBor = (HSSFCellStyle)xBook.CreateCellStyle();
            xTextCellStyleBor.BorderLeft = NPOI.SS.UserModel.BorderStyle.Medium;
            xTextCellStyleBor.BorderTop = NPOI.SS.UserModel.BorderStyle.Medium;
            xTextCellStyleBor.BorderRight = NPOI.SS.UserModel.BorderStyle.Medium;
            xTextCellStyleBor.BorderBottom = NPOI.SS.UserModel.BorderStyle.Medium;
            xTextCellStyleBor.DataFormat = xBook.CreateDataFormat().GetFormat("text");

            HSSFCellStyle xTextCellStyleBorI = (HSSFCellStyle)xBook.CreateCellStyle();
            xTextCellStyleBorI.BorderLeft = NPOI.SS.UserModel.BorderStyle.Medium;
            xTextCellStyleBorI.BorderTop = NPOI.SS.UserModel.BorderStyle.Medium;
            xTextCellStyleBorI.BorderRight = NPOI.SS.UserModel.BorderStyle.Medium;
            xTextCellStyleBorI.BorderBottom = NPOI.SS.UserModel.BorderStyle.Medium;
            xTextCellStyleBorI.DataFormat = xBook.CreateDataFormat().GetFormat("text");
            xTextCellStyleBorI.SetFont(fontI);

            HSSFCellStyle xTextCellStyleBorB = (HSSFCellStyle)xBook.CreateCellStyle();
            xTextCellStyleBorB.BorderLeft = NPOI.SS.UserModel.BorderStyle.Medium;
            xTextCellStyleBorB.BorderTop = NPOI.SS.UserModel.BorderStyle.Medium;
            xTextCellStyleBorB.BorderRight = NPOI.SS.UserModel.BorderStyle.Medium;
            xTextCellStyleBorB.BorderBottom = NPOI.SS.UserModel.BorderStyle.Medium;
            xTextCellStyleBorB.DataFormat = xBook.CreateDataFormat().GetFormat("text");
            xTextCellStyleBorB.SetFont(fontB);

            HSSFCellStyle xTextCellStyleBorBdole = (HSSFCellStyle)xBook.CreateCellStyle();
            xTextCellStyleBorBdole.BorderBottom = NPOI.SS.UserModel.BorderStyle.Double;
            xTextCellStyleBorBdole.DataFormat = xBook.CreateDataFormat().GetFormat("text");
            xTextCellStyleBorBdole.SetFont(fontB);

            HSSFCellStyle xTextCellStyleBorDole = (HSSFCellStyle)xBook.CreateCellStyle();
            xTextCellStyleBorDole.BorderBottom = NPOI.SS.UserModel.BorderStyle.Double;
            xTextCellStyleBorDole.DataFormat = xBook.CreateDataFormat().GetFormat("text");

            string sRok = DateTime.Now.Year.ToString().Substring(2, 2);

            var iRow = 0;
            var r = xSheet.CreateRow(iRow);
            xCell = r.CreateCell(0);
            xCell.CellStyle = xTextCellStyleBorDole;
            xCell.SetCellValue("Identifikácia lokality");

            int iCol = 1;
            xCell = r.CreateCell(iCol);
            xCell.CellStyle = xTextCellStyleBorDole;
            xCell.SetCellValue("Lab. č.");

            iCol++;
            xCell = r.CreateCell(iCol);
            xCell.CellStyle = xTextCellStyleBorDole;
            xCell.SetCellValue("Rok");

            iCol++;
            xCell = r.CreateCell(iCol);
            xCell.CellStyle = xTextCellStyleBorDole;
            xCell.SetCellValue("Homog.");

            iCol++;
            xCell = r.CreateCell(iCol);
            xCell.CellStyle = xTextCellStyleBorDole;
            xCell.SetCellValue("Príprava");

            iCol++;
            foreach (DataGridViewRow dr in dg.Rows)
            {
                xCell = r.CreateCell(iCol);
                xCell.CellStyle = xTextCellStyleBorBdole;
                xCell.SetCellValue(dr.Cells[1].Value.ToString());
                iCol++;
            }

            //r = xSheet.CreateRow(1);
            //xCell = r.CreateCell(0);
            //xCell.CellStyle = xTextCellStyle;
            //xCell.SetCellValue("x/" + sRok);

            for (int i = 0; i <= iCol; i++)
            {
                xSheet.AutoSizeColumn(i);
            }

            xSheet = xBook.CreateSheet("Detaily");
            iRow = 0;
            r = xSheet.CreateRow(iRow);

            xCell = r.CreateCell(0);
            xCell.CellStyle = xTextCellStyleB;
            xCell.SetCellValue("Detaily merania:");

            iRow = 2;
            r = xSheet.CreateRow(iRow);
            xCell = r.CreateCell(0);
            xCell.CellStyle = xTextCellStyleBorI;
            xCell.SetCellValue("Parameter");

            xCell = r.CreateCell(1);
            xCell.CellStyle = xTextCellStyleBorI;
            xCell.SetCellValue("Položka");

            xCell = r.CreateCell(2);
            xCell.CellStyle = xTextCellStyleBorI;
            xCell.SetCellValue("Matrica");

            xCell = r.CreateCell(3);
            xCell.CellStyle = xTextCellStyleBorI;
            xCell.SetCellValue("Princíp");

            xCell = r.CreateCell(4);
            xCell.CellStyle = xTextCellStyleBorI;
            xCell.SetCellValue("Označenie");

            xCell = r.CreateCell(5);
            xCell.CellStyle = xTextCellStyleBorI;
            xCell.SetCellValue("Jednotka");

            xCell = r.CreateCell(6);
            xCell.CellStyle = xTextCellStyleBorI;
            xCell.SetCellValue("Oddelenie");

            iRow = 3;
            foreach (DataGridViewRow dr in dg.Rows)
            {
                r = xSheet.CreateRow(iRow);
                xCell = r.CreateCell(0);
                xCell.CellStyle = xTextCellStyleBor;
                xCell.SetCellValue(dr.Cells[1].Value.ToString());

                xCell = r.CreateCell(1);
                xCell.CellStyle = xTextCellStyleBor;
                xCell.SetCellValue(dr.Cells[3].Value.ToString());

                xCell = r.CreateCell(2);
                xCell.CellStyle = xTextCellStyleBor;
                xCell.SetCellValue(dr.Cells[5].Value.ToString());

                xCell = r.CreateCell(3);
                xCell.CellStyle = xTextCellStyleBor;
                xCell.SetCellValue(dr.Cells[7].Value.ToString());

                xCell = r.CreateCell(4);
                xCell.CellStyle = xTextCellStyleBor;
                xCell.SetCellValue(dr.Cells[9].Value.ToString());

                xCell = r.CreateCell(5);
                xCell.CellStyle = xTextCellStyleBor;
                xCell.SetCellValue(dr.Cells[11].Value.ToString());

                xCell = r.CreateCell(6);
                xCell.CellStyle = xTextCellStyleBor;
                xCell.SetCellValue(dr.Cells[13].Value.ToString());

                iRow++;
            }
            iRow++;
            iRow++;
            r = xSheet.CreateRow(iRow);
            xCell = r.CreateCell(0);
            xCell.CellStyle = xTextCellStyleB;
            xCell.SetCellValue("Všetky dostupné parametre:");
            iRow++;
            iRow++;
            for (int i = 0; i < RRvar.Matrix3.Count; i++)
            {
                r = xSheet.CreateRow(iRow);
                xCell = r.CreateCell(0);
                xCell.CellStyle = xTextCellStyleBor;
                xCell.SetCellValue(RRdata.MatrixRead(3, i, 0));
                iRow++;
            }

            for (int i = 0; i < 7; i++)
            {
                xSheet.AutoSizeColumn(i);
            }

            var xDocInfo = NPOI.HPSF.PropertySetFactory.CreateDocumentSummaryInformation();
            var xInfo = NPOI.HPSF.PropertySetFactory.CreateSummaryInformation();
            xInfo.Author = "sampleX © 2022 Róbert Repka";
            xInfo.Subject = "sampleX - šablóna na import údajov";
            xInfo.Comments = "robert@repka.org\r\n+421917799260";
            xInfo.Keywords = "meranie";

            xDocInfo.Company = "Štátny geologický ústav Dionýza Štúra, Odbor geoanalytických laboratórií, Spišská Nová Ves";
            //xDocInfo.Category = "Category";

            xBook.DocumentSummaryInformation = xDocInfo;
            xBook.SummaryInformation = xInfo;

            System.Windows.Forms.SaveFileDialog SD = new System.Windows.Forms.SaveFileDialog();
            SD.Title = "Export XLS šablóny";
            SD.RestoreDirectory = true;
            SD.DefaultExt = "xls";
            SD.Filter = "MS Excel (*.xls)|*.xls";
            SD.CheckPathExists = true;
            SD.FileName = cMain.Text + " - " + DateTime.Now.ToString("yyyy'-'MM'-'dd'_'HH'-'mm'-'ss") + ".xls";

            if (SD.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream stream = new FileStream(SD.FileName, FileMode.Create, FileAccess.Write))
                    {
                        xBook.Write(stream);
                    }
                }
                catch
                {
                    MessageBox.Show("Nepodarilo za mi zapísať súbor.\r\n", "Varovanie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}