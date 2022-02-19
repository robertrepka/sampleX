using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System.Management;
using System.Runtime.InteropServices;

namespace sampleX
{
    class RRvar
    {

        private static List<string[]> _Matrix1 = new List<string[]>();
        public static List<string[]> Matrix1
        {
            get { return _Matrix1; }
            set { _Matrix1 = value; }
        }

        private static List<string[]> _Matrix2 = new List<string[]>();
        public static List<string[]> Matrix2
        {
            get { return _Matrix2; }
            set { _Matrix2 = value; }
        }

        private static List<string[]> _Matrix3 = new List<string[]>();
        public static List<string[]> Matrix3
        {
            get { return _Matrix3; }
            set { _Matrix3 = value; }
        }

        private static List<string[]> _Matrix4 = new List<string[]>();
        public static List<string[]> Matrix4
        {
            get { return _Matrix4; }
            set { _Matrix4 = value; }
        }

        private static List<string[]> _Matrix5 = new List<string[]>();
        public static List<string[]> Matrix5
        {
            get { return _Matrix5; }
            set { _Matrix5 = value; }
        }

        private static List<string[]> _Matrix6 = new List<string[]>();
        public static List<string[]> Matrix6
        {
            get { return _Matrix6; }
            set { _Matrix6 = value; }
        }
        private static string _sFilterMeranie;
        public static string sFilterMeranie
        {
            get { return _sFilterMeranie; }
            set { _sFilterMeranie = value; }
        }

        private static int _iFilterMeranie;
        public static int iFilterMeranie
        {
            get { return _iFilterMeranie; }
            set { _iFilterMeranie = value; }
        }

        private static int _iProtoNo1;
        public static int iProtoNo1
        {
            get { return _iProtoNo1; }
            set { _iProtoNo1 = value; }
        }

        private static int _iProtoNo2;
        public static int iProtoNo2
        {
            get { return _iProtoNo2; }
            set { _iProtoNo2 = value; }
        }

        private static string _sZakazkaId;
        public static string sZakazkaId
        {
            get { return _sZakazkaId; }
            set { _sZakazkaId = value; }
        }

        private static int _iLabelsFont1;
        public static int iLabelsFont1
        {
            get { return _iLabelsFont1; }
            set { _iLabelsFont1 = value; }
        }

        private static int _iLabelsFont2;
        public static int iLabelsFont2
        {
            get { return _iLabelsFont2; }
            set { _iLabelsFont2 = value; }
        }

        private static int _iLabelsColumnSize;
        public static int iLabelsColumnSize
        {
            get { return _iLabelsColumnSize; }
            set { _iLabelsColumnSize = value; }
        }

        private static int _iLabelsRowSize;
        public static int iLabelsRowSize
        {
            get { return _iLabelsRowSize; }
            set { _iLabelsRowSize = value; }
        }

        // aktuálne obdobie
        private static int _iRok;
        public static int iRok
        {
            get { return _iRok; }
            set { _iRok = value; }
        }

        //premenná pre výber hodnoty z iného formulára na zobrazenie prvkov
        private static bool _bSelect = false;
        public static bool bSelect
        {
            get { return _bSelect; }
            set { _bSelect = value; }
        }

        //premenná pre výber hodnoty z iného formulára na zobrazenie prvkov
        private static bool _bBackFromAddRecords = false;
        public static bool bBackFromAddRecords
        {
            get { return _bBackFromAddRecords; }
            set { _bBackFromAddRecords = value; }
        }

        private static bool _bDetail = false;
        public static bool bDetail
        {
            get { return _bDetail; }
            set { _bDetail = value; }
        }

        private static bool _bPrevadzkaUpdated = false;
        public static bool bPrevadzkaUpdated
        {
            get { return _bPrevadzkaUpdated; }
            set { _bPrevadzkaUpdated = value; }
        }

        //premenná pre výber filtra z iného formulára na zobrazenie prvkov iba 1ks
        private static bool _bFilter = false;
        public static bool bFilter
        {
            get { return _bFilter; }
            set { _bFilter = value; }
        }

        private static string _sFilter1;
        public static string sFilter1
        {
            get { return _sFilter1; }
            set { _sFilter1 = value; }
        }

        private static string _sIdObjZak;
        public static string sIdObjZak
        {
            get { return _sIdObjZak; }
            set { _sIdObjZak = value; }
        }

        private static string _sFilter2;
        public static string sFilter2
        {
            get { return _sFilter2; }
            set { _sFilter2 = value; }
        }

        private static DateTime _dtLastRunStamp;
        public static DateTime dtLastRunStamp
        {
            get { return _dtLastRunStamp; }
            set { _dtLastRunStamp = value; }
        }

        private static bool _bTop;
        public static bool bTop
        {
            get { return _bTop; }
            set { _bTop = value; }
        }

        private static int _iTop;
        public static int iTop
        {
            get { return _iTop; }
            set { _iTop = value; }
        }

        private static string _s1;
        public static string s1
        {
            get { return _s1; }
            set { _s1 = value; }
        }

        private static string _partner_id;
        public static string partner_id
        {
            get { return _partner_id; }
            set { _partner_id = value; }
        }

        private static bool _bKontaktUpdated;
        public static bool bKontaktUpdated
        {
            get { return _bKontaktUpdated; }
            set { _bKontaktUpdated = value; }
        }

        private static string _kontakt_id;
        public static string kontakt_id
        {
            get { return _kontakt_id; }
            set { _kontakt_id = value; }
        }

        private static string _prevadzka_id;
        public static string prevadzka_id
        {
            get { return _prevadzka_id; }
            set { _prevadzka_id = value; }
        }

        private static string _s2;
        public static string s2
        {
            get { return _s2; }
            set { _s2 = value; }
        }

        private static string _s3;
        public static string s3
        {
            get { return _s3; }
            set { _s3 = value; }
        }

        private static int _i;
        public static int i
        {
            get { return _i; }
            set { _i = value; }
        }

        private static int _j;
        public static int j
        {
            get { return _j; }
            set { _j = value; }
        }

        private static bool _bDeleted;
        public static bool bDeleted
        {
            get { return _bDeleted; }
            set { _bDeleted = value; }
        }

        private static bool _bUpdated;
        public static bool bUpdated
        {
            get { return _bUpdated; }
            set { _bUpdated = value; }
        }

        private static string _sDataPath;
        public static string sDataPath
        {
            get { return _sDataPath; }
            set { _sDataPath = value; }
        }

        private static string _sNewPass;
        public static string sNewPass
        {
            get { return _sNewPass; }
            set { _sNewPass = value; }
        }

        private static string _sConStr;
        public static string sConStr
        {
            get { return _sConStr; }
            set { _sConStr = value; }
        }

        private static string _sCurrPath;
        public static string sCurrPath
        {
            get { return _sCurrPath; }
            set { _sCurrPath = value; }
        }

        private static string _sUser;
        public static string sUser
        {
            get { return _sUser; }
            set { _sUser = value; }
        }

