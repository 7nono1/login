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
        /*
         *登陆信息 
         */
        public static DataTable login(string IDl)
        {
            String strSQL = "SELECT * from 教师 WHERE 工号='" + IDl + "'";
            DataTable dt = DAL.DBHelper.getDt(strSQL);
            return dt;
        }

        /**
         * 查询教师信息
         */
        public static DataTable Adminteach()
        {
            string str = "SELECT 工号,姓名,权限,部门 FROM 教师";
            DataTable dt = DAL.DBHelper.getDt(str);
            return dt;
        }

        /**
         * 新增教师用户
         * 
         */
        public static int creatTeach(string YN, string dpm, string usrid, string userName, string sex, string Pwd, string permissions)
        {
            if (YN == "外聘教师")
            {
                YN = "是";
            }
            if (YN == "本校教师")
            {
                YN = "否";
            }
            string str = "INSERT INTO 教师(工号,密码,姓名,权限,性别,部门,是否外聘教师)VALUES('" + usrid + "','" + Pwd + "','" + userName + "','" + permissions + "','" + sex + "','" + dpm + "','" + YN + "')";

            DAL.DBHelper.Getdt(str);
            DataTable dt = DAL.DBHelper.getDt("SELECT * FROM 教师 WHERE 工号='" + usrid + "'");
            if (dt.Rows.Count == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        /*
         * 修改教师密码
         */
        public static int updt(string pwd, string id, string ypwd)
        {
            string str = "UPDATE 教师 SET 密码='" + pwd.Trim() + "' WHERE 工号='" + id.Trim() + "'";
            DAL.DBHelper.Getdt(str);
            DataTable dtt = DAL.DBHelper.getDt("SELECT 密码 FROM 教师 WHERE 工号='" + id.Trim() + "'");
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
        public static int sendmarg(string message, string id)
        {
            DataTable dt = DAL.DBHelper.getDt("SELECT 工号 FROM 教师 WHERE 权限='" + id + "'");
            string timer = System.DateTime.Now.ToShortDateString();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string str = "INSERT INTO 消息(时间,信息,用户名,阅读状态)VALUES('" + timer + "','" + message + "','" + dt.Rows[i][0] + "','1')";
                DAL.DBHelper.Getdt(str);
            }

            return 1;
        }

        /*
         *查询消息
         */
        public static DataTable readmarg(string id, string num)
        {
            DataTable dt = DAL.DBHelper.getDt("SELECT 时间,信息 FROM 消息 WHERE 用户名='" + id + "' AND 阅读状态='" + num + "'");
            return dt;
        }
        /*
         *修改标记消息阅读状态
         */
        public static void upmarg(string id, string marg, string timema)
        {
            DAL.DBHelper.Getdt("UPDATE 消息 SET 阅读状态='2' WHERE 时间='" + timema + "' AND 信息='" + marg + "' AND 用户名='" + id + "'");
        }
        /*
         *所有消息已读
         */
        public static void upmarg1(string id)
        {
            DAL.DBHelper.Getdt("UPDATE 消息 SET 阅读状态='2' WHERE 用户名='" + id + "'");
        }

        /*
         *删除历史信息
         */
        public static void delemarg(string id, string marg, string timemarg)
        {
            DAL.DBHelper.Getdt("DELECT FROM 消息 WHERE 用户名='" + id + "' AND 时间='" + timemarg + "' AND 信息='" + marg + "' AND 阅读状态='2'");
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
        public static int excle(string url, string tb)
        {

            DataTable dt = DAL.DBHelper.getExcle(url);
            if (tb == "全校教师")
            {
                DAL.DBHelper.SQLBulkCopy(dt,"教师");
            }
            if (tb == "外聘教师")
            {
                DAL.DBHelper.waiteaSQLBulkCopy(dt,tb);
                DAL.DBHelper.waipinTea(dt, "教师");
            }
            if (tb == "信息艺术系" || tb == "会计系" || tb == "商务外语系" || tb == "食品工程系" || tb == "建筑工程系" || tb == "机械工程系" || tb == "经济管理系" || tb == "教务处" || tb == "基础教学部")
            {
                DAL.DBHelper.xibu(dt,tb);
            }
            if (tb == "校历")
            {
            }
            return 1;
        }

        /*
         *清空所有数据
         */

        public static void wipe(string tb)
        {
            DAL.DBHelper.Getdt("DELETE FROM "+tb);
        }
        public static void de()
        {

            DAL.DBHelper.Getdt("delete from 信息艺术系");
            DAL.DBHelper.Getdt("delete from 教师 where 工号!='12'");
            DAL.DBHelper.Getdt("delete from 消息");
            DAL.DBHelper.Getdt("delete from 外聘教师");
            DAL.DBHelper.Getdt("delete from 会计系");
            DAL.DBHelper.Getdt("delete from 商务外语系");
            DAL.DBHelper.Getdt("delete from 食品工程系");
            DAL.DBHelper.Getdt("delete from 建筑工程系");
            DAL.DBHelper.Getdt("delete from 机械工程系");
            DAL.DBHelper.Getdt("delete from 经济管理系");
            DAL.DBHelper.Getdt("delete from 教务处");
            DAL.DBHelper.Getdt("delete from 基础教学部");
        }
    }
}
