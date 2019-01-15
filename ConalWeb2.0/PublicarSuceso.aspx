<%@ Page Language="C#" MasterPageFile="Menu.Master" AutoEventWireup="true" CodeBehind="PublicarSuceso.aspx.cs" Inherits="ConalWeb2._0.PublicarSuceso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

	<link rel="stylesheet" href="CSS/CSS_PublicarSuceso.css">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

	<div class="main">
		<div class="container" id="container1">
			<h1>
				Publicar suceso
			</h1>
			<div class="container" id="container2">

			    <label for="nombre">Titular</label>
			    <p><asp:TextBox runat="server" id="inputTitular" placeholder="Titular" oninput="this.className = ''" name="titular"/></p>

			    <label for="nombre">Descripción</label>
			    <p><Textarea id="inputDesc" rows="4" cols="50" name="inputDesc" placeholder="Descripción del suceso."></Textarea></p>

			    <label for="nombre">Descripción de los sospechosos</label>
			    <p><Textarea id="inputDescSospechosos" rows="4" cols="50" name="inputDescSospechosos" placeholder="Descripción de los sospechosos."></Textarea></p>

			    <label for="nombre">Fecha del suceso</label>
			    <p><asp:TextBox runat="server" id="inputFecha" type="date" name="fecha" /></p>

			    <label for="nombre">Hora del suceso</label>
			    <p><asp:TextBox runat="server" ID="inputHora" type="time" name="hora" /></p>

				<label for="nombre">Ubicación del suceso</label>
				<p><Textarea id="inputUbicacion" rows="4" cols="50" name="inputUbicacion" placeholder='Ubicación del acontecimiento'></Textarea></p>
				
                <!--<label for="nombre">Mapa de la ubicación</label>-->

                <p style:"center">
                    <asp:Button ID="btnPublicar" class="button" runat="server" Text="Publicar" OnClick="btnPublicarSuceso" />
				</p>

                <br> <br>
			</div>
		</div>
	</div>
</asp:Content>