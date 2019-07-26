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
        public static Ordenes Factory(DropDownList txtIdPizza, DropDownList txtRutCliente, TextBox txtCantidad, object usuario)
        {
            var nuevaOrden = new Ordenes();            
            nuevaOrden.IdPizza = Convert.ToInt32(txtIdPizza.Text);
            nuevaOrden.RutCliente = txtRutCliente.Text;
            nuevaOrden.Cantidad = Convert.ToInt32(txtCantidad.Text);
            nuevaOrden.Fecha = Convert.ToDateTime(DateTime.Today);
            nuevaOrden.IdUsuario = Convert.ToInt32(usuario);
            
            return nuevaOrden;

        }
        
    }
}