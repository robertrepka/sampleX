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
    public partial class PassChangeAdmin: Form
    {
        RRsql RRsql = new RRsql();
        RRcode RRcode = new RRcode();
        RRstring RRstring = new RRstring();

        bool bAfterChange = false;
        
        public PassChangeAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
                        RRvar.sTemp = RRstring.CryptPass(RRvar.sTemp8 + tNew1.Text);
                        RRsql.RunSql("update refe set password = '" + RRvar.sTemp + "' where id = " + RRvar.iID + ";");
                        MessageBox.Show("Heslo bolo úspešne zmenené.", "Zmena hesla", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        RRcode.Log(this.Text);
                        RRvar.sNewPass = RRstring.CryptPass(tNew1.Text);
                        this.Close();
                    }
                    catch { }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RRvar.sNewPass = "";
            this.Close();
        }

        private void PassChangeAdmin_Shown(object sender, EventArgs e)
        {
            tNew1.Focus();
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

        private void PassChangeAdmin_Load(object sender, EventArgs e)
        {
            this.Text = RRvar.sHeader;
            bAfterChange = false;
            RRvar.sNewPass = "";
        }

        private void PassChangeAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            RRcode.FadeOut(this);
        }
    }
}
