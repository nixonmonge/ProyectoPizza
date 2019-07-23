using Pizza.Ef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizza.Dal
{
    public class EmpleadosDal
    {
        public static List<Empleados> ListarPorNombre()
        {
            var lista = new List<Empleados>();
            using (var grupo = new Model1())
            {
                var types = grupo.Empleados
                    .OrderBy(ct => ct.Usuario)
                    .ToList();
            }
            return lista;
        }
    }
}