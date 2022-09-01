using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using System.Configuration;

namespace sampleX
{
    public partial class zzzz : Form
    {
        string s = "";
        OpenFileDialog o = new OpenFileDialog();
        string sDlg = "";
        string sOrFilename = "";
        string sOrExt = "";
        string sNewFilename = "";
        bool bSuccCopy;
        string sFullRemotePath = "";
        string sFullLocalPath = "";
        string sFullLocalName = "";
        string sSmbServer = "";
        string sSmbShare = "";
        string sSmbUser = "";
        string sSmbPass = "";
        RRcode RRcode = new RRcode();
        RRzip RRzip = new RRzip();

        public zzzz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            o = new OpenFileDialog();
            o.Title = "sampleX - vyberte súbor";
            o.Filter = "Všetko|*.*";
            sDlg = "";
            sOrFilename = "";
            sOrExt = "";
            sNewFilename = "";

            if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                sDlg = o.FileName;
                sOrFilename = sDlg.Substring(sDlg.LastIndexOf("\\") + 1, sDlg.Length - 1 - sDlg.LastIndexOf("\\"));
                sOrExt = sOrFilename.Substring(sOrFilename.LastIndexOf(".") + 1, sOrFilename.Length - 1 - sOrFilename.LastIndexOf(".")).ToLower();
                sNewFilename = RRstring.NewRandomFilename() + "." + sOrExt.ToLower();
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (bSuccCopy)
            {
                bSuccCopy = false;
                this.BringToFront();
            }
            else
            {
                this.BringToFront();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            MyCopyLocal();
            MyCopyRemote();
        }

        private void MyCopyLocal()
        {
            CreateLocalDir();
            FileSystem.CopyFile(sDlg, sFullLocalPath + @"\" + sNewFilename, Microsoft.VisualBasic.FileIO.UIOption.AllDialogs);
            RRzip.CompressFile(sFullLocalPath + @"\" + sNewFilename, sFullLocalPath + @"\" + sNewFilename + ".zip", true, "System.Data.Security");
            FileSystem.DeleteFile(sFullLocalPath + @"\" + sNewFilename);
            sFullLocalName = sFullLocalPath + @"\" + sNewFilename + ".zip";
        }

        private void MyCopyRemote()
        {
            int i = 0;
            sSmbServer = ConfigurationSettings.AppSettings["SMB_server"];
            sSmbShare = ConfigurationSettings.AppSettings["SMB_share"];
            sSmbUser = ConfigurationSettings.AppSettings["SMB_user"];
            sSmbPass = ConfigurationSettings.AppSettings["SMB_pass"];

            //CreateRemoteDir();

            using (NetworkShareAccesser.Access(sSmbServer, sSmbServer, sSmbUser, sSmbPass))
            {
                CreateRemoteDir();
                RRcode.CopyPro(sFullLocalName, sFullRemotePath, this);
            }

            using (NetworkShareAccesser.Access(sSmbServer, sSmbServer, sSmbUser, sSmbPass))
            {
                do
                {
                    if (FileSystem.FileExists(sFullRemotePath + sNewFilename + ".zip"))
                    {
                        i = i + 1000;
                        bSuccCopy = true;
                    }
                    else
                    {
                        i++;
                        System.Threading.Thread.Sleep(100);
                        bSuccCopy = false;
                    }
                } while (i < 150);
            }
            FileSystem.DeleteFile(sFullLocalPath + @"\" + sNewFilename + ".zip");
        }

        public void CreateLocalDir()
        {
            s = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\" + "sampleX";
            Microsoft.VisualBasic.FileIO.FileSystem.CreateDirectory(s);
            s += @"\" + "Cache";
            Microsoft.VisualBasic.FileIO.FileSystem.CreateDirectory(s);
            sFullLocalPath = s;
        }

        public void CreateRemoteDir()
        {
            Microsoft.VisualBasic.FileIO.FileSystem.CreateDirectory(@"\\" + sSmbServer + @"\" + sSmbShare + @"\" + DateTime.Now.ToString("yyyy"));
            Microsoft.VisualBasic.FileIO.FileSystem.CreateDirectory(@"\\" + sSmbServer + @"\" + sSmbShare + @"\" + DateTime.Now.ToString("yyyy") + @"\" + DateTime.Now.ToString(DateTime.Now.Month.ToString("MM")));
            sFullRemotePath = @"\\" + sSmbServer + @"\" + sSmbShare + @"\" + DateTime.Now.ToString("yyyy") + @"\" + DateTime.Now.ToString("MM") + @"\";
        }

        private void zzzz_Load(object sender, EventArgs e)
        {
        }
    }
}
