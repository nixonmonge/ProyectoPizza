namespace Pizza.Ef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ordenes
    {
        [Key]
        public int IdOrden { get; set; }

        public int? IdPizza { get; set; }

        public DateTime? Fecha { get; set; }

        public int? Cantidad { get; set; }

        public int? IdUsuario { get; set; }

        [StringLength(50)]
        public string RutCliente { get; set; }
    }
}
