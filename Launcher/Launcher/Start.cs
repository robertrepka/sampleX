using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Configuration;
using System.IO.Compression;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Core;


namespace Launcher
{
    public partial class Start : Form
    {
        string sSmbShare = "";
        string sRun = "";
        string sLocalVer = "";
        string sRemoteVer = "";
        bool bVyrok = false;

        public Start()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string sPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string sUserPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData); 
            ////string sPath = Path.GetDirectoryName(Application.ExecutablePath);
            

            //string[] sPart = Regex.Split(sPath, @"\\");
            //int j = sPart.Length - 2;
            //for (int i = 0; i < j; i++)
            //{
            //    sCurrPath += sPart[i];
            //    sCurrPath += "\\";
            //}
            RRvar.sCurrPath = sUserPath + "\\sampleX\\";

            
            sSmbShare = ReadConfigTxt(@".\Launcher.config", "share");
            sRun = "sampleX.exe";
         
            FileVersionInfo myFileVersionInfo;

            try
            {
                myFileVersionInfo = FileVersionInfo.GetVersionInfo(RRvar.sCurrPath + "App\\" + sRun);
                sLocalVer = myFileVersionInfo.FileVersion;
            }
            catch 
            {
                sLocalVer = "0.0.0.0";
            }
            
            try
            {
                sRemoteVer = ReadConfigTxt(sSmbShare + "version", "ver");
            }
            catch 
            {
                sRemoteVer = "0.0.0.0";
            }
            RRvar.sCopyFileVersion = sRemoteVer;
            //sSmbShare = ConfigurationSettings.AppSettings["SMB_share"];

            Process[] processlist = Process.GetProcesses();
            int iProc = 0;

            foreach (Process theprocess in processlist)
            {
                if (theprocess.ProcessName == "Launcher" && theprocess.ProcessName == sRun)
                {
                    iProc++;
                }
            }

            if (iProc > 1)
            {
                foreach (Process clsProcess in Process.GetProcesses())
                {
                    if (clsProcess.ProcessName.StartsWith("Launcher") && (clsProcess.Id != Process.GetCurrentProcess().Id))
                    {
                        clsProcess.Kill();
                    }
                    if (clsProcess.ProcessName.StartsWith(sRun))
                    {
                        clsProcess.Kill();
                    }
                }
            }
            
            if (sLocalVer!=sRemoteVer)
            {
                
                try
                {
                    Microsoft.VisualBasic.FileIO.FileSystem.DeleteDirectory(RRvar.sCurrPath + "App", Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.DeletePermanently, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing);
                }
                catch { }
                
                if (!File.Exists(RRvar.sCurrPath + "\\App\\" + sRun))
                {
                    Microsoft.VisualBasic.FileIO.FileSystem.CreateDirectory(RRvar.sCurrPath + "App");
                    RRcode.CopyPro(sSmbShare + "update.zip", RRvar.sCurrPath + "App\\", this);
                    //Microsoft.VisualBasic.FileIO.FileSystem.CopyFile(sSmbShare + "update.zip", sCurrPath + "App\\update.zip", Microsoft.VisualBasic.FileIO.UIOption.AllDialogs);
                    do
                    {
                        
                    } while (RRvar.bCopyFileProgress);

                    ExtractZipFile(RRvar.sCurrPath + "App\\update.zip", "", RRvar.sCurrPath + "App\\");
                    Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(RRvar.sCurrPath + "App\\__placeholder__");
                    Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(RRvar.sCurrPath + "App\\update.zip");
                }
            }
            Process proc = new Process();
            proc.StartInfo.FileName = RRvar.sCurrPath + "App\\" + sRun;
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.Arguments = "start";

