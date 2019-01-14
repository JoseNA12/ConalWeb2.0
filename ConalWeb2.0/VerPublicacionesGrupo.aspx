<%@ Page Language="C#" MasterPageFile="Menu.Master" AutoEventWireup="true" CodeBehind="VerPublicacionesGrupo.aspx.cs" Inherits="ConalWeb2._0.VerPublicacionesGrupo" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
                <div id = "seccionSucesos" style="display: block;">
                    <asp:Table ID="tblSucesos" runat="server" Width="70%" Style="margin: auto; border:1;" CssClass="table-responsive marginToFooter" >
                    <asp:TableHeaderRow runat="server" CssClass="tableBorder">
                    </asp:TableHeaderRow>
                    </asp:Table>
                </div>

                <div id = "seccionReuniones" style="display: none;">
                    <asp:Table ID="tblReuniones" runat="server" Width="70%" Style="margin: auto; border:1;" CssClass="table-responsive marginToFooter" >
                    <asp:TableHeaderRow runat="server" CssClass="tableBorder">
                    </asp:TableHeaderRow>
                    </asp:Table>
                </div>
			</div>
		</div>
		<div id = "divButton">
			<button type="button" class = "buttonGrupos" style = "margin: 25px auto auto 9em;">Publicar reunión</button>
			<button type="button" class = "buttonGrupos" style = "margin: 25px auto auto 9em;">Publicar suceso</button>
			<button type="button" class = "buttonGrupos" style = "margin: 25px auto auto 20em;">Salir del grupo</button>
		</div>

     
</asp:Content>