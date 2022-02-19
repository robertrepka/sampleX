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
using System.Globalization;

namespace sampleX
{
    public partial class FilterA : Form
    {
        private readonly RRcode RRcode = new RRcode();
        private readonly RRfun RRfun = new RRfun();
        private readonly RRdata RRdata = new RRdata();
        private readonly RRsql RRsql = new RRsql();
        
        BindingSource bs = new BindingSource();
        MySqlDataAdapter da = new MySqlDataAdapter();

        DataTable dtAll = new DataTable();
        DataTable dtMat1 = new DataTable();
        DataTable dtMat2 = new DataTable();
        DataTable dtParameter = new DataTable();
        DataTable dtPrincip = new DataTable();
        DataTable dtOzn = new DataTable();
        DataTable dtOdd = new DataTable();
        DataTable dtJednotka = new DataTable();
        DataTable dtNeistota = new DataTable();

        string sTemp = "";
        string SqlSelectAll = "SELECT id, polozka, parameter, princip, ozn, jednotka, odd  FROM c_all1 order by id DESC ";
        string SqlSelectMatrica = "select id, value from xmatrica order by value";

        MySqlCommand myCommand;
        MySqlDataAdapter MyAdapter;
        MySqlConnection con = new MySqlConnection(RRvar.sConStr);

        public FilterA()
        {
            InitializeComponent();
        }

        private void FilterA_Load(object sender, EventArgs e)
        {
            string s;
            RRvar.sFooter = "sampleX verzia: " + Application.ProductVersion + " - " + RRvar.sFullName;
            lStatus.Text = RRvar.sFooter;
            this.Text = RRvar.sHeader;
            RRcode.Front();

            Filldt(SqlSelectAll, dtAll);
            dgAll.MultiSelect = false;
            dgAll.DataSource = dtAll;
            dgAll.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgAll.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgAll.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgAll.Columns[1].HeaderText = "pol.";
            dgAll.Columns[2].HeaderText = "parameter";
            dgAll.Columns[3].HeaderText = "princíp";
            dgAll.Columns[4].HeaderText = "označenie";
            dgAll.Columns[5].HeaderText = "jednotka";
            dgAll.Columns[6].HeaderText = "oddelenie";
            dgAll.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            dtNeistota.Columns.Add("min", typeof(double));
            dtNeistota.Columns.Add("max", typeof(double));
            dtNeistota.Columns.Add("des", typeof(int));
            dtNeistota.Columns.Add("value", typeof(int));
            dtNeistota.Columns.Add("pozn", typeof(string));
            dgNeistota.ReadOnly = true;

            dgNeistota.MultiSelect = false;
            dgNeistota.DataSource = dtNeistota;
            dgNeistota.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgNeistota.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgNeistota.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgNeistota.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8);
            dgNeistota.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgNeistota.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgNeistota.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgNeistota.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgNeistota.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //dgNeistota.Columns[0].HeaderText = "min";
            //dgNeistota.Columns[1].HeaderText = "max";
            dgNeistota.Columns[2].HeaderText = "presnosť";
            dgNeistota.Columns[3].HeaderText = "hodnota";
            dgNeistota.Columns[4].HeaderText = "poznámka";
            //for (int i = 0; i <= dgNeistota.Columns.Count - 1; i++)
            //{
            ////    int colw = dgNeistota.Columns[i].Width;
            //    dgNeistota.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ////    dgNeistota.Columns[i].Width = colw;
            //}

            dgNeistota.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            Filldt(SqlSelectMatrica, dtMat1);
            dgMat1.MultiSelect = false;
            dgMat1.DataSource = dtMat1;
            dgMat1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgMat1.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgMat1.Columns[0].Visible = false;
            dgMat1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            try
            {
                dgMat1.Rows[0].Selected = true;
            }
            catch { }

            Filldt("select id, value from xmatrica where id = 0", dtMat2);
            dgMat2.MultiSelect = false;
            dgMat2.DataSource = dtMat2;
            dgMat2.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgMat2.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgMat2.Columns[0].Visible = false;
            dgMat2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            try
            {
                dgMat2.Rows[0].Selected = true;
            }
            catch { }

