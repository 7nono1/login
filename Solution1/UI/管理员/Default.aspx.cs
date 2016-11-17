using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class 管理员_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label2.Text = BLL.PWDProcess.MD5Encrypt("123123123123",BLL.PWDProcess.CreateKey("123123123"));
    }
}