        private static int _idUser;
        public static int idUser
        {
            get { return _idUser; }
            set { _idUser = value; }
        }

        private static string _sFullName;
        public static string sFullName
        {
            get { return _sFullName; }
            set { _sFullName = value; }
        }

        private static string _sTemp1 = "";
        public static string sTemp1
        {
            get { return _sTemp1; }
            set { _sTemp1 = value; }
        }

        private static string _sTemp2 = "";
        public static string sTemp2
        {
            get { return _sTemp2; }
            set { _sTemp2 = value; }
        }

        private static string _sTemp3 = "";
        public static string sTemp3
        {
            get { return _sTemp3; }
            set { _sTemp3 = value; }
        }

        private static string _sTemp4 = "";
        public static string sTemp4
        {
            get { return _sTemp4; }
            set { _sTemp4 = value; }
        }

        private static string _sTemp5 = "";
        public static string sTemp5
        {
            get { return _sTemp5; }
            set { _sTemp5 = value; }
        }

        private static string _sTemp6 = "";
        public static string sTemp6
        {
            get { return _sTemp6; }
            set { _sTemp6 = value; }
        }

        private static string _sTemp7 = "";
        public static string sTemp7
        {
            get { return _sTemp7; }
            set { _sTemp7 = value; }
        }

        private static string _sTemp8 = "";
        public static string sTemp8
        {
            get { return _sTemp8; }
            set { _sTemp8 = value; }
        }

        private static string _sTemp9 = "";
        public static string sTemp9
        {
            get { return _sTemp9; }
            set { _sTemp9 = value; }
        }

        private static string _sTempN = "";
        public static string sTempN
        {
            get { return _sTempN; }
            set { _sTempN = value; }
        }

        private static string _sTemp = "";
        public static string sTemp
        {
            get { return _sTemp; }
            set { _sTemp = value; }
        }

        private static string _sRegisteredName;
        public static string sRegisteredName
        {
            get { return _sRegisteredName; }
            set { _sRegisteredName = value; }
        }

        private static bool _bRegisteredFull;
        public static bool bRegisteredFull
        {
            get { return _bRegisteredFull; }
            set { _bRegisteredFull = value; }
        }

        private static int _iRegisteredDays;
        public static int iRegisteredDays
        {
            get { return _iRegisteredDays; }
            set { _iRegisteredDays = value; }
        }

        private static int _iCell;
        public static int iCell
        {
            get { return _iCell; }
            set { _iCell = value; }
        }

        private static int _iID;
        public static int iID
        {
            get { return _iID; }
            set { _iID = value; }
        }

        private static int _iMinPasswordLenght;
        public static int iMinPasswordLenght
        {
            get { return _iMinPasswordLenght; }
            set { _iMinPasswordLenght = value; }
        }

        private static int _iMaxLoginAttempts;
        public static int iMaxLoginAttempts
        {
            get { return _iMaxLoginAttempts; }
            set { _iMaxLoginAttempts = value; }
        }

        private static int _iFade = 2;
        public static int iFade
        {
            get { return _iFade; }
            set { _iFade = value; }
        }

        private static string _sHeader;
        public static string sHeader
        {
            get { return _sHeader; }
            set { _sHeader = value; }
        }

        private static string _sFooter;
        public static string sFooter
        {
            get { return _sFooter; }
            set { _sFooter = value; }
        }

    }

    class RRstring
    {
        public string dbDate(string input)
        {
            string sOut = "";
            string[] sIn = input.Split('.');
            string s0, s1, s2;

            s0 = sIn[0].Trim();
            s1 = sIn[1].Trim();
            s2 = sIn[2].Trim();

            try
            {
                if (s0.Length == 1)
                {
                    s0 = "0" + s0;
                }

                if (s1.Length == 1)
                {
                    s1 = "0" + s1;
                }
                //sOut = sIn[2].Trim() + "-" + sIn[1].Trim() + "-" + sIn[0].Trim();
                sOut = s2 + "-" + s1 + "-" + s0;
            }
            catch
            {
                sOut = "";
            }
            return sOut;
        }

        public bool IsNumeric(string input)
        {
            int test;
            return int.TryParse(input, out test);
        }

        public string CryptPass(string strRetazec)
        {
            int iNeistota;
            //strRetazec = strRetazec;
            string strHeslo = "System.Data.Security";
            bool base64 = true;
            string strDlzka = strRetazec.Length.ToString();
            int iPozicia = strDlzka.Length;
            try
            {
                strDlzka = strDlzka.Substring(iPozicia - 2, 2);
            }
            catch
            {
                strDlzka = "0" + strDlzka.Substring(iPozicia - 1, 1);
            }

            strRetazec += strDlzka;
            byte[] ub = Encoding.Unicode.GetBytes(strRetazec);
            int i = 0;
            int o = 0;
            int iZnak = 1;
            string x = "";
            string y = "";

            byte[] ubOut = new byte[ub.Length];
            for (i = 0; i <= (ub.Length - 1); i = i + 2)
            {
                y = ub[i].ToString();
                if (y.Length == 1)
                    y = "00" + y;
                if (y.Length == 2)
                    y = "0" + y;
                x = y;

                y = ub[i + 1].ToString();
                if (y.Length == 1)
                    y = "00" + y;
                if (y.Length == 2)
                    y = "0" + y;
                x += y;

                o = Convert.ToInt32(x);

                o += CryptShift(strHeslo, iZnak);
                iNeistota = iZnak;
                if (iNeistota > strHeslo.Length && strHeslo.Length > 0)
                {
                    do
                    {
                        iNeistota -= strHeslo.Length;
                    } while (iNeistota > strHeslo.Length);
                }
                if (strHeslo.Length > 0)
                    o += iNeistota;

                iZnak++;

                x = o.ToString();
                if (x.Length == 1)
                    x = "00000" + x;
                if (x.Length == 2)
                    x = "0000" + x;
                if (x.Length == 3)
                    x = "000" + x;
                if (x.Length == 4)
                    x = "00" + x;
                if (x.Length == 5)
                    x = "0" + x;

                try
                {
                    y = x.Substring(0, 3);
                    ubOut[i] = Convert.ToByte(y);
                    y = x.Substring(3, 3);
                    ubOut[i + 1] = Convert.ToByte(y);
                }
                catch
                {
                    return "Pokášate sa šíifrovať neštandardný znak!!!";
                }
            }

            if (base64 == true)
            {

                byte[] encbuff = System.Text.Encoding.UTF8.GetBytes(Encoding.Unicode.GetString(ubOut));
                return Convert.ToBase64String(encbuff);

            }
            return Encoding.Unicode.GetString(ubOut);
        }

