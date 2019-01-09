<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerReunion.aspx.cs" Inherits="ConalWeb2._0.VerReunion" %>

<!DOCTYPE html>

<html>
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<link type="text/css" rel="stylesheet" href="CSS_VerReunion.css">
</head>
<body>
    <form id="form1" runat="server">
        <p> <span id = "titularReunion" class = "txt">Titular</span> <span id = "fechaReunion" class = "txt">Fecha</span> <span id = "horaReunion" class = "txt">Hora</span> </p>

		<span  class="close" title="Close Modal">&times;</span>

		<div id = "divMapa" class = "divReunion">
			
		</div>

		<div id = "divDesc" class = "divReunion">
			<p id = "descripcionReunion" class = "titulos"> Descripción </p>
		</div>
	
		<div id = "divUbicacion" class = "divReunion">
			<p id = "ubicacionReunion" class = "titulos"> Ubicación </p>
		</div>
    </form>
</body>
</html>
