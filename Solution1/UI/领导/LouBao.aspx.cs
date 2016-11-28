using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using dotnetCHARTING;
using System.Data;

public partial class 领导_LouBao : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        getTAble();
        if (!IsPostBack)
        {
            getBind(DropDownList1.SelectedValue);
        }




    }
    public void getTAble()
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
        dt = BLL.isLogin.setWeiKaoqin();
        BLL.isLogin.getTeacher1();
        BLL.isLogin.inster1(dt, "漏报分析");
        Bind(BLL.isLogin.getTeacherTable());
    }
    public void getBind(string SelectIdex)
    {
        SelectIdex = DropDownList1.SelectedValue;
        if (SelectIdex == "所有数据")
        {
            Bind(BLL.isLogin.getTeacherTable());
        }
        else if (SelectIdex != "所有记录" && TextBox1.Text != "")
        {
            if (SelectIdex == "系部查询")
            {
                Bind(BLL.isLogin.getTeacher("承担单位", TextBox1.Text));
            }
            else if (SelectIdex == "工号查询")
            {
                Bind(BLL.isLogin.getTeacher("工号", TextBox1.Text));
            }
            else if (SelectIdex == "姓名查询")
            {
                Bind(BLL.isLogin.getTeacher("教师姓名", TextBox1.Text));
            }
        }
    }
    public void Bind(DataTable dt)
    {
        GridView1.DataSource = dt;
        GridView1.DataKeyNames = new string[] { "工号" };
        GridView1.DataBind();
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        getBind(DropDownList1.SelectedValue);
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        getBind(DropDownList1.SelectedValue);
        TextBox1.Text = "";
    }

    protected void DropDownList1_TextChanged(object sender, EventArgs e)
    {

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

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {

        if (e.CommandName == "详细")
        {

            //string sno = GridView1.Rows[Convert.ToInt32(e.CommandArgument)].Cells[1].Text.ToString().Trim();
            //    Bind(BLL.zytj.getWorkTable("学号", sno));
            Session["UidID"] = GridView1.Rows[Convert.ToInt32(e.CommandArgument)].Cells[1].Text.ToString().Trim(); ;
            Response.Redirect("XiangxiXinxi.aspx");

        }
    }
}