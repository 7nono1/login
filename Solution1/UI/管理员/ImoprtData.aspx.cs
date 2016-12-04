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
        if (Session["userID"].ToString() != null && Session["userID"].ToString() != "")
        {
            Label1.Visible = false;
            Label6.Visible = false;
            Label7.Visible = false;
        }
        else
        {
            Response.Redirect("../login/login-form.aspx");
        }
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
       
        Label6.Visible = true;
            int i = BLL.Datasplit.a();
            if (i == 1)
            {
                Label6.Text = "成功！";
            }
            if (i == 2)
            {
                Label6.Text = "您已解析过课程";
            }
        int ii=BLL.Datasplit.kaoqin();
        if (ii == 1)
        {
            Label7.Visible = true;
            Label7.Text = "成功！";
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label1.Visible = false;
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        int sday = Convert.ToInt32(TextBox3.Text);//获取起始日
        int sum = sday-1;//总天数，控制月份转换
        int moth = Convert.ToInt32(TextBox2.Text);//获取起始月
        int week = Convert.ToInt32(TextBox4.Text);//获取总周次
        int moco = 0;//每月的总天数
        string we = "";//周次
        string mo = "";//月份
        int y = Convert.ToInt32(TextBox1.Text);
        for (int j = 0; j < week; j++)
        {
            for (int i = 0; i < 7; i++)
            {
                if (i == 0)
                {
                    we = (j + 1).ToString();
                }
                sum++;
                if (moth == 1 || moth == 3 || moth == 5 || moth == 7 || moth == 8 || moth == 10 || moth == 12)
                {
                    moco = 31;
                }
                if (moth == 4 || moth == 6 || moth == 9 || moth == 11)
                {
                    moco = 30;
                }
                if (sum > moco)
                {
                    sum = 1;
                    moth++;

                    if (moth > 12)
                    {
                        moth = 1;
                        y++;
                    }
                    mo = moth.ToString();
                }
                int fan = BLL.isLogin.calender(y.ToString(),moth.ToString(),sum.ToString(),we,(i+1));
                if(fan==1)
                {
                    Label5.Visible = true;
                    Label5.Text = "成功";
                }
            }
        }
    }
    
}