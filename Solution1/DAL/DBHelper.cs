﻿using System;
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
        private static string GetConn()
        {
            string strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
            return strConn;
        
        }
        
        
        public static DataTable getDt(string strSQL)
        {
            string strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strSQL,conn);
            da.Fill(dt);

            conn.Close();
            return dt;
        }

        public static void Getdt(string strSQL)
        {
            string strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            
            SqlCommand cmd = new SqlCommand(strSQL,conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

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
        public static void SQLBulkCopy(DataTable dt)
        {
            using (SqlConnection conn = new SqlConnection(GetConn())) {
                conn.Open();
                using (SqlBulkCopy bulCopy = new SqlBulkCopy(conn))
                {
                    bulCopy.DestinationTableName = "";
                    bulCopy.ColumnMappings.Add("dt1", "dbt1");
                    bulCopy.ColumnMappings.Add("dt2", "dbt2");
                    bulCopy.ColumnMappings.Add("dt3", "dbt3");
                    bulCopy.ColumnMappings.Add("dt4", "dbt4");
                    bulCopy.WriteToServer(dt);

                }
            }
        }
    }
}

