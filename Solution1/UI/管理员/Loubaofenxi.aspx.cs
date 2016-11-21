using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
 using System.Drawing;
 using dotnetCHARTING;
using System.Data;
public partial class 管理员_Queqinfenxi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["userID"].ToString() != null && Session["userID"].ToString() != "")
        {
            if (!Page.IsPostBack)
            {
               Drawing("Column","1");
               Drawing("Column", "1");
                DropDownList1.Items.Add(new ListItem("柱状图", "Column"));
               DropDownList1.Items.Add(new ListItem("折线图", "Spline"));

                DropDownList2.Items.Add(new ListItem("全院情况", "1"));
                DropDownList2.Items.Add(new ListItem("信息与艺术系", "2"));
                DropDownList2.Items.Add(new ListItem("建筑系", "3"));
                DropDownList2.Items.Add(new ListItem("机械工程系", "4"));
                DropDownList2.Items.Add(new ListItem("会计系", "5"));
                DropDownList2.Items.Add(new ListItem("食品工程系", "6"));
                DropDownList2.Items.Add(new ListItem("经济管理系", "7"));
                DropDownList2.Items.Add(new ListItem("商务外语系", "8"));
            }
        }
        else
        {
            Response.Redirect("../login/login-form.aspx");
        }

      
    }

    private void Drawing(string type,string department)
    {
        Charting c = new Charting();

        c.Title = "缺勤情况";
       c.XTitle = "周次";
        c.YTitle = "人数（人）";
        c.PicHight = 250;        c.PicWidth = 400;
        c.PhaysicalImagePath = "ChartImages";//统计图片存放的文件夹名称，缺少对应的文件夹生成不了统计图片
       c.FileName = "Statistics51aspx";
        if (type== "Column")
         {
            c.Type = SeriesType.Column;
        }
        else
       {
             c.Type = SeriesType.Spline;
             
        }

        if (department =="1")
        { 
            c.DataSource = GetDataSource(1, 7);
        }
        else if (department == "2")
        {
            c.DataSource = GetDataSource(1, 1);
        }
        else if (department == "3")
        {
            c.DataSource = GetDataSource(2, 2);
        }
        else if (department == "4")
        {
            c.DataSource = GetDataSource(3, 3);
        }

        else if (department == "5")
        {
            c.DataSource = GetDataSource(4, 4);
        }

        else if (department == "6")
        {
            c.DataSource = GetDataSource(5, 5);
        }

        else if (department == "7")
        {
            c.DataSource = GetDataSource(6, 6);
        }

        else if (department == "8")
        {
            c.DataSource = GetDataSource(7, 7);
        }
        c.Use3D = true;

        c.CreateStatisticPic(this.Chart1);
 
     }
    private void Department(string department)
    {
      
    }




    private SeriesCollection GetDataSource(int i, int x)
    {
        SeriesCollection SC = new SeriesCollection();
        string droplist1 = DropDownList2.SelectedValue;


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

        //可自定义填充图的填充色，系统采取默认分配各数据项的填充色
        //SC[0].DefaultElement.Color = Color.Blue;
        //SC[1].DefaultElement.Color = Color.Red;
        //SC[2].DefaultElement.Color = Color.FromArgb(255, 99, 49);
        //SC[3].DefaultElement.Color = Color.FromArgb(0, 156, 255);
    }
 
     public class Charting
     {
         private string _phaysicalimagepath;//图片存放路径
         private string _title; //图片标题
        private string _xtitle;//图片x座标名称
         private string _ytitle;//图片y座标名称
        private string _seriesname;//图例名称
         private int _picwidth;//图片宽度
       private int _pichight;//图片高度
         private SeriesType _type;//统计图类型(柱形,线形等)
        private bool _use3d;//是否显示成3维图片
         private SeriesCollection _dt;//统计图数据源
        private string _filename;//统计图片的名称(不包括后缀名)

         /**/
        /// <summary>
        /// 图片存放路径
         /// </summary>
         public string PhaysicalImagePath
        {
             set { _phaysicalimagepath = value; }
            get { return _phaysicalimagepath; }
         }
        /**/
        /// <summary>
         /// 图片标题
         /// </summary>
        public string Title
         {
             set { _title = value; }
             get { return _title; }
         }
         /**/
        /// <summary>
         /// 图片x座标名称
        /// </summary>
        public string XTitle
         {
             set { _xtitle = value; }
             get { return _xtitle; }
         }
        /**/
        /// <summary>
         /// 图片y座标名称
         /// </summary>
         public string YTitle
        {
             set { _ytitle = value; }
            get { return _ytitle; }
         }
 
         /**/
         /// <summary>
        /// 图例名称
         /// </summary>
        public string SeriesName
         {
             set { _seriesname = value; }
            get { return _seriesname; }
        }
         /**/
        /// <summary>
         /// 图片宽度
         /// </summary>
         public int PicWidth
         {
             set { _picwidth = value; }
             get { return _picwidth; }
         }
        /**/
        /// <summary>
         /// 图片高度
        /// </summary>
         public int PicHight
         {
            set { _pichight = value; }
             get { return _pichight; }
         }
 
         /// <summary>
         /// 统计图类型(柱形,线形等)
         /// </summary>
         public SeriesType Type
        {
             set { _type = value; }
             get { return _type; }
        }
 
        /// <summary>
         /// 是否将输出的图片显示成三维
         /// </summary>
         public bool Use3D
         {
             set { _use3d = value; }
             get { return _use3d; }
        }
 
        /// <summary>
        /// 对比图形数据源
         /// </summary>
         public SeriesCollection DataSource
         {
 
             set { _dt = value; }
             get { return _dt; }
         }
 
         /// <summary>
         /// 生成统计图片的名称
        /// </summary>
         public string FileName
         {
            set { _filename = value; }
             get { return _filename; }
        }
 
 
         /// <summary>
         /// 生成统计图片
         /// </summary>
         /// <param name="chart"></param>
         /// <param name="type">图形类别,如柱状，折线型</param>
         public void CreateStatisticPic(dotnetCHARTING.Chart chart)
         {
             chart.Title = this.Title;
             chart.XAxis.Label.Text = this.XTitle;
             chart.YAxis.Label.Text = this.YTitle;
             chart.TempDirectory = this.PhaysicalImagePath;
            chart.FileManager.FileName = this.FileName;
             chart.Width = this.PicWidth;
             chart.Height = this.PicHight;
             chart.Type = ChartType.Combo;
             //chart.Series.Type = this.Type;//生成对比的线型图时不适用
             chart.DefaultSeries.Type = this.Type; //统一使用默认的序列图类型属性
             chart.Series.Name = this.SeriesName;
             chart.SeriesCollection.Add(this.DataSource);
             chart.DefaultSeries.DefaultElement.ShowValue = true;
             chart.ShadingEffect = true;
             chart.Use3D = this.Use3D;
            chart.Series.DefaultElement.ShowValue = true;
        }
    }
 

    protected void DropDownList1_TextChanged(object sender, EventArgs e)
    {
        Drawing(DropDownList1.SelectedValue,DropDownList2.SelectedValue);
    }


    protected void DropDownList2_TextChanged(object sender, EventArgs e)
    {
        Drawing(DropDownList2.SelectedValue,DropDownList1.SelectedValue);
    }


}
