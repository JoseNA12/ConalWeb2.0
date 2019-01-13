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

        function myFunction() {
            var input, filter, ul, li, a, i, txtValue;
            input = document.getElementById("myInput");
            filter = input.value.toUpperCase();
            ul = document.getElementById("myUL");
            li = ul.getElementsByTagName("li");
            for (i = 0; i < li.length; i++) {
                a = li[i].getElementsByTagName("a")[0];
                txtValue = a.textContent || a.innerText;
                if (txtValue.toUpperCase().indexOf(filter) > -1) {
                    li[i].style.display = "";
                } else {
                    li[i].style.display = "none";
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
                <input type="text" id="myInput" onkeyup="myFunction()" placeholder="Buscar por nombre.." title="Type in a name">


                <asp:Table ID="tblGruposNoPertenece" runat="server" Width="100%" CssClass="table-responsive marginToFooter" >
                    <asp:TableHeaderRow runat="server" CssClass="tableBorder">
                    </asp:TableHeaderRow>
                </asp:Table>
                <!--
                <ul id="myUL">
                  <li>
                      <p>
                        <a href="#">Adele 
                            <asp:Button class="button button2 pos" runat="server" Text="Unirse" />
                        </a>
                      </p>

                  </li>

                  <li><a href="#">Agnes</a></li>

                  <li><a href="#">Billy</a></li>
                  <li><a href="#">Bob</a></li>

                  <li><a href="#">Calvin</a></li>
                  <li><a href="#">Christina</a></li>
                  <li><a href="#">Cindy</a></li>
                </ul>
                <br />
                <br /> -->
                <p style="text-align:center;">
                    
                    <asp:Button class="button button2" runat="server" Text="Encontrar grupos" />
                </p>
                <br />
            </div>

        </div>
    </div>

</asp:Content>
