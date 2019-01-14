using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConalWeb2._0.Modelo;

namespace ConalWeb2._0
{
    public partial class VerPublicacionesGrupo : System.Web.UI.Page
    {
        public String pruebaVar = "'hola'";
        public ArrayList sucesos;

        protected void Page_Load(object sender, EventArgs e)
        {
            llenarTablaReunion();
            llenarTablaSuceso();
           
        }

        protected void llenarTablaReunion()
        {
            ArrayList reuniones = ConexionBD.getInstance().selectReunionesGrupo("1");
            //limpia la tabla para meter los nuevos valores
            tblReuniones.Rows.Clear();

            //comienza a crear la tabla
            TableRow row = new TableRow();
            TableCell campo = new TableCell();
            int x = 0;
            foreach (Reunion reunion in reuniones)
            {
                row = new TableRow();

                //AGREGA LA INFORMACION DEL EVENTO
                campo = new TableCell();
                campo.Text = "<b><h1>" + reunion.getTitular() + "</h1></b> " + "<br/>" +
                               "<b> Autor: </b>" + reunion.getNombreUsuario() + "<br/><br/>" +
                "<i> <a id='" + x + "' class='link' href='#miModal'>Ingresar a publicación </a></i>";
           
                campo.Attributes.Add("Style", "width: 100%; height: 150px;");
                row.Cells.Add(campo);
                row.Attributes.Add("Style", "color: black; background-color: #C9D4E1");
                tblReuniones.Rows.Add(row);
                x++;
            }
        }

        protected void llenarTablaSuceso()
        {
            ArrayList sucesos = ConexionBD.getInstance().selectSucesosGrupo("1");
            //limpia la tabla para meter los nuevos valores
            tblSucesos.Rows.Clear();
       
           
            //comienza a crear la tabla
            TableRow row = new TableRow();
            TableCell campo = new TableCell();
            int x = 0;
            foreach (Suceso suceso in sucesos)
            {

                row = new TableRow();

                //AGREGA LA INFORMACION DEL EVENTO
                campo = new TableCell();
                campo.Text = "<b><h1>" + suceso.getTitular() + "</h1></b> " + "<br/>" +
                               "<b> Autor: </b>" + suceso.getNombreUsuario() + "<br/><br/>" +
                "<i> <a id='" + x + "' class='link' href='#miModal'>Ingresar a publicación </a> </i>";
                campo.Attributes.Add("Style", "width: 100%; height: 150px;");
                row.Cells.Add(campo);
                Response.Write("<script>alert('pasando el id " + x + "')</script>");
                Button button = new Button();
                button.Text = "Ver mapa";
                button.CssClass = "btn btn-default botonCelda";
                button.Click += delegate
                {
                    Response.Redirect("VerSuceso.aspx?IDSuceso=" + x);
                    //HttpContext.Current.Session.Add(ClaseGlobal.sessionKey_usuarioNombre, u.getNombre());
                };
                campo = new TableCell();
                campo.Controls.Add(button);
                row.Cells.Add(campo);
                row.Attributes.Add("Style", "color: black; background-color: #C9D4E1");
                tblSucesos.Rows.Add(row);
                x += 1;

            }
        }
        protected void verSuceso()
        {
      
            string x = Labelprueba.Text.ToString();
            titularSuceso.Text = x;
            Response.Write("alert('paso 4: "+x+"')");
        }

        protected void prueba()
        {
            Response.Write("alert('paso ?: "+ Labelprueba.Text.ToString() + "')");
        }

        
    }
}