        public string Crypt(string strRetazec, string strHeslo, bool base64)
        {
            int iNeistota;
            strRetazec = Cas2Hex() + strRetazec;

            string strDlzka = strRetazec.Length.ToString();
            int iPozicia = strDlzka.Length;
            try
            {
                strDlzka = strDlzka.Substring(iPozicia - 2, 2);
            }
            catch
            {
                strDlzka = "0" + strDlzka.Substring(iPozicia - 1, 1);
            }

            strRetazec += strDlzka;

            byte[] ub = Encoding.Unicode.GetBytes(strRetazec);
            int i = 0;
            int o = 0;
            int iZnak = 1;
            string x = "";
            string y = "";

            byte[] ubOut = new byte[ub.Length];
            for (i = 0; i <= (ub.Length - 1); i = i + 2)
            {
                y = ub[i].ToString();
                if (y.Length == 1) y = "00" + y;
                if (y.Length == 2) y = "0" + y;
                x = y;

                y = ub[i + 1].ToString();
                if (y.Length == 1) y = "00" + y;
                if (y.Length == 2) y = "0" + y;
                x += y;

                o = Convert.ToInt32(x);

                o += CryptShift(strHeslo, iZnak);

                iNeistota = iZnak;

                if (iNeistota > strHeslo.Length && strHeslo.Length > 0)
                {
                    do
                    {
                        iNeistota -= strHeslo.Length;
                    } while (iNeistota > strHeslo.Length);
                }

                if (strHeslo.Length > 0) o += iNeistota;

                iZnak++;
                x = o.ToString();
                if (x.Length == 1) x = "00000" + x;
                if (x.Length == 2) x = "0000" + x;
                if (x.Length == 3) x = "000" + x;
                if (x.Length == 4) x = "00" + x;
                if (x.Length == 5) x = "0" + x;

                try
                {
                    y = x.Substring(0, 3);
                    ubOut[i] = Convert.ToByte(y);
                    y = x.Substring(3, 3);
                    ubOut[i + 1] = Convert.ToByte(y);
                }
                catch
                {
                    return "Pokúšate sa šifrovať neštandardný znak!!!";
                }
            }
            if (base64 == true)
            {
                byte[] encbuff = System.Text.Encoding.UTF8.GetBytes(Encoding.Unicode.GetString(ubOut));
                return Convert.ToBase64String(encbuff);
            }
            return Encoding.Unicode.GetString(ubOut);
        }

        public string Decrypt(string strRetazec, string strHeslo, bool VratPeciatku, bool base64)
        {
            int iNeistota;

            if (base64 == true)
            {
                byte[] decbuff = Convert.FromBase64String(strRetazec);
                strRetazec = System.Text.Encoding.UTF8.GetString(decbuff);
            }

            byte[] ubNazad = Encoding.Unicode.GetBytes(strRetazec);

            int i = 0;
            int o = 0;
            int iZnak = 1;
            string x = "";
            string y = "";

            byte[] ubNazadOut = new byte[ubNazad.Length];
            for (i = 0; i <= (ubNazad.Length - 1); i = i + 2)
            {
                y = ubNazad[i].ToString();
                if (y.Length == 1)
                    y = "00" + y;
                if (y.Length == 2)
                    y = "0" + y;
                x = y;

                y = ubNazad[i + 1].ToString();
                if (y.Length == 1)
                    y = "00" + y;
                if (y.Length == 2)
                    y = "0" + y;
                x += y;

                o = Convert.ToInt32(x);

                o -= CryptShift(strHeslo, iZnak);

                iNeistota = iZnak;
                if (iNeistota > strHeslo.Length && strHeslo.Length > 0)
                {
                    do
                    {
                        iNeistota -= strHeslo.Length;
                    } while (iNeistota > strHeslo.Length);
                }
                if (strHeslo.Length > 0)
                    o -= iNeistota;

                iZnak++;

                x = o.ToString();
                if (x.Length == 1)
                    x = "00000" + x;
                if (x.Length == 2)
                    x = "0000" + x;
                if (x.Length == 3)
                    x = "000" + x;
                if (x.Length == 4)
                    x = "00" + x;
                if (x.Length == 5)
                    x = "0" + x;

                //try
                //{
                y = x.Substring(0, 3);
                ubNazadOut[i] = Convert.ToByte(y);
                y = x.Substring(3, 3);
                ubNazadOut[i + 1] = Convert.ToByte(y);
                //}
                //catch
                //{
                //    return "chyba";
                //}

            }
            strRetazec = Encoding.Unicode.GetString(ubNazadOut);

            int iLenght = 0;
            int iRetazecLenght = strRetazec.Length - 2;


            string strPeciatka = strRetazec.Substring(0, 8);

            strRetazec = strRetazec.Substring(8, strRetazec.Length - 8);

            iLenght = Convert.ToInt16(strRetazec.Substring(strRetazec.Length - 2, 2));
            strRetazec = strRetazec.Substring(0, strRetazec.Length - 2);
            int iNula = 0;

            if (iRetazecLenght > 99)
            {
                iRetazecLenght = Convert.ToInt16(iRetazecLenght.ToString().Substring(Convert.ToInt16(iRetazecLenght.ToString().Length) - 2, 2));
            }

            if (!(iRetazecLenght == iLenght))
            {
                return (9 / iNula).ToString();
            }

            if (VratPeciatku == true)
            {
                return strPeciatka;
            }
            else
            {
                return strRetazec;
            }
        }

