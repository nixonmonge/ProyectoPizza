using Pizza.Dal;
using Pizza.ServiceDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pizza
{
    public partial class WebClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = ClientesDal.ListarClientes();
            GridView1.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("IngresoCliente.aspx");
        }
    }
}