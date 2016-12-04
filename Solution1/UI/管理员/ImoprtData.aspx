<%@ Page Title="" Language="C#" MasterPageFile="~/管理员/sdbi_MasterPage.master" AutoEventWireup="true" CodeFile="ImoprtData.aspx.cs" Inherits="管理员_ImoprtData" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="height:25px; margin-left:30px; margin-top:10px;">
        <a href="message.aspx" style="text-decoration:none; color:cyan;">首页</a>><a href="ImoprtData.aspx" style="text-decoration:none;color:cyan;">导入数据</a>
    </div>
     <div id="center">
  
         <div id="div2">
          选择数据类型：&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="138px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
              <asp:ListItem Value="全校教师"></asp:ListItem>
              <asp:ListItem Value="会计系"></asp:ListItem>
              <asp:ListItem Value="信息艺术系"></asp:ListItem>
              <asp:ListItem Value="商务外语系"></asp:ListItem>
              <asp:ListItem Value="食品工程系"></asp:ListItem>
              <asp:ListItem Value="建筑工程系"></asp:ListItem>
              <asp:ListItem Value="机械工程系"></asp:ListItem>
              <asp:ListItem Value="经济管理系"></asp:ListItem>
              <asp:ListItem Value="教务处"></asp:ListItem>
              <asp:ListItem Value="基础教学部"></asp:ListItem>
              <asp:ListItem Value="外聘教师"></asp:ListItem>
          </asp:DropDownList>
          <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
          <br />
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
          <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
          <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
          <br />
          <br />
          <br />
          <asp:Label ID="Label3" runat="server" Font-Size="24px" Text="导入校历："></asp:Label>
          <br />
          <asp:Label ID="Label4" runat="server" Text="本学期的起始日期："></asp:Label>
          年分：<asp:TextBox ID="TextBox1" runat="server" Width="97px"></asp:TextBox>
          月份：<asp:TextBox ID="TextBox2" runat="server" Width="64px"></asp:TextBox>
&nbsp;日：<asp:TextBox ID="TextBox3" runat="server" Width="41px"></asp:TextBox>
          <br />
          本学期共几周（只填数字）：<asp:TextBox ID="TextBox4" runat="server" Width="89px"></asp:TextBox>
         <br />
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="导入" Width="99px" />
          <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
          <br />
           <br />
          <br />
          <br />
          <br />
      </div>
  </div>
</asp:Content>

