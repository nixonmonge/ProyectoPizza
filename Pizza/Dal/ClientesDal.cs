using Pizza.Ef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizza.Dal
{
    public class ClientesDal
    {
        public static List<Clientes> ListarClientes()
        {
            var listado = new List<Clientes>();
            using (var modelo = new Model1())
            {
                listado = modelo.Clientes
                .OrderBy(e => e.Nombre)
                .ToList();
            }
            return listado;
        }
    }
}