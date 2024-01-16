using Microsoft.EntityFrameworkCore;
using SuperHeroAPI.Models;

namespace SuperHeroAPI.data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }
        protected DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=superherodb;Trusted_Connection=True;Encrypt=False;");
        }

        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}