using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
namespace BLL
{
    public class xsqk
    {
        public static void rowupdate(string stuname , string stuid , string week, string kecheng )
        {

            string SQL = "update 学生出勤 set " + stuname + "='" + stuid + "'where " + week +  "'";
            DBHelper.Getdt(SQL);

        }
        public static void rowdelete(string id, string key)
        {
            string SQL = "delete from 学生出勤 where " + id + "='" + key + "'";
            DBHelper.Getdt(SQL);
        }
        public static DataTable find()
        {
            string SQL = "select * from 学生出勤";
            DataTable dt = DBHelper.getDt(SQL);
            return dt;
        }
        public static DataTable Griview(string column, string name)
        {
            string SQL = "select * from 学生出勤 where " + column + "='" + name + "'";

            DataTable dt = DBHelper.getDt(SQL);
            return dt;

        }
    }
}
