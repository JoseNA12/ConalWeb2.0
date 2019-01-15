using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConalWeb2._0.Modelo;

namespace ConalWeb2._0
{
    public partial class EliminarMiembros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["idMiembro"]!=null)
            {
                if (ConexionBD.getInstance().eliminarMiembroGrupo(Request.QueryString["idMiembro"], Request.QueryString["idGrupo"]))
                {
                    ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "script", "mostrarMensaje('Se ha eliminado el integrante seleccionado exitosamente!');", true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "script", "mostrarMensaje('No se ha podido eliminat el integrante del grupo seleccionado.');", true);
                }
            }

            llenarTablaIntegrantes();
        }

        private void llenarTablaIntegrantes()
        {
            ArrayList integrantesGrupo = ConexionBD.getInstance().selectMiembrosGrupo(Request.QueryString["idGrupo"]);
            tablaIntegrantes.Rows.Clear();

            TableRow row = new TableRow();
            TableCell campo = new TableCell();

            foreach (Usuario integrante in integrantesGrupo)
            {
                if (!integrante.getIdUsuario().Equals(HttpContext.Current.Session[ClaseGlobal.sessionKey_usuarioNombreUsuario].ToString()))
                {
                    row = new TableRow();
                    campo = new TableCell();
                    campo.Text = "<b><h3>" + integrante.getNombre() + " " + integrante.getApellidos() + "</h3></b>";
                    campo.Attributes.Add("Style", "width: 40%");
                    campo.Attributes.Add("Style", "color: #47525E");
                    row.Cells.Add(campo);

                    //Se agrega boton de eliminar integrante

                    Button btn_eliminarIntegrante = new Button();
                    btn_eliminarIntegrante.ID = integrante.getIdUsuario();
                    btn_eliminarIntegrante.Text = "Eliminar integrante";
                    btn_eliminarIntegrante.CssClass = "buttonEliminar";

                    // Estilo del boton

                    btn_eliminarIntegrante.Style.Add("background-color", "#2B456C;");
                    btn_eliminarIntegrante.Style.Add("color", "white");
                    btn_eliminarIntegrante.Style.Add("border", "none");
                    btn_eliminarIntegrante.Style.Add("padding", "15px 32px");
                    btn_eliminarIntegrante.Style.Add("cursor", "pointer");

                    btn_eliminarIntegrante.Click += delegate
                    {
                        Response.Redirect("EliminarMiembros.aspx?idMiembro=" + integrante.getIdUsuario() + "&idGrupo=" + Request.QueryString["idGrupo"]);
                    };
                    campo = new TableCell();
                    campo.Controls.Add(btn_eliminarIntegrante);
                    campo.Attributes.Add("Style", "width: 20%; text-align: center;");
                    row.Cells.Add(campo);


                    tablaIntegrantes.Rows.Add(row);
                }
                
            }


        }
    }
}