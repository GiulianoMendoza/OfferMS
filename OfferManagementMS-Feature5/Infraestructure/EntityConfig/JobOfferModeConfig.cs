using Domain.Entities;
using Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfig
{
    public class JobOfferModeConfig : IEntityTypeConfiguration<JobOfferMode>
    {
        public void Configure(EntityTypeBuilder<JobOfferMode> builder)
        {
            builder.ToTable("JobOfferMode");
            builder.HasKey(i => i.JobOfferModeId);
            builder.Property(i => i.JobOfferModeId);
            builder.Property(n => n.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasMany<Offer>(o => o.Offers)
                   .WithOne(o => o.JobOfferMode)
                   .HasForeignKey(o => o.JobOfferModeId);

            JobOfferModeData.SeedData(builder);
        }
    }
}
