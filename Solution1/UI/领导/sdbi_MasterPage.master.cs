using System;
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
        if (!IsPostBack)
        {
            tree();
        }
    }

    public void tree()
    {
        DataTable dt = BLL.isLogin.Btr();
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
    

    protected void TreeView1_SelectedNodeChanged1(object sender, EventArgs e)
    {
        switch (TreeView1.SelectedNode.Text)
        {
            case "首页消息":
                Response.Redirect("message.aspx"); break;
            case "个人信息":
                Response.Redirect("alterPwd.aspx"); break;
            case "修改密码":
                Response.Redirect("alterPwd.aspx"); break;


            case "数据分析":
                Response.Redirect("DAform.aspx"); break;
            case "系部分析":
                Response.Redirect("DapartmentForm.aspx"); break;
            case "作业分析":
                Response.Redirect("Zuoyefenxi.aspx"); break;
            case "漏报分析":
                Response.Redirect("FTRform.aspx"); break;
            case "缺勤汇总":
                Response.Redirect("lack.aspx"); break;
            case "导出数据":
                Response.Redirect("leadform.aspx"); break;


            case "考勤信息":
                Response.Redirect("enterwork.aspx"); break;
            case "录入考勤":
                Response.Redirect("enterwork.aspx"); break;
            case "以往记录":
                Response.Redirect("alterPwd.aspx"); break;
        }
    }
}
