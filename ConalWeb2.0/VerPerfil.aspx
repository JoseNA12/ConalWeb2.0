<%@ Page Language="C#" MasterPageFile="Menu.Master" AutoEventWireup="true" CodeBehind="VerPerfil.aspx.cs" Inherits="ConalWeb2._0.VerPerfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

	<link rel="stylesheet" href="CSS/CSS_VerPerfil.css">


</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main">
        <div class="container" id="container1">
            <h1>Perfil</h1>
            <div class="container" id="container2">
                <img id="imgPerfil1" src="IMGs/img_girl.jpg" alt="Girl in a jacket"><br>

                <div id="divNombre" runat="server">
                    
                </div>
                <br>
                <center>
                    <h4>Nombre de usuario:</h4>
                    <div id="divUsuario" runat="server">
                    
                    </div>

                    <h4>Correo electrónico:</h4>
                    <div id="divEmail" runat="server">
                    
                    </div>
                </center>
            </div>
        </div>
    </div>

</asp:Content>
