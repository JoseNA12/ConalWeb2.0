using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConalWeb2._0.Modelo;



namespace ConalWeb2._0
{
    public partial class InicioSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpContext.Current.Session.RemoveAll(); // importante para el iniciar y cerrar sesión
        }

        public void btnIniciarSesion(object sender, EventArgs e)
        {
            Usuario u = ConexionBD.getInstance().iniciarSesion(inputCorreo.Text, inputContrasenia.Text);

            if (u == null)
            {
                Response.Write("<script>alert(' error ')</script>");
            }
            else
            {
                HttpContext.Current.Session.Add(ClaseGlobal.sessionKey_usuarioNombre, u.getNombre());
                HttpContext.Current.Session.Add(ClaseGlobal.sessionKey_usuarioApellidos, u.getApellidos());
                HttpContext.Current.Session.Add(ClaseGlobal.sessionKey_usuarioNombreUsuario, u.getIdUsuario());
                HttpContext.Current.Session.Add(ClaseGlobal.sessionKey_usuarioCorreo, u.getCorreo());
                Response.Redirect("PaginaPrincipal.aspx", false);
                //Response.Write("<script>alert('" + u.getNombre() + "')</script>");

          
            }
            
        }
    }
}