﻿using Pizza.Ef;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public static List<Ordenes> ListarOrdenes()
        {
            var listado = new List<Ordenes>();
            using (var modelo = new Model1())
            {
                listado = modelo.Ordenes
                .OrderBy(e => e.Fecha).Include("Pizzas").Include("Clientes")
                .ToList();
            }
            return listado;
        }
    }
}