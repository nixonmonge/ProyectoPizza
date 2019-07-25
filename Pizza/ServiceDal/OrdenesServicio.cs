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
        public static Ordenes Factory(DropDownList txtIdPizza, DropDownList txtIdUsuario, TextBox txtCantidad)
        {
            var nuevaOrden = new Ordenes();
            nuevaOrden.IdPizza = Convert.ToInt32(txtIdPizza.Text);
            nuevaOrden.IdUsuario = Convert.ToInt32(txtIdUsuario.Text);
            nuevaOrden.Cantidad = Convert.ToInt32(txtCantidad.Text);            
            return nuevaOrden;
        }


    }
}