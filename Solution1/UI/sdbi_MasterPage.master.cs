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
        Label1.Attributes.Add("onclick", "display()");
        if (!IsPostBack)
        {
            Bind_Tv(BLL.isLogin.tr(), TreeView1.Nodes, null, "id", "parent_id", "name");
        }
    }

    protected void Label1_DataBinding(object sender, EventArgs e)
    {
    }

    protected void Bind_Tv(DataTable dt, TreeNode p_Node, string pid_val, string id, string pid, string text)
    {
        DataView dv = new DataView(dt);//将DataTable存到DataView中，以便于筛选数据
        TreeNode tn;//建立TreeView的节点（TreeNode），以便将取出的数据添加到节点中
                    //以下为三元运算符，如果父id为空，则为构建“父id字段 is null”的查询条件，否则构建“父id字段=父id字段值”的查询条件
        string filter = string.IsNullOrEmpty(pid_val) ? pid + " is null" : string.Format(pid + "='{0}'", pid_val);
        dv.RowFilter = filter;//利用DataView将数据进行筛选，选出相同 父id值 的数据
        foreach (DataRowView row in dv)
        {
            tn = new TreeNode();//建立一个新节点（学名叫：一个实例）
            if (p_Node == null)//如果为根节点
            {
                tn.Value = row[id].ToString();//节点的Value值，一般为数据库的id值
                tn.Text = row[text].ToString();//节点的Text，节点的文本显示
                TreeView1.Nodes.Add(tn);//将该节点加入到TreeView中
                Bind_Tv(dt, tn, tn.Value, id, pid, text);//递归（反复调用这个方法，直到把数据取完为止）
            }
            else//如果不是根节点
            {
                tn.Value = row[id].ToString();//节点Value值
                tn.Text = row[text].ToString();//节点Text值
                p_Node.ChildNodes.Add(tn);//该节点加入到上级节点中
                //Bind_Tv(dt, tn, tn.Value, id, pid, text);//递归
            }
        }
    }


    private void Bind_Tv(DataTable dt, TreeNodeCollection tnc, string pid_val, string id, string pid, string text)
    {
        DataView dv = new DataView(dt);//将DataTable存到DataView中，以便于筛选数据
        TreeNode tn;//建立TreeView的节点（TreeNode），以便将取出的数据添加到节点中
                    //以下为三元运算符，如果父id为空，则为构建“父id字段 is null”的查询条件，否则构建“父id字段=父id字段值”的查询条件
        string filter = string.IsNullOrEmpty(pid_val) ? pid + " is null" : string.Format(pid + "='{0}'", pid_val);
        dv.RowFilter = filter;//利用DataView将数据进行筛选，选出相同 父id值 的数据
        foreach (DataRowView drv in dv)
        {
            tn = new TreeNode();//建立一个新节点（学名叫：一个实例）
            tn.Value = drv[id].ToString();//节点的Value值，一般为数据库的id值
            tn.Text = drv[text].ToString();//节点的Text，节点的文本显示
            tnc.Add(tn);//将该节点加入到TreeNodeCollection（节点集合）中
            Bind_Tv(dt, tn.ChildNodes, tn.Value, id, pid, text);//递归（反复调用这个方法，直到把数据取完为止）
        }
    }
}
