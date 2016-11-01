<%@ Page Title="" Language="C#" MasterPageFile="~/管理员/sdbi_MasterPage.master" AutoEventWireup="true" CodeFile="AddUser.aspx.cs" Inherits="管理员_AddUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <style type="text/css">
  
         #div1 {
         margin:0 auto;
             height:300px;
            width: 462px;
            padding-top:30px;
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
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server"><div style="height:28px; margin-left:30px; margin-top:10px;">
        <a href="Default.aspx" style="text-decoration:none; color:cyan;">首页</a>><a href="alterPwd.aspx" style="text-decoration:none;color:cyan;">新增用户</a>
    </div>
    <div id="div1">教师类型：<asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="188px">
        <asp:ListItem Value="外聘教师"></asp:ListItem>
        <asp:ListItem Selected="True" Value="本校教师"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        所属部门：<asp:DropDownList ID="DropDownList2" runat="server" Height="16px" Width="187px">
            <asp:ListItem Value="安全保卫处"></asp:ListItem>
            <asp:ListItem Value="办公室"></asp:ListItem>
            <asp:ListItem Value="教务处"></asp:ListItem>
            <asp:ListItem Value="基础部"></asp:ListItem>
            <asp:ListItem Value="机电工程系"></asp:ListItem>
            <asp:ListItem Value="经济管理系"></asp:ListItem>
            <asp:ListItem Value="建筑工程系"></asp:ListItem>
            <asp:ListItem Value="会计系"></asp:ListItem>
            <asp:ListItem Value="食品工程系"></asp:ListItem>
            <asp:ListItem Value="商务外语系"></asp:ListItem>
            <asp:ListItem Value="信息艺术系"></asp:ListItem>
            <asp:ListItem Value="学生公寓管理中心"></asp:ListItem>
            <asp:ListItem Value="总务处"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        教师工号：<asp:TextBox ID="TextBox1" runat="server" Height="16px" Width="183px"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        教师姓名：<asp:TextBox ID="TextBox2" runat="server" Height="16px" Width="183px"></asp:TextBox>
        <br />
        <br />
        密&nbsp;&nbsp; 码:<input id="Password1" type="password" runat="server" /><br />
        <br />
        确认密码：<input id="Password2" type="password" runat="server" /><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />性&nbsp;&nbsp;别：<asp:DropDownList ID="DropDownList4" runat="server" Height="16px" Width="188px">
        <asp:ListItem Value="男"></asp:ListItem>
        <asp:ListItem Selected="True" Value="女"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        权&nbsp;&nbsp; 限:<asp:DropDownList ID="DropDownList3" runat="server" Height="19px" Width="190px">
            <asp:ListItem Value="1"></asp:ListItem>
            <asp:ListItem Value="2"></asp:ListItem>
            <asp:ListItem Value="3"></asp:ListItem>
            <asp:ListItem Selected="True" Value="4"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <div style="height: 60px">&nbsp;<asp:Button ID="Button2" runat="server" Height="27px" Text="确定" Width="112px" OnClick="Button2_Click" />
&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Height="27px" Text="重置" Width="112px" OnClick="Button3_Click" />
&nbsp;&nbsp;&nbsp; </div>
    </div>
</asp:Content>

