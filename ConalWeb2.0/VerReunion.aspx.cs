using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConalWeb2._0.Modelo;

namespace ConalWeb2._0
{
    public partial class VerReunion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["id"]))
            {
                int i = Int32.Parse(Request.QueryString["id"]);
                Reunion prueba = (Reunion)ClaseGlobal.getInstancia().getReuniones()[i];
                titularReunion.Text += ": " + prueba.getTitular();
                fechaReunion.Text += ": " + prueba.getFecha();
                horaReunion.Text += ": " + prueba.getHora();
                descripcionReunion.Text = prueba.getDescripcion();
                ubicacionReunion.Text = prueba.getUbicacion();
            }
            else
            {
                Response.Write("<script>alert('no funca')</script>");
            }
        }
    }
}