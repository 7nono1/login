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
            if (YN == "外聘教师")
            {
                YN = "是";
            }
            if (YN == "本校教师")
            {
                YN = "否";
            }
            string str = "insert into 教师(工号,密码,姓名,权限,性别,部门,是否外聘教师)values('" + usrid + "','" + Pwd + "','" + userName + "','" + permissions + "','" + sex + "','" + dpm + "','" + YN + "')";

            DAL.DBHelper.Getdt(str);
            DataTable dt = DAL.DBHelper.getDt("select * from 教师 where 工号='"+usrid+"'");
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
        public static int updt(string pwd,string id,string ypwd)
        {
            string str = "update 教师 set 密码='"+pwd.Trim()+"' where 工号='"+id.Trim()+"'";
            DAL.DBHelper.Getdt(str);
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
        public static int sendmarg(string message,string id)
        {
            DataTable dt = DAL.DBHelper.getDt("select 工号 from 教师 where 权限='"+id+"'");
            string timer = System.DateTime.Now.ToShortDateString();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string str = "insert into 消息(时间,信息,用户名,阅读状态)values('" + timer + "','" + message + "','" + dt.Rows[i][0] + "','1')";
                DAL.DBHelper.Getdt(str);
            }
          
                return 1;
        }

        /*
         *查询消息
         */
        public static DataTable readmarg(string id)
        {
            DataTable dt = DAL.DBHelper.getDt("select 时间,信息 from 消息 where 用户名='"+id+"' and 阅读状态='1'");
            return dt;
        }
        /*
         *修改标记消息阅读状态
         */
        public static void upmarg(string id,string marg,string timema)
        {
            DAL.DBHelper.Getdt("update 消息 set 阅读状态='2' where 时间='"+timema+"' and 信息='"+marg+"' and 用户名='"+id+"'");
        }
        public static void upmarg1(string id)
        {
            DAL.DBHelper.Getdt("update 消息 set 阅读状态='2' where 用户名='"+id+"'");
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
        public static int excle(string url,string tb)
        {
            
            DataTable dt= DAL.DBHelper.getExcle(url);
            for (int i = 1; i < dt.Rows.Count; i++)
            {
                if (tb == "教师信息")
                {
                    DAL.DBHelper.Getdt("insert into 教师 values('" + dt.Rows[i][0] + "','" + dt.Rows[i][1] + "','" + dt.Rows[i][2] + "','" + dt.Rows[i][3] + "','" + dt.Rows[i][4] + "','" + dt.Rows[i][5] + "','" + dt.Rows[i][6] + "','" + dt.Rows[i][7] + "','" + dt.Rows[i][8] + "','" + dt.Rows[i][9] + "','" + dt.Rows[i][10] + "','" + dt.Rows[i][11] + "','" + dt.Rows[i][12] + "','" + dt.Rows[i][13] + "') ");
                }
                if (tb == "学生信息") {

                    DAL.DBHelper.Getdt("insert into 学生 values('" + dt.Rows[i][0] + "','" + dt.Rows[i][1] + "','" + dt.Rows[i][2] + "','" + dt.Rows[i][3] + "','" + dt.Rows[i][4] + "','" + dt.Rows[i][5] + "') ");

                }
                if (tb == "信息艺术系" || tb == "会计系" || tb == "商务外语系" || tb == "食品工程系" || tb == "建筑工程系" || tb == "机械工程系" || tb == "经济管理系" || tb == "教务处" || tb == "基础教学部")
                {
                    DAL.DBHelper.Getdt("insert into "+tb+" values('" + dt.Rows[i][0] + "','" + dt.Rows[i][1] + "','" + dt.Rows[i][2] + "','" + dt.Rows[i][3] + "') ");

                }
                if (tb == "所有课程")
                {
                    DAL.DBHelper.Getdt("insert into " + tb + " values('" + dt.Rows[i][0] + "','" + dt.Rows[i][1] + "','" + dt.Rows[i][2] + "','" + dt.Rows[i][3] + "','" + dt.Rows[i][4] + "','" + dt.Rows[i][5] + "','" + dt.Rows[i][6] + "','" + dt.Rows[i][7] + "') ");

                }
            }
            return 1;
        }
    }
}
