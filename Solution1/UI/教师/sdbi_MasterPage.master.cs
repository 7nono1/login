﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class sdbi_MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userID"].ToString() != null && Session["userID"].ToString() != "")
        {
            if (!IsPostBack)
            {
                tree();
                string co = Session["userCols"].ToString();
                if (co == "1")
                {
                    co = "管理员";
                }
                if (co == "2")
                {
                    co = "院系领导";
                }
                if (co == "3")
                {
                    co = "辅导员";
                }
                if (co == "4")
                {
                    co = "教师";
                }
                Label1.Text = Session["stuweek"].ToString();
                Label2.Text = "在线人数:";
                Label3.Text = Application["online"].ToString();
                namela.Text = co + "[" + Session["userID"].ToString() + "]" + Session["userName"].ToString() + " " + "您好!";
            }
        }
        else
        {
            Response.Redirect("../login/login-form.aspx");
        }
    }

    public void tree()
    {
        DataTable dt = BLL.isLogin.Dtr();
        TreeNode tn = new TreeNode(dt.Rows[0][1].ToString());
        tn.NavigateUrl = "";
        TreeView1.Nodes.Add(tn);
        for (int i = 1; i < dt.Rows.Count; i++)
        {
            if (dt.Rows[i][0].ToString() != null && dt.Rows[i][0].ToString() != "")
            {
                if (dt.Rows[i][0].ToString() == "10")
                {
                    TreeNode father = new TreeNode(dt.Rows[i][1].ToString());
                    TreeView1.Nodes[0].ChildNodes.Add(father);
                }
                if (dt.Rows[i][0].ToString() != "10" && dt.Rows[i][0].ToString() != "0")
                {
                    TreeNode child = new TreeNode(dt.Rows[i][1].ToString());
                    TreeView1.Nodes[0].ChildNodes[(Int32.Parse(dt.Rows[i][0].ToString()))].ChildNodes.Add(child);

                }
            }
        }

    }

    protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
    {
        switch (TreeView1.SelectedNode.Text)
        {
            case "首页消息":
                Response.Redirect("message.aspx"); break;
            case "修改密码":
                Response.Redirect("alterPwd.aspx"); break;


            case "考勤信息":
                Response.Redirect("#"); break;
            case "录入考勤":
                Response.Redirect("#"); break;
            case "以往记录":
                Response.Redirect("#"); break;
        }
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {

        Session["userID"] = "";
        Response.Redirect("/login/login-form.aspx");
    }
}
