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

        }

        protected void ButtonIngresoOrden_Click(object sender, EventArgs e)
        {
            Response.Redirect("IngresoOrden.aspx");
        }
        protected void ButtonEmpleados_Click(object sender, EventArgs e)
        {
            Response.Redirect("Empleados.aspx");
        }
        protected void ButtonClientes_Click(object sender, EventArgs e)
        {
            Response.Redirect("Clientes.aspx");
        }
        protected void ButtonSalir_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("default.aspx");
        }
    }
}