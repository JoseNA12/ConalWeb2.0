<%@ Page Language="C#" MasterPageFile="Menu.Master" AutoEventWireup="true" CodeBehind="VerPerfil.aspx.cs" Inherits="ConalWeb2._0.VerPerfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

	<link rel="stylesheet" href="CSS/CSS_VerPerfil.css">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main">
        <div class="container" id="container1">
            <h1>
                            Perfil
            </h1>
            <div class="container" id="container2">
                <img id="imgPerfil1" src="IMGs/img_girl.jpg" alt="Girl in a jacket"><br>
                <center>Juana de Arco</center>
                <h3>Biografía:</h3>
                <p>Tiene un tata y una mama y nació en el hospital</p>
                <h3>Lugar de residencia:</h3>
                <p>Tiene una chospi de aquellas</p>
            </div>
        </div>
    </div>

</asp:Content>
