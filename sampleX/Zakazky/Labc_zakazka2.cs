using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using MySql.Data.MySqlClient;
//using Microsoft.VisualBasic.PowerPacks;
using System.Diagnostics;
using System.IO;
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
    public partial class Labc_zakazka2 : Form
    {
        #region UVOD - TODO EDIT VALUES
        int iSort = 0;
        string sFilter = "";
        BindingSource bs = new BindingSource();
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable dt = new DataTable();

        string SqlSelectCommand = "SELECT `labc`, `rok`, `ozn`, pozn_labc AS pozn, `obj_no`, `zakazka_no`, `nazov`, `autor`, `stamp`, `id`, `zakazka_id` FROM `samplex`.`labc_zakazka` " + RRvar.sTemp;
        string SqlInsertCommand = "";
        string SqlUpdateCommand = "UPDATE `labc` SET `ozn` = @ozn, `pozn` = @pozn, `refe_id` = @refe_id  WHERE (`id` = @id)";
        string SqlDeleteCommand = "";

        MySqlCommand mySqlSelectCommand;
        MySqlCommand mySqlUpdateCommand;
        MySqlCommand mySqlInsertCommand;
        MySqlCommand mySqlDeleteCommand;

        MySqlConnection con = new MySqlConnection(RRvar.sConStr);
        MySqlConnection MyDataConnect = new MySqlConnection(RRvar.sConStr);

        ListSortDirection oldSortOrder;
        DataGridViewColumn oldSortCol;
        string oldFilter = "";
        int oldCombo = 0;
        bool bInsertIsRunning = false;
        RRcode RRcode = new RRcode();
        RRfun RRfun = new RRfun();
        RRsql RRsql = new RRsql();
        RRdata RRdata = new RRdata();
        RRstring RRstring = new RRstring();
        bool bStarting = true;

        public Labc_zakazka2()
        {
            InitializeComponent();
            da = new MySqlDataAdapter();
            bs.DataSource = dt;
            dg.DataSource = bs;
            bn.BindingSource = bs;
            //myDataSource();
        }

        private void Headers()
        {
            //dg.ReadOnly = false;
            //dg.Columns[0].ReadOnly = true;
            dg.Columns[0].HeaderText = "labc";
            dg.Columns[1].HeaderText = "rok";
            dg.Columns[2].HeaderText = "označenie";
            dg.Columns[3].HeaderText = "popis";
            dg.Columns[4].HeaderText = "obj";
            dg.Columns[5].HeaderText = "zák";
            dg.Columns[6].HeaderText = "objednávateľ";
            dg.Columns[7].HeaderText = "autor";
            dg.Columns[8].HeaderText = "zmenené";
            //dg.Columns[25].HeaderText = "Názov2";
            dg.Columns[9].HeaderText = "id1";
            dg.Columns[10].HeaderText = "id2";
            //dg.Columns[9].Visible = false;
            //dg.Columns[10].Visible = false;
            dg.Columns["autor"].Visible = false;

        }

        private void myDgReload()
        {
            try
            {
                myBsReload();
                myFill();
                bs.DataSource = dt;
                bn.BindingSource = bs;
                dg.DataSource = dt;
            }
            catch { }
        }
        #endregion

        #region ELEMENTY DEFINOVANE - EDIT!!!
        private void myDataSource()
        {
            id_.DataBindings.Add("Text", bs, "id", false, DataSourceUpdateMode.OnPropertyChanged);
            ozn_.DataBindings.Add("Text", bs, "ozn", false, DataSourceUpdateMode.OnPropertyChanged);
            labc_.DataBindings.Add("Text", bs, "labc", false, DataSourceUpdateMode.OnPropertyChanged);
            rok_.DataBindings.Add("Text", bs, "rok", false, DataSourceUpdateMode.OnPropertyChanged);
            obj_no_.DataBindings.Add("Text", bs, "obj_no", false, DataSourceUpdateMode.OnPropertyChanged);
            zakazka_no_.DataBindings.Add("Text", bs, "zakazka_no", false, DataSourceUpdateMode.OnPropertyChanged);
            nazov_.DataBindings.Add("Text", bs, "nazov", false, DataSourceUpdateMode.OnPropertyChanged);
            pozn_.DataBindings.Add("Text", bs, "pozn", false, DataSourceUpdateMode.OnPropertyChanged);
            mySqlUpdateCommand.Parameters.AddWithValue("@id", id_.Text);
            mySqlUpdateCommand.Parameters.AddWithValue("@ozn", ozn_.Text);
            mySqlUpdateCommand.Parameters.AddWithValue("@pozn", pozn_.Text);
            mySqlUpdateCommand.Parameters.AddWithValue("@refe_id", RRvar.idUser);
        }
        #endregion 

        private void Labc_zakazka2_Load(object sender, EventArgs e)
        {
            if (!RRdata.bAuth("z-rw"))
            {
                dr.Enabled = false;
                bindingNavigatorDeleteItem.Enabled = false;
                bindingNavigatorAddNewItem.Enabled = false;
            }

            MyDataConnect.Open();
            mySqlSelectCommand = new MySqlCommand(SqlSelectCommand, MyDataConnect);
            mySqlUpdateCommand = new MySqlCommand(SqlUpdateCommand, MyDataConnect);
            da.SelectCommand = mySqlSelectCommand;
            da.UpdateCommand = mySqlUpdateCommand;
            this.da.Fill(dt);
            MyDataConnect.Close();
            myDataSource();

            this.Text = RRvar.sHeader;
            lStatus.Text = RRvar.sFooter;
            dg.MultiSelect = true;
            //this.Size = new Size(Screen.PrimaryScreen.Bounds.Width - 40, Screen.PrimaryScreen.Bounds.Height - 60);
            //this.Location = new Point(20, 10);
            DoubleBuffered(dg, true);
            this.WindowState = FormWindowState.Maximized;
            RRcode.Front();
            RRcode.FadeIn(this);
            myFill();
            cFilter.Items.Insert(0, "VŠETKO");
            int i = 0;
            foreach (DataGridViewColumn column in dg.Columns)
            {
                i++;
                cFilter.Items.Insert(i, column.HeaderText);
            }
            Application.DoEvents();
            UD1.Value = RRvar.iLabelsFont1;
            UD2.Value = RRvar.iLabelsFont2;
            UD3.Value = RRvar.iLabelsColumnSize;
            UD4.Value = RRvar.iLabelsRowSize;

            cFilter.SelectedIndex = 0;
            dg.Visible = true;
            pictureBox1.Visible = true;
            bExcel.Visible = true;
            bProto.Visible = true;
            bSelect.Visible = true;
            ActiveControl = dg;
            bindingNavigatorDeleteItem.Enabled = false;
            bStarting = false;
        }

        #region MANIPULACIA - VALIDATE DELETE ENDEDIT
        private void myTaUpdate()
        {
            mySqlUpdateCommand.Parameters["@id"].Value = id_.Text;
            mySqlUpdateCommand.Parameters["@ozn"].Value = ozn_.Text;
            mySqlUpdateCommand.Parameters["@pozn"].Value = pozn_.Text;
            mySqlUpdateCommand.Parameters["@refe_id"].Value = RRvar.idUser;
            try
            {
                da.Update(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void myFill()
        {
            dt.Clear();
            this.da.Fill(dt);
        }

        private void myBsReload()
        {
            try
            {
                dg.DataSource = null;
                dg.DataSource = bs;
            }
            catch { }
        }

        private void myDelete()
        {
            try
            {
                bs.EndEdit();
                bs.RemoveCurrent();
                myTaUpdate();
            }
            catch { }
        }

        private void myEndEdit(bool bValidate)
        {
            try
            {
                if (bValidate)
                {
                    this.Validate();
                }
                bs.EndEdit();

            }
            catch { }

            myTaUpdate();

        }
        #endregion

        #region PODPORNE FUNKCIE - RESIZE F12 BUFFER FILTER
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            RRfun.ShowMyInfoToolTip(pictureBox1.Location.X + 50, pictureBox1.Location.Y + 50, this);
        }

        private void myResize()
        {
            bn.Location = new Point(5, 5);
            //bExcel.Visible = false;
            bSelect.Location = new Point(5, dr.Height + bn.Height + 10);
            bProto.Location = new Point(5, dr.Height + bn.Height + 57);
            bExcel.Location = new Point(5, dr.Height + bn.Height + 54 + 50);

            l0.Location = new Point(5, dr.Height + bn.Height + 60 + 45 + 55);
            l1.Location = new Point(5, dr.Height + bn.Height + 60 + 60 + 57);
            UD1.Location = new Point(5, dr.Height + bn.Height + 60 + 60 + 73);

            l2.Location = new Point(5, dr.Height + bn.Height + 60 + 60 + 104);
            UD2.Location = new Point(5, dr.Height + bn.Height + 60 + 60 + 120);

            l3.Location = new Point(5, dr.Height + bn.Height + 60 + 60 + 151);
            UD3.Location = new Point(5, dr.Height + bn.Height + 60 + 60 + 167);

            l4.Location = new Point(5, dr.Height + bn.Height + 60 + 60 + 198);
            UD4.Location = new Point(5, dr.Height + bn.Height + 60 + 60 + 214);

            l5.Location = new Point(5, dr.Height + bn.Height + 60 + 60 + 245);
            UD5.Location = new Point(5, dr.Height + bn.Height + 60 + 60 + 261);

            //bPass.Location = new Point(5 + bExcel.Height + 3, dr.Height + bn.Height + 10);
            pictureBox1.Location = new Point(5, this.Size.Height - 120);
            dr.Location = new Point(5, 35);
            dg.Location = new Point(5 + 5 + 40 + dr.Width, 35);
            dg.Size = new Size(this.Size.Width - 35 - dr.Width - 40, this.Size.Height - 105);
            Application.DoEvents();
        }

        private void dg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F12)
            {
                myClip();
            }
        }

        private void myClip()
        {
            try
            {
                int iX = dg.CurrentCellAddress.X;
                int iLastCell = dg.CurrentCellAddress.Y;
                string strID = dg.Rows[iLastCell].Cells[0].Value.ToString();
                int FirstDisplayedScrollingRowIndex = dg.FirstDisplayedScrollingRowIndex;
                dg.MultiSelect = true;
                dg.SelectAll();
                DataObject dataObj = dg.GetClipboardContent();
                Clipboard.SetDataObject(dataObj, true);
                IDataObject myDataObject = Clipboard.GetDataObject();
                myDataObject.GetData(DataFormats.UnicodeText);
                Clipboard.SetDataObject(myDataObject.GetData(DataFormats.UnicodeText), true);
                //dg.MultiSelect = false;
                dg.FirstDisplayedScrollingRowIndex = FirstDisplayedScrollingRowIndex;
                dg.Rows[iLastCell].Selected = true;
                dg.CurrentCell = dg[2, iLastCell];
                dg.CurrentCell = dg[1, iLastCell];
                dg.CurrentCell = dg[iX, iLastCell];
                MessageBox.Show("Údaje z tabuľky boli uložené do schránky...", "Informácia", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch { }
        }

        public static void DoubleBuffered(DataGridView dgv, bool bvalue)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, bvalue, null);
        }

        private void myFilter()
        {
            try
            {
                if (cFilter.SelectedIndex != 0)
                {
                    bs.Filter = "Convert([" + cFilter.Text + "], 'System.String') LIKE '%" + tSearch.Text + "%'";
                }
                else
                {
                    sFilter = "";
                    if (tSearch.Text.Length > 0)
                    {
                        int i = 0;
                        foreach (DataGridViewColumn column in dg.Columns)
                        {
                            if (i > 0) sFilter += " OR ";
                            i++;
                            //cFilter.Items.Insert(i, column.HeaderText);
                            sFilter += "Convert([" + column.Name + "], 'System.String') LIKE '%" + tSearch.Text + "%'";
                        }
                        bs.Filter = sFilter;
                    }
                    else
                    {
                        bs.Filter = null;
                    }
                }
            }
            catch { }
        }

        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);

        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags,
        UIntPtr dwExtraInfo);

        private void ChildFormClosedFull(object sender, EventArgs e)
        {
            this.Enabled = true;
            RRcode.Front();
            this.Close();
        }

        private void ChildFormClosedProto(object sender, EventArgs e)
        {
            RRcode.FadeIn(this);
            this.Visible = true;
            RRcode.Front();
        }
        #endregion

        #region FILTER FORM - ITEMS TSEARCH CFILTER CELLPAINTING
        private void tSearch_TextChanged(object sender, EventArgs e)
        {
            myFilter();
        }

        private void cFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            myFilter();
        }

        private void dg_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1 && dg.Columns[e.ColumnIndex].Name != "Id")
                {
                    if (!String.IsNullOrEmpty(tSearch.Text))
                    {
                        String gridCellValue = e.FormattedValue.ToString();
                        int startIndexInCellValue;
                        startIndexInCellValue = gridCellValue.ToLower().IndexOf(tSearch.Text.ToLower());

                        if (startIndexInCellValue >= 0)
                        {
                            try
                            {
                                if (!(e.Value.ToString().ToLower() == "true" || e.Value.ToString().ToLower() == "false"))
                                {
                                    e.Handled = true;
                                    e.PaintBackground(e.CellBounds, true);
                                    //the highlite rectangle  
                                    Rectangle hl_rect = new Rectangle();
                                    hl_rect.Y = e.CellBounds.Y + 2;
                                    hl_rect.Height = e.CellBounds.Height - 5;
                                    String sBeforeSearchword = gridCellValue.Substring(0, startIndexInCellValue);
                                    String sSearchWord = gridCellValue.Substring(startIndexInCellValue, tSearch.Text.Length);
                                    Size s1 = TextRenderer.MeasureText(e.Graphics, sBeforeSearchword, e.CellStyle.Font, e.CellBounds.Size);
                                    Size s2 = TextRenderer.MeasureText(e.Graphics, sSearchWord, e.CellStyle.Font, e.CellBounds.Size);
                                    if (s1.Width > 5)
                                    {
                                        hl_rect.X = e.CellBounds.X + s1.Width - 5;
                                        hl_rect.Width = s2.Width - 6;
                                    }
                                    else
                                    {
                                        hl_rect.X = e.CellBounds.X + 2;
                                        hl_rect.Width = s2.Width - 6;
                                    }

                                    SolidBrush hl_brush;
                                    hl_brush = new SolidBrush(Color.Lime);
                                    e.Graphics.FillRectangle(hl_brush, hl_rect);
                                    hl_brush.Dispose();
                                    e.PaintContent(e.CellBounds);
                                }
                            }
                            catch { }
                        }
                    }
                }
            }
            catch { }
        }
        #endregion

        #region FORM ITEMS

        private void dg_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            myEndEdit(true);
        }

        private void Labc_zakazka2_Resize(object sender, EventArgs e)
        {
            myResize();
        }

        private void bn_Validated(object sender, EventArgs e)
        {
            myEndEdit(false);
        }

        private void dr_Validated(object sender, EventArgs e)
        {
            myEndEdit(false);
        }

        private void poznTextBox_Validated(object sender, EventArgs e)
        {
            int FirstDisplayedScrollingRowIndex = dg.FirstDisplayedScrollingRowIndex;
            int FirstDisplayedScrollingColumnIndex = dg.FirstDisplayedScrollingColumnIndex;
            if (bInsertIsRunning)
            {
                return;
            }
            myBsReload();
            myEndEdit(true);
            try
            {
                dg.FirstDisplayedScrollingRowIndex = FirstDisplayedScrollingRowIndex;
                dg.FirstDisplayedScrollingColumnIndex = FirstDisplayedScrollingColumnIndex;
            }
            catch { }
            Headers();
        }

        private void Labc_zakazka2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //RRvar.sTemp = "";
            RRvar.bSelect = false;
            //object o = MySqlHelper.ExecuteScalar(RRvar.sConStr, "delete from refe where (login='' or login is null) and (fullname='' or fullname is null);");
            RRcode.FadeOut(this);
        }
        #endregion

        #region INSERT - ADDBUTTON OK MYINSERT
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bExcel.Visible = false;
            bSelect.Visible = false;
            bInsertIsRunning = true;
            oldSortOrder = dg.SortOrder == SortOrder.Ascending ? ListSortDirection.Ascending : ListSortDirection.Descending;
            oldSortCol = dg.SortedColumn;
            oldFilter = tSearch.Text;
            tSearch.Text = "";
            oldCombo = cFilter.SelectedIndex;
            cFilter.SelectedIndex = 0;
            dr.Focus();
            bs.Position = dg.RowCount;
            dg.Enabled = false;
            dg.Visible = false;
            bOK.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = false;
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorCountItem.Enabled = false;
            bindingNavigatorMoveFirstItem.Enabled = false;
            bindingNavigatorMoveLastItem.Enabled = false;
            bindingNavigatorMoveNextItem.Enabled = false;
            bindingNavigatorMovePreviousItem.Enabled = false;
            bindingNavigatorPositionItem.Enabled = false;

            id_.Text = "NOVÝ";
            foreach (Control ctr in dr.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = "";
                }
            }
            labc_.Text = "---";
            partner_id_.Text = "---";
            expired_.Text = "False";
            rok_.Text = RRvar.iRok.ToString();
            ozn_.Focus();

            int i = 0;
            string sSql =
            "select count(id) as total from last where " +
            "rok = '" + RRvar.iRok.ToString() + "' and nazov = 'O';";

            i = Convert.ToInt16(RRsql.RunSqlReturn(sSql));

            if (i == 0)
            {
                sSql =
                "INSERT INTO last (nazov, hodnota, rok) VALUES " +
                "('O', 0, " + RRvar.iRok.ToString() + ");";
                try
                {
                    RRsql.RunSql(sSql);
                }
                catch { }
            }
            RRvar.bSelect = true;
        }


        private void bOK_Click(object sender, EventArgs e)
        {
            if (!RRstring.IsNumeric(partner_id_.Text))
            {
                MessageBox.Show("Nie je zvolený zákazník.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);

                return;
            }

            bool bSuccessWrite = true;
            int iNumberNext = 0;
            bInsertIsRunning = true;
            int iNewId = 0;

            string sSql =
            "select hodnota from last where " +
            "rok = '" + RRvar.iRok.ToString() + "' and nazov = 'O';";

            iNumberNext = Convert.ToInt16(RRsql.RunSqlReturn(sSql));
            iNumberNext++;


            //MySqlCommand cmd = new MySqlCommand(da.Adapter.InsertCommand.CommandText, con);
            MySqlCommand cmd = new MySqlCommand(SqlInsertCommand, con);
            //INSERT INTO `refe` (`login`, `fullname`, `password`, `l1`, `l2`, `l3`, `l4`, `l5`, `l6`, `l7`, `l8`, `active`) VALUES (@login, @fullname, @password, @l1, @l2, @l3, @l4, @l5, @l6, @l7, @l8, @active)
            //"`no`, `ico`, `dic`, `nazov1`, `nazov2`, `ulica`, `mesto`, `psc`, `meno`, `titul`, `prie`, `funkcia`, `tel`, `banka`, `ucet`, `pozn`) VALUES (@no, @ico, @dic, @nazov1, @nazov2, @ulica, @mesto, @psc, @meno, @titul, @prie, @funkcia, @tel, @banka, @ucet, @pozn)
            string s, d;
            Control[] c;

            d = "no";
            s = d + "_";
            c = this.Controls.Find(s, true);
            //cmd.Parameters.AddWithValue("@" + d, (c[0] as TextBox).Text);
            cmd.Parameters.AddWithValue("@" + d, iNumberNext);

            d = "rok";
            s = d + "_";
            c = this.Controls.Find(s, true);
            cmd.Parameters.AddWithValue("@" + d, (c[0] as TextBox).Text);

            d = "cobj";
            s = d + "_";
            c = this.Controls.Find(s, true);
            cmd.Parameters.AddWithValue("@" + d, (c[0] as TextBox).Text);

            d = "czml";
            s = d + "_";
            c = this.Controls.Find(s, true);
            cmd.Parameters.AddWithValue("@" + d, (c[0] as TextBox).Text);

            d = "partner_id";
            s = d + "_";
            c = this.Controls.Find(s, true);
            cmd.Parameters.AddWithValue("@" + d, (c[0] as Label).Text);

            d = "datum";
            s = d + "_";
            c = this.Controls.Find(s, true);
            cmd.Parameters.AddWithValue("@" + d, (c[0] as DateTimePicker).Value);

            d = "expired";
            s = d + "_";
            c = this.Controls.Find(s, true);
            cmd.Parameters.AddWithValue("@" + d, (c[0] as Label).Text);

            d = "pozn1";
            s = d + "_";
            c = this.Controls.Find(s, true);
            cmd.Parameters.AddWithValue("@" + d, (c[0] as TextBox).Text);

            d = "pozn2";
            s = d + "_";
            c = this.Controls.Find(s, true);
            cmd.Parameters.AddWithValue("@" + d, "");

            cmd.Parameters.AddWithValue("@autor", RRvar.sUser);
            cmd.Parameters.AddWithValue("@stamp", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            using (System.Transactions.TransactionScope scope = new System.Transactions.TransactionScope())
            {
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    bSuccessWrite = false;
                    MessageBox.Show(ex.ToString());
                }

                con.Close();
                try
                {
                    iNewId = Convert.ToInt32(MySqlHelper.ExecuteScalar(RRvar.sConStr, "SELECT LAST_INSERT_ID();"));
                }
                catch { }
                scope.Complete();
            }


            if (bSuccessWrite)
            {
                sSql =
                "UPDATE last set hodnota = '" + iNumberNext + "' where nazov='O ' and rok='" + RRvar.iRok + "';";
                try
                {
                    RRsql.RunSql(sSql);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            //RRcode.Log("Nová objednávka: " + RRsql.RunSqlReturn("SELECT CONCAT('id:', id, ' č. ', no, '/', rok, ' - ', meno) from Labc_zakazka ORDER BY id DESC LIMIT 1;"));

            myDgReload();
            dg.Focus();
            bExcel.Visible = false;
            bSelect.Visible = true;
            dg.Enabled = true;
            dg.Visible = true;
            bOK.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = true;
            bindingNavigatorCountItem.Enabled = true;
            bindingNavigatorMoveFirstItem.Enabled = true;
            bindingNavigatorMoveLastItem.Enabled = true;
            bindingNavigatorMoveNextItem.Enabled = true;
            bindingNavigatorMovePreviousItem.Enabled = true;
            bindingNavigatorPositionItem.Enabled = true;
            bInsertIsRunning = false;
            RRvar.bSelect = false;

            try
            {
                if (oldSortCol != null)
                {
                    DataGridViewColumn newCol = dg.Columns[oldSortCol.Name];
                    dg.Sort(newCol, oldSortOrder);
                }
            }
            catch { }

            foreach (DataGridViewRow row in dg.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(iNewId.ToString()))
                {
                    try
                    {
                        dg.Rows[row.Index].Selected = false;
                        dg.Rows[row.Index].Selected = true;
                        bs.Position = row.Index;
                    }
                    catch { }
                    break;
                }
            }
            cFilter.SelectedIndex = oldCombo;
            tSearch.Text = oldFilter;
            dg.FirstDisplayedScrollingRowIndex = dg.SelectedRows[0].Index;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            string sID = dg.CurrentRow.Cells[0].Value.ToString();
            int iIndex = dg.SelectedRows[0].Index;
            if (MessageBox.Show("Určite chceš vymazať záznam č. " + sID + " ?", "Mazanie dát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (MessageBox.Show("Určite vieš, čo robíš?", "Varovanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    myDelete();
                }
            }
            int numRowCount = dg.RowCount;
            if (iIndex >= numRowCount)
            {
                try
                {
                    dg.Rows[iIndex - 1].Selected = false;
                    dg.Rows[iIndex - 1].Cells[0].Selected = true;
                }
                catch { }
            }
            else
            {
                try
                {
                    dg.Rows[iIndex].Selected = false;
                    dg.Rows[iIndex].Cells[0].Selected = true;
                }
                catch { }
            }
        }
        #endregion

        private void dg_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Chyba zápisu", "Varovanie", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void expired__TextChanged(object sender, EventArgs e)
        {
            //if (expired_.Text == "True")
            //{
            //    akr_.Checked = true;
            //}
            //else
            //{
            //    akr_.Checked = false;
            //}
        }

        private void c_expired__CheckedChanged(object sender, EventArgs e)
        {
            //if (akr_.Checked)
            //{
            //    expired_.Text = "True";
            //}
            //else
            //{
            //    expired_.Text = "False";
            //}
            //if (!bInsertIsRunning) myEndEdit(true);

        }

        private void PartnerClosed(object sender, EventArgs e)
        {
            RRcode.FadeIn(this);
            this.Visible = true;
            RRcode.Front();
        }

        private void PartnerAddClosed(object sender, EventArgs e)
        {
            RRcode.FadeIn(this);
            this.Visible = true;
            if (RRvar.iID > 0)
            {
                partner_id_.Text = RRvar.iID.ToString();
                obj_no_.Text = RRvar.sTemp;
            }

            RRcode.Front();
        }

        private void bSelect_Click(object sender, EventArgs e)
        {
            RRdata.MatrixClear(2);
            foreach (DataGridViewRow r in dg.SelectedRows)
            {
                String[] sValue = new string[4];
                sValue[0] = r.Cells[9].Value.ToString();
                sValue[1] = r.Cells[0].Value.ToString();
                sValue[2] = r.Cells[1].Value.ToString();
                try
                {
                    sValue[3] = RRsql.RunSqlReturn("select count(*) from data where labc='" + sValue[0] + "';");
                }
                catch (Exception)
                {
                    sValue[3] = "0";
                }
                RRdata.MatrixAdd(2, sValue, false);
            }
            //List<string> myList = new List<string>();
            //RRdata.MatrixClear(2);
            //foreach (DataGridViewRow r in dg.SelectedRows)
            //{
            //    myList.Add(r.Cells[9].Value.ToString());
            //}

            //String[] sValue = myList.ToArray();
            //myList.Clear();

            //RRdata.MatrixAdd(2, sValue, false);

            Form DataA = new DataA();
            DataA.Closed += new EventHandler(DataAClosed);
            RRvar.sTemp1 = nazov_.Text;
            RRvar.sTemp2 = obj_no_.Text;
            RRvar.sTemp3 = zakazka_no_.Text;
            RRvar.sTemp4 = ozn_.Text;
            RRvar.sTemp5 = rok_.Text;
            RRvar.sTemp6 = labc_.Text;
            RRvar.sTemp7 = id_.Text;
            RRvar.sHeader = "Vytvorenie požiadavky na meranie pre zákazku: " + RRvar.sTemp3 + " / " + RRvar.sTemp5;
            RRcode.FadeOut(this);
            this.Visible = false;
            DataA.Show();
        }

        private void DataAClosed(object sender, EventArgs e)
        {
            //RRcode.FadeIn(this);
            //this.Visible = true;
            //RRcode.Front();
            this.Close();
        }




        private void Labc_zakazka2_Shown(object sender, EventArgs e)
        {
            Headers();
            if (RRvar.bSelect)
            {
                bSelect.Visible = true;
            }

            if (RRvar.bFilter)
            {
                RRvar.bFilter = false;
                try
                {
                    cFilter.SelectedItem = RRvar.sFilter1;
                    tSearch.Text = RRvar.sFilter2;
                }
                catch { }
            }
        }

        private void dg_Click(object sender, EventArgs e)
        {
            try
            {
                iSort = Convert.ToInt32(dg.Rows[dg.CurrentRow.Index].Cells[0].Value);
            }
            catch { }
        }

        private void dg_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int iRow = 0;
            foreach (DataGridViewRow row in dg.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(iSort.ToString()))
                {
                    iRow = row.Index;
                    break;
                }
            }
            try
            {
                dg.CurrentCell = dg.Rows[iRow].Cells[0];
                dg.Rows[iRow].Selected = true;
                dg.FirstDisplayedScrollingRowIndex = dg.SelectedRows[0].Index;

            }
            catch { }
        }
        private void bExcel_Click(object sender, EventArgs e)
        {
            RRcode.Log("Štítky: " + this.Text);
            RRdata.MatrixClear(2);
            RRdata.MatrixClear(4);
            foreach (DataGridViewRow rr in dg.SelectedRows)
            {
                String[] sValue = new string[6];
                sValue[0] = rr.Cells[0].Value.ToString();
                sValue[1] = rr.Cells[1].Value.ToString();
                sValue[2] = rr.Cells[2].Value.ToString();
                RRdata.MatrixAdd(2, sValue, false);
            }
            int iCount = RRvar.Matrix2.Count;

            if (UD5.Value > 0)
            {
                for (int i = 0; i < UD5.Value; i++)
                {
                    String[] sValue = new string[6];
                    sValue[0] = "";
                    sValue[1] = "";
                    sValue[2] = "";
                    RRdata.MatrixAdd(4, sValue, false);
                }
            }


            for (int i = iCount - 1; i >= 0; i--)
            {
                String[] sValue = new string[6];
                sValue[0] = RRdata.MatrixRead(2, i, 0);
                sValue[1] = RRdata.MatrixRead(2, i, 1);
                sValue[2] = RRdata.MatrixRead(2, i, 2);
                RRdata.MatrixAdd(4, sValue, false);
            }

            iCount = RRvar.Matrix4.Count;
            //
            // XLS
            //
            HSSFWorkbook xBook = new HSSFWorkbook();
            ICell xCell;
            int iSheetNumber = 1;
            int iRow = 0;
            int iCol = 0;
            string sCell = "";
            ISheet xSheet = xBook.CreateSheet();
            IRow r = xSheet.CreateRow(0);
            xBook.Clear();

            iRow = 0;
            iCol = 0;

            for (int i = 0; i < iCount; i++)
            {
                if ((i % 16) == 0)
                {
                    xSheet = xBook.CreateSheet(iSheetNumber.ToString());
                    xSheet.DefaultRowHeight = (short)(RRvar.iLabelsRowSize * 10);

                    HSSFFont myFont = (HSSFFont)xBook.CreateFont();
                    myFont.FontHeightInPoints = (short)10;
                    myFont.FontName = "Arial";
                    HSSFCellStyle myStyle = (HSSFCellStyle)xBook.CreateCellStyle();
                    myStyle.WrapText = true;
                    myStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                    myStyle.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
                    myStyle.SetFont(myFont);
                    xSheet.SetDefaultColumnStyle(0, myStyle);
                    xSheet.SetDefaultColumnStyle(1, myStyle);

                    iSheetNumber++;
                    iRow = 1;
                    r = xSheet.CreateRow(iRow);
                    xSheet.PrintSetup.PaperSize = (short)PaperSize.A4 + 1;
                    xSheet.SetMargin(MarginType.LeftMargin, 0);
                    xSheet.SetMargin(MarginType.RightMargin, 0);
                    xSheet.SetMargin(MarginType.TopMargin, 0);
                    xSheet.SetMargin(MarginType.BottomMargin, 0);
                    xSheet.SetMargin(MarginType.HeaderMargin, 0);
                    xSheet.SetMargin(MarginType.FooterMargin, 0);
                    xSheet.FitToPage = false;
                }
                if (iCol == 0)
                {
                    r = xSheet.CreateRow(iRow);
                }
                xCell = r.CreateCell(iCol);

                if (iCol == 0)
                {
                    iCol = 1;
                }
                else
                {
                    iRow++;
                    iRow++;
                    iRow++;
                    iRow++;
                    iCol = 0;
                }

                if (RRdata.MatrixRead(4, i, 0).Length > 0)
                {
                    sCell = RRdata.MatrixRead(4, i, 0) + " / " + RRdata.MatrixRead(4, i, 1);
                }
                else
                {
                    sCell = "";
                }
                xCell.SetCellValue(sCell);
            }

            //
            // 2. RIADOK
            //

            iSheetNumber = 1;
            iRow = 1;
            iCol = 0;

            for (int i = 0; i < iCount; i++)
            {
                if ((i % 16) == 0)
                {
                    xSheet = xBook.GetSheet(iSheetNumber.ToString());
                    iSheetNumber++;
                    iRow = 2;
                    r = xSheet.CreateRow(iRow);
                }
                if (iCol == 0)
                {
                    r = xSheet.CreateRow(iRow);
                }
                xCell = r.CreateCell(iCol);

                if (iCol == 0)
                {
                    iCol = 1;
                }
                else
                {
                    iRow++;
                    iRow++;
                    iRow++;
                    iRow++;
                    iCol = 0;
                }
                sCell = RRdata.MatrixRead(4, i, 2);
                xCell.SetCellValue(sCell);
            }

            //
            // FORMATOVANIE
            //
            iSheetNumber = 1;
            for (int i = 0; i < iCount; i++)
            {
                if ((i % 16) == 0)
                {
                    xSheet = xBook.GetSheet(iSheetNumber.ToString());
                    iSheetNumber++;
                    xSheet.SetColumnWidth(0, (short)RRvar.iLabelsColumnSize * 23);
                    xSheet.SetColumnWidth(1, (short)RRvar.iLabelsColumnSize * 23);

                    int iTemp = 0;

                    HSSFFont myFont1 = (HSSFFont)xBook.CreateFont();
                    myFont1.FontHeightInPoints = (short)RRvar.iLabelsFont1;
                    myFont1.FontName = "Arial";
                    myFont1.Boldweight = (short)FontBoldWeight.Bold;
                    HSSFCellStyle myStyle1 = (HSSFCellStyle)xBook.CreateCellStyle();
                    myStyle1.WrapText = true;
                    myStyle1.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                    myStyle1.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Bottom;
                    myStyle1.SetFont(myFont1);

                    HSSFFont myFont2 = (HSSFFont)xBook.CreateFont();
                    myFont2.FontHeightInPoints = (short)RRvar.iLabelsFont2;
                    myFont2.FontName = "Arial";
                    myFont2.Boldweight = (short)FontBoldWeight.Bold;
                    HSSFCellStyle myStyle2 = (HSSFCellStyle)xBook.CreateCellStyle();
                    myStyle2.WrapText = true;
                    myStyle2.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                    myStyle2.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Top;
                    myStyle2.SetFont(myFont2);

                    iTemp = 0;
                    for (int iRowToFormat = 1; iRowToFormat < 32; iRowToFormat++)
                    {
                        iTemp++;

                        if (iTemp == 1)
                        {
                            try
                            {
                                r = xSheet.GetRow(iRowToFormat);
                                r.GetCell(0).CellStyle = myStyle1;
                                r.GetCell(1).CellStyle = myStyle1;
                            }
                            catch { }
                        }
                        if (iTemp == 4)
                        {
                            iTemp = 0;
                        }
                    }

                    iTemp = 0;
                    for (int iRowToFormat = 2; iRowToFormat < 32; iRowToFormat++)
                    {
                        iTemp++;

                        if (iTemp == 1)
                        {
                            try
                            {
                                r = xSheet.GetRow(iRowToFormat);
                                r.GetCell(0).CellStyle = myStyle2;
                                r.GetCell(1).CellStyle = myStyle2;
                            }
                            catch { }
                        }
                        if (iTemp == 4)
                        {
                            iTemp = 0;
                        }
                    }

                    for (int iRowToFormat = 0; iRowToFormat < 32; iRowToFormat++)
                    {
                        try
                        {
                            r = xSheet.GetRow(iRowToFormat);
                            r.Height = (short)(RRvar.iLabelsRowSize * 10);
                        }
                        catch { }
                    }
                }
            }

            //HSSFCellStyle xTextCellStyleBorI = (HSSFCellStyle)xBook.CreateCellStyle();
            //xTextCellStyleBorI.BorderLeft = NPOI.SS.UserModel.BorderStyle.Medium;
            //xTextCellStyleBorI.BorderTop = NPOI.SS.UserModel.BorderStyle.Medium;
            //xTextCellStyleBorI.BorderRight = NPOI.SS.UserModel.BorderStyle.Medium;
            //xTextCellStyleBorI.BorderBottom = NPOI.SS.UserModel.BorderStyle.Medium;
            //xTextCellStyleBorI.DataFormat = xBook.CreateDataFormat().GetFormat("text");
            //xTextCellStyleBorI.SetFont(fontI);
            //string sRok = DateTime.Now.Year.ToString().Substring(2, 2);

            //int iCol = 1;
            //foreach (DataGridViewRow dr in dg.Rows)
            //{
            //    xCell = r.CreateCell(iCol);
            //    //xCell.CellStyle = xTextCellStyleBorBdole;
            //    xCell.SetCellValue(dr.Cells[1].Value.ToString());
            //    iCol++;
            //}
            //    xSheet.AutoSizeColumn(i);

            var xDocInfo = NPOI.HPSF.PropertySetFactory.CreateDocumentSummaryInformation();
            var xInfo = NPOI.HPSF.PropertySetFactory.CreateSummaryInformation();
            xInfo.Author = "sampleX © 2022 Róbert Repka";
            xInfo.Subject = "sampleX - tlač štítkov pre laboratórne čísla";
            xInfo.Comments = "robert@repka.org\r\n+421917799260";
            xInfo.Keywords = "štítky";
            xDocInfo.Company = "Štátny geologický ústav Dionýza Štúra, Odbor geoanalytických laboratórií, Spišská Nová Ves";

            xBook.DocumentSummaryInformation = xDocInfo;
            xBook.SummaryInformation = xInfo;

            System.Windows.Forms.SaveFileDialog SD = new System.Windows.Forms.SaveFileDialog();
            SD.Title = "Export XLS šablóny";
            SD.RestoreDirectory = true;
            SD.DefaultExt = "xls";
            SD.Filter = "MS Excel (*.xls)|*.xls";
            SD.CheckPathExists = true;
            SD.FileName = "Štítky" + " - " + DateTime.Now.ToString("yyyy'-'MM'-'dd'_'HH'-'mm'-'ss") + ".xls";

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

        private void UD1_ValueChanged(object sender, EventArgs e)
        {
            if (!bStarting)
            {
                RRvar.iLabelsFont1 = Convert.ToInt32(UD1.Value);
                RRcode.RegWrite("LabelsFont1", RRvar.iLabelsFont1.ToString());
            }
        }

        private void UD2_ValueChanged(object sender, EventArgs e)
        {
            if (!bStarting)
            {
                RRvar.iLabelsFont2 = Convert.ToInt32(UD2.Value);
                RRcode.RegWrite("LabelsFont2", RRvar.iLabelsFont2.ToString());
            }
        }

        private void UD3_ValueChanged(object sender, EventArgs e)
        {
            if (!bStarting)
            {
                RRvar.iLabelsColumnSize = Convert.ToInt32(UD3.Value);
                RRcode.RegWrite("LabelsColumnSize", RRvar.iLabelsColumnSize.ToString());
            }
        }

        private void UD4_ValueChanged(object sender, EventArgs e)
        {
            if (!bStarting)
            {
                RRvar.iLabelsRowSize = Convert.ToInt32(UD4.Value);
                RRcode.RegWrite("LabelsRowSize", RRvar.iLabelsRowSize.ToString());
            }
        }

        private void bProto_Click(object sender, EventArgs e)
        {
            RRcode.Log("Protokol: " + this.Text);
            RRdata.MatrixClear(2);
            RRdata.MatrixClear(4);
            foreach (DataGridViewRow rr in dg.SelectedRows)
            {
                String[] sValue = new string[6];
                sValue[0] = rr.Cells[0].Value.ToString();
                sValue[1] = rr.Cells[1].Value.ToString();
                sValue[2] = rr.Cells[2].Value.ToString();
                sValue[3] = rr.Cells[9].Value.ToString();
                sValue[4] = rr.Cells[10].Value.ToString();
                RRdata.MatrixAdd(2, sValue, false);
            }
            int iCount = RRvar.Matrix2.Count;

            RRvar.iProtoNo1 = 999999999;
            for (int i = iCount - 1; i >= 0; i--)
            {
                String[] sValue = new string[6];
                sValue[0] = RRdata.MatrixRead(2, i, 0);
                sValue[1] = RRdata.MatrixRead(2, i, 1);
                sValue[2] = RRdata.MatrixRead(2, i, 2);
                sValue[3] = RRdata.MatrixRead(2, i, 3);
                sValue[4] = RRdata.MatrixRead(2, i, 4);

                if (Convert.ToInt32(sValue[0]) < RRvar.iProtoNo1)
                {
                    RRvar.iProtoNo1 = Convert.ToInt32(sValue[0]);
                    RRvar.iProtoNo2 = Convert.ToInt32(sValue[1]);
                }

                RRdata.MatrixAdd(4, sValue, false);
            }

            RRcode.FadeOut(this);
            this.Visible = false;
            Form ProMenu = new ProMenu();
            ProMenu.Closed += new EventHandler(ChildFormClosedProto);
            RRvar.sHeader = "Protokol pre " + RRvar.sHeader;
            ProMenu.Show();

        }
    }
}
