using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConalWeb2._0.Modelo;
namespace ConalWeb2._0
{
    public partial class PublicarReunion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        public void btnPublicarReunion(object sender, EventArgs e)
        {
            if(ConexionBD.getInstance().publicarReunion(inputTitular.Text, Request.Form["inputMotivo"], inputFecha.Text, inputHora.Text, Request.Form["inputUbicacion"], "josuarez", "1"))
            {
                Response.Write("<script>alert(' Reunión publicada con éxito ')</script>");
            }
            else
            {
                Response.Write("<script>alert(' Ha sucedido un error ')</script>");
            }
        }
    }
}