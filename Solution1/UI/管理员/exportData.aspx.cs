using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class 管理员_exportData : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label4.Visible = false;
        Label5.Visible = false;
        Label6.Visible = false;
        Label7.Visible = false;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //学生缺勤
        System.Data.DataTable dt = BLL.ExportDate.stukaoqin();
        if (dt.Rows.Count > 0)
        {
            try
            {
                string Filename = System.DateTime.Now.ToString("yyyyMMddhhmmssffff")+"学生缺勤";
                ex(dt, Filename);
                Response.Redirect("../导出数据/"+Filename+".xlsx");
                Label4.Visible = true;
                Label4.Text = "成功！";
            }
            catch
            {
                Label4.Visible = true;
                Label4.Text = "失败!";
            }
        }
        else
        {
            Label4.Visible = true;
            Label4.Text = "无数据！";
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //教师漏报
        System.Data.DataTable dt = BLL.ExportDate.tealoubao();
        if (dt.Rows.Count > 0)
        {
            try
            {
                string Filename = System.DateTime.Now.ToString("yyyyMMddhhmmssffff")+"教师漏报";
                ex(dt,Filename);
                Response.Redirect("../导出数据/" + Filename + ".xlsx");
                Label5.Visible = true;
                Label5.Text = "成功！";
            }
            catch
            {
                Label5.Visible = true;
                Label5.Text = "失败!";
            }
        }
        else
        {
            Label5.Visible = true;
            Label5.Text = "无数据！";
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        //教师作业
        System.Data.DataTable dt = BLL.ExportDate.teazuoye();
        if (dt.Rows.Count > 0)
        {
            try
            {
                string Filename = System.DateTime.Now.ToString("yyyyMMddhhmmssffff")+"教师作业";
                ex(dt, Filename);
                Response.Redirect("../导出数据/" + Filename + ".xlsx");
                Label6.Visible = true;
                Label6.Text = "成功！";
            }
            catch
            {
                Label6.Visible = true;
                Label6.Text = "失败!";
            }
        }
        else
        {
            Label6.Visible = true;
            Label6.Text = "无数据！";
        }
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        //学生作业
        System.Data.DataTable dt = BLL.ExportDate.stuzuoye();
        if (dt.Rows.Count > 0)
        {
            try
            {
                string Filename = System.DateTime.Now.ToString("yyyyMMddhhmmssffff")+"学生作业";
                ex(dt, Filename);
                Response.Redirect("../导出数据/" + Filename + ".xlsx");
                Label7.Visible = true;
                Label7.Text = "成功！";
            }
            catch
            {
                Label7.Visible = true;
                Label7.Text = "失败!";
            }
        }
        else
        {
            Label7.Visible = true;
            Label7.Text = "无数据！";
        }
    }

    private void ex(System.Data.DataTable dt,string name)
    {
        object miss = Missing.Value;
        Application excelApp = new Application();
        excelApp.Workbooks.Add(miss);
        //导入数据
        Worksheet workSheet = (Worksheet)excelApp.Worksheets[1];
        object[,] dataArray = new object[dt.Rows.Count+1, dt.Columns.Count];
        Random rand = new Random(DateTime.Now.Millisecond);
        for (int i = 0; i <= dt.Rows.Count; i++)
        {
            for (int j = 0; j < dt.Columns.Count; j++)
            {
                if (i == 0)
                {
                    dataArray[i, j] = dt.Columns[j].ColumnName;
                }
                else
                {
                    if (j == 1)
                    {
                        dataArray[i, j] = "[" + dt.Rows[(i-1)][j].ToString() + "]";
                    }
                    else
                    {
                        dataArray[i, j] = dt.Rows[(i-1)][j].ToString();
                    }
                }
            }
        }
        workSheet.get_Range(workSheet.Cells[1, 1], workSheet.Cells[dt.Rows.Count, dt.Columns.Count]).Value2 = dataArray;
        workSheet = null;
        //保存
        Workbook workBook = excelApp.Workbooks[1];
        workBook.RefreshAll();
        workBook.SaveAs(Server.MapPath("../ ") + "导出数据/"+name, miss, miss, miss, miss, miss, XlSaveAsAccessMode.xlNoChange, miss, miss, miss, miss, miss);
        workBook.Close(false, miss, miss);
        workBook = null;
        excelApp.Quit();
        excelApp = null;
        GC.Collect();
    }
}