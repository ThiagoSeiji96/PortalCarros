using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Repository.Persistence
{
    public class PortalCarrosDbContext : DbContext
    {
        public PortalCarrosDbContext(DbContextOptions<PortalCarrosDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Advice> Advices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
