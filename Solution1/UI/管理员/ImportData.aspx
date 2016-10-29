<%@ Page Title="" Language="C#" MasterPageFile="~/管理员/sdbi_MasterPage.master" AutoEventWireup="true" CodeFile="ImportData.aspx.cs" Inherits="管理员_ImportData" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        #div1 {
            background-color:#000000;
            height:20px;
        }
        #div2 {
            margin-left:155px;
        }
        #Select1 {
            height: 8px;
            width: 86px;
        }
        #center {
            width:942px;
            float:left;
            margin-left: 18px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <div id="center">
   
        <div id="div1"></div>
       <div id="div2">
            <asp:RadioButton ID="本校教师" runat="server" />
            <asp:RadioButton ID="外聘教师" runat="server" />
       </div>
       <div>
         请选择要导入的文件：<asp:FileUpload ID="FileUpload1" runat="server" />

                &nbsp;   <asp:Button ID="Button1" runat="server" Height="20px" Text="导入" Width="98px" />

       </div>
         <div id="div1"></div>
     <div id="div2">
           &nbsp;  <select id="Select1">
             <option>教务处</option>

         </select>
     </div>
       &nbsp;<div>
           请选择要导入的文件：<asp:FileUpload ID="FileUpload2" runat="server" />

                &nbsp;  <asp:Button ID="Button2" runat="server" Height="20px" Text="导入" Width="98px" />

       </div>
        <div id="div1"></div>
       <div>
           请选择要导入的文件：<asp:FileUpload ID="FileUpload3" runat="server" />

                &nbsp;  <asp:Button ID="Button3" runat="server" Height="20px" Text="导入" Width="98px" />

       </div>
         <div id="div1"></div>
       <div>
           会计系&nbsp;   信息工程系&nbsp;   经济管理系&nbsp;   食品工程系 &nbsp;  机械工程系&nbsp;   商务外语系 &nbsp;  建筑工程系
       </div>
       <div> </div>
       <asp:TextBox ID="TextBox1" runat="server" Width="45px"></asp:TextBox>
      &nbsp;  <asp:TextBox ID="TextBox2" runat="server" Width="45px"></asp:TextBox>
      &nbsp;&nbsp;&nbsp;  <asp:TextBox ID="TextBox3" runat="server" Width="45px"></asp:TextBox>
      &nbsp;&nbsp;&nbsp;&nbsp;  <asp:TextBox ID="TextBox4" runat="server" Width="45px"></asp:TextBox>
      &nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox5" runat="server" Width="45px"></asp:TextBox>
      &nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox6" runat="server" Width="45px"></asp:TextBox>
      &nbsp;&nbsp;&nbsp;&nbsp;  <asp:TextBox ID="TextBox7" runat="server" Width="45px"></asp:TextBox>
      &nbsp;&nbsp;  <asp:Button ID="Button4" runat="server" Text="确定" Height="23px" Width="65px" />
       <div id="div1"></div>
       <div id="div3">
      <asp:Button ID="Button5" runat="server" Text="分析导入数据" Height="23px" Width="134px" />
           <br />
           <br />
<asp:Button ID="Button6" runat="server" Text="处理入库数据" Height="23px" Width="134px" />
           <br />
           <br />
<asp:Button ID="Button7" runat="server" Text="清空入库数据" OnClick="Button7_Click" Height="23px" Width="134px" />
       </div>
        <div id="div1"></div>
       <div>
<asp:Button ID="Button8" runat="server" Text="更新课程数据" OnClick="Button7_Click" Height="23px" Width="134px" />
        </div>
   </div>
</asp:Content>

