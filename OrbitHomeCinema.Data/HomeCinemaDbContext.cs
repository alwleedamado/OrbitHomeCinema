using Microsoft.EntityFrameworkCore;
using OrbitHomeCinema.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitHomeCinema.Data
{
    internal class HomeCinemaDbContext : DbContext
    {
        public DbSet<Movie> Movies => Set<Movie>();
        public DbSet<Series> Series => Set<Series>();
        public HomeCinemaDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(HomeCinemaDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
