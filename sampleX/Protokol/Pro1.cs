#region USING
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
using MySql.Data.MySqlClient;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.HSSF.Util;
using NPOI.XSSF.Util;
using NPOI.POIFS.FileSystem;
using NPOI.HPSF;
#endregion
namespace sampleX
{
    public partial class Pro1 : Form
    {
        #region DEKLARACIE
        private readonly RRcode RRcode = new RRcode();
        private readonly RRfun RRfun = new RRfun();
        private readonly RRdata RRdata = new RRdata();
        private readonly RRsql RRsql = new RRsql();


        HSSFWorkbook xBook = new HSSFWorkbook();
        //HSSFWorkbook xBook;
        ICell xCell;
        ISheet xSheet;
        IRow r;
        int iRow = 0;
        int iCol = 0;
        int iCount = 0;
        int iSheetNameToCreate = 1;
        int iRowToInitializeOnStart = 100;
        DataTable dtOdberName;
        DataTable dtResult;
        DataTable dtBoss;
        MySqlCommand myCommand;
        MySqlDataAdapter MyAdapter;
        MySqlConnection con = new MySqlConnection(RRvar.sConStr);


        #endregion
        #region FORM
        public Pro1()
        {
            InitializeComponent();
        }

        private void Pro1_Load(object sender, EventArgs e)
        {

            RRcode.Log(this.Text);
            this.Text = RRvar.sHeader;
            lStatus.Text = "sampleX - " + RRvar.sFullName;
            iCount = RRvar.Matrix4.Count;
            cOdberAkr.SelectedIndex = 0;
            LoadVariables();
            RRcode.Front();

            FilldtOdberName("select id1 as id, fullname from f_auth_refe1 where value='o' order by fullname");
            cOdberName.DisplayMember = "fullname";
            cOdberName.ValueMember = "id";
            cOdberName.DataSource = dtOdberName;
            cOdberName.SelectedIndex = 0;

            FilldtResult("select id1 as id, fullname from f_auth_refe1 fullname where value='p-v' order by fullname");
            cResult.DisplayMember = "fullname";
            cResult.ValueMember = "id";
            cResult.DataSource = dtResult;
            cResult.SelectedIndex = 0;

            FilldtBoss("select id1 as id, fullname from f_auth_refe1 where value='p-p' order by fullname");
            cBoss.DisplayMember = "fullname";
            cBoss.ValueMember = "id";
            cBoss.DataSource = dtBoss;
            cBoss.SelectedIndex = 0;

        }

        private void Pro1_Shown(object sender, EventArgs e)
        {
            RRcode.FadeIn(this);
            RRcode.Front();
        }

        private void FilldtOdberName(string sSql)
        {
            myCommand = new MySqlCommand(sSql, con);
            MyAdapter = new MySqlDataAdapter(myCommand);
            dtOdberName = new DataTable();
            con.Open();
            MyAdapter.Fill(dtOdberName);
            con.Close();
            MyAdapter.Dispose();
        }
        private void FilldtResult(string sSql)
        {
            myCommand = new MySqlCommand(sSql, con);
            MyAdapter = new MySqlDataAdapter(myCommand);
            dtResult = new DataTable();
            con.Open();
            MyAdapter.Fill(dtResult);
            con.Close();
            MyAdapter.Dispose();
        }
        private void FilldtBoss(string sSql)
        {
            myCommand = new MySqlCommand(sSql, con);
            MyAdapter = new MySqlDataAdapter(myCommand);
            dtBoss = new DataTable();
            con.Open();
            MyAdapter.Fill(dtBoss);
            con.Close();
            MyAdapter.Dispose();
        }

        private void bOdberName_Click(object sender, EventArgs e)
        {
            tOdber.Text = cOdberName.Text;
        }

        private void bResult_Click(object sender, EventArgs e)
        {
            tResult1.Text = cResult.Text;
            tResult2.Text = RRsql.RunSqlReturn("select post from refe where fullname = '" + cResult.Text + "'");
        }

