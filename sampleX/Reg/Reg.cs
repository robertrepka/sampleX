using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;


namespace sampleX
{
    public partial class Reg: Form
    {
        public Reg()
        {
            InitializeComponent();
        }

        bool bExit = true;
        RRstring RRstring = new RRstring();
        RRcode RRcode = new RRcode();

        private void button1_Click(object sender, EventArgs e)
        {

            RegistryKey RegKey1;
            RegKey1 = Registry.CurrentUser.CreateSubKey(@"Software\Repka Software\sampleX");
            try
            {
                RegKey1.SetValue("key", txtIn.Text);
            }
            catch
            {
                RegKey1.Flush();
                RegKey1.Close();
            }
            RegKey1.Flush();
            RegKey1.Close();

            //if (MessageBox.Show("Vďaka za registráciu", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            //{
            //    this.Close();
            //}
            bExit = false;
            Form Login = new Login();
            Login.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void txtIn_TextChanged(object sender, EventArgs e)
        {
            if (txtIn.Text.Length > 0)
            {
                if (RRcode.ValidLicence(txtIn.Text))
                {
                    lOut.Text = RRcode.Licence(txtIn.Text);
                    if (RRcode.LicenceIsDemo(txtIn.Text))
                    {
                        lOut.Text += "\r\nPlatí do ";
                        lOut.Text += RRcode.LicenceEnd(txtIn.Text).ToString();
                    }
                    if (RRcode.LicenceIsValidNow(txtIn.Text))
                    {
                        btnOK.Enabled = true;
                    }
                }
                else
                {
                    lOut.Text = "nesprávny kľúč!";
                    btnOK.Enabled = false;
                }
            }
            else
            {
                lOut.Text = "";
                btnOK.Enabled = false;
                
            }
        }

        private void Reg_Load(object sender, EventArgs e)
        {
            btnOK.Enabled = false;
            btnOK.Visible = true;
            txtID.Text = RRstring.HardDiskID2();
            if (txtID.Text.Length < 5)
            {
                txtID.Text = System.Environment.UserName.ToUpper().Trim();
            }
            
            //if (RRvar.bNewKey == true)
            //{
            //    RRvar.bNewKey = false;
            //    label1.Text = "Zmena registrácie:";
            //    label2.Text = "sampleX - zmena registrácie";
            //}
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        //    string strTemp = txtID.Text;
        //    MAPI mapi = new MAPI();
        //    mapi.AddRecipientCC("robert@repka.org");
        //    mapi.SendMailPopup("sampleX - registračný mail", @"Posielam Ti moje registračné ID:" + "\r\n" + @"""" + strTemp + @"""" + "\r\n" + "\r\n" + @"Okamžite mi pošli aktivačný kľúč!!!");
        }

        private void Reg_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (bExit)
            {
                Application.Exit();  
            }
        }

        private void txtIn_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}
