using Domain.Entities;
using Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfig
{
    public class ApplicationStatusTypeConfig : IEntityTypeConfiguration<ApplicationStatusType>
    {
        public void Configure(EntityTypeBuilder<ApplicationStatusType> builder)
        {
            builder.ToTable("ApplicationStatusType");
            builder.HasKey(i => i.ApplicationStatusTypeId);
            builder.Property(i => i.ApplicationStatusTypeId).ValueGeneratedOnAdd();
            builder.Property(n => n.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.HasMany<Aplication>(j => j.Applications)
                   .WithOne(c => c.ApplicationStatusType)
                   .HasForeignKey(c => c.ApplicationStatusTypeId);
            
            ApplicationStatusTypeData.SeedData(builder);
        }
    }
}
