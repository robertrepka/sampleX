using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Configuration;
using System.IO;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;

namespace sampleX
{
    public partial class Start2 : Form
    {
        RRfun RRfun = new RRfun();
        RRsql RRsql = new RRsql();

        string s2;

        public Start2()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        public static extern bool ShowWindowAsync(HandleRef hWnd, int nCmdShow);
        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr WindowHandle);
        public const int SW_RESTORE = 9;

        public static void ChangeAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                MessageBox.Show("Chyba pri zápise konfigurácie.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
        }

        private void Start2_Load(object sender, EventArgs e)
        {
            this.Size = new Size(45,45);
            pictureBox2.Size = new Size(45, 45);
            RRfun.ShowMyInfoToolTip(15, 75, this);
        }

        private void Start2_Shown(object sender, EventArgs e)
        {
            backgroundWorker2.RunWorkerAsync();
        }
        
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                RRvar.sFullName = RRsql.RunSqlReturn("select fullname from refe where login = '" + RRvar.sUser + "';");
            } catch { }
            try
            {
                RRvar.iMinPasswordLenght = Convert.ToInt16(RRsql.Config("MinPasswordLenght"));
            } catch {
                RRvar.iMinPasswordLenght = 8;
            }
            
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Form Menu = new Menu();
            Menu.Show();
            this.Close();
        }

        
     }
}
