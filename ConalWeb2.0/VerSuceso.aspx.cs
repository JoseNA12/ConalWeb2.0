using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConalWeb2._0
{
    public partial class VerSuceso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["IDSuceso"]))
            {
                Response.Write("<script>alert('prueba " + Request.QueryString["IDSuceso"] + "')</script>");
            }
            else
            {
                Response.Write("<script>alert('no funca')</script>");
            }
        }
    }
}