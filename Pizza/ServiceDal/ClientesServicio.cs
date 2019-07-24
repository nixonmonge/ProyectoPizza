using Pizza.Ef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Pizza.ServiceDal
{
    public class ClientesServicio
    {
        public static Clientes Factory(TextBox txtRutCliente, TextBox txtNombre, TextBox txtTelefono, TextBox txtDireccion)
        {
            var nuevoCliente = new Clientes();
            nuevoCliente.RutCliente = txtRutCliente.Text;
            nuevoCliente.Nombre = txtNombre.Text;
            nuevoCliente.Telefono = Convert.ToInt32(txtTelefono.Text);
            nuevoCliente.Direccion = txtDireccion.Text;

            return nuevoCliente;
        }
    }
}