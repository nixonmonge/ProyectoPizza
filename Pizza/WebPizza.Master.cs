using Pizza.Ef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pizza
{
    public partial class WebPizza : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Empleados usuario = (Empleados)Session["usuario"];
            string logout = Request.QueryString["logout"];
            if (logout != null)
            {
                Session.Abandon();
                usuario = null;
            }

            // si el usuario no esta, redireccionar a la pagina de login
            if (usuario == null)
            {
                Response.Redirect("default.aspx", true);
            }
            else
            {
                // si el usuario esta, lo muestro en el objeto literal.
                Literal1.Text = usuario.NombreCompleto;

            }

        }

        protected void ButtonIngresoOrden_Click(object sender, EventArgs e)
        {
            Response.Redirect("IngresoOrden.aspx");
        }
        protected void ButtonEmpleados_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebEmpleados.aspx");
        }
        protected void ButtonClientes_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebClientes.aspx");
        }
        protected void ButtonPizzas_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebPizzas.aspx");
        }
        protected void ButtonSalir_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("default.aspx");
        }
    }
}