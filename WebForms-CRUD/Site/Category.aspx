<%@ Page Title="Kategori Sayfası" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Category.aspx.cs" Inherits="WebForms_CRUD.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <table style="width: 100%; height: 30px">
        <tr>
            <td style="height: 30px"><a href="NewCategory.aspx" class="btn btn-warning">Yeni Kategori Ekle</a></td>
            <td style="height: 30px; text-align: center;">
                <a href="UpdateCategory.aspx" class="btn btn-warning">Kategori Güncelle</a>
            </td>
            <td aria-hidden="False" style="right: 50px; height: 30px; text-align: right;">
                <asp:TextBox ID="txtSilid" runat="server" Width="70px" placeholder="İd giriniz"></asp:TextBox>
                <asp:Button ID="btnSil" runat="server" Text="Sil" class="btn btn-warning" style="text-align: right" OnClick="btnSil_Click" />
            </td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Label ID="lblGuncelle" runat="server"></asp:Label></td>
            <td><asp:Label ID="lblSil" runat="server" Text=""></asp:Label></td>
        </tr>
    </table>
    <br />
    <table class="table table-bordered table-hover" style="width: 100%">
        <tr>
            <th style="height: 37px">Kategori ID</th>
            <th style="height: 37px">Kategori Adı</th>
            <th style="height: 37px">Açıklama</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("CategoryID")%> </td>
                        <td><%#Eval("CategoryName")%></td>
                        <td><%#Eval("Description")%></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
