using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sampleX
{
    class RRsql
    {
        
        public bool DataWrite(bool Update, string Table, string Pc, string a, string b, string c, string d, string e, string f, string g, string h, string i, string j)
        {
            return _DataWrite(Update, Table, Pc, a, b, c, d, e, f, g, h, i, j);
        }
        public bool DataWrite(bool Update, string Table, string Pc, string a, string b, string c, string d, string e, string f, string g, string h, string i)
        {
            return _DataWrite(Update, Table, Pc, a, b, c, d, e, f, g, h, i, "");
        }
        public bool DataWrite(bool Update, string Table, string Pc, string a, string b, string c, string d, string e, string f, string g, string h)
        {
            return _DataWrite(Update, Table, Pc, a, b, c, d, e, f, g, h, "", "");
        }
        public bool DataWrite(bool Update, string Table, string Pc, string a, string b, string c, string d, string e, string f, string g)
        {
            return _DataWrite(Update, Table, Pc, a, b, c, d, e, f, g, "", "", "");
        }
        public bool DataWrite(bool Update, string Table, string Pc, string a, string b, string c, string d, string e, string f)
        {
            return _DataWrite(Update, Table, Pc, a, b, c, d, e, f, "", "", "", "");
        }
        public bool DataWrite(bool Update, string Table, string Pc, string a, string b, string c, string d, string e)
        {
            return _DataWrite(Update, Table, Pc, a, b, c, d, e, "", "", "", "", "");
        }
        public bool DataWrite(bool Update, string Table, string Pc, string a, string b, string c, string d)
        {
            return _DataWrite(Update, Table, Pc, a, b, c, d, "", "", "", "", "", "");
        }
        public bool DataWrite(bool Update, string Table, string Pc, string a, string b, string c)
        {
            return _DataWrite(Update, Table, Pc, a, b, c, "", "", "", "", "", "", "");
        }
        public bool DataWrite(bool Update, string Table, string Pc, string a, string b)
        {
            return _DataWrite(Update, Table, Pc, a, b, "", "", "", "", "", "", "", "");
        }
        public bool DataWrite(bool Update, string Table, string Pc, string a)
        {
            return _DataWrite(Update, Table, Pc, a, "", "", "", "", "", "", "", "", "");
        }
        public bool DataWrite(string Table)
        {
            return _DataTableCreate(Table);
        }
        
        public bool DataEmpty(string Table)
        {
            return _DataEmpty(Table);
        }

        private bool _DataWrite(bool Update, string Table, string Pc, string a, string b, string c, string d, string e, string f, string g, string h, string i, string j)
        {
            MySqlConnection MyDataConnect = new MySqlConnection(RRvar.sConStr);
            MySqlCommand Sql;
            MyDataConnect.Open();
            //MySqlCommand Sql = new MySqlCommand("CREATE TABLE " + Table +  Todo (Id COUNTER CONSTRAINT PrimaryKey PRIMARY KEY, Pc VARCHAR(100), Data VARCHAR(100));");
            if (Update)
            {
                Sql = new MySqlCommand("DELETE FROM " + Table + " WHERE PC='" + Pc + "';");
                Sql.Connection = MyDataConnect;
                try
                {
                    Sql.ExecuteNonQuery();
                }
                catch
                {
                    MyDataConnect.Close();
                    return false;
                }
            }
            Sql = new MySqlCommand("INSERT INTO " + Table + " (Pc, a, b, c, d, e, f, g, h, i, j) values ('" + Pc + "', '" + a + "', '" + b + "', '" + c + "', '" + d + "', '" + e + "', '" + f + "', '" + g + "', '" + h + "', '" + i + "', '" + j + "');");
            Sql.Connection = MyDataConnect;
            try
            {
                Sql.ExecuteNonQuery();
            }
            catch
            {
                MyDataConnect.Close();
                return false;
            }
            MyDataConnect.Close();
            return true;
        }
        
        private bool _DataEmpty(string Table)
        {
            MySqlConnection MyDataConnect = new MySqlConnection(RRvar.sConStr);
            MySqlCommand Sql;
            MyDataConnect.Open();
            Sql = new MySqlCommand("DELETE FROM " + Table + " WHERE Id > 0;");
            Sql.Connection = MyDataConnect;
            try
            {
                Sql.ExecuteNonQuery();
            }
            catch
            {
                MyDataConnect.Close();
                return false;
            }
            MyDataConnect.Close();
            return true;
        }

        private bool _DataTableCreate(string Table)
        {
            
            MySqlConnection MyDataConnect = new MySqlConnection(RRvar.sConStr);
            MySqlCommand Sql;
            MyDataConnect.Open();
            Sql = new MySqlCommand("CREATE TABLE " + Table + "(Id COUNTER CONSTRAINT PrimaryKey PRIMARY KEY, Pc VARCHAR(100), a VARCHAR(100), b VARCHAR(100), c VARCHAR(100), d VARCHAR(100), e VARCHAR(100), f VARCHAR(100), g VARCHAR(100), h VARCHAR(100), i VARCHAR(100), j VARCHAR(100), created TIMESTAMP DEFAULT NOW());");
            Sql.Connection = MyDataConnect;
            try
            {
                Sql.ExecuteNonQuery();
            }
            catch
            {
                MyDataConnect.Close();
                return false;
            }
            MyDataConnect.Close();
            return true;
        }

        public void RunSql(string sSql)
        {
            MySqlConnection MyDataConnect = new MySqlConnection(RRvar.sConStr);
            MySqlCommand Sql;

            try
            {
                MyDataConnect.Open();
                Sql = new MySqlCommand(sSql);
                Sql.Connection = MyDataConnect;
                Sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MyDataConnect.Close();
            }
            try
            {
                MyDataConnect.Close();
            }
            catch {}
        }

        public string RunSqlReturn(string sSql)
        {
            MySqlConnection MyDataConnect = new MySqlConnection(RRvar.sConStr);
            //RRvar.sConStr = "SERVER=10.7.16.16;DATABASE=samplex;UID=samplex;PASSWORD=System.Data.Security;CharSet=utf8;Allow User Variables=True;pooling=false;;ssl-mode=none;";
            string strDataCommand = sSql;
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            DataTable MyTable = new DataTable();
            MyDataConnect.Open();
            MyAdapter = new MySqlDataAdapter(strDataCommand, MyDataConnect);
            MyAdapter.Fill(MyTable);
            MyDataConnect.Close();  
            Object oId = MyTable.Rows[0][0];
            return Convert.ToString(oId);
        }
        public string Config(string sItem)
        {
            string sSql = "select value from config where item = '" + sItem + "';";
            
            MySqlConnection MyDataConnect = new MySqlConnection(RRvar.sConStr);
            string strDataCommand = sSql;
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            DataTable MyTable = new DataTable();
            MyDataConnect.Open();
            MyAdapter = new MySqlDataAdapter(strDataCommand, MyDataConnect);
            MyAdapter.Fill(MyTable);
            MyDataConnect.Close();
            Object oId = MyTable.Rows[0][0];
            return Convert.ToString(oId);
        }
    }
}
