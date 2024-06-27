using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data
{
    public class ProvinceData
    {
        public static void SeedData(EntityTypeBuilder<Province> builder)
        {
            builder.HasData(
                new Province { CountryId = 1, ProvinceId = 06, Name = "Buenos Aires" },
                new Province { CountryId = 1, ProvinceId = 02, Name = "Ciudad Autónoma de Buenos Aires" },
                new Province { CountryId = 1, ProvinceId = 82, Name = "Santa Fe" },
                new Province { CountryId = 1, ProvinceId = 42, Name = "La Pampa" },
                new Province { CountryId = 1, ProvinceId = 14, Name = "Cordoba" },
                new Province { CountryId = 1, ProvinceId = 30, Name = "Entre Rios" },
                new Province { CountryId = 1, ProvinceId = 54, Name = "Misiones" },
                new Province { CountryId = 1, ProvinceId = 34, Name = "Formosa" },
                new Province { CountryId = 1, ProvinceId = 22, Name = "Chaco" },
                new Province { CountryId = 1, ProvinceId = 90, Name = "Tucuman" },
                new Province { CountryId = 1, ProvinceId = 10, Name = "Catamarca" },
                new Province { CountryId = 1, ProvinceId = 66, Name = "Salta" },
                new Province { CountryId = 1, ProvinceId = 38, Name = "Jujuy" },
                new Province { CountryId = 1, ProvinceId = 46, Name = "La Rioja" },
                new Province { CountryId = 1, ProvinceId = 70, Name = "San Juan" },
                new Province { CountryId = 1, ProvinceId = 74, Name = "San Luis" },
                new Province { CountryId = 1, ProvinceId = 50, Name = "Mendoza" },
                new Province { CountryId = 1, ProvinceId = 58, Name = "Neuquen" },
                new Province { CountryId = 1, ProvinceId = 18, Name = "Corrientes" },
                new Province { CountryId = 1, ProvinceId = 62, Name = "Rio Negro" },
                new Province { CountryId = 1, ProvinceId = 26, Name = "Chubut" },
                new Province { CountryId = 1, ProvinceId = 94, Name = "Tierra Del Fuego" }
                );
        }
    }
}