            Filldt("select id, value from xparameter order by value", dtParameter);
            dgParameter.MultiSelect = false;
            dgParameter.DataSource = dtParameter;
            dgParameter.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgParameter.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgParameter.Columns[0].Visible = false;
            dgParameter.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            try
            {
                dgParameter.Rows[0].Selected = true;
            }
            catch { }

            Filldt("select id, CONCAT(value, ' (', popis, ')') AS value from xprincip order by value", dtPrincip);
            dgPrincip.MultiSelect = false;
            dgPrincip.DataSource = dtPrincip;
            dgPrincip.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgPrincip.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgPrincip.Columns[0].Visible = false;
            dgPrincip.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            try
            {
                dgPrincip.Rows[0].Selected = true;
            }
            catch { }

            Filldt("select id, CONCAT(value, ' ', popis ) AS value from xozn order by value", dtOzn);
            dgOzn.MultiSelect = false;
            dgOzn.DataSource = dtOzn;
            dgOzn.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgOzn.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgOzn.Columns[0].Visible = false;
            dgOzn.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            try
            {
                dgOzn.Rows[0].Selected = true;
            }
            catch { }

            Filldt("select id, value from xodd order by value", dtOdd);
            dgOdd.MultiSelect = false;
            dgOdd.DataSource = dtOdd;
            dgOdd.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgOdd.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgOdd.Columns[0].Visible = false;
            dgOdd.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            try
            {
                dgOdd.Rows[0].Selected = true;
            }
            catch { }

            Filldt("select id, value from xjednotka order by value", dtJednotka);
            dgJednotka.MultiSelect = false;
            dgJednotka.DataSource = dtJednotka;
            dgJednotka.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgJednotka.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgJednotka.Columns[0].Visible = false;
            dgJednotka.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            try
            {
                dgJednotka.Rows[0].Selected = true;
            }
            catch { }
            try
            {
                dgParameter.CurrentCell = dgParameter.Rows[0].Cells[1];
            }
            catch { }
            try
            {
                dgPrincip.CurrentCell = dgPrincip.Rows[0].Cells[1];
            }
            catch { }
            try
            {
                dgOzn.CurrentCell = dgOzn.Rows[0].Cells[1];
            }
            catch { }
            try
            {
                dgOdd.CurrentCell = dgOdd.Rows[0].Cells[1];
            }
            catch { }
            try
            {
                dgJednotka.CurrentCell = dgJednotka.Rows[0].Cells[1];
            }
            catch { }
            
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            DataRow r = dtNeistota.NewRow();
            int iLast;
            
            try
            {
                r["min"] = Convert.ToDouble(tMin.Text);
            }
            catch {
                tMin.Focus();
                return;
            }
            try
            {
                r["max"] = Convert.ToDouble(tMax.Text);
            }
            catch {
                tMax.Focus();
                return;
            }
            
