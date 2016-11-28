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
public partial class 管理员_Zuoyetongji : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        getTAble();
        if(!IsPostBack)
        {
            getBind(DropDownList1.SelectedValue);
        }

    }
    public void getTAble()
    {
        string[] allDepartment = { "会计系", "信息工程系", "经济管理系", "食品工程系", "机械工程系", "商务外语系", "建筑工程系" };
        BLL.zytj.getWork();
        DataTable dt = new DataTable();
        string[] allClass = { "1-2节", "3-4节", "5-6节", "7-8节" };
        string[] str = { "星期一", "星期二", "星期三", "星期四", "星期五", "星期六", "星期天" };
        for (int i = 0; i < allDepartment.Length; i++)
        {

            dt = BLL.zytj.getWork(allDepartment[i]);
            if (dt.Rows.Count == 0)
            { }
            else
            {
                BLL.isLogin.inster(dt,"作业统计121");
            }
        }
        dt = BLL.zytj.setWork();
        BLL.zytj.getWork();
        //int n = (int)dt.Rows.Count;
        //int[] arry = new int[n];
        BLL.isLogin.inster1(dt, "作业统计121");
       
    }
    public void getBind(string SelectIdex)
    {
        SelectIdex = DropDownList1.SelectedValue;
        if (SelectIdex == "所有数据")
        {
            Bind(BLL.zytj.getWorkTable());
        }
        else if (SelectIdex != "所有数据" && TextBox1.Text != "")
        {
            if (SelectIdex == "系部查询")
            {
                Bind(BLL.zytj.getWorkTable("系部", TextBox1.Text));
            }
            else if (SelectIdex == "学号查询")
            {
                Bind(BLL.zytj.getWorkTable("学号", TextBox1.Text));
            }
            else if (SelectIdex == "姓名查询")
            {
                Bind(BLL.zytj.getWorkTable("姓名", TextBox1.Text));
            }
        }
    }
    public void Bind(DataTable dt)
    {
        GridView1.DataSource = dt;
        GridView1.DataKeyNames = new string[] { "学号" };
        GridView1.DataBind();
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        getBind(DropDownList1.SelectedValue);
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string sno =  GridView1.SelectedRow.Cells[1].Text.ToString();
        //txtName.Text = Gridview1.SelectedRow.Cells[1].Text.ToString();
        Response.Redirect("Xiangxi.aspx?学号='" + sno + "'");
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedValue == "所有数据")

        {

            TextBox1.Visible = false;
        }
        else
        {

            TextBox1.Visible = true;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        getBind(DropDownList1.SelectedValue);
        TextBox1.Text = "";
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if(e.CommandName=="详细")
        {
            Label3.Text = GridView1.Rows[Convert.ToInt32(e.CommandArgument)].Cells[1].Text.ToString().Trim();
            //string sno = GridView1.Rows[Convert.ToInt32(e.CommandArgument)].Cells[1].Text.ToString().Trim();
            //    Bind(BLL.zytj.getWorkTable("学号", sno));
            Session["ID"] = Label3.Text.ToString().Trim();
            Response.Redirect("Xiangxi.aspx");
            
        }
    }



    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
       
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {

    }
}
    
   
