using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.OleDb;

namespace DAL
{
    public class DBHelper
    {

        /*
         * 链接sql数据库
         */
        private static string  getConn() {
            string strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
            return strConn;
        }

        public static DataTable getDt(string strSQL)
        {
            SqlConnection conn = new SqlConnection(getConn());
            conn.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strSQL,conn);
            da.Fill(dt);

            conn.Close();
            return dt;
        }

        public static void Getdt(string strSQL)
        {
            SqlConnection conn = new SqlConnection(getConn());
            conn.Open();
            
            SqlCommand cmd = new SqlCommand(strSQL,conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }



        /*
         *读取Excel表 
         */
        public static DataTable getExcle(string url)
        {
            string strConn = "provider=Microsoft.ACE.OLEDB.12.0;data source='" + url + "';Extended Properties='Excel 8.0;HDR=NO;IMEX=1'";
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();

            string strSQL = "select * from [sheet1$]";
            OleDbDataAdapter da = new OleDbDataAdapter(strSQL, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();

            return ds.Tables[0];
        }

        /*
         *批量导入excel数据到数据库
         */
        public static void SQLBulkCopy(DataTable dt) {
            using (SqlConnection conn = new SqlConnection(getConn())) {
                conn.Open();
                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conn)) {
                    bulkCopy.DestinationTableName = "TabTempUserInfo";
                    //bulkCopy.ColumnMappings.Add("","");
                    bulkCopy.WriteToServer(dt);
                }
            }
        }
    }
}
