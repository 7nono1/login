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

public partial class 辅导员_DEpartment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
     
        if (!Page.IsPostBack)  
        {
           
            string str = Session["userName"].ToString();
           DataTable dt= BLL.Department.getDepartment(str);
            initialDatattable();
            DataTable dd = isLogin.getStudent2(dt.Rows[0][0].ToString());
            GridView1.DataSource = dd;
            GridView1.DataBind();
            Drawing("Column", dt.Rows[0][0].ToString());
          
        }

    }

    private void Drawing(string type,string department)
    {

        Charting c = new Charting();
        c.Title = "缺勤情况";
        c.XTitle = "周次";
        c.YTitle = "人数（人）";
        c.PicHight = 300;
        c.PicWidth = 800;
        c.PhaysicalImagePath = "ChartImages";//统计图片存放的文件夹名称，缺少对应的文件夹生成不了统计图片
        c.FileName = "Statistics51aspx";
          c.Type = SeriesType.Column;
        if (department == "信息与艺术系")
        {
            c.DataSource = GetDataSource(1, 1);
        }
        else if (department == "建筑系")
        {
            c.DataSource = GetDataSource(2, 2);
        }
        else if (department == "机电系")
        {
            c.DataSource = GetDataSource(3, 3);
        }

        else if (department == "机械工程系")
        {
            c.DataSource = GetDataSource(4, 4);
        }

        else if (department == "食品工程系")
        {
            c.DataSource = GetDataSource(5, 5);
        }

        else if (department == "经济管理系")
        {
            c.DataSource = GetDataSource(6, 6);
        }

        else if (department == "商务外语系")
        {
            c.DataSource = GetDataSource(7, 7);
        }
        c.Use3D = false;

        c.CreateStatisticPic(this.Chart1);

    }
    private void initialDatattable()
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
            double late1 = Math.Round(late / School, 3);
            double Early1 = Math.Round(Early / School, 3);
            double Attendance1 = Math.Round(Attendance / School, 3);
            double Leave1 = Math.Round(Leave / School, 3);
            double sum = late + Early + Attendance + Leave;
            double sum1 = Math.Round(sum / School, 3);
            isLogin.getStudent(allDepartment[j], (int)School, (int)late, late1.ToString("0.000"), (int)Early, Early1.ToString("0.000"), (int)Attendance, Attendance1.ToString("0.000"), (int)Leave, Leave1.ToString("0.000"), (int)sum, sum1.ToString());

        }
    
    }



    private SeriesCollection GetDataSource(int i, int x)
    {
        SeriesCollection SC = new SeriesCollection();
   


        for (int a = i; a <= x; a++) //对比的项数
        {
            Series s = new Series();
            if (a == 1)
            {
                getSc("信息工程系", s);
                SC.Add(s);
            }
            else if (a == 2)
            {
                getSc("建筑工程系", s);
                SC.Add(s);
            }
            else if (a == 3)
            {
                getSc("会计系", s);
                SC.Add(s);
            }
            else if (a == 4)
            {
                getSc("机械工程系", s);
                SC.Add(s);
            }
            else if (a == 5)
            {
                getSc("食品工程系", s);
                SC.Add(s);
            }
            else if (a == 6)
            {
                getSc("经济管理系", s);
                SC.Add(s);
            }
            else
            {
                getSc("商务外语系", s);
                SC.Add(s);

            }

            //各个数据项代表的名称.     
        }
        return SC;
    }
    public static void getSc(string departement, Series s)
    {
        Random rd = new Random();
        s.Name = (departement);
        for (int b = 1; b <= 19; b++) //X轴尺度个数，如19个周表示有19个尺度数
        {
            DataTable dt = BLL.isLogin.getStudent(departement, b);
            int i = dt.Rows.Count;

            Element e = new Element();
            e.Name = b.ToString();//对应于X轴个尺度的名称
            e.YValue = i;//与X轴对应的Y轴的数值
            s.Elements.Add(e);
        }
    }
}