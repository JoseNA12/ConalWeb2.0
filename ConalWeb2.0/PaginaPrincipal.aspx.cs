using ConalWeb2._0.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConalWeb2._0
{
    public partial class PaginaPrincipal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.Session[ClaseGlobal.sessionKey_usuarioCorreo] != null)
            {
                //si esta logeado
            }
            else
            {
                Response.Redirect("InicioSesion.aspx", false);
            }
        }

        public void btn_BuscarGrupos(object sender, EventArgs e)
        {
            Response.Redirect("BuscarGrupo.aspx", false);
        }
    }
}