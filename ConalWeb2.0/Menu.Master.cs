using ConalWeb2._0.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConalWeb2._0
{
    public partial class Menu : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            llenarTabla();
        }

        protected void llenarTabla()
        {
            string usuarioActual = (string)HttpContext.Current.Session[ClaseGlobal.sessionKey_usuarioNombreUsuario];
            ArrayList grupos = ConexionBD.getInstance().cargarGruposPertenece(usuarioActual);
            ClaseGlobal.getInstancia().setGruposMiembro(grupos);
            //tblMenu.Rows.Clear();

            //comienza a crear la tabla
            //TableRow row = new TableRow();
            //TableCell campo = new TableCell();

            if (tblMenu != null)
            {
                foreach (Grupo grupo in grupos)
                {
                    divMisGrupos.Controls.Add(new LiteralControl("<a id='" + grupo.getIdGrupo() + "' class='link' >" + grupo.getNombre() + "</a>"));
                }
            }
        }
    }
}