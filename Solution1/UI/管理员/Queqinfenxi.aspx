﻿<%@ Page Title="" Language="C#" MasterPageFile="~/管理员/sdbi_MasterPage.master" AutoEventWireup="true" CodeFile="Queqinfenxi.aspx.cs" Inherits="管理员_Queqinfenxi" %>

<%@ Register assembly="dotnetCHARTING" namespace="dotnetCHARTING" tagprefix="dotnetCHARTING" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <dotnetCHARTING:Chart ID="Chart1" runat="server">
    </dotnetCHARTING:Chart>
    <asp:DropDownList ID="DropDownList1" runat="server"  AutoPostBack="True" OnTextChanged="DropDownList1_TextChanged" >
    </asp:DropDownList>
</asp:Content>

