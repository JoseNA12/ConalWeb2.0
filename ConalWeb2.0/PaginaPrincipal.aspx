<%@ Page Language="C#" MasterPageFile="Menu.Master" AutoEventWireup="true" CodeBehind="PaginaPrincipal.aspx.cs" Inherits="ConalWeb2._0.PaginaPrincipal" %>

<%@ PreviousPageType VirtualPath="InicioSesion.aspx" %> 
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- script para estilos específicos del view -->
    <link rel="stylesheet" href="CSS/CSS_PaginaPrincipal.css">

    <style>
        #fuente{
            color: #47525E;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="main">
		<div class="container" id="container1">
			<h1>Pagina inicial -  ConalWeb</h1>
			<div class="container" id="container2">
			    <h2 id="fuente">Comunidades ante el hampa</h2>
                <h4 id="fuente">¡Bienvenid@ a Conal Web 2.0!</h4>
                <h4 id="fuente">Somos una comunidad sin fines de lucro, con el fin de combatir el hampa o cualquier otra actividad
                    que ponga en peligro la vida de las personas. Además, tambien fomentamos la comunicacíón de las personas por
                    medio de reuniones en los distintos grupos que conforman la comunidad.
                </h4>
                <p style="text-align:center;">
                    <img src="img/policeman.png" alt="policeman" style="height: 187px; width: 170px" /> 
                    <br /><br />
                    <asp:Button class="button button2" runat="server" Text="Encontrar grupos" />
                </p>
                <br />
            </div>
		</div>
	</div>
</asp:Content>