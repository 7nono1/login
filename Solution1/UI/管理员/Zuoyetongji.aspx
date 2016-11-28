<%@ Page Title="" Language="C#" MasterPageFile="~/管理员/sdbi_MasterPage.master" AutoEventWireup="true" CodeFile="Zuoyetongji.aspx.cs" Inherits="管理员_Zuoyetongji" %>

<%@ Register assembly="dotnetCHARTING" namespace="dotnetCHARTING" tagprefix="dotnetCHARTING" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .top1{
        text-align:center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="top1" >
         <asp:Label ID="Label2" runat="server" Text="查询范围:"></asp:Label>
         <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" AutoPostBack="true" style="margin-left: 0px" Width="173px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
             <asp:ListItem>所有数据</asp:ListItem>
             <asp:ListItem>系部查询</asp:ListItem>
             <asp:ListItem>学号查询</asp:ListItem>
             <asp:ListItem>姓名查询</asp:ListItem>
         </asp:DropDownList>
         <asp:TextBox ID="TextBox1" runat="server" Visible="False"></asp:TextBox>
         <asp:Button ID="Button1" runat="server" Height="16px" Text="查询" Width="89px" OnClick="Button1_Click" />
         <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
         <asp:GridView ID="GridView1" runat="server" CellPadding="2"  ForeColor="Black" AutoGenerateColumns="False" GridLines="None" Height="535px" Width="519px" AllowPaging="True" HorizontalAlign="Center" OnPageIndexChanging="GridView1_PageIndexChanging" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" ShowFooter="True" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderStyle="Double" BorderWidth="1px" Font-Overline="False" Font-Size="Large" Font-Bold="False" Font-Italic="False" style="margin-left: 61px" OnRowCommand="GridView1_RowCommand" OnRowDataBound="GridView1_RowDataBound" OnRowDeleting="GridView1_RowDeleting" >
        <AlternatingRowStyle BackColor="PaleGoldenrod" VerticalAlign="Middle" />
        <Columns>
            <asp:BoundField DataField="系部" HeaderText="系部" />
            <asp:BoundField DataField="学号" HeaderText="学号" />
            <asp:BoundField DataField="姓名" HeaderText="姓名" />
            <asp:BoundField DataField="未完成作业次数" HeaderText="未完成作业次数" />
            <asp:ButtonField ButtonType="Button" CommandName="详细" HeaderText="详细" Text="按钮" />
        </Columns>
        <FooterStyle BackColor="Tan" />
        <HeaderStyle BackColor="Tan" Font-Bold="True" />
        <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
        <SortedAscendingCellStyle BackColor="#FAFAE7" />
        <SortedAscendingHeaderStyle BackColor="#DAC09E" />
        <SortedDescendingCellStyle BackColor="#E1DB9C" />
        <SortedDescendingHeaderStyle BackColor="#C2A47B" />
    </asp:GridView></div>
    </asp:Content>


