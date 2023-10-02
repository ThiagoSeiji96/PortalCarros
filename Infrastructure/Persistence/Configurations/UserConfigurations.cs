using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Persistence.Configurations
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder
                .HasMany(u => u.ListAdvices)
                .WithOne(u => u.User)
                .HasForeignKey(a => a.IdUser)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(a => a.Address)
                .WithOne(a => a.User)
                .HasForeignKey<Address>(a => a.IdUser)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