            foreach (DataRow dr in dtNeistota.Rows)
            {
                if (dr["min"].ToString() == r["min"].ToString())
                {
                    MessageBox.Show("Zadaná minimálna hranica už existuje.", "Informácia", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    tMin.Focus();
                    return;
                }
            }

            foreach (DataRow dr in dtNeistota.Rows)
            {
                if (dr["max"].ToString() == r["max"].ToString())
                {
                    MessageBox.Show("Zadaná maximálna hranica už existuje.", "Informácia", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    tMax.Focus();
                    return;
                }
            }
            
            try
            {
                r["des"] = Convert.ToInt16(NUD1.Value);
                r["value"] = Convert.ToInt16(NUD2.Value);
                r["pozn"] = tPozn.Text;
                dtNeistota.Rows.Add(r);

                iLast = dgNeistota.Rows.Count - 1;
                dgNeistota.CurrentCell = dgNeistota.Rows[iLast].Cells[0];
                dgNeistota.Rows[iLast].Cells[0].Selected = true;
                tMin.Text = "";
                tMax.Text = "";
            }
            catch { }
            
            dgNeistota.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
        }

        private void bRemove_Click(object sender, EventArgs e)
        {
            int i;
            int iLast;
            try
            {
                i = dgNeistota.SelectedCells[0].RowIndex;
                DataRow dr = dtNeistota.Rows[i];
                dr.Delete();
                dtNeistota.AcceptChanges();

                iLast = dgNeistota.Rows.Count - 1;
                dgNeistota.CurrentCell = dgNeistota.Rows[iLast].Cells[0];
                dgNeistota.Rows[iLast].Cells[0].Selected = true;
            } catch {} 
        }

        private void Filldt(string sSql, DataTable dt)
        {
            myCommand = new MySqlCommand(sSql, con);
            MyAdapter = new MySqlDataAdapter(myCommand);
            //dt = new DataTable();
            con.Open();
            MyAdapter.Fill(dt);
            con.Close();
            MyAdapter.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            string s;
            try
            {
                i = dgMat1.SelectedCells[0].RowIndex;
                DataGridViewRow dgr = dgMat1.Rows[i];
                s = dgr.Cells[1].Value.ToString();
                dtMat2.Rows.Add(new Object[]{
                dgr.Cells[0].Value,
                dgr.Cells[1].Value.ToString()
                });

                DataRow dr = dtMat1.Rows[i];
                dr.Delete();

                dtMat1.AcceptChanges();
                dtMat2.AcceptChanges();
                
                DataView v = new DataView(dtMat2);
                v.Sort = "value";
                DataTable t = v.ToTable();
                dtMat2.Clear();

                foreach (DataRow r in t.Rows)
                {
                    dtMat2.Rows.Add(r.ItemArray);
                }
                dgMat2.DataSource = dtMat2;
                //dtMat2 = t.Clone();
                //dgMat2.DataSource = dtMat2;
                //foreach (DataRow dtMat2 in dtMat2.Rows)
                //{
                //    dtTableNew.ImportRow(dtMat2);
                //}

                foreach (DataGridViewRow row in dgMat2.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(s))
                    {
                        dgMat2.CurrentCell = dgMat2.Rows[row.Index].Cells[1];
                        dgMat2.Rows[row.Index].Selected = true;
                        break;
                    }
                }
            } catch {}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            string s;
            try
            {
                i = dgMat2.SelectedCells[0].RowIndex;
                DataGridViewRow dgr = dgMat2.Rows[i];
                s = dgr.Cells[1].Value.ToString();
                dtMat1.Rows.Add(new Object[]{
                dgr.Cells[0].Value,
                dgr.Cells[1].Value.ToString()
                });

                DataRow dr = dtMat2.Rows[i];
                dr.Delete();

                dtMat1.AcceptChanges();
                dtMat2.AcceptChanges();
                //dtMat1.DefaultView.Sort = "value";
                DataView v = new DataView(dtMat1);
                v.Sort = "value";
                DataTable t = v.ToTable();
                dtMat1.Clear();

                foreach (DataRow r in t.Rows)
                {
                    dtMat1.Rows.Add(r.ItemArray);
                }
                dgMat1.DataSource = dtMat1;


                foreach (DataGridViewRow row in dgMat1.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(s))
                    {
                        dgMat1.CurrentCell = dgMat1.Rows[row.Index].Cells[1];
                        dgMat1.Rows[row.Index].Selected = true;
                        break;
                    }
                }
            }
            catch { }
        }

        private void FilterA_Shown(object sender, EventArgs e)
        {
            try
            {
                dgAll.Rows[0].Selected = true;
            } catch { }
            RRcode.FadeIn(this);
            RRcode.Front();
            tMin.Focus();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            RRfun.ShowMyInfoToolTip(pictureBox1.Location.X + 50, pictureBox1.Location.Y + 50, this);
        }

        private void tMin_TextChanged(object sender, EventArgs e)
        {
            //double d;
            //tMin.Text = tMin.Text.Replace('.',',');
            
            //if (tMin.Text.Length == 0)
            //{
            //    sTemp = "";
            //}
            
            //try
            //{
            //    d = Convert.ToDouble(tMin.Text);
            //    sTemp = tMin.Text;
            //    tMin.Select(tMin.Text.Length, 0);
            //} catch {
            //    tMin.Text = sTemp;
            //}
        }

