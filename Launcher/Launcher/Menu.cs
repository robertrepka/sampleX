using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Text.RegularExpressions;

namespace Launcher
{
    public partial class Menu : Form
    {
        string sLibrary = "System.Data.Security";
       
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
            
            string sPath = System.IO.Path.GetFullPath(".\\");
            //string sPath = Path.GetDirectoryName(Application.ExecutablePath);
            string[] sPart = Regex.Split(sPath, @"\\");
            int j = sPart.Length - 2;
            for (int i = 0; i < j; i++)
            {
                RRvar.sCurrPath += sPart[i];
                RRvar.sCurrPath += "\\";
            }
            //RRvar.sSmbShare = RRCrypt.Decrypt(ConfigurationSettings.AppSettings["SMB_share"], sLibrary, false, true);
            //RRvar.sSmbServer = RRCrypt.Decrypt(ConfigurationSettings.AppSettings["SMB_server"], sLibrary, false, true);
            //RRvar.sSmbUser = RRCrypt.Decrypt(ConfigurationSettings.AppSettings["SMB_user"], sLibrary, false, true);
            //RRvar.sSmbPass = RRCrypt.Decrypt(ConfigurationSettings.AppSettings["SMB_pass"], sLibrary, false, true);

            //RRvar.sConStr = 
            //    "Server=" +
            //    RRCrypt.Decrypt(ConfigurationSettings.AppSettings["CS_server"], sLibrary, false, true) +
            //    ";Port=" + 
            //    RRCrypt.Decrypt(ConfigurationSettings.AppSettings["CS_port"], sLibrary, false, true) +
            //    ";User Id=" +
            //    RRCrypt.Decrypt(ConfigurationSettings.AppSettings["CS_user"], sLibrary, false, true) +
            //    ";Password=" + 
            //    RRCrypt.Decrypt(ConfigurationSettings.AppSettings["CS_pass"], sLibrary, false, true) +
            //    ";Database=" + 
            //    RRCrypt.Decrypt(ConfigurationSettings.AppSettings["CS_db"], sLibrary, false, true) +
            //    ";";
            
            toolStripStatusLabel1.Text = "verzia: " + Application.ProductVersion ;
        }

        private void ChildFormClosedFull(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        

        private void Menu_Shown(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Vytváram pripojenie na server...";
            Application.DoEvents();
            
            
            
        }


    }
}
