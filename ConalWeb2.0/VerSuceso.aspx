<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerSuceso.aspx.cs" Inherits="ConalWeb2._0.VerSuceso" %>

<!DOCTYPE html>

<html>
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
	<link type="text/css" rel="stylesheet" href="CSS/CSS_VerSuceso.css">
</head>
<body>
    <form id="form1" runat="server">
		<p> <span id = "titularSuceso" class = "txt">Titular</span> <span id = "fechaSuceso" class = "txt">Fecha</span> <span id = "horaSuceso" class = "txt">Hora</span> </p>

		<span  class="close" title="Close Modal">&times;</span>

		<div id = "divMapa" class = "divSuceso">
			
		</div>

		<div id = "divDesc" class = "divSuceso">
			<p id = "descripcionSuceso" class = "titulos"> Descripción </p>
		</div>
		
		<div id = "divSospechoso" class = "divSuceso">
			<p id = "sospechosoSuceso" class = "titulos"> Sospechosos </p>
		</div>
		
		<div id = "divUbicacion" class = "divSuceso">
			<p id = "ubicacionSuceso" class = "titulos"> Ubicación </p>
		</div>

    </form>
</body>
</html>
