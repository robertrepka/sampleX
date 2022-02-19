using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace sampleX
{
    public partial class Filter1 : Form
    {
        private readonly RRcode RRcode = new RRcode();
        private readonly RRfun RRfun = new RRfun();
        private readonly RRdata RRdata = new RRdata();
        private readonly RRsql RRsql = new RRsql();

        BindingSource bs = new BindingSource();
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable dt;
        DataTable dt3;
        DataTable dt4;
        MySqlCommand myCommand;
        MySqlDataAdapter MyAdapter;
        MySqlDataAdapter MyAdapter3;
        MySqlDataAdapter MyAdapter4;
        MySqlConnection con = new MySqlConnection(RRvar.sConStr);
        MySqlConnection con3 = new MySqlConnection(RRvar.sConStr);
        MySqlConnection con4 = new MySqlConnection(RRvar.sConStr);

        bool bStarting = true;
        bool bUpdatingCombo = false;
        static string sTempLocalForm = RRvar.sTemp;
        //https://www.daveoncsharp.com/2009/11/binding-a-windows-forms-combobox-in-csharp/

        public Filter1()
        {
            InitializeComponent();
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
            //FillOneComboStart("select c_all.id, CONCAT(polozka, ' - ', xparameter.value) as value from c_all, xparameter where xparameter.id = c_all.parameter order by value", "cPolozka");
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




        private void FillAkr()
        {
            int i = 0;
            string s, t;
            string s0 = "", s1 = "", s2 = "", s3 = "", s4 = "", s5 = "", s6 = "";
            bUpdatingCombo = true;
            dg3.DataSource = null;
            try
            {
                i = dg2.SelectedCells[0].RowIndex;
            }
            catch { };
            try
            {
                DataGridViewRow selectedRow = dg2.Rows[i];
                t = selectedRow.Cells[0].Value.ToString();
                s0 = selectedRow.Cells[1].Value.ToString();
                s = " SELECT " +
                    "c_all.polozka as s0, c_all.princip as s1, c_all.ozn as s2, c_all.jednotka as s3, c_all.odd as s4, " +
                    "c_all.id as id, c_all.polozka, " +
                    " xparameter.value as parameter, " +
                    " xjednotka.value as jednotka, " +
                    " CONCAT(xozn.value, ' ', xozn.popis) as ozn, " +
                    " xprincip.value as princip, " +
                    " xodd.value as odd " +
                    " FROM c_all, xparameter, xprincip, xjednotka, xozn, xodd " +
                    " WHERE " +
                    " c_all.parameter = '" + t + "'" +
                    " AND c_all.princip = xprincip.id " +
                    " AND c_all.jednotka = xjednotka.id " +
                    " AND c_all.ozn = xozn.id " +
                    " AND c_all.odd = xodd.id " +
                    " AND c_all.parameter = xparameter.id;";

                Filldt3(s);
                dg3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dg3.DataSource = dt3;
                dg3.Columns[0].Visible = false;
                dg3.Columns[1].Visible = false;
                dg3.Columns[2].Visible = false;
                dg3.Columns[3].Visible = false;
                dg3.Columns[4].Visible = false;
                dg3.AlternatingRowsDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
                dg3.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);

                //try
                //{
                //    foreach (DataRow r in dt.Rows)
                //    {
                //        s1 = r["polozkaid"].ToString();
                //        s2 = r["matricaid"].ToString();
                //        s3 = r["principid"].ToString();
                //        s4 = r["oznid"].ToString();
                //        s5 = r["jednotkaid"].ToString();
                //        s6 = r["oddid"].ToString();
                //    }
                //}
                //catch { }

            }
            catch { }

            bUpdatingCombo = false;
        }

        private void FillMatricu()
        {
            int i = 0;
            string s, t;
            string s0 = "", s1 = "", s2 = "", s3 = "", s4 = "", s5 = "", s6 = "";
            bUpdatingCombo = true;
            dg4.DataSource = null;

            try
            {
                i = dg3.SelectedCells[0].RowIndex;
            }
            catch { };
            try
            {
                DataGridViewRow selectedRow = dg3.Rows[i];
                t = selectedRow.Cells[5].Value.ToString();
                s = " SELECT " +
                    "c_matrica.matrica as matricaid, " +
                    " xmatrica.value as matrica " +
                    " FROM c_matrica, xmatrica " +
                    " WHERE " +
                    " c_matrica.c_all = '" + t + "'" +
                    " AND c_matrica.matrica = xmatrica.id ";

                Filldt4(s);
                dg4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dg4.DataSource = dt4;
                //                dg4.Columns[0].Visible = false;
                dg4.AlternatingRowsDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
                dg4.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);

                //try
                //{
                //    foreach (DataRow r in dt.Rows)
                //    {
                //        s2 = r["matricaid"].ToString();
                //    }
                //}
                //catch { }

            }
            catch { }

            bUpdatingCombo = false;
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
            try
            {
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
                    //ComboFind(s1, "cPolozka");
                    cPolozka.Text = s1;
                    ComboFind(s2, "cMatrica");
                    ComboFind(s3, "cPrincip");
                    ComboFind(s4, "cOzn");
                    ComboFind(s5, "cJednotka");
                    ComboFind(s6, "cOdd");
                }
                catch { }
            }
            catch { }

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

        private void Filter1_Load(object sender, EventArgs e)
        {
            RRvar.sFooter = "sampleX verzia: " + Application.ProductVersion + " - " + RRvar.sFullName;
            lStatus.Text = RRvar.sFooter;
            this.Text = RRvar.sHeader;
            RRcode.Front();

            Filldt("select id, value from xcat order by value");
            cMain.DisplayMember = "value";
            cMain.ValueMember = "id";
            cMain.DataSource = dt;

            try
            {
                cMain.SelectedIndex = 0;
            }
            catch { }

            FillCombosStart();
            DoIt();
            FillCombos();
            bStarting = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s, t;
            int i, j;
            try
            {
                i = dg1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dg1.Rows[i];
                t = selectedRow.Cells[0].Value.ToString();

                j = 0;
                string sSql =
                "select count(id) as total from f_cat_par where " +
                "catid = '" + cMain.SelectedValue + "' and parid = '" + t + "';";

                j = Convert.ToInt16(RRsql.RunSqlReturn(sSql));

                if (j == 0)
                {
                    s = "insert into f_cat_par (catid, parid, refe_id) values ('" + cMain.SelectedValue + "', '" + t + "', '" + RRvar.idUser + "')";
                    int FirstDisplayedScrollingRowIndex = dg1.FirstDisplayedScrollingRowIndex;
                    RRsql.RunSql(s);

                    DoIt();
                    try
                    {
                        dg1.CurrentCell = dg1.Rows[i].Cells[1];
                        dg1.FirstDisplayedScrollingRowIndex = FirstDisplayedScrollingRowIndex;
                    }
                    catch
                    {
                        try
                        {
                            dg1.CurrentCell = dg1.Rows[i - 1].Cells[1];
                            dg1.FirstDisplayedScrollingRowIndex = FirstDisplayedScrollingRowIndex;
                        }
                        catch { }
                    }

                    foreach (DataGridViewRow row in dg2.Rows)
                    {
                        if (row.Cells[0].Value.ToString().Equals(t))
                        {
                            dg2.CurrentCell = dg2.Rows[row.Index].Cells[1];
                            dg2.Rows[row.Index].Selected = true;
                            break;
                        }
                    }
                }
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s, t;
            int i;
            try
            {
                i = dg2.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dg2.Rows[i];
                t = selectedRow.Cells[0].Value.ToString();
                s = "delete from f_cat_par where parid='" + t + "' and catid= '" + cMain.SelectedValue + "'";
                int FirstDisplayedScrollingRowIndex = dg2.FirstDisplayedScrollingRowIndex;
                RRsql.RunSql(s);
                DoIt();
                try
                {
                    dg2.CurrentCell = dg2.Rows[i].Cells[1];
                    dg2.FirstDisplayedScrollingRowIndex = FirstDisplayedScrollingRowIndex;
                }
                catch
                {
                    try
                    {
                        dg2.CurrentCell = dg2.Rows[i - 1].Cells[1];
                        dg2.FirstDisplayedScrollingRowIndex = FirstDisplayedScrollingRowIndex;
                    }
                    catch { }
                }

                foreach (DataGridViewRow row in dg1.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(t))
                    {
                        dg1.CurrentCell = dg1.Rows[row.Index].Cells[1];
                        dg1.Rows[row.Index].Selected = true;
                        break;
                    }
                }
            }
            catch { }
        }

        private void DoIt()
        {
            string s;
            s = "select id, value from xparameter order by value";
            //s = "select id, value from xparameter where id not in (select parid from f_cat_par1 where catid='" + cMain.SelectedValue + "') order by value";
            //s = "select id, value from xparameter where id not in (select parid from f_cat_par1) order by value";
            Filldt(s);
            dg1.DataSource = dt;
            dg1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dg1.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10);
            dg1.Columns[0].Visible = false;
            dg1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            try
            {
                dg1.Rows[0].Selected = true;
            }
            catch { }

            s = "select parid, parvalue from f_cat_par1 where catid='" + cMain.SelectedValue + "' order by parvalue";

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
            s = "select parid, parvalue from f_cat_par1 where catid='" + cMain.SelectedValue + "' order by parvalue";

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
            DoIt2();
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

        private void Filldt3(string sSql)
        {
            myCommand = new MySqlCommand(sSql, con3);
            MyAdapter3 = new MySqlDataAdapter(myCommand);
            dt3 = new DataTable();
            con3.Open();
            MyAdapter3.Fill(dt3);
            con3.Close();
            MyAdapter3.Dispose();
        }

        private void Filldt4(string sSql)
        {
            myCommand = new MySqlCommand(sSql, con4);
            MyAdapter4 = new MySqlDataAdapter(myCommand);
            dt4 = new DataTable();
            con4.Open();
            MyAdapter4.Fill(dt4);
            con4.Close();
            MyAdapter4.Dispose();
        }



        private void ChildFormClosedFull(object sender, EventArgs e)
        {
            RRcode.FadeIn(this);
            this.Visible = true;
            RRcode.Front();
        }

        private void ChildFormClosedFullNoFade(object sender, EventArgs e)
        {
            this.Enabled = true;
            RRcode.Front();
        }

        private void Filter1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void Filter1_Shown(object sender, EventArgs e)
        {
            RRcode.FadeIn(this);
            RRcode.Front();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            RRfun.ShowMyInfoToolTip(pictureBox1.Location.X + 50, pictureBox1.Location.Y + 50, this);
        }

        private void dg2_SelectionChanged(object sender, EventArgs e)
        {
            if (!bStarting)
            {
                try
                {
                    FillCombos();
                }
                catch { }
                //try
                //{
                //    FillAkr();
                //} catch { }    
            }
            bAkr.Visible = true;
            dg3.Visible = false;
            dg4.Visible = false;
            ldg3.Visible = false;
            ldg4.Visible = false;
            bAll.Visible = false;
        }

        private void UpdateDbFromCombo(string sColName, string sComboName, bool bPolozka)
        {
            if (!bUpdatingCombo)
            {
                int i = 0;
                string s, t;
                string sSql;
                try { i = dg2.SelectedCells[0].RowIndex; } catch { }

                DataGridViewRow selectedRow = dg2.Rows[i];
                t = selectedRow.Cells[0].Value.ToString();

                if (bPolozka)
                {
                    s = cPolozka.Text;
                }
                else
                {
                    s = ComboId(sComboName);
                }

                if (s.Length == 0)
                {
                    sSql = "update f_cat_par set " + sColName + " = NULL, refe_id='" + RRvar.idUser + "' where parid='" + t + "' and catid= '" + cMain.SelectedValue + "'";
                }
                else
                {
                    sSql = "update f_cat_par set " + sColName + " = '" + s + "', refe_id='" + RRvar.idUser + "' where parid='" + t + "' and catid= '" + cMain.SelectedValue + "'";
                }

                try
                {
                    RRsql.RunSql(sSql);
                }
                catch { }
            }
        }

        private void cMatrica_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDbFromCombo("matricaid", "cMatrica", false);
        }

        private void cPrincip_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDbFromCombo("principid", "cPrincip", false);
        }

        private void cOzn_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDbFromCombo("oznid", "cOzn", false);
        }

        private void cJednotka_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDbFromCombo("jednotkaid", "cJednotka", false);
        }

        private void cOdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDbFromCombo("oddid", "cOdd", false);
        }

        private void cPolozka_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDbFromCombo("polozkaid", "cPolozka", true);
        }

        private void cPolozka_TextUpdate(object sender, EventArgs e)
        {
            UpdateDbFromCombo("polozkaid", "cPolozka", true);
        }

        private void cPolozka_TextChanged(object sender, EventArgs e)
        {
            //UpdateDbFromCombo("polozkaid", "cPolozka", true);
        }

        private void bClone_Click(object sender, EventArgs e)
        {
            string sNewName = "";
            string s = "";
            int iNewId;
            sTempLocalForm = cMain.Text + " - ";
            if (ShowInputTextDialog(ref sNewName) == DialogResult.OK)
            {
                s = " SELECT COUNT(*) FROM xcat WHERE value = '" + sNewName + "'";
                RRdata.MatrixFill(s, true);
                if (Convert.ToInt32(RRdata.MatrixRead(0, 0)) > 0)
                {
                    MessageBox.Show("Skupina parametov s takýmto názvom už existuje!", "Kontrola", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    s = " INSERT INTO xcat (value, refe_id) VALUES ('" + sNewName + "', '" + RRvar.idUser + "')";
                    RRdata.RunSql(s);
                    s = " SELECT id FROM xcat where value='" + sNewName + "';";
                    RRdata.MatrixFill(s, true);
                    iNewId = Convert.ToInt32(RRdata.MatrixRead(0, 0));
                    s = " SELECT catid, parid, polozkaid, matricaid, principid, oznid, jednotkaid, oddid" +
                        " FROM f_cat_par WHERE " +
                        " catid = '" + cMain.SelectedValue + "'";
                    RRdata.MatrixFill(2, s, true);

                    for (int i = 0; i < RRvar.Matrix2.Count; i++)
                    {
                        string s0, s1, s2, s3, s4, s5, s6, s7;
                        //s0 = RRdata.MatrixRead(2, i, 0);
                        s0 = iNewId.ToString();
                        s1 = RRdata.MatrixRead(2, i, 1);
                        if (s1.Length == 0)
                        {
                            s1 = "NULL";
                        }
                        else
                        {
                            s1 = "'" + s1 + "'";
                        }
                        s2 = RRdata.MatrixRead(2, i, 2);
                        if (s2.Length == 0)
                        {
                            s2 = "NULL";
                        }
                        else
                        {
                            s2 = "'" + s2 + "'";
                        }

                        s3 = RRdata.MatrixRead(2, i, 3);
                        if (s3.Length == 0)
                        {
                            s3 = "NULL";
                        }
                        else
                        {
                            s3 = "'" + s3 + "'";
                        }

                        s4 = RRdata.MatrixRead(2, i, 4);
                        if (s4.Length == 0)
                        {
                            s4 = "NULL";
                        }
                        else
                        {
                            s4 = "'" + s4 + "'";
                        }

                        s5 = RRdata.MatrixRead(2, i, 5);
                        if (s5.Length == 0)
                        {
                            s5 = "NULL";
                        }
                        else
                        {
                            s5 = "'" + s5 + "'";
                        }

                        s6 = RRdata.MatrixRead(2, i, 6);
                        if (s6.Length == 0)
                        {
                            s6 = "NULL";
                        }
                        else
                        {
                            s6 = "'" + s6 + "'";
                        }

                        s7 = RRdata.MatrixRead(2, i, 7);
                        if (s7.Length == 0)
                        {
                            s7 = "NULL";
                        }
                        else
                        {
                            s7 = "'" + s7 + "'";
                        }

                        s = " INSERT INTO " +
                            "f_cat_par (catid, parid, polozkaid, matricaid, " +
                            "  principid, oznid, jednotkaid, oddid,  refe_id) " +
                            " VALUES " +
                            "('" + s0 + "', " + s1 + ", " + s2 + ", " + s3 + ", " + s4 + ", " + s5 + ", " + s6 + ", " + s7 + ", '" + RRvar.idUser + "')";
                        RRdata.RunSql(s);
                    }

                    Filldt("select id, value from xcat order by value");
                    cMain.DataSource = dt;
                    cMain.Text = sNewName;
                }
            }
        }
        private static DialogResult ShowInputTextDialog(ref string input)
        {
            System.Drawing.Size size = new System.Drawing.Size(300, 70);
            Form inputBox = new Form();
            inputBox.TopMost = true;
            inputBox.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            inputBox.ControlBox = false;
            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            inputBox.MinimizeBox = false;
            inputBox.ShowIcon = false;
            inputBox.ShowInTaskbar = false;
            inputBox.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            inputBox.StartPosition = FormStartPosition.CenterParent;
            inputBox.ShowInTaskbar = false;
            inputBox.AutoSize = false;
            inputBox.ClientSize = size;
            inputBox.Text = "Názov skupiny";

            System.Windows.Forms.TextBox tIn = new TextBox();
            tIn.Size = new System.Drawing.Size(290, 25);
            tIn.Location = new System.Drawing.Point(5, 5);
            tIn.Font = new Font("Segoe UI", 10);
            tIn.Text = sTempLocalForm;
            inputBox.Controls.Add(tIn);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 30);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(220, 35);
            okButton.Font = new Font("Segoe UI", 10);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 30);
            cancelButton.Text = "&Zruš";
            cancelButton.Location = new System.Drawing.Point(5, 35);
            cancelButton.Font = new Font("Segoe UI", 10);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            string s = tIn.Text;
            input = s;
            return result;
        }

        private void CombosClone(string sSourceComboName, string sDbHeaderName, bool bValueIsInt)
        {
            int i = 0;
            string s;
            Control[] c;
            c = this.Controls.Find(sSourceComboName, true);
            try { i = dg2.SelectedCells[0].RowIndex; }
            catch { }
            DataGridViewRow selectedRow = dg2.Rows[i];
            s = selectedRow.Cells[1].Value.ToString();


            if (bValueIsInt)
            {
                if ((c[0] as ComboBox).Text.Length == 0)
                {
                    if (MessageBox.Show("Mám celej skupine nastaviť prázdnu hodnotu podľa " + s + "???", "Úprava dát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        s = cMain.SelectedValue.ToString();
                        s = "UPDATE f_cat_par set " + sDbHeaderName + " = NULL, refe_id='" + RRvar.iID + "' WHERE catid='" + s + "' ";
                        RRdata.RunSql(s);
                    }
                }
                else
                {
                    if (MessageBox.Show("Mám celej skupine nastaviť " + (c[0] as ComboBox).Text + " podľa " + s + "???", "Úprava dát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        s = cMain.SelectedValue.ToString();
                        string ss = (c[0] as ComboBox).SelectedValue.ToString();
                        s = "UPDATE f_cat_par set " + sDbHeaderName + " = '" + ss + "', refe_id='" + RRvar.iID + "' WHERE catid='" + s + "' ";
                        RRdata.RunSql(s);
                    }
                }
            }
            else
            {
                if (MessageBox.Show("Určite mám všade nastaviť " + (c[0] as ComboBox).Text + " podľa " + s + "???", "Úprava dát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    s = cMain.SelectedValue.ToString();
                    string ss = (c[0] as ComboBox).Text.ToString();
                    s = "UPDATE f_cat_par set " + sDbHeaderName + " = '" + ss + "', refe_id='" + RRvar.iID + "' WHERE catid='" + s + "' ";
                    RRdata.RunSql(s);
                }
            }
        }

        private void bPolozka_Click(object sender, EventArgs e)
        {
            CombosClone("cPolozka", "polozkaid", false);
        }

        private void bMatrica_Click(object sender, EventArgs e)
        {
            CombosClone("cMatrica", "matricaid", true);
        }

        private void bPrincip_Click(object sender, EventArgs e)
        {
            CombosClone("cPrincip", "principid", true);
        }

        private void bOzn_Click(object sender, EventArgs e)
        {
            CombosClone("cOzn", "oznid", true);
        }

        private void bJednotka_Click(object sender, EventArgs e)
        {
            CombosClone("cJednotka", "jednotkaid", true);
        }

        private void bOdd_Click(object sender, EventArgs e)
        {
            CombosClone("cOdd", "oddid", true);
        }

        private void dg2_Paint(object sender, PaintEventArgs e)
        {
            ldg2.Text = "Počet: " + dg2.Rows.Count.ToString();
        }

        private void dg1_Paint(object sender, PaintEventArgs e)
        {
            ldg1.Text = "Počet: " + dg1.Rows.Count.ToString();
        }

        private void dg1_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int i = 0; i < (dg1.Rows.Count); i++)
            {
                if (dg1.Rows[i].Cells["value"].Value.ToString().StartsWith(e.KeyChar.ToString(), true, CultureInfo.InvariantCulture))
                {
                    dg1.Rows[i].Cells["value"].Selected = true;
                    dg1.CurrentCell = dg1.Rows[i].Cells["value"];
                    return;
                }
            }
        }

        private void dg2_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int i = 0; i < (dg2.Rows.Count); i++)
            {
                if (dg2.Rows[i].Cells[1].Value.ToString().StartsWith(e.KeyChar.ToString(), true, CultureInfo.InvariantCulture))
                {
                    dg2.Rows[i].Cells[1].Selected = true;
                    dg2.CurrentCell = dg2.Rows[i].Cells[1];
                    return;
                }
            }
        }

        private void dg3_Paint(object sender, PaintEventArgs e)
        {
            ldg3.Text = "Počet možných akreditovaných kombinácií pre tento parameter: " + dg3.Rows.Count.ToString();
        }

        private void bAkr_Click(object sender, EventArgs e)
        {
            bAkr.Visible = false;
            dg3.Visible = true;
            ldg3.Visible = true;

            dg4.Visible = true;
            ldg4.Visible = true;


            try
            {
                FillAkr();
                Application.DoEvents();
                FillMatricu();
            }
            catch { }

            if (dg3.Rows.Count > 0)
            {
                bAll.Visible = true;
            }
            else
            {
                bAll.Visible = false;
            }
        }

        private void bAll_Click(object sender, EventArgs e)
        {
            if (dg3.Rows.Count > 0)
            {
                if (MessageBox.Show("Mám pre parameter " + dg3.SelectedRows[0].Cells["parameter"].Value.ToString() + " nastaviť vybrané hodnoty z rozsahu akreditácie???", "Úprava dát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    ComboFind(dg4.SelectedRows[0].Cells[0].Value.ToString(), "cMatrica");
                    ComboFind(dg3.SelectedRows[0].Cells[1].Value.ToString(), "cPrincip");
                    ComboFind(dg3.SelectedRows[0].Cells[2].Value.ToString(), "cOzn");
                    ComboFind(dg3.SelectedRows[0].Cells[3].Value.ToString(), "cJednotka");
                    ComboFind(dg3.SelectedRows[0].Cells[4].Value.ToString(), "cOdd");
                    cPolozka.Text = dg3.SelectedRows[0].Cells[0].Value.ToString();
                }
            }
        }

        private void dg3_SelectionChanged(object sender, EventArgs e)
        {
            FillMatricu();
        }

        private void dg4_Paint(object sender, PaintEventArgs e)
        {
            ldg4.Text = "Počet matríc: " + dg4.Rows.Count.ToString();
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            string sNewName = "";
            string s = "";
            sTempLocalForm = "...";
            if (ShowInputTextDialog(ref sNewName) == DialogResult.OK)
            {
                s = " SELECT COUNT(*) FROM xcat WHERE value = '" + sNewName + "'";
                RRdata.MatrixFill(s, true);

                if (sNewName.Length > 0)
                {
                    if (Convert.ToInt32(RRdata.MatrixRead(0, 0)) > 0)
                    {
                        MessageBox.Show("Skupina parametov s takýmto názvom už existuje!", "Kontrola", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        s = " INSERT INTO xcat (value, refe_id) VALUES ('" + sNewName + "', '" + RRvar.idUser + "')";
                        RRdata.RunSql(s);

                        Filldt("select id, value from xcat order by value");
                        cMain.DataSource = dt;
                        try
                        {
                            cMain.Text = sNewName;
                        }
                        catch { }
                    }
                }
                else
                {
                    MessageBox.Show("Skupina parametov musí mať nejaký názov!", "Kontrola", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Určite mám vymazať skupinu " + cMain.Text + "?", "Mazanie dát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                MySqlConnection con = new MySqlConnection(RRvar.sConStr);
                string s = "delete from xcat where id='" + cMain.SelectedValue + "'";

                try
                {
                    con.Open();
                    try
                    {
                        RRsql.RunSql(s);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                    con.Close();
                }
                catch { }

                Filldt("select id, value from xcat order by value");
                cMain.DataSource = dt;
            }
        }

        private void bRename_Click(object sender, EventArgs e)
        {
            string sNewName = "";
            string s = "";
            sTempLocalForm = cMain.Text;
            if (ShowInputTextDialog(ref sNewName) == DialogResult.OK)
            {
                s = " SELECT COUNT(*) FROM xcat WHERE value = '" + sNewName + "'";
                RRdata.MatrixFill(s, true);

                if (sNewName.Length > 0)
                {
                    if (Convert.ToInt32(RRdata.MatrixRead(0, 0)) > 0)
                    {
                        MessageBox.Show("Skupina parametov s takýmto názvom už existuje!", "Kontrola", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        s = "UPDATE xcat set value='" + sNewName + "' WHERE id='" + cMain.SelectedValue.ToString() + "'";
                        RRdata.RunSql(s);

                        Filldt("select id, value from xcat order by value");
                        cMain.DataSource = dt;
                        try
                        {
                            cMain.Text = sNewName;
                        }
                        catch { }
                    }
                }
                else
                {
                    MessageBox.Show("Skupina parametov musí mať nejaký názov!", "Kontrola", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }
    }
}


