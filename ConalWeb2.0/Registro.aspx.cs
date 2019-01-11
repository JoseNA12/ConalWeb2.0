using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConalWeb2._0.Modelo;
namespace ConalWeb2._0
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void btnCrearCuenta(object sender, EventArgs e)
        {
            if (ConexionBD.getInstance().registrarUsuario(inputUsuario.Text, inputContrasenia.Text, inputCorreo.Text, inputNombre.Text, inputApellidos.Text))
            {
                Response.Write("<script>alert('Usuario registrado')</script>");
            }
            else
            {
                Response.Write("<script>alert('Error, el usuario ingresado ya existe.')</script>");
            }
            
        }
    }
}