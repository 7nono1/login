<%@ Page Title="" Language="C#" MasterPageFile="~/辅导员/sdbi_MasterPage.master" AutoEventWireup="true" CodeFile="importData.aspx.cs" Inherits="管理员_importData" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:FileUpload ID="FileUpload1" runat="server" Height="37px" Width="320px" />
    <asp:Button ID="Button1" runat="server" Height="39px" OnClick="Button1_Click" Text="导入" Width="80px" />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</asp:Content>

