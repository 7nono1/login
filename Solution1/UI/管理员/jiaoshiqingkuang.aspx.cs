﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;

public partial class 管理员_jiaoshiqingkuang : System.Web.UI.Page
{
    protected void Inquire()
    {
        if (DropDownList1.SelectedItem.ToString() == "所有记录")
        {
            DataTable dt = jsqk.find();
            BindToGridView(dt);

        }
        else if (DropDownList1.SelectedItem.ToString() != "所有记录" && TextBox1.Text != "")
        {
            if (DropDownList1.SelectedItem.Text == "按教工号查询")
            {
                DataTable dt = jsqk.Griview("工号", TextBox1.Text);
                BindToGridView(dt);

            }
            else if (DropDownList1.SelectedItem.Text == "按姓名查询")
            {
                DataTable dt = jsqk.Griview("教师姓名", TextBox1.Text);
                BindToGridView(dt);
            }
            else if (DropDownList1.SelectedItem.Text == "按周次查询")
            {
                DataTable dt = jsqk.Griview("周次", TextBox1.Text);
                BindToGridView(dt);
            }
            else if (DropDownList1.SelectedItem.Text == "按课程查询")
            {
                DataTable dt = jsqk.Griview("课程", TextBox1.Text);
                BindToGridView(dt);
            }

        }
    }
    protected void BindToGridView(DataTable dt)
    {
        GridView1.DataSource = dt;
        GridView1.DataKeyNames = new string[] { "工号" };
        GridView1.DataBind();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedItem.ToString() == "所有记录")

        {
            Label2.Visible = false;
            TextBox1.Visible = false;
        }
        else
        {
            Label2.Visible = true;
            TextBox1.Visible = true;
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;

        Inquire();


    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        Inquire();

    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        Inquire();
    }
    //protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    //{

    //    jsqk.rowdelete("工号", GridView1.DataKeys[e.RowIndex].Value.ToString());
    //    {
    //        Inquire();
    //    }

    //}
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

        string strUserRole = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[6].Controls[0])).Text.ToString();
        string zc = GridView1.Rows[e.RowIndex].Cells[3].Text.ToString();
        string zq = GridView1.Rows[e.RowIndex].Cells[4].Text.ToString();
        string jc = GridView1.Rows[e.RowIndex].Cells[5].Text.ToString();
        string kc = GridView1.Rows[e.RowIndex].Cells[2].Text.ToString();
        string strUserID = GridView1.DataKeys[e.RowIndex].Value.ToString();
        jsqk.rowupdate("是否考勤", strUserRole, "工号", strUserID,zc,zq,jc,kc);




        GridView1.EditIndex = -1;
        Inquire();


    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {



    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Inquire();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userID"].ToString() != null && Session["userID"].ToString() != "")
        {
            if (!IsPostBack)
            {
                DataTable dt = jsqk.find();
                BindToGridView(dt);
                Label2.Visible = false;
                TextBox1.Visible = false;


            }
        }
        else
        {
            Response.Redirect("../login/login-form.aspx");
        }
    }
}