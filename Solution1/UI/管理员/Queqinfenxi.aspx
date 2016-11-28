<%@ Page Title="" Language="C#" MasterPageFile="~/管理员/sdbi_MasterPage.master" AutoEventWireup="true" CodeFile="Queqinfenxi.aspx.cs" Inherits="管理员_Queqinfenxi" %>

<%@ Register assembly="dotnetCHARTING" namespace="dotnetCHARTING" tagprefix="dotnetCHARTING" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Button ID="Button1" runat="server" Font-Size="XX-Large" ForeColor="Black" Height="101px" OnClick="Button1_Click1" style="margin-left: 68px" Text="生成图表" Width="845px" />
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" CellPadding="3" AutoGenerateColumns="False" Height="100px" Width="1000px">
        <Columns>
            <asp:BoundField HeaderText="系部" DataField="系部" />
            <asp:BoundField HeaderText="在校人数" DataField="在校人次" />
            <asp:BoundField HeaderText="旷课人次" DataField="旷课人次" />
            <asp:BoundField HeaderText="旷课率" DataField="旷课率" />
            <asp:BoundField HeaderText="迟到率" DataField="迟到率" />
            <asp:BoundField HeaderText="早退人次" DataField="早退人次" />
            <asp:BoundField HeaderText="早退率" DataField="早退率" />
            <asp:BoundField HeaderText="请假人次" DataField="请假人次" />
            <asp:BoundField HeaderText="请假率" DataField="请假率" />
            <asp:BoundField HeaderText="总缺勤数" DataField="总缺勤人次" />
            <asp:BoundField HeaderText="总缺勤率" DataField="总缺勤率" />
            <asp:BoundField DataField="早退人次" HeaderText="早退人数" />
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
    <dotnetCHARTING:Chart ID="Chart1" runat="server" Height="355px" Width="375px">
    </dotnetCHARTING:Chart>
    <asp:DropDownList ID="DropDownList2" runat="server"  AutoPostBack="True" OnTextChanged="DropDownList1_TextChanged">
    </asp:DropDownList>
    <asp:DropDownList ID="DropDownList1" runat="server"  AutoPostBack="True" OnTextChanged="DropDownList1_TextChanged"  >
    </asp:DropDownList>
    </asp:Content>

