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
    public partial class Matrica : Form
    {
        #region UVOD - TODO EDIT VALUES
    	int iSort = 0;
        string sFilter = "";
        BindingSource bs = new BindingSource();
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable dt = new DataTable();

        string sSqlCount = "select count(id) as total from xmatrica where value = '";

        string SqlSelectCommand = "SELECT id, value, pozn, autor, stamp FROM xmatrica1 ";// + RRvar.sTemp;
        string SqlUpdateCommand = "UPDATE xmatrica SET value = @value, pozn = @pozn, refe_id = @refe_id  WHERE (`id` = @id)";
        string SqlInsertCommand = "INSERT INTO `xmatrica` (`value`, `pozn`, `refe_id`) VALUES (@value, @pozn, @refe_id)";
        string SqlDeleteCommand = "DELETE from xmatrica where id = @id";
        string SqlLogCommand = "SELECT CONCAT('id:', id, ' - ', value) from xmatrica ORDER BY id DESC LIMIT 1;";

	string sLog1 = "Nová matrica: ";

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
        RRstring RRstring = new RRstring();

        public Matrica()
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
            dg.ReadOnly = true;
            dg.Columns[0].ReadOnly = true;
            dg.Columns[1].HeaderText = "názov";
            dg.Columns[2].HeaderText = "poznámka";
            for (int i = 0; i <= dg.Columns.Count - 1; i++)
            {
                int colw = dg.Columns[i].Width;
                dg.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dg.Columns[i].Width = colw;
            }
            dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

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
            string s, d;
            Control[] c;

            d = "id";
            s = d + "_";
            c = this.Controls.Find(s, true);
            (c[0] as Label).DataBindings.Add("Text", bs, d, false, DataSourceUpdateMode.OnPropertyChanged);

            d = "value";
            s = d + "_";
            c = this.Controls.Find(s, true);
            (c[0] as TextBox).DataBindings.Add("Text", bs, d, false, DataSourceUpdateMode.OnPropertyChanged);

            d = "pozn";
            s = d + "_"; ;
            c = this.Controls.Find(s, true);
            (c[0] as TextBox).DataBindings.Add("Text", bs, d, false, DataSourceUpdateMode.OnPropertyChanged);

            mySqlUpdateCommand.Parameters.AddWithValue("@id", id_.Text);
            mySqlUpdateCommand.Parameters.AddWithValue("@value", value_.Text);
            mySqlUpdateCommand.Parameters.AddWithValue("@pozn", pozn_.Text);
            mySqlUpdateCommand.Parameters.AddWithValue("@refe_id", RRvar.idUser);
            //mySqlDeleteCommand.Parameters.AddWithValue("@id", id_.Text);

        }
        #endregion 

        private void Matrica_Load(object sender, EventArgs e)
        {
            MyDataConnect.Open();
            mySqlSelectCommand = new MySqlCommand(SqlSelectCommand, MyDataConnect);
            mySqlUpdateCommand = new MySqlCommand(SqlUpdateCommand, MyDataConnect);
            mySqlDeleteCommand = new MySqlCommand(SqlDeleteCommand, MyDataConnect);
            da.SelectCommand = mySqlSelectCommand;
            da.UpdateCommand = mySqlUpdateCommand;
            
            this.da.Fill(dt);
            MyDataConnect.Close();
            myDataSource();

            dg.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dg.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10);

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
                //if (i > 2)
                //{
                //    break;
                //}
            }
            Application.DoEvents();

            cFilter.SelectedIndex = 0;
            dg.Visible = true;
            pictureBox1.Visible = true;
            bExcel.Visible = true;
            ActiveControl = dg;
        }

        #region MANIPULACIA - VALIDATE DELETE ENDEDIT
        private void myTaUpdate()
        {

            mySqlUpdateCommand.Parameters["@id"].Value = id_.Text;
            mySqlUpdateCommand.Parameters["@value"].Value = value_.Text;
            mySqlUpdateCommand.Parameters["@pozn"].Value = pozn_.Text;
            mySqlUpdateCommand.Parameters["@refe_id"].Value = RRvar.idUser;

            try {
                da.Update(dt);
            } catch { }

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
            MySqlConnection con = new MySqlConnection(RRvar.sConStr);
            MySqlCommand cmd = new MySqlCommand(SqlDeleteCommand, con);
            
            cmd.Parameters.AddWithValue("@id", id_.Text);


            try
            {
                    con.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                    con.Close();
                    try
                    {
                        bs.EndEdit();
                        bs.RemoveCurrent();
                        //   myTaUpdate();
                    }
                    catch { }    
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            

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
    
        private void Matrica_Resize(object sender, EventArgs e)
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

        private void Matrica_FormClosing(object sender, FormClosingEventArgs e)
        {
            //object o = MySqlHelper.ExecuteScalar(RRvar.sConStr, "delete from refe where (login='' or login is null) and (fullname='' or fullname is null);");
            RRcode.FadeOut(this);
        }
        #endregion

        #region INSERT - ADDBUTTON OK MYINSERT
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bInsertIsRunning = true;
            oldSortOrder = dg.SortOrder == SortOrder.Ascending ? ListSortDirection.Ascending : ListSortDirection.Descending;
            oldSortCol = dg.SortedColumn;
            oldFilter = tSearch.Text;
            tSearch.Text = "";
            oldCombo = cFilter.SelectedIndex;
            cFilter.SelectedIndex = 0;
            bExcel.Visible = false;
            
            
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
        }
        
        private void bOK_Click(object sender, EventArgs e)
        {
            int j = 0;
            string ss = sSqlCount + value_.Text + "';";
            j = Convert.ToInt16(RRsql.RunSqlReturn(ss));

            if (j > 0)
            {
                MessageBox.Show("Uvedená položka sa už v databáze nachádza!", "Varovanie", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            bool bSuccessWrite = true;
            int iNumberNext = 0;
            bInsertIsRunning = true;
            int iNewId = 0;
            
            MySqlCommand cmd = new MySqlCommand(SqlInsertCommand, con);

            string s, d;
            Control[] c;

            d = "value";
            s = d + "_";
            c = this.Controls.Find(s, true);
            cmd.Parameters.AddWithValue("@" + d, (c[0] as TextBox).Text);
            
            d = "pozn";
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

            RRcode.Log(sLog1 + RRsql.RunSqlReturn(SqlLogCommand));
            
            myDgReload();
            dg.Focus();
            bExcel.Visible = true;
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

        private void Matrica_Shown(object sender, EventArgs e)
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
                catch {}
            }
        }

        private void bSelect_Click(object sender, EventArgs e)
        {
            RRvar.iID = Convert.ToInt32(id_.Text);
            RRvar.sTemp = value_.Text;
            this.Close();
        }

        private void dg_Click(object sender, EventArgs e)
        {
            try
            {
                iSort = Convert.ToInt32(dg.Rows[dg.CurrentRow.Index].Cells[0].Value);
            }
            catch {}
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
                
            } catch { }          
        }

    }
}
