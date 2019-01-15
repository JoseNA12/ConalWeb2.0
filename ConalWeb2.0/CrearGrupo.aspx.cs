using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using ConalWeb2._0.Modelo;

namespace ConalWeb2._0
{
    public partial class CrearGrupo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

   
        public void btn_CrearGrupo(object sender, EventArgs e)
        {
            if (validarNombreGrupo())
            {
                string usuario = HttpContext.Current.Session[ClaseGlobal.sessionKey_usuarioNombreUsuario].ToString();
                Boolean creacionGrupo = ConexionBD.getInstance().crearGrupo(usuario, inputNombre.Text, Request["inputDescripcion"]);
                if (creacionGrupo)
                {
                    ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "redirect", "mostrarMensaje('Se ha creado el grupo "+inputNombre.Text+"'); window.location='" + Request.ApplicationPath + "PaginaPrincipal.aspx';", true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "script", "mostrarMensaje('No se ha podido crear el grupo.');", true);
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "script", "mostrarMensaje('Ya existe un grupo con el nombre que ha indicado.');", true);
            }
             
        }

        private Boolean validarNombreGrupo()
        {
            Boolean validarNombreGp = ConexionBD.getInstance().validarGrupo(inputNombre.Text);
            if (validarNombreGp)
            {
                return true;
            }
            return false;
        }
        

        /*protected void UploadFile(object sender, EventArgs e)
        {
            string folderPath = Server.MapPath("~/Files/");

            //Check whether Directory (Folder) exists.
            if (!Directory.Exists(folderPath))
            {
                //If Directory (Folder) does not exists Create it.
                Directory.CreateDirectory(folderPath);
            }

            //Save the File to the Directory (Folder).
            FileUpload1.SaveAs(folderPath + Path.GetFileName(FileUpload1.FileName));

            //Display the Picture in Image control.
            Image1.ImageUrl = "~/Files/" + Path.GetFileName(FileUpload1.FileName);
        }*/

    }
}