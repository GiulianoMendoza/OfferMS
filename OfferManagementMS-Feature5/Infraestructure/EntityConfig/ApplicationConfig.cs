using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfig
{
    public class ApplicationConfig : IEntityTypeConfiguration<Domain.Entities.Aplication>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Aplication> builder)
        {
            builder.ToTable("Application");
            builder.HasKey(i => i.ApplicationId);
            builder.Property(i => i.ApplicationId).ValueGeneratedOnAdd();
            builder.Property(a => a.ApplicationStatusTypeId).IsRequired();
            builder.Property(u => u.UserId).IsRequired();
            builder.Property(o => o.OfferId).IsRequired();
            builder.Property(o => o.ApplicationDate).IsRequired();
            builder.Property(o => o.Status).IsRequired();

            builder.HasOne<Offer>(j => j.Offer)
                   .WithMany(c => c.Applications)
                   .HasForeignKey(c => c.OfferId);

            builder.HasOne<ApplicationStatusType>(j => j.ApplicationStatusType)
                   .WithMany(c => c.Applications)
                   .HasForeignKey(c => c.ApplicationStatusTypeId);
        }
    }
}
