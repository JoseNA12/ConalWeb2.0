<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="ConalWeb2._0.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="CSS/Estilos.css" type="text/css"/>
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
            <h4 id="h4DivSecond">Nombre</h4>
            <input type="text" name="nombre" />
            <br/>
            <h4 id="h4DivSecond">Apellidos</h4>
            <input type="text" name="apellidos" />
            <br/>
            <h4 id="h4DivSecond">Correo</h4>
            <input type="email" name="correo" placeholder="ejemplo@correo.com" />
            <br/>
            <h4 id="h4DivSecond">Contraseña</h4>
            <input type="password" name="contrasenia" placeholder="pepito123" />
            <br/><br/>
            <div align="center">
                <button class="button button2">Registrase</button>
            </div>
            
            <br/><br/>
        </div>
        <br/>
        <br/>
    </div>
</body>
</html>
