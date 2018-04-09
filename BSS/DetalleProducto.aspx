<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalleProducto.aspx.cs" Inherits="BSS.DetalleProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="color:red">Producto Detalle</h2>
   
    <div class="form-inline">
        <asp:Label ID="lbCodProducto" runat="server" Text="Codigo Producto: "></asp:Label>
        <asp:TextBox ID="txtCodProducto" runat="server" CssClass="form-control"></asp:TextBox>
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-primary" OnClick="btnBuscar_Click" />
    </div>
    
    <div class="form-group" id="divMantenimiento" runat="server" visible="false">
    <asp:Label ID="lbCodigo" runat="server" Text="Codigo"></asp:Label>
    <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control"></asp:TextBox>
    <asp:Label ID="lbTipoCodigo" runat="server" Text="Tipo Codigo"></asp:Label>
    <asp:TextBox ID="txtTipoCodigo" runat="server" CssClass="form-control"></asp:TextBox>
    <asp:Label ID="lbMarcaCodigo" runat="server" Text="Codigo Marca"></asp:Label>
    <asp:TextBox ID="txtMarcaCodigo" runat="server" CssClass="form-control"></asp:TextBox>
    <asp:Label ID="lbDetalle" runat="server" Text="Detalle"></asp:Label>
    <asp:TextBox ID="txtDetalle" runat="server" CssClass="form-control"></asp:TextBox>
    <asp:Label ID="lbMonedaCodigo" runat="server" Text="Moneda Codigo"></asp:Label>
    <asp:TextBox ID="txtMonedaCodigo" runat="server" CssClass="form-control"></asp:TextBox>
    <asp:Label ID="lbPrecio" runat="server" Text="Precio"></asp:Label>
    <asp:TextBox ID="txtPrecio" runat="server" CssClass="form-control"></asp:TextBox>
    <asp:Label ID="lbDescuento" runat="server" Text="Descuento"></asp:Label>
    <asp:TextBox ID="txtDescuento" runat="server" CssClass="form-control"></asp:TextBox>
    <asp:Label ID="lbGravado" runat="server" Text="Gravado"></asp:Label>
        <br />
    <asp:RadioButton ID="rbGravado" runat="server" Text="Si"/>
        <br />
    <asp:Label ID="lbUnidadMedida" runat="server" Text="Unidad de Medida"></asp:Label>
    <asp:TextBox ID="txtUnidadMedida" runat="server" CssClass="form-control"></asp:TextBox>
    <asp:Label ID="lbMedida" runat="server" Text="Medida"></asp:Label>
    <asp:TextBox ID="txtMedida" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

</asp:Content>
