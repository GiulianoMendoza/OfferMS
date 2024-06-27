using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data
{
    public class CountryData
    {
        public static void SeedData(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
                new Country { CountryId = 1, Name = "Argentina" }
                );
        }
    }
}
