using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class 管理员_ImoprtData : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
        Label2.Visible = false;
        Label2.Text = "失败!";
    }
    
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedValue != "")
        {
            if (FileUpload1.FileName != "")
            {
                exl();
            }
            else
            {
                Response.Write("<Script Language=JavaScript>alert('请先选择上传文件！');</Script>");
            }
        }
        else {
            Response.Write("<Script Language=JavaScript>alert('请先选择数据类型！');</Script>");
        }
    }

    /*
     *导入数据
     */

    string cur = string.Empty;
    private void exl() {

        string tempPath = Path.GetTempPath();
        HttpPostedFile ff = this.FileUpload1.PostedFile;//文件所有属性
       string filename = ff.FileName;//文件名
        //string path = "C:\\Users\\昱小可\\Desktop\\ASP.NET\\";//上传路径
        //string path=Path.GetTempPath();//获取系统临时文件路径
        string path = Server.MapPath("../") + "testDB\\";//要上传的工程文件夹
        string Filename = Path.GetFileName(filename);//文件名
        //string Extension=Path.GetExtension(Filename);//获取文件的扩展名
        //string[] date = System.DateTime.Now.ToShortDateString().Split('/');//把日期的‘/’符号改成‘-’
        //string Newdate = "";
        //for (int i = 0; i < date.Length; i++)
        //{
        //    Newdate = Newdate + date[i] + "-";
        //}
        //string[] time = System.DateTime.Now.ToLongTimeString().Split(':');//把时间‘：’符号改成‘-’
        //string Newtime = "";
        //for (int i = 0; i < time.Length; i++)
        //{
        //    Newtime = Newtime + time[i] + "-";
        //}
        //Filename = Newdate + Newtime + Filename;//日期、时间、文件名（带扩展名）合成一个文件名
        Filename = System.DateTime.Now.ToString("yyyyMMddhhmmssffff")+Filename;//将日期与文件名合并（带扩展名  ）
        this.cur = path + Filename;//将路径加文件名合并
        ff.SaveAs(this.cur);//上传
        int send = BLL.isLogin.excle(cur, DropDownList1.SelectedValue.ToString().Trim());
        if (send == 1)
        {
            Label1.Visible = true;
            Label1.Text = "成功！";
        }
        else
        {
            Label1.Visible = true;
            Label1.Text = "数据重复！";
        }
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        if (Label2.Text == "失败!")
        {
            int i = BLL.Datasplit.a();
            Label2.Text = "请您稍等。。。";
            if (i == 1)
            {
                Label2.Text = "成功！";
            }
        }
        else
        {
            Response.Redirect("<Script Language=JavaScript>alert('不可以重复分析哦');</Script>");
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label1.Visible = false;
    }
}