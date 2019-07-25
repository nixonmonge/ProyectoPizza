using Pizza.Ef;
using Pizza.ServiceDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Pizza.Dal
{
    public class EmpleadosDal
    {
        public static void Insertar(Empleados usuario)
        {
            using (var grupo = new Model1())
            {
                grupo.Empleados.Add(usuario);
                grupo.SaveChanges();

            }


        }

        public static Empleados Validar(Empleados antiguo)
        {
            var nuevo = new Empleados();
            using (var grupo = new Model1())
            {
                nuevo = grupo.Empleados
                    .Where(e => e.Usuario == antiguo.Usuario)
                    .FirstOrDefault(); // Si no esta el usuario, devuelve un nulo
                                       //.First();  // Si no esta el usuario, se va a generar un error
            }
            if (nuevo != null && Util.Base64Encode(Util.Encriptar(antiguo.Clave)) != nuevo.Clave)
            {
                nuevo = null;
            }
            return nuevo;
        }
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