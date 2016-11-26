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
        getTAble();

    }
    public  void getTAble()
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
                BLL.isLogin.inster(dt, "漏报分析");
            }
        }
        string aa = "";
        dt = BLL.isLogin.setWeiKaoqin();
        BLL.isLogin.getTeacher1();
        //int n = (int)dt.Rows.Count;
        //int[] arry = new int[n];
        BLL.isLogin.inster1(dt, "漏报分析");
        GridView1.DataSource = BLL.isLogin.getTeacherTable();
        GridView1.DataBind();
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        getTAble();
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
    
   
