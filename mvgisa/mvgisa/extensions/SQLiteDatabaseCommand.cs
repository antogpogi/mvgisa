using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mvgisa.extensions
{

    class SQLiteDatabaseCommand
    {
        public static string connectionString = Application.StartupPath + @"\database";
        public static SQLiteConnection con = new SQLiteConnection(@"data source=E:\Files\isaApp\mvgisa\mvgisa\database\mvgisa.db");

        public static DataTable selectSearch(string tablename, int Id)
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM " + tablename + " WHERE Id = " + Id, con);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
            finally { con.Close(); }
        }

        public static DataTable dataList(string tablename)
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM "+ tablename +" order by Id asc", con);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch(SQLiteException e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
            finally {  con.Close(); }
        }

        public static DataTable flowList(string tablename, string path)
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM " + tablename + " WHERE Path LIKE '" + path + "_%' order by Id desc", con);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
            finally { con.Close(); }
        }

        public static DataTable getFlowChartLines(string path)
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM tblFlowChartLines WHERE FlowChartId = @path order by FlowChartId desc", con);
                cmd.Parameters.Add("@path", DbType.String);
                cmd.Parameters[0].Value = path;
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
            finally { con.Close(); }
        }

        public static DataTable itemsList(string tablename, string path)
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM " + tablename + " WHERE Path Like '" + path + "_%' order by Id desc", con);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
            finally { con.Close(); }
        }
    

        public static int newKRA(string KRAtxt)
        {
            int i = 0;
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                SQLiteCommand cmd = new SQLiteCommand("INSERT into tblKRA (Name) VALUES (@Name)", con);
                SQLiteParameter param = new SQLiteParameter("@Name", KRAtxt);
                param.DbType = System.Data.DbType.String;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();

                SQLiteCommand cmdGet = new SQLiteCommand("SELECT * FROM tblKRA order by Id desc", con);
                i = int.Parse(cmdGet.ExecuteScalar().ToString());
                
            }
            catch(SQLiteException e)
            {
                MessageBox.Show(e.ToString());
            }
            finally { con.Close(); }
            return i;
        }

        public static void insertNodes(string tablename, string value, string path)
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                SQLiteCommand cmd = new SQLiteCommand("INSERT into " + tablename + " (Name, Path) VALUES (@Name, @Path)", con);
                SQLiteParameter param = new SQLiteParameter("@Name", value);
                param.DbType = System.Data.DbType.String;
                cmd.Parameters.Add(param);
                SQLiteParameter param2 = new SQLiteParameter("@Path", path);
                param2.DbType = System.Data.DbType.String;
                cmd.Parameters.Add(param2);
                cmd.ExecuteNonQuery();
            }
            catch(SQLiteException e)
            {
                MessageBox.Show(e.ToString());
            }
            finally { con.Close(); }
        }

        public static void insertNodeIndicator(string tablename, string value, string path, string indicator)
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                SQLiteCommand cmd = new SQLiteCommand("INSERT into " + tablename + " (Name, Indicator, Path) VALUES (@Name, @Indicator, @Path)", con);
                SQLiteParameter param = new SQLiteParameter("@Name", value);
                param.DbType = System.Data.DbType.String;
                cmd.Parameters.Add(param);
                //
                SQLiteParameter param2 = new SQLiteParameter("@Indicator", indicator);
                param2.DbType = System.Data.DbType.String;
                cmd.Parameters.Add(param2);
                //
                SQLiteParameter param3 = new SQLiteParameter("@Path", path);
                param3.DbType = System.Data.DbType.String;
                cmd.Parameters.Add(param3);
                //
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.ToString());
            }
            finally { con.Close(); }
        }

        public static void insertFlowLines()
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand("INSERT INTO tblFlowChartLines (FlowChartId, Text, DocuName, PageFrom, PageTo) VALUES (@FlowId, @Text, @DocuName, @From, @To)",con);
                    cmd.Parameters.Add("@FlowId", DbType.String);
                    cmd.Parameters.Add("@Text", DbType.String);
                    cmd.Parameters.Add("@DocuName", DbType.String);
                    cmd.Parameters.Add("@From", DbType.String);
                    cmd.Parameters.Add("@To", DbType.String);
                    foreach (var items in controls.flowList)
                    {
                        cmd.Parameters[0].Value = controls.KRA + "_" + items.flowNumber;
                        cmd.Parameters[1].Value = items.text;
                        cmd.Parameters[2].Value = items.documentName;
                        cmd.Parameters[3].Value = items.pageFrom;
                        cmd.Parameters[4].Value = items.pageTo;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.ToString());
            }
            finally { con.Close(); }
        }

        public static void deleteDocument(string DocumentName)
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand("DELETE from tblDocument WHERE DocumentName = @DocumentName", con);
                    SQLiteParameter param = new SQLiteParameter("@DocumentName", DocumentName);
                    param.DbType = System.Data.DbType.String;
                    cmd.Parameters.Add(param);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.ToString());
            }
            finally { con.Close(); }
        }

        public static void insertDocument(string DocumentName, string DocumentFileName)
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                SQLiteCommand cmd = new SQLiteCommand("INSERT into tblDocument (DocumentName, DocumentFileName) VALUES (@DocumentName, @DocumentFileName)", con);
                SQLiteParameter param = new SQLiteParameter("@DocumentName", DocumentName);
                param.DbType = System.Data.DbType.String;
                cmd.Parameters.Add(param);
                //
                SQLiteParameter param2 = new SQLiteParameter("@DocumentFileName", DocumentFileName);
                param2.DbType = System.Data.DbType.String;
                cmd.Parameters.Add(param2);
                //
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.ToString());
            }
            finally { con.Close(); }
        }
    }
}
