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
    public partial class IngresoOrden : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownListPizza.DataSource = PizzasDal.ListaPizzasOrdenes();
            DropDownListPizza.DataBind();
            DropDownListClientes.DataSource = ClientesDal.ListaClientesOrdenes();
            DropDownListClientes.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*var nuevaOrden = OrdenesServicio.Factory(DropDownListPizza, DropDownListClientes, TextBoxCantidad);
            OrdenesDal.Insertar(nuevaOrden);
            DropDownListPizza.Text = "";
            DropDownListClientes.Text = "";
            TextBoxCantidad.Text = "";*/
            
        }
    }
}