using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using MySql.Data.MySqlClient;
using System.IO;
using System.Runtime.InteropServices;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.HSSF.Util;
using NPOI.XSSF.Util;
using NPOI.POIFS.FileSystem;
using NPOI.HPSF;
using NPOI.SS.Formula.Functions;

namespace sampleX
{
    public partial class ImportPredpis : Form
    {
        RRcode RRcode = new RRcode();
        RRdata RRdata = new RRdata();
        RRfun RRfun = new RRfun();
        RRsql RRsql = new RRsql();
        RRstring RRstring = new RRstring();

        string sParIdData = "";
        string sLabcIdData = "";
        bool bWriteData = false;

        public ImportPredpis()
        {
            InitializeComponent();
        }

        private void ImportPredpis_Load(object sender, EventArgs e)
        {
            dg.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12);
            dg.EnableHeadersVisualStyles = false;
            dg.ColumnHeadersDefaultCellStyle.BackColor = Color.Gainsboro;
            dg.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            dg.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 12);
            dg.DefaultCellStyle.BackColor = Color.White;
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dg.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            this.Text = RRvar.sHeader;
            lStatus.Text = RRvar.sFooter;
            dg.MultiSelect = false;
            dg.Visible = true;
            //this.Size = new Size(Screen.PrimaryScreen.Bounds.Width - 40, Screen.PrimaryScreen.Bounds.Height - 60);
            //this.Location = new Point(20, 10);
            this.WindowState = FormWindowState.Maximized;
            RRcode.Front();
            RRcode.FadeIn(this);
            bExcel.Visible = true;
            bSelect.Visible = true;
            pictureBox1.Visible = true;

        }

        private void ImportPredpis_Shown(object sender, EventArgs e)
        {
            FileStream fs = null;
            HSSFWorkbook wb = null;
            ISheet sheet = null;
            int rowCount = 0;
            int colCount = 0;
            pictureBox1.Visible = false;
            bExcel.Enabled = false;
            bSelect.Enabled = false;
            dg.Enabled = false;
            lStatus.Text = "Importujem dáta";
            Application.DoEvents();
            try
            {
                fs = new FileStream(RRvar.sTemp9, FileMode.Open, FileAccess.Read);
                wb = new HSSFWorkbook(fs);
                if (fs != null)
                {
                    fs.Close();
                    fs.Dispose();
                    fs = null;
                }
                sheet = wb.GetSheet("sampleX");
                rowCount = sheet.LastRowNum + 1;
                colCount = sheet.GetRow(0).LastCellNum;
                dg.Rows.Clear();
                dg.Columns.Clear();
                for (int j = 0; j < colCount; j++)  //Column loop
                {
                    ICell cell = sheet.GetRow(0).GetCell(j);//Get column
                    dg.Columns.Add(j.ToString() + cell.ToString(), cell.ToString());
                }
                for (int i = 1; i < rowCount; i++)      //Line loop
                {
                    IRow row = sheet.GetRow(i);  //Get i row
                    int index = dg.Rows.Add();
                    dg.Rows[i - 1].Cells[0].Style.BackColor = Color.Gainsboro;
                    colCount = row.LastCellNum;
                    for (int j = 0; j < colCount; j++)  //Column loop
                    {
                        try
                        {
                            ICell cell = row.GetCell(j);//Get column j
                            dg.Rows[index].Cells[j].Value = cell.ToString();
                            dg.FirstDisplayedScrollingRowIndex = dg.RowCount - 1;
                            dg.ClearSelection();
                            if (j == 0)
                            {
                                dg.Rows[index].Cells[j].Selected = true;
                            }
                        }
                        catch { }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nemôžem získať prístup ku zvolenému súboru! Zrejme je uzamknutý, nemáte prístupové právo alebo už je otvorený niekde inde.\r\n\r\nZopakujte prosím pokus o jeho otvorenie neskôr.", "Varovanie", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.Close();
                return;
            }

            Application.DoEvents();

            int iBezNazvu = 1;
            for (int i = 0; i < dg.Columns.Count; i++)
            {
                string ss = dg.Columns[i].HeaderText;
                if (ss.Length == 0)
                {
                    dg.Columns[i].HeaderText = "_prázdny_" + iBezNazvu.ToString();
                    iBezNazvu++;
                }
            }

            try { dg.FirstDisplayedScrollingRowIndex = 0; }
            catch { }
            try { dg.Rows[0].Cells[0].Selected = true; }
            catch { }

            //do MATRIX4u vsetky labc z DB 
            //RRdata.MatrixFill(4, "SELECT id, labc, rok from labc ORDER BY id DESC", true);
            //do MATRIX2u vsetky parametre

            // MATRIX2 musi byt vyplneny z predchadzajuceho formu FIlter1
            //RRdata.MatrixFill(2, "SELECT id, value from xparameter;", true);
            
            Application.DoEvents();
            pictureBox1.Visible = true;
            bExcel.Enabled = true;
            bSelect.Enabled = true;
            dg.Enabled = true;
            Analyze();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            RRfun.ShowMyInfoToolTip(pictureBox1.Location.X + 50, pictureBox1.Location.Y + 50, this);
            pLegenda.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pLegenda.Visible = false;
        }

        private void myResize()
        {
            bExcel.Location = new Point(5, 10);
            bSelect.Location = new Point(55, 10);
            //bPass.Location = new Point(5 + bExcel.Height + 3, dr.Height + bn.Height + 10);
            pictureBox1.Location = new Point(5, this.Size.Height - 115);
            pLegenda.Location = new Point(this.Size.Width / 2 - 200, this.Size.Height / 2 - 57);
            bSelect.Location = new Point(this.Size.Width - 70, this.Size.Height - 115);
            bExcel.Location = new Point(this.Size.Width - 120, this.Size.Height - 115);
            dg.Location = new Point(10, 10);
            dg.Size = new Size(this.Size.Width - 35, this.Size.Height - 130);
            //dg.Size = new Size(35, 25);

            Application.DoEvents();
        }

        private void dg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F12)
            {
            }
        }

        private void ChildFormClosedFull(object sender, EventArgs e)
        {
            this.Enabled = true;
            RRcode.Front();
        }

        private void mb(string s)
        {
            MessageBox.Show(s);
        }

        private void ImportPredpis_Resize(object sender, EventArgs e)
        {
            myResize();
        }

        private void ImportPredpis_FormClosing(object sender, FormClosingEventArgs e)
        {
            RRcode.FadeOut(this);
        }

        private void bSelect_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Mám zapísať hodnoty?", "Kontrola", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                ClearCells();
                bWriteData = true;
                Analyze();
                bWriteData = false;
                bSelect.Enabled = false;
                bExcel.Enabled = false;
                dg.ReadOnly = true;
                dg.Enabled = true;
            }
        }

        private void ClearCells()
        {
            pictureBox1.Visible = false;
            int iR = dg.Rows.Count;
            int iC = dg.Columns.Count - 1;
            for (int i = 0; i < iR; i++)
            {
                for (int j = 1; j <= iC; j++)
                {
                    dg.Rows[i].Cells[j].Style.BackColor = Color.White;
                    dg.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                    DataGridViewCell c = this.dg.Rows[i].Cells[j];
                    c.ToolTipText = "";
                }
            }
            Application.DoEvents();
            pictureBox1.Visible = true;
        }

        private void bExcel_Click(object sender, EventArgs e)
        {
            dg.Enabled = false;
            ClearCells();
            Analyze();
            dg.Enabled = true;
        }

        public void Analyze()
        {
            dg.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            lStatus.Text = "Kontrolujem čísla vzoriek";
            Application.DoEvents();
            dg.Enabled = false;
            pictureBox1.Visible = false;
            int iR = dg.Rows.Count;
            int iC = dg.Columns.Count - 1;
            string[] sPar = new string[iC];
            string[] sLabc = new string[iR];
            string[] sRok = new string[iR];
            string[] sLokalita = new string[iR];
            string[] sLabcId = new string[iR];
            string sParId = "";
            string s = "";
            string s1 = "";
            string s2 = "";
            string s3 = "";
            string s4 = "";
            string s5 = "";
            string s6 = "";
            string sAll = "";
            bool bAkr = false;

            sLabcIdData = "";
            sParIdData = "";

            //Parametre
            //for (int i = 5; i <= iC; i++)
            //{
            //    sPar[i - 5] = dg.Columns[i].HeaderText;
            //}
            
            //labc
            for (int i = 0; i < iR; i++)
            {
                try {
                    sLabc[i] = dg.Rows[i].Cells[1].Value.ToString();
                } catch {
                    sLabc[i] = "";
                    dg.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
                int iTest;
                try {
                    iTest = Convert.ToInt32(sLabc[i]);
                } catch {
                    sLabc[i] = "";
                    dg.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
            
            //rok
            for (int i = 0; i < iR; i++)
            {
                try
                {
                    sRok[i] = dg.Rows[i].Cells[2].Value.ToString();
                }
                catch
                {
                    sRok[i] = "";
                    dg.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
                int iTest;
                try
                {
                    iTest = Convert.ToInt32(sRok[i]);
                }
                catch
                {
                    sRok[i] = "";
                    dg.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
                if (sRok[i].Length != 4)
                {
                    sRok[i] = "";
                    dg.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }

            }

            //lokalita
            //for (int i = 0; i < iR; i++)
            //{
            //    try
            //    {
            //        sLokalita[i] = dg.Rows[i].Cells[0].Value.ToString();
            //    }
            //    catch
            //    {
            //        sLokalita[i] = "";
            //    }
            //}

            lStatus.Text = "Mažem prázdne záznamy";
            Application.DoEvents();
            for (int i = iR - 1 ; i >= 0; i--)
            {
                if (sLabc[i].Length == 0 || sRok[i].Length == 0)
                {
                    dg.Rows.RemoveAt(i);
                }
            }

            //
            // kontrola na vygenerovane LC
            //
            lStatus.Text = "Kontrolujem na vygenerované laboratórne čísla";
            Application.DoEvents();
            iR = dg.Rows.Count;
            iC = dg.Columns.Count - 1;
            sLabc = new string[iR];
            sRok = new string[iR];

            for (int i = iR - 1; i >= 0; i--)
            {
                s = "select count(id) as total from labc where " +
                    "labc = '" + dg.Rows[i].Cells[1].Value.ToString() + "' " +
                    "and rok = '" + dg.Rows[i].Cells[2].Value.ToString() + "';";
                    
                if (Convert.ToInt16(RRsql.RunSqlReturn(s)) == 0)
                {
                    dg.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                    dg[1, i].Value = "xxxxxxxxxx";

                }
            }

            Application.DoEvents();

            for (int i = iR - 1; i >= 0; i--)
            {
                if (dg[1, i].Value.ToString() == "xxxxxxxxxx")
                {
                    dg.Rows.RemoveAt(i);
                }
            }

            //
            // kontrola na duplicity
            //
            lStatus.Text = "Kontrolujem na duplicity";
            Application.DoEvents();

            iR = dg.Rows.Count;
            sLabc = new string[iR];
            sRok = new string[iR];
            int iTotalCount = 0;

            for (int i = 0; i < iR; i++)
            {
                s1 = dg.Rows[i].Cells[1].Value.ToString();
                s2 = dg.Rows[i].Cells[2].Value.ToString();

                for (int j = 0; j < iR; j++)
                {
                    if (i != j) // aby nekontroloval sam seba
                    {
                        if (s1 == dg.Rows[j].Cells[1].Value.ToString() && s2 == dg.Rows[j].Cells[2].Value.ToString())
                        {
                            // ak sa zhoduje lc aj rok
                            iTotalCount++;
                            dg[1, j].Value = "xxxxxxxxxx";

                            dg.Rows[j].DefaultCellStyle.BackColor = Color.LightBlue;
                        }
                    }
                    if (iTotalCount > 0)
                    {
                        dg.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
                        dg[1, i].Value = "xxxxxxxxxx";
                        iTotalCount = 0;
                    }
                }
            }

            Application.DoEvents();

            for (int i = iR - 1; i >= 0; i--)
            {
                if (dg[1, i].Value.ToString() == "xxxxxxxxxx")
                {
                    dg.Rows.RemoveAt(i);
                }
            }


            //
            // kontrola na uz definovane predpisy
            //
            lStatus.Text = "Kontrolujem na už vygenerované predpisy merania";
            Application.DoEvents();
            iR = dg.Rows.Count;
            sLabc = new string[iR];
            sRok = new string[iR];

            for (int i = iR - 1; i >= 0; i--)
            {
                s1 = "select id from labc where " +
                    "labc = '" + dg.Rows[i].Cells[1].Value.ToString() + "' " +
                    "and rok = '" + dg.Rows[i].Cells[2].Value.ToString() + "';";

                s = RRsql.RunSqlReturn(s1);

                s1 = "select count(id) as total from data where " +
                    "labc = '" + s + "';";

                if (Convert.ToInt16(RRsql.RunSqlReturn(s1)) > 0)
                {
                    dg.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                    dg[1, i].Value = "xxxxxxxxxx";

                }
            }

            Application.DoEvents();

            for (int i = iR - 1; i >= 0; i--)
            {
                if (dg[1, i].Value.ToString() == "xxxxxxxxxx")
                {
                    dg.Rows.RemoveAt(i);
                }
            }


            lStatus.Text = "Kontrolujem parametre merania";
            Application.DoEvents();
            // vyfarbenie parametrov pre import

            iR = dg.Rows.Count;
            iC = dg.Columns.Count - 1;


            for (int i = 0; i <iR; i++)
            {
                dg.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                for (int j = 3; j <= iC; j++)
                {
                    try
                    {
                        if (dg.Rows[i].Cells[j].Value.ToString().Length > 0)
                        {
                            dg.Rows[i].Cells[j].Value = "ok";
                        }
                    }
                    catch { }

                    try {
                        if (dg.Rows[i].Cells[j].Value.ToString().Length == 0)
                        {
                            dg.Rows[i].Cells[j].Style.BackColor = Color.Orange;
                            dg.Rows[i].Cells[j].Value = "---";
                        }
                    }
                    catch {
                        dg.Rows[i].Cells[j].Style.BackColor = Color.Orange;
                        dg.Rows[i].Cells[j].Value = "---";
                    }
                    
                }
            }

            bool bFound = false;

            for (int i = 5; i <= iC; i++)
            {
                s1 = dg.Columns[i].HeaderText;

                for (int j = 0; j < RRvar.Matrix2.Count; j++)
                {
                    if (!bFound)
                    {
                        s2 = RRdata.MatrixRead(2, j, 0);
                        if (s1 == s2)
                        {
                            bFound=true;
                        }
                    }
                }

                if (!bFound)
                {
                    for (int k = 0; k < iR; k++)
                    {
                        dg.Rows[k].Cells[i].Value = "---";
                        dg.Rows[k].Cells[i].Style.BackColor = Color.Red;
                        dg.Rows[k].Cells[i].Style.ForeColor = Color.White;
                    }
                }

                bFound = false;
            }


            //for (int i = iR - 1; i >= 0; i--)
            //{
            //    s = "select count(id) as total from labc where " +
            //        "labc = '" + dg.Rows[i].Cells[1].Value.ToString() + "' " +
            //        "and rok = '" + dg.Rows[i].Cells[2].Value.ToString() + "';";

            //    if (Convert.ToInt16(RRsql.RunSqlReturn(s)) == 0)
            //    {
            //        dg.Rows.RemoveAt(i);
            //    }
            //}



            dg.Enabled = true;
            pictureBox1.Visible = true;
            return;









            
            //MATRIX1
            //0-id
            //1-polozka
            //2-parameter
            //3-matrica
            //4-princip
            //5-ozn
            //6-odd
            //7-jednotka 
            //pre kazde najdene labc
            sLabcIdData = "";
            for (int i = 0; i < iR; i++)
            {
                //do MATRIXu vsetky polozky pre hladane labc
                RRdata.MatrixFill(1, "SELECT id, polozka, parameter, matrica, princip, ozn, odd, jednotka from data WHERE labc='" + sLabcId[i] + "';", true);
                //string sss = "SELECT id, polozka, parameter, matrica, princip, ozn, odd, jednotka from data WHERE labc='" + sLabcId[i] + "';";
                //MessageBox.Show(sLabcId[i]);
                //tie labc ku ktorym mam Id
                if (sLabcId[i].Length > 0)
                {
                    sLabcIdData = sLabcId[i];
                    //pre kazdu bunku jedneho labc
                    for (int j = 1; j <= iC; j++)
                    {
                        //hladam Id parametra z hlavicky v xparameter (MATRIX2)
                        sParId = "";
                        sParIdData = "";
                        for (int k = 0; k < RRvar.Matrix2.Count; k++)
                        {
                            if (sPar[j - 1] == RRdata.MatrixRead(2, k, 1))
                            {
                                sParId = RRdata.MatrixRead(2, k, 0);
                                break;
                            }
                        }
                        //ak som nasiel tento parameter v xparameter (MATRIX2)
                        //MessageBox.Show("spar " + sParId);
                        if (sParId.Length > 0)
                        {
                            sParIdData = sParId;
                            s1 = "";
                            s2 = "";
                            s3 = "";
                            s4 = "";
                            s5 = "";
                            s6 = "";
                            for (int l = 0; l < RRvar.Matrix1.Count; l++)
                            {
                                //MessageBox.Show(sParId);
                                //MessageBox.Show(RRdata.MatrixRead(1, l, 2));

                                //MessageBox.Show(RRdata.MatrixRead(1, l, 2) + " / " + sParId);
                                if (RRdata.MatrixRead(1, l, 2) == sParId)
                                {
                                    s1 = RRdata.MatrixRead(1, l, 2);//parameter (zistit id z nazvu)
                                    s2 = RRdata.MatrixRead(1, l, 4);//princip
                                    s3 = RRdata.MatrixRead(1, l, 5);//ozn
                                    s4 = RRdata.MatrixRead(1, l, 6);//odd
                                    s5 = RRdata.MatrixRead(1, l, 7);//jednotka
                                    s6 = RRdata.MatrixRead(1, l, 3);//matrica            
                                    break;
                                }
                            }

                            bAkr = true;
                            //Id jedalneho listka kde je zhoda na vsetky parametre merania
                            s = "SELECT id from c_all WHERE " +
                                " parameter = '" + s1 + "' AND princip = '" + s2 + "' AND " +
                                " ozn = '" + s3 + "' AND odd = '" + s4 + "' AND jednotka = '" + s5 + "';";

                            //MessageBox.Show(s);
                            try { sAll = RRsql.RunSqlReturn(s).ToString(); }
                            catch { sAll = ""; }
                            //ak sedi, skontrolujem mozne matrice

                            if (sAll.Length > 0)
                            {
                                s = "SELECT id from c_matrica WHERE " +
                                " c_all = '" + sAll + "' AND matrica = '" + s6 + "';";
                                string s0;
                                try { s0 = RRsql.RunSqlReturn(s).ToString(); }
                                catch { s0 = ""; }
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
                                s = "SELECT min, max, des, value from c_neistota WHERE " +
                                    " c_all = '" + sAll + "' ORDER BY min;";
                                //MATRIX3 - neistoty pre id c_all - overene kombinacie
                                RRdata.MatrixFill(3, s, true);
                                //kontrola jednotlivych vysledkov - buniek

                                string sTemp = "";

                                try
                                {
                                    sTemp = dg.Rows[i].Cells[j].Value.ToString();
                                }
                                catch { }

                                if (sTemp.Length > 0)
                                {
                                    if (!ResultCheck(sTemp, i, j))
                                    {
                                        dg.Rows[i].Cells[j].Style.BackColor = Color.Red;
                                        dg.Rows[i].Cells[j].Style.ForeColor = Color.White;
                                        DataGridViewCell c = this.dg.Rows[i].Cells[j];
                                        c.ToolTipText = "Nesprávna hodnota";
                                    }
                                }
                                else
                                {
                                    dg.Rows[i].Cells[j].Style.BackColor = Color.Red;
                                    dg.Rows[i].Cells[j].Style.ForeColor = Color.White;
                                    DataGridViewCell c = this.dg.Rows[i].Cells[j];
                                    c.ToolTipText = "Prázdna hodnota";
                                }
                            }
                            else
                            {
                                string sTest = "";
                                try
                                {
                                    sTest = dg.Rows[i].Cells[j].Value.ToString();
                                    dg.Rows[i].Cells[j].Style.BackColor = Color.LightPink;
                                    RRdata.MatrixClear(3);
                                    DataGridViewCell c = this.dg.Rows[i].Cells[j];
                                    c.ToolTipText = "Nenachádza sa v rozsahu akreditácie alebo v požiadavke na meranie";
                                    if (bWriteData)
                                    {
                                        string sx;
                                        double dx;
                                        sx = dg.Rows[i].Cells[j].Value.ToString().Replace(".", ",");

                                        if (Double.TryParse(sx, out dx))
                                        {
                                            try
                                            {
                                                if (bCheckParInLabc())
                                                {
                                                    sx = sx.Replace(",", ".");
                                                    WriteData(sx, "", "", false, "", "", i, j);
                                                    dg.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                                                    dg.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                                                }
                                                else
                                                {
                                                    dg.Rows[i].Cells[j].Style.BackColor = Color.Red;
                                                    dg.Rows[i].Cells[j].Style.ForeColor = Color.White;
                                                    c.ToolTipText = "Nenájdená požiadavka na meranie tohoto parametra";
                                                }
                                            }
                                            catch
                                            {
                                                dg.Rows[i].Cells[j].Style.BackColor = Color.Red;
                                                dg.Rows[i].Cells[j].Style.ForeColor = Color.White;
                                                c.ToolTipText = "Nenaimportované!";
                                            }
                                        }
                                        else
                                        {
                                            dg.Rows[i].Cells[j].Style.BackColor = Color.Red;
                                            dg.Rows[i].Cells[j].Style.ForeColor = Color.White;
                                            c.ToolTipText = "Nenaimportované!";
                                        }
                                    }
                                    //neakr////////////////////////////////////////////////////////////////////////////////////////////////////////////                                
                                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////
                                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////
                                }
                                catch
                                {
                                    dg.Rows[i].Cells[j].Style.BackColor = Color.Red;
                                    DataGridViewCell c = this.dg.Rows[i].Cells[j];
                                    c.ToolTipText = "Nesprávna hodnota";
                                }
                            }
                        }
                        else//ak som nenasiel tento parameter v xparameter (MATRIX2)
                        {
                            dg.Rows[i].Cells[j].Style.BackColor = Color.Red;
                            dg.Rows[i].Cells[j].Style.ForeColor = Color.White;
                            DataGridViewCell c = this.dg.Rows[i].Cells[j];
                            c.ToolTipText = "Parameter nie je v číselníku";
                        }
                    }
                }
            }
            dg.Enabled = true;
            pictureBox1.Visible = true;
        }

        public bool ResultCheck(string sResult, int iRow, int iColumn)
        {
            bool bOut = false;
            bool bFound = false;
            double dValue = 0;
            double dMin = 0;
            double dMax = 0;
            double dNeistota = 0;
            double dMedza = 0;
            int iDes = 0;
            double dMaxxx = 0;
            double d;
            DataGridViewCell c = this.dg.Rows[iRow].Cells[iColumn];

            if (sResult.Trim().Substring(0, 1) == "<")
            {
                sResult = "0";
            }

            if (Double.TryParse(sResult.Replace('.', ','), out d))
            {
                //try
                //{
                //double d = Convert.ToDouble(sResult.Replace('.', ','));
                dMedza = Convert.ToDouble(RRdata.MatrixRead(3, 0, 0));
                double dTemp;
                for (int j = 0; j < RRvar.Matrix3.Count; j++)
                {
                    dTemp = Convert.ToDouble(RRdata.MatrixRead(3, j, 1));
                    if (dTemp > dMaxxx)
                    {
                        dMaxxx = dTemp;
                    }
                }

                //tMedza.Text = RRdata.MatrixRead(3, 0, 0);
                bFound = false;
                bool bColorUpdated = false;
                for (int i = 0; i < RRvar.Matrix3.Count; i++)
                {
                    if (!bFound)
                    {
                        dMin = Convert.ToDouble(RRdata.MatrixRead(3, i, 0));
                        dMax = Convert.ToDouble(RRdata.MatrixRead(3, i, 1));
                        dValue = Convert.ToDouble(RRdata.MatrixRead(3, i, 3));
                        iDes = Convert.ToInt16(RRdata.MatrixRead(3, i, 2));
                        dMedza = Convert.ToDouble(RRdata.MatrixRead(3, 0, 0));

                        if (d >= dMin && d <= dMax)
                        {
                            bFound = true;
                            dNeistota = dValue;
                            dg.Rows[iRow].Cells[iColumn].Style.BackColor = Color.DarkCyan;
                            dg.Rows[iRow].Cells[iColumn].Style.ForeColor = Color.White;
                            c.ToolTipText = "Neistota: " + dNeistota.ToString() + " | Medza: " + dMedza.ToString() + " | (" + dMin.ToString() + " - " + dMax.ToString() + ")";
                            bColorUpdated = true;
                            if (bWriteData)
                            {
                                string s1;
                                double d1;
                                s1 = dg.Rows[iRow].Cells[iColumn].Value.ToString().Replace(".", ",");

                                if (Double.TryParse(s1, out d1))
                                {
                                    try
                                    {
                                        if (bCheckParInLabc())
                                        {
                                            s1 = s1.Replace(",", ".");
                                            WriteData(s1, dNeistota.ToString(), dMedza.ToString(), true, iDes.ToString(), "", iRow, iColumn);
                                            dg.Rows[iRow].Cells[iColumn].Style.BackColor = Color.Yellow;
                                            dg.Rows[iRow].Cells[iColumn].Style.ForeColor = Color.Black;
                                        }
                                        else
                                        {
                                            dg.Rows[iRow].Cells[iColumn].Style.BackColor = Color.Red;
                                            dg.Rows[iRow].Cells[iColumn].Style.ForeColor = Color.White;
                                            c.ToolTipText = "Nenájdená požiadavka na meranie tohoto parametra";
                                        }
                                    }
                                    catch
                                    {
                                        dg.Rows[iRow].Cells[iColumn].Style.BackColor = Color.Red;
                                        dg.Rows[iRow].Cells[iColumn].Style.ForeColor = Color.White;
                                        c.ToolTipText = "Nenaimportované!";
                                    }
                                }
                                else
                                {
                                    dg.Rows[iRow].Cells[iColumn].Style.BackColor = Color.Red;
                                    dg.Rows[iRow].Cells[iColumn].Style.ForeColor = Color.White;
                                    c.ToolTipText = "Nenaimportované!";
                                }
                            }
                            //akr////////////////////////////////////////////////////////////////////////////////////////////////////////////                                
                            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        }

                        if (d < dMedza)
                        {
                            bFound = true;
                            dg.Rows[iRow].Cells[iColumn].Style.BackColor = Color.Aquamarine;
                            //tPozn.Text = "< " + dMedza;
                            c.ToolTipText = "Stopa (< " + dMedza.ToString() + ")";
                            bColorUpdated = true;
                            if (bWriteData)
                            {
                                string s1;
                                double d1;
                                s1 = dg.Rows[iRow].Cells[iColumn].Value.ToString().Replace(".", ",");

                                if (Double.TryParse(s1, out d1))
                                {
                                    try
                                    {
                                        s1 = s1.Replace(",", ".");
                                        WriteData(s1, "", dMedza.ToString(), true, "", "< " + dMedza.ToString(), iRow, iColumn);
                                        dg.Rows[iRow].Cells[iColumn].Style.BackColor = Color.Yellow;
                                        dg.Rows[iRow].Cells[iColumn].Style.ForeColor = Color.Black;
                                    }
                                    catch
                                    {
                                        dg.Rows[iRow].Cells[iColumn].Style.BackColor = Color.Red;
                                        dg.Rows[iRow].Cells[iColumn].Style.ForeColor = Color.White;
                                        c.ToolTipText = "Nenaimportované!";
                                    }
                                }
                                else
                                {
                                    try
                                    {
                                        if (bCheckParInLabc())
                                        {
                                            s1 = s1.Replace(",", ".");
                                            WriteData("", "", dMedza.ToString(), true, "", "< " + dMedza.ToString(), iRow, iColumn);
                                            dg.Rows[iRow].Cells[iColumn].Style.BackColor = Color.Yellow;
                                            dg.Rows[iRow].Cells[iColumn].Style.ForeColor = Color.Black;
                                        }
                                        else
                                        {
                                            dg.Rows[iRow].Cells[iColumn].Style.BackColor = Color.Red;
                                            dg.Rows[iRow].Cells[iColumn].Style.ForeColor = Color.White;
                                            c.ToolTipText = "Nenájdená požiadavka na meranie tohoto parametra";
                                        }
                                    }
                                    catch
                                    {
                                        dg.Rows[iRow].Cells[iColumn].Style.BackColor = Color.Red;
                                        dg.Rows[iRow].Cells[iColumn].Style.ForeColor = Color.White;
                                        c.ToolTipText = "Nenaimportované!";
                                    }
                                }
                            }
                            //akr ale stopa////////////////////////////////////////////////////////////////////////////////////////////////////////////                                
                            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        }
                    }
                }
                if (!bColorUpdated)
                {
                    dg.Rows[iRow].Cells[iColumn].Style.BackColor = Color.LavenderBlush;
                    c.ToolTipText = "Mimo rozsah merania (>" + dMaxxx.ToString() + ")";
                    if (bWriteData)
                    {
                        string s1;
                        double d1;
                        s1 = dg.Rows[iRow].Cells[iColumn].Value.ToString().Replace(".", ",");

                        if (Double.TryParse(s1, out d1))
                        {
                            try
                            {
                                if (bCheckParInLabc())
                                {
                                    s1 = s1.Replace(",", ".");
                                    WriteData(s1, "", "", false, "", "", iRow, iColumn);
                                    dg.Rows[iRow].Cells[iColumn].Style.BackColor = Color.Yellow;
                                    dg.Rows[iRow].Cells[iColumn].Style.ForeColor = Color.Black;
                                }
                                else
                                {
                                    dg.Rows[iRow].Cells[iColumn].Style.BackColor = Color.Red;
                                    dg.Rows[iRow].Cells[iColumn].Style.ForeColor = Color.White;
                                    c.ToolTipText = "Nenájdená požiadavka na meranie tohoto parametra";
                                }
                            }
                            catch
                            {
                                dg.Rows[iRow].Cells[iColumn].Style.BackColor = Color.Red;
                                dg.Rows[iRow].Cells[iColumn].Style.ForeColor = Color.White;
                                c.ToolTipText = "Nenaimportované!";
                            }
                        }
                        else
                        {
                            dg.Rows[iRow].Cells[iColumn].Style.BackColor = Color.Red;
                            dg.Rows[iRow].Cells[iColumn].Style.ForeColor = Color.White;
                            c.ToolTipText = "Nenaimportované!";
                        }
                    }
                    //Bolo by akr ale je out of range////////////////////////////////////////////////////////////////////////////////////////////////////////////                                
                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////
                }
                //}
                //catch {}
                bOut = true;
            }
            else
            {
                bOut = false;
            }
            return bOut;
        }

        private void WriteData(string sResult, string sNeistota, string sMedza, bool bAkr, string sDes, string sPozn, int iRow, int iColumn)
        {
            string s = "UPDATE data set ";
            if (sResult.Length > 0)
            {
                s += " result = '" + sResult.Replace(',', '.') + "' ";
            }
            else
            {
                s += " result = NULL ";
            }

            if (bAkr)
            {
                s += ", akr = 'true' ";
                if (sMedza.Length > 0)
                {
                    s += ", medza = '" + sMedza.Replace(',', '.') + "' ";
                }
                if (sNeistota.Length > 0)
                {
                    s += ", neistota = '" + sNeistota.Replace(',', '.') + "' ";
                }
                if (sDes.Length > 0)
                {
                    s += ", des = '" + sDes + "' ";
                }
            }
            else
            {
                s += ", akr = 'false' ";
            }
            s += ", pozn = '" + sPozn + "' ";
            s += ", result_id = '" + RRvar.idUser.ToString() + "' ";
            s += " WHERE labc = '" + sLabcIdData + "' AND parameter = '" + sParIdData + "';";

            try
            {
                RRsql.RunSql(s);
            }
            catch
            {
                MessageBox.Show("Chyba pri zápise!");
            }
        }

        private bool bCheckParInLabc()
        {
            bool bOut = false;
            string sCount;
            int i;
            string s = "SELECT COUNT(*) FROM data WHERE ";
            s += " labc = '" + sLabcIdData + "' AND parameter = '" + sParIdData + "';";

            try
            {
                sCount = RRsql.RunSqlReturn(s);
                try
                {
                    i = Convert.ToInt16(sCount);
                    if (i > 0)
                    {
                        bOut = true;
                    }
                }
                catch { }
            }
            catch
            {
                MessageBox.Show("Chyba SQL!!!");
            }
            return bOut;
        }



    }
}
