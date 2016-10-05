using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label3.Visible = false;
    }

    private void log()
    {
        DataTable i = BLL.isLogin.login(TextBox1.Text);
        if (i.Rows.Count == 0)
        {
            Label3.Visible = true;
            Label3.Text = "用户名错误！";
        }
        if (i.Rows.Count == 1)
        {
            if (i.Rows[0][1].ToString() == TextBox2.Value.ToString())
            {
                if (Session["ValiDateCode"].ToString() == TextBox3.Text)
                {
                    Label3.Visible = true;
                    Label3.Text = "登陆成功！";
                    Session["userID"] = i.Rows[0][0];
                    Session["userPwd"] = i.Rows[0][1];
                    Session["userName"] = i.Rows[0][2];
                    Session["userCols"] = i.Rows[0][3];
                    switch (i.Rows[0][3].ToString())
                    {
                        case "1":
                            Response.Redirect(""); break;
                        case "2":
                            Response.Redirect(""); break;
                        case "3":
                            Response.Redirect(""); break;
                        case "4":
                            Response.Redirect("https://www.baidu.com"); break;
                        default:
                            break;
                    }
                }
                else
                {
                    Label3.Text = "验证码错误！";
                }
            }
            else
            {
                Label3.Visible = true;
                Label3.Text = "密码错误！如果密码忘记请速与管理员联系，谢谢！";
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        log();
    }
}