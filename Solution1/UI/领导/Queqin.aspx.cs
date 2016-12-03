using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using dotnetCHARTING;
using System.Data;
using System.Data.SqlClient;
using BLL;

public partial class 领导_Queqin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        { 
        GridView1.DataSource = initialDatattable();
        GridView1.DataKeyNames = new string[] { "系部" };//主键
        GridView1.DataBind();
        }
    }
    private DataTable initialDatattable()
    {


        double good = 0;
        double late = 0;
        double Early = 0;
        double Attendance = 0;
        double Leave = 0;
        double School = 0;
        BLL.isLogin.deleteStudent();
        string[] allDepartment = { "会计系", "信息工程系", "经济管理系", "食品工程系", "机械工程系", "商务外语系", "建筑工程系" };
        for (int j = 0; j < 7; j++)
        {
            for (int i = 0; i < 20; i++)
            {
                if (i == 0)
                {
                    good = 0;
                    late = 0;
                    Early = 0;
                    Attendance = 0;
                    Leave = 0;
                    School = 0;
                    good = BLL.isLogin.getStudent(allDepartment[j], i, "正常").Rows.Count + good;
                    late = BLL.isLogin.getStudent(allDepartment[j], i, "迟到").Rows.Count + late;
                    Early = BLL.isLogin.getStudent(allDepartment[j], i, "早退").Rows.Count + Early;
                    Attendance = BLL.isLogin.getStudent(allDepartment[j], i, "旷课").Rows.Count + Attendance;
                    Leave = BLL.isLogin.getStudent(allDepartment[j], i, "请假").Rows.Count + Leave;
                }
                else
                {
                    good = BLL.isLogin.getStudent(allDepartment[j], i, "正常").Rows.Count + good;
                    late = BLL.isLogin.getStudent(allDepartment[j], i, "迟到").Rows.Count + late;
                    Early = BLL.isLogin.getStudent(allDepartment[j], i, "早退").Rows.Count + Early;
                    Attendance = BLL.isLogin.getStudent(allDepartment[j], i, "旷课").Rows.Count + Attendance;
                    Leave = BLL.isLogin.getStudent(allDepartment[j], i, "请假").Rows.Count + Leave;
                }
            }
            School = good + late + Early + Attendance + Leave;
            double late1 = late / School;
            double Early1 = Early / School;
            double Attendance1 = Attendance / School;
            double Leave1 = Leave / School;
            double sum = late + Early + Attendance + Leave;
            double sum1 = sum / School;
            isLogin.getStudent(allDepartment[j], (int)School, (int)late, late1.ToString(), (int)Early, Early1.ToString(), (int)Attendance, Attendance1.ToString(), (int)Leave, Leave1.ToString(), (int)sum, sum1.ToString());

        }
        DataTable dt = isLogin.getStudent1();
        return dt;
    }

}