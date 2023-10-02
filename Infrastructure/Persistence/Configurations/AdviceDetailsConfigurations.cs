using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class AdviceDetailsConfigurations : IEntityTypeConfiguration<AdviceDetails>
    {
        public void Configure(EntityTypeBuilder<AdviceDetails> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .HasOne(a => a.Advice)
                .WithOne(a => a.AdviceDetails)
                .HasForeignKey<AdviceDetails>(a => a.Id_Advice)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(a => a.CarModel)
                .WithOne()
                .HasForeignKey<AdviceDetails>(a => a.Id_CarModel)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(a => a.Brand)
                .WithOne()
                .HasForeignKey<AdviceDetails>(a => a.Id_Brand)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(a => a.CarAcessories)
                .WithOne(a => a.AdviceDetails)
                .HasForeignKey<AdviceDetails>(a => a.Id_CarAcessories)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(a => a.CarRegularization)
                .WithOne(a => a.AdviceDetail)
                .HasForeignKey<AdviceDetails>(a => a.Id_CarRegularization)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(a => a.CarPreservation)
                .WithOne(a => a.AdviceDetails)
                .HasForeignKey<AdviceDetails>(a => a.Id_CarPreservation)
                .OnDelete(DeleteBehavior.Restrict);

            
        }
    }
}
