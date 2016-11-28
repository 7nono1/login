<%@ Page Title="" Language="C#" MasterPageFile="~/管理员/sdbi_MasterPage.master" AutoEventWireup="true" CodeFile="Loubaofenxi.aspx.cs" Inherits="管理员_Queqinfenxi" %>

<%@ Register assembly="dotnetCHARTING" namespace="dotnetCHARTING" tagprefix="dotnetCHARTING" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   <style type="text/css">
       .top1{
       text-align:center;
       }
   </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label2" runat="server" Text="查询条件"></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" OnTextChanged="DropDownList1_TextChanged" style="margin-left: 12px" Width="185px" AutoPostBack="true">
        <asp:ListItem>所有数据</asp:ListItem>
        <asp:ListItem>系部查询</asp:ListItem>
        <asp:ListItem>工号查询</asp:ListItem>
        <asp:ListItem>姓名查询</asp:ListItem>
    </asp:DropDownList>
    <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 1px" Width="153px" Visible="False"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="查询" Width="82px" />
    <div class="top1">
    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" AutoGenerateColumns="False" GridLines="None" Height="500px" Width="558px" AllowPaging="True" HorizontalAlign="Center" OnPageIndexChanging="GridView1_PageIndexChanging" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" ShowFooter="True" style="margin-left: 66px; margin-right: 33px;">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="承担单位" HeaderText="系部" />
            <asp:BoundField DataField="工号" HeaderText="教师工号" />
            <asp:BoundField DataField="教师姓名" HeaderText="教师姓名" />
            <asp:BoundField DataField="未考勤次数" HeaderText="未考勤次数" />
            <asp:ButtonField Text="详细" ButtonType="Button" />
        </Columns>
        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <SortedAscendingCellStyle BackColor="#FDF5AC" />
        <SortedAscendingHeaderStyle BackColor="#4D0000" />
        <SortedDescendingCellStyle BackColor="#FCF6C0" />
        <SortedDescendingHeaderStyle BackColor="#820000" />
    </asp:GridView></div>
    </asp:Content>

