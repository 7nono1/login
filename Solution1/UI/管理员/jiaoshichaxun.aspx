<%@ Page Title="" Language="C#" MasterPageFile="~/管理员/sdbi_MasterPage.master" AutoEventWireup="true" CodeFile="jiaoshichaxun.aspx.cs" Inherits="管理员_jiaoshichaxun" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="top1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;查询范围
    <asp:DropDownList ID="DropDownList1"
        runat="server" AutoPostBack="True" Font-Size="12pt" Width="135px" 
        onselectedindexchanged="DropDownList1_SelectedIndexChanged">
        <asp:ListItem>所有记录</asp:ListItem>
        <asp:ListItem>按部门查询</asp:ListItem>
        <asp:ListItem>按教师工号查询</asp:ListItem>
        <asp:ListItem>按权限查询</asp:ListItem>
         <asp:ListItem>按教师姓名查询</asp:ListItem>
    </asp:DropDownList>
        <asp:Label ID="Label2" runat="server" Text="查询条件"></asp:Label><asp:TextBox ID="TextBox1"
            runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="查询" onclick="Button1_Click" Height="21px" Width="73px" /></div>
    <div class="top2"  ><asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
        AllowSorting="True" AutoGenerateColumns="False" CellPadding="3" PageSize="16" 
        onselectedindexchanged="GridView1_SelectedIndexChanged" 
        onpageindexchanging="GridView1_PageIndexChanging" 
        onrowcancelingedit="GridView1_RowCancelingEdit" 
        onrowdeleting="GridView1_RowDeleting" onrowediting="GridView1_RowEditing" 
        onrowupdating="GridView1_RowUpdating" 
           BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellSpacing="2">
        <Columns>
            <asp:BoundField DataField="部门" HeaderText="所属部门" ReadOnly="True" >
            <ControlStyle Width="100px" />
            <ItemStyle Width="100px" HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:BoundField>
            <asp:BoundField DataField="工号" HeaderText="教师工号" ReadOnly="True">
            <ControlStyle Width="100px" />
            <ItemStyle Width="100px" HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:BoundField>
            <asp:BoundField DataField="姓名" HeaderText="教师姓名" ReadOnly="True">
            <ControlStyle Width="100px" />
            <ItemStyle Width="100px" HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:BoundField>
            <asp:BoundField DataField="权限" HeaderText="教师权限"  ControlStyle-Width="50px" ItemStyle-Width="50px">
            <ControlStyle Width="100px" />
            <ItemStyle Width="100px" HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:BoundField>
            <asp:CommandField HeaderText="编辑" ShowEditButton="True">
            <ControlStyle Width="100px" />
            <ItemStyle Width="70px" HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:CommandField>
            <asp:CommandField HeaderText="删除" ShowDeleteButton="True">
            <ControlStyle Width="100px" />
            <ItemStyle Width="70px" HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:CommandField>
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
        <br />
    </div>


</asp:Content>

