<%@ Page Title="Ürün Güncelleştirme Sayfası" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateProduct.aspx.cs" Inherits="WebForms_CRUD.Site.UpdateProduct" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <table align="center" style="width: 717px; height: 133px; ">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Ürün İD"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtid" runat="server" placeholder="İD giriniz"></asp:TextBox>
                <asp:Button class="btn btn-success" ID="btnBilgiGetir" runat="server" Text="Bilgileri Getir" OnClick="btnBilgiGetir_Click"/>
                <asp:Label ID="lblidbulunamadi" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="height: 48px; width: 89px;">Ürün Adı</td>
            <td style="height: 48px; font-size: 11pt">
                <asp:TextBox ID="txtUrunAdi" runat="server" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="height: 50px; width: 89px;">Ürün Fiyatı</td>
            <td style="height: 50px">
                <asp:TextBox ID="txtUrunFiyat" runat="server" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="height: 50px; width: 89px;">Stok Adeti</td>
            <td style="height: 50px">
                <asp:TextBox ID="txtUrunStok" runat="server" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 89px">&nbsp;</td>
            <td>
                <asp:Button class="btn btn-primary" ID="btnGuncelle" runat="server" Text="Güncelle" Width="100px" OnClick="btnGuncelle_Click"/>
            </td>
        </tr>
    </table>
</asp:Content>
