using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data
{
    public class JobOfferModeData
    {
        public static void SeedData(EntityTypeBuilder<JobOfferMode> builder)
        {
            builder.HasData(
                new JobOfferMode { JobOfferModeId = 1, Name = "Presencial" },
                new JobOfferMode { JobOfferModeId = 2, Name = "Hibrido" },
                new JobOfferMode { JobOfferModeId = 3, Name = "Remoto" }
                );
        }
    }
}
