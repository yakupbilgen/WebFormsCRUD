<%@ Page Title="Ürünler Sayfası" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="WebForms_CRUD.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <table style="width: 100%; height: 30px">
        <tr>
            <td style="height: 30px"><a href="NewProduct.aspx" class="btn btn-warning">Yeni Ürün Ekle</a></td>
            <td style="height: 30px; text-align: center;">
                <a href="UpdateProduct.aspx" class="btn btn-warning">Ürün Güncelle</a>
            </td>
            <td aria-hidden="False" style="right: 50px; height: 30px; text-align: right;">
                <asp:TextBox ID="txtSilid" runat="server" Width="70px" placeholder="İd giriniz"></asp:TextBox>
                <asp:Button ID="btnSil" runat="server" Text="Sil" class="btn btn-warning" style="text-align: right" OnClick="btnSil_Click"/>
            </td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Label ID="lblGuncelle" runat="server"></asp:Label></td>
            <td><asp:Label ID="lblSil" runat="server" Text=""></asp:Label></td>
        </tr>
    </table>
    <br />
    <table class="table table-bordered table-hover">
        <tr>
            <th>Ürün ID</th>
            <th>Ürün Adı</th>
            <th>Ürün Fiyatı</th>
            <th>Ürün Adeti</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("ProductID")%> </td>
                        <td><%#Eval("ProductName")%></td>
                        <td><%#Eval("UnitPrice")%></td>
                        <td><%#Eval("UnitStock")%></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
