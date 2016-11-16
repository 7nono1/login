<%@ Page Title="" Language="C#" MasterPageFile="~/领导/sdbi_MasterPage.master" AutoEventWireup="true" CodeFile="FTRform.aspx.cs" Inherits="领导_FTRform" %>

<%@ Register assembly="dotnetCHARTING" namespace="dotnetCHARTING" tagprefix="dotnetCHARTING" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <dotnetCHARTING:Chart ID="Chart1" runat="server" Height="355px" Width="375px">
    </dotnetCHARTING:Chart>
    <asp:DropDownList ID="DropDownList2" runat="server"  AutoPostBack="True" OnTextChanged="DropDownList1_TextChanged">
    </asp:DropDownList>
    <asp:DropDownList ID="DropDownList1" runat="server"  AutoPostBack="True" OnTextChanged="DropDownList1_TextChanged"  >
    </asp:DropDownList>
    </asp:Content>