            try
            {
                proc.Start();
            }
            catch 
            {
            }
        }

        private void Vyrok()
        {
            int i = RRcode.NahodneCisloVyroku();
            string s = "-- " + RRcode.Vyrok(i, true) + "\r\n" + RRcode.Vyrok(i, false);
            //toolTip1.Show(s, this, 10000);
            ToolTip mytoolTip = new ToolTip();
            mytoolTip.ShowAlways = true; // to force it
            mytoolTip.Show(s, this, 10000);
        }

        private void Start_Load(object sender, EventArgs e)
        {
            if (ReadConfigTxt(@".\Launcher.config", "sentence") == "1")
            {
                bVyrok = true;
            }

            if (bVyrok) Vyrok();
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Application.Exit();
        }

        public void ExtractZipFile(string archiveFilenameIn, string password, string outFolder)
        {
            ZipFile zf = null;
            try
            {
                FileStream fs = File.OpenRead(archiveFilenameIn);
                zf = new ZipFile(fs);
                if (!String.IsNullOrEmpty(password))
                {
                    zf.Password = password;		// AES encrypted entries are handled automatically
                }
                foreach (ZipEntry zipEntry in zf)
                {
                    if (!zipEntry.IsFile)
                    {
                        continue;			// Ignore directories
                    }
                    String entryFileName = zipEntry.Name;
                    // to remove the folder from the entry:- entryFileName = Path.GetFileName(entryFileName);
                    // Optionally match entrynames against a selection list here to skip as desired.
                    // The unpacked length is available in the zipEntry.Size property.

                    byte[] buffer = new byte[4096];		// 4K is optimum
                    Stream zipStream = zf.GetInputStream(zipEntry);

                    // Manipulate the output filename here as desired.
                    String fullZipToPath = Path.Combine(outFolder, entryFileName);
                    string directoryName = Path.GetDirectoryName(fullZipToPath);
                    if (directoryName.Length > 0)
                        Directory.CreateDirectory(directoryName);

                    // Unzip file in buffered chunks. This is just as fast as unpacking to a buffer the full size
                    // of the file, but does not waste memory.
                    // The "using" will close the stream even if an exception occurs.
                    using (FileStream streamWriter = File.Create(fullZipToPath))
                    {
                        StreamUtils.Copy(zipStream, streamWriter, buffer);
                    }
                }
            }
            finally
            {
                if (zf != null)
                {
                    zf.IsStreamOwner = true; // Makes close also shut the underlying stream
                    zf.Close(); // Ensure we release resources
                }
            }
        }

        /// <summary>
        /// Zistí v textovom súbore prítomnosť reťazca a pridá znak =
        /// prechádza po jednotlivých riadkoch.
        /// Ak reťazec nájde, vráti text za znamienkom =.
        /// Ignoruje riadky začínajúce mriežkou - ako komentár v UNIX-e.
        /// </summary>
        /// <param name="strMenoSuboru">Názov textového súboru z ktorého sa má čítať text</param>
        /// <param name="strNazovAtributu">Reťazec, ktorý má hľadať v súbore</param>
        /// 
        public static string ReadConfigTxt(string strNazovSuboru, string strNazovAtributu)
        {
            string strRiadok = "";
            string strHodnota = "";
            string strHladanyRetazec = strNazovAtributu + "=";
            bool bNasielSom = false;
            int i = 0;
            int j = 0;
            int k = 0;
            TextReader tr;
            try
            {
                tr = new StreamReader(strNazovSuboru, Encoding.Default);
            }
            catch (Exception)
            {
                
                throw;
            }
            do
            {
                try
                {
                    strRiadok = tr.ReadLine();

                    if (strRiadok.Length > 0)
                    {
                        if (strRiadok.Substring(0, 1) == "#")
                        {
                        }
                        else
                        {
                            if (strRiadok.IndexOf(strHladanyRetazec) >= 0)
                            {
                                bNasielSom = true;
                                i = strRiadok.IndexOf("=") + 1;
                                j = strRiadok.Length;
                                k = strRiadok.Length - strRiadok.IndexOf("=") - 1;
                                strHodnota = strRiadok.Substring(strRiadok.IndexOf("=") + 1, strRiadok.Length - strRiadok.IndexOf("=") - 1);

                            }
                        }
                    }
                }
                catch
                {

                    bNasielSom = true;
                    strHodnota = "";
                }
            } while (bNasielSom == false);
            tr.Close();
            return strHodnota;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }




    }
}
