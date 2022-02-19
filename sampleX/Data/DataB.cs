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
    public partial class DataB : Form
    {
        private readonly RRcode RRcode = new RRcode();
        private readonly RRfun RRfun = new RRfun();
        private readonly RRdata RRdata = new RRdata();
        private readonly RRsql RRsql = new RRsql();
                
        BindingSource bs = new BindingSource();
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable dt;
        DataTable dt2;

        MySqlCommand myCommand;
        MySqlDataAdapter MyAdapter;
        MySqlConnection con = new MySqlConnection(RRvar.sConStr);

        bool bStart = true;

        public DataB()
        {
            InitializeComponent();
        }

        private void DataB_Load(object sender, EventArgs e)
        {
            bStart = true;
            RRvar.sFooter = "sampleX verzia: " + Application.ProductVersion + " - " + RRvar.sFullName;
            lStatus.Text = RRvar.sFooter;
            rokUD.Value = Convert.ToInt16(RRvar.iRok);
            this.Text = RRvar.sHeader;
            RRcode.Front();
            FilldtVsetko("select id, value from xodd order by value");
            cMain.DisplayMember = "value";
            cMain.ValueMember = "id";
            cMain.DataSource = dt;
            cMain.SelectedIndex = 0;
            dg.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10);
            dg.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            DoIt1();
            bStart = false;
        }

        private void DoIt1()
        {
            string sSql = "";
            string sSqlOddNull = "";

            sSql = " SELECT DISTINCT " +
            " labc.id AS id, labc.labc AS labc, labc.rok AS rok, " +
            " xodd.value AS odd, partner.nazov as nazov " +
            " from xodd, data, labc, zakazka, obj, partner  " +
            " WHERE  " +
            " data.odd = xodd.id AND " +
            " data.labc = labc.id AND  " +
            " labc.zakazka_id = zakazka.id AND  " +
            " zakazka.obj_id = obj.id AND  " +
            " obj.partner_id = partner.id AND " +
            " zakazka.rok = '" + rokUD.Value.ToString() + "' ";

            sSqlOddNull = " SELECT DISTINCT " +
            " labc.id AS id, labc.labc AS labc, labc.rok AS rok, " +
            " '' AS odd, partner.nazov as nazov " +
            " from data, labc, zakazka, obj, partner  " +
            " WHERE  " +
            " data.labc = labc.id AND  " +
            " labc.zakazka_id = zakazka.id AND  " +
            " zakazka.obj_id = obj.id AND  " +
            " data.odd IS NULL AND  " +
            " obj.partner_id = partner.id AND " +
            " zakazka.rok = '" + rokUD.Value.ToString() + "' ";

            if (cMain.SelectedIndex == 0)
            {
                Filldt(sSql);
                Filldt2(sSqlOddNull);
                dt.Merge(dt2);
            }

            if (cMain.SelectedIndex == 1)
            {
                Filldt(sSqlOddNull);
                dt.Merge(dt);
            }

            if (cMain.SelectedIndex > 1)
            {
                sSql += " AND xodd.id = '" + cMain.SelectedValue + "' ";
                Filldt(sSql);
                dt.Merge(dt);
            }

            DataView dv = dt.DefaultView;
            dv.Sort = "[rok] DESC, [labc] DESC";
            dg.DataSource = dv;
            this.dg.Columns["labc"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dg.Columns["labc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            this.dg.Columns["rok"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dg.Columns["rok"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }

        private void cMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!bStart)
            {
                DoIt1();    
            }
        }

        private void FilldtVsetko(string sSql)
        {
            myCommand = new MySqlCommand(sSql, con);
            MyAdapter = new MySqlDataAdapter(myCommand);
            dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("value");
            dt.Rows.Add("0", "- všetky oddelenia -");
            dt.Rows.Add("1", "- bez oddelenia -");
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
        
        private void ChildFormClosedFull(object sender, EventArgs e)
        {
            RRcode.FadeIn(this);
            this.Visible = true;
            RRcode.Front();
            cMain.SelectedIndex = 0;
        }

        private void DataB_Shown(object sender, EventArgs e)
        {
            RRcode.FadeIn(this);
            RRcode.Front();
        }

        private void pictureBox1_MouseHover_1(object sender, EventArgs e)
        {
            RRfun.ShowMyInfoToolTip(pictureBox1.Location.X + 50, pictureBox1.Location.Y + 50, this);
        }

        private void rokUD_ValueChanged(object sender, EventArgs e)
        {
            if (!bStart)
            {
                DoIt1();
            }
        }
        private void bOK_Click(object sender, EventArgs e)
        {
            int i = dg.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dg.Rows[i];
            RRvar.sTemp1 = selectedRow.Cells[0].Value.ToString();
            RRvar.iFilterMeranie = Convert.ToInt16(cMain.SelectedValue);
            RRvar.sFilterMeranie = cMain.Text;
            RRcode.FadeOut(this);
            this.Visible = false;
            Form DataC = new DataC();
            DataC.Closed += new EventHandler(ChildFormClosedFull);
            DataC.Show();
        }

        private void dg_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int i = 0; i < (dg.Rows.Count); i++)
            {
                if (dg.Rows[i].Cells["nazov"].Value.ToString().StartsWith(e.KeyChar.ToString(), true, CultureInfo.InvariantCulture))
                {
                    dg.Rows[i].Cells["nazov"].Selected = true;
                    dg.CurrentCell = dg.Rows[i].Cells["nazov"];
                    return;
                }
            }
        }

        private void dg_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dg.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dg.Rows[i];
            RRvar.sTemp1 = selectedRow.Cells[0].Value.ToString();
            RRvar.iFilterMeranie = Convert.ToInt16(cMain.SelectedValue);
            RRvar.sFilterMeranie = cMain.Text;
            RRcode.FadeOut(this);
            this.Visible = false;
            Form DataC = new DataC();
            DataC.Closed += new EventHandler(ChildFormClosedFull);
            DataC.Show();
        }
    }
}