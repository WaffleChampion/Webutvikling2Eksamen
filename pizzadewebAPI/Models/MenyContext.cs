using Microsoft.EntityFrameworkCore;

namespace pizzadewebAPI.Models{

    public class MenyContext : DbContext{
        
        public MenyContext(DbContextOptions<MenyContext> options):base(options){}

        public DbSet<Dishes> Dishes {get; set;}
        public DbSet<Drinks> Drinks {get; set;}
        public DbSet<Desserts> Desserts {get; set;}

    }

}