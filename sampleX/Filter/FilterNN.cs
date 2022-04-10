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

namespace sampleX
{
    public partial class FilterNN : Form
    {
        private readonly RRcode RRcode = new RRcode();
        private readonly RRfun RRfun = new RRfun();
        private readonly RRdata RRdata = new RRdata();
        private readonly RRsql RRsql = new RRsql();

        BindingSource bs = new BindingSource();
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable dt;
        MySqlCommand myCommand;
        MySqlDataAdapter MyAdapter;
        MySqlConnection con = new MySqlConnection(RRvar.sConStr);

        bool bStart = true;
        string sTest;

        public FilterNN()
        {
            InitializeComponent();
        }

        private void FilterNN_Load(object sender, EventArgs e)
        {
            RRvar.sFooter = "sampleX verzia: " + Application.ProductVersion + " - " + RRvar.sFullName;
            lStatus.Text = RRvar.sFooter;
            this.Text = RRvar.sHeader;
            RRcode.Front();

            Filldt("select id, CONCAT(polozka, ' - ', parameter, ' - ', princip, ' - ', ozn, ' - ', odd) as value from c_all1 WHERE akr='False' order by polozka, parameter");
            cMain.DisplayMember = "value";
            cMain.ValueMember = "id";
            cMain.DataSource = dt;
            //cMain.SelectedIndex = 0;
            cMain.SelectedValue = Convert.ToInt32(RRvar.sTempN);
            DoIt1();
            bStart = false;
            dg2.Columns["max"].Visible = false;
            dg2.Columns[4].Visible = false;
        }

        private void DoIt1()
        {
            string s;
            s = "select id, min, max, des, value, pozn from c_neistota where c_all = '" + RRvar.sTempN + "' order by min";

            Filldt(s);
            dg2.DataSource = dt;
            dg2.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dg2.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10);
            dg2.ColumnHeadersVisible = true;
            dg2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dg2.Columns[1].HeaderText = "min";
            dg2.Columns[2].HeaderText = "max";
            dg2.Columns[3].HeaderText = "presnosť";
            dg2.Columns[4].HeaderText = "hodnota";
            dg2.Columns[5].HeaderText = "poznámka";
            dg2.MultiSelect = false;
            dg2.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dg2.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dg2.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dg2.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dg2.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            try
            {
                dg2.Rows[0].Selected = true;
            }
            catch { }


        }

