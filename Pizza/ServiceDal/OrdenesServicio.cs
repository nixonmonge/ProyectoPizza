using Pizza.Ef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Pizza.ServiceDal
{
    public class OrdenesServicio
    {
        public static Ordenes Factory(TextBox txtIdOrden, TextBox txtIdPizza, TextBox txtFecha, TextBox txtCantidad, TextBox txtIdUsuario)
        {
            var nuevaOrden = new Ordenes();
            nuevaOrden.IdOrden = Convert.ToInt32(txtIdOrden.Text);
            nuevaOrden.IdPizza = Convert.ToInt32(txtIdPizza.Text);
            nuevaOrden.Fecha = Convert.ToDateTime(txtFecha.Text);
            nuevaOrden.Cantidad = Convert.ToInt32(txtCantidad.Text);
            nuevaOrden.IdUsuario = Convert.ToInt32(txtIdUsuario.Text);
            return nuevaOrden;
        }
    }
}