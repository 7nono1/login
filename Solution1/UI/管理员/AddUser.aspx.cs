﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class 管理员_AddUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
        Label2.Visible = false;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string YN = DropDownList1.SelectedValue.ToString().Trim();//教师类型
        string dpm = DropDownList2.SelectedValue.ToString().Trim();//所属部门
        string userID111 = TextBox1.Text.ToString().Trim();//教师工号
        string userName111 = TextBox2.Text.ToString().Trim();//教师姓名
        string pawd11 = Password1.Value.ToString().Trim();//密码
        string pawd1 = Password2.Value.ToString().Trim();//确认密码
        string sex = DropDownList4.SelectedValue.ToString().Trim();//性别
        string pms = DropDownList3.SelectedValue.ToString().Trim();//权限
        if (pawd1 == pawd11)
        {
            DataTable dt = BLL.isLogin.login(userID111);
            if (dt.Rows.Count == 0)
            {
                int i = BLL.isLogin.creatTeach(YN, dpm, userID111, userName111, sex, pawd1, pms);
                if (i == 1)
                {
                    Response.Write("<Script Language=JavaScript>alert('修改成功！');</Script>");
                }
                else
                {
                    Response.Write("<Script Language=JavaScript>alert('修改失败！');</Script>");
                }
            }
            else
            {
                Label2.Visible = true;
                Label2.Text = "该账号已存在";
            }
        }
        else
        {
            Label1.Visible = true;
            Label1.Text = "密码不一致";
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Label1.Visible = false;
        Label2.Visible = false;
        DropDownList1.SelectedIndex = 1;
        DropDownList2.SelectedIndex = 2;
        TextBox1.Text = "";
        TextBox2.Text = "";
        Password1.Value = "";
        Password2.Value = "";
        DropDownList4.SelectedIndex = 0;
        DropDownList3.SelectedIndex = 3;
    }
}