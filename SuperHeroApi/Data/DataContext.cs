using Microsoft.EntityFrameworkCore;

namespace SuperHeroApi.Data
{
    public class DataContext : DbContext
    {
        //The controller will inject here so we can access the superheroes from database.

        //Constructor
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        //Property
        public DbSet <SuperHero> SuperHeroes { get; set; }
    }
}
