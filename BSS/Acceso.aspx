<%@ Page Title="Ingreso al sistema" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="Acceso.aspx.cs" Inherits="BSS.Acceso" %>

<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div id="loginbox" style="margin-top: 20%;" class="mainbox col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2">
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <div class="panel-title">Bienvenido al sistemas - Ingrese sus credenciales</div>
                </div>
                <div style="padding-top: 30px" class="panel-body">

                    <div class="form-group">
                        <div class="col-md-12 control">
                            <div style="border-top: 1px solid#888; padding-top: 15px; font-size: 85%">
                            </div>
                        </div>
                    </div>

                    <div id="loginform" class="form-horizontal" role="form">
                        <div style="margin-bottom: 25px" class="input-group">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
                            <asp:TextBox ID="txtUsuario" runat="server" class="form-control" placeholder="Digite su usuario" required></asp:TextBox>
                        </div>

                        <div style="margin-bottom: 25px" class="input-group">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-lock"></i></span>
                            <asp:TextBox TextMode="Password" ID="txtClave" runat="server" class="form-control" placeholder="Digite su contraseña" required></asp:TextBox>
                        </div>

                        <div style="margin-top: 10px" class="form-group" align="center">
                            <div class="col-sm-">
                                <asp:Button ID="btnLogin" runat="server" class="btn btn-success" Text="Login" OnClick="btnLogin_Click" />
                            </div>
                        </div>
                    </div>

                    <div class="form-group">
                        <div class="col-md-12 control">
                            <div style="border-top: 1px solid#888; padding-top: 15px; font-size: 85%">
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>

    <div class="row">
        <div id="aviso" class="alert alert-danger alert-dismissible col-md-6 col-md-offset-3" align="center" visible="false" runat="server">
            <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
            <strong>Información!</strong> El usuario o la contraseña utilizados no son correctos
        </div>
    </div>

</asp:Content>
