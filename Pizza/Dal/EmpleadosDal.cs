using Pizza.Ef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizza.Dal
{
    public class EmpleadosDal
    {
        public static List<Empleados> ListarTodo()
        {
            var listado = new List<Empleados>();
            using (var modelo = new Model1())
            {
                    listado = modelo.Empleados                    
                    .OrderBy(e => e.Usuario)
                    .ToList();
            }
            return listado;
        }
    }
}