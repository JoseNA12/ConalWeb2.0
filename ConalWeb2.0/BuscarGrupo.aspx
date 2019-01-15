<%@ Page Language="C#" MasterPageFile="Menu.Master" AutoEventWireup="true" CodeBehind="BuscarGrupo.aspx.cs" Inherits="ConalWeb2._0.BuscarGrupo" %>

<%@ PreviousPageType VirtualPath="InicioSesion.aspx" %> 
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- script para estilos específicos del view -->
    <link rel="stylesheet" href="CSS/CSS_BuscarGrupo.css">


    <style>
        #fuente{
            color: #47525E;
        }

        .pos{
            margin-left: 83%;
        }
    </style>

    <script>

        function mostrarMensaje(mensaje) {
            alert(mensaje);
        }

        function filtrarGrupos() {
          var input, filter, table, tr, td, i, txtValue;
          input = document.getElementById("myInput");
          filter = input.value.toUpperCase();
          table = document.getElementById("ContentPlaceHolder1_tblGruposNoPertenece");
          tr = table.getElementsByTagName("tr");

          for (i = 0; i < tr.length; i++) {
            td = tr[i].getElementsByTagName("td")[0];
            if (td) {
              txtValue = td.textContent || td.innerText;
              if (txtValue.toUpperCase().indexOf(filter) > -1) {
                tr[i].style.display = "";
              } else {
                tr[i].style.display = "none";
              }
            }       
          }
        }

    </script>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="main">
		<div class="container" id="container1">
            <h1>Buscar grupos</h1>
			<div class="container" id="container2">
                <input type="text" id="myInput" onkeyup="filtrarGrupos()" placeholder="Buscar por nombre..." title="Type in a name">


                <asp:Table ID="tblGruposNoPertenece" runat="server" Width="100%" CssClass="table-responsive marginToFooter" >
                    <asp:TableHeaderRow runat="server" CssClass="tableBorder">
                    </asp:TableHeaderRow>
                </asp:Table>
                <p style="text-align:center;">
                    
                    <asp:Button class="button button2" runat="server" Text="Encontrar grupos" />
                </p>
                <br />
            </div>

        </div>
    </div>

</asp:Content>
