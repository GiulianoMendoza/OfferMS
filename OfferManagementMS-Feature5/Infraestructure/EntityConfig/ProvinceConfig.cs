using Domain.Entities;
using Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfig
{
    public class ProvinceConfig : IEntityTypeConfiguration<Province>
    {
        public void Configure(EntityTypeBuilder<Province> builder)
        {
            builder.ToTable("Province");
            builder.HasKey(i => i.ProvinceId);
            builder.Property(i => i.CountryId)
                   .IsRequired();
            builder.Property(n => n.Name)
                   .IsRequired()
                   .HasMaxLength(50);
            builder.Property(c => c.CountryId)
                   .IsRequired();

            builder.HasOne<Country>(c => c.Country)
                  .WithMany(ps => ps.Provinces)
                  .HasForeignKey(fk => fk.CountryId);

            builder.HasMany<City>(cs => cs.Cities)
                   .WithOne(p => p.Province)
                   .HasForeignKey(fk => fk.ProvinceId);

            ProvinceData.SeedData(builder);

        }
    }
}
