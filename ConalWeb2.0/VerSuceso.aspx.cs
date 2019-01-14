using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConalWeb2._0.Modelo;

namespace ConalWeb2._0
{
    public partial class VerSuceso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["id"]))
            {
                int i = Int32.Parse(Request.QueryString["id"]);
                Suceso prueba = (Suceso) ClaseGlobal.getInstancia().getSucesos()[i];
                titularSuceso.Text = prueba.getTitular();
                fechaSuceso.Text = prueba.getFecha();
                horaSuceso.Text = prueba.getHora();
                descripcionSuceso.Text = prueba.getDescripcion();
                sospechosoSuceso.Text = prueba.getSospechosos();
                ubicacionSuceso.Text = prueba.getUbicacion();
            }
            else
            {
                Response.Write("<script>alert('no funca')</script>");
            }
        }
    }
}