        private void tMin_Enter(object sender, EventArgs e)
        {
            sTemp = tMin.Text;
        }

        private void tMax_TextChanged(object sender, EventArgs e)
        {
            //double d;
            //tMax.Text = tMax.Text.Replace('.', ',');

            //if (tMax.Text.Length == 0)
            //{
            //    sTemp = "";
            //}
            
            //try
            //{
            //    d = Convert.ToDouble(tMax.Text);
            //    sTemp = tMax.Text;
            //    tMax.Select(tMax.Text.Length, 0);
            //}
            //catch
            //{
            //    tMax.Text = sTemp;
            //}
        }

        private void tMax_Enter(object sender, EventArgs e)
        {
            if (tMin.Text.Length == 0)
            {
                tMin.Focus();
            }
            sTemp = tMax.Text;
            
        }

        private void tMax_Validating(object sender, CancelEventArgs e)
        {
            if (tMax.Text.Length == 0)
            {
                return;
            }
            
            double d1, d2;
            try
            {
                d1 = Convert.ToDouble(tMin.Text);
                d2 = Convert.ToDouble(tMax.Text);
                if (d1 >= d2)
                {
                    tMax.Focus();    
                }
            }
            catch
            {
                tMax.Focus();
            }
        }

        private void NUD1_Enter(object sender, EventArgs e)
        {
            NUD1.Select();
            NUD1.Select(0, NUD1.Text.Length);
        }

