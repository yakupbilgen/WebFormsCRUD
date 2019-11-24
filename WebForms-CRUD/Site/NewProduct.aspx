<%@ Page Title="Yeni Ürün Ekleme Sayfası" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewProduct.aspx.cs" Inherits="WebForms_CRUD.Site.NewProduct" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <table align="center" style="width: 543px; height: 202px;">
        <tr>
            <td style="width: 95px">Ürün Adı</td>
            <td>
                <asp:TextBox ID="txtProductName" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 95px">Ürün Fiyatı</td>
            <td>
                <asp:TextBox ID="txtUnitPrice" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 95px">Ürün Adeti</td>
            <td>
                <asp:TextBox ID="txtUnitStock" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 95px">&nbsp;</td>
            <td>
                <asp:Button class="btn btn-primary" ID="btnEkle" runat="server" Text="Ekle" Width="100px" OnClick="btnEkle_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblDurum" runat="server"></asp:Label>
            </td>
        </tr>
    </table>

</asp:Content>