        private void cMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!bStart)
            {
                RRvar.sTempN = cMain.SelectedValue.ToString();
                DoIt1();
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

        private void ChildFormClosedFull(object sender, EventArgs e)
        {
            RRcode.FadeIn(this);
            this.Visible = true;
            RRcode.Front();
        }

        private void FilterNN_Shown(object sender, EventArgs e)
        {
            RRcode.FadeIn(this);
            RRcode.Front();
        }

        private void pictureBox1_MouseHover_1(object sender, EventArgs e)
        {
            RRfun.ShowMyInfoToolTip(pictureBox1.Location.X + 50, pictureBox1.Location.Y + 50, this);
        }

        private void tMin_TextChanged(object sender, EventArgs e)
        {
            double d;
            tMin.Text = tMin.Text.Replace('.', ',');

            if (tMin.Text.Length == 0)
            {
                sTest = "";
            }

            try
            {
                d = Convert.ToDouble(tMin.Text);
                sTest = tMin.Text;
                tMin.Select(tMin.Text.Length, 0);
            }
            catch
            {
                tMin.Text = sTest;
            }
            tMax.Text = tMin.Text;
        }

        private void tMax_TextChanged(object sender, EventArgs e)
        {
            double d;
            tMax.Text = tMax.Text.Replace('.', ',');

            if (tMax.Text.Length == 0)
            {
                sTest = "";
            }

            try
            {
                d = Convert.ToDouble(tMax.Text);
                sTest = tMax.Text;
                tMax.Select(tMax.Text.Length, 0);
            }
            catch
            {
                tMax.Text = sTest;
            }

        }

        private void tMin_Enter(object sender, EventArgs e)
        {
            sTest = tMin.Text;
        }

        private void tMax_Enter(object sender, EventArgs e)
        {
            if (tMin.Text.Length == 0)
            {
                tMin.Focus();
            }
            sTest = tMax.Text;
        }

        private void NUD1_Enter(object sender, EventArgs e)
        {
            NUD1.Select();
            NUD1.Select(0, NUD1.Text.Length);
        }

        private void NUD2_Enter(object sender, EventArgs e)
        {
            NUD2.Select();
            NUD2.Select(0, NUD2.Text.Length);
        }

        private void tMax_Validating(object sender, CancelEventArgs e)
        {
            if (tMax.Text.Length == 0)
            {
                return;
            }

            double d1, d2;
            try
            {
                d1 = Convert.ToDouble(tMin.Text);
                d2 = Convert.ToDouble(tMax.Text);
                if (d1 >= d2)
                {
                    tMax.Focus();
                }
            }
            catch
            {
                tMax.Focus();
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            int iLast;
            double d;
            string sSql;
            int iNewId;

            try
            {
                d = Convert.ToDouble(tMin.Text);
            }
            catch
            {
                tMin.Focus();
                return;
            }
            try
            {
                d = Convert.ToDouble(tMax.Text);
            }
            catch
            {
                tMax.Focus();
                return;
            }

            if (dg2.Rows.Count > 0)
            {
                MessageBox.Show("Medza už je pridaná. Najprv ju osober!", "Informácia", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                tMin.Focus();
                return;
            }
            foreach (DataGridViewRow dr in dg2.Rows)
            {
                if (dr.Cells["min"].Value.ToString() == tMin.Text)
                {
                    MessageBox.Show("Zadaná minimálna hranica už existuje.", "Informácia", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    tMin.Focus();
                    return;
                }
            }

            foreach (DataGridViewRow dr in dg2.Rows)
            {
                if (dr.Cells["max"].Value.ToString() == tMax.Text)
                {
                    MessageBox.Show("Zadaná maximálna hranica už existuje.", "Informácia", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    tMax.Focus();
                    return;
                }
            }

            using (System.Transactions.TransactionScope scope = new System.Transactions.TransactionScope())
            {
                try
                {
                    sSql = "insert into c_neistota (c_all, min, max, des, value, pozn, refe_id) values (" +
                        "'" + RRvar.sTempN + "', " +
                        "'" + tMin.Text.ToString().Replace(',', '.') + "', " +
                        "'" + tMax.Text.ToString().Replace(',', '.') + "', " +
                        "'" + NUD1.Value.ToString() + "', " +
                        "'" + NUD2.Value.ToString().ToString() + "', " +
                        "'" + tPozn.Text.ToString() + "', " +
                        "'" + RRvar.idUser.ToString() + "')";
                    RRsql.RunSql(sSql);
                    iNewId = Convert.ToInt32(RRsql.RunSqlReturn("SELECT LAST_INSERT_ID();"));


                    dt.Clear();
                    Filldt("select id, min, max, des, value, pozn from c_neistota where c_all = '" + RRvar.sTempN + "' order by min");
                    dg2.DataSource = dt;
                    foreach (DataGridViewRow dr in dg2.Rows)
                    {
                        if (dr.Cells["id"].Value.ToString() == iNewId.ToString())
                        {
                            //dr.Cells[0];
                            dr.Cells[0].Selected = true;
                            break;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                scope.Complete();
            }
            dg2.Columns["max"].Visible = false;
            dg2.Columns["hodnota"].Visible = false;
        }

        private void bRemove_Click(object sender, EventArgs e)
        {
            try
            {
                string sID = dg2.CurrentRow.Cells[0].Value.ToString();
                int iIndex = dg2.SelectedRows[0].Index;
                if (MessageBox.Show("Určite chceš vymazať záznam č. " + sID + " ?", "Mazanie dát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    try
                    {
                        RRsql.RunSql("delete from c_neistota where id='" + dg2.CurrentRow.Cells[0].Value.ToString() + "';");
                        dt.Clear();
                        Filldt("select id, min, max, des, value, pozn from c_neistota where c_all = '" + RRvar.sTempN + "' order by min");
                        dg2.DataSource = dt;

                        int numRowCount = dg2.RowCount;
                        if (iIndex >= numRowCount)
                        {
                            try
                            {
                                dg2.Rows[iIndex - 1].Selected = false;
                                dg2.Rows[iIndex - 1].Cells[0].Selected = true;
                            }
                            catch { }
                        }
                        else
                        {
                            try
                            {
                                dg2.Rows[iIndex].Selected = false;
                                dg2.Rows[iIndex].Cells[0].Selected = true;
                            }
                            catch { }
                        }
                    }
                    catch { }
                }
            }
            catch { }
        }
    }
}



