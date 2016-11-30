using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class 领导_XiangxiXinxi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        bind();


    }
    public void bind()
    {
        string ID = Session["UidID"].ToString().Trim();
        GridView1.DataSource = BLL.isLogin.getTeacher1(ID);
        GridView1.DataBind();
    }

    protected void GridView1_PageIndexChanged(object sender, EventArgs e)
    {

    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        bind();

    }


}