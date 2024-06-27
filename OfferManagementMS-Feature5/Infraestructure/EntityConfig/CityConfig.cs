using Domain.Entities;
using Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfig
{
    public class CityConfig : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("City");
            builder.HasKey(i => i.CityId);
            builder.Property(i => i.CityId).ValueGeneratedOnAdd();
            builder.Property(p => p.ProvinceId).IsRequired();
            builder.Property(n => n.Name).IsRequired();

            builder.HasOne<Province>(j => j.Province)
                  .WithMany(c => c.Cities)
                  .HasForeignKey(c => c.ProvinceId);

            builder.HasMany<Offer>(o => o.Offers)
                   .WithOne(o => o.City)
                   .HasForeignKey(o => o.CityId);

            CityData.SeedData(builder);

        }
    }
}
