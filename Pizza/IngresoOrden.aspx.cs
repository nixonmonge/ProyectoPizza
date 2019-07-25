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
            
                var nuevoOrden = OrdenesServicio.Factory(DropDownListPizza, DropDownListClientes, TextBoxCantidad);

                nuevoOrden.IdPizza = Convert.ToInt32(DropDownListPizza.SelectedValue);
                nuevoOrden.RutCliente= DropDownListClientes.Text;
                nuevoOrden.Cantidad = Convert.ToInt32(TextBoxCantidad.Text);
            OrdenesDal.Insertar(nuevoOrden);                   
                                     
        }
    }
}