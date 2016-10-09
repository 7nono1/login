<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #main {
        }
        body {
        /*background-image:url(/images/1235.jpg);*/
        background-color:#333;
        }
        #login {
        margin-top:220px;
        margin-left:600px;
            width: 325px;
            height: 262px;

            background-image:url('/images/log.jpg');
        }
        #log {
        margin-left:45px;
        margin-top:40px;
        }
        #lo {
        margin-left:60px;
        }
        #cc {
        margin-top:530px;
        margin-left:600px;
        }
        p {
        font-size:12px;
        }
        #TextBox2 {
            width: 171px;
            height: 25px;
        }
        #log {
            width: 235px;
        }
        #logini {
        width:325px;
        height:40px;
        background-color:aqua;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
     <div id="main">
     <div id="login">
         <div id="logini">
             
          </div>
         <div id="log">
         <div id="user">
        <asp:Label ID="Label1" runat="server" Text="用户名"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Height="22px" Width="171px"></asp:TextBox>
             </div>
         <div id="pass">
        <br /><asp:Label ID="Label2" runat="server" Text="  密码" Width="48px"></asp:Label>
             <input type="password" id="TextBox2" runat="server" />
             </div>
             <br /><div id="vali">
                 <asp:Label ID="Label4" runat="server" Text="验证码"></asp:Label>
                 <asp:TextBox ID="TextBox3" runat="server" Width="71px"></asp:TextBox>
             <img src="/../ValidateImage.aspx" alt="验证字符" style="width:80px; height:17px" onclick="this.src=this.src+'?'" />
             </div>
         <div id="lo">
        <br /><asp:Button ID="Button1" runat="server" Text="登陆" OnClick="Button1_Click" Width="120px" Height="29px" />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
             </div>
         </div>
         </div>
         <div id="cc">
            <p>制作人：李国富、葛海程、姚明、韩尚水  LED:17853522782</p>
         </div>
        </div>
    </form>
</body>
</html>
