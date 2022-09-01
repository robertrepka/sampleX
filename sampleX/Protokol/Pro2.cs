#region USING
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
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.HSSF.Util;
using NPOI.XSSF.Util;
using NPOI.POIFS.FileSystem;
using NPOI.HPSF;
#endregion
namespace sampleX
{
    public partial class Pro2 : Form
    {
        #region DEKLARACIE
        private readonly RRcode RRcode = new RRcode();
        private readonly RRfun RRfun = new RRfun();
        private readonly RRdata RRdata = new RRdata();
        private readonly RRsql RRsql = new RRsql();

        HSSFWorkbook xBook;
        ICell xCell;
        ISheet xSheet;
        IRow r;
        int iRow = 0;
        int iCol = 0;
        int iCount = 0;
        int iSheetNameToCreate = 1;
        int iRowToInitializeOnStart = 100;
        DataTable dtOdberName;
        DataTable dtResult;
        DataTable dtBoss;
        MySqlCommand myCommand;
        MySqlDataAdapter MyAdapter;
        MySqlConnection con = new MySqlConnection(RRvar.sConStr);

        #endregion
        #region FORM
        public Pro2()
        {
            InitializeComponent();
        }
        private void Pro2_Load(object sender, EventArgs e)
        {

            RRcode.Log(this.Text);
            this.Text = RRvar.sHeader;
            lStatus.Text = "sampleX - " + RRvar.sFullName;
            iCount = RRvar.Matrix4.Count;
            cOdberAkr.SelectedIndex = 0;
            LoadVariables();
            RRcode.Front();

            FilldtOdberName("select id1 as id, fullname from f_auth_refe1 where value='o' order by fullname");
            cOdberName.DisplayMember = "fullname";
            cOdberName.ValueMember = "id";
            cOdberName.DataSource = dtOdberName;
            cOdberName.SelectedIndex = 0;

            FilldtResult("select id1 as id, fullname from f_auth_refe1 fullname where value='p-v' order by fullname");
            cResult.DisplayMember = "fullname";
            cResult.ValueMember = "id";
            cResult.DataSource = dtResult;
            cResult.SelectedIndex = 0;

            FilldtBoss("select id1 as id, fullname from f_auth_refe1 where value='p-p' order by fullname");
            cBoss.DisplayMember = "fullname";
            cBoss.ValueMember = "id";
            cBoss.DataSource = dtBoss;
            cBoss.SelectedIndex = 0;
        }
        private void Pro2_Shown(object sender, EventArgs e)
        {
            RRcode.FadeIn(this);
            RRcode.Front();
        }
        private void FilldtOdberName(string sSql)
        {
            myCommand = new MySqlCommand(sSql, con);
            MyAdapter = new MySqlDataAdapter(myCommand);
            dtOdberName = new DataTable();
            con.Open();
            MyAdapter.Fill(dtOdberName);
            con.Close();
            MyAdapter.Dispose();
        }
        private void FilldtResult(string sSql)
        {
            myCommand = new MySqlCommand(sSql, con);
            MyAdapter = new MySqlDataAdapter(myCommand);
            dtResult = new DataTable();
            con.Open();
            MyAdapter.Fill(dtResult);
            con.Close();
            MyAdapter.Dispose();
        }
        private void FilldtBoss(string sSql)
        {
            myCommand = new MySqlCommand(sSql, con);
            MyAdapter = new MySqlDataAdapter(myCommand);
            dtBoss = new DataTable();
            con.Open();
            MyAdapter.Fill(dtBoss);
            con.Close();
            MyAdapter.Dispose();
        }
        private void bOdberName_Click(object sender, EventArgs e)
        {
            tOdber.Text = cOdberName.Text;
        }
        private void bResult_Click(object sender, EventArgs e)
        {
            tResult1.Text = cResult.Text;
            tResult2.Text = RRsql.RunSqlReturn("select post from refe where fullname = '" + cResult.Text + "'");
        }
        private void bBoss_Click(object sender, EventArgs e)
        {
            tBoss1.Text = cBoss.Text;
            tBoss2.Text = RRsql.RunSqlReturn("select post from refe where fullname = '" + cBoss.Text + "'");
        }
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            RRfun.ShowMyInfoToolTip(pictureBox1.Location.X + 50, pictureBox1.Location.Y + 50, this);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool b = true;

            tOdber.BackColor = Color.White;
            tResult1.BackColor = Color.White;
            tResult2.BackColor = Color.White;
            tBoss1.BackColor = Color.White;
            tBoss2.BackColor = Color.White;

            if (tOdber.Text.Length == 0)
            {
                tOdber.BackColor = Color.Yellow;
                b = false;
            }

            if (tResult1.Text.Length == 0)
            {
                tResult1.BackColor = Color.Yellow;
                b = false;
            }

            if (tResult2.Text.Length == 0)
            {
                tResult2.BackColor = Color.Yellow;
                b = false;
            }

            if (tBoss1.Text.Length == 0)
            {
                tBoss1.BackColor = Color.Yellow;
                b = false;
            }

            if (tBoss2.Text.Length == 0)
            {
                tBoss2.BackColor = Color.Yellow;
                b = false;
            }

            if (b)
            {
                RRcode.Log(this.Text);
                xBook = new HSSFWorkbook();
                myStylesDefine();
                Typ1();
            }
        }
        private void nu1_ValueChanged(object sender, EventArgs e)
        {
            RRcode.RegWrite("Proto1", nu1.Value.ToString());
        }
        private void nu2_ValueChanged(object sender, EventArgs e)
        {
            RRcode.RegWrite("Proto2", nu2.Value.ToString());
        }
        private void nu3_ValueChanged(object sender, EventArgs e)
        {
            RRcode.RegWrite("Proto3", nu3.Value.ToString());
        }
        private void nu4_ValueChanged(object sender, EventArgs e)
        {
            RRcode.RegWrite("Proto4", nu4.Value.ToString());
        }
        private void nuR_ValueChanged(object sender, EventArgs e)
        {
            RRcode.RegWrite("ProtoR", nuR.Value.ToString());
        }
        private void nuC_ValueChanged(object sender, EventArgs e)
        {
            RRcode.RegWrite("ProtoC", nuC.Value.ToString());
        }
        private void nuF2_ValueChanged(object sender, EventArgs e)
        {
            RRcode.RegWrite("ProtoF2", nuF2.Value.ToString());
        }
        private void nuF1_ValueChanged(object sender, EventArgs e)
        {
            RRcode.RegWrite("ProtoF1", nuF1.Value.ToString());
        }
        #endregion
    }
}



