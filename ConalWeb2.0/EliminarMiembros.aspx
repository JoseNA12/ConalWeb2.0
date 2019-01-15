<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarMiembros.aspx.cs" Inherits="ConalWeb2._0.EliminarMiembros" MasterPageFile="Menu.Master" %>


<%@ PreviousPageType VirtualPath="InicioSesion.aspx" %> 
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<meta name="viewport" content="width=device-width, initial-scale=1">
	<link type="text/css" rel="stylesheet" href="CSS/CSS_EliminarMiembro.css">
    <script>
        function mostrarMensaje(mensaje) {
            alert(mensaje);
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <div class="container" id="container1" style="color:#47525E">
            <h1 style="color: white">
                Gestionar grupo.
            </h1>
            <div class="container" id="container2">
                <h3 style="color:#47525E"> Eliminar integrante </h3>
                <p style="color:#47525E"> Seleccione el integrante que desea eliminar y presione el botón de eliminar integrante</p>

                <asp:Table ID="tablaIntegrantes" runat="server" Width="100%" CssClass="table-responsive marginToFooter" style="color:#47525E">
                    <asp:TableHeaderRow runat="server" CssClass="tableBorder">
                    </asp:TableHeaderRow>
                </asp:Table>


                <!--<br>
                <br>
                <br>

                <div id = "divButton" style="width:100%; text-align:center;">

                    <asp:Button ID="Button1" runat="server" Text="Cancelar" class = "buttonGrupos" style = " border-radius:4px;" />
                   
                </div>-->

            </div>
        </div>

</asp:Content>
