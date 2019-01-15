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
    public partial class GestionarGrupo : System.Web.UI.Page
    {
        private string idGrupo;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["idGrupo"]))
            {
                idGrupo = Request.QueryString["idGrupo"];
                HiddenField1.Value = idGrupo;
            }
            else
            {
                Response.Write("<script>alert('Error al cargar el grupo, intente nuevamente!')</script>");
            }
        }

   
        public void btn_ModificarGrupo(object sender, EventArgs e)
        {
            if (validarModificacion())
            {
                if (validarNombreGrupo())
                {
                    if (ConexionBD.getInstance().actualizarGrupo(idGrupo, inputNombre.Text, Request["inputDescripcion"]))
                    {
                        Response.Write("<script>alert('Se ha actualizado el grupo correctamente!')</script>");
                        Response.Redirect("PaginaPrincipal.aspx", false);
                    }
                    else
                    {
                        Response.Write("<script>alert('No se ha podido crear el grupo.')</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Error, el nombre de grupo indicado ya existe en el sistema.')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('No se han hecho cambios en el grupo')</script>");
            }
             
        }

        private Boolean validarModificacion()
        {
            Grupo grupo = ClaseGlobal.getInstancia().getGrupoByID(idGrupo);
            if(inputNombre.Text == grupo.getNombre() && Request["inputDescripcion"] == grupo.getDescripcion())
            {  
                return false;
            }
            return true;
            
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
    }
}