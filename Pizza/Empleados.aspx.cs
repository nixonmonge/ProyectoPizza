using System;
using Pizza.Dal;
using Pizza.Ef;
using Pizza.ServiceDal;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pizza
{
    public partial class Empleados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = EmpleadosDal.ListarPorNombre();
            GridView1.DataBind();
        }
    }
}