        public int CryptShift(string strHeslo, int iPozicia)
        {
            string strZnak = "";

            if (strHeslo.Length == 0)
                return 0;
            if (strHeslo.Length == 1)
                iPozicia = 1;

            if (iPozicia > strHeslo.Length)
            {
                do
                {
                    iPozicia -= strHeslo.Length;
                } while (iPozicia > strHeslo.Length);
            }
            strZnak = strHeslo.Substring(iPozicia - 1, 1);
            if (strZnak == "0")
                return 0;
            if (strZnak == "1")
                return 1;
            if (strZnak == "2")
                return 2;
            if (strZnak == "3")
                return 3;
            if (strZnak == "4")
                return 4;
            if (strZnak == "5")
                return 5;
            if (strZnak == "6")
                return 6;
            if (strZnak == "7")
                return 7;
            if (strZnak == "8")
                return 8;
            if (strZnak == "9")
                return 9;
            if (strZnak == "a")
                return 10;
            if (strZnak == "á")
                return 11;
            if (strZnak == "ä")
                return 12;
            if (strZnak == "b")
                return 13;
            if (strZnak == "c")
                return 14;
            if (strZnak == "č")
                return 15;
            if (strZnak == "d")
                return 16;
            if (strZnak == "ď")
                return 17;
            if (strZnak == "e")
                return 18;
            if (strZnak == "é")
                return 19;
            if (strZnak == "f")
                return 20;
            if (strZnak == "g")
                return 21;
            if (strZnak == "h")
                return 22;
            if (strZnak == "i")
                return 23;
            if (strZnak == "í")
                return 24;
            if (strZnak == "j")
                return 25;
            if (strZnak == "k")
                return 26;
            if (strZnak == "l")
                return 27;
            if (strZnak == "m")
                return 28;
            if (strZnak == "n")
                return 29;
            if (strZnak == "ň")
                return 30;
            if (strZnak == "o")
                return 31;
            if (strZnak == "ó")
                return 32;
            if (strZnak == "ô")
                return 33;
            if (strZnak == "p")
                return 34;
            if (strZnak == "q")
                return 35;
            if (strZnak == "r")
                return 36;
            if (strZnak == "ŕ")
                return 37;
            if (strZnak == "ř")
                return 38;
            if (strZnak == "s")
                return 39;
            if (strZnak == "š")
                return 40;
            if (strZnak == "t")
                return 41;
            if (strZnak == "ť")
                return 43;
            if (strZnak == "u")
                return 44;
            if (strZnak == "ú")
                return 45;
            if (strZnak == "v")
                return 46;
            if (strZnak == "x")
                return 47;
            if (strZnak == "y")
                return 48;
            if (strZnak == "ý")
                return 49;
            if (strZnak == "z")
                return 50;
            if (strZnak == "ž")
                return 51;
            if (strZnak == "Á")
                return 52;
            if (strZnak == "B")
                return 53;
            if (strZnak == "C")
                return 54;
            if (strZnak == "Č")
                return 55;
            if (strZnak == "D")
                return 56;
            if (strZnak == "Ď")
                return 57;
            if (strZnak == "E")
                return 58;
            if (strZnak == "É")
                return 59;
            if (strZnak == "F")
                return 60;
            if (strZnak == "G")
                return 61;
            if (strZnak == "H")
                return 62;
            if (strZnak == "I")
                return 63;
            if (strZnak == "J")
                return 64;
            if (strZnak == "K")
                return 65;
            if (strZnak == "L")
                return 66;
            if (strZnak == "M")
                return 67;
            if (strZnak == "N")
                return 68;
            if (strZnak == "Ň")
                return 69;
            if (strZnak == "Ó")
                return 70;
            if (strZnak == "Ô")
                return 71;
            if (strZnak == "P")
                return 72;
            if (strZnak == "Q")
                return 73;
            if (strZnak == "R")
                return 74;
            if (strZnak == "Ŕ")
                return 75;
            if (strZnak == "Ř")
                return 76;
            if (strZnak == "S")
                return 77;
            if (strZnak == "Š")
                return 78;
            if (strZnak == "T")
                return 79;
            if (strZnak == "Ť")
                return 80;
            if (strZnak == "U")
                return 81;
            if (strZnak == "Ú")
                return 82;
            if (strZnak == "V")
                return 83;
            if (strZnak == "X")
                return 84;
            if (strZnak == "Y")
                return 85;
            if (strZnak == "Z")
                return 86;
            if (strZnak == "ĺ")
                return 87;
            if (strZnak == "ľ")
                return 88;
            if (strZnak == "Ĺ")
                return 89;
            if (strZnak == "Ľ")
                return 90;
            if (strZnak == "-")
                return 91;
            if (strZnak == "+")
                return 92;
            if (strZnak == "*")
                return 93;
            if (strZnak == "_")
                return 94;
            if (strZnak == "$")
                return 95;
            if (strZnak == "€")
                return 96;
            if (strZnak == "@")
                return 97;
            if (strZnak == " ")
                return 98;
            if (strZnak == "&")
                return 99;
            return 100;
        }

        public string Cas2Hex()
        {
            DateTime dt90 = new DateTime(1990, 1, 1, 0, 0, 0, 0);
            long ticks1990 = dt90.Ticks;
            int Teraz = (int)((DateTime.Now.Ticks - ticks1990) / 10000000L);
            return Teraz.ToString("x");
        }

        public string Cas2Hex(DateTime dt)
        {
            DateTime dt90 = new DateTime(1990, 1, 1, 0, 0, 0, 0);
            long ticks1990 = dt90.Ticks;
            int Teraz = (int)((dt.Ticks - ticks1990) / 10000000L);
            return Teraz.ToString("x");
        }

        public DateTime Hex2Cas(string strCasHex)
        {
            DateTime dt90 = new DateTime(1990, 1, 1, 0, 0, 0, 0);
            long ticks1990 = dt90.Ticks;
            DateTime MojDatum;
            try
            {
                MojDatum = new DateTime(ticks1990 + Convert.ToInt32(strCasHex, 16) * 10000000L);
            }

            catch
            {
                return DateTime.Now;
            }

            return MojDatum;
        }

        public string HardDiskID2()
        {
            string hd = "";
            string sOut = "WD-WXR1E74KPHW6-PELVUH21T7JZEI4";
            string s1 = "S4FTRO";
            string s2 = "0P49S3";

            try
            {
                ManagementObjectSearcher searcherPM1 = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
                foreach (ManagementObject wmi_HD in searcherPM1.Get())
                {

                    hd = wmi_HD["Tag"].ToString().ToUpper();
                    hd = hd.Replace(@"\", "");
                    if (hd.Contains("PHYSICALDRIVE0") == true)
                    {
                        try
                        {
                            hd = wmi_HD["SerialNumber"].ToString().ToLower();
                            hd = hd.Replace(" ", "");
                            s1 = hd;
                        }
                        catch
                        {
                        }
                    }
                }
            }
            catch
            {
            }
            try
            {
                ManagementObjectSearcher searcherPM2 = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
                foreach (ManagementObject wmi_HD in searcherPM2.Get())
                {

                    s2 = wmi_HD["SerialNumber"].ToString().ToUpper();
                }
            }
            catch
            {
            }
            s1 = s1.Replace(" ", "");
            s2 = s2.Replace(" ", "");
            s1 = s1.Replace("-", "x");
            s2 = s2.Replace("-", "x");

            sOut = s1 + s2;
            return sOut.ToUpper().Trim();
        }

        public string Encode64(string str)
        {
            byte[] encbuff = System.Text.Encoding.UTF8.GetBytes(str);
            return Convert.ToBase64String(encbuff);
        }

        public string Decode64(string str)
        {
            byte[] decbuff = Convert.FromBase64String(str);
            return System.Text.Encoding.UTF8.GetString(decbuff);
        }

        private string CreateRandomPassword(int passwordLength)
        {
            string allowedChars = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789";
            char[] chars = new char[passwordLength];
            Random rd = new Random();

            for (int i = 0; i < passwordLength; i++)
            {
                chars[i] = allowedChars[rd.Next(0, allowedChars.Length)];
            }

            return new string(chars);
        }

        public string NewRandomFilename()
        {
            string s = "";
            s += DateTime.Now.ToString("yyyy").Substring(2, 2);
            s += DateTime.Now.ToString("MMddHHmmss");
            s += "_";
            s += CreateRandomPassword(4);
            return s;
        }
    }

    class RRcode
    {
        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);

        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags,
        UIntPtr dwExtraInfo);

        MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
        DataTable MyTable = new DataTable();
        BindingSource MyBind = new BindingSource();
        RRstring RRstring = new RRstring();
        RRdata RRdata = new RRdata();

