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
				<div id = "seccionSucesos" style="display: block;">
						<p > hola </p>

				</div>

				<div id = "seccionReuniones" style="display: none;">

					<p > como estas </p>

				</div>
			</div>
		</div>
		<div id = "divButton">
			<button type="button" class = "buttonGrupos" style = "margin: 25px auto auto 9em;">Publicar reunión</button>
			<button type="button" class = "buttonGrupos" style = "margin: 25px auto auto 9em;">Publicar suceso</button>
			<button type="button" class = "buttonGrupos" style = "margin: 25px auto auto 20em;">Salir del grupo</button>
		</div>
    </form>
</body>
</html>
