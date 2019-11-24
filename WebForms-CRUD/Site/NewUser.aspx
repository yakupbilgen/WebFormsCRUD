<%@ Page Title="Yeni Kullanıcı Sayfası" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewUser.aspx.cs" Inherits="WebForms_CRUD.Site.NewUser" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <table class="nav-justified"  align="center" style="width: 500px; height: 124px">
        <tr>
            <td style="width: 92px">Kullanıcı Adı</td>
            <td>
                <asp:TextBox ID="txtUserName" runat="server"  Width="150px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 92px">Şifre</td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server"  Width="150px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 92px">&nbsp;</td>
            <td>
                <asp:Button CssClass="btn btn-warning" ID="btnSaveUser" runat="server" Text="Kaydol" Width="100px" OnClick="btnSaveUser_Click" />
            </td>
        </tr>
        <tr>
            <td style="width: 92px">
                <asp:Label ID="lblDurum" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>

</asp:Content>
