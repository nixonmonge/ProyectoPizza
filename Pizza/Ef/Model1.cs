namespace Pizza.Ef
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model13")
        {
        }

        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Empleados> Empleados { get; set; }
        public virtual DbSet<Ordenes> Ordenes { get; set; }
        public virtual DbSet<Pizzas> Pizzas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clientes>()
                .Property(e => e.RutCliente)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Empleados>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<Empleados>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<Empleados>()
                .Property(e => e.NombreCompleto)
                .IsUnicode(false);

            modelBuilder.Entity<Ordenes>()
                .Property(e => e.RutCliente)
                .IsUnicode(false);

            modelBuilder.Entity<Pizzas>()
                .Property(e => e.Titulo)
                .IsUnicode(false);

            modelBuilder.Entity<Pizzas>()
                .Property(e => e.Imagen)
                .IsUnicode(false);
        }
    }
}
