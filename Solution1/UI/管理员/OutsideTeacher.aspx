<%@ Page Title="" Language="C#" MasterPageFile="~/管理员/sdbi_MasterPage.master" AutoEventWireup="true" CodeFile="OutsideTeacher.aspx.cs" Inherits="管理员_OutsideTeacher" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
       <style type="text/css">
        #Select1 {
            height: 43px;
            width: 105px;
        }
        #div1 {
         margin:0 auto;
             height: 550px;
            width: 700px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       
    <div id="div1">
        查询范围：<select id="Select1" name="D1">
            <option></option>
        </select>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="查询" Height="24px" Width="80px" />
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" Height="466px" Width="696px">
        </asp:GridView>
</div>

</asp:Content>

