<%@ Page Title="" Language="C#" MasterPageFile="~/管理员/sdbi_MasterPage.master" AutoEventWireup="true" CodeFile="hosmarg.aspx.cs" Inherits="管理员_hosmarg" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .main {
        }
        .listbox1 {
            margin-top:50px;
            margin-left:70px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div style="height:28px; margin-left:30px; margin-top:10px;">
        <a href="message.aspx" style="text-decoration:none; color:cyan;">首页</a>><a href="message.aspx" style="text-decoration:none;color:cyan;">消息管理</a>><a href="hosmarg.aspx" style="text-decoration:none;color:cyan;">历史记录</a>
    </div>
    <div class="main">
    <asp:ListBox ID="ListBox1" CssClass="listbox1" runat="server" Height="502px" Width="768px"></asp:ListBox>
        </div>
</asp:Content>

