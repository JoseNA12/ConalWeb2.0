<%@ Page Language="C#" MasterPageFile="Menu.Master" AutoEventWireup="true" CodeBehind="PublicarReunion.aspx.cs" Inherits="ConalWeb2._0.PublicarReunion" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

	<link rel="stylesheet" href="CSS/CSS_PublicarReunion.css">
    <!--<link href="CSS/Switch.css" rel="stylesheet" />-->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>

    <style>
        /*
        #divMapaGPS
        {
            height: auto;
            width: auto;
        }
        */
    </style>

    <script>
        /*
        function desplegarMapa() {
          var checkBox = document.getElementById("myCheck_Mapa");
          
          if (checkBox.checked == true){
            $("#divMapaGPS").load("MapaGPS.html"); 
          }
          else {
             /* Eliminar el div
            jQuery('#divMapaGPS').html('');
          }
        }
        /*
    </script>

</asp:Content>
	
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="main">
		<div class="container" id="container1">
			<h1>
				Publicar reunión
			</h1>
			<div class="container" id="container2">			
				<label for="nombre">Titular</label>
				<p><asp:TextBox runat="server" id="inputTitular" placeholder="Titular" oninput="this.className = ''" name="titular"/></p>
				<label for="nombre">Motivo</label>
				<p><Textarea id="inputMotivo" rows="4" cols="50" name="inputMotivo" placeholder="Motivo de la reunión"></Textarea></p>
				<label for="nombre">Fecha de la reunión</label>
				<p><asp:TextBox runat="server" id="inputFecha" type="date" name="fecha" /></p>
				<label for="nombre">Hora de la reunión</label>
				<p><asp:TextBox runat="server" ID="inputHora" type="time" name="hora" /></p>
					
				<label for="nombre">Ubicación de la reunión</label>
				<p><Textarea id="inputUbicacion" rows="4" cols="50" name="inputUbicacion" placeholder='Ubicación del acontecimiento'></Textarea></p>
				
                <!--<label for="nombre">Mapa de la ubicación</label>

                
                <label class="switch">
                  <input id="myCheck_Mapa" type="checkbox" onclick="desplegarMapa()">
                  <span class="slider round"></span>
                </label>
                    --->

                <!-- Mapa GPS 
                <div id="divMapaGPS"></div>--->
					
                <p style:"center">
                    <asp:Button ID="btn123" class="button" runat="server" Text="Publicar" OnClick="btnPublicarReunion" />
				</p>
					
                <br> <br>
			</div>
		</div>
	</div>

</asp:Content>
