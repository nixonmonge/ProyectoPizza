namespace Pizza.Ef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Clientes
    {
        [Key]
        [StringLength(50)]
        public string RutCliente { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        public int? Telefono { get; set; }

        [StringLength(50)]
        public string Direccion { get; set; }
    }
}
