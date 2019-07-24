namespace Pizza.Ef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pizzas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pizzas()
        {
            Ordenes = new HashSet<Ordenes>();
        }

        [Key]
        public int IdPizza { get; set; }

        [StringLength(50)]
        public string Titulo { get; set; }

        public int? Precio { get; set; }

        [StringLength(50)]
        public string Imagen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ordenes> Ordenes { get; set; }
    }
}
