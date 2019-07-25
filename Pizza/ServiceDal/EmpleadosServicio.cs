using System;
using Pizza.Ef;
using Pizza.ServiceDal;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Pizza.ServiceDal
{
    public class EmpleadosServicio
    {
        public static Empleados FactoryLogin(TextBox txtUsuario, TextBox txtClave)
        {
            var usuario = new Empleados();
            usuario.Usuario = txtUsuario.Text;
            usuario.Clave = txtClave.Text;
            return usuario;
        }
        public static Empleados FactoryAddUser(TextBox txtUsuario, TextBox txtClave, TextBox txtNombreCompleto)
        {
            var addUser = new Empleados();
            addUser.Usuario = txtUsuario.Text;
            addUser.Clave = txtClave.Text;
            addUser.Clave = txtNombreCompleto.Text;
            return addUser;
        }
        public static Empleados Factory(TextBox txtIdUsuario, TextBox txtUsuario, TextBox txtClave, TextBox txtNombreCompleto)
        {
            var nuevoEmpleado = new Empleados();
            nuevoEmpleado.IdUsuario = Convert.ToInt32(txtIdUsuario.Text);
            nuevoEmpleado.Usuario = txtUsuario.Text;
            nuevoEmpleado.Clave = txtClave.Text;
            nuevoEmpleado.NombreCompleto = txtNombreCompleto.Text;           

            return nuevoEmpleado;
        }

    }
}