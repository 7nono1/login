<%@ Page Title="" Language="C#" MasterPageFile="~/领导/sdbi_MasterPage.master" AutoEventWireup="true" CodeFile="alterPwd.aspx.cs" Inherits="领导_alterPwd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <link href="css/pawd.css" type="text/css" rel="stylesheet" />
    <div style="height: 606px">
        <div style="height:372px; width:496px; margin-left:29%; margin-top:150px;">
            <div style="height:52px; width:444px; margin-left:50px;">

                <asp:Label ID="Label2" runat="server" Text="原密码：" ></asp:Label>
                <input type="text" id="userID" runat="server"  />


            


                <asp:Label ID="Label4" runat="server" ForeColor="Red" Text="Label"></asp:Label>


            


            </div>
            <div style="height:52px; width:444px; margin-left:50px;">
                 <asp:Label ID="Label3" runat="server" Text="新密码："></asp:Label>
                <input type="text" id="userPwd" runat="server" />
                 <asp:Label ID="Label5" runat="server" ForeColor="Red" Text="Label"></asp:Label>
            </div>
            <div style="height:72px; width:440px; margin-left:50px;">
                 <asp:Label ID="Label1" runat="server" Text="确认密码："></asp:Label>
                <input type="text" id="surePwd" runat="server" />
                 <asp:Label ID="Label6" runat="server" ForeColor="Red" Text="Label"></asp:Label>
            </div>
            <div style="height:59px; width:213px; margin-left:126px;">
                
                <asp:Button ID="Button1" runat="server" Height="53px"  Text="提交" Width="205px" OnClick="Button1_Click" />
                
            </div>
        </div>
       

    </div>
</asp:Content>

