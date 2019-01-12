using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConalWeb2._0.Modelo;

namespace ConalWeb2._0
{
    public partial class VerPublicacionesGrupo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            llenarTablaReunion();
           
        }

        protected void llenarTablaReunion()
        {
            ArrayList reuniones = ConexionBD.getInstance().selectReunionesGrupo("1");
            //limpia la tabla para meter los nuevos valores
            tblReuniones.Rows.Clear();

            //comienza a crear la tabla
            TableRow row = new TableRow();
            TableCell campo = new TableCell();

            foreach (Reunion reunion in reuniones)
            {
                row = new TableRow();

                Response.Write("<script>alert(' " + reunion.getTitular() + reunion.getUbicacion() + " ')</script>");
                //AGREGA LA INFORMACION DEL EVENTO
                campo = new TableCell();
                campo.Text = "<b><h3>" + reunion.getTitular() + "</h3></b> " + reunion.getUbicacion() + "<br/>" +
                    "<i>" + reunion.getNombreUsuario() + " " + reunion.getFecha() + " " + reunion.getHora() + "</i><br/><br/>" +
                    "<b>Descripción: </b>" + reunion.getDescripcion();
                
                campo.Attributes.Add("Style", "width: 80%; height: 300px;");
                row.Cells.Add(campo);

                //AGREGA EL BOTON
                Button button = new Button();
                button.Text = "Ver mapa";
                button.CssClass = "btn btn-default botonCelda";
                button.Click += delegate
                {
                    Response.Write("<script> window.open('prueba','_blank'); </script>");
                };

                campo = new TableCell();
                campo.Controls.Add(button);
                row.Cells.Add(campo);
                row.Attributes.Add("Style","background-color: black");
                tblReuniones.Rows.Add(row);

            }
        }
    }
}