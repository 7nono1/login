<%@ Page Title="" Language="C#" MasterPageFile="~/管理员/sdbi_MasterPage.master" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="辅导员_ChangePassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
  
        #div1 {
         margin:0 auto;
             height:200px;
            width: 341px;
        }
   
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="div1">教室工号：&nbsp; <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" Text="查询" Height="24px" Width="70px" />
        <br />
        即将对<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        修改密码！<br />
        新密码：&nbsp;&nbsp; 
        <input id="Password1" type="password" />&nbsp;
        <br />
        <br />
        确认密码：&nbsp; 
        <input id="Password2" type="password" />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="确定" Height="24px" Width="70px" />
    </div>
</asp:Content>

