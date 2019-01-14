using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConalWeb2._0.Modelo;
using Firebase.Auth;


using Firebase.Storage;

namespace ConalWeb2._0
{
    public partial class Registro : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            

        }


        public void btnCrearCuenta(object sender, EventArgs e)
        {
            if (!inputNombre.Text.Equals("") && !inputApellidos.Text.Equals("") && !inputCorreo.Text.Equals("") && !inputUsuario.Text.Equals("") && !inputContrasenia.Text.Equals(""))
            {
                if (ConexionBD.getInstance().validarUsuario(inputUsuario.Text))
                {
                    string nombreImgAGruardar;
                    if (FileUpload1.PostedFile != null && FileUpload1.HasFile)
                    {
                        nombreImgAGruardar = inputUsuario.Text + ".png";
                        FileUpload1.SaveAs(Server.MapPath("Files") + "//" + nombreImgAGruardar);
                        GuardarImgFireBase(nombreImgAGruardar);
                    }
                    else
                    {
                        nombreImgAGruardar = "usuarioDefault.png";
                    }

                    Boolean result = ConexionBD.getInstance().registrarUsuario(inputUsuario.Text, inputContrasenia.Text, inputCorreo.Text, inputNombre.Text, inputApellidos.Text, nombreImgAGruardar);
                    if (result)
                    {
                        ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "redirect", "mostrarMensaje('Se ha creado la cuenta correctamente.'); window.location='" + Request.ApplicationPath + "InicioSesion.aspx';", true);

                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "script", "mostrarMensaje('No se ha podido crear la cuenta.');", true);
                    }
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "script", "mostrarMensaje('Ya existe una cuenta con ese nombre de usuario.');", true);
                }
                
            }
            else
            {
                ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "script", "mostrarMensaje('Llene todas las casillas para completar el registro correctamente.');", true);
            }

        }

        public async System.Threading.Tasks.Task GuardarImgFireBase(String fileName)
        {
            var stream = File.Open(@"D:\ConalWEB2.0\ConalWeb2.0\ConalWeb2.0\Files\" + fileName, FileMode.Open);
            var task = new FirebaseStorage("conalweb2-0.appspot.com")
                .Child("ImgsPerfil")
                .Child(fileName)
                .PutAsync(stream);
            // Track progress of the upload
            task.Progress.ProgressChanged += (s, a) => Console.WriteLine($"Progress: {a.Percentage} %");
            var downloadUrl = await task;
        }

       
    }
}