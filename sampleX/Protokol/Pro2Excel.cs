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
        #region FILL
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
            rSize(6, 40);
            rSize(7, 40);
            #endregion
            #region LOGÁ OBRAZKY
            InitPic(1, 0, 0);
            InitPic(2, 0, 14);
            InitPic(3, 0, 18);
            #endregion
            #region HLAVICKA PROTOKOLU
            s = "Protokol o skúške č. " + RRvar.iProtoNo1.ToString() + "/" + RRvar.iProtoNo2.ToString();
            w("L7", s, (short)(nuF2.Value), true, false, "center", false, 0, 0, 0, 0);

            w("N9", "Skúška:", myStyleCur);
            w("N10", "Subdodávka:", myStyleCur);
            w("N11", "Odber:", myStyleCur);

            w("W9", "A - akreditovaná, N - neakreditovaná", myStyleAlignR);
            w("W10", "SA - akreditovaná, SN - neakreditovaná", myStyleAlignR);
            w("W11", "A - akreditovaný, N neakreditovaný", myStyleAlignR);

            w("A13", "Počet výtlačkov:", myStyleCur);
            w("A14", "Výtlačok číslo:", myStyleCur);
            w("A16", "Objednávateľ:", myStyleCurBold);
            w("A18", "Zodp. pracovník:", myStyleCur);
            w("A19", "Telefón:", myStyleCur);
            w("A20", "E-mail:", myStyleCur);
            w("A21", "Objednávka:", myStyleCur);
            w("A22", "Zákazka:", myStyleCur);
            w("A23", "Počet vzoriek:", myStyleCur);

            w("N20", "Dátum prevzatia vzoriek:", myStyleCur);
            w("N21", "Dátum vykonania skúšok od:", myStyleCur);
            w("N22", "Dátum vykonania skúšok do:", myStyleCur);
            w("N23", "Dátum vydania protokolu:", myStyleCur);

            w("A25", "Údaje o vzorkách:", myStyleCurBold);
            w("A26", "Matrica:", myStyleCur);
            w("A27", "Identif. matrice:", myStyleCur);

            w("N25", "Vzorky odobral:", myStyleCur);
            w("N26", "Miesto odberu:", myStyleCur);
            w("N27", "Dátum odberu:", myStyleCur);

            w("W13", "Strana 1 z počtu 1", myStyleAlignR);
            w("W14", "Počet príloh: " + nuPriloha.Value.ToString(), myStyleAlignR);
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
            w("E13", "3");
            w("E14", "1");
            w("E23", iCount.ToString());

            s = RRdata.MatrixRead(4, 0, 4);
            s = "SELECT * FROM zakazka_obj_partner WHERE id='" + s + "';";
            RRdata.MatrixFill(5, s, true);
            s = RRdata.MatrixRead(5, 0, 24);
            s = "SELECT nazov, ulica, psc, mesto FROM partner WHERE id='" + s + "';";
            RRdata.MatrixFill(6, s, true);
            s = RRdata.MatrixRead(6, 0, 0);
            w("E16", s, myStyleBold);//nazov
            ss = RRdata.MatrixRead(6, 0, 2);
            if (ss.Length == 5)
            {
                ss = ss.Substring(0, 3) + " " + ss.Substring(3, 2) + " ";
            }
            s = RRdata.MatrixRead(6, 0, 1) + ", " + ss + RRdata.MatrixRead(6, 0, 3);
            w("E17", s);//adresa
            s = RRdata.MatrixRead(5, 0, 26);
            w("E18", s);//kontakt
            s = RRdata.MatrixRead(5, 0, 28);
            w("E19", s);//email
            s = RRdata.MatrixRead(5, 0, 29);
            w("E20", s);//tel
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

            w("E21", s);//cobj/czml
            s = RRdata.MatrixRead(5, 0, 10) + "/" + RRdata.MatrixRead(5, 0, 11);
            w("E22", s);//cislo zakazky
            s = RRdata.MatrixRead(5, 0, 34);
            w("E27", s);//v_matrica

            s = RRdata.MatrixRead(5, 0, 14);
            s = myDateFormatConvert(s);
            w("W20", s, myStyleAlignR);//dat dod

            s = RRdata.MatrixRead(5, 0, 16);
            s = myDateFormatConvert(s);
            w("W21", s, myStyleAlignR);//dat start

            s = RRdata.MatrixRead(5, 0, 17);
            s = myDateFormatConvert(s);
            w("W22", s, myStyleAlignR);//dat stop

            s = RRdata.MatrixRead(5, 0, 18);
            s = myDateFormatConvert(s);
            w("W23", s, myStyleAlignR);//dat prot

            //s = RRdata.MatrixRead(5, 0, 35);
            s = tOdber.Text + ", odber: " + cOdberAkr.Text;
            //s = myDateFormatConvert(s);
            w("W25", s, myStyleAlignR);//v_odobral

            s = RRdata.MatrixRead(5, 0, 38);
            //s = myDateFormatConvert(s);
            w("W27", s, myStyleAlignR);//v_miesto

            s = myDateFormatConvert(RRdata.MatrixRead(5, 0, 36));
            ss = myDateFormatConvert(RRdata.MatrixRead(5, 0, 37));
            if (ss.Length == 10 || ss != s)
            {
                s = s + " - " + ss;
            }
            w("W27", s, myStyleAlignR);//v_cas
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
            w("E26", s);//matrica
            #endregion
            #region UDAJE
            // matrix3 - zhromazdovanie principov kvoli vysvetlivkam
            RRdata.MatrixClear(3);
            // matrix2 - zhromazdovanie poznámok kvoli poznámkam
            RRdata.MatrixClear(2);
            bool bImHereAlready = false;

            rSize(30, 40);
            w("L30", "Výsledky skúšok", (short)(nuF2.Value - 2), true, false, "center", false, 0, 0, 0, 0);
            iRow = 32;
                #region data pre jedno labc do MATRIX5
            for (int i = 0; i < iCount; i++)
            {
                
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

                    #region pridavanie riadkov z data
                    for (int m = 0; m < RRvar.Matrix5.Count; m++)
                    {
                        //Nastavi cislo riadku a stranu
                        Typ1Page(i);
                        #region PARAMETER
                        ss = RRdata.MatrixRead(5, m, 3); //id parameter
                        s = RRsql.RunSqlReturn("SELECT pozn FROM xparameter where id='" + ss + "'");
                        if (s.Length == 0)
                        {
                            s = RRsql.RunSqlReturn("SELECT value FROM xparameter where id='" + ss + "'");
                        }
                        ws("A" + (iRow).ToString(), myStyleBoldBorder);
                        ws("B" + (iRow).ToString(), myStyleBoldBorder);
                        ws("C" + (iRow).ToString(), myStyleBoldBorder);
                        ws("D" + (iRow).ToString(), myStyleBoldBorder);
                        ws("E" + (iRow).ToString(), myStyleBoldBorder);
                        ss = "A" + (iRow).ToString();
                        j("A" + (iRow).ToString(), 4);
                        w("A" + (iRow).ToString(), "  " + s);
                        #endregion
                        #region distinct pre poznámku parametra kvoli poznamke do matrix2
                        bImHereAlready = false;
                        for (int p = 0; p < RRvar.Matrix2.Count; p++)
                        {
                            if (RRdata.MatrixRead(2, p, 0) == s)
                            {
                                bImHereAlready = true;
                            }
                        }
                        if (!bImHereAlready)
                        {
                            String[] sValue = new string[2];
                            sValue[0] = s;
                            s = RRsql.RunSqlReturn("SELECT explanation FROM xparameter where value='" + s + "'");
                            sValue[1] = s;
                            RRdata.MatrixAdd(2, sValue, false);
                        }
                        #endregion
                        #region JEDNOTKA
                        ss = RRdata.MatrixRead(5, m, 8); //id jedn
                        s = RRsql.RunSqlReturn("SELECT value FROM xjednotka where id='" + ss + "'");
                        if (s.Length == 0)
                        {
                            s = " ";
                        }
                        ws("F" + (iRow).ToString(), myStyleBoldBorder);
                        ws("G" + (iRow).ToString(), myStyleBoldBorder);
                        j("F" + (iRow).ToString(), 1);
                        // w(ss, s, (short)(nuF1.Value - 1), false, false, "center", false, 1, 1, 0, 1);
                        w("F" + (iRow).ToString(), s, myStyleMinus1CenterBorder);
                        string sJednotka = s;
                        #endregion
                        #region POZNÁMKA ???
                        s = RRdata.MatrixRead(5, m, 14); //poznamka
                        string sPozn = s.Replace(".", ",");
                        #endregion
                        #region MEDZA
                        s = RRdata.MatrixRead(5, m, 12); //medza
                        ws("M" + (iRow).ToString(), myStyleMinus1CenterBorder);
                        ws("N" + (iRow).ToString(), myStyleMinus1CenterBorder);
                        j("M" + (iRow).ToString(), 1);
                        if (s.Length > 0)
                        {
                            w("M" + (iRow).ToString(), s + " " + sJednotka);
                        }
                        else
                        {
                            w("M" + (iRow).ToString(), " ", myStyleMinus1CenterBorder);
                        }
                        #endregion
                        #region STOPA
                        string sStopa = "< " + s;
                        #endregion
                        #region AKREDITOVANE - TYP SKÚŠKY
                        if (RRdata.MatrixRead(5, m, 9).ToLower() == "true")
                        {
                            s = "A";
                        }
                        else
                        {
                            s = "N";
                        }
                        ws("V" + (iRow).ToString(), myStyleCenterBorder);
                        ws("W" + (iRow).ToString(), myStyleCenterBorder);
                        j("V" + (iRow).ToString(), 1);
                        w("V" + (iRow).ToString(), s);
                        #endregion
                        #region HODNOTA
                        s = RRdata.MatrixRead(5, m, 10);
                        /////////////////////// FORMATOVANIE HODNOTY
                        if (s.Length == 0)
                        {
                            s = " ";
                        }
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
                        ws("H" + (iRow).ToString(), myStyleCenterBorder);
                        ws("I" + (iRow).ToString(), myStyleCenterBorder);
                        ws("J" + (iRow).ToString(), myStyleCenterBorder);
                        j("H" + (iRow).ToString(), 2);
                        w("H" + (iRow).ToString(), s);
                        #endregion
                        #region NEISTOTA
                        s = RRdata.MatrixRead(5, m, 11); //neistota
                        if (s.Length == 0)
                        {
                            s = " ";
                        }
                        ws("K" + (iRow).ToString(), myStyleCenterBorder);
                        ws("L" + (iRow).ToString(), myStyleCenterBorder);
                        j("K" + (iRow).ToString(), 1);
                        w("K" + (iRow).ToString(), s);
                        #endregion
                        #region PRINCIP
                        ss = RRdata.MatrixRead(5, m, 5); //princip
                        s = RRsql.RunSqlReturn("SELECT value FROM xprincip where id='" + ss + "'");
                        if (s.Length == 0)
                        {
                            s = " ";
                        }
                        ws("O" + (iRow).ToString(), myStyleCenterBorder);
                        ws("P" + (iRow).ToString(), myStyleCenterBorder);
                        ws("Q" + (iRow).ToString(), myStyleCenterBorder);
                        j("O" + (iRow).ToString(), 2);
                        w("O" + (iRow).ToString(), s);
                        #endregion
                        #region distinct pre princíp kvoli vysvetlivke do matrix3
                        bImHereAlready = false;
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
                        #endregion
                        #region NORMA

                        if (RRdata.MatrixRead(5, m, 6).Length > 0)
                        {
                            s = RRsql.RunSqlReturn("SELECT value FROM xozn where id='" + ss + "'");
                        }
                        else
                        {
                            s = " ";
                        }
                        ws("R" + (iRow).ToString(), myStyleMinus1CenterBorder);
                        ws("S" + (iRow).ToString(), myStyleMinus1CenterBorder);
                        ws("T" + (iRow).ToString(), myStyleMinus1CenterBorder);
                        ws("U" + (iRow).ToString(), myStyleMinus1CenterBorder);
                        j("R" + (iRow).ToString(), 3);
                        //w(ss, s, (short)(nuF1.Value - 1), false, false, "center", false, 1, 1, 0, 1);
                        w("R" + (iRow).ToString(), s);
                        #endregion
                    }
                    iRow++;
                    iRow++;
                }
            }
                #endregion
            #endregion
            #region KOMENTARE
            iRow--;
            iRow--;
            //povinne texty
            RRdata.MatrixFill(1, "SELECT config.value FROM config WHERE config.item LIKE 'Pro2text%' ORDER BY config.item;", true);
            for (int i = 0; i < RRvar.Matrix1.Count; i++)
            {
                Typ1PageComment(RRdata.MatrixRead(1, i, 0));
            }
            //doplnenie IP natvrdo do vysvetliviek
            String[] sIP = new string[2];
            sIP[0] = "IP";
            sIP[1] = "interný predpis";
            RRdata.MatrixAdd(3, sIP, false);
            //vysvetlivky
            iRow++;
            Typ1PageHeaderExplanatory();
            for (int i = 0; i < RRvar.Matrix3.Count; i++)
            {
                Typ1PageExplanatory(RRdata.MatrixRead(3, i, 0), RRdata.MatrixRead(3, i, 1));
            }
            //poznamky
            iRow++;
            Typ1PageHeaderNotes();
            for (int i = 0; i < RRvar.Matrix2.Count; i++)
            {
                Typ1PageNotes(RRdata.MatrixRead(2, i, 1));
            }
            //podpisy
            iRow++; iRow++; iRow++;
            Typ1PagePersons();
            #endregion
            #region CISLA STRAN
            for (int q = 0; q < iSheetNameToCreate - 1; q++)
            {
                xSheet = xBook.GetSheetAt(q);

                if (q == 0)
                {
                    w("W13", "Strana 1 z počtu " + (iSheetNameToCreate - 1).ToString(), myStyleAlignR);
                }
                else
                {
                    w("W2", "Strana " + (q + 1).ToString() + " z počtu " + (iSheetNameToCreate - 1).ToString(), myStyleAlignR);
                }
            }
            #endregion
            SaveProtokol();
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
                w("W2", "Strana 1 z počtu 1", myStyleAlignR);
                w("W3", "Počet príloh: " + nuPriloha.Value.ToString(), (short)(nuF1.Value), false, false, "topright", false, 0, 0, 0, 0);
                iRow = 5;
                Typ1TableHeader(i, true);
            }
        }
        #endregion
        #region HLAVICKA S PRECHODOM NA NOVU STRANU
        //Hlavicka tabulky
        private void Typ1TableHeader(int i, bool bSplitOnNewPage)
        {
            string s = "";
            //for (int l = 1; l < 23; l++)
            //{
                //wNum(l + 1, iRow, 0, 1, 0, 1);
            //}

            s = "  Laboratórne číslo " + RRdata.MatrixRead(4, i, 0) + " / " + RRdata.MatrixRead(4, i, 1);
            if (bSplitOnNewPage)
            {
                s += " - pokračovanie";
            }
            w("A" + (iRow).ToString(), s, myStyleBoldPlus1LeftBorderLTB);
            ws("B" + (iRow).ToString(), myStyleBorderTB);
            ws("C" + (iRow).ToString(), myStyleBorderTB);
            ws("D" + (iRow).ToString(), myStyleBorderTB);
            ws("E" + (iRow).ToString(), myStyleBorderTB);
            ws("F" + (iRow).ToString(), myStyleBorderTB);
            ws("G" + (iRow).ToString(), myStyleBorderTB);
            ws("H" + (iRow).ToString(), myStyleBorderTB);
            ws("I" + (iRow).ToString(), myStyleBorderTB);
            ws("J" + (iRow).ToString(), myStyleBorderTB);
            ws("K" + (iRow).ToString(), myStyleBorderTB);
            ws("L" + (iRow).ToString(), myStyleBorderTB);
            ws("M" + (iRow).ToString(), myStyleBorderTB);
            ws("N" + (iRow).ToString(), myStyleBorderTB);
            ws("O" + (iRow).ToString(), myStyleBorderTB);
            ws("P" + (iRow).ToString(), myStyleBorderTB);
            ws("Q" + (iRow).ToString(), myStyleBorderTB);
            ws("R" + (iRow).ToString(), myStyleBorderTB);
            ws("S" + (iRow).ToString(), myStyleBorderTB);
            ws("T" + (iRow).ToString(), myStyleBorderTB);
            ws("U" + (iRow).ToString(), myStyleBorderTB);
            ws("V" + (iRow).ToString(), myStyleBorderTB);
            
            if (RRdata.MatrixRead(4, i, 2).Length > 0)
            {
                s = "Označenie: " + RRdata.MatrixRead(4, i, 2);
            }
            else
            {
                s = " " + RRdata.MatrixRead(4, i, 2);
            }
            w("W" + (iRow).ToString(), s, myStyleRightBorderRTB);

            iRow++;
            ws("A" + (iRow).ToString(), myStyleCurBorder);
            ws("A" + (iRow + 1).ToString(), myStyleCurBorder);
            ws("B" + (iRow).ToString(), myStyleCurBorder);
            ws("B" + (iRow + 1).ToString(), myStyleCurBorder);
            ws("C" + (iRow).ToString(), myStyleCurBorder);
            ws("C" + (iRow + 1).ToString(), myStyleCurBorder);
            ws("D" + (iRow).ToString(), myStyleCurBorder);
            ws("D" + (iRow + 1).ToString(), myStyleCurBorder);
            ws("E" + (iRow).ToString(), myStyleCurBorder);
            ws("E" + (iRow + 1).ToString(), myStyleCurBorder);

            ws("A" + (iRow).ToString(), myStyleCurCenterBorder);
            ws("A" + (iRow + 1).ToString(), myStyleCurCenterBorder);
            ws("B" + (iRow).ToString(), myStyleCurCenterBorder);
            ws("B" + (iRow + 1).ToString(), myStyleCurCenterBorder);
            ws("C" + (iRow).ToString(), myStyleCurCenterBorder);
            ws("C" + (iRow + 1).ToString(), myStyleCurCenterBorder);
            ws("D" + (iRow).ToString(), myStyleCurCenterBorder);
            ws("D" + (iRow + 1).ToString(), myStyleCurCenterBorder);
            ws("E" + (iRow).ToString(), myStyleCurCenterBorder);
            ws("E" + (iRow + 1).ToString(), myStyleCurCenterBorder);
            ws("F" + (iRow).ToString(), myStyleCurCenterBorder);
            ws("F" + (iRow + 1).ToString(), myStyleCurCenterBorder);
            ws("G" + (iRow).ToString(), myStyleCurCenterBorder);
            ws("G" + (iRow + 1).ToString(), myStyleCurCenterBorder);
            ws("H" + (iRow).ToString(), myStyleCurCenterBorder);
            ws("H" + (iRow + 1).ToString(), myStyleCurCenterBorder);
            ws("I" + (iRow).ToString(), myStyleCurCenterBorder);
            ws("I" + (iRow + 1).ToString(), myStyleCurCenterBorder);
            ws("J" + (iRow).ToString(), myStyleCurCenterBorder);
            ws("J" + (iRow + 1).ToString(), myStyleCurCenterBorder);
            ws("K" + (iRow).ToString(), myStyleCurCenterBorder);
            ws("K" + (iRow + 1).ToString(), myStyleCurCenterBorder);
            ws("L" + (iRow).ToString(), myStyleCurCenterBorder);
            ws("L" + (iRow + 1).ToString(), myStyleCurCenterBorder);
            ws("M" + (iRow).ToString(), myStyleCurCenterBorder);
            ws("M" + (iRow + 1).ToString(), myStyleCurCenterBorder);
            ws("N" + (iRow).ToString(), myStyleCurCenterBorder);
            ws("N" + (iRow + 1).ToString(), myStyleCurCenterBorder);
            ws("O" + (iRow).ToString(), myStyleCurCenterBorder);
            ws("O" + (iRow + 1).ToString(), myStyleCurCenterBorder);
            ws("P" + (iRow).ToString(), myStyleCurCenterBorder);
            ws("P" + (iRow + 1).ToString(), myStyleCurCenterBorder);
            ws("Q" + (iRow).ToString(), myStyleCurCenterBorder);
            ws("Q" + (iRow + 1).ToString(), myStyleCurCenterBorder);
            ws("R" + (iRow).ToString(), myStyleCurCenterBorder);
            ws("R" + (iRow + 1).ToString(), myStyleCurCenterBorder);
            ws("S" + (iRow).ToString(), myStyleCurCenterBorder);
            ws("S" + (iRow + 1).ToString(), myStyleCurCenterBorder);
            ws("T" + (iRow).ToString(), myStyleCurCenterBorder);
            ws("T" + (iRow + 1).ToString(), myStyleCurCenterBorder);
            ws("U" + (iRow).ToString(), myStyleCurCenterBorder);
            ws("U" + (iRow + 1).ToString(), myStyleCurCenterBorder);
            ws("V" + (iRow).ToString(), myStyleCurCenterBorder);
            ws("V" + (iRow + 1).ToString(), myStyleCurCenterBorder);
            ws("W" + (iRow).ToString(), myStyleCurCenterBorder);
            ws("W" + (iRow + 1).ToString(), myStyleCurCenterBorder);

            j("A" + (iRow).ToString(), 4, 1);
            w("A" + (iRow).ToString(), "  Parameter");
            j("H" + (iRow).ToString(), 2, 1);
            w("H" + (iRow).ToString(), "Hodnota");
            j("F" + (iRow).ToString(), 1, 1);
            w("F" + (iRow).ToString(), "Jednotka");
            j("K" + (iRow).ToString(), 1, 1);
            w("K" + (iRow).ToString(), "Rozšírená neistota[%]");
            j("M" + (iRow).ToString(), 1, 1);
            w("M" + (iRow).ToString(), "Medza stanovenia");
            j("O" + (iRow).ToString(), 2, 1);
            w("O" + (iRow).ToString(), "Metóda");
            j("R" + (iRow).ToString(), 3, 1);
            w("R" + (iRow).ToString(), "Metodický predpis");
            j("V" + (iRow).ToString(), 1, 1);
            w("V" + (iRow).ToString(), "Typ skúšky");

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
            if (iRow < 60)
            {
                iRow++;
            }
            else
            {
                Typ1JumpToNewPageInit();
            }
            w("A" + (iRow + 1).ToString(), sRow);
        }
        private void Typ1PageExplanatory(string sRowA, string sRowC)
        {
            if (iRow < 60)
            {
                iRow++;
            }
            else
            {
                Typ1JumpToNewPageInit();
            }
            w("A" + (iRow + 1).ToString(), sRowA, myStyleBold);
            w("E" + (iRow + 1).ToString(), sRowC);
        }
        private void Typ1PageHeaderExplanatory()
        {
            string s = "";
            string ss = "";
            if (iRow < 57)
            {
                iRow++;
            }
            else
            {
                Typ1JumpToNewPageInit();
            }
            w("A" + (iRow + 1).ToString(), "Popis skratiek:", myStyleCur);
        }
        private void Typ1PageNotes(string sRowA)
        {
            if (sRowA.Length > 1)
            {
                if (iRow < 60)
                {
                    iRow++;
                }
                else
                {
                    Typ1JumpToNewPageInit();
                }
                w("A" + (iRow + 1).ToString(), sRowA);
            }
        }
        private void Typ1PageHeaderNotes()
        {
            if (iRow < 57)
            {
                iRow++;
            }
            else
            {
                Typ1JumpToNewPageInit();
            }
            w("A" + (iRow + 1).ToString(), "Poznámky:", myStyleCur);
        }
        private void Typ1PagePersons()
        {
            if (iRow < 52)
            {
                iRow++;
            }
            else
            {
                Typ1JumpToNewPageInit();
            }
            w("A" + (iRow).ToString(), "Výsledky preskúmal a schválil:", myStyleCur);
            w("A" + (iRow + 6).ToString(), "Protokol o skúške schválil:", myStyleCur);
            w("R" + (iRow + 1).ToString(), tResult1.Text, (short)(nuF1.Value), true, false, "center", false, 0, 0, 0, 0);
            w("R" + (iRow + 2).ToString(), tResult2.Text, (short)(nuF1.Value), false, false, "center", false, 0, 0, 0, 0);
            w("R" + (iRow + 7).ToString(), tBoss1.Text, (short)(nuF1.Value), true, false, "center", false, 0, 0, 0, 0);
            w("R" + (iRow + 8).ToString(), tBoss2.Text, (short)(nuF1.Value), false, false, "center", false, 0, 0, 0, 0);
        }
        private void Typ1JumpToNewPageInit()
        {
            string s;
            InitXLS();
            rSize(1, 40);
            s = "Protokol o skúške č. " + RRvar.iProtoNo1.ToString() + "/" + RRvar.iProtoNo2.ToString();
            w("L1", s, (short)(nuF2.Value), true, false, "center", false, 0, 0, 0, 0);
            w("W2", "Strana 1 z počtu 1", myStyleAlignR);
            w("W3", "Počet príloh: " + nuPriloha.Value.ToString(), (short)(nuF1.Value), false, false, "topright", false, 0, 0, 0, 0);
            iRow = 3;
        }
        #endregion
        #region ULOZ SUBOR
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
        #endregion
        #endregion
    }
}



