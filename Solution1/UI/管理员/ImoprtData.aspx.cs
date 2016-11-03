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

    }

    /*
     * 导入数据
     */
    string cur = string.Empty;
    protected void Button1_Click(object sender, EventArgs e)
    {
        string tempPath = Path.GetTempPath();
        HttpPostedFile ff = this.FileUpload1.PostedFile;//文件所有属性
        string Filename = ff.FileName;//文件名
        //string path = "C:\\Users\\昱小可\\Desktop\\ASP.NET\\";//上传路径
        //string path=Path.GetTempPath();//获取系统临时文件路径
        string path = Server.MapPath("../")+"testDB\\";//上传到工程文件夹里
        //Filename = Path.GetFileName( FileUpload1.PostedFile.FileName);//文件名
        //string Extension=Path.GetExtension(Filename);//获取文件的扩展名
        string[] date = System.DateTime.Now.ToShortDateString().Split('/');//把日期的‘/’符号改成‘-’
        string Newdate = "";
        for (int i = 0; i < date.Length; i++)
        {
            Newdate = Newdate + date[i] + "-";
        }
        string[] time = System.DateTime.Now.ToLongTimeString().Split(':');//把时间‘：’符号改成‘-’
        string Newtime = "";
        for (int i = 0; i < time.Length; i++)
        {
            Newtime = Newtime + time[i] + "-";
        }
        Filename = Newdate + Newtime + Filename;//日期、时间、文件名（带扩展名）合成一个文件名
        this.cur = path + Filename;//将路径加文件名合并
        ff.SaveAs(this.cur);//上传
        int send = BLL.isLogin.excle(cur,DropDownList1.SelectedValue.ToString().Trim());
    }

    protected void Button5_Click(object sender, EventArgs e)
    {

    }

    protected void Button6_Click(object sender, EventArgs e)
    {

    }

    protected void Button7_Click(object sender, EventArgs e)
    {

    }
}