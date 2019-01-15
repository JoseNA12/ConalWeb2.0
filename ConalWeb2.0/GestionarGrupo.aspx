﻿<%@ Page Language="C#" MasterPageFile="Menu.Master" AutoEventWireup="true" CodeBehind="GestionarGrupo.aspx.cs" Inherits="ConalWeb2._0.GestionarGrupo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

	<link rel="stylesheet" href="CSS/CSS_CrearGrupo.css">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main">
        <div class="container" id="container1">
            <h1>
                Gestionar Grupo
            </h1>
            <div class="container" id="container2">
                <div class="tab">
                    <label id="idPrueba" for="nombre">Nombre</label>
                    <p><asp:TextBox runat="server" id="inputNombre" placeholder="Nombre del grupo" oninput="this.className = ''" name="titular"/></p>
                    <label for="subject">Descripción</label>
                    <p><Textarea id="inputDescripcion" rows="4" cols="50" name="inputDescripcion" placeholder="Descripción del grupo.."></Textarea></p>

                    <br>
                    <br>                    
                </div><br>
                <div class="tab" id="idButtonCrearGp">
                    <asp:Button class="btnCrearGrupo" name="btnCrearGp" runat="server" Text="Modificar Grupo"  OnClick="btn_ModificarGrupo" />
                    <button type="button" class="btnCrearGrupo" id ="btnEliminarMiembros">Eliminar miembros</button>
                </div>                               
            </div>
        </div>
    </div>
    <asp:HiddenField ID="HiddenField1" runat="server" />  
    <script>
       $(function() {
            $('.btnEliminarMiembros').click(function (e) {
                window.location.href='EliminarMiembros.aspx?id='+ $(HiddenField1).attr('Value');               
			});
        });

    </script>
</asp:Content>