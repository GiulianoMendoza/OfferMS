using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data
{
    public class CategoryData
    {
        public static void SeedData(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                    new Category { CategoryId = 1, Name = "Diseño y Desarrollo" },
                    new Category { CategoryId = 2, Name = "Comercial, Ventas y Negocios" },
                    new Category { CategoryId = 3, Name = "Administración, Contabilidad y Finanzas" },
                    new Category { CategoryId = 4, Name = "Ingenierías" },
                    new Category { CategoryId = 5, Name = "Tecnología, Sistemas y Telecomunicaciones" },
                    new Category { CategoryId = 6, Name = "Secretarias y Recepción" },
                    new Category { CategoryId = 7, Name = "Oficios y Otros" },
                    new Category { CategoryId = 8, Name = "Gastronomía y Turismo" },
                    new Category { CategoryId = 9, Name = "Abastecimiento y Logística" },
                    new Category { CategoryId = 10, Name = "Atención al Cliente, Call Center y Telemarketing" },
                    new Category { CategoryId = 11, Name = "Recursos Humanos y Capacitación" },
                    new Category { CategoryId = 12, Name = "Salud, Medicina y Farmacia" },
                    new Category { CategoryId = 13, Name = "Producción y Manufactura" },
                    new Category { CategoryId = 14, Name = "Legales" },
                    new Category { CategoryId = 15, Name = "Aduana y Comercio Exterior" },
                    new Category { CategoryId = 16, Name = "Ingeniería Civil y Construcción" },
                    new Category { CategoryId = 17, Name = "Seguros" },
                    new Category { CategoryId = 18, Name = "Gerencia y Dirección General" },
                    new Category { CategoryId = 20, Name = "Comunicación y Relaciones Públicas" },
                    new Category { CategoryId = 21, Name = "Educación, Docencia e Investigación" },
                    new Category { CategoryId = 22, Name = "Departamento Tecnico" },
                    new Category { CategoryId = 23, Name = "Enfermería" },
                    new Category { CategoryId = 24, Name = "Minería, Petróleo y Gas" },
                    new Category { CategoryId = 25, Name = "Naviero, Maritimo, Portuario" },
                    new Category { CategoryId = 26, Name = "Marketing y Publicidad" },
                    new Category { CategoryId = 27, Name = "Marketing y Publicidad" }
                );

        }
    }
}
