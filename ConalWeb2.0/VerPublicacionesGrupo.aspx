<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerPublicacionesGrupo.aspx.cs" Inherits="ConalWeb2._0.VerPublicacionesGrupo" %>

<!DOCTYPE html>

<html>
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <link type="text/css" rel="stylesheet" href="CSS/CSS_VerPublicacionesGrupo.css">

    

    <style>
        .modal-contenido{
            font-family: Arial, Helvetica, sans-serif;
            background-color: #2B456C;
            color: white;
            width:70%;
            margin: auto;
            position: relative;
        }
        .modal{
            background-color: rgba(0,0,0,.8);
            top:0;
            right:0;
            bottom:0;
            left:0;
            opacity:0;
            position: fixed;
            pointer-events:none;
            transition: all 1s;
        }

        #miModal:target {
            opacity: 1;
            pointer-events: auto;   
        }

        #divMapa {
            height: 12em;
        }

        #divDesc {
            height: 7em;
        }

        #divSospechoso {
            height: 7em;
        }

        #divUbicacion {
            height: 6em;
        }

        .divSuceso {
            background-color: #406295;
            color: white;
            width: 80%;
            margin: auto;
            border-radius: 20px;
        }

        .txt {
            margin-left: 150px;
        }

        /* The Close Button (x) */
        .close {
            position: absolute;
            right: 25px;
            top: 0;
            color: white;
            font-size: 35px;
            font-weight: bold;
        }

        .close:hover,
        .close:focus {
            color: red;
            cursor: pointer;
        }

        .titulos {
            margin: 50px auto auto 50px;
        }

    </style>

    <script>
		$(function() {

			$('#headerSucesos').click(function(e) {
				$("#seccionSucesos").delay(100).fadeIn(100);
				$("#seccionReuniones").fadeOut(100);
				$('#headerReuniones').removeClass('active');
				$(this).addClass('active');
				e.preventDefault();
			});
			
			$('#headerReuniones').click(function(e) {
				$("#seccionReuniones").delay(100).fadeIn(100);
				$("#seccionSucesos").fadeOut(100);
				$('#headerSucesos').removeClass('active');
				$(this).addClass('active');
				e.preventDefault();
            });

            $('.link').click(function (e) {
                var a = $('.link').attr('id'); 
                alert("id " + a);
                $('#YourHiddenField').val(a);
                alert("paso 2");
                $(<%=Labelprueba.ClientID%>).text(a);
                alert("paso 3: " + $(<%=Labelprueba.ClientID%>).text());
                <% verSuceso();%>;
                alert("ultimo paso");
                <% prueba();%>;
			});

        });

       
	</script>

   
</head>
<body>
    

    <form id="form1" runat="server">

        <button type="button" class = "buttonGrupos" style = "margin: 25px auto auto 1150px;">Publicar reunión</button>
		<div class="panel">
			<div class="panel-heading">
				<div class="row">
					<div class="col-xs-6">
						<a href="#" class="active" id="headerSucesos">Sucesos</a>
					</div>
					<div class="col-xs-6">
						<a href="#" id="headerReuniones">Reuniones</a>
					</div>

				</div>
			</div>
			<div class="panel-body">
                <asp:Panel id = "seccionSucesos" style="display: block;" runat="server" >
                    <asp:Table ID="tblSucesos" runat="server" Width="70%" Style="margin: auto; border:1;" CssClass="table-responsive marginToFooter" >
                    <asp:TableHeaderRow runat="server" CssClass="tableBorder">
                    </asp:TableHeaderRow>
                    </asp:Table>
                </asp:Panel>

                <asp:Panel id = "seccionReuniones" style="display: none;" runat="server" >
                    <asp:Table ID="tblReuniones" runat="server" Width="70%" Style="margin: auto; border:1;" CssClass="table-responsive marginToFooter" >
                    <asp:TableHeaderRow runat="server" CssClass="tableBorder">
                    </asp:TableHeaderRow>
                    </asp:Table>
                </asp:Panel>
			</div>
		</div>
		<div id = "divButton">
			<button type="button" class = "buttonGrupos" style = "margin: 25px auto auto 9em;">Publicar reunión</button>
			<button type="button" class = "buttonGrupos" style = "margin: 25px auto auto 9em;">Publicar suceso</button>
			<button type="button" class = "buttonGrupos" style = "margin: 25px auto auto 20em;">Salir del grupo</button>
		</div>

       <asp:Panel runat="server" ID="miModal" class="modal">
            <div class="modal-contenido" onload="cargarSuceso()">
                <asp:label runat="server" id = "Labelprueba" class = "txt" Text="Titular"></asp:label>
                <asp:HiddenField ID="YourHiddenField" runat="server" ClientIDMode="Static" />
                <asp:label runat="server" id = "titularSuceso" class = "txt" Text="Titular"></asp:label> <asp:label runat="server" id = "fechaSuceso" class = "txt"></asp:label> <asp:label runat="server" id = "horaSuceso" class = "txt"></asp:label> 
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
            </div>  
       </asp:Panel>
        
    </form>
</body>
</html>
