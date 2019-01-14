<%@ Page Language="C#" MasterPageFile="Menu.Master" AutoEventWireup="true" CodeBehind="VerPublicacionesGrupo.aspx.cs" Inherits="ConalWeb2._0.VerPublicacionesGrupo" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <link type="text/css" rel="stylesheet" href="CSS/CSS_VerPublicacionesGrupo.css">

    
    
    <style>
        .modal-contenido{
            font-family: Arial, Helvetica, sans-serif;
            background-color: #2B456C;
            color: white;
            width: 70%;
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
                window.location.href='VerSuceso.aspx?id='+ $(this).attr('id');               
			});
        });

	</script>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

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

     
</asp:Content>