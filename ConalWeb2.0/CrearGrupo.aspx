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
                <form id="crearGrupoForm"  method="post" enctype="multipart/form-data">
                    <div class="tab">
                        <label for="nombre">Nombre</label>
                        <p><input placeholder="Nombre del grupo" oninput="this.className = ''" name="titular"></p>
                        <label for="subject">Descripción</label>
                        <p><textarea rows="4" cols="50" name="descripcionGrupo" form="crearGrupoForm" placeholder="Descripción del grupo.."></textarea></p>
                        <br>
                        <label for="subject">Imagen</label>
                        <input type="file" name="image" id="inputImg" />
                        <br>
                        <br>                    
                    </div><br><br>
                    <div class="tab" id="idButtonCrearGp">
                        <button id="btnCrearGp" style="display:block;width:120px; height:30px;" onclick="validateForm()" >Crear grupo</button>
                        <input type="submit" value="Submit" name="sumit" id="btnCrearGrupo" style="display:none" />
                    </div>               
                </form>
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