﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #main {
        }
        body {
        background-image:url(/images/1235.jpg);
        }
        #login {
        margin-top:250px;
        margin-left:600px;
        }
        #lo {
        margin-left:50px;
        }
        #cc {
        margin-top:280px;
        margin-left:50px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
     <div id="main">
     <div id="login">
         <div id="user">
        <asp:Label ID="Label1" runat="server" Text="账号"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
             </div>
         <div id="pass">
        <br /><asp:Label ID="Label2" runat="server" Text="密码"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
             </div>
         <div id="lo">
        <br /><asp:Button ID="Button1" runat="server" Text="登陆" OnClick="Button1_Click" Width="81px" />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
             <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
             </div>
         <div id="cc">
            <p>制作人：李国富 LED:17853522782</p>
         </div>
         </div>
        </div>
    </form>
</body>
</html>
