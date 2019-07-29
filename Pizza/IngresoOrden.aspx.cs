using Pizza.Dal;
using Pizza.Ef;
using Pizza.ServiceDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pizza
{
    public partial class IngresoOrden : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownListPizza.DataSource = PizzasDal.ListaPizzasOrdenes();
                DropDownListPizza.DataBind();
                DropDownListClientes.DataSource = ClientesDal.ListaClientesOrdenes();
                DropDownListClientes.DataBind();

            }
            else
            {
                Panel1.DataBind();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            DropDownListPizza.Text = DropDownListPizza.SelectedItem.Value;
            DropDownListClientes.Text = DropDownListClientes.SelectedItem.Value;
            Empleados userLogin = (Empleados)Session["usuario"];
            object usuario = userLogin.IdUsuario;
            var nuevoOrden = OrdenesServicio.Factory(DropDownListPizza, DropDownListClientes, TextBoxCantidad, usuario);
            OrdenesDal.Insertar(nuevoOrden);
        }

    }
}