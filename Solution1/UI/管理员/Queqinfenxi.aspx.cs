using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using dotnetCHARTING;
public partial class 管理员_Queqinfenxi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Drawing("Spline");

            DropDownList1.Items.Add(new ListItem("AreaLine", "AreaLine"));
            DropDownList1.Items.Add(new ListItem("Bar", "Bar"));
            DropDownList1.Items.Add(new ListItem("Column", "Column"));
            DropDownList1.Items.Add(new ListItem("Cylinder", "Cylinder"));
            DropDownList1.Items.Add(new ListItem("Line", "Line"));
            DropDownList1.Items.Add(new ListItem("Marker", "Marker"));
            DropDownList1.Items.Add(new ListItem("Spline", "Spline"));
        }
    }

    private void Drawing(string type)
    {
        Charting c = new Charting();

        c.Title = "缺勤情况";
        c.XTitle = "周次";
        c.YTitle = "人数（人）";
        c.PicHight = 600;
        c.PicWidth = 1000;
        c.SeriesName = "合计";//仅对于DataTable类型做数据源时，此属性有效
        c.PhaysicalImagePath = "ChartImages";//统计图片存放的文件夹名称，缺少对应的文件夹生成不了统计图片
        c.FileName = "Statistics51aspx";
        if (type == "AreaLine")
        {
            c.Type = SeriesType.AreaLine;
        }
        else if (type == "Bar")
        {
            c.Type = SeriesType.Bar;
        }
        else if (type == "Column")
        {
            c.Type = SeriesType.Column;
        }
        else if (type == "Cylinder")
        {
            c.Type = SeriesType.Cylinder;
        }
        else if (type == "Line")
        {
            c.Type = SeriesType.Line;
        }
        else if (type == "Marker")
        {
            c.Type = SeriesType.Marker;
        }
        else
        {
            c.Type = SeriesType.Spline;
        }


        c.Use3D = false;
        c.DataSource = GetDataSource();
        c.CreateStatisticPic(this.Chart1);

    }




    private SeriesCollection GetDataSource()
    {
        SeriesCollection SC = new SeriesCollection();
        Random rd = new Random();


        for (int a = 1; a <= 7; a++) //对比的项数
        {
            Series s = new Series();
            if (a == 1)
            {
                s.Name = ("信息系");
            }
            else if (a == 2)
            {
                s.Name = ("建筑系");
            }
            else if (a == 3)
            {
                s.Name = ("机电系");
            }
            else if (a == 4)
            {
                s.Name = ("粮食工程系");
            }
            else if (a == 5)
            {
                s.Name = ("食品工程系");
            }
            else if (a == 6)
            {
                s.Name = ("经济管理系");
            }
            else
            {
                s.Name = ("商务外语系");
            }
            //各个数据项代表的名称.

            for (int b = 1; b <= 19; b++) //X轴尺度个数，如19个周表示有19个尺度数
            {
                Element e = new Element();
                e.Name = "第" + b.ToString() + "周次";//对应于X轴个尺度的名称
                e.YValue = rd.Next(10);//与X轴对应的Y轴的数值
                s.Elements.Add(e);
            }
            SC.Add(s);
        }


        //可自定义填充图的填充色，系统采取默认分配各数据项的填充色
        //SC[0].DefaultElement.Color = Color.Blue;
        //SC[1].DefaultElement.Color = Color.Red;
        //SC[2].DefaultElement.Color = Color.FromArgb(255, 99, 49);
        //SC[3].DefaultElement.Color = Color.FromArgb(0, 156, 255);
        return SC;
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

    protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        Drawing(DropDownList1.SelectedValue);
    }
}