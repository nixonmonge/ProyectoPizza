using Pizza.Ef;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        public static List<Pizzas> ListaPizzasOrdenes()
        {
            using (var grupo = new Model1())
            {
                var types = grupo.Pizzas
                    .OrderBy(ct => ct.Titulo)
                    .ToList();
                Pizzas vacio = new Pizzas();
                vacio.IdPizza =0;
                vacio.Titulo = "Seleccione una Pizza";
                types.Insert(0, vacio); // inserto al comienzo
                return types;
            }
        }
        public static void Insertar(Pizzas pizza)
        {
            using (var nuevaPizza = new Model1())
            {
                nuevaPizza.Pizzas.Add(pizza);
                nuevaPizza.SaveChanges();
            }
        }
    }  
}