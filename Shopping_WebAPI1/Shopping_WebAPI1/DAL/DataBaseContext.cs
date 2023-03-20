using Microsoft.EntityFrameworkCore;
using Shopping_WebAPI1.Entities;

namespace Shopping_WebAPI1.DAL
{

    public class DataBaseContext: DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext>options): base(options)
        {

        }

        public DbSet<Country>Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();
        }
    
    }
}
