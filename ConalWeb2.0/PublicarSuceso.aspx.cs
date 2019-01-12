using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConalWeb2._0.Modelo;

namespace ConalWeb2._0
{
    public partial class PublicarSuceso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPublicarSuceso(object sender, EventArgs e)
        {
            if (ConexionBD.getInstance().publicarSuceso(inputTitular.Text, Request.Form["inputDesc"], Request.Form["inputDescSospechosos"], inputFecha.Text, inputHora.Text, Request.Form["inputUbicacion"], "imgGPS", "josuarez", "1"))
            {
                Response.Write("<script>alert(' Suceso publicado con éxito ')</script>");
            }
            else
            {
                Response.Write("<script>alert(' Ha sucedido un error ')</script>");
            }
        }
    }
}