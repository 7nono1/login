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
        DataTable dt = BLL.isLogin.Atr();
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
            case "新增用户":
                Response.Redirect("AddUser.aspx"); break;
            case "发布通知":
                Response.Redirect("sendNew.aspx"); break;


            case "导入数据":
                Response.Redirect("ImoprtData.aspx"); break;

            case "缺勤分析":
                Response.Redirect("Queqinfenxi.aspx"); break;
            case "考勤信息":
                Response.Redirect("#"); break;
            case "录入考勤":
                Response.Redirect("#"); break;
            case "以往记录":
                Response.Redirect("#"); break;

        }
    }
}
