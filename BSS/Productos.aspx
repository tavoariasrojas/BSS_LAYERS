<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="BSS.Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Productos</h2>
    <p>
        <asp:GridView ID="gvProductos" runat="server" CssClass="table table-hover"></asp:GridView>
    </p>


</asp:Content>
