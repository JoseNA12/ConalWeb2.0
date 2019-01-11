<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="ConalWeb2._0.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="CSS/CSS_InicioSesion.css" type="text/css"/>
    <title>Crear cuenta</title>
</head>
<body>

    <nav class="navbar navbar-inverse">
      <div class="container-fluid">
        <div class="navbar-header">
          <a class="navbar-brand" href="#">ConalWeb 2.0</a>
        </div>
        <ul class="nav navbar-nav navbar-right">
          <li><a href="#">Acerca de...</a></li>
          <li><a href="InicioSesion.aspx">Iniciar sesión</a></li>
          <li class="active"><a href="Registro.aspx">Registro</a></li>
        </ul>
      </div>
    </nav>

    <br/>
    <br/><div id="divMain">
        <br/>
        <h2 id="h2DivMain">Registro</h2>
        <div id="divSecond">
            <br/>
            <form id="form2" runat="server">
                <h4 id="h4DivSecond">Nombre</h4>
                <asp:TextBox runat="server" id="inputNombre" type="text" name="nombre" />
                <br/>
                <h4 id="h4DivSecond">Apellidos</h4>
                <asp:TextBox runat="server" type="text" id="inputApellidos" name="apellidos" />
                <br/>
                <h4 id="h4DivSecond">Usuario</h4>
                <asp:TextBox runat="server" type="text" id="inputUsuario" name="usuario" />
                <br/>
                <h4 id="h4DivSecond">Correo</h4>
                <asp:TextBox runat="server" type="email" id="inputCorreo" name="correo" placeholder="ejemplo@correo.com" />
                <br/>
                <h4 id="h4DivSecond">Contraseña</h4>
                <asp:TextBox runat="server" type="password" id="inputContrasenia" name="contrasenia" placeholder="pepito123" />

                <br/><br/>
                <div align="center">
                    <asp:Button runat="server" class="button button2" Text="Registrase" onClick="btnCrearCuenta" />
                </div>
            </form>
            <br/><br/>
        </div>
        <br/>
        <br/>
    </div>
</body>
</html>
