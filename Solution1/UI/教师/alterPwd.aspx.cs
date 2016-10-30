using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class 教师_alterPwd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label6.Visible = false;
        Label5.Visible = false;
        Label4.Visible = false;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Session["userPwd"].ToString().Trim() == userID.Value.ToString())
        {
            int i = BLL.isLogin.updt(userPwd.Value.ToString(), Session["userID"].ToString().Trim(), userPwd.Value.Trim());
            if (i == 0)
            {
                Label6.Visible = true;
                Label6.Text = "对不起，修改失败！";
            }
            else
            {
                Label6.Visible = true;
                Label6.Text = "修改成功！";
            }
        }
        else
        {
            Label4.Visible = true;
            Label4.Text = "密码错误！";
        }
    }
}