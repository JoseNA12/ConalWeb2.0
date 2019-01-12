using ConalWeb2._0.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConalWeb2._0
{
    public partial class VerPerfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.Session[ClaseGlobal.sessionKey_usuarioCorreo] != null) // evitar saltarse el inicio de sesion
            {
                divNombre.Controls.Add(new LiteralControl("<center>" + HttpContext.Current.Session[ClaseGlobal.sessionKey_usuarioNombre] + " " +
                    HttpContext.Current.Session[ClaseGlobal.sessionKey_usuarioApellidos] + "</center>"));
                divUsuario.Controls.Add(new LiteralControl("<p>" + HttpContext.Current.Session[ClaseGlobal.sessionKey_usuarioNombreUsuario] + "</p>"));
                divEmail.Controls.Add(new LiteralControl("<p>" + HttpContext.Current.Session[ClaseGlobal.sessionKey_usuarioCorreo] + "</p>"));
                // si esta logeado
            }
            else
            {
                Response.Redirect("InicioSesion.aspx", false); // pa tras niño
            }
        }
    }
}