using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConalWeb2._0
{
    public partial class InicioSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void btnIniciarSesion(object sender, EventArgs e)
        {
            string fuck = inputCorreo.Text + inputContrasenia.Text;
            Response.Write("<script>alert('" + fuck + "')</script>");
        }
    }
}