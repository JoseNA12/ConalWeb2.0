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

        }

        public void btnIniciarSesion(object sender, EventArgs e)
        {
            Usuario u = null;
            u = ConexionBD.getInstance().iniciarSesion(inputCorreo.Text, inputContrasenia.Text);

            if (u == null)
            {
                Response.Write("<script>alert(' error ')</script>");
            }
            else
            {
                Response.Write("<script>alert('" + u.getNombre() + "')</script>");
            }
            
        }
    }
}