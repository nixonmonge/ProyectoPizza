using Pizza.Ef;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
                public static List<Clientes> ListaClientesOrdenes()
        {
            using(var grupo=new Model1())
            {
                var types=grupo.Clientes
                    .OrderBy( ct => ct.Nombre)
                    .ToList();
                Clientes vacio =new Clientes();
                vacio.RutCliente="0";
                vacio.Nombre="Seleccione un Cliente";
                types.Insert(0,vacio); // inserto al comienzo
                return types;
            }
        }
        public static void Insertar(Clientes cliente)
        {
            using (var nuevoCliente = new Model1())
            {
                nuevoCliente.Clientes.Add(cliente);
                nuevoCliente.SaveChanges();
            }
        }
    }
}