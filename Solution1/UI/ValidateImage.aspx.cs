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
        string[] codes = { "3+5=","9+4=","10+1=","15+1=","2+8=","12+3=","18+2=","50+9=","5+7=","6+7"};
        string[] codese = { "8","13","11","16","10","15","20","59","12","13"};
        Color[] color = {Color.Black,Color.Red,Color.Blue,Color.Brown,Color.DarkBlue };
        string[] font = {"宋体","楷体","幼圆","Times New Roman"};
        Random ra = new Random();
        int co = ra.Next(codes.Length);
        string shkCode = codes[co];
        Session["ValiDateCode"] = codese[co];
        Bitmap mp = new Bitmap(124,35);
        Graphics g = Graphics.FromImage(mp);
        g.Clear(Color.WhiteSmoke);
        int length = shkCode.Length;
        for (int i = 0; i < length; i++)
        {
            string fnt = font[ra.Next(font.Length)];
            Font ft = new Font(fnt, 19);
            Color cr = color[ra.Next(color.Length)];
            g.DrawString(shkCode[i].ToString(),ft,new SolidBrush(cr),(float)i*20,(float)1);

        }
        mp.Save(Response.OutputStream,ImageFormat.Gif);
    }
}