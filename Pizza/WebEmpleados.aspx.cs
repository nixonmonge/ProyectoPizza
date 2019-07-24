using System;
using Pizza.Dal;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pizza
{
    public partial class WebEmpleados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = EmpleadosDal.ListarTodo();
            GridView1.DataBind();

        }
    }
}