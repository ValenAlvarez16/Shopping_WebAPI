using Microsoft.EntityFrameworkCore;
using Shopping_WebAPI1.Entities;

namespace Shopping_WebAPI1.DAL
{

    public class DataBaseContext: DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext>options): base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<Category>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<State>().HasIndex("Name", "CountryId").IsUnique(); // Índice Compuesto
            modelBuilder.Entity<City>().HasIndex("Name", "StateId").IsUnique(); // Índice Compuesto
        }
    
    }
}
