using Pizza.ServiceDal;
using Pizza.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pizza
{
    public partial class IngresoCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var nuevoCliente = ClientesServicio.Factory(TextBoxRutCliente, TextBoxNombreCliente,TextBoxTelefonoCliente, TextBoxDireccionCliente);
            ClientesDal.Insertar(nuevoCliente);
            TextBoxRutCliente.Text = "";
            TextBoxNombreCliente.Text = "";
            TextBoxTelefonoCliente.Text = "";
            TextBoxDireccionCliente.Text = "";
        }
    }
}