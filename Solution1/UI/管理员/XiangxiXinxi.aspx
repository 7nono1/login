<%@ Page Title="" Language="C#" MasterPageFile="~/管理员/sdbi_MasterPage.master" AutoEventWireup="true" CodeFile="XiangxiXinxi.aspx.cs" Inherits="Xiangxi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" Height="506px" style="margin-left: 88px" Width="582px" OnPageIndexChanged="GridView1_PageIndexChanged" OnPageIndexChanging="GridView1_PageIndexChanging" >
             <AlternatingRowStyle BackColor="PaleGoldenrod" />
             <Columns>
                 <asp:BoundField />
                 <asp:BoundField DataField="系部" HeaderText="承担单位" />
                 <asp:BoundField DataField="学号" HeaderText="工号" />
                 <asp:BoundField DataField="姓名" HeaderText="教师姓名" />
                 <asp:BoundField DataField="周次" HeaderText="周次" />
                 <asp:BoundField DataField="星期" HeaderText="星期" />
                 <asp:BoundField HeaderText="节次" DataField="节次" />
             </Columns>
             <FooterStyle BackColor="Tan" />
             <HeaderStyle BackColor="Tan" Font-Bold="True" />
             <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
             <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
             <SortedAscendingCellStyle BackColor="#FAFAE7" />
             <SortedAscendingHeaderStyle BackColor="#DAC09E" />
             <SortedDescendingCellStyle BackColor="#E1DB9C" />
             <SortedDescendingHeaderStyle BackColor="#C2A47B" />
         </asp:GridView>
      <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
</asp:Content>

