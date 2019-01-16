using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConalWeb2._0.Modelo;

namespace ConalWeb2._0
{
    public partial class VerPublicacionesGrupo : System.Web.UI.Page
    {
        private string idGrupo;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["new"] != null)
            {
                asociarUsuarioAlGrupo();
            }
            idGrupo = Request.QueryString["idGrupo"];
            llenarTablaReunion(Request.QueryString["idGrupo"]); // En Menu.Master.cs (llenarTabla()) se define el nombre de la variable de este Request
            llenarTablaSuceso(Request.QueryString["idGrupo"]);
            verificarAdministradorGrupo(Request.QueryString["idGrupo"]);
        }

        private void asociarUsuarioAlGrupo()
        {
            bool resultado = ConexionBD.getInstance().agregarMiembroGrupo(HttpContext.Current.Session[ClaseGlobal.sessionKey_usuarioNombreUsuario].ToString(), Request.QueryString["idGrupo"]);
            if (resultado)
            {
                ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "script", "mostrarMensaje('Bienvenido al grupo!');", true);
            }
            else
            {
                Response.Redirect("BuscarGrupo.aspx?return=true");
            }
        }

        protected void llenarTablaReunion(string pIdGrupo)
        {
            ArrayList reunionesTemp = ConexionBD.getInstance().selectReunionesGrupo(pIdGrupo);
            ClaseGlobal.getInstancia().setReuniones(reunionesTemp);
            //limpia la tabla para meter los nuevos valores
            tblReuniones.Rows.Clear();

            //comienza a crear la tabla
            TableRow row = new TableRow();
            TableCell campo = new TableCell();
            int x = 0;
            foreach (Reunion reunion in ClaseGlobal.getInstancia().getReuniones())
            {
                row = new TableRow();

                //AGREGA LA INFORMACION DEL EVENTO
                campo = new TableCell();
                campo.Text = "<b><h1>" + reunion.getTitular() + "</h1></b> " + "<br/>" +
                            "<b> Autor: </b>" + reunion.getNombreUsuario() + "<br/><br/>" +
                "<i> <a id='" + x + "' class='linkReunion' href='#'>Ingresar a publicación </a></i> <hr>";
           
                campo.Attributes.Add("Style", "width: 100%; height: 150px;");
                row.Cells.Add(campo);
                row.Attributes.Add("Style", "color: black; background-color: #C9D4E1");
                tblReuniones.Rows.Add(row);
                x++;
            }
        }

        protected void llenarTablaSuceso(string pIdGrupo)
        {
            ArrayList sucesosTemp = ConexionBD.getInstance().selectSucesosGrupo(pIdGrupo);
            ClaseGlobal.getInstancia().setSucesos(sucesosTemp);
            //limpia la tabla para meter los nuevos valores
            tblSucesos.Rows.Clear();
       
           
            //comienza a crear la tabla
            TableRow row = new TableRow();
            TableCell campo = new TableCell();
            int x = 0;
            foreach (Suceso suceso in ClaseGlobal.getInstancia().getSucesos())
            {

                row = new TableRow();

                //AGREGA LA INFORMACION DEL EVENTO
                campo = new TableCell();
                campo.Text = "<b><h1>" + suceso.getTitular() + "</h1></b> " + "<br/>" + "<b> Autor: </b>" + suceso.getNombreUsuario() + "<br/><br/>" +
                "<i> <a id='" + x + "' class='linkSuceso' href='#' >Ingresar a publicación </a> </i> <hr>";
                campo.Attributes.Add("Style", "width: 100%; height: 150px;");
                row.Cells.Add(campo);             
                row.Attributes.Add("Style", "color: black; background-color: #C9D4E1");
                tblSucesos.Rows.Add(row);
                x += 1;

            }
        }

        protected void verificarAdministradorGrupo(string pIdGrupo)
        {
            string usuarioActual = HttpContext.Current.Session[ClaseGlobal.sessionKey_usuarioNombreUsuario].ToString();

            // verificar si es admi del grupo
            bool soyAdmin = ClaseGlobal.getInstancia().esAdministrador(pIdGrupo, HttpContext.Current.Session[ClaseGlobal.sessionKey_usuarioNombreUsuario].ToString());

            if (soyAdmin)
            {
                divButton.Controls.Add(new LiteralControl("<button class='button2' type='button' onclick='goToGestionarGrupo(" + pIdGrupo + ")'>Administrar</button>"));
            }
            else
            {

            }
        }

        protected void eliminarMiembro(object sender, EventArgs e)
        {
            ConexionBD.getInstance().eliminarMiembroGrupo(HttpContext.Current.Session[ClaseGlobal.sessionKey_usuarioNombreUsuario].ToString(), Request.QueryString["idGrupo"]);
            Response.Redirect("PaginaPrincipal.aspx", false);
        }

        protected void goToPublicarReunion(object sender, EventArgs e)
        {
            Response.Redirect("PublicarReunion.aspx?idGrupo=" + Request.QueryString["idGrupo"], false);
        }

        protected void goToPublicarSuceso(object sender, EventArgs e)
        {
            Response.Redirect("PublicarSuceso.aspx?idGrupo=" + Request.QueryString["idGrupo"], false);
        }
    }
}