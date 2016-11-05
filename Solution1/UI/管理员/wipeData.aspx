<%@ Page Title="" Language="C#" MasterPageFile="~/管理员/sdbi_MasterPage.master" AutoEventWireup="true" CodeFile="wipeData.aspx.cs" Inherits="管理员_wipeData" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .main {
            height:393px;
            width: 568px;
            margin-left:180px;
            margin-top:50px;
            background-color:#ff2775;
            border-radius:15px;
        }
        .wipebtn {
            border-top-left-radius:15px;
            border-top-right-radius:15px;
            background-color:#00FF99;
            font-size:36px;
            color:white;
        }
            .wipebtn:hover {
                background-color:#ff2775;
            }
        .left {
            width: 481px;
            height: 247px;
            margin-left:50px;
        }
        .right {
            height: 85px;
            width: 568px;
        }
         .wipe1btn {
             border-bottom-left-radius:15px;
             border-bottom-right-radius:15px;
            background-color:#00FF99;
            font-size:36px;
            color:white;
        }
            .wipe1btn:hover {
                background-color:#ff2775;
            }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
     <div style="height:28px; margin-left:30px; margin-top:10px;">
        <a href="message.aspx" style="text-decoration:none; color:cyan;">首页</a>><a href="wipeData.aspx" style="text-decoration:none;color:cyan;">清空数据</a>
    </div>
    <div class="main">

        <asp:Button ID="Button1" runat="server" Height="64px" Text="清空所有数据" Width="569px" CssClass="wipebtn" OnClick="Button1_Click" />
        <div class="left">
        <br />
        <br />
        <asp:CheckBox ID="CheckBox1" runat="server" Text="教务处" OnCheckedChanged="CheckBox1_CheckedChanged" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="CheckBox2" runat="server" Text="会计系" OnCheckedChanged="CheckBox2_CheckedChanged" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="CheckBox9" runat="server" Text="机械工程系" OnCheckedChanged="CheckBox9_CheckedChanged" />
            <br />
        <br />
        <br />
        <asp:CheckBox ID="CheckBox3" runat="server" Text="校历" OnCheckedChanged="CheckBox3_CheckedChanged" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="CheckBox4" runat="server" Text="基础教学部" OnCheckedChanged="CheckBox4_CheckedChanged" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="CheckBox10" runat="server" Text="商务外语系" OnCheckedChanged="CheckBox10_CheckedChanged" />
            <br />
        <br />
        <br />
        <asp:CheckBox ID="CheckBox5" runat="server" Text="信息艺术系" OnCheckedChanged="CheckBox5_CheckedChanged" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="CheckBox6" runat="server" Text="经济管理系" OnCheckedChanged="CheckBox6_CheckedChanged" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="CheckBox7" runat="server" Text="食品工程系" OnCheckedChanged="CheckBox7_CheckedChanged" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:CheckBox ID="CheckBox8" runat="server" Text="建筑工程系" OnCheckedChanged="CheckBox8_CheckedChanged" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="CheckBox11" runat="server" OnCheckedChanged="CheckBox11_CheckedChanged" Text="教师" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="CheckBox12" runat="server" OnCheckedChanged="CheckBox12_CheckedChanged" Text="外聘教师" />
            </div>
        <div class="right">

            <asp:Button ID="Button2" runat="server" Height="87px" Text="清空选中数据" Width="569px" CssClass="wipe1btn" OnClick="Button2_Click" />

        </div>

    </div>
</asp:Content>

