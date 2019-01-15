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
    public partial class BuscarGrupo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["return"]!=null)
            {
                ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "script", "mostrarMensaje('No ha sido posible unirse al grupo.');", true);
            }
            llenarTabla();
        }

        protected void llenarTabla()
        {
            ArrayList grupos = ConexionBD.getInstance().cargarGruposNoPertenece(HttpContext.Current.Session[ClaseGlobal.sessionKey_usuarioNombreUsuario].ToString());
            tblGruposNoPertenece.Rows.Clear();

            //comienza a crear la tabla
            TableRow row = new TableRow();
            TableCell campo = new TableCell();

            foreach (Grupo grupo in grupos)
            {

                row = new TableRow();
                //AGREGA EL NOMBRE DE GRUPO
                campo = new TableCell();
                campo.Text = "<b><h3>" + grupo.getNombre() + "</h3></b>";
                campo.Attributes.Add("Style", "width: 40%");
                campo.Attributes.Add("Style", "color: #47525E");
                row.Cells.Add(campo);

                //AGREGA EL BOTON
                Button button = new Button();
                button.ID = grupo.getIdGrupo();
                button.Text = "Unirse";
                button.CssClass = "button button2 pos";
                button.Click += delegate
                {
                    Response.Redirect("VerPublicacionesGrupo.aspx?idGrupo="+grupo.getIdGrupo()+"&new=true");                   
                };
                campo = new TableCell();
                campo.Controls.Add(button);
                campo.Attributes.Add("Style", "width: 20%; text-align: center;");
             //   row.Attributes.Add("Style", "background-color:white;");
                row.Cells.Add(campo);
                


                tblGruposNoPertenece.Rows.Add(row);
            }
        }
 
    }
}