        private void NUD2_Enter(object sender, EventArgs e)
        {
            NUD2.Select();
            NUD2.Select(0, NUD2.Text.Length);
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            if (dgMat2.Rows.Count == 0)
            {
                MessageBox.Show("Nie sú zvolené žiadne matrice.", "Informácia", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            if (dgNeistota.Rows.Count == 0)
            {
                MessageBox.Show("Nie sú zadefinované žiadne rozsahy neistôt.", "Informácia", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            if (tPolozka.Text.Length == 0)
            {
                MessageBox.Show("Nie je vyplnená identifikácia položky.", "Informácia", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                tPolozka.Focus();
                return;
            }

            string sSql;
            int iNewId;

            sSql = "select count(*) AS total from c_all where polozka= '" + tPolozka.Text + "' AND " +
                "parameter = '" + dgParameter.CurrentRow.Cells[0].Value.ToString() + "' AND " +
                "princip = '" + dgPrincip.CurrentRow.Cells[0].Value.ToString() + "' AND " +
                "ozn = '" + dgOzn.CurrentRow.Cells[0].Value.ToString() + "' AND " +
                "odd = '" + dgOdd.CurrentRow.Cells[0].Value.ToString() + "' AND " +
                "jednotka = '" + dgJednotka.CurrentRow.Cells[0].Value.ToString() + "'; ";
            int j = Convert.ToInt32(RRsql.RunSqlReturn(sSql));

            if (j > 0)
            {
                if (MessageBox.Show("Takáto kombinácia sa už v číselníku nachádza.\r\nUrčite ju chceš vložiť ešte raz??", "Varovanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }
            }

            using (System.Transactions.TransactionScope scope = new System.Transactions.TransactionScope())
            {
                try
                {
                    
                    sSql = "insert into c_all (polozka, parameter, princip, ozn, odd, jednotka, refe_id) values (" +
                        "'" + tPolozka.Text + "', " +
                        "'" + dgParameter.CurrentRow.Cells[0].Value.ToString() + "', " +
                        "'" + dgPrincip.CurrentRow.Cells[0].Value.ToString() + "', " +
                        "'" + dgOzn.CurrentRow.Cells[0].Value.ToString() + "', " +
                        "'" + dgOdd.CurrentRow.Cells[0].Value.ToString() + "', " +
                        "'" + dgJednotka.CurrentRow.Cells[0].Value.ToString() + "', " +
                        "'" + RRvar.idUser.ToString() + "')";
                                               
                    RRsql.RunSql(sSql);
                    //iNewId = Convert.ToInt32(MySqlHelper.ExecuteScalar(RRvar.sConStr, "SELECT LAST_INSERT_ID();"));
                    iNewId = Convert.ToInt32(RRsql.RunSqlReturn("SELECT LAST_INSERT_ID();"));

                    foreach (DataRow dr in dtNeistota.Rows)
                    {
                        sSql = "insert into c_neistota (c_all, min, max, des, value, pozn, refe_id) values (" +
                        "'" + iNewId + "', " +
                        "'" + dr["min"].ToString().Replace(',', '.') + "', " +
                        "'" + dr["max"].ToString().Replace(',', '.') + "', " +
                        "'" + dr["des"].ToString() + "', " +
                        "'" + dr["value"].ToString() + "', " +
                        "'" + tPozn.Text + "', " +
                        "'" + RRvar.idUser.ToString() + "')";
                        RRsql.RunSql(sSql);
                    }

                    foreach (DataRow dr in dtMat2.Rows)
                    {
                        sSql = "insert into c_matrica (c_all, matrica, refe_id) values (" +
                        "'" + iNewId + "', " +
                        "'" + dr["id"].ToString() + "', " +
                        "'" + RRvar.idUser.ToString() + "')";
                        RRsql.RunSql(sSql);
                    }
                    
                    //dtNeistota.Clear();
                    //dtMat2.Clear();
                    
                    dtMat1.Clear();
                    dtAll.Clear();
                    Filldt(SqlSelectAll, dtAll);
                    Filldt(SqlSelectMatrica, dtMat1);
                
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                scope.Complete();
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            int iX = dgAll.CurrentCellAddress.X;
            int iLastCell = dgAll.CurrentCellAddress.Y;
            int FirstDisplayedScrollingRowIndex = dgAll.FirstDisplayedScrollingRowIndex;

            if (MessageBox.Show("Skutočne chceš vymazať túto položku z rozsahu akreditácie???", "Varovanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                RRsql.RunSql("delete from c_all where id='" + dgAll.CurrentRow.Cells[0].Value.ToString() + "';");
                dtAll.Clear();
                Filldt(SqlSelectAll, dtAll);

                try
                {
                    dgAll.FirstDisplayedScrollingRowIndex = FirstDisplayedScrollingRowIndex;
                }
                catch { }

                try
                {
                    dgAll.Rows[iLastCell].Selected = true;
                }
                catch {
                    try
                    {
                        dgAll.Rows[iLastCell - 1].Selected = true;
                    }
                    catch { }
                }
            }
        }

        private void ChildFormClosedFull(object sender, EventArgs e)
        {
            this.Enabled = true;
            if (RRvar.sTemp9 != RRvar.sTemp)
            {
                int iRow = 0;
                foreach (DataGridViewRow row in dgAll.Rows)
                {
                    if (row.Cells[0].Value.ToString() == RRvar.sTemp)
                    {
                        iRow = row.Index;
                        break;
                    }
                }
                try
                {
                    dgAll.CurrentCell = dgAll.Rows[iRow].Cells[0];
                    dgAll.Rows[iRow].Selected = true;
                    dgAll.FirstDisplayedScrollingRowIndex = dgAll.SelectedRows[0].Index;
                }
                catch { }          
            }
            RRcode.Front();
        }

        private void bMatrica_Click(object sender, EventArgs e)
        {
            RRvar.sTempN = "";
            RRvar.sTempN = dgAll.CurrentRow.Cells[0].Value.ToString();
            RRvar.sTemp9 = dgAll.CurrentRow.Cells[0].Value.ToString();

            if (RRvar.sTempN.Length == 0)
            {
                return;
            }
            this.Enabled = false;
            Form FilterM = new FilterM();
            FilterM.Closed += new EventHandler(ChildFormClosedFull);
            RRvar.sHeader = "Rozsah akreditácie - matrice ";
            FilterM.Show();
        }

        private void bNeistota_Click(object sender, EventArgs e)
        {
            RRvar.sTempN = "";
            RRvar.sTempN = dgAll.CurrentRow.Cells[0].Value.ToString();
            RRvar.sTemp9 = dgAll.CurrentRow.Cells[0].Value.ToString();

            if (RRvar.sTempN.Length == 0)
            {
                return;
            }
            this.Enabled = false;
            Form FilterN = new FilterN();
            FilterN.Closed += new EventHandler(ChildFormClosedFull);
            RRvar.sHeader = "Rozsah akreditácie - neistoty ";
            FilterN.Show();
        }

        private void tMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void dgMat1_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int i = 0; i < (dgMat1.Rows.Count); i++)
            {
                if (dgMat1.Rows[i].Cells[1].Value.ToString().StartsWith(e.KeyChar.ToString(), true, CultureInfo.InvariantCulture))
                {
                    dgMat1.Rows[i].Cells[1].Selected = true;
                    dgMat1.CurrentCell = dgMat1.Rows[i].Cells[1];
                    return;
                }
            }
        }

        private void dgMat2_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int i = 0; i < (dgMat2.Rows.Count); i++)
            {
                if (dgMat2.Rows[i].Cells[1].Value.ToString().StartsWith(e.KeyChar.ToString(), true, CultureInfo.InvariantCulture))
                {
                    dgMat2.Rows[i].Cells[1].Selected = true;
                    dgMat2.CurrentCell = dgMat2.Rows[i].Cells[1];
                    return;
                }
            }
        }

        private void dgParameter_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int i = 0; i < (dgParameter.Rows.Count); i++)
            {
                if (dgParameter.Rows[i].Cells[1].Value.ToString().StartsWith(e.KeyChar.ToString(), true, CultureInfo.InvariantCulture))
                {
                    dgParameter.Rows[i].Cells[1].Selected = true;
                    dgParameter.CurrentCell = dgParameter.Rows[i].Cells[1];
                    return;
                }
            }
        }

        private void dgPrincip_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int i = 0; i < (dgPrincip.Rows.Count); i++)
            {
                if (dgPrincip.Rows[i].Cells[1].Value.ToString().StartsWith(e.KeyChar.ToString(), true, CultureInfo.InvariantCulture))
                {
                    dgPrincip.Rows[i].Cells[1].Selected = true;
                    dgPrincip.CurrentCell = dgPrincip.Rows[i].Cells[1];
                    return;
                }
            }
        }

        private void dgJednotka_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int i = 0; i < (dgJednotka.Rows.Count); i++)
            {
                if (dgJednotka.Rows[i].Cells[1].Value.ToString().StartsWith(e.KeyChar.ToString(), true, CultureInfo.InvariantCulture))
                {
                    dgJednotka.Rows[i].Cells[1].Selected = true;
                    dgJednotka.CurrentCell = dgJednotka.Rows[i].Cells[1];
                    return;
                }
            }
        }