        public void Front()
        {
            System.Diagnostics.Process[] processlist = System.Diagnostics.Process.GetProcesses();
            foreach (System.Diagnostics.Process theprocess in processlist)
            {
                if (theprocess.ProcessName.ToLower() == "samplex")
                {
                    IntPtr h = theprocess.MainWindowHandle;
                    SetForegroundWindow(h);
                    break;
                }
            }
        }

        public void FadeIn(System.Windows.Forms.Form f)
        {
            try
            {
                f.Opacity = 0;
                Application.DoEvents();

                for (int i = 0; i < 100; i++)
                {
                    Application.DoEvents();
                    f.Opacity += 0.20;
                    if (f.Opacity >= 0.95)
                    {
                        f.Opacity = 1;
                        break;
                    }
                    System.Threading.Thread.Sleep(RRvar.iFade);
                }
            }
            catch { }
        }

        public void FadeOut(System.Windows.Forms.Form f)
        {
            try
            {
                f.Opacity = 1;
                Application.DoEvents();
                for (int i = 0; i < 100; i++)
                {
                    Application.DoEvents();
                    f.Opacity -= 0.2;
                    if (f.Opacity <= 0.05)
                    {
                        f.Opacity = 0;
                        break;
                    }
                    System.Threading.Thread.Sleep(RRvar.iFade);
                }
            }
            catch { }
        }

        public bool LicenceIsValidNow()
        {
            bool bReturn = false;
            string s = "";
            DateTime dtStart = DateTime.Now;

            if (ValidLicence())
            {
                try
                {
                    dtStart = RRstring.Hex2Cas(RRstring.Decrypt(RegRead("key"), RRstring.HardDiskID2(), true, true));
                }
                catch { }

                try
                {
                    s = RRstring.Decrypt(RegRead("key"), RRstring.HardDiskID2(), false, true);
                }
                catch
                {
                }

                if (s.Length > 7)
                {
                    if (s.Substring(0, 4) == "DEMO")
                    {
                        int iNumOfDays = 0;
                        try
                        {
                            iNumOfDays = Convert.ToInt16(s.Substring(4, 3));
                        }
                        catch
                        {
                        }
                        if (iNumOfDays > 0)
                        {
                            dtStart = dtStart.AddDays(iNumOfDays);
                        }
                        else
                        {
                            dtStart = dtStart.AddDays(99999);
                        }
                    }
                    else
                    {
                        dtStart = dtStart.AddDays(99999);
                    }
                }
                else
                {
                    dtStart = dtStart.AddDays(99999);
                }


                if (Convert.ToString(dtStart - RRvar.dtLastRunStamp).Substring(0, 1) == "-")
                {
                    bReturn = false;
                    try
                    {
                        RegWrite("key", "");
                    }
                    catch { }

                }
                else
                {
                    bReturn = true;
                }
            }
            return bReturn;
        }

        public bool LicenceIsValidNow(string sIn)
        {
            bool bReturn = false;
            string s = "";
            DateTime dtStart = DateTime.Now;

            if (ValidLicence(sIn))
            {
                try
                {
                    dtStart = RRstring.Hex2Cas(RRstring.Decrypt(sIn, RRstring.HardDiskID2(), true, true));
                }
                catch { }

                try
                {
                    s = RRstring.Decrypt(sIn, RRstring.HardDiskID2(), false, true);
                }
                catch
                {
                }

                if (s.Length > 7)
                {
                    if (s.Substring(0, 4) == "DEMO")
                    {
                        int iNumOfDays = 0;
                        try
                        {
                            iNumOfDays = Convert.ToInt16(s.Substring(4, 3));
                        }
                        catch
                        {
                        }
                        if (iNumOfDays > 0)
                        {
                            dtStart = dtStart.AddDays(iNumOfDays);
                        }
                        else
                        {
                            dtStart = dtStart.AddDays(99999);
                        }
                    }
                    else
                    {
                        dtStart = dtStart.AddDays(99999);
                    }
                }
                else
                {
                    dtStart = dtStart.AddDays(99999);
                }

                if (Convert.ToString(dtStart - RRvar.dtLastRunStamp).Substring(0, 1) == "-")
                {
                    bReturn = false;
                }
                else
                {
                    bReturn = true;
                }
            }
            return bReturn;
        }

        public DateTime LicenceEnd(string sIn)
        {
            string s = "";
            DateTime dtStart = DateTime.Now;

            try
            {
                dtStart = RRstring.Hex2Cas(RRstring.Decrypt(sIn, RRstring.HardDiskID2(), true, true));
            }
            catch { }

            try
            {
                s = RRstring.Decrypt(sIn, RRstring.HardDiskID2(), false, true);
            }
            catch { }

            if (s.Length > 7)
            {
                if (s.Substring(0, 4) == "DEMO")
                {
                    int iNumOfDays = 0;
                    try
                    {
                        iNumOfDays = Convert.ToInt16(s.Substring(4, 3));
                    }
                    catch
                    {
                    }
                    if (iNumOfDays > 0)
                    {
                        dtStart = dtStart.AddDays(iNumOfDays);
                    }
                    else
                    {
                        dtStart = dtStart.AddDays(99999);
                    }
                }
                else
                {
                    dtStart = dtStart.AddDays(99999);
                }
            }
            else
            {
                dtStart = dtStart.AddDays(99999);
            }
            return dtStart;
        }

        public DateTime LicenceEnd()
        {
            string s = "";
            DateTime dtStart = DateTime.Now;

            try
            {
                dtStart = RRstring.Hex2Cas(RRstring.Decrypt(RegRead("key"), RRstring.HardDiskID2(), true, true));
            }
            catch { }

            try
            {
                s = RRstring.Decrypt(RegRead("key"), RRstring.HardDiskID2(), false, true);
            }
            catch
            {
            }

            if (s.Length > 7)
            {
                if (s.Substring(0, 4) == "DEMO")
                {
                    int iNumOfDays = 0;
                    try
                    {
                        iNumOfDays = Convert.ToInt16(s.Substring(4, 3));
                    }
                    catch
                    {
                    }
                    if (iNumOfDays > 0)
                    {
                        dtStart = dtStart.AddDays(iNumOfDays);
                    }
                    else
                    {
                        dtStart = dtStart.AddDays(99999);
                    }
                }
                else
                {
                    dtStart = dtStart.AddDays(99999);
                }
            }
            else
            {
                dtStart = dtStart.AddDays(99999);
            }
            return dtStart;
        }

        public bool LicenceIsDemo(string sIn)
        {
            string s = "";
            bool bReturn = true;

            try
            {
                s = RRstring.Decrypt(sIn, RRstring.HardDiskID2(), false, true);
            }
            catch { }

            if (s.Length > 7)
            {
                if (s.Substring(0, 4) == "DEMO")
                {
                    int iNumOfDays = 0;
                    try
                    {
                        iNumOfDays = Convert.ToInt16(s.Substring(4, 3));
                    }
                    catch
                    {
                    }
                    if (iNumOfDays > 0)
                    {
                        bReturn = true;
                    }
                    else
                    {
                        bReturn = false;
                    }
                }
                else
                {
                    bReturn = false;
                }
            }
            else
            {
                bReturn = false;
            }
            return bReturn;
        }

