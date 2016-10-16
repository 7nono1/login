<%@ Page Title="" Language="C#" MasterPageFile="~/领导/sdbi_MasterPage.master" AutoEventWireup="true" CodeFile="enterwork.aspx.cs" Inherits="领导_enterwork" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="height: 785px">
    <asp:Repeater ID="rptCourse" runat="server" OnItemCommand="rptCourse_ItemCommand">
        <HeaderTemplate>
            <table border="0" style="width:100%" cellpadding="0" cellspacing="0">
                <tr>
                    <td colspan="4" style="width:100%; height:30px;" class="STYLE1">
                        <asp:Label ID="Lable2" runat="server" Text="本周授课信息："></asp:Label>

                    </td>
                </tr>
            </table>
        </HeaderTemplate>
        <ItemTemplate>
            <table border="0" style="width:100%" cellpadding="0" cellspacing="0">
                <tr>
                    <td style="width:10%; height:25px;" align="center" class="STYLE1">
                        <%#Container.ItemIndex+1 %>&nbsp;
                    </td>
                    <td style="width:40%;height:25px;"class="STYLE1">
                        <%#DataBinder.Eval(Container.DataItem,"Week") %>
                        <%#DataBinder.Eval(Container.DataItem,"Time") %>
                        <%#(DataBinder.Eval(Container.DataItem,"Course")).ToString().Substring(0,(DataBinder.Eval(Container.DataItem,"Course")).ToString().Length-3) %>
                        <asp:TextBox ID="tetCourse" runat="server" Visible="false" Text='<%#DataBinder.Eval(Container.DataItem,"Course") %>'></asp:TextBox>
                        <asp:TextBox ID="tetWeek" runat="server" Visible="false" Text='<%#DataBinder.Eval(Container.DataItem,"Week") %>'></asp:TextBox>
                        <asp:TextBox ID="tetTime" runat="server" Visible="false" Text='<%#DataBinder.Eval(Container.DataItem,"Time") %>'></asp:TextBox>
                        <asp:TextBox ID="tetWeelRange" runat="server" Visible="false" Text='<%#DataBinder.Eval(Container.DataItem,"StudentIDList") %>'></asp:TextBox>
                    </td>
                    <td style="width:10%;height:25px;" class="STYLE1">
                        <asp:CheckBox ID="chkHomework" Text="布置作业" runat="server" />

                    </td>
                    <td style="width:20%; height:25px;" class="STYLE1"><asp:Button ID="btnClick" CssClass="btn" Text="考勤" Width="100" runat="server" OnClick="BtnSubmit_Click" />

                    </td>
                    <td style="width:10%;height:25px;">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="5"><hr />

                    </td>
                </tr>
            </table>
        </ItemTemplate>
        <FooterTemplate>
            </FooterTemplate>
    </asp:Repeater>
        </div>
</asp:Content>

