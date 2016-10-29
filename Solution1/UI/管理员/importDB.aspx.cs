﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class 管理员_importDB : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    string cur = string.Empty;
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (FileUpload1.FileName != "")
        {
            string tempPath = Path.GetTempPath();
            HttpPostedFile ff = this.FileUpload1.PostedFile;
            string Filename = ff.FileName;
            string path = Server.MapPath("../") + "testDB\\";
            //Filename = Path.GetFileName( FileUpload1.PostedFile.FileName);
            string[] date = System.DateTime.Now.ToShortDateString().Split('/');
            string Newdate = "";
            for (int i = 0; i < date.Length; i++)
            {
                Newdate = Newdate + date[i] + "-";
            }
            string[] time = System.DateTime.Now.ToLongTimeString().Split(':');
            string Newtime = "";
            for (int i = 0; i < time.Length; i++)
            {
                Newtime = Newtime + time[i] + "-";
            }
            Filename = Newdate + Newtime + Filename;
            this.cur = path + Filename;
            ff.SaveAs(this.cur);
            int li = BLL.isLogin.excle(cur);
            if (li == 1)
            {
                Label1.Text = "成功";
            }
        }
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }
}