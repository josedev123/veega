using Microsoft.EntityFrameworkCore;
using veega.Models;

namespace veega.Persistence
{
    public class VeegaDbContext : DbContext
    {
        public VeegaDbContext(DbContextOptions<VeegaDbContext> options) 
          : base(options)
        {
        }

        public DbSet<Make> Makes {get; set;}
        public DbSet<Feature> Features { get; set; }

    }
} 