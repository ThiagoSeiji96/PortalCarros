using Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Repository.Persistence
{
    public class PortalCarrosDbContext : IdentityDbContext
    {
        public PortalCarrosDbContext(DbContextOptions<PortalCarrosDbContext> options) : base(options)
        {
        }
        public PortalCarrosDbContext(){ }

        public DbSet<User> Users { get; set; }
        public DbSet<Advice> Advices { get; set; }
        public DbSet<AdviceDetails> AdvicesDetails { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<CarAcessories> CarAcessories { get; set; }
        public DbSet<CarBrand> Brands { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<CarPreservation> CarPreservations { get; set; }
        public DbSet<CarRegularization> CarRegularizations { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
