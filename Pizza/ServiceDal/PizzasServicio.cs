using Pizza.Ef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Pizza.ServiceDal
{
    public class PizzasServicio
    {
        public static Pizzas Factory(TextBox txtIdPizza, TextBox txtTitulo, TextBox txtPrecio, TextBox txtImagen)
        {
            var nuevoPizza = new Pizzas();
            nuevoPizza.IdPizza = Convert.ToInt32(txtIdPizza.Text);
            nuevoPizza.Titulo = txtTitulo.Text;
            nuevoPizza.Precio = Convert.ToInt32(txtPrecio.Text);
            nuevoPizza.Imagen = txtImagen.Text;   

            return nuevoPizza;
        }
    }
}