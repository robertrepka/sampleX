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
        #region FONTY A ŠTÝLY
        HSSFFont myFont;
        HSSFFont myFontMinus1;
        HSSFFont myFontCur;
        HSSFFont myFontCurBold;
        HSSFFont myFontBold;
        HSSFFont myFontBoldPlus1;
        HSSFCellStyle myStyleCur;
        HSSFCellStyle myStyleBold;
        HSSFCellStyle myStyleCurBold;
        HSSFCellStyle myStyleAlignR;
        HSSFCellStyle myStyleBoldBorder;
        HSSFCellStyle myStyleCenterBorder;
        HSSFCellStyle myStyleMinus1CenterBorder;
        HSSFCellStyle myStyleBoldPlus1LeftBorderLTB;
        HSSFCellStyle myStyleBorderTB;
        HSSFCellStyle myStyleRightBorderRTB;
        HSSFCellStyle myStyleCurBorder;
        HSSFCellStyle myStyleCurCenterBorder;


        public void myStylesDefine()
        {
            #region FONTY
            myFont = (HSSFFont)xBook.CreateFont();
            myFont.FontHeightInPoints = (short)10;
            myFont.FontName = "Arial";
            myFont.FontHeightInPoints = (short)(nuF1.Value);
            myFont.Boldweight = (short)NPOI.SS.UserModel.FontBoldWeight.Normal;
            myFont.IsItalic = false;

            myFontMinus1 = (HSSFFont)xBook.CreateFont();
            myFontMinus1.FontHeightInPoints = (short)10;
            myFontMinus1.FontName = "Arial";
            myFontMinus1.FontHeightInPoints = (short)(nuF1.Value - 1);
            myFontMinus1.Boldweight = (short)NPOI.SS.UserModel.FontBoldWeight.Normal;
            myFontMinus1.IsItalic = false;

            myFontCur = (HSSFFont)xBook.CreateFont();
            myFontCur.FontHeightInPoints = (short)10;
            myFontCur.FontName = "Arial";
            myFontCur.FontHeightInPoints = (short)(nuF1.Value);
            myFontCur.Boldweight = (short)NPOI.SS.UserModel.FontBoldWeight.Normal;
            myFontCur.IsItalic = true;

            myFontCurBold = (HSSFFont)xBook.CreateFont();
            myFontCurBold.FontHeightInPoints = (short)10;
            myFontCurBold.FontName = "Arial";
            myFontCurBold.FontHeightInPoints = (short)(nuF1.Value);
            myFontCurBold.Boldweight = (short)NPOI.SS.UserModel.FontBoldWeight.Bold;
            myFontCurBold.IsItalic = true;

            myFontBold = (HSSFFont)xBook.CreateFont();
            myFontBold.FontHeightInPoints = (short)10;
            myFontBold.FontName = "Arial";
            myFontBold.FontHeightInPoints = (short)(nuF1.Value);
            myFontBold.Boldweight = (short)NPOI.SS.UserModel.FontBoldWeight.Bold;
            myFontBold.IsItalic = false;

            myFontBoldPlus1 = (HSSFFont)xBook.CreateFont();
            myFontBoldPlus1.FontHeightInPoints = (short)10;
            myFontBoldPlus1.FontName = "Arial";
            myFontBoldPlus1.FontHeightInPoints = (short)(nuF1.Value + 1);
            myFontBoldPlus1.Boldweight = (short)NPOI.SS.UserModel.FontBoldWeight.Bold;
            myFontBoldPlus1.IsItalic = false;

            #endregion
            #region ŠTÝLY
            myStyleBold = (HSSFCellStyle)xBook.CreateCellStyle();
            myStyleBold.WrapText = false;
            myStyleBold.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
            myStyleBold.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Left;
            myStyleBold.WrapText = false;
            myStyleBold.SetFont(myFontBold);

            myStyleCur = (HSSFCellStyle)xBook.CreateCellStyle();
            myStyleCur.WrapText = false;
            myStyleCur.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
            myStyleCur.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Left;
            myStyleCur.WrapText = false;
            myStyleCur.SetFont(myFontCur);

            myStyleCurBold = (HSSFCellStyle)xBook.CreateCellStyle();
            myStyleCurBold.WrapText = false;
            myStyleCurBold.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
            myStyleCurBold.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Left;
            myStyleCurBold.WrapText = false;
            myStyleCurBold.SetFont(myFontCur);

            myStyleAlignR = (HSSFCellStyle)xBook.CreateCellStyle();
            myStyleAlignR.WrapText = false;
            myStyleAlignR.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
            myStyleAlignR.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Right;
            myStyleAlignR.WrapText = false;
            myStyleAlignR.SetFont(myFont);

            myStyleBoldBorder = (HSSFCellStyle)xBook.CreateCellStyle();
            myStyleBoldBorder.WrapText = false;
            myStyleBoldBorder.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
            myStyleBoldBorder.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Left;
            myStyleBoldBorder.WrapText = false;
            myStyleBoldBorder.SetFont(myFontBold);
            myStyleBoldBorder.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
            myStyleBoldBorder.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
            myStyleBoldBorder.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
            myStyleBoldBorder.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;

            myStyleMinus1CenterBorder = (HSSFCellStyle)xBook.CreateCellStyle();
            myStyleMinus1CenterBorder.WrapText = false;
            myStyleMinus1CenterBorder.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
            myStyleMinus1CenterBorder.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
            myStyleMinus1CenterBorder.WrapText = false;
            myStyleMinus1CenterBorder.SetFont(myFontMinus1);
            myStyleMinus1CenterBorder.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
            myStyleMinus1CenterBorder.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
            myStyleMinus1CenterBorder.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
            myStyleMinus1CenterBorder.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;

            myStyleCenterBorder = (HSSFCellStyle)xBook.CreateCellStyle();
            myStyleCenterBorder.WrapText = false;
            myStyleCenterBorder.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
            myStyleCenterBorder.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
            myStyleCenterBorder.WrapText = false;
            myStyleCenterBorder.SetFont(myFont);
            myStyleCenterBorder.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
            myStyleCenterBorder.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
            myStyleCenterBorder.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
            myStyleCenterBorder.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;

            // HLAVICKA TABULKY
            myStyleBoldPlus1LeftBorderLTB = (HSSFCellStyle)xBook.CreateCellStyle();
            myStyleBoldPlus1LeftBorderLTB.WrapText = false;
            myStyleBoldPlus1LeftBorderLTB.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
            myStyleBoldPlus1LeftBorderLTB.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Left;
            myStyleBoldPlus1LeftBorderLTB.WrapText = false;
            myStyleBoldPlus1LeftBorderLTB.SetFont(myFontBoldPlus1);
            myStyleBoldPlus1LeftBorderLTB.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
            myStyleBoldPlus1LeftBorderLTB.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
            myStyleBoldPlus1LeftBorderLTB.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;

            myStyleRightBorderRTB = (HSSFCellStyle)xBook.CreateCellStyle();
            myStyleRightBorderRTB.WrapText = false;
            myStyleRightBorderRTB.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
            myStyleRightBorderRTB.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Right;
            myStyleRightBorderRTB.WrapText = false;
            myStyleRightBorderRTB.SetFont(myFont);
            myStyleRightBorderRTB.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
            myStyleRightBorderRTB.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
            myStyleRightBorderRTB.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;

            myStyleBorderTB = (HSSFCellStyle)xBook.CreateCellStyle();
            myStyleBorderTB.WrapText = false;
            myStyleBorderTB.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
            myStyleBorderTB.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Left;
            myStyleBorderTB.WrapText = false;
            myStyleBorderTB.SetFont(myFont);
            myStyleBorderTB.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
            myStyleBorderTB.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;

            myStyleCurBorder = (HSSFCellStyle)xBook.CreateCellStyle();
            myStyleCurBorder.WrapText = false;
            myStyleCurBorder.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
            myStyleCurBorder.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Left;
            myStyleCurBorder.WrapText = true;
            myStyleCurBorder.SetFont(myFontCur);
            myStyleCurBorder.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
            myStyleCurBorder.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
            myStyleCurBorder.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
            myStyleCurBorder.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;

            myStyleCurCenterBorder = (HSSFCellStyle)xBook.CreateCellStyle();
            myStyleCurCenterBorder.WrapText = false;
            myStyleCurCenterBorder.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
            myStyleCurCenterBorder.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
            myStyleCurCenterBorder.WrapText = true;
            myStyleCurCenterBorder.SetFont(myFontCur);
            myStyleCurCenterBorder.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
            myStyleCurCenterBorder.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
            myStyleCurCenterBorder.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
            myStyleCurCenterBorder.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;

            #endregion

        }
        #endregion

    }
}



