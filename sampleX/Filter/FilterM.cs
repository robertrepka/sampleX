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
    public partial class FilterM : Form
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

        public FilterM()
        {
            InitializeComponent();
        }

        private void FilterM_Load(object sender, EventArgs e)
        {
            RRvar.sFooter = "sampleX verzia: " + Application.ProductVersion + " - " + RRvar.sFullName;
            lStatus.Text = RRvar.sFooter;
            this.Text = RRvar.sHeader;
            RRcode.Front();

            Filldt("select id, CONCAT(polozka, ' - ', parameter, ' - ', princip, ' - ', ozn, ' - ', odd) as value from c_all1 order by polozka, parameter");
            cMain.DisplayMember = "value";
            cMain.ValueMember = "id";
            cMain.DataSource = dt;
            //cMain.SelectedIndex = 0;
            cMain.SelectedValue = Convert.ToInt32(RRvar.sTempN);
            DoIt1();
            bStart = false;
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
                "select count(id2) as total from c_matrica1 where " +
                "c_all = '" + RRvar.sTempN + "' and id2 = '" + t + "';";

                j = Convert.ToInt16(RRsql.RunSqlReturn(sSql));

                if (j == 0)
                {
                    s = "insert into c_matrica (c_all, matrica, refe_id) values ('" + RRvar.sTempN + "', '" + t + "', '" + RRvar.idUser + "')";
                    int FirstDisplayedScrollingRowIndex = dg1.FirstDisplayedScrollingRowIndex;
                    RRsql.RunSql(s);

                    DoIt1();
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
            }catch{}
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
                s = "delete from c_matrica where matrica='" + t + "' and c_all= '" + RRvar.sTempN + "'";
                int FirstDisplayedScrollingRowIndex = dg2.FirstDisplayedScrollingRowIndex;
                RRsql.RunSql(s);
                DoIt1();
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
            catch {}
        }

        private void DoIt1()
        {
            string s;
            //s = "select id, value from xoddameter where id not in (select oddid from f_cat_odd1 where catid='" + cMain.SelectedValue + "')";
            s = "select id, value value from xmatrica where id not in (select matrica from c_matrica where c_all='" + RRvar.sTempN + "') order by value";
            //s = "select id, concat(value, ' (', pozn, ')') as value from xprincip order by value";
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

            s = "select id2, value from c_matrica1 where c_all = '" + RRvar.sTempN + "' order by value";

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

        private void FilterM_Shown(object sender, EventArgs e)
        {
            RRcode.FadeIn(this);
            RRcode.Front();
        }

        private void pictureBox1_MouseHover_1(object sender, EventArgs e)
        {
            RRfun.ShowMyInfoToolTip(pictureBox1.Location.X + 50, pictureBox1.Location.Y + 50, this);
        }       
    }
}



