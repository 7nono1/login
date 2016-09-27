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
        public static DataTable login(string IDl,string pawl)
        {
            String strSQL = "select * from load where [user]='"+IDl+"'";
            DataTable dt = DAL.DBHelper.getDt(strSQL);
            return dt;
        }
    }
}
