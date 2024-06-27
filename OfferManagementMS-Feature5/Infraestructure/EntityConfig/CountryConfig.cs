using Domain.Entities;
using Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfig
{
    public class CountryConfig : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("Country");
            builder.HasKey(i => i.CountryId);
            builder.Property(n => n.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.HasMany<Province>(p => p.Provinces)
                   .WithOne(c => c.Country)
                   .HasForeignKey(fk => fk.CountryId);

            CountryData.SeedData(builder);
        }
    }
}