        private void dgOzn_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int i = 0; i < (dgOzn.Rows.Count); i++)
            {
                if (dgOzn.Rows[i].Cells[1].Value.ToString().StartsWith(e.KeyChar.ToString(), true, CultureInfo.InvariantCulture))
                {
                    dgOzn.Rows[i].Cells[1].Selected = true;
                    dgOzn.CurrentCell = dgOzn.Rows[i].Cells[1];
                    return;
                }
            }
        }

        private void dgOdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int i = 0; i < (dgOdd.Rows.Count); i++)
            {
                if (dgOdd.Rows[i].Cells[1].Value.ToString().StartsWith(e.KeyChar.ToString(), true, CultureInfo.InvariantCulture))
                {
                    dgOdd.Rows[i].Cells[1].Selected = true;
                    dgOdd.CurrentCell = dgOdd.Rows[i].Cells[1];
                    return;
                }
            }
        }

        private void dgAll_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int i = 0; i < (dgAll.Rows.Count); i++)
            {
                if (dgAll.Rows[i].Cells["Parameter"].Value.ToString().StartsWith(e.KeyChar.ToString(), true, CultureInfo.InvariantCulture))
                {
                    dgAll.Rows[i].Cells["Parameter"].Selected = true;
                    dgAll.CurrentCell = dgAll.Rows[i].Cells["Parameter"];
                    return;
                }
            }
        }

    }
}