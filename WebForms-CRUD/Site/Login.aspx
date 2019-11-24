<%@ Page Title="Kullanıcı Giriş Sayfası" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebForms_CRUD.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <table align="center" style="width: 500px; height: 124px">
        <tr>
            <td style="width: 110px">Kullanıcı Adı</td>
            <td>
                <asp:TextBox ID="txtUsername" runat="server" Width="150px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 110px; height: 30px">Şifre</td>
            <td style="height: 30px">
                <asp:TextBox ID="txtPassword" runat="server" Width="150px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 110px">&nbsp;</td>
            <td>
                <asp:Button CssClass="btn btn-warning" ID="btnLogin" runat="server" Text="Button" Width="100px" OnClick="btnLogin_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblDurum" runat="server"></asp:Label>
            </td>
        </tr>
    </table>


</asp:Content>