using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConalWeb2._0
{
    public partial class PublicarReunion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        public void btnPublicarReunion(object sender, EventArgs e)
        {
            string fuck = inputTitular.Text + Request.Form["inputMotivo"] + inputFecha.Text + inputHora.Text + Request.Form["inputUbicacion"];

            Response.Write("<script>alert('" + fuck + "')</script>");
        }
    }
}