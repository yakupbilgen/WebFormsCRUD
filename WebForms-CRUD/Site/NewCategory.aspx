<%@ Page Title="Yeni Kategori Ekleme Sayfası" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewCategory.aspx.cs" Inherits="WebForms_CRUD.NewCategory" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center" style="width: 483px; height: 133px; ">
        <tr>
            <td class="modal-sm" style="height: 48px; width: 89px;">Kategori Adı</td>
            <td style="height: 48px; font-size: 11pt">
                <asp:TextBox ID="txtKategori" runat="server" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="height: 50px; width: 89px;">Açıklama</td>
            <td style="height: 50px">
                <asp:TextBox ID="txtAciklama" runat="server" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 89px">&nbsp;</td>
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


