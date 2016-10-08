using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Drawing.Imaging;


public partial class 页面_Coder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Random rd = new Random();
        string strCode = "";
        for (int i = 0; i < 4; i++)
        {
            strCode += rd.Next(10).ToString();

        }
        Session["Code"] = strCode;
        Bitmap bmp = new Bitmap(80,20);
        Graphics g = Graphics.FromImage(bmp);
        Font fnt = new Font("Times New Roman",10,FontStyle.Bold);
        g.DrawString(strCode,fnt,Brushes.AliceBlue,0,0);
        bmp.Save(Response.OutputStream,ImageFormat.Gif);
    }
}