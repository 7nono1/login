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

    }

    private void log()
    {
        DataTable i = BLL.isLogin.login(TextBox1.Text, TextBox2.Text);
        if (i.Rows.Count == 0)
        {
            Label3.Text = "登陆失败！";
        }
        if (i.Rows.Count > 0)
        {
            Label4.Text = "权限为" + i.Rows[0]["id"];
            Label3.Text = "登陆成功！";
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        log();
    }
}