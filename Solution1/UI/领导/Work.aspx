<%@ Page Title="" Language="C#" MasterPageFile="~/领导/sdbi_MasterPage.master" AutoEventWireup="true" CodeFile="Work.aspx.cs" Inherits="领导_Work" %>

<%@ Register assembly="dotnetCHARTING" namespace="dotnetCHARTING" tagprefix="dotnetCHARTING" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" CellPadding="3" AutoGenerateColumns="False" Height="200px" Width="800px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <Columns>
            <asp:BoundField HeaderText="系部" DataField="系部" />
            <asp:BoundField HeaderText="作业总次数" DataField="作业总次数" />
            <asp:BoundField DataField="未完成作业次数" HeaderText="未完成作业次数" />
            <asp:BoundField HeaderText="未完成作业率" DataField="未完成作业率" />
        </Columns>
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FFF1D4" />
        <SortedAscendingHeaderStyle BackColor="#B95C30" />
        <SortedDescendingCellStyle BackColor="#F1E5CE" />
        <SortedDescendingHeaderStyle BackColor="#93451F" />
    </asp:GridView>
    <div>
        <dotnetCHARTING:Chart ID="Chart1" runat="server">
        </dotnetCHARTING:Chart>
    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
    <asp:DropDownList ID="DropDownList2" runat="server"  AutoPostBack="True" OnTextChanged="DropDownList1_TextChanged">
    </asp:DropDownList>
    <asp:DropDownList ID="DropDownList1" runat="server"  AutoPostBack="True" OnTextChanged="DropDownList1_TextChanged"  >
    </asp:DropDownList>
</asp:Content>