        public bool LicenceIsDemo()
        {
            string s = "";
            bool bReturn = true;

            try
            {
                s = RRstring.Decrypt(RegRead("key"), RRstring.HardDiskID2(), false, true);
            }
            catch
            {
            }

            if (s.Length > 7)
            {
                if (s.Substring(0, 4) == "DEMO")
                {
                    int iNumOfDays = 0;
                    try
                    {
                        iNumOfDays = Convert.ToInt16(s.Substring(4, 3));
                    }
                    catch
                    {
                    }
                    if (iNumOfDays > 0)
                    {
                        bReturn = true;
                    }
                    else
                    {
                        bReturn = false;
                    }
                }
                else
                {
                    bReturn = false;
                }
            }
            else
            {
                bReturn = false;
            }
            return bReturn;
        }

        public int LicenceDaysDemo(string sIn)
        {
            string s = "";
            int iReturn = 99999;

            try
            {
                s = RRstring.Decrypt(sIn, RRstring.HardDiskID2(), false, true);
            }
            catch { }

            if (s.Length > 7)
            {
                if (s.Substring(0, 4) == "DEMO")
                {
                    int iNumOfDays = 0;
                    try
                    {
                        iNumOfDays = Convert.ToInt16(s.Substring(4, 3));
                    }
                    catch
                    {
                    }
                    if (iNumOfDays > 0)
                    {
                        iReturn = iNumOfDays;
                    }
                }
            }
            return iReturn;
        }

        public int LicenceDaysDemo()
        {
            string s = "";
            int iReturn = 99999;

            try
            {
                s = RRstring.Decrypt(RegRead("key"), RRstring.HardDiskID2(), false, true);
            }
            catch
            {
            }

            if (s.Length > 7)
            {
                if (s.Substring(0, 4) == "DEMO")
                {
                    int iNumOfDays = 0;
                    try
                    {
                        iNumOfDays = Convert.ToInt16(s.Substring(4, 3));
                    }
                    catch
                    {
                    }
                    if (iNumOfDays > 0)
                    {
                        iReturn = iNumOfDays;
                    }
                }
            }
            return iReturn;
        }

