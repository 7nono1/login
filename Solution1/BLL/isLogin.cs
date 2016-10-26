using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class isLogin
    {
        public static DataTable login(string IDl)
        {
            String strSQL = "select * from 教师 where 工号='"+IDl+"'";
            DataTable dt = DAL.DBHelper.getDt(strSQL);
            return dt;
        }

        /**
         * 查询教师信息
         */
        public static DataTable Adminteach()
        {
            string str = "select 工号,姓名,权限,部门 from 教师";
            DataTable dt = DAL.DBHelper.getDt(str);
            return dt;
        }

        /**
         * 新增教师用户
         * 
         */
        public static int creatTeach(string YN,string dpm,string usrid,string userName,string sex,string Pwd,string permissions)
        {
            string str= "insert into 教师(工号,密码,姓名,权限,性别,部门,是否外聘(1/2))values('"+usrid+"','"+Pwd+"','"+userName+"','"+permissions+"','"+sex+"','"+dpm+"','"+YN+"')";

            DataTable dt = DAL.DBHelper.Getdt(str);
            if (dt.Rows.Count == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        /*
         * 修改教师密码
         */
        public static int updt(string pwd,string id,string ypwd)
        {
            string str = "update 教师 set 密码='"+pwd.Trim()+"' where 工号='"+id.Trim()+"'";
            DataTable dt = DAL.DBHelper.Getdt(str);
            DataTable dtt = DAL.DBHelper.getDt("select 密码 from 教师 where 工号='"+id.Trim()+"'");
            if (dtt.Rows[0][0].ToString() == ypwd.Trim())
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        /**
         * 发布通知 
         */
        public static int inform(string message,DataTable id)
        {
            DataTable ID = id;
            DataTable dt = new DataTable();
            for (int i = 0; i < ID.Rows.Count; i++)
            {
                string timer = System.DateTime.Now.ToShortDateString();
                string str = "insert into 消息(时间,信息,用户名,阅读状态)values('" + timer + "','"+message+"','"+ID.Rows[i][0]+"','1')";
                dt = DAL.DBHelper.Getdt(str);
            }
            if (dt.Rows.Count == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        /*
         * treeview链接数据库
         */
        public static DataTable Atr()
        {
            return DAL.DBHelper.getDt("select aid,aname from tree");
        }
        public static DataTable Btr()
        {
            return DAL.DBHelper.getDt("select bid,bname from tree");
        }
        public static DataTable Ctr()
        {
            return DAL.DBHelper.getDt("select cid,cname from tree");
        }
        public static DataTable Dtr()
        {
            return DAL.DBHelper.getDt("select did,dname from tree");
        }

        /*
         *数据的导入 
         */
        public static int excle(string url)
        {
            DataTable dt= DAL.DBHelper.getExcle(url);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    DataTable ft = DAL.DBHelper.Getdt("insert into ceshi(F"+(j+1)+") values('" + dt.Rows[i][j] + "') ");
                }
            }
            return 1;
        }
    }
}
