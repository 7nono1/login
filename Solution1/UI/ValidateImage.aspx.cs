using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Drawing.Imaging;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string[] codes = { "红烧茄子","酱醋排骨","宫爆鸡丁","糖醋鲤鱼","葛二蛋子"};
        Color[] color = {Color.Black,Color.Red,Color.Blue,Color.Brown,Color.DarkBlue };
        string[] font = {"宋体","楷体","幼圆"};
        Random ra = new Random();
        string shkCode = codes[ra.Next(codes.Length)];
        Session["ValiDateCode"] = shkCode;
        Bitmap mp = new Bitmap(80,17);
        Graphics g = Graphics.FromImage(mp);
        g.Clear(Color.WhiteSmoke);
        int length = shkCode.Length;
        for (int i = 0; i < length; i++)
        {
            string fnt = font[ra.Next(font.Length)];
            Font ft = new Font(fnt, 12);
            Color cr = color[ra.Next(color.Length)];
            g.DrawString(shkCode[i].ToString(),ft,new SolidBrush(cr),(float)i*20,(float)1);

        }
        mp.Save(Response.OutputStream,ImageFormat.Gif);
    }
}