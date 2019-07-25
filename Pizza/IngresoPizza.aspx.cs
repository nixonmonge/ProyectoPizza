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
    public partial class IngresoPizza : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            var nuevaPizza = PizzasServicio.Factory(TextBoxTitulo, TextBoxPrecio, TextBoxImagen);
            PizzasDal.Insertar(nuevaPizza);
            TextBoxTitulo.Text = "";
            TextBoxPrecio.Text = "";
            TextBoxImagen.Text = "";

        }
    }
}