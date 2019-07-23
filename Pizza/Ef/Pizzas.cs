namespace Pizza.Ef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pizzas
    {
        [Key]
        public int IdPizza { get; set; }

        [StringLength(50)]
        public string Titulo { get; set; }

        public int? Precio { get; set; }

        [StringLength(50)]
        public string Imagen { get; set; }
    }
}
