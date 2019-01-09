<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarMiembros.aspx.cs" Inherits="ConalWeb2._0.EliminarMiembros" %>

<!DOCTYPE html>

<html>
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1">
	<link type="text/css" rel="stylesheet" href="CSS/CSS_EliminarMiembro.css">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container" id="container1">
            <h1>
                Gestionar grupo.
            </h1>
            <div class="container" id="container2">
                <h3> Eliminar integrante </h3>
                <p> Seleccione el integrante que desea eliminar y presione el botón de eliminar integrante</p>
                <table id = "tablaIntegrantes">
                    <tr class = "header">
                        <th>Integrantes del grupo</th>
                    </tr>
                    <tr>
                        <td> (img) (nombre) </td>
                    </tr>

                </table>

                <div id = "divButton">
                        <button type="button" class = "buttonGrupos" style = "margin: 25px auto auto 9em;">Eliminar integrante</button>
                        <button type="button" class = "buttonGrupos" style = "margin: 25px auto auto 9em;">Cancelar</button>
                </div>

            </div>
        </div>
    </form>
</body>
</html>
