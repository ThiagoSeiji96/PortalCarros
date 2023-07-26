using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Persistence.Configurations
{
    public class AdviceConfigurations : IEntityTypeConfiguration<Advice>
    {

        public void Configure(EntityTypeBuilder<Advice> builder)
        {
            builder.HasKey(a => a.Id);

            builder
                .HasOne(a => a.User)
                .WithMany(a => a.ListAdvices)
                .HasForeignKey(a => a.IdUser)
                .OnDelete(DeleteBehavior.Restrict);
                
        }
    }
}
