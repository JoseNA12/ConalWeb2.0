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
		<asp:label runat="server" id = "titularSuceso" class = "txt">Titular</asp:label> <asp:label runat="server" ID ="fechaSuceso" class = "txt">Fecha</asp:label> <asp:label runat="server" id = "horaSuceso" class = "txt">Hora</asp:label> 

		<!--<span  class="close" title="Close Modal">&times;</span>-->
        <br>
        <br>
        <br>
        <br>
		<div id = "divDesc" class = "divSuceso">
			<asp:label runat="server" id = "descripcionSuceso" class = "titulos"> Descripción </asp:label>
		</div>
		<br>
		<div id = "divSospechoso" class = "divSuceso">
			<asp:label runat="server" id = "sospechosoSuceso" class = "titulos"> Sospechosos </asp:label>
		</div>
		<br>
		<div id = "divUbicacion" class = "divSuceso">
			<asp:label runat="server" id = "ubicacionSuceso" class = "titulos"> Ubicación </asp:label>
		</div>

    </form>
</body>
</html>
