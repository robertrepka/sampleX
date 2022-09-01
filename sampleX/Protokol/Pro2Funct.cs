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
    public partial class Pro2 : Form
    {
        #region FUNKCIE
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
        private void ws(string sCell, HSSFCellStyle y)
        {
            string sChar = sCell.Substring(0, 1);
            int iRow = Convert.ToInt32(sCell.Substring(1, sCell.Length - 1)) - 1;
            iCol = iColumnToNumber(sChar);
            r = xSheet.GetRow(iRow);
            xCell = r.GetCell(iCol);
            xCell.CellStyle = y;
        }
        private void w(string sCell, string sValue, HSSFCellStyle y)
        {
            string sChar = sCell.Substring(0, 1);
            int iRow = Convert.ToInt32(sCell.Substring(1, sCell.Length - 1)) - 1;
            iCol = iColumnToNumber(sChar);
            r = xSheet.GetRow(iRow);
            xCell = r.GetCell(iCol);
            if (sValue.Length > 0)
            {
                xCell.SetCellValue(sValue);
                xCell.CellStyle = y;
            }
        }
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
                    myStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
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
                    myStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
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
                    myStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
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
                    myStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
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
                    myStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
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
                    myStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
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
                    myStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
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
                    myStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
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
                    myStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
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
                    myStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
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
                    myStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
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
                    myStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
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
        #endregion FUNKCIE
    }
}
