using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConalWeb2._0
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void btnCrearCuenta(object sender, EventArgs e)
        {
            string fuck = inputNombre.Text + inputApellidos.Text + inputCorreo.Text + inputContrasenia.Text;
            Response.Write("<script>alert('este es mi string" + fuck + "')</script>");
        }
    }
}