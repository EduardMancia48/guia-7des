using Microsoft.EntityFrameworkCore;

namespace LibroAPI.Models
{
    public class LibroContext : DbContext
    {
        public LibroContext(DbContextOptions<LibroContext> options) : base(options)
        {
        }

        public DbSet<Libro> LibroSet { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Libro>().HasData(
                new Libro
                {
                    Id = 1,
                    Titulo = "Clean Code",
                    Autor = "Robert C. Martin",
                    AnioPublicacion = 2008 
                },
                new Libro
                {
                    Id = 2,
                    Titulo = "The Pragmatic Programmer",
                    Autor = "Andrew Hunt, David Thomas",
                    AnioPublicacion = 1999 
                },
                new Libro
                {
                    Id = 3,
                    Titulo = "Design Patterns: Elements of Reusable Object-Oriented Software",
                    Autor = "Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides",
                    AnioPublicacion = 1994 
                }
            );
        }
    }
}
