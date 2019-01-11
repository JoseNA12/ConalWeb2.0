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
    public partial class BuscarGrupo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<script>alert(' Suceso publicado con éxito ')</script>");
            System.Diagnostics.Debug.WriteLine("parada 0");
            llenarTabla();
        }

        protected void llenarTabla()
        {
            ArrayList grupos = ConexionBD.getInstance().cargarGruposNoPertenece("josuarez");
            tblGruposNoPertenece.Rows.Clear();

            //comienza a crear la tabla
            TableRow row = new TableRow();
            TableCell campo = new TableCell();

            foreach (Grupo grupo in grupos)
            {

                row = new TableRow();
                //AGREGA EL NOMBRE DE GRUPO
                campo = new TableCell();
                campo.Text = "<b><h3>" + grupo.getNombre() + "</h3></b>";
                campo.Attributes.Add("Style", "width: 40%");
                row.Cells.Add(campo);

                //AGREGA EL BOTON
                Button button = new Button();
                button.Text = "Unirse";
                button.CssClass = "button button2 pos";
                button.Click += delegate
                {
                    Response.Write("<script> window.open('" + grupo.getNombre() + "','_blank'); </script>");

                };
                campo = new TableCell();
                campo.Controls.Add(button);
                campo.Attributes.Add("Style", "width: 20%; text-align: center;");
             //   row.Attributes.Add("Style", "background-color:white;");
                row.Cells.Add(campo);
                


                tblGruposNoPertenece.Rows.Add(row);
            }
        }

       
    }
}