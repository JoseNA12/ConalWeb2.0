<%@ Page Language="C#" MasterPageFile="Menu.Master" AutoEventWireup="true" CodeBehind="VerPerfil.aspx.cs" Inherits="ConalWeb2._0.VerPerfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

	<link rel="stylesheet" href="CSS/CSS_VerPerfil.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script>
        $().ready(function () {
            var config =
            {
                apiKey: "AIzaSyDvI37M59STMIy3dXBFIbZeECa_jPmn3yE",
                authDomain: "conalweb2-0.firebaseapp.com",
                databaseURL: "https://conalweb2-0.firebaseio.com",
                storageBucket: "conalweb2-0.appspot.com",
            };
                
            firebase.initializeApp(config);
            var storage = firebase.storage();
            var storageRef = storage.ref();
            var tangRef = storageRef.child('ImgsPerfil/' + '<%=HttpContext.Current.Session["USUARIO_ACTUAL_IMAGEN_PERFIL"] %>');
            tangRef.getDownloadURL().then(function (url) {
                var test = url;
                $("#imgPerfil1").attr("src", test);
            }).catch(function (error) {
                switch (error.code) {
                    case 'storage/object_not_found':
                        break;

                    case 'storage/unauthorized':
                        break;

                    case 'storage/canceled':
                        break;

                    case 'storage/unknown':
                        break;
                }
            });
        });
        </script>
    <div class="main">
        <div class="container" id="container1">
            <h1>Perfil</h1>
            <div class="container" id="container2">
                <img id="imgPerfil1" ><br>

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
                    <br>
                </center>
            </div>
        </div>
    </div>
    
</asp:Content>
