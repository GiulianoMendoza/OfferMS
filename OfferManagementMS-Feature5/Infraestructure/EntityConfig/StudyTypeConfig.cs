using Domain.Entities;
using Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfig
{
    public class StudyTypeConfig : IEntityTypeConfiguration<StudyType>
    {
        public void Configure(EntityTypeBuilder<StudyType> builder)
        {
            builder.ToTable("StudyType");
            builder.HasKey(i => i.StudyTypeId);
            builder.Property(n => n.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.HasMany<Offer>(o => o.Offers)
                   .WithOne(o => o.StudyType)
                   .HasForeignKey(fk => fk.StudyTypeId);

            StudyTypeData.SeedData(builder);
        }
    }
}
