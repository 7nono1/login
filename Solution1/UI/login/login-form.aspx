<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login-form.aspx.cs" Inherits="login_login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>山东商务职业学院学生考勤管理系统</title>
    <style type="text/css">
body{
	background-image:url(images/bg11.jpg);
	background-repeat:no-repeat;
	margin:0 auto;
	font-family: 'Open Sans', sans-serif;}
h1{
	font-family: 'Exo 2', sans-serif;
	  text-align: center;
	  padding-top: 1em;
	  font-weight: 400;
	  color: #2B2B36;
	  font-size: 2em;}
#login-form{
	background: #2b2b36;
	text-align: center;
	width:350px;
	height:469px;
	margin-left:37%;
    margin-top:80px;
	border-radius: 15px;}
#login-head{
	width:350px;
	height:110px;}
#header{
	margin-top:30px;}
.userName{
	width:70%;
	padding: 1em 2em 1em 3em;
	color: #9199aa;
	font-size: 18px;
	outline: none;
	background:url(images/adm.png) no-repeat 10px 15px;
	border: none;
	font-weight: 100;
	border-bottom: 1px solid#484856;
	margin-top: 2em;
	  }
.login-pwd{
	width:70%;
	padding: 1em 2em 1em 3em;
	color: #dd3e3e;
	font-size: 18px;
	outline: none;
	background:url(images/key.png) no-repeat 10px 23px;
	border: none;
	font-weight: 100;
	border-bottom: 1px solid#484856;}
.ya{
	border-bottom: 1px solid#484856;
	}
.yanbox{
	        border-style: none;
            border-color: inherit;
            border-width: medium;
            width:57px;
	        color: #9199aa;
            border:none;
	        padding: 1em 2em 1em 1em;
	        outline: none;
	        background: no-repeat 10px 23px;
	        font-weight: 100;
	        font-size: 18px;
        }
#Button1{
	width:100%;
	height:100px;
	color:#FFF;
    outline: none;
    border: none;
	background: #3ea751;
	border-bottom-left-radius:15px;
	border-bottom-right-radius:15px;
	cursor: pointer;
	font-size: 30px;}
#Button1:hover{
	background: #ff2775;}
        .code {
            position:relative;
            top:10px;
        }
         #lab {
             width:100%;
             height:3em;
             line-height:3em;
        }

</style>
</head>
<body>
    <form id="form1" runat="server">
    <h1></h1>
<div id="login-form">
<div id="login-head">
<img src="images/avtar.png" id="header" />
</div>
<div>
<input type="text" id="userBox" runat="server" class="userName" value="用户名" onfocus="this.value='';" onblur="if(this.value==''){this.value='用户名';}" />
</div>
<div>
<input type="password" id="pwdBox" runat="server" class="login-pwd" value="密码" onfocus="
this.value='';" onblur="if(this.value==''){this.value='密码';}" />
</div>
<div class="ya">
<label style="line-height:2em; color:#666;">验证码</label>
<input type="text" id="codeBox" runat="server" autocomplete="off" class="yanbox"  />
<img src="../ValidateImage.aspx" class="code" style="cursor: pointer; left: 0px; width: 124px;" height="35" onclick="this.src=this.src+'?'" />
    <img src="images/pass.png" title="请在输入框输入算数结果" />
</div>
    <div id="lab">

        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

    </div>
<div>
    <asp:Button ID="Button1" runat="server" Text="登陆" OnClick="Button1_Click" />
</div>

</div>
    </form>
</body>
</html>