        private void bBoss_Click(object sender, EventArgs e)
        {
            tBoss1.Text = cBoss.Text;
            tBoss2.Text = RRsql.RunSqlReturn("select post from refe where fullname = '" + cBoss.Text + "'");
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            RRfun.ShowMyInfoToolTip(pictureBox1.Location.X + 50, pictureBox1.Location.Y + 50, this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool b = true;

            tOdber.BackColor = Color.White;
            tResult1.BackColor = Color.White;
            tResult2.BackColor = Color.White;
            tBoss1.BackColor = Color.White;
            tBoss2.BackColor = Color.White;

            if (tOdber.Text.Length == 0)
            {
                tOdber.BackColor = Color.Yellow;
                b = false;
            }

            if (tResult1.Text.Length == 0)
            {
                tResult1.BackColor = Color.Yellow;
                b = false;
            }

            if (tResult2.Text.Length == 0)
            {
                tResult2.BackColor = Color.Yellow;
                b = false;
            }

            if (tBoss1.Text.Length == 0)
            {
                tBoss1.BackColor = Color.Yellow;
                b = false;
            }

            if (tBoss2.Text.Length == 0)
            {
                tBoss2.BackColor = Color.Yellow;
                b = false;
            }

            if (b)
            {
                RRcode.Log(this.Text);
                xBook = new HSSFWorkbook();
                Typ1();
            }
        }

        private void nu1_ValueChanged(object sender, EventArgs e)
        {
            RRcode.RegWrite("Proto1", nu1.Value.ToString());
        }

        private void nu2_ValueChanged(object sender, EventArgs e)
        {
            RRcode.RegWrite("Proto2", nu2.Value.ToString());
        }

        private void nu3_ValueChanged(object sender, EventArgs e)
        {
            RRcode.RegWrite("Proto3", nu3.Value.ToString());
        }

        private void nu4_ValueChanged(object sender, EventArgs e)
        {
            RRcode.RegWrite("Proto4", nu4.Value.ToString());
        }

        private void nuR_ValueChanged(object sender, EventArgs e)
        {
            RRcode.RegWrite("ProtoR", nuR.Value.ToString());
        }

        private void nuC_ValueChanged(object sender, EventArgs e)
        {
            RRcode.RegWrite("ProtoC", nuC.Value.ToString());
        }

        private void nuF2_ValueChanged(object sender, EventArgs e)
        {
            RRcode.RegWrite("ProtoF2", nuF2.Value.ToString());
        }

        private void nuF1_ValueChanged(object sender, EventArgs e)
        {
            RRcode.RegWrite("ProtoF1", nuF1.Value.ToString());
        }

        #endregion
        #region FUNKCIE
        public void LoadVariables()
        {
            try
            {
                nu1.Value = Convert.ToInt32(RRcode.RegRead("Proto1"));
            }
            catch
            {
                RRcode.RegWrite("Proto1", nu1.Value.ToString());
            }

            try
            {
                nu2.Value = Convert.ToInt32(RRcode.RegRead("Proto2"));
            }
            catch
            {
                RRcode.RegWrite("Proto2", nu2.Value.ToString());
            }

            try
            {
                nu3.Value = Convert.ToInt32(RRcode.RegRead("Proto3"));
            }
            catch
            {
                RRcode.RegWrite("Proto3", nu3.Value.ToString());
            }

            try
            {
                nu4.Value = Convert.ToInt32(RRcode.RegRead("Proto4"));
            }
            catch
            {
                RRcode.RegWrite("Proto4", nu4.Value.ToString());
            }

            try
            {
                nuC.Value = Convert.ToInt32(RRcode.RegRead("ProtoC"));
            }
            catch
            {
                RRcode.RegWrite("ProtoC", nuC.Value.ToString());
            }

            try
            {
                nuR.Value = Convert.ToInt32(RRcode.RegRead("ProtoR"));
            }
            catch
            {
                RRcode.RegWrite("ProtoR", nuR.Value.ToString());
            }

            try
            {
                nuF1.Value = Convert.ToInt32(RRcode.RegRead("ProtoF1"));
            }
            catch
            {
                RRcode.RegWrite("ProtoF1", nuF1.Value.ToString());
            }

            try
            {
                nuF2.Value = Convert.ToInt32(RRcode.RegRead("ProtoF2"));
            }
            catch
            {
                RRcode.RegWrite("ProtoF2", nuF2.Value.ToString());
            }
        }

        private void SaveProtokol()
        {
            var xDocInfo = NPOI.HPSF.PropertySetFactory.CreateDocumentSummaryInformation();
            var xInfo = NPOI.HPSF.PropertySetFactory.CreateSummaryInformation();
            xInfo.Author = "sampleX © 2022 Róbert Repka";
            xInfo.Subject = "sampleX - výstupný protokol";
            xInfo.Comments = "robert@repka.org\r\n+421917799260";
            xInfo.Keywords = "Protokol";
            xDocInfo.Company = "Štátny geologický ústav Dionýza Štúra, Odbor geoanalytických laboratórií, Spišská Nová Ves";

            xBook.DocumentSummaryInformation = xDocInfo;
            xBook.SummaryInformation = xInfo;

            System.Windows.Forms.SaveFileDialog SD = new System.Windows.Forms.SaveFileDialog();
            SD.Title = "Export XLS šablóny";
            SD.RestoreDirectory = true;
            SD.DefaultExt = "xls";
            SD.Filter = "MS Excel (*.xls)|*.xls";
            SD.CheckPathExists = true;
            SD.FileName = "Protokol" + " - " + RRvar.iProtoNo1.ToString() + "-" + RRvar.iProtoNo2.ToString() + "___" + DateTime.Now.ToString("yyyy'-'MM'-'dd'_'HH'-'mm'-'ss") + ".xls";

            if (SD.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream stream = new FileStream(SD.FileName, FileMode.Create, FileAccess.Write))
                    {
                        xBook.Write(stream);
                    }
                }
                catch
                {
                    MessageBox.Show("Nepodarilo za mi zapísať súbor.\r\n", "Varovanie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Process proc = new Process();
            proc.StartInfo.FileName = SD.FileName;
            proc.StartInfo.UseShellExecute = true;

            try
            {
                proc.Start();
            }
            catch
            {
            }
        }

        private void InitPic(int iIndexOfPic, int iRow, int iCol)
        {
            if (iIndexOfPic == 1)
            {
                byte[] da1 = File.ReadAllBytes(Application.StartupPath + @"\" + "01.jpg");
                int ip1 = xBook.AddPicture(da1, PictureType.JPEG);
                ICreationHelper h1 = xBook.GetCreationHelper();
                IDrawing d1 = xSheet.CreateDrawingPatriarch();
                IClientAnchor a1 = h1.CreateClientAnchor();
                a1.Col1 = iCol;
                a1.Row1 = iRow;
                IPicture p1 = d1.CreatePicture(a1, ip1);
                p1.Resize(0.1 / 100 * Convert.ToDouble(nu1.Value));
            }

            if (iIndexOfPic == 2)
            {
                byte[] da2 = File.ReadAllBytes(Application.StartupPath + @"\" + "02.jpg");
                int ip2 = xBook.AddPicture(da2, PictureType.JPEG);
                ICreationHelper h2 = xBook.GetCreationHelper();
                IDrawing d2 = xSheet.CreateDrawingPatriarch();
                IClientAnchor a2 = h2.CreateClientAnchor();
                a2.Col1 = iCol;
                a2.Row1 = iRow;
                IPicture p2 = d2.CreatePicture(a2, ip2);
                p2.Resize(0.1 / 100 * Convert.ToDouble(nu2.Value));
            }

            if (iIndexOfPic == 3)
            {
                byte[] da3 = File.ReadAllBytes(Application.StartupPath + @"\" + "03.jpg");
                int ip3 = xBook.AddPicture(da3, PictureType.JPEG);
                ICreationHelper h3 = xBook.GetCreationHelper();
                IDrawing d3 = xSheet.CreateDrawingPatriarch();
                IClientAnchor a3 = h3.CreateClientAnchor();
                a3.Col1 = iCol;
                a3.Row1 = iRow;
                IPicture p3 = d3.CreatePicture(a3, ip3);
                p3.Resize(0.1 / 100 * Convert.ToDouble(nu3.Value));
            }

            if (iIndexOfPic == 4)
            {
                byte[] da4 = File.ReadAllBytes(Application.StartupPath + @"\" + "04.jpg");
                int ip4 = xBook.AddPicture(da4, PictureType.JPEG);
                ICreationHelper h4 = xBook.GetCreationHelper();
                IDrawing d4 = xSheet.CreateDrawingPatriarch();
                IClientAnchor a4 = h4.CreateClientAnchor();
                a4.Col1 = iCol;
                a4.Row1 = iRow;
                IPicture p4 = d4.CreatePicture(a4, ip4);
                p4.Resize(0.1 / 100 * Convert.ToDouble(nu4.Value));
            }
        }

        private void InitXLS()
        {
            string sSheetNameToCreate = "";
            if (iSheetNameToCreate < 10)
            {
                sSheetNameToCreate = "0" + iSheetNameToCreate.ToString();
            }
            else
            {
                sSheetNameToCreate = iSheetNameToCreate.ToString();
            }
            iSheetNameToCreate++;
            xSheet = xBook.CreateSheet(sSheetNameToCreate);
            xSheet.PrintSetup.PaperSize = (short)PaperSize.A4 + 1;
            xSheet.SetMargin(MarginType.LeftMargin, (short)1 / 2.54);
            xSheet.SetMargin(MarginType.RightMargin, (short)1 / 2.54 / 2);
            xSheet.SetMargin(MarginType.TopMargin, (short)1 / 2.54);
            xSheet.SetMargin(MarginType.BottomMargin, (short)1 / 2.54);
            xSheet.SetMargin(MarginType.HeaderMargin, (short)1 / 2.54);
            xSheet.SetMargin(MarginType.FooterMargin, (short)1 / 2.54);
            xSheet.DefaultRowHeight = (short)(nuR.Value * 10);
            xSheet.FitToPage = false;
            HSSFFont myFont = (HSSFFont)xBook.CreateFont();
            myFont.FontName = "Arial";
            myFont.FontHeightInPoints = (short)(nuF1.Value); ;
            HSSFCellStyle myStyle = (HSSFCellStyle)xBook.CreateCellStyle();
            myStyle.WrapText = false;
            myStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Left;
            myStyle.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
            myStyle.SetFont(myFont);
            for (int k = 0; k < 25; k++)
            {
                xSheet.SetDefaultColumnStyle(k, myStyle);
            }

            for (int i = 0; i < iRowToInitializeOnStart; i++)
            {
                r = xSheet.CreateRow(i);
                r.Height = (short)(nuR.Value * 10);
                for (int j = 0; j < 30; j++)
                {
                    xCell = r.CreateCell(j);
                }
            }

            for (int i = 0; i < 50; i++)
            {
                xSheet.SetColumnWidth(i, (short)nuC.Value * 23);
            }
        }

        private string sConfigValue(string sItem)
        {
            string sValue = "";
            int iConfig = RRvar.Matrix2.Count;
            for (int i = 0; i < iConfig; i++)
            {
                if (RRdata.MatrixRead(2, i, 0) == sItem)
                {
                    sValue = RRdata.MatrixRead(2, i, 1);
                    break;
                }

            }
            return sValue;
        }

        private int iColumnToNumber(string sChar)
        {
            int i = 0;

            switch (sChar)
            {
                case "A":
                    i = 0;
                    break;
                case "B":
                    i = 1;
                    break;
                case "C":
                    i = 2;
                    break;
                case "D":
                    i = 3;
                    break;
                case "E":
                    i = 4;
                    break;
                case "F":
                    i = 5;
                    break;
                case "G":
                    i = 6;
                    break;
                case "H":
                    i = 7;
                    break;
                case "I":
                    i = 8;
                    break;
                case "J":
                    i = 9;
                    break;
                case "K":
                    i = 10;
                    break;
                case "L":
                    i = 11;
                    break;
                case "M":
                    i = 12;
                    break;
                case "N":
                    i = 13;
                    break;
                case "O":
                    i = 14;
                    break;
                case "P":
                    i = 15;
                    break;
                case "Q":
                    i = 16;
                    break;
                case "R":
                    i = 17;
                    break;
                case "S":
                    i = 18;
                    break;
                case "T":
                    i = 19;
                    break;
                case "U":
                    i = 20;
                    break;
                case "V":
                    i = 21;
                    break;
                case "W":
                    i = 22;
                    break;
                case "X":
                    i = 23;
                    break;
                case "Y":
                    i = 24;
                    break;
                case "Z":
                    i = 25;
                    break;
                default:
                    i = 0;
                    break;
            }
            return i;
        }

        // vyska riadka
        private void rSize(int iRowInExcel, short iHeight)
        {
            r = xSheet.GetRow(iRowInExcel - 1);
            r.Height = (short)(iHeight * 10);
        }

        //zluci bunky
        private void j(string sCell)
        {
            string sChar = sCell.Substring(0, 1);
            int iRow = Convert.ToInt32(sCell.Substring(1, sCell.Length - 1)) - 1;
            iCol = iColumnToNumber(sChar);
            r = xSheet.GetRow(iRow);
            xCell = r.GetCell(iCol);
            NPOI.SS.Util.CellRangeAddress cra = new NPOI.SS.Util.CellRangeAddress(iRow, iRow, iCol, iCol + 1);
            xSheet.AddMergedRegion(cra);
        }

        private void j(string sCell, int iNumberOfColumnsToAdd)
        {
            string sChar = sCell.Substring(0, 1);
            int iRow = Convert.ToInt32(sCell.Substring(1, sCell.Length - 1)) - 1;
            iCol = iColumnToNumber(sChar);
            r = xSheet.GetRow(iRow);
            xCell = r.GetCell(iCol);
            NPOI.SS.Util.CellRangeAddress cra = new NPOI.SS.Util.CellRangeAddress(iRow, iRow, iCol, iCol + iNumberOfColumnsToAdd);
            xSheet.AddMergedRegion(cra);
        }

        private void j(string sCell, int iNumberOfColumnsToAdd, int iNumberOfRowsToAdd)
        {
            string sChar = sCell.Substring(0, 1);
            int iRow = Convert.ToInt32(sCell.Substring(1, sCell.Length - 1)) - 1;
            iCol = iColumnToNumber(sChar);
            r = xSheet.GetRow(iRow);
            xCell = r.GetCell(iCol);
            NPOI.SS.Util.CellRangeAddress cra = new NPOI.SS.Util.CellRangeAddress(iRow, iRow + iNumberOfRowsToAdd, iCol, iCol + iNumberOfColumnsToAdd);
            xSheet.AddMergedRegion(cra);
        }

        //nastavi bunku aj s formatovanim
        private void w(string sCell, string sValue)
        {
            string sChar = sCell.Substring(0, 1);
            int iRow = Convert.ToInt32(sCell.Substring(1, sCell.Length - 1)) - 1;
            iCol = iColumnToNumber(sChar);
            r = xSheet.GetRow(iRow);
            xCell = r.GetCell(iCol);
            if (sValue.Length > 0)
            {
                xCell.SetCellValue(sValue);
            }
        }

        private void w(string sCell, string sValue, short iSize, bool bBold, bool bItalic, string sAligment, bool bWrap, int iLeft, int iBottom, int iRight, int iTop)
        {
            string sChar = sCell.Substring(0, 1);
            int iRow = Convert.ToInt32(sCell.Substring(1, sCell.Length - 1)) - 1;
            iCol = iColumnToNumber(sChar);
            r = xSheet.GetRow(iRow);
            xCell = r.GetCell(iCol);
            if (sValue.Length > 0)
            {
                xCell.SetCellValue(sValue);
            }

            HSSFFont myFont = (HSSFFont)xBook.CreateFont();
            myFont.FontHeightInPoints = (short)10;
            myFont.FontName = "Arial";
            myFont.FontHeightInPoints = iSize;
            if (bBold)
            {
                myFont.Boldweight = (short)NPOI.SS.UserModel.FontBoldWeight.Bold;
            }
            else
            {
                myFont.Boldweight = (short)NPOI.SS.UserModel.FontBoldWeight.Normal;
            }


            if (bItalic)
            {
                myFont.IsItalic = true;
            }
            else
            {
                myFont.IsItalic = false;
            }

            HSSFCellStyle myStyle = (HSSFCellStyle)xBook.CreateCellStyle();
            myStyle.WrapText = false;
            myStyle.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;

            if (sAligment.ToLower() == "left")
            {
                myStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Left;
            }

            if (sAligment.ToLower() == "center")
            {
                myStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
            }

            if (sAligment.ToLower() == "right")
            {
                myStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Right;
            }

            if (sAligment.ToLower() == "topright")
            {
                myStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Right;
                myStyle.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Top;
            }


            myStyle.WrapText = bWrap;
            myStyle.SetFont(myFont);

            switch (iLeft)
            {
                case 0:
                    myStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.None;
                    break;
                case 1:
                    myStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.Hair;
                    break;
                case 2:
                    myStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.Medium;
                    break;
                case 3:
                    myStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thick;
                    break;
                case 4:
                    myStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.Double;
                    break;
                case 5:
                    myStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.Dotted;
                    break;
                default:
                    myStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.None;
                    break;
            }

            switch (iRight)
            {
                case 0:
                    myStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.None;
                    break;
                case 1:
                    myStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.Hair;
                    break;
                case 2:
                    myStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.Medium;
                    break;
                case 3:
                    myStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.Thick;
                    break;
                case 4:
                    myStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.Double;
                    break;
                case 5:
                    myStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.Dotted;
                    break;
                default:
                    myStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.None;
                    break;
            }

            switch (iTop)
            {
                case 0:
                    myStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.None;
                    break;
                case 1:
                    myStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Hair;
                    break;
                case 2:
                    myStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Medium;
                    break;
                case 3:
                    myStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Thick;
                    break;
                case 4:
                    myStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Double;
                    break;
                case 5:
                    myStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Dotted;
                    break;
                default:
                    myStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.None;
                    break;
            }


            switch (iBottom)
            {
                case 0:
                    myStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.None;
                    break;
                case 1:
                    myStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Hair;
                    break;
                case 2:
                    myStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Medium;
                    break;
                case 3:
                    myStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thick;
                    break;
                case 4:
                    myStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Double;
                    break;
                case 5:
                    myStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Dotted;
                    break;
                default:
                    myStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.None;
                    break;
            }

            xCell.CellStyle = myStyle;
        }

        private void wNum(int iC, int iR, string sValue, short iSize, bool bBold, bool bItalic, string sAligment, bool bWrap, int iLeft, int iBottom, int iRight, int iTop)
        {
            //string sChar = sCell.Substring(0, 1);
            int iRow = iR - 1;
            iCol = iC - 1;
            r = xSheet.GetRow(iRow);
            xCell = r.GetCell(iCol);
            if (sValue.Length > 0)
            {
                xCell.SetCellValue(sValue);
            }

            HSSFFont myFont = (HSSFFont)xBook.CreateFont();
            myFont.FontHeightInPoints = (short)10;
            myFont.FontName = "Arial";
            myFont.FontHeightInPoints = iSize;
            if (bBold)
            {
                myFont.Boldweight = (short)NPOI.SS.UserModel.FontBoldWeight.Bold;
            }
            else
            {
                myFont.Boldweight = (short)NPOI.SS.UserModel.FontBoldWeight.Normal;
            }

            if (bItalic)
            {
                myFont.IsItalic = true;
            }
            else
            {
                myFont.IsItalic = false;
            }

            HSSFCellStyle myStyle = (HSSFCellStyle)xBook.CreateCellStyle();
            myStyle.WrapText = false;

            if (sAligment.ToLower() == "left")
            {
                myStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Left;
            }

            if (sAligment.ToLower() == "center")
            {
                myStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
            }

            if (sAligment.ToLower() == "right")
            {
                myStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Right;
            }
            myStyle.WrapText = bWrap;
            myStyle.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
            myStyle.SetFont(myFont);

            switch (iLeft)
            {
                case 0:
                    myStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.None;
                    break;
                case 1:
                    myStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.Hair;
                    break;
                case 2:
                    myStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.Medium;
                    break;
                case 3:
                    myStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thick;
                    break;
                case 4:
                    myStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.Double;
                    break;
                case 5:
                    myStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.Dotted;
                    break;
                default:
                    myStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.None;
                    break;
            }

            switch (iRight)
            {
                case 0:
                    myStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.None;
                    break;
                case 1:
                    myStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.Hair;
                    break;
                case 2:
                    myStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.Medium;
                    break;
                case 3:
                    myStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.Thick;
                    break;
                case 4:
                    myStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.Double;
                    break;
                case 5:
                    myStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.Dotted;
                    break;
                default:
                    myStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.None;
                    break;
            }

            switch (iTop)
            {
                case 0:
                    myStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.None;
                    break;
                case 1:
                    myStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Hair;
                    break;
                case 2:
                    myStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Medium;
                    break;
                case 3:
                    myStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Thick;
                    break;
                case 4:
                    myStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Double;
                    break;
                case 5:
                    myStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Dotted;
                    break;
                default:
                    myStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.None;
                    break;
            }


            switch (iBottom)
            {
                case 0:
                    myStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.None;
                    break;
                case 1:
                    myStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Hair;
                    break;
                case 2:
                    myStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Medium;
                    break;
                case 3:
                    myStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thick;
                    break;
                case 4:
                    myStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Double;
                    break;
                case 5:
                    myStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Dotted;
                    break;
                default:
                    myStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.None;
                    break;
            }

            xCell.CellStyle = myStyle;
        }

        private void wNum(int iC, int iR, int iLeft, int iBottom, int iRight, int iTop)
        {
            int iRow = iR - 1;
            iCol = iC - 1;
            r = xSheet.GetRow(iRow);
            xCell = r.GetCell(iCol);

            HSSFCellStyle myStyle = (HSSFCellStyle)xBook.CreateCellStyle();
            myStyle.WrapText = false;

            switch (iLeft)
            {
                case 0:
                    myStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.None;
                    break;
                case 1:
                    myStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.Hair;
                    break;
                case 2:
                    myStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.Medium;
                    break;
                case 3:
                    myStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thick;
                    break;
                case 4:
                    myStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.Double;
                    break;
                case 5:
                    myStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.Dotted;
                    break;
                default:
                    myStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.None;
                    break;
            }

            switch (iRight)
            {
                case 0:
                    myStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.None;
                    break;
                case 1:
                    myStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.Hair;
                    break;
                case 2:
                    myStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.Medium;
                    break;
                case 3:
                    myStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.Thick;
                    break;
                case 4:
                    myStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.Double;
                    break;
                case 5:
                    myStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.Dotted;
                    break;
                default:
                    myStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.None;
                    break;
            }

            switch (iTop)
            {
                case 0:
                    myStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.None;
                    break;
                case 1:
                    myStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Hair;
                    break;
                case 2:
                    myStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Medium;
                    break;
                case 3:
                    myStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Thick;
                    break;
                case 4:
                    myStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Double;
                    break;
                case 5:
                    myStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Dotted;
                    break;
                default:
                    myStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.None;
                    break;
            }

            switch (iBottom)
            {
                case 0:
                    myStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.None;
                    break;
                case 1:
                    myStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Hair;
                    break;
                case 2:
                    myStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Medium;
                    break;
                case 3:
                    myStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thick;
                    break;
                case 4:
                    myStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Double;
                    break;
                case 5:
                    myStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Dotted;
                    break;
                default:
                    myStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.None;
                    break;
            }

            xCell.CellStyle = myStyle;
        }

        private string myDateFormatConvert(string sDate)
        {
            string s = "";
            string sY = "";
            string sM = "";
            string sD = "";

            if (sDate.Length == 10)
            {
                sY = sDate.Substring(0, 4);
                sM = sDate.Substring(5, 2);
                sD = sDate.Substring(8, 2);
                s = sD + "." + sM + "." + sY;
            }
            return s;
        }
        #endregion
        #region DATA S PRECHODOM NA NOVU STRANU
        //Nastavi cislo riadku a stranu
        private void Typ1Page(int i)
        {
            string s = "";
            if (iRow < 60)
            {
                iRow++;
            }
            else
            {
                InitXLS();

                rSize(1, 40);
                s = "Protokol o skúške č. " + RRvar.iProtoNo1.ToString() + "/" + RRvar.iProtoNo2.ToString();
                w("L1", s, (short)(nuF2.Value), true, false, "center", false, 0, 0, 0, 0);

                rSize(3, 40);
                s = "Výsledky skúšok";
                w("L3", s, (short)(nuF2.Value - 2), true, false, "center", false, 0, 0, 0, 0);

                w("W2", "Strana 1 z počtu 1", (short)(nuF1.Value), false, false, "right", false, 0, 0, 0, 0);
                w("W3", "Počet príloh: " + nuPriloha.Value.ToString(), (short)(nuF1.Value), false, false, "topright", false, 0, 0, 0, 0);

                iRow = 5;
                Typ1TableHeader(i, true);

            }
        }
        //Hlavicka tabulky
        private void Typ1TableHeader(int i, bool bSplitOnNewPage)
        {
            string s = "";
            string ss = "";

            for (int l = 1; l < 23; l++)
            {
                wNum(l + 1, iRow, 0, 1, 0, 1);
            }

            s = "  Laboratórne číslo " + RRdata.MatrixRead(4, i, 0) + " / " + RRdata.MatrixRead(4, i, 1);
            if (bSplitOnNewPage)
            {
                s += " - pokračovanie";
            }

            ss = "A" + (iRow).ToString();
            w(ss, s, (short)(nuF1.Value + 1), true, false, "left", false, 1, 1, 0, 1);

            if (RRdata.MatrixRead(4, i, 2).Length > 0)
            {
                s = "Označenie: " + RRdata.MatrixRead(4, i, 2);
            }
            else
            {
                s = " " + RRdata.MatrixRead(4, i, 2);
            }
            ss = "W" + (iRow).ToString();
            w(ss, s, (short)(nuF1.Value), false, false, "right", false, 0, 1, 1, 1);

            iRow++;

            ss = "A" + (iRow).ToString();
            j(ss, 4, 1);
            w(ss, "  Parameter", (short)(nuF1.Value - 1), false, true, "left", true, 1, 0, 0, 0);
            ss = "A" + (iRow + 1).ToString();
            w(ss, "  Parameter", (short)(nuF1.Value - 1), false, true, "left", true, 1, 0, 0, 0);

            ss = "H" + (iRow).ToString();
            j(ss, 2, 1);
            w(ss, "Hodnota", (short)(nuF1.Value - 1), false, true, "center", true, 1, 0, 0, 0);
            ss = "H" + (iRow + 1).ToString();
            w(ss, "Hodnota", (short)(nuF1.Value - 1), false, true, "center", true, 1, 0, 0, 0);

            ss = "F" + (iRow).ToString();
            j(ss, 1, 1);
            w(ss, "Jednotka", (short)(nuF1.Value - 1), false, true, "center", true, 1, 0, 0, 0);
            ss = "F" + (iRow + 1).ToString();
            w(ss, "Jednotka", (short)(nuF1.Value - 1), false, true, "center", true, 1, 0, 0, 0);

            ss = "K" + (iRow).ToString();
            j(ss, 1, 1);
            w(ss, "Rozšírená neistota[%]", (short)(nuF1.Value - 1), false, true, "center", true, 1, 0, 0, 0);
            ss = "K" + (iRow + 1).ToString();
            w(ss, "Rozšírená neistota[%]", (short)(nuF1.Value - 1), false, true, "center", true, 1, 0, 0, 0);

            ss = "M" + (iRow).ToString();
            j(ss, 1, 1);
            w(ss, "Medza stanovenia", (short)(nuF1.Value - 1), false, true, "center", true, 1, 0, 0, 0);
            ss = "M" + (iRow + 1).ToString();
            w(ss, "Medza stanovenia", (short)(nuF1.Value - 1), false, true, "center", true, 1, 0, 0, 0);

            ss = "O" + (iRow).ToString();
            j(ss, 2, 1);
            w(ss, "Metóda", (short)(nuF1.Value - 1), false, true, "center", true, 1, 0, 0, 0);
            ss = "O" + (iRow + 1).ToString();
            w(ss, "Metóda", (short)(nuF1.Value - 1), false, true, "center", true, 1, 0, 0, 0);

            ss = "R" + (iRow).ToString();
            j(ss, 3, 1);
            w(ss, "Metodický predpis", (short)(nuF1.Value - 1), false, true, "center", true, 1, 0, 0, 0);
            ss = "R" + (iRow + 1).ToString();
            w(ss, "Metodický predpis", (short)(nuF1.Value - 1), false, true, "center", true, 1, 0, 0, 0);

            ss = "V" + (iRow).ToString();
            j(ss, 1, 1);
            w(ss, "Typ skúšky", (short)(nuF1.Value - 1), false, true, "center", true, 1, 0, 1, 0);
            ss = "V" + (iRow + 1).ToString();
            w(ss, "Typ skúšky", (short)(nuF1.Value - 1), false, true, "center", true, 1, 0, 1, 0);

            wNum(23, iRow, 0, 0, 1, 0);
            wNum(23, iRow + 1, 0, 0, 1, 0);

            iRow++;
            if (bSplitOnNewPage)
            {
                iRow++;
            }
        }
        #endregion
        #region SPODNE TEXTY S PRECHODOM NA NOVU STRANU
        //Nastavi cislo riadku a stranu
        private void Typ1PageComment(string sRow)
        {
            string s = "";
            string ss = "";
            if (iRow < 60)
            {
                iRow++;
                ss = "A" + (iRow + 1).ToString();
                w(ss, sRow);
            }
            else
            {
                InitXLS();

                rSize(1, 40);
                s = "Protokol o skúške č. " + RRvar.iProtoNo1.ToString() + "/" + RRvar.iProtoNo2.ToString();
                w("L1", s, (short)(nuF2.Value), true, false, "center", false, 0, 0, 0, 0);

                w("W2", "Strana 1 z počtu 1", (short)(nuF1.Value), false, false, "right", false, 0, 0, 0, 0);
                w("W3", "Počet príloh: " + nuPriloha.Value.ToString(), (short)(nuF1.Value), false, false, "topright", false, 0, 0, 0, 0);

                iRow = 3;
                //Typ1TableHeader(i, true);
                ss = "A" + (iRow + 1).ToString();
                w(ss, sRow);
            }
        }
        private void Typ1PageExplanatory(string sRowA, string sRowC)
        {
            string s = "";
            string ss = "";
            if (iRow < 60)
            {
                iRow++;
                ss = "A" + (iRow + 1).ToString();
                w(ss, sRowA);
                ss = "E" + (iRow + 1).ToString();
                w(ss, sRowC);
            }
            else
            {
                InitXLS();

                rSize(1, 40);
                s = "Protokol o skúške č. " + RRvar.iProtoNo1.ToString() + "/" + RRvar.iProtoNo2.ToString();
                w("L1", s, (short)(nuF2.Value), true, false, "center", false, 0, 0, 0, 0);

                w("W2", "Strana 1 z počtu 1", (short)(nuF1.Value), false, false, "right", false, 0, 0, 0, 0);
                w("W3", "Počet príloh: " + nuPriloha.Value.ToString(), (short)(nuF1.Value), false, false, "topright", false, 0, 0, 0, 0);

                iRow = 3;
                //Typ1TableHeader(i, true);
                ss = "A" + (iRow + 1).ToString();
                w(ss, sRowA);
                ss = "E" + (iRow + 1).ToString();
                w(ss, sRowC);
            }
        }
        private void Typ1PageHeaderExplanatory()
        {
            string s = "";
            string ss = "";
            if (iRow < 57)
            {
                iRow++;
                ss = "A" + (iRow + 1).ToString();
                w(ss, "Popis skratiek:", (short)(nuF1.Value), false, true, "left", false, 0, 0, 0, 0);
            }
            else
            {
                InitXLS();

                rSize(1, 40);
                s = "Protokol o skúške č. " + RRvar.iProtoNo1.ToString() + "/" + RRvar.iProtoNo2.ToString();
                w("L1", s, (short)(nuF2.Value), true, false, "center", false, 0, 0, 0, 0);

                w("W2", "Strana 1 z počtu 1", (short)(nuF1.Value), false, false, "right", false, 0, 0, 0, 0);
                w("W3", "Počet príloh: " + nuPriloha.Value.ToString(), (short)(nuF1.Value), false, false, "topright", false, 0, 0, 0, 0);

                iRow = 3;
                //Typ1TableHeader(i, true);
                ss = "A" + (iRow + 1).ToString();
                w(ss, "Popis skratiek:", (short)(nuF1.Value), false, true, "left", false, 0, 0, 0, 0);
            }
        }
        private void Typ1PagePersons()
        {
            string s = "";
            string ss = "";
            if (iRow < 52)
            {
                iRow++;
                ss = "A" + (iRow).ToString();
                w(ss, "Výsledky preskúmal a schválil:", (short)(nuF1.Value), false, true, "left", false, 0, 0, 0, 0);
                ss = "A" + (iRow + 6).ToString();
                w(ss, "Protokol o skúške schválil:", (short)(nuF1.Value), false, true, "left", false, 0, 0, 0, 0);

                ss = "R" + (iRow + 1).ToString();
                w(ss, tResult1.Text, (short)(nuF1.Value), true, false, "center", false, 0, 0, 0, 0);
                ss = "R" + (iRow + 2).ToString();
                w(ss, tResult2.Text, (short)(nuF1.Value), false, false, "center", false, 0, 0, 0, 0);

                ss = "R" + (iRow + 7).ToString();
                w(ss, tBoss1.Text, (short)(nuF1.Value), true, false, "center", false, 0, 0, 0, 0);
                ss = "R" + (iRow + 8).ToString();
                w(ss, tBoss2.Text, (short)(nuF1.Value), false, false, "center", false, 0, 0, 0, 0);
            }
            else
            {
                InitXLS();

                rSize(1, 40);
                s = "Protokol o skúške č. " + RRvar.iProtoNo1.ToString() + "/" + RRvar.iProtoNo2.ToString();
                w("L1", s, (short)(nuF2.Value), true, false, "center", false, 0, 0, 0, 0);

                w("W2", "Strana 1 z počtu 1", (short)(nuF1.Value), false, false, "right", false, 0, 0, 0, 0);
                w("W3", "Počet príloh: " + nuPriloha.Value.ToString(), (short)(nuF1.Value), false, false, "topright", false, 0, 0, 0, 0);

                iRow = 3;

                ss = "A" + (iRow).ToString();
                w(ss, "Výsledky preskúmal a schválil:", (short)(nuF1.Value), false, true, "left", false, 0, 0, 0, 0);
                ss = "A" + (iRow + 6).ToString();
                w(ss, "Protokol o skúške schválil:", (short)(nuF1.Value), false, true, "left", false, 0, 0, 0, 0);

                ss = "R" + (iRow + 1).ToString();
                w(ss, tResult1.Text, (short)(nuF1.Value), true, false, "center", false, 0, 0, 0, 0);
                ss = "R" + (iRow + 2).ToString();
                w(ss, tResult2.Text, (short)(nuF1.Value), false, false, "center", false, 0, 0, 0, 0);

                ss = "R" + (iRow + 7).ToString();
                w(ss, tBoss1.Text, (short)(nuF1.Value), true, false, "center", false, 0, 0, 0, 0);
                ss = "R" + (iRow + 8).ToString();
                w(ss, tBoss2.Text, (short)(nuF1.Value), false, false, "center", false, 0, 0, 0, 0);

            }
        }

        private void Typ1(int i, bool bSplitOnNewPage)
        {
            string s = "";
            string ss = "";

            for (int l = 1; l < 23; l++)
            {
                wNum(l + 1, iRow, 0, 1, 0, 1);
            }

            s = "  Laboratórne číslo " + RRdata.MatrixRead(4, i, 0) + " / " + RRdata.MatrixRead(4, i, 1);
            if (bSplitOnNewPage)
            {
                s += " - pokračovanie";
            }

            ss = "A" + (iRow).ToString();
            w(ss, s, (short)(nuF1.Value + 1), true, false, "left", false, 1, 1, 0, 1);

            if (RRdata.MatrixRead(4, i, 2).Length > 0)
            {
                s = "Označenie: " + RRdata.MatrixRead(4, i, 2);
            }
            else
            {
                s = " " + RRdata.MatrixRead(4, i, 2);
            }
            ss = "W" + (iRow).ToString();
            w(ss, s, (short)(nuF1.Value), false, false, "right", false, 0, 1, 1, 1);

            iRow++;

            ss = "A" + (iRow).ToString();
            j(ss, 4, 1);
            w(ss, "  Parameter", (short)(nuF1.Value - 1), false, true, "left", true, 1, 0, 0, 0);
            ss = "A" + (iRow + 1).ToString();
            w(ss, "  Parameter", (short)(nuF1.Value - 1), false, true, "left", true, 1, 0, 0, 0);

            ss = "H" + (iRow).ToString();
            j(ss, 2, 1);
            w(ss, "Hodnota", (short)(nuF1.Value - 1), false, true, "center", true, 1, 0, 0, 0);
            ss = "H" + (iRow + 1).ToString();
            w(ss, "Hodnota", (short)(nuF1.Value - 1), false, true, "center", true, 1, 0, 0, 0);

            ss = "F" + (iRow).ToString();
            j(ss, 1, 1);
            w(ss, "Jednotka", (short)(nuF1.Value - 1), false, true, "center", true, 1, 0, 0, 0);
            ss = "F" + (iRow + 1).ToString();
            w(ss, "Jednotka", (short)(nuF1.Value - 1), false, true, "center", true, 1, 0, 0, 0);

            ss = "K" + (iRow).ToString();
            j(ss, 1, 1);
            w(ss, "Rozšírená neistota[%]", (short)(nuF1.Value - 1), false, true, "center", true, 1, 0, 0, 0);
            ss = "K" + (iRow + 1).ToString();
            w(ss, "Rozšírená neistota[%]", (short)(nuF1.Value - 1), false, true, "center", true, 1, 0, 0, 0);

            ss = "M" + (iRow).ToString();
            j(ss, 1, 1);
            w(ss, "Medza stanovenia", (short)(nuF1.Value - 1), false, true, "center", true, 1, 0, 0, 0);
            ss = "M" + (iRow + 1).ToString();
            w(ss, "Medza stanovenia", (short)(nuF1.Value - 1), false, true, "center", true, 1, 0, 0, 0);

            ss = "O" + (iRow).ToString();
            j(ss, 2, 1);
            w(ss, "Metóda", (short)(nuF1.Value - 1), false, true, "center", true, 1, 0, 0, 0);
            ss = "O" + (iRow + 1).ToString();
            w(ss, "Metóda", (short)(nuF1.Value - 1), false, true, "center", true, 1, 0, 0, 0);

            ss = "R" + (iRow).ToString();
            j(ss, 3, 1);
            w(ss, "Metodický predpis", (short)(nuF1.Value - 1), false, true, "center", true, 1, 0, 0, 0);
            ss = "R" + (iRow + 1).ToString();
            w(ss, "Metodický predpis", (short)(nuF1.Value - 1), false, true, "center", true, 1, 0, 0, 0);

            ss = "V" + (iRow).ToString();
            j(ss, 1, 1);
            w(ss, "Typ skúšky", (short)(nuF1.Value - 1), false, true, "center", true, 1, 0, 1, 0);
            ss = "V" + (iRow + 1).ToString();
            w(ss, "Typ skúšky", (short)(nuF1.Value - 1), false, true, "center", true, 1, 0, 1, 0);

            wNum(23, iRow, 0, 0, 1, 0);
            wNum(23, iRow + 1, 0, 0, 1, 0);

            iRow++;
            if (bSplitOnNewPage)
            {
                iRow++;
            }
        }
        #endregion
        private void Typ1()
        {
            string s;
            string ss;
            iSheetNameToCreate = 1;
            InitXLS();
            #region LOGO NAZOV FIRMY
            for (int i = 0; i < 5; i++)
            {
                rSize(i + 1, (short)(nuR.Value - 4));
            }
            RRdata.MatrixFill(2, "SELECT item, value FROM config;", true);
            w("D1", sConfigValue("adr01") + ", " + sConfigValue("adr10"), (short)(nuF1.Value - 1), true, false, "left", false, 0, 0, 0, 0);
            w("D2", sConfigValue("adr03") + ", " + sConfigValue("adr04"), (short)(nuF1.Value - 1), false, false, "left", false, 0, 0, 0, 0);
            w("D3", sConfigValue("adr06"), (short)(nuF1.Value - 1), false, false, "left", false, 0, 0, 0, 0);
            w("D4", sConfigValue("adr11"), (short)(nuF1.Value - 1), false, false, "left", false, 0, 0, 0, 0);
            w("D5", sConfigValue("adr07") + ", " + sConfigValue("adr08") + ", tel.: " + sConfigValue("adr09"), (short)(nuF1.Value - 1), false, false, "left", false, 0, 0, 0, 0);
            rSize(7, 40);
            #endregion
            #region LOGÁ OBRAZKY
            InitPic(1, 0, 0);
            InitPic(2, 0, 14);
            InitPic(3, 0, 17);
            #endregion
            #region HLAVICKA PROTOKOLU
            s = "Protokol o skúške č. " + RRvar.iProtoNo1.ToString() + "/" + RRvar.iProtoNo2.ToString();
            w("L7", s, (short)(nuF2.Value), true, false, "center", false, 0, 0, 0, 0);

            w("N9", "Skúška:", (short)(nuF1.Value), false, true, "left", false, 0, 0, 0, 0);
            w("N10", "Subdodávka:", (short)(nuF1.Value), false, true, "left", false, 0, 0, 0, 0);
            w("N11", "Odber:", (short)(nuF1.Value), false, true, "left", false, 0, 0, 0, 0);

            w("W9", "A - akreditovaná, N - neakreditovaná", (short)(nuF1.Value), false, false, "right", false, 0, 0, 0, 0);
            w("W10", "SA - akreditovaná, SN - neakreditovaná", (short)(nuF1.Value), false, false, "right", false, 0, 0, 0, 0);
            w("W11", "A - akreditovaný, N neakreditovaný", (short)(nuF1.Value), false, false, "right", false, 0, 0, 0, 0);

            w("A13", "Počet výtlačkov:", (short)(nuF1.Value), false, true, "left", false, 0, 0, 0, 0);
            w("A14", "Výtlačok číslo:", (short)(nuF1.Value), false, true, "left", false, 0, 0, 0, 0);
            w("A16", "Objednávateľ:", (short)(nuF1.Value), true, true, "left", false, 0, 0, 0, 0);
            w("A18", "Zodp. pracovník:", (short)(nuF1.Value), false, true, "left", false, 0, 0, 0, 0);
            w("A19", "Telefón:", (short)(nuF1.Value), false, true, "left", false, 0, 0, 0, 0);
            w("A20", "E-mail:", (short)(nuF1.Value), false, true, "left", false, 0, 0, 0, 0);
            w("A21", "Objednávka:", (short)(nuF1.Value), false, true, "left", false, 0, 0, 0, 0);
            w("A22", "Zákazka:", (short)(nuF1.Value), false, true, "left", false, 0, 0, 0, 0);
            w("A23", "Počet vzoriek:", (short)(nuF1.Value), false, true, "left", false, 0, 0, 0, 0);

            w("N20", "Dátum prevzatia vzoriek:", (short)(nuF1.Value), false, true, "left", false, 0, 0, 0, 0);
            w("N21", "Dátum vykonania skúšok od:", (short)(nuF1.Value), false, true, "left", false, 0, 0, 0, 0);
            w("N22", "Dátum vykonania skúšok do:", (short)(nuF1.Value), false, true, "left", false, 0, 0, 0, 0);
            w("N23", "Dátum vydania protokolu:", (short)(nuF1.Value), false, true, "left", false, 0, 0, 0, 0);

            w("A25", "Údaje o vzorkách:", (short)(nuF1.Value), true, true, "left", false, 0, 0, 0, 0);
            w("A26", "Matrica:", (short)(nuF1.Value), false, true, "left", false, 0, 0, 0, 0);
            w("A27", "Identif. matrice:", (short)(nuF1.Value), false, true, "left", false, 0, 0, 0, 0);

            w("N25", "Vzorky odobral:", (short)(nuF1.Value), false, true, "left", false, 0, 0, 0, 0);
            w("N26", "Miesto odberu:", (short)(nuF1.Value), false, true, "left", false, 0, 0, 0, 0);
            w("N27", "Dátum odberu:", (short)(nuF1.Value), false, true, "left", false, 0, 0, 0, 0);

            w("W13", "Strana 1 z počtu 1", (short)(nuF1.Value), false, false, "right", false, 0, 0, 0, 0);
            w("W14", "Počet príloh: " + nuPriloha.Value.ToString(), (short)(nuF1.Value), false, false, "right", false, 0, 0, 0, 0);
            #endregion
            #region DATA - HELP
            //////////////////////////////////////////////////
            // MATRIX4
            //labc 0
            //rok 1
            //ozn 2
            //labc_id 3
            //zakazka_id 4
            //////////////////////////////////////////////////
            // data - MATRIX5
            //id 0
            //labc 1
            //polozka 2
            //parameter 3
            //matrica 4
            //princip 5
            //ozn 6
            //odd 7
            //jednotka 8
            //akr 9
            //result 10
            //neistota 11
            //pozn 14
            //////////////////////////////////////////////////
            // zakazka_obj_partner - MATRIX5
            //obj_no 0
            //obj_rok 1
            //cobj 2
            //czml 3
            //obj_datum 4
            //obj_expired 5
            //obj_pozn 6
            //meno 7
            //id 8
            //labc 9
            //no 10
            //rok 11
            //ozn 12
            //obj_id 13
            //datum_dod 14
            //datum_termin 15
            //datum_start 16
            //datum_end 17
            //datum_protokol 18
            //akr 19
            //pozn 20
            //stamp 21
            //refe_id 22
            //autor 23
            //partner_id 24
            //kontakt_id 25
            //kontakt_meno 26
            //kontakt_funkcia 27
            //kontakt_tel 28
            //kontakt_email 29
            //adr1 30
            //adr2 31
            //adr3 32
            //adr4 33
            //v_matrica 34
            //v_meno 35
            //v_cas1 36
            //v_cas2 37
            //v_miesto 38
            //////////////////////////////////////////////////
            // zakazka - MATRIX6
            //nazov 0
            //ulica 1
            //psc 2
            //mesto 3
            //////////////////////////////////////////////////
            #endregion
            #region ZAKAZKA HLAVICKA
            w("E13", "3", (short)(nuF1.Value), false, false, "left", false, 0, 0, 0, 0);
            w("E14", "1", (short)(nuF1.Value), false, false, "left", false, 0, 0, 0, 0);
            w("E23", iCount.ToString(), (short)(nuF1.Value), false, false, "left", false, 0, 0, 0, 0);

            s = RRdata.MatrixRead(4, 0, 4);
            s = "SELECT * FROM zakazka_obj_partner WHERE id='" + s + "';";
            RRdata.MatrixFill(5, s, true);
            s = RRdata.MatrixRead(5, 0, 24);
            s = "SELECT nazov, ulica, psc, mesto FROM partner WHERE id='" + s + "';";
            RRdata.MatrixFill(6, s, true);
            s = RRdata.MatrixRead(6, 0, 0);
            w("E16", s, (short)(nuF1.Value), true, false, "left", false, 0, 0, 0, 0);//nazov
            ss = RRdata.MatrixRead(6, 0, 2);
            if (ss.Length == 5)
            {
                ss = ss.Substring(0, 3) + " " + ss.Substring(3, 2) + " ";
            }
            s = RRdata.MatrixRead(6, 0, 1) + ", " + ss + RRdata.MatrixRead(6, 0, 3);
            w("E17", s, (short)(nuF1.Value), false, false, "left", false, 0, 0, 0, 0);//adresa
            s = RRdata.MatrixRead(5, 0, 26);
            w("E18", s, (short)(nuF1.Value), false, false, "left", false, 0, 0, 0, 0);//kontakt
            s = RRdata.MatrixRead(5, 0, 28);
            w("E19", s, (short)(nuF1.Value), false, false, "left", false, 0, 0, 0, 0);//email
            s = RRdata.MatrixRead(5, 0, 29);
            w("E20", s, (short)(nuF1.Value), false, false, "left", false, 0, 0, 0, 0);//tel
            string sCobj = RRdata.MatrixRead(5, 0, 2);
            string sCzml = RRdata.MatrixRead(5, 0, 3);
            s = "";
            if (sCobj.Length > 0)
            {
                s = sCobj;
                if (sCzml.Length > 0)
                {
                    s += ", zmluva " + sCzml;
                }
            }
            else
            {
                if (sCzml.Length > 0)
                {
                    s = "zmluva " + sCzml;
                }
            }

            w("E21", s, (short)(nuF1.Value), false, false, "left", false, 0, 0, 0, 0);//cobj/czml
            s = RRdata.MatrixRead(5, 0, 10) + "/" + RRdata.MatrixRead(5, 0, 11);
            w("E22", s, (short)(nuF1.Value), false, false, "left", false, 0, 0, 0, 0);//cislo zakazky
            s = RRdata.MatrixRead(5, 0, 34);
            w("E27", s, (short)(nuF1.Value), false, false, "left", false, 0, 0, 0, 0);//v_matrica

            s = RRdata.MatrixRead(5, 0, 14);
            s = myDateFormatConvert(s);
            w("W20", s, (short)(nuF1.Value), false, false, "right", false, 0, 0, 0, 0);//dat dod

            s = RRdata.MatrixRead(5, 0, 16);
            s = myDateFormatConvert(s);
            w("W21", s, (short)(nuF1.Value), false, false, "right", false, 0, 0, 0, 0);//dat start

            s = RRdata.MatrixRead(5, 0, 17);
            s = myDateFormatConvert(s);
            w("W22", s, (short)(nuF1.Value), false, false, "right", false, 0, 0, 0, 0);//dat stop

            s = RRdata.MatrixRead(5, 0, 18);
            s = myDateFormatConvert(s);
            w("W23", s, (short)(nuF1.Value), false, false, "right", false, 0, 0, 0, 0);//dat prot

            //s = RRdata.MatrixRead(5, 0, 35);
            s = tOdber.Text + ", odber: " + cOdberAkr.Text;
            //s = myDateFormatConvert(s);
            w("W25", s, (short)(nuF1.Value), false, false, "right", false, 0, 0, 0, 0);//v_odobral

            s = RRdata.MatrixRead(5, 0, 38);
            //s = myDateFormatConvert(s);
            w("W27", s, (short)(nuF1.Value), false, false, "right", false, 0, 0, 0, 0);//v_miesto

            s = myDateFormatConvert(RRdata.MatrixRead(5, 0, 36));
            ss = myDateFormatConvert(RRdata.MatrixRead(5, 0, 37));
            if (ss.Length == 10 || ss != s)
            {
                s = s + " - " + ss;
            }
            w("W27", s, (short)(nuF1.Value), false, false, "right", false, 0, 0, 0, 0);//v_cas
            // MATRIX 4
            // 4 - zakazka_id
            // 3 - labc_id
            RRdata.MatrixClear(5);
            // matrice zo vetkych LC a parametrov do MATRIX5
            for (int i = 0; i < iCount; i++)
            {
                ss = RRdata.MatrixRead(4, i, 3);// pre kazdé labc_id
                int iParameterCount = Convert.ToInt16(RRsql.RunSqlReturn("SELECT count(*) FROM data WHERE labc=" + ss + ";"));
                if (iParameterCount > 0)
                {
                    RRdata.MatrixFill(5, "SELECT xmatrica.value FROM xmatrica RIGHT JOIN data ON xmatrica.id = data.matrica WHERE labc=" + ss + ";", false);
                }
            }
            // distinct matric z MATRIX5 do MATRIX6
            RRdata.MatrixClear(6);
            for (int i = 0; i < RRvar.Matrix5.Count; i++)
            {
                String[] sValue = new string[1];
                ss = RRdata.MatrixRead(5, i, 0);// pre kazdy riadok MATRIX5
                bool bNeedInsert = true;
                if (RRvar.Matrix6.Count > 0)
                {
                    for (int k = 0; k < RRvar.Matrix6.Count; k++)
                    {
                        if (RRdata.MatrixRead(6, k, 0) == ss)
                        {
                            bNeedInsert = false;
                        }
                    }
                }
                if (bNeedInsert)
                {
                    sValue[0] = ss;
                    RRdata.MatrixAdd(6, sValue, false);
                }
            }

            s = RRdata.MatrixRead(6, 0, 0);
            if (RRvar.Matrix6.Count > 1)
            {
                for (int i = 1; i < RRvar.Matrix6.Count; i++)
                {
                    s += ", " + RRdata.MatrixRead(6, i, 0);
                }
            }
            w("E26", s, (short)(nuF1.Value), false, false, "left", false, 0, 0, 0, 0);//matrica
            #endregion
            #region UDAJE
            // matrix3 - zhromazdovanie principov kvoli vysvetlivkam
            RRdata.MatrixClear(3);

            rSize(30, 40);
            w("L30", "Výsledky skúšok", (short)(nuF2.Value - 2), true, false, "center", false, 0, 0, 0, 0);
            iRow = 32;

            for (int i = 0; i < iCount; i++)
            {
                //data pre jedno labc do MATRIX5
                string sLabcId = RRdata.MatrixRead(4, i, 3);
                RRdata.MatrixFill(5, "select * from data where labc='" + sLabcId + "';", true);
                if (RRvar.Matrix5.Count > 0)
                {
                    if (iRow < 56)
                    {
                        //Hlavicka tabulky
                        Typ1TableHeader(i, false);
                    }
                    else
                    {
                        Typ1Page(i);
                    }

                    //pridavanie riadkov z data
                    for (int m = 0; m < RRvar.Matrix5.Count; m++)
                    {
                        //Nastavi cislo riadku a stranu
                        Typ1Page(i);

                        for (int n = 0; n < 23; n++)
                        {
                            wNum(n + 1, iRow, 0, 1, 0, 1);
                        }
                        ss = RRdata.MatrixRead(5, m, 3); //id parameter
                        s = RRsql.RunSqlReturn("SELECT pozn FROM xparameter where id='" + ss + "'");
                        if (s.Length == 0)
                        {
                            s = RRsql.RunSqlReturn("SELECT value FROM xparameter where id='" + ss + "'");
                        }
                        ss = "A" + (iRow).ToString();
                        j(ss, 4);
                        w(ss, "  " + s, (short)(nuF1.Value), true, false, "left", false, 1, 1, 0, 1);

                        ss = RRdata.MatrixRead(5, m, 8); //id jedn
                        s = RRsql.RunSqlReturn("SELECT value FROM xjednotka where id='" + ss + "'");
                        ss = "F" + (iRow).ToString();
                        j(ss, 1);
                        w(ss, s, (short)(nuF1.Value - 1), false, false, "center", false, 1, 1, 0, 1);
                        string sJednotka = s;

                        ss = RRdata.MatrixRead(5, m, 14); //poznamka
                        s = ss;
                        string sPozn = s.Replace(".", ",");

                        ss = RRdata.MatrixRead(5, m, 12); //medza
                        s = ss;
                        ss = "M" + (iRow).ToString();
                        string sMedza = s;

                        j(ss, 1);
                        if (s.Length > 0)
                        {
                            w(ss, s + " " + sJednotka, (short)(nuF1.Value - 1), false, false, "center", false, 1, 1, 0, 1);
                        }
                        else
                        {
                            w(ss, "", (short)(nuF1.Value - 1), false, false, "center", false, 1, 1, 0, 1);
                        }

                        string sStopa = "< " + s;

                        ss = RRdata.MatrixRead(5, m, 9); //akr
                        string sAkreditovane = ss.ToLower();
                        if (ss.ToLower() == "true")
                        {
                            s = "A";
                        }
                        else
                        {
                            s = "N";
                        }
                        ss = "V" + (iRow).ToString();
                        j(ss, 1);
                        w(ss, s, (short)(nuF1.Value), false, false, "center", false, 1, 1, 0, 1);

                        ss = RRdata.MatrixRead(5, m, 10); //hodn
                        s = ss;
                        string sHodnota = ss;
                        ///////////////////// FORMATOVANIE HODNOTY
                        if (sPozn.Length > 1)
                        {
                            s = sPozn;
                        }
                        else
                        {
                            if (s == "0")
                            {
                                s = sStopa;
                            }
                        }

                        if (sHodnota.Length == 0)
                        {
                            s = "";
                        }

                        ss = "H" + (iRow).ToString();
                        j(ss, 2);
                        w(ss, s, (short)(nuF1.Value), false, false, "center", false, 1, 1, 0, 1);

                        ss = RRdata.MatrixRead(5, m, 11); //neistota
                        s = ss;
                        ss = "K" + (iRow).ToString();
                        j(ss, 1);
                        w(ss, s, (short)(nuF1.Value), false, false, "center", false, 1, 1, 0, 1);

                        ss = RRdata.MatrixRead(5, m, 5); //princip
                        s = RRsql.RunSqlReturn("SELECT value FROM xprincip where id='" + ss + "'");
                        ss = "O" + (iRow).ToString();
                        j(ss, 2);
                        w(ss, s, (short)(nuF1.Value), false, false, "center", false, 1, 1, 0, 1);

                        bool bImHereAlready = false;
                        for (int p = 0; p < RRvar.Matrix3.Count; p++)
                        {
                            if (RRdata.MatrixRead(3, p, 0) == s)
                            {
                                bImHereAlready = true;
                            }
                        }
                        if (!bImHereAlready)
                        {
                            String[] sValue = new string[2];
                            sValue[0] = s;
                            s = RRsql.RunSqlReturn("SELECT popis FROM xprincip where value='" + s + "'");
                            sValue[1] = s;
                            RRdata.MatrixAdd(3, sValue, false);
                        }


                        ss = RRdata.MatrixRead(5, m, 6); //ozn - norma
                        if (ss.Length > 0)
                        {
                            s = RRsql.RunSqlReturn("SELECT value FROM xozn where id='" + ss + "'");
                        }
                        else
                        {
                            s = "";
                        }
                        ss = "R" + (iRow).ToString();
                        j(ss, 3);
                        w(ss, s, (short)(nuF1.Value - 1), false, false, "center", false, 1, 1, 0, 1);
                        wNum(23, iRow, 0, 1, 1, 1);

                    }
                    iRow++;
                    iRow++;
                }
            }

            #endregion
            #region KOMENTARE
            iRow--;
            iRow--;
            RRdata.MatrixFill(2, "SELECT config.value FROM config WHERE config.item LIKE 'pro1text%' ORDER BY config.item;", true);
            for (int i = 0; i < RRvar.Matrix2.Count; i++)
            {
                Typ1PageComment(RRdata.MatrixRead(2, i, 0));
            }

            String[] sIP = new string[2];
            sIP[0] = "IP";
            sIP[1] = "interný predpis";
            RRdata.MatrixAdd(3, sIP, false);

            iRow++;
            Typ1PageHeaderExplanatory();
            for (int i = 0; i < RRvar.Matrix3.Count; i++)
            {
                Typ1PageExplanatory(RRdata.MatrixRead(3, i, 0), RRdata.MatrixRead(3, i, 1));
            }
            iRow++; iRow++; iRow++;
            Typ1PagePersons();

            //for (int i = 0; i < RRvar.Matrix2.Count; i++)
            //{
            //    Typ1PageComment(RRdata.MatrixRead(2, i, 0));
            //}



            //if (iRow < 56)
            //{
            //    //    Typ1TableHeader(i, false);
            //}
            //else
            //{
            //    //    Typ1Page(i);
            //}
            #endregion
            #region CISLA STRAN
            for (int q = 0; q < iSheetNameToCreate - 1; q++)
            {
                xSheet = xBook.GetSheetAt(q);

                if (q == 0)
                {
                    w("W13", "Strana 1 z počtu " + (iSheetNameToCreate - 1).ToString(), (short)(nuF1.Value), false, false, "right", false, 0, 0, 0, 0);
                }
                else
                {
                    w("W2", "Strana " + (q + 1).ToString() + " z počtu " + (iSheetNameToCreate - 1).ToString(), (short)(nuF1.Value), false, false, "right", false, 0, 0, 0, 0);
                }
            }
            #endregion
            SaveProtokol();
        }


    }
}



