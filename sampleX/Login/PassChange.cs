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

namespace sampleX
{
    public partial class PassChange: Form
    {
        RRsql RRsql = new RRsql();
        RRcode RRcode = new RRcode();
        RRstring RRstring = new RRstring();

        bool bAfterChange = false;
        
        public PassChange()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            string sSql="";
            string sPass = RRstring.CryptPass(RRvar.sUser + tOld.Text);
            sSql =
            "select count(id) as total from refe where " +
            "login = '" + RRvar.sUser + "' and password = '" + sPass + "';";

            i = Convert.ToInt16(RRsql.RunSqlReturn(sSql));

            if (i > 0)
            {
                if (tNew1.Text == tOld.Text)
                {
                    MessageBox.Show("Vami zadané nové heslo musí byť iné, ako staré.\r\nPokus zopakujte.", "Zmena hesla", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    tNew1.Text = "";
                    tNew2.Text = "";
                    bAfterChange = true;
                    tNew1.Focus();
                }
                else
                {
                    if (!(tNew1.Text == tNew2.Text))
                    {
                        MessageBox.Show("Vami zadané nové heslá sa nezhodujú.\r\nPokus zopakujte.", "Zmena hesla", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                        tNew1.Text = "";
                        tNew2.Text = "";
                        bAfterChange = true;
                        tNew1.Focus();
                    }
                    else
                    {
                        if (tNew1.Text.Length < RRvar.iMinPasswordLenght)
                        {
                            MessageBox.Show("Vami zadané nové heslo nemá dostatočný počet znakov.\r\nMinimum je " + RRvar.iMinPasswordLenght + ".\r\n\r\nZadajte dlhšie heslo.", "Zmena hesla", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                            tNew1.Text = "";
                            tNew2.Text = "";
                            bAfterChange = true;
                            tNew1.Focus();
                        }
                        else
                        {
                            try
                            {
                                RRsql.RunSql("update refe set password = '" + RRstring.CryptPass(RRvar.sUser + tNew1.Text) + "' where login = '" + RRvar.sUser + "';");
                                MessageBox.Show("Heslo bolo úspešne zmenené.", "Zmena hesla", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                RRcode.Log("Zmena vlastného hesla");
                                this.Close();
                            }
                            catch { }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vami zadané staré heslo je nesprávne.\r\nPokus zopakujte.", "Nesprávne heslo", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                tOld.Enabled = false;
                tNew1.Enabled = false;
                tNew2.Enabled = false;
                btnCancel.Enabled = false;
                btnOK.Enabled = false;
                Thread.Sleep(3000);
                tOld.Text = "";
                tNew1.Text = "";
                tNew2.Text = "";
                tOld.Enabled = true;
                tNew1.Enabled = true;
                tNew2.Enabled = true;
                btnCancel.Enabled = true;
                btnOK.Enabled = true;
                bAfterChange = true;
                tOld.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PassChange_Shown(object sender, EventArgs e)
        {
            tOld.Focus();
            RRcode.FadeIn(this);
        }

        private void tUser_KeyUp(object sender, KeyEventArgs e)
        {
            if (!bAfterChange)
            {
                if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
                {
                    this.SelectNextControl((Control)sender, true, true, true, true);
                }
            }
        }

        private void tPass_KeyUp(object sender, KeyEventArgs e)
        {
            if (!bAfterChange)
            {
                if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
                {
                    this.SelectNextControl((Control)sender, true, true, true, true);
                }
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

        private void tNew2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }

        private void tNew2_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tOld_TextChanged(object sender, EventArgs e)
        {
            bAfterChange = false;
        }

        private void tNew1_TextChanged(object sender, EventArgs e)
        {
            bAfterChange = false;
        }

        private void PassChange_Load(object sender, EventArgs e)
        {
            bAfterChange = false;
        }

        private void PassChange_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void PassChange_FormClosing(object sender, FormClosingEventArgs e)
        {
            RRcode.FadeOut(this);
            this.Visible = false;
        }
    }
}
