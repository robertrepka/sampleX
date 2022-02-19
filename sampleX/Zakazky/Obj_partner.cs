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
    public partial class Obj_partner : Form
    {
        int iSort = 0;
        string sFilter = "";
        BindingSource bs = new BindingSource();
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable dt = new DataTable();

        #region UVOD
        string SqlSelectCommand = "SELECT id, no, rok, cobj, czml, meno, datum, expired, pozn, ozn, autor, stamp, partner_id FROM obj_partner " + RRvar.sTemp + " ORDER BY id DESC";
        string SqlUpdateCommand = "UPDATE `obj` SET `no` = @no, `rok` = @rok, `cobj` = @cobj, `czml` = @czml, `partner_id` = @partner_id, `datum` = @datum, `expired` = @expired, `pozn` = @pozn, `ozn` = @ozn, `refe_id` = @refe_id WHERE `id` = @id";
        string SqlInsertCommand = "INSERT INTO `obj` (`no`, `rok`, `cobj`, `czml`, `partner_id`, `datum`, `expired`, `pozn`, `ozn`, `refe_id`) VALUES (@no, @rok, @cobj, @czml, @partner_id, @datum, @expired, @pozn, @ozn, @refe_id)";
        string SqlDeleteCommand = "DELETE from obj where id = @id";
        string SqlLogCommand = "SELECT CONCAT('id:', id, ' - ', no) from obj_partner ORDER BY id DESC LIMIT 1;";

        string sLog1 = "Nová objednávka: ";
        int iDG = 0;

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
        RRdata RRdata = new RRdata();
        RRfun RRfun = new RRfun();
        RRsql RRsql = new RRsql();
        RRstring RRstring = new RRstring();

        public Obj_partner()
        {
            InitializeComponent();
            da = new MySqlDataAdapter();
            bs.DataSource = dt;
            dg.DataSource = bs;
            bn.BindingSource = bs;

        }


        private void DGen(string Meno, string Popis, int Typ)
        {
            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            DataGridViewCheckBoxColumn c2 = new DataGridViewCheckBoxColumn();

            if (Typ == 1)
            {
                dg.Columns.Add(c1);
                c1.DataPropertyName = Meno;
                c1.Name = Meno;
                c1.HeaderText = Popis;
                c1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            if (Typ == 2)
            {
                dg.Columns.Add(c2);
                c2.DataPropertyName = Meno;
                c2.Name = Meno;
                c2.HeaderText = Popis;
                c2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }


        private void DGen()
        {
            dg.AutoGenerateColumns = false;
            dg.Columns.Clear();

            DGen("id", "id", 1);
            DGen("no", "číslo", 1);
            DGen("rok", "rok", 1);
            DGen("cobj", "objednávka", 1);
            DGen("czml", "zmluva", 1);
            DGen("meno", "meno", 1);
            DGen("datum", "dátum", 1);
            DGen("expired", "koniec", 2);
            DGen("pozn", "poznámka", 1);
            DGen("ozn", "ev.č", 1);
            DGen("autor", "autor", 1);
            DGen("stamp", "zápis", 1);
            DGen("partner_id", "id2", 1);

        }

        private void Headers()
        {

            dg.Columns[12].Visible = false;
            for (int i = 0; i <= dg.Columns.Count - 1; i++)
            {
                int colw = dg.Columns[i].Width;
                dg.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dg.Columns[i].Width = colw;


            }

            dg.Columns[1].HeaderText = "por.č.";
            dg.Columns[5].HeaderText = "objednávateľ";
            dg.Columns[6].HeaderText = "zo dňa";
            dg.Columns[7].HeaderText = "ukončené";

        }

        private void Obj_partner_Shown(object sender, EventArgs e)
        {
            Headers();
            if (RRvar.bSelect)
            {
                bSelect.Visible = true;
                bObj.Visible = false;
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

        private void Obj_partner_Load(object sender, EventArgs e)
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
            mySqlDeleteCommand = new MySqlCommand(SqlDeleteCommand, MyDataConnect);
            da.SelectCommand = mySqlSelectCommand;
            da.UpdateCommand = mySqlUpdateCommand;
            da.DeleteCommand = mySqlDeleteCommand;
            DGen();
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
            //myFill();
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
            bObj.Visible = true;
            ActiveControl = dg;

            if (RRvar.bDetail)
            {
                bPartner.Enabled = false;
                bindingNavigatorAddNewItem.Enabled = false;
            }
            bindingNavigatorDeleteItem.Enabled = false;
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
            myDef("id");
            myDef("no");
            myDef("rok");
            myDef("cobj");
            myDef("czml");
            myDef("meno");
            myDef("datum");
            myDef("expired");
            myDef("partner_id");
            myDef("pozn");
            myDef("ozn");

            mySqlUpdateCommand.Parameters.AddWithValue("@refe_id", RRvar.idUser);
            // mySqlUpdateCommand.Parameters.AddWithValue("@stamp", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

        }
        #endregion 

        #region MANIPULACIA - VALIDATE DELETE ENDEDIT
        private void myTaUpdate()
        {
            mySqlUpdateCommand.Parameters["@id"].Value = id_.Text;
            mySqlUpdateCommand.Parameters["@no"].Value = no_.Text;
            mySqlUpdateCommand.Parameters["@rok"].Value = rok_.Text;
            mySqlUpdateCommand.Parameters["@cobj"].Value = cobj_.Text;
            mySqlUpdateCommand.Parameters["@czml"].Value = czml_.Text;
            mySqlUpdateCommand.Parameters["@meno"].Value = meno_.Text;

            mySqlUpdateCommand.Parameters["@datum"].Value = datum_.Text;
            mySqlUpdateCommand.Parameters["@expired"].Value = expired_.Text;
            mySqlUpdateCommand.Parameters["@partner_id"].Value = partner_id_.Text;
            mySqlUpdateCommand.Parameters["@pozn"].Value = pozn_.Text;
            mySqlUpdateCommand.Parameters["@ozn"].Value = ozn_.Text;

            mySqlUpdateCommand.Parameters["@refe_id"].Value = RRvar.idUser;
            //mySqlUpdateCommand.Parameters["@stamp"].Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            try
            {
                da.Update(dt);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
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
                myTaUpdate();
            }
            catch { }
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
            bObj.Location = new Point(55, dr.Height + bn.Height + 10);
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

        private void Obj_partner_Resize(object sender, EventArgs e)
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

        private void Obj_partner_FormClosing(object sender, FormClosingEventArgs e)
        {
            RRvar.bDetail = false;
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
            bObj.Visible = false;
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
            no_.Text = "---";
            partner_id_.Text = "---";
            expired_.Text = "False";
            rok_.Text = RRvar.iRok.ToString();
            cobj_.Focus();

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

            MySqlCommand cmd = new MySqlCommand(SqlInsertCommand, con);
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
            cmd.Parameters.AddWithValue("@" + d, (c[0] as TextBox).Text);

            d = "expired";
            s = d + "_";
            c = this.Controls.Find(s, true);
            cmd.Parameters.AddWithValue("@" + d, (c[0] as Label).Text);

            d = "pozn";
            s = d + "_";
            c = this.Controls.Find(s, true);
            cmd.Parameters.AddWithValue("@" + d, (c[0] as TextBox).Text);

            d = "ozn";
            s = d + "_";
            c = this.Controls.Find(s, true);
            cmd.Parameters.AddWithValue("@" + d, (c[0] as TextBox).Text);

            cmd.Parameters.AddWithValue("@refe_id", RRvar.idUser);
            //cmd.Parameters.AddWithValue("@stamp", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

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

            RRcode.Log(sLog1 + RRsql.RunSqlReturn(SqlLogCommand));

            myDgReload();
            dg.Focus();
            bExcel.Visible = true;
            bObj.Visible = true;
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
            myEndEdit(true);
            dg.FirstDisplayedScrollingRowIndex = dg.SelectedRows[0].Index;
            Headers();
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
            if (expired_.Text == "True")
            {
                c_expired_.Checked = true;
            }
            else
            {
                c_expired_.Checked = false;
            }
        }

        private void c_expired__CheckedChanged(object sender, EventArgs e)
        {
            if (c_expired_.Checked)
            {
                expired_.Text = "True";
            }
            else
            {
                expired_.Text = "False";
            }
            if (!bInsertIsRunning) myEndEdit(true);

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
                meno_.Text = RRvar.sTemp3;
            }

            RRcode.Front();
        }

        private void bPartner_Click(object sender, EventArgs e)
        {
            //RRvar.bFilter = true;
            //RRvar.sFilter1 = "nazov";
            //RRvar.sFilter2 = meno_.Text;

            if (RRvar.bSelect)
            {
            }
            else
            {
                RRvar.sTemp = " where id='" + partner_id_.Text + "'";
            }

            RRcode.FadeOut(this);
            this.Visible = false;
            Form Partners = new Partners();

            if (RRvar.bSelect)
            {
                RRvar.sTemp = "---";
                RRvar.iID = 0;
                RRvar.sHeader = "Číselník zákazníkov - pridelenie objednávky / zmluvy zákazníkovi";
                Partners.Closed += new EventHandler(PartnerAddClosed);
            }
            else
            {
                RRvar.sHeader = "Číselník zákazníkov - detail zákazníka - " + meno_.Text;
                Partners.Closed += new EventHandler(PartnerClosed);
            }
            Partners.Show();
        }

        private void bSelect_Click(object sender, EventArgs e)
        {
            RRvar.sIdObjZak = id_.Text;
            RRvar.sTemp1 = no_.Text;
            RRvar.sTemp2 = rok_.Text;
            RRvar.sTemp3 = cobj_.Text;
            RRvar.sTemp4 = czml_.Text;
            RRvar.sTemp5 = meno_.Text;
            RRvar.sTemp6 = datum_.Text;
            RRvar.sTemp7 = expired_.Text;
            this.Close();
        }

        private void myDef(string sElement)
        {
            string s, d;
            Control[] c;
            d = sElement;
            s = d + "_";
            try
            {
                c = this.Controls.Find(s, true);
                (c[0]).DataBindings.Add("Text", bs, d, false, DataSourceUpdateMode.OnPropertyChanged);
                mySqlUpdateCommand.Parameters.AddWithValue("@" + d, (c[0]).Text);
            }
            catch { }
        }

        private void dg_Enter(object sender, EventArgs e)
        {
            try
            {
                int i = dg.CurrentCell.RowIndex;
                dg.Rows[i].Selected = true;
            }
            catch { }
        }

        private void dg_Click(object sender, EventArgs e)
        {

            try
            {
                iSort = Convert.ToInt32(dg.Rows[dg.CurrentRow.Index].Cells[0].Value);
            }
            catch { }
            int i = dg.CurrentCell.RowIndex;
            dg.Rows[i].Selected = true;
        }

        private void DetailClosed(object sender, EventArgs e)
        {
            RRcode.FadeIn(this);
            this.Visible = true;
            RRcode.Front();
        }

        private void bObj_Click(object sender, EventArgs e)
        {
            string sSql = "select count(id) as total from zakazka " +
            " where obj_id='" + id_.Text + "'";

            int i = Convert.ToInt16(RRsql.RunSqlReturn(sSql));

            if (i > 0)
            {
                RRvar.bDetail = true;
                RRvar.sTemp = " where obj_id='" + id_.Text + "'";
                RRcode.FadeOut(this);
                this.Visible = false;
                Form Zakazka_obj_partner = new Zakazka_obj_partner();
                RRvar.sHeader = "Zákazky pre objednávku - " + no_.Text + "/" + rok_.Text + " - " + meno_.Text;
                Zakazka_obj_partner.Closed += new EventHandler(DetailClosed);
                Zakazka_obj_partner.Show();
            }

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

        private void b_datum_Click(object sender, EventArgs e)
        {
            datum_.Text = "";
            myValidated();
            myBsReload();
            myEndEdit(true);
        }

        private void datum___ValueChanged(object sender, EventArgs e)
        {
            datum_.Text = datum__.Value.ToString("yyyy-MM-dd");
            myValidated();
        }
        private void myValidated()
        {
            if (bInsertIsRunning)
            {
                return;
            }
            myBsReload();
            myEndEdit(true);
        }

    }
}
