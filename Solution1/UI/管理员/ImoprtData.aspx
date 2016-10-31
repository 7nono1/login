<%@ Page Title="" Language="C#" MasterPageFile="~/管理员/sdbi_MasterPage.master" AutoEventWireup="true" CodeFile="ImoprtData.aspx.cs" Inherits="管理员_ImoprtData" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <style type="text/css">
       #div1 {
           
           height:20px;
       }
       #div2 {
          
       }
       #Select1 {
            height: 13px;
            width: 148px;
       }
        #center {
          width:942px;
            float:left;
           margin-left: 18px;
           padding-top:50px;
       }
    </style>
     <div id="center">
  
      <div id="div2">
          选择数据类型：&nbsp;&nbsp;&nbsp; <select id="Select1" name="D1">
              <option></option>
          </select><br />
          <br />
          <br />
       </div>
      <div>
       请选择要导入的文件：<asp:FileUpload ID="FileUpload1" runat="server" />

                &nbsp;   <asp:Button ID="Button1" runat="server" Height="20px" Text="导入" Width="98px" OnClick="Button1_Click" />

       </div>
       &nbsp;&nbsp;        
         &nbsp;&nbsp;&nbsp;  
      &nbsp;&nbsp;&nbsp;&nbsp;  
     &nbsp;&nbsp;&nbsp;&nbsp; 
      &nbsp;&nbsp;&nbsp; 
     &nbsp;&nbsp;&nbsp;&nbsp;  
      &nbsp;&nbsp;  
      <div id="div3">
     <asp:Button ID="Button5" runat="server" Text="分析导入数据" Height="23px" Width="134px" OnClick="Button5_Click" />
          <br />
         <br />
<asp:Button ID="Button6" runat="server" Text="处理入库数据" Height="23px" Width="134px" OnClick="Button6_Click" />
          <br />
           <br />
<asp:Button ID="Button7" runat="server" Text="清空入库数据" OnClick="Button7_Click" Height="23px" Width="134px" />
          <br />
<asp:Button ID="Button8" runat="server" Text="更新课程数据" OnClick="Button7_Click" Height="23px" Width="134px" />
          <br />
      </div>
  </div>
</asp:Content>

