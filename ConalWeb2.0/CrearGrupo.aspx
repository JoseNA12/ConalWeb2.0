<%@ Page Language="C#" MasterPageFile="Menu.Master" AutoEventWireup="true" CodeBehind="CrearGrupo.aspx.cs" Inherits="ConalWeb2._0.CrearGrupo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

	<link rel="stylesheet" href="CSS/CSS_CrearGrupo.css">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main">
        <div class="container" id="container1">
            <h1>
                Crear Grupo
            </h1>
            <div class="container" id="container2">
                <div class="tab">
                    <label id="idPrueba" for="nombre">Nombre</label>
                    <p><asp:TextBox runat="server" id="inputNombre" placeholder="Nombre del grupo" oninput="this.className = ''" name="titular"/></p>
                    <label for="subject">Descripción</label>
                    <p><Textarea id="inputDescripcion" rows="4" cols="50" name="inputDescripcion" placeholder="Descripción del grupo.."></Textarea></p>

                    <br>
                    <br>                    
                </div><br><br>
                <div class="tab" id="idButtonCrearGp">
                    <asp:Button class="btnCrearGrupo" name="btnCrearGp" runat="server" Text="Crear Grupo"  OnClick="btn_CrearGrupo" />
                </div>                               
            </div>
        </div>
    </div>

    <script>
        var dropdown = document.getElementsByClassName("dropdown-btn");
        var i;

        for (i = 0; i < dropdown.length; i++) {
          dropdown[i].addEventListener("click", function() {
          this.classList.toggle("active");
          var dropdownContent = this.nextElementSibling;
          if (dropdownContent.style.display === "block") {
          dropdownContent.style.display = "none";
          } else {
          dropdownContent.style.display = "block";
          }
          });
        }

    </script>
</asp:Content>