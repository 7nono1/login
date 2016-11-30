<%@ Page Title="" Language="C#" MasterPageFile="~/教师/sdbi_MasterPage.master" AutoEventWireup="true" CodeFile="lurukaoqinxiangxi.aspx.cs" Inherits="管理员_lurukaoqinxiangxi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
       <style type="text/css">
        #Select1 {
            width: 88px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnUnNormal" runat="server" Text="返回主页面" OnClick="btnUnNormal_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnAttendance" runat="server" OnClick="btnAttendance_Click" Text="上报考勤结果" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    &nbsp;&nbsp;&nbsp;
    &nbsp;
&nbsp;<asp:Panel ID="Panel1" runat="server" Height="452px" ScrollBars="Vertical">
        <asp:GridView ID="gvAttendanceDetails" runat="server" AutoGenerateColumns="False" BackColor="White"
    BorderColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="学号" 
    GridLines="Horizontal" OnRowDataBound="gvAttendanceDetails_RowDataChanged" Font-Size="12px" >
            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            <Columns>
                <asp:BoundField DataField="系部" HeaderText="系部" ItemStyle-Width="100px" >
                <ItemStyle Width="100px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="行政班级" HeaderText="行政班级" ItemStyle-Width="100px" >
                <ItemStyle Width="100px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="学号" HeaderText="学号" ItemStyle-Width="100px" >
                <ItemStyle Width="100px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="姓名" HeaderText="姓名" ItemStyle-Width="100px" >
                <ItemStyle Width="100px"></ItemStyle>
                </asp:BoundField>
                <asp:TemplateField HeaderText="出勤情况">
                    <ItemTemplate>
                        <asp:RadioButton ID="rdoNormal" runat="server" GroupName="g1" Text="正常" Checked="true"
                    AutoPostBack="true" OnCheckedChanged="rdo_CheckChange" />
                        <asp:RadioButton ID="rdoLate" runat="server" GroupName="g1" Text="迟到" 
                    AutoPostBack="true" OnCheckedChanged="rdo_CheckChange" />
                        <asp:RadioButton ID="rdoAbsence" runat="server" GroupName="g1" Text="旷课"
                    AutoPostBack="true" OnCheckedChanged="rdo_CheckChange" />
                        <asp:RadioButton ID="rdoEarly" runat="server" GroupName="g1" Text="早退" 
                    AutoPostBack="true" OnCheckedChanged="rdo_CheckChange" />
                        <asp:RadioButton ID="rdoLeave" runat="server" GroupName="g1" Text="请假" 
                    AutoPostBack="true" OnCheckedChanged="rdo_CheckChange" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="true" ForeColor="#F7F7F7" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="true" ForeColor="#F7F7F7" />
        </asp:GridView>
    </asp:Panel>

    <asp:SqlDataSource ID="sqlDataSourceAttendanceDetails" runat="server" ConnectionString="%$ConnectionStrings:SDBISASConnectionString2 %>"
        SelectCommand="SELECT DISTINCT[studentDepartment],[StudentID],[StudentName],[t4]FROM[TabAllCourse]WHERE(([TeacherID]=@TeacherID)AND([Course]=@Course)AND([TimeAndArea]=@TimeAndArea))">
        <SelectParameters>
            <asp:SessionParameter Name="TeacherID" SessionField="UserID" Type="String" />
            <asp:SessionParameter Name="Course" SessionField="CurrentCourse" Type="String" />
            <asp:SessionParameter Name="TimeAndArea" SessionField="WeekRange" Type="String" />
        </SelectParameters>

    </asp:SqlDataSource>

</asp:Content>

