<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="BSS.Perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="//netdna.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
    <script src="//netdna.bootstrapcdn.com/bootstrap/3.2.0/js/bootstrap.min.js"></script>
    <script src="//code.jquery.com/jquery-1.11.1.min.js"></script>

    <link href="//netdna.bootstrapcdn.com/font-awesome/4.0.3/css/font-awesome.min.css" rel="stylesheet">
    <div class="container">
	    <div class="row">
		    <div class="col-md-offset-2 col-md-8 col-lg-offset-3 col-lg-6">
    	     <div class="">
                <div class="col-sm-12">
                    <div class="col-xs-12 col-sm-8">
                        <h2><label id="Nombre">Mi perfil</label></h2>
                        <p><strong>Nombre: </strong><asp:Label ID="lbNombre" runat="server"></asp:Label>
                        <p><strong>Nickname: </strong><asp:Label ID="lbNickname" runat="server"></asp:Label> 
                        <p><strong>Puesto: </strong></p><asp:Label ID="lbPuesto" runat="server">Empleado</asp:Label>
                    </div>             
                    <div class="col-xs-12 col-sm-4 text-center">
                        <figure>
                            <img src="http://www.localcrimenews.com/wp-content/uploads/2013/07/default-user-icon-profile.png" alt="" class="img-circle img-responsive">
                        </figure>
                    </div>
                </div>            
                <div class="col-xs-12 divider text-center">
                    <div class="col-xs-12 col-sm-4 emphasis">
                        <br/>   
                        <span class="fa fa-gear"></span>           
                        <h4><strong>Cambiar contraseña</strong></h4>
                        <asp:Button class="btn btn-success btn-block" ID="btnCambiar" runat="server" OnClick="btnCambiar_Click" Text="Cambiar"/>
                    </div>
                    <div class="col-xs-12 col-sm-4 emphasis">
                        <br/>   
                        <span class="fa fa-user"></span>       
                        <h4><strong>Editar informacion</strong></h4>
                        <asp:Button class="btn btn-info btn-block" ID="btnEditar" runat="server" OnClick="btnEditar_Click" Text="Editar"/>
                    </div>
                    <div class="col-xs-12 col-sm-4 emphasis">
                        <br/>
                        <span class="fa fa-plus-circle"></span>
                        <h4><strong>Agregar Imagen de Perfil</strong></h4>
                        <asp:Button class="btn btn-primary btn-block" ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar"/>
                        </div>
                    </div>
                </div>
    	     </div>                 
		    </div>
	    </div>
    </div>
</asp:Content>
