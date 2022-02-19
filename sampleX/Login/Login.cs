using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;

namespace sampleX
{
    public partial class Login : Form
    {
        RRcode RRcode = new RRcode();
        RRstring RRstring = new RRstring();
        RRsql RRsql = new RRsql();

        [DllImport("user32.dll")]
        public static extern bool LockWorkStation();

        int iBadLoginCount = 0;
        bool bExit = true;


        public Login()
        {
            InitializeComponent();
        }


        public void LoadVariables()
        {
            int i;
            try
            {
                i = Convert.ToInt32(RRcode.RegRead("LabelsFont1"));
                if (i >= 10 && i <= 50)
                {
                    RRvar.iLabelsFont1 = i;
                }
                else
                {
                    RRvar.iLabelsFont1 = 20;
                    RRcode.RegWrite("LabelsFont1", "20");
                }
            }
            catch
            {
                RRvar.iLabelsFont1 = 20;
                RRcode.RegWrite("LabelsFont1", "20");
            }

            try
            {
                i = Convert.ToInt32(RRcode.RegRead("LabelsFont2"));
                if (i >= 10 && i <= 50)
                {
                    RRvar.iLabelsFont2 = i;
                }
                else
                {
                    RRvar.iLabelsFont2 = 14;
                    RRcode.RegWrite("LabelsFont2", "14");
                }
            }
            catch
            {
                RRvar.iLabelsFont2 = 14;
                RRcode.RegWrite("LabelsFont2", "14");
            }

            try
            {
                i = Convert.ToInt32(RRcode.RegRead("LabelsColumnSize"));
                if (i >= 100 && i <= 1000)
                {
                    RRvar.iLabelsColumnSize = i;
                }
                else
                {
                    RRvar.iLabelsColumnSize = 500;
                    RRcode.RegWrite("LabelsColumnSize", "500");
                }
            }
            catch
            {
                RRvar.iLabelsColumnSize = 500;
                RRcode.RegWrite("LabelsColumnSize", "500");
            }

            try
            {
                i = Convert.ToInt32(RRcode.RegRead("LabelsRowSize"));
                if (i >= 10 && i <= 100)
                {
                    RRvar.iLabelsRowSize = i;
                }
                else
                {
                    RRvar.iLabelsRowSize = 50;
                    RRcode.RegWrite("LabelsRowSize", "50");
                }
            }
            catch
            {
                RRvar.iLabelsRowSize = 50;
                RRcode.RegWrite("LabelsRowSize", "50");
            }


        }


        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            int iBad = 0;
            string sLock = "";
            string sSql = "";

            sSql = "select active from refe where " + "login = '" + tUser.Text + "';";
            try
            {
                sLock = RRsql.RunSqlReturn(sSql).ToLower();
            }
            catch { }

