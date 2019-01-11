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

   

        /*protected void btnCrearGrupo_Click(object sender, EventArgs e)
        {
            if (ConexionBD.getInstance.iniciarSesion(usuario, contrasena))
            {
                Response.Redirect("frmBoletines.aspx", false);
            }
            else
            {
                Response.Write("<script>alert('Nombre de usuario o contrasena incorrecta.')</script>");
            }
        }*/

        public void pruebajeje(object sender, EventArgs e)
        {
            Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Hello this is an Alert')</SCRIPT>");
        }

        protected void UploadFile(object sender, EventArgs e)
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
        }

    }
}