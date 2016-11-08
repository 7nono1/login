using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class login_login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        log();
    }

    private void log()
    {
        DataTable i = BLL.isLogin.login(userBox.Value);
        if (i.Rows.Count == 0)
        {
            Label1.Visible = true;
            Label1.Text = "该账号不存在";
        }
        if (i.Rows.Count == 1)
        {
            if (i.Rows[0][1].ToString() == pwdBox.Value.ToString())
            {
                if (Session["ValiDateCode"].ToString() == codeBox.Value)
                {
                    Session["userID"] = i.Rows[0][1];
                    Session["userPwd"] = i.Rows[0][2];
                    Session["userName"] = i.Rows[0][3];
                    Session["userCols"] = i.Rows[0][5];
                    switch (i.Rows[0][5].ToString())
                    {
                        case "1":
                            Response.Redirect("/管理员/message.aspx"); break;
                        case "2":
                            Response.Redirect("/领导/Default.aspx"); break;
                        case "3":
                            Response.Redirect("/辅导员/Default.aspx"); break;
                        case "4":
                            Response.Redirect("/教师/Default.aspx"); break;
                        default:
                            break;
                    }
                }
                else
                {
                    Label1.Visible = true;
                    Label1.Text = "验证码错误！";

                }
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "密码错误！如果密码忘记请速与管理员联系，谢谢！";
            }
        }
    }

}