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

namespace sampleX
{
    public partial class Start : Form
    {
        string s2;
        string sLibrary = "System.Data.Security";
        RRstring RRstring = new RRstring();
        RRcode RRcode = new RRcode();
        RRfun RRfun = new RRfun();
        bool bBadInstallation = false;

        public Start()
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

        private void Start_Load(object sender, EventArgs e)
        {
            bBadInstallation = false;
            string sReal = "";
            string sNeed1 = "";
            string sNeed2 = "";
            sReal = Environment.CurrentDirectory;
            sNeed1 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).Substring(0, 16);

            if (!sReal.StartsWith(sNeed1))
            {
                bBadInstallation = true;
            }

            sReal = System.Reflection.Assembly.GetExecutingAssembly().Location;
            sNeed1 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            sNeed2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            if (!sReal.StartsWith(sNeed1))
            {
                if (!sReal.StartsWith(sNeed2))
                {
                    bBadInstallation = true;
                }
            }
            int iProc = 0;

            Process[] processlist = Process.GetProcesses();
            foreach (Process theprocess in processlist)
            {
                if (theprocess.ProcessName.ToLower() == "samplex")
                {
                    IntPtr hWnd = IntPtr.Zero;
                    hWnd = theprocess.MainWindowHandle;
                    ShowWindowAsync(new HandleRef(null, hWnd), SW_RESTORE);
                    SetForegroundWindow(theprocess.MainWindowHandle);
                    iProc++;
                }
            }

            if (iProc > 1)
            {
                foreach (Process clsProcess in Process.GetProcesses())
                {
                    if (clsProcess.ProcessName.StartsWith("samplex") && (clsProcess.Id != Process.GetCurrentProcess().Id))
                    {
                        clsProcess.Kill();
                    }
                }
            }

            RRvar.sUser = "neprihlásený";

            RRvar.sCurrPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\";
            string sThisFile = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\sampleX.exe";
            string sThisFileVersion = "";

            FileVersionInfo myFileVersionInfo;

            try
            {
                myFileVersionInfo = FileVersionInfo.GetVersionInfo(sThisFile);
                sThisFileVersion = myFileVersionInfo.FileVersion;
            }
            catch { }

            try
            {
                TextWriter tw = new StreamWriter(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\version", false, Encoding.GetEncoding(1250));
                tw.Write("ver=" + sThisFileVersion);
                tw.Close();
            }
            catch { }

            string sPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string[] sPart = Regex.Split(sPath, @"\\");
            int j = sPart.Length - 1;
            for (int i = 0; i < j; i++)
            {
                RRvar.sCurrPath += sPart[i];
                RRvar.sCurrPath += "\\";
            }

            string sServer = ConfigurationSettings.AppSettings["server"];
            string sDb = ConfigurationSettings.AppSettings["db"];
            string sPort = ConfigurationSettings.AppSettings["port"];

            RRvar.sConStr = "SERVER=" + sServer + ";DATABASE=" + sDb + ";UID=samplex;PASSWORD=System.Data.Security;";
        }

        private void Start_Shown(object sender, EventArgs e)
        {
            string[] args = Environment.GetCommandLineArgs();
            string s = "";
            int ii;
            try
            {
                s = args[1].ToString().ToLower();
            }
            catch { }

            if (s == "full")
            {
                Form Login = new Login();
                Login.Show();
                this.Hide();
            }
            else
            {
                if (s == "start")
                {
                    if (bBadInstallation)
                    {
                        ii = RRfun.NahodneCisloVyroku();
                        s2 = "Toto je testovacia verzia aplikácie, ktorá sa pripája na inštanciu servera, ktorá už nie je funkčná.";
                        s2 += "\r\n\r\nNainštalujte si prosím miesto nej produkčnú aplikáciu z dodaného inštalačného média: ";
                        s2 += "\r\nS:\\_sampleX\\setup.exe";
                        s2 += "\r\n\r\nV prípade problémov volajte 0917 799 260.";
                        s2 += "\r\n\r\n";
                        s2 += "-- " + RRfun.Vyrok(ii, true) + "\r\n" + RRfun.Vyrok(ii, false);
                        s2 += "\r\n\r\n© 2021 Róbert Repka";
                        MessageBox.Show(s2, "SampleX - TESTOVACIA APLIKÁCIA", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                        try
                        {
                            RRcode.LogAsSystem("NEKOREKTNÁ INŠTALÁCIA");
                        }
                        catch { }
                        Application.Exit();
                    }
                    else
                    {
                        Form Login = new Login();
                        Login.Show();
                        this.Hide();
                    }
                }
                else
                {
                    ii = RRfun.NahodneCisloVyroku();
                    s2 = "Pokúšate sa získať neoprávnený prístup do aplikácie!";
                    s2 += "\r\n\r\n";
                    s2 += "-- " + RRfun.Vyrok(ii, true) + "\r\n" + RRfun.Vyrok(ii, false);
                    s2 += "\r\n\r\n© 2021 Róbert Repka";
                    MessageBox.Show(s2, "SampleX - NEAUTORIZOVANY PRÍSTUP", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    try
                    {
                        RRcode.LogAsSystem("NEAUTORIZOVANY PRÍSTUP");
                    }
                    catch { }
                    Application.Exit();
                }
            }
        }
    }
}
