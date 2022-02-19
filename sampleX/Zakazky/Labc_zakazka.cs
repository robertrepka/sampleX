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
using System.Runtime.InteropServices;

namespace sampleX
{
    public partial class Labc_zakazka : Form
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

        public Labc_zakazka()
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
            dg.Columns[9].Visible = false;
            dg.Columns[10].Visible = false;
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

        private void Labc_zakazka_Load(object sender, EventArgs e)
        {
            if (RRdata.bAuth("v-r") || RRdata.bAuth("v-rw"))
            {
                bResult.Enabled = true;
            }
            else
            {
                bResult.Enabled = false;
            }

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
            dg.MultiSelect = false;
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

            cFilter.SelectedIndex = 0;
            dg.Visible = true;
            pictureBox1.Visible = true;
            bExcel.Visible = true;
            bResult.Visible = true;
            bSelect.Visible = true;
            bPaste.Visible = true;
            ActiveControl = dg;
            bindingNavigatorDeleteItem.Enabled = false;
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
            bExcel.Location = new Point(5, dr.Height + bn.Height + 10);
            bSelect.Location = new Point(55, dr.Height + bn.Height + 10);
            bPaste.Location = new Point(105, dr.Height + bn.Height + 10);
            bResult.Location = new Point(205, dr.Height + bn.Height + 10);
            //bPass.Location = new Point(5 + bExcel.Height + 3, dr.Height + bn.Height + 10);
            pictureBox1.Location = new Point(5, this.Size.Height - 120);
            dr.Location = new Point(5, 35);
            dg.Location = new Point(5 + 5 + dr.Width, 35);
            dg.Size = new Size(this.Size.Width - 35 - dr.Width, this.Size.Height - 105);
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
                dg.MultiSelect = false;
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
        }

        private void ChildFormClosedFull2(object sender, EventArgs e)
        {
            this.Visible = true;
            this.Enabled = true;
            RRcode.FadeIn(this);
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
        private void bExcel_Click(object sender, EventArgs e)
        {
            myClip();
        }

        private void dg_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            myEndEdit(true);
        }

        private void Labc_zakazka_Resize(object sender, EventArgs e)
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

        private void Labc_zakazka_FormClosing(object sender, FormClosingEventArgs e)
        {
            RRvar.sTemp = "";
            RRvar.bSelect = false;
            //object o = MySqlHelper.ExecuteScalar(RRvar.sConStr, "delete from refe where (login='' or login is null) and (fullname='' or fullname is null);");
            RRcode.FadeOut(this);
        }
        #endregion

        #region INSERT - ADDBUTTON OK MYINSERT
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bExcel.Visible = false;
            bResult.Visible = false;
            bSelect.Visible = false;
            bPaste.Visible = false;
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
            bExcel.Visible = true;
            bResult.Visible = true;
            bSelect.Visible = true;
            bPaste.Visible = true;
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

            Form Labc_zakazka2 = new Labc_zakazka2();
            Labc_zakazka2.Closed += new EventHandler(DataAClosed);
            RRvar.sTemp1 = nazov_.Text;
            RRvar.sTemp2 = obj_no_.Text;
            RRvar.sTemp3 = zakazka_no_.Text;
            RRvar.sTemp4 = ozn_.Text;
            RRvar.sTemp5 = rok_.Text;
            RRvar.sTemp6 = labc_.Text;
            RRvar.sTemp7 = id_.Text;
            //RRvar.sHeader = "Vytvorenie požiadavky na meranie pre zákazku: " + RRvar.sTemp3 + " / " + RRvar.sTemp5;
            RRcode.FadeOut(this);
            this.Visible = false;
            Labc_zakazka2.Show();
        }

        private void DataAClosed(object sender, EventArgs e)
        {
            //RRcode.FadeIn(this);
            //this.Visible = true;
            //RRcode.Front();
            this.Close();
        }




        private void Labc_zakazka_Shown(object sender, EventArgs e)
        {
            Headers();
            if (RRvar.bSelect)
            {
                bSelect.Visible = true;
                bPaste.Visible = true;
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

        private void bPaste_Click(object sender, EventArgs e)
        {

            Form Labc_zakazka3 = new Labc_zakazka3();
            Labc_zakazka3.Closed += new EventHandler(DataAClosed);
            RRvar.sTemp1 = nazov_.Text;
            RRvar.sTemp2 = obj_no_.Text;
            RRvar.sTemp3 = zakazka_no_.Text;
            RRvar.sTemp4 = ozn_.Text;
            RRvar.sTemp5 = rok_.Text;
            RRvar.sTemp6 = labc_.Text;
            RRvar.sTemp7 = id_.Text;
            //RRvar.sHeader = "Vytvorenie požiadavky na meranie pre zákazku: " + RRvar.sTemp3 + " / " + RRvar.sTemp5;
            RRcode.FadeOut(this);
            this.Visible = false;
            Labc_zakazka3.Show();
        }

        private void ozn__TextChanged(object sender, EventArgs e)
        {
            int i, j;
            i = ozn_.SelectionStart;
            j = ozn_.SelectionLength;

            ozn_.Text = ozn_.Text.Replace("\n", String.Empty);
            ozn_.Text = ozn_.Text.Replace("\r", String.Empty);
            ozn_.Text = ozn_.Text.Replace("\t", String.Empty);

            ozn_.Text = ozn_.Text.TrimStart().Replace(Environment.NewLine, "");
            ozn_.Text = ozn_.Text.TrimStart().Replace("  ", " ");
            ozn_.Text = ozn_.Text.TrimStart().Replace("  ", " ");
            ozn_.Text = ozn_.Text.TrimStart().Replace("  ", " ");
            ozn_.Text = ozn_.Text.TrimStart().Replace("  ", " ");

            try
            {
                ozn_.SelectionStart = i;
            }
            catch { }
            try
            {
                ozn_.SelectionLength = j;
            }
            catch { }

        }

        private void bResult_Click(object sender, EventArgs e)
        {
            string s = "";

            s = " SELECT COUNT(*) FROM labc, data WHERE data.labc = labc.id AND " +
            " labc.labc = '" + labc_.Text + "' AND " +
            "labc.rok = '" + rok_.Text + "';";

            if (Convert.ToInt16(RRdata.sSqlResult(s, 1, 1)) == 0)
            {
                MessageBox.Show("Nie je vytvorená požiadavka na meranie.", "Hľadanie", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                s = " SELECT id, labc, rok FROM labc WHERE " +
                    " labc = '" + labc_.Text + "' AND " +
                    " rok = '" + rok_.Text + "';";
                RRdata.MatrixFill(s, true);
                RRvar.sTemp1 = RRdata.MatrixRead(0, 0);
                RRvar.iFilterMeranie = 0;
                Form DataC = new DataC();
                DataC.Closed += new EventHandler(ChildFormClosedFull2);
                RRcode.FadeOut(this);
                this.Enabled = false;
                DataC.Show();
            }
        }
    }
}
