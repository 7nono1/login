<%@ Page Title="" Language="C#" MasterPageFile="~/管理员/sdbi_MasterPage.master" AutoEventWireup="true" CodeFile="sendNew.aspx.cs" Inherits="管理员_sendNew" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .check {
            margin-left:150px;
            width:656px;
            height:446px;
            background-color:#2b2b36;
            border-radius:15px;
        }
        .boxleft {
        margin-left:100px;
        }
         .cheleft {
        }
        .textarea {
            width: 572px;
            height: 387px;
            margin-left:45px;
        }
        .btn1 {
            background-color:#00FF99;
        border-bottom-left-radius:10px;
        font-size:20px;
        color:white;
        }
            .btn1:hover {
            background-color:#ff2775;
            }
        .btn2 {
        border-bottom-right-radius:10px;
        background-color:#00FF99;
        font-size:20px;
        color:white;
        }
            .btn2:hover {
            background-color:#ff2775;
            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="height:28px; margin-left:30px; margin-top:10px;">
        <a href="message.aspx" style="text-decoration:none; color:cyan;">首页</a>><a href="sendNew.aspx" style="text-decoration:none;color:cyan;">发布通知</a>
    </div>
    <div style="height: 514px">
        <div class="check">
            <div class="cheleft">
                <br />
                <br />
    <label><asp:CheckBox ID="CheckBox1" runat="server" CssClass="boxleft" Text="院系领导" ForeColor="#CCCCFF" /></label>
    <label><asp:CheckBox ID="CheckBox2" runat="server" CssClass="boxleft" Text="各系辅导员" ForeColor="#CCCCFF" /></label>
    <label><asp:CheckBox ID="CheckBox3" runat="server" CssClass="boxleft" Text="教师" ForeColor="#CCCCFF" /></label>
                </div>
            <div class="textarea">
                <br />
                <textarea runat="server" id="textarea" style="width: 559px; height: 292px"></textarea>
                <br />
                <asp:Button ID="Button1" runat="server" Text="重置" Height="41px" Width="282px" BorderStyle="None" CssClass="btn1" OnClick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" Text="发送" Height="41px" Width="279px" BorderStyle="None" CssClass="btn2" OnClick="Button2_Click" />
                <br />
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </div>
        </div>
</asp:Content>