        public bool ValidLicence(string sIn)
        {
            string s = "";

            try
            {
                s = RRstring.Decrypt(sIn, RRstring.HardDiskID2(), false, true);
            }
            catch
            {
            }

            if (s.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidLicence()
        {
            string s = "";

            try
            {
                s = RRstring.Decrypt(RegRead("key"), RRstring.HardDiskID2(), false, true);
            }
            catch
            {
            }

            if (s.Length > 0)
            {
                return true;
            }
            else
            {
                try
                {
                    RegWrite("key", "");
                }
                catch
                {
                }
                return false;
            }
        }

        public string Licence(string sIn)
        {
            string s = "";

            try
            {
                s = RRstring.Decrypt(sIn, RRstring.HardDiskID2(), false, true);
            }
            catch { }

            if (s.Length > 7)
            {
                if (s.Substring(0, 4) == "DEMO")
                {
                    int iNumOfDays = 0;
                    try
                    {
                        iNumOfDays = Convert.ToInt16(s.Substring(4, 3));
                    }
                    catch
                    {
                    }
                    if (iNumOfDays > 0)
                    {
                        RRvar.sRegisteredName = s.Substring(7, s.Length - 7);
                        RRvar.iRegisteredDays = iNumOfDays;
                        RRvar.bRegisteredFull = false;
                    }
                    else
                    {
                        RRvar.sRegisteredName = s;
                        RRvar.iRegisteredDays = 99999;
                        RRvar.bRegisteredFull = true;
                    }
                }
                else
                {
                    RRvar.sRegisteredName = s;
                    RRvar.iRegisteredDays = 99999;
                    RRvar.bRegisteredFull = true;
                }
            }
            else
            {
                RRvar.sRegisteredName = s;
                RRvar.iRegisteredDays = 99999;
                RRvar.bRegisteredFull = true;
            }
            return RRvar.sRegisteredName;
        }

        public void Licence()
        {
            string s = "";

            if (ValidLicence())
            {
                try
                {
                    s = RRstring.Decrypt(RegRead("key"), RRstring.HardDiskID2(), false, true);
                }
                catch { }
            }

            if (s.Length > 7)
            {
                if (s.Substring(0, 4) == "DEMO")
                {
                    int iNumOfDays = 0;
                    try
                    {
                        iNumOfDays = Convert.ToInt16(s.Substring(4, 3));
                    }
                    catch
                    {
                    }
                    if (iNumOfDays > 0)
                    {
                        RRvar.sRegisteredName = s.Substring(7, s.Length - 7);
                        RRvar.iRegisteredDays = iNumOfDays;
                        RRvar.bRegisteredFull = false;
                    }
                    else
                    {
                        RRvar.sRegisteredName = s;
                        RRvar.iRegisteredDays = 99999;
                        RRvar.bRegisteredFull = true;
                    }
                }
                else
                {
                    RRvar.sRegisteredName = s;
                    RRvar.iRegisteredDays = 99999;
                    RRvar.bRegisteredFull = true;
                }
            }
            else
            {
                RRvar.sRegisteredName = s;
                RRvar.iRegisteredDays = 99999;
                RRvar.bRegisteredFull = true;
            }
        }

        public string RegRead(string strAppName, string strKeyName)
        {
            string strReturn = "";
            RegistryKey RegKluc;
            RegKluc = Registry.CurrentUser.OpenSubKey(@"Software\Repka Software\" + strAppName);
            try
            {
                strReturn = RegKluc.GetValue(strKeyName).ToString();
            }
            catch { }

            try
            {
                RegKluc.Flush();
                RegKluc.Close();
            }
            catch { }
            return strReturn;
        }

        public string RegRead(string strKeyName)
        {
            string strAppName = "sampleX";
            string strReturn = "";
            RegistryKey RegKluc;
            RegKluc = Registry.CurrentUser.OpenSubKey(@"Software\Repka Software\" + strAppName);
            try
            {
                strReturn = RegKluc.GetValue(strKeyName).ToString();
            }
            catch { }

            try
            {
                RegKluc.Flush();
                RegKluc.Close();
            }
            catch { }
            return strReturn;
        }

        public void RegWrite(string strKeyName, string strKeyValue)
        {
            string strAppName = "sampleX";
            RegistryKey RegKluc;
            RegKluc = Registry.CurrentUser.CreateSubKey(@"Software\Repka Software\" + strAppName);
            try
            {
                RegKluc.SetValue(strKeyName, strKeyValue);
            }
            catch { }
            try
            {
                RegKluc.Flush();
                RegKluc.Close();
            }
            catch { }

        }

        public void RegWrite(string strAppName, string strKeyName, string strKeyValue)
        {
            RegistryKey RegKluc;
            RegKluc = Registry.CurrentUser.CreateSubKey(@"Software\Repka Software\" + strAppName);
            try
            {
                RegKluc.SetValue(strKeyName, strKeyValue);
            }
            catch { }
            try
            {
                RegKluc.Flush();
                RegKluc.Close();
            }
            catch { }

        }

        public void CopyPro(string sFilename, string sDirectory, System.ComponentModel.ISynchronizeInvoke oThis)
        {
            //RRvar.bCopyFileProgress = true;
            List<String> TempFiles = new List<String>();
            TempFiles.Add(sFilename);
            CopyFiles Temp = new CopyFiles(TempFiles, sDirectory);
            DIA_CopyFiles TempDiag = new DIA_CopyFiles();
            TempDiag.SynchronizationObject = oThis;
            Temp.CopyAsync(TempDiag);
            //Uncomment this line to do a synchronous copy.
            //Temp.Copy();

        }

        public void Log(string sDescription)
        {
            string sPc = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString();
            sDescription = sDescription.Replace("'", "");
            sPc = sPc.Replace("\\", " -> ");
            string sTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string sSql = "insert into journal (pc, refe_id, description, stamp) values ('" + sPc + "', '" + RRvar.idUser.ToString() + "', '" + sDescription + "' , '" + sTime + "')";
            RRdata.RunSql(sSql);
        }

        public void LogAsSystem(string sDescription)
        {
            int idSystem = Convert.ToInt16(RRdata.sSqlResult("select id from refe where login='system';", 1, 1));

            string sPc = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString();
            sDescription = sDescription.Replace("'", "");
            sPc = sPc.Replace("\\", " -> ");
            string sTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string sSql = "insert into journal (pc, refe_id, description, stamp) values ('" + sPc + "', '" + idSystem.ToString() + "', '" + sDescription + "' , '" + sTime + "')";
            RRdata.RunSql(sSql);
        }

    }

    class RRdata
    {
        //MySqlConnection MyCon = new MySqlConnection(RRvar.sConStr);
        public bool bAuth(string sValue)
        {
            string s = "select count(*) as total from f_auth_refe1 where value='" + sValue + "' and id2 = '" + RRvar.idUser + "'";
            int i = Convert.ToInt16(sSqlResult(s, 1, 1));

            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static DataTable _County;
        public static DataTable County
        {
            get
            {
                return _County;
            }
            set
            {
                _County = value;
            }
        }

        private static DataTable _Region;
        public static DataTable Region
        {
            get
            {
                return _Region;
            }
            set
            {
                _Region = value;
            }
        }

        private static DataTable _Type_doc;
        public static DataTable Type_doc
        {
            get
            {
                return _Type_doc;
            }
            set
            {
                _Type_doc = value;
            }
        }

        private static DataTable _Type_work;
        public static DataTable Type_work
        {
            get
            {
                return _Type_work;
            }
            set
            {
                _Type_work = value;
            }
        }

        private static DataTable _Type_work_detail;
        public static DataTable Type_work_detail
        {
            get
            {
                return _Type_work_detail;
            }
            set
            {
                _Type_work_detail = value;
            }
        }

        private static DataTable _Users;
        public static DataTable Users
        {
            get
            {
                return _Users;
            }
            set
            {
                _Users = value;
            }
        }

        private static string _sSqL;
        public static string sSqL
        {
            get
            {
                return _sSqL;
            }
            set
            {
                _sSqL = value;
            }
        }

        public string MatrixRead(int iRow0, int iCol0)
        {
            return MatrixRead(1, iRow0, iCol0);
        }

        public string MatrixRead(int iMatrix, int iRow0, int iCol0)
        {
            string s = "";
            try
            {
                switch (iMatrix)
                {
                    case 1:
                        string[] ss1 = RRvar.Matrix1[iRow0];
                        s = ss1[iCol0];
                        break;
                    case 2:
                        string[] ss2 = RRvar.Matrix2[iRow0];
                        s = ss2[iCol0];
                        break;
                    case 3:
                        string[] ss3 = RRvar.Matrix3[iRow0];
                        s = ss3[iCol0];
                        break;
                    case 4:
                        string[] ss4 = RRvar.Matrix4[iRow0];
                        s = ss4[iCol0];
                        break;
                    case 5:
                        string[] ss5 = RRvar.Matrix5[iRow0];
                        s = ss5[iCol0];
                        break;
                    case 6:
                        string[] ss6 = RRvar.Matrix6[iRow0];
                        s = ss6[iCol0];
                        break;
                    default:
                        string[] ssd = RRvar.Matrix1[iRow0];
                        s = ssd[iCol0];
                        break;
                }
            }
            catch { }
            return s;
        }

        public void MatrixClear()
        {
            RRvar.Matrix1.Clear();
        }

        public void MatrixClear(int iMatrix)
        {
            switch (iMatrix)
            {
                case 1:
                    RRvar.Matrix1.Clear();
                    break;
                case 2:
                    RRvar.Matrix2.Clear();
                    break;
                case 3:
                    RRvar.Matrix3.Clear();
                    break;
                case 4:
                    RRvar.Matrix4.Clear();
                    break;
                case 5:
                    RRvar.Matrix5.Clear();
                    break;
                case 6:
                    RRvar.Matrix6.Clear();
                    break;
                default:
                    RRvar.Matrix1.Clear();
                    break;
            }
        }

        public void MatrixFill(string sSql, bool bClearMatrixBeforeFill)
        {
            MatrixFill(1, sSql, bClearMatrixBeforeFill);
        }

        public void MatrixFill(int iMatrix, string sSql, bool bClearMatrixBeforeFill)
        {
            List<string> myList = new List<string>();
            if (bClearMatrixBeforeFill)
            {
                switch (iMatrix)
                {
                    case 1:
                        RRvar.Matrix1.Clear();
                        break;
                    case 2:
                        RRvar.Matrix2.Clear();
                        break;
                    case 3:
                        RRvar.Matrix3.Clear();
                        break;
                    case 4:
                        RRvar.Matrix4.Clear();
                        break;
                    case 5:
                        RRvar.Matrix5.Clear();
                        break;
                    case 6:
                        RRvar.Matrix6.Clear();
                        break;
                    default:
                        RRvar.Matrix1.Clear();
                        break;
                }
            }

            MySqlConnection MyCon = new MySqlConnection(RRvar.sConStr);
            MySqlCommand Sql = new MySqlCommand(sSql);
            try
            {
                MyCon.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Chyba pri zápise", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            Sql.Connection = MyCon;

            int iColumns;

            MySqlDataReader rReader = Sql.ExecuteReader();

            while (rReader.Read())
            {
                try
                {
                    iColumns = rReader.FieldCount;

                    for (int i = 0; i < iColumns; i++)
                    {
                        myList.Add(rReader[i].ToString());
                    }
                    String[] sOut = myList.ToArray();
                    myList.Clear();

                    switch (iMatrix)
                    {
                        case 1:
                            RRvar.Matrix1.Add(sOut);
                            break;
                        case 2:
                            RRvar.Matrix2.Add(sOut);
                            break;
                        case 3:
                            RRvar.Matrix3.Add(sOut);
                            break;
                        case 4:
                            RRvar.Matrix4.Add(sOut);
                            break;
                        case 5:
                            RRvar.Matrix5.Add(sOut);
                            break;
                        case 6:
                            RRvar.Matrix6.Add(sOut);
                            break;
                        default:
                            RRvar.Matrix1.Add(sOut);
                            break;
                    }
                }
                catch { }
            }
            try { rReader.Close(); }
            catch { }
            try { MyCon.Close(); }
            catch { }
        }

        //public void MatrixAdd(string sValue, bool bClearMatrixBeforeFill)
        //{
        //    MatrixAdd(1, sValue[], bClearMatrixBeforeFill);
        //}

        public void MatrixAdd(int iMatrix, string[] sValue, bool bClearMatrixBeforeFill)
        {
            if (bClearMatrixBeforeFill)
            {
                switch (iMatrix)
                {
                    case 1:
                        RRvar.Matrix1.Clear();
                        break;
                    case 2:
                        RRvar.Matrix2.Clear();
                        break;
                    case 3:
                        RRvar.Matrix3.Clear();
                        break;
                    case 4:
                        RRvar.Matrix4.Clear();
                        break;
                    case 5:
                        RRvar.Matrix5.Clear();
                        break;
                    case 6:
                        RRvar.Matrix6.Clear();
                        break;
                    default:
                        RRvar.Matrix1.Clear();
                        break;
                }
            }

            switch (iMatrix)
            {
                case 1:
                    RRvar.Matrix1.Add(sValue);
                    break;
                case 2:
                    RRvar.Matrix2.Add(sValue);
                    break;
                case 3:
                    RRvar.Matrix3.Add(sValue);
                    break;
                case 4:
                    RRvar.Matrix4.Add(sValue);
                    break;
                case 5:
                    RRvar.Matrix5.Add(sValue);
                    break;
                case 6:
                    RRvar.Matrix6.Add(sValue);
                    break;
                default:
                    RRvar.Matrix1.Add(sValue);
                    break;
            }
        }

        public string sSqlResult(string sSql, int iColumn, int iRecord)
        {
            //string sTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            iColumn--;
            string sResult = "";
            MySqlConnection MyCon = new MySqlConnection(RRvar.sConStr);
            MySqlCommand Sql = new MySqlCommand(sSql);
            try
            {
                MyCon.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Chyba pri zápise", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            Sql.Connection = MyCon;
            MySqlDataReader rReader = Sql.ExecuteReader();
            for (int i = 1; i <= iRecord; i++)
            {
                try
                {
                    rReader.Read();
                    sResult = rReader[iColumn].ToString();
                }
                catch
                {
                    sResult = "";
                }
            }

            try
            {
                rReader.Close();
            }
            catch { }

            try
            {
                MyCon.Close();
            }
            catch { }
            return sResult;
        }

        public void RunSql(string sSql)
        {
            //string sTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            MySqlConnection MyCon = new MySqlConnection(RRvar.sConStr);
            MySqlCommand Sql = new MySqlCommand(sSql);
            try
            {
                MyCon.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Chyba pri zápise", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            Sql.Connection = MyCon;
            try
            {

                Sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Chyba pri zápise", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            try
            {
                MyCon.Close();
            }
            catch
            {
            }
        }

        public DataTable DT(string sSql)
        {
            MySqlConnection MyCon = new MySqlConnection(RRvar.sConStr);
            MySqlCommand Sql = new MySqlCommand(sSql);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            DataTable MyTable = new DataTable();
            BindingSource MyBind = new BindingSource();
            try
            {
                MyCon.Open();
            }
            catch
            {
            }
            MyAdapter = new MySqlDataAdapter(sSql, MyCon);
            MyTable.Rows.Clear();
            MyAdapter.Fill(MyTable);
            MyCon.Close();
            return MyTable;
        }

        public DataTable DTAddLine(string sSql, string Col1, string Col2, string Value1, string Value2)
        {
            MySqlConnection MyCon = new MySqlConnection(RRvar.sConStr);
            MySqlCommand Sql = new MySqlCommand(sSql);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            DataTable MyTable = new DataTable();
            BindingSource MyBind = new BindingSource();
            try
            {
                MyCon.Open();
            }
            catch
            {
            }
            MyAdapter = new MySqlDataAdapter(sSql, MyCon);
            MyTable.Rows.Clear();
            MyAdapter.Fill(MyTable);
            MyCon.Close();

            DataTable MyTableOut = new DataTable();
            MyTableOut.Columns.Add(Col1);
            MyTableOut.Columns.Add(Col2);
            MyTableOut.Rows.Add(Value1, Value2);
            foreach (DataRow row in MyTable.Rows)
            {
                MyTableOut.Rows.Add(row[Col1].ToString(), row[Col2].ToString());
            }
            return MyTableOut;
        }

        public DataTable memDT(DataTable dt, string filter, string sort)
        {
            DataTable memTable;
            DataView view = dt.DefaultView;
            view.Sort = sort;
            view.RowFilter = filter;

            memTable = view.ToTable();
            return memTable;
        }

        public DataTable memDTAddLine(DataTable dt, string filter, string sort, string Col1, string Col2, string Value1, string Value2)
        {
            DataTable memTable;
            DataView view = dt.DefaultView;
            view.Sort = sort;
            view.RowFilter = filter;
            memTable = view.ToTable();


            DataTable MyTableOut = new DataTable();
            MyTableOut.Columns.Add(Col1);
            MyTableOut.Columns.Add(Col2);
            MyTableOut.Rows.Add(Value1, Value2);
            foreach (DataRow row in memTable.Rows)
            {
                MyTableOut.Rows.Add(row[Col1].ToString(), row[Col2].ToString());
            }
            return MyTableOut;
        }

        public string memSqlResult(DataTable dt, string filter, string sort, int iColumn, int iRecord)
        {
            iColumn--;
            string sResult = "";
            DataTable memTable;
            DataView view = dt.DefaultView;
            try
            {
                view.Sort = sort;
                view.RowFilter = filter;
                memTable = view.ToTable();
                int i = 1;

                foreach (DataRow row in memTable.Rows)
                {
                    if (i == iRecord)
                    {
                        sResult = row[iColumn].ToString();
                        //MessageBox.Show(row[0].ToString());
                        //MessageBox.Show(row[1].ToString());
                        //MessageBox.Show(row[2].ToString());
                        //MessageBox.Show(row[3].ToString());
                    }
                    i++;


                }
            }
            catch { }
            return sResult;
        }

    }
}
