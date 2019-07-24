using Pizza.Ef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizza.Dal
{
    public class PizzasDal
    {
        public static List<Pizzas> ListarPizzas()
        {
            var listadoPizzas = new List<Pizzas>();
            using (var modelo = new Model1())
            {
                listadoPizzas = modelo.Pizzas
                    .OrderBy(e => e.Titulo)
                    .ToList();
            }
            return listadoPizzas;
        }
    }  
}