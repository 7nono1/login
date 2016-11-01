<%@ Page Title="" Language="C#" MasterPageFile="~/管理员/sdbi_MasterPage.master" AutoEventWireup="true" CodeFile="sendNew.aspx.cs" Inherits="管理员_sendNew" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .check {
            margin-left:200px;
            margin-top:80px;
        
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="height: 514px">
        <div class="check">
    <asp:CheckBox ID="CheckBox1" runat="server" Text="院系领导" />
    <asp:CheckBox ID="CheckBox2" runat="server" Text="各系辅导员" />
    <asp:CheckBox ID="CheckBox3" runat="server" Text="教师" />
            </div>
        </div>
</asp:Content>

