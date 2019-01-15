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
        <asp:label runat="server" id = "Label1" class = "txt"> Descripción </asp:label>
		<div id = "divDesc" class = "divSuceso">
            <br>
			<asp:label runat="server" id = "descripcionSuceso" class = "info"> Descripción del suceso </asp:label>
		</div>
		<br>
        <asp:label runat="server" id = "Label2" class = "txt"> Sospechosos </asp:label>
		<div id = "divSospechoso" class = "divSuceso">
            <br>
			<asp:label runat="server" id = "sospechosoSuceso" class = "info"> Sospechosos del suceso </asp:label>
		</div>
		<br>
        <asp:label runat="server" id = "Label3" class = "txt"> Ubicación </asp:label>
		<div id = "divUbicacion" class = "divSuceso">
            <br>
			<asp:label runat="server" id = "ubicacionSuceso" class = "info"> Ubicación del suceso </asp:label>
		</div>

    </form>
</body>
</html>
