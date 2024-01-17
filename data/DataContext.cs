using Microsoft.EntityFrameworkCore;
using SuperHeroAPI.Models;

namespace SuperHeroAPI.data
{
    public class SuperHeroesContext : DbContext
    {
        public SuperHeroesContext()
        {
        }
        protected SuperHeroesContext(DbContextOptions<SuperHeroesContext> options) : base(options)
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