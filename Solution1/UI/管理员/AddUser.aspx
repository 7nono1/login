<%@ Page Title="" Language="C#" MasterPageFile="~/管理员/sdbi_MasterPage.master" AutoEventWireup="true" CodeFile="AddUser.aspx.cs" Inherits="管理员_AddUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <style type="text/css">
  
        #div1 {
         margin:0 auto;
             height:300px;
            width: 300px;
        }
         #Select1 {
             height: 28px;
             width: 189px;
         }
         #Select2 {
             height: 25px;
             width: 190px;
         }
         #Password1 {
             height: 16px;
             width: 183px;
         }
         #Password2 {
             height: 16px;
             width: 183px;
         }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="div1">教师类型：<select id="Select1" name="D1">
        <option></option>
        </select><br />
        <br />
        所属部门：<select id="Select2" name="D2">
            <option></option>
        </select><br />
        <br />
        教师工号：<asp:TextBox ID="TextBox1" runat="server" Height="16px" Width="183px"></asp:TextBox>
        <br />
        <br />
        教师姓名：<asp:TextBox ID="TextBox2" runat="server" Height="16px" Width="183px"></asp:TextBox>
        <br />
        <br />
        密&nbsp;&nbsp; 码:<input id="Password1" type="password" /><br />
        <br />
        权&nbsp;&nbsp; 限:<asp:TextBox ID="TextBox3" runat="server" Height="16px" Width="183px"></asp:TextBox>
        <br />
        <br />
        <br />
        <div>&nbsp;<asp:Button ID="Button2" runat="server" Height="27px" Text="确定" Width="112px" />
&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Height="27px" Text="取消" Width="112px" />
&nbsp;&nbsp;&nbsp; </div>
    </div>
</asp:Content>

