using Gestion.Model;
using Microsoft.EntityFrameworkCore;

namespace Gestion.Data
{
    public class GestionDbContext : DbContext
    {
        public GestionDbContext(DbContextOptions<GestionDbContext> options) : base(options) { }
        public GestionDbContext()
        {
            
        }

        public DbSet<Contacto> Contactos { get; set; }


        public void Setup()
        {
            Database.EnsureCreated();
            //Database.Migrate();
        }

        // DESCOMENTAR PARA CREAR MIGRATION
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=ejercicio_gestion;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True;");
        //    base.OnConfiguring(optionsBuilder);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
