using Pizza.Ef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizza.Dal
{
    public class OrdenesDal
    {
        public static void Insertar(Ordenes orden)
        {
            using (var nuevaOrden = new Model1())
            {
                nuevaOrden.Ordenes.Add(orden);
                nuevaOrden.SaveChanges();
            }
        }
         
    }
}