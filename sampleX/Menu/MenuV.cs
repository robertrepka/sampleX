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
using System.Runtime.InteropServices;

using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.HSSF.Util;
using NPOI.XSSF.Util;
using NPOI.POIFS.FileSystem;
using NPOI.HPSF;

namespace sampleX
{
    public partial class MenuV : Form
    {
        private readonly RRcode RRcode = new RRcode();
        private readonly RRfun RRfun = new RRfun();
        private readonly RRdata RRdata = new RRdata();

        string sSql;
        public MenuV()
        {
            InitializeComponent();
        }

        private void MenuV_Load(object sender, EventArgs e)
        {
            this.Text = RRvar.sHeader;
            lStatus.Text = "sampleX - " + RRvar.sFullName;
            RRcode.Front();
        }

        private void ChildFormClosedFull(object sender, EventArgs e)
        {
            RRcode.FadeIn(this);
            this.Visible = true;
            RRcode.Front();
        }

        private void ChildFormClosedFullNoFade(object sender, EventArgs e)
        {
            this.Enabled = true;
            RRcode.Front();
        }

        private void MenuV_Shown(object sender, EventArgs e)
        {
            RRcode.FadeIn(this);
            RRcode.Front();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            RRfun.ShowMyInfoToolTip(pictureBox1.Location.X + 50, pictureBox1.Location.Y + 50, this);
        }

        private void bPassCh_Click(object sender, EventArgs e)
        {
            Form PassChange = new PassChange();
            this.Enabled = false;
            PassChange.Closed += new EventHandler(ChildFormClosedFullNoFade);
            PassChange.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RRcode.FadeOut(this);
            this.Visible = false;
            Form DataB = new DataB();
            DataB.Closed += new EventHandler(ChildFormClosedFull);
            RRvar.sHeader = "sampleX - meranie a výsledky";
            DataB.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sLabc = "";
            string s = "";
            RRvar.sTemp = sLabc;
            
            if (ShowInputDialog(ref sLabc) == DialogResult.OK)
            {
                RRvar.sTemp = sLabc;
                if (Convert.ToInt16(RRdata.sSqlResult(RRvar.sTemp, 1, 1)) == 0)
                {
                    MessageBox.Show("Nenašiel som...", "Hľadanie", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    s = " SELECT id, labc, rok FROM labc WHERE " +
                    " labc = '" + RRvar.sTemp1 + "' AND " +
                    " rok = '" + RRvar.sTemp2 + "';";

                    RRdata.MatrixFill(s, true);

                    RRvar.sTemp1 = RRdata.MatrixRead(0, 0);
                   
                    RRcode.FadeOut(this);
                    this.Visible = false;

                    RRvar.iFilterMeranie = 0;
                    Form DataC = new DataC();
                    DataC.Closed += new EventHandler(ChildFormClosedFull);
                    DataC.Show();
                }
            }
        }

        private static DialogResult ShowInputDialog(ref string input)
        {
            System.Drawing.Size size = new System.Drawing.Size(165, 70);
            Form inputBox = new Form();
            inputBox.TopMost = true;
            inputBox.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            inputBox.ControlBox = false;
            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            inputBox.MinimizeBox = false;
            inputBox.ShowIcon = false;
            inputBox.ShowInTaskbar = false;
            inputBox.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            inputBox.StartPosition = FormStartPosition.CenterParent;
            inputBox.ShowInTaskbar = false;
            inputBox.AutoSize = false;
            inputBox.ClientSize = size;
            inputBox.Text = "Laboratórne číslo";

            System.Windows.Forms.NumericUpDown nud1 = new NumericUpDown();
            nud1.Minimum = 1;
            nud1.Maximum = 10000;
            nud1.Size = new System.Drawing.Size(75, 25);
            nud1.Location = new System.Drawing.Point(5, 5);
            nud1.Font = new Font("Segoe UI", 11);
            inputBox.Controls.Add(nud1);

            System.Windows.Forms.NumericUpDown nud2 = new NumericUpDown();
            nud2.Minimum = 2020;
            nud2.Maximum = 2100;
            nud2.Size = new System.Drawing.Size(75, 25);
            nud2.Location = new System.Drawing.Point(85, 5);
            nud2.Font = new Font("Segoe UI", 11);
            nud2.Value = Convert.ToDecimal(RRvar.iRok);
            inputBox.Controls.Add(nud2);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 30);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(5, 35);
            okButton.Font = new Font("Segoe UI", 10);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 30);
            cancelButton.Text = "&Zruš";
            cancelButton.Location = new System.Drawing.Point(85, 35);
            cancelButton.Font = new Font("Segoe UI", 10);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            string s = " SELECT COUNT(*) FROM labc, data WHERE data.labc = labc.id AND " + 
            " labc.labc = '" + nud1.Value.ToString() + "' AND " + 
            "labc.rok = '" + nud2.Value.ToString() + "';";
            RRvar.sTemp1 = nud1.Value.ToString();
            RRvar.sTemp2 = nud2.Value.ToString();
            input = s;
            return result;
        }

        private void bExcel_Click(object sender, EventArgs e)
        {
            RRcode.FadeOut(this);
            this.Visible = false;
            Form FilterE = new FilterE();
            FilterE.Closed += new EventHandler(ChildFormClosedFull);
            RRvar.sHeader = "Generovanie šablóny pre MS Excel";
            RRvar.bShowExportPatternData = true;
            FilterE.Show();
        }

        private void bImport_Click(object sender, EventArgs e)
        {
            string sFile = "";
            string sPath = "";
           
            OpenFileDialog od = new OpenFileDialog();
                    
            try {
                sPath = RRcode.RegRead("sampleX", "XlsPath");
            } catch {}

            if (sPath.Length < 3) { sPath = @"c:\"; }

            od.Filter = "XLS súbory (*.xls)|*.xls|Všetky súbory (*.*)|*.*";
            od.Title = "Vyber súbor s nameranými hodnotami";
            od.FileName = "";
            od.InitialDirectory = sPath;

            DialogResult result = od.ShowDialog();

            if (result == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(od.FileName);
                
                sPath = fi.DirectoryName;
                sFile = fi.Name;
                try
                {
                    RRcode.RegWrite("sampleX", "XlsPath", fi.DirectoryName);
                }
                catch { }

                RRvar.sTemp9 = sPath + @"\" + sFile;
                
                RRcode.FadeOut(this);
                this.Visible = false;
                Form ImportE = new ImportE();
                ImportE.Closed += new EventHandler(ChildFormClosedFull);
                RRvar.sHeader = "Import nameraných výsledkov";
                ImportE.Show();
            }  
        }
    }
}