            if (sLock == "false")
            {
                MessageBox.Show("Toto konto je uzamknuté.\r\nKontaktujte správcu!", "Upozornenie", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Enabled = false;
                Thread.Sleep(3000);
                this.Enabled = true;
                RRcode.LogAsSystem("Pokus o prihlásenie zamknutým účtom " + tUser.Text);
                return;
            }

            sSql =
            "select attempts from refe where " +
            "login = '" + tUser.Text + " ';";
            try
            {
                iBad = Convert.ToInt16(RRsql.RunSqlReturn(sSql));
            }
            catch
            {
                iBad = 0;
            }

            if (iBad >= RRvar.iMaxLoginAttempts)
            {
                MessageBox.Show("Toto konto bolo uzamknuté.\r\nKontaktujte správcu!", "Upozornenie", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Enabled = false;
                Thread.Sleep(3000);
                this.Enabled = true;
                sSql = "update refe set active = 'False' where login = '" + tUser.Text + "';";
                try
                {
                    RRsql.RunSql(sSql);
                }
                catch { }
                RRcode.LogAsSystem("Zamknutie účtu " + tUser.Text);
                return;
            }

            string sPass = RRstring.CryptPass(tUser.Text + tPass.Text);
            sSql =
            "select count(id) as total from refe where " +
            "login = '" + tUser.Text + "' and password = '" + sPass + "'" +
            " and active = 'true';";

            i = Convert.ToInt16(RRsql.RunSqlReturn(sSql));

            if (i > 0)
            {
                RRvar.sUser = tUser.Text;
                RRvar.idUser = Convert.ToInt16(RRsql.RunSqlReturn("select id from refe where login = '" + RRvar.sUser + "';"));
                bExit = false;

                sSql = "update refe set attempts = '0' where login = '" + tUser.Text + "';";
                try
                {
                    RRsql.RunSql(sSql);
                }
                catch { }

                try
                {
                    RRcode.RegWrite("lastlogin", RRstring.Crypt((tUser.Text), RRstring.HardDiskID2(), true));
                }
                catch { }
                RRcode.Licence();
                LoadVariables();
                Form Start2 = new Start2();
                Start2.Show();
                this.Close();
            }
            else
            {
                RRvar.sUser = tUser.Text;
                RRvar.idUser = Convert.ToInt16(RRsql.RunSqlReturn("select id from refe where login = '" + RRvar.sUser + "';"));

                try
                {
                    RRcode.Log("Neúspešné prihlásenie - " + tUser.Text);
                }
                catch { }
                iBad++;
                sSql = "update refe set attempts = '" + iBad + "' where login = '" + tUser.Text + "';";
                try
                {
                    RRsql.RunSql(sSql);
                }
                catch { }

                iBadLoginCount++;

                if (iBadLoginCount == 1)
                {
                    tUser.Enabled = false;
                    tPass.Enabled = false;
                    btnOK.Enabled = false;
                    btnCancel.Enabled = false;
                    Application.DoEvents();
                    Thread.Sleep(2000);
                    tUser.Enabled = true;
                    tPass.Enabled = true;
                    btnOK.Enabled = true;
                    btnCancel.Enabled = true;
                    tPass.Text = "";
                    tPass.Focus();
                    Application.DoEvents();
                }
                if (iBadLoginCount == 2)
                {
                    tUser.Enabled = false;
                    tPass.Enabled = false;
                    btnOK.Enabled = false;
                    btnCancel.Enabled = false;
                    Application.DoEvents();
                    Thread.Sleep(5000);
                    tUser.Enabled = true;
                    tPass.Enabled = true;
                    btnOK.Enabled = true;
                    btnCancel.Enabled = true;
                    tPass.Text = "";
                    tPass.Focus();
                    Application.DoEvents();
                }
                if (iBadLoginCount == 3)
                {
                    tUser.Enabled = false;
                    tPass.Enabled = false;
                    btnOK.Enabled = false;
                    btnCancel.Enabled = false;
                    Application.DoEvents();
                    Thread.Sleep(7000);
                    try
                    {
                        LockWorkStation();
                    }
                    catch { }
                    Application.Exit();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                RRvar.iMaxLoginAttempts = Convert.ToInt16(RRsql.Config("MaxLoginAttempts"));
            }
            catch
            {
                RRvar.iMaxLoginAttempts = 3;
            }
            RRcode.Front();
            //string s = RRstring.CryptPass("33");
            try
            {
                tUser.Text = RRstring.Decrypt(RRcode.RegRead("lastlogin"), RRstring.HardDiskID2(), false, true);
            }
            catch { }
        }

        private void Login_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            RRcode.FadeOut(this);
            this.Visible = false;
            if (bExit)
            {
                Application.Exit();
            }
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            if (tUser.Text.Length > 0)
            {
                tPass.Focus();
            }
            else
            {
                tUser.Focus();
            }
            RRcode.FadeIn(this);
        }

        private void tPass_KeyUp(object sender, KeyEventArgs e)
        {

            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);

            }
        }

        private void tUser_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }

        private void tUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }

        private void tUser_TextChanged(object sender, EventArgs e)
        {
            if (tUser.Text.Length > 0)
            {
                btnOK.Enabled = true;
            }
            else
            {
                btnOK.Enabled = false;
            }
        }
    }
}
