<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InicioSesion.aspx.cs" Inherits="ConalWeb2._0.InicioSesion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="CSS/CSS_InicioSesion.css" type="text/css"/>
    <title>Iniciar sesión</title>
</head>
<body>

    <nav class="navbar navbar-inverse">
      <div class="container-fluid">
        <div class="navbar-header">
          <a class="navbar-brand" href="#">ConalWeb 2.0</a>
        </div>
        <ul class="nav navbar-nav navbar-right">
          <li><a href="#">Acerca de...</a></li>
          <li class="active"><a href="InicioSesion.aspx">Iniciar sesión</a></li>
          <li><a href="Registro.aspx">Registro</a></li>
        </ul>
      </div>
    </nav>

    <br/>
    <br/><div id="divMain">
        <br/>
        <h2 id="h2DivMain">Iniciar sesión</h2>
        <div id="divSecond">
            <form id="form1" runat="server">
                <br/>
                <h4 id="h4DivSecond">Correo</h4>
                <asp:TextBox ID="inputCorreo" runat="server" type="email" name="correo" placeholder="ejemplo@correo.com"></asp:TextBox>
                <br/><br/>
                <h4 id="h4DivSecond">Contraseña</h4>
                <asp:TextBox ID="inputContrasenia" runat="server" type="password" name="contrasenia" placeholder="pepito123"></asp:TextBox>
                <br/><br/>
                <div align="center">
                    <asp:Button ID="Button1" runat="server" class="button button2" Text="Iniciar sesión" onClick="btnIniciarSesion" />
                </div>
            </form>
            
            <br/><br/>
        </div>
        <br/>
        <br/>
    </div>
</body>
</html>
