using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
 using System.Drawing;
 using dotnetCHARTING;
using System.Data;
using BLL;
public partial class 管理员_Queqinfenxi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string[] allDepartment = { "会计系", "信息工程系", "经济管理系", "食品工程系", "机械工程系", "商务外语系", "建筑工程系" };
        BLL.isLogin.getTeacher1();
        DataTable dt = new DataTable();
        int[] arr = new int[7];
        string[] allClass = { "1-2节", "3-4节", "5-6节", "7-8节" };
        string[] str = { "星期一", "星期二", "星期三", "星期四", "星期五", "星期六", "星期天" };
        for (int i = 0; i < allDepartment.Length; i++)
        {

            dt = BLL.isLogin.getTeacher(allDepartment[i]);
            if (dt.Rows.Count == 0)
            { }
            else
            {
                BLL.isLogin.inster(dt,"漏报分析");
            }  
        }string aa="";
        dt=BLL.isLogin.setWeiKaoqin();
        for(int x=1;x<dt.Rows.Count;x++)
        {
          BLL.isLogin.SETTeacher((int)dt.Rows[x]["未考勤次数"]);
        }

  
        GridView1.DataSource = dt ;
        GridView1.DataBind();

    }
}
    
   
