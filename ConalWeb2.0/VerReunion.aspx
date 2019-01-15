<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerReunion.aspx.cs" Inherits="ConalWeb2._0.VerReunion" %>

<!DOCTYPE html>

<html>
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<link type="text/css" rel="stylesheet" href="CSS/CSS_VerReunion.css">
</head>
<body>
    <form id="form1" runat="server">
		<asp:label runat="server" id = "titularReunion" class = "txt">Titular</asp:label> <asp:label runat="server" ID ="fechaReunion" class = "txt">Fecha</asp:label> <asp:label runat="server" id = "horaReunion" class = "txt">Hora</asp:label> 

		<!--<span  class="close" title="Close Modal">&times;</span>-->
        <br>
        <br>
        <br>
        <br>
        <asp:label runat="server" id = "Label1" class = "txt"> Descripción </asp:label>
		<div id = "divDesc" class = "divReunion">
            <br>
			<asp:label runat="server" id = "descripcionReunion" class = "info"> Descripción del Reunion </asp:label>
		</div>
		<br>
		<br>
        <asp:label runat="server" id = "Label3" class = "txt"> Ubicación </asp:label>
		<div id = "divUbicacion" class = "divReunion">
            <br>
			<asp:label runat="server" id = "ubicacionReunion" class = "info"> Ubicación del Reunion </asp:label>
		</div>

    </form>
</body>
</html>
