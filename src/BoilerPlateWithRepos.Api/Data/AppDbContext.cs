using BoilerPlateWithRepos.Api.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BoilerPlateWithRepos.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Game> Games => Set<Game>();
    }
}
