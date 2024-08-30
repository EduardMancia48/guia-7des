using Microsoft.EntityFrameworkCore;

namespace ProductoAPI.Models
{
    public class ProductoContext:DbContext
    {
        public ProductoContext(DbContextOptions<ProductoContext>options):base(options)
        {

        }

        public DbSet<Producto> ProductoSet { get;set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Producto>().HasData(
                new Producto
                {
                    Id = 1,
                    Nombre = "Laptop",
                    Categoria = "Electronica",
                    Descripcion = "Una laptop de alto rendimiento"

                },
                new Producto
                {
                    Id = 2,
                    Nombre = "Smartphone",
                    Categoria = "Electronica",
                    Descripcion = "Un smartphone de nueva generacion"
                },
                new Producto
                {
                    Id = 3,
                    Nombre = "Silla de Escritorio",
                    Categoria = "Muebles",
                    Descripcion = "Una silla de escritorio comoda"
                }

                );

        }

    }
}
