using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data
{
    public class OfferSkillData
    {
        public static void SeedData(EntityTypeBuilder<OfferSkill> builder)
        {
            builder.HasData(
                new OfferSkill { OfferSkillId = 1, OfferId = Guid.Parse("d4b57950-3920-4a06-a7f6-76bfb5e1d501"), SkillId = 1 }, // C#
                new OfferSkill { OfferSkillId = 2, OfferId = Guid.Parse("d4b57950-3920-4a06-a7f6-76bfb5e1d501"), SkillId = 3 }, // JavaScript
                new OfferSkill { OfferSkillId = 3, OfferId = Guid.Parse("d4b57950-3920-4a06-a7f6-76bfb5e1d501"), SkillId = 4 }, // Node.js
                new OfferSkill { OfferSkillId = 4, OfferId = Guid.Parse("d4b57950-3920-4a06-a7f6-76bfb5e1d501"), SkillId = 23 }, // Marketing de Contenidos
                new OfferSkill { OfferSkillId = 5, OfferId = Guid.Parse("d4b57950-3920-4a06-a7f6-76bfb5e1d501"), SkillId = 26 }, // Publicidad Digital
                new OfferSkill { OfferSkillId = 6, OfferId = Guid.Parse("d4b57950-3920-4a06-a7f6-76bfb5e1d501"), SkillId = 27 }, // Analytics de Marketing
                new OfferSkill { OfferSkillId = 7, OfferId = Guid.Parse("d4b57950-3920-4a06-a7f6-76bfb5e1d501"), SkillId = 28 }, // Estrategia de Marketing
                new OfferSkill { OfferSkillId = 8, OfferId = Guid.Parse("d4b57950-3920-4a06-a7f6-76bfb5e1d501"), SkillId = 69 }, // Asesoría en recursos humanos
                new OfferSkill { OfferSkillId = 9, OfferId = Guid.Parse("d4b57950-3920-4a06-a7f6-76bfb5e1d501"), SkillId = 71 }, // PowerPoint
                new OfferSkill { OfferSkillId = 10, OfferId = Guid.Parse("d4b57950-3920-4a06-a7f6-76bfb5e1d501"), SkillId = 75 },  // Microsoft Access

                new OfferSkill { OfferSkillId = 11, OfferId = Guid.Parse("e4e8d3ec-9df2-46dc-a465-dc17a7815d56"), SkillId = 1 },   // C#
                new OfferSkill { OfferSkillId = 12, OfferId = Guid.Parse("e4e8d3ec-9df2-46dc-a465-dc17a7815d56"), SkillId = 2 },   // C
                new OfferSkill { OfferSkillId = 13, OfferId = Guid.Parse("e4e8d3ec-9df2-46dc-a465-dc17a7815d56"), SkillId = 3 },   // JavaScript
                new OfferSkill { OfferSkillId = 14, OfferId = Guid.Parse("e4e8d3ec-9df2-46dc-a465-dc17a7815d56"), SkillId = 4 },   // Node.Js
                new OfferSkill { OfferSkillId = 15, OfferId = Guid.Parse("e4e8d3ec-9df2-46dc-a465-dc17a7815d56"), SkillId = 5 },   // HTML
                new OfferSkill { OfferSkillId = 16, OfferId = Guid.Parse("e4e8d3ec-9df2-46dc-a465-dc17a7815d56"), SkillId = 6 },   // CSS
                new OfferSkill { OfferSkillId = 17, OfferId = Guid.Parse("e4e8d3ec-9df2-46dc-a465-dc17a7815d56"), SkillId = 7 },   // Photoshop
                new OfferSkill { OfferSkillId = 18, OfferId = Guid.Parse("e4e8d3ec-9df2-46dc-a465-dc17a7815d56"), SkillId = 8 },   // Excel
                new OfferSkill { OfferSkillId = 19, OfferId = Guid.Parse("e4e8d3ec-9df2-46dc-a465-dc17a7815d56"), SkillId = 9 },   // Word
                new OfferSkill { OfferSkillId = 20, OfferId = Guid.Parse("e4e8d3ec-9df2-46dc-a465-dc17a7815d56"), SkillId = 10 },  // Ventas consultivas

                new OfferSkill { OfferSkillId = 21, OfferId = Guid.Parse("c2d4bb58-aa15-4659-8f42-e4e6326b6cf2"), SkillId = 45 }, // Análisis de mercado
                new OfferSkill { OfferSkillId = 22, OfferId = Guid.Parse("c2d4bb58-aa15-4659-8f42-e4e6326b6cf2"), SkillId = 108 }, // Maya
                new OfferSkill { OfferSkillId = 23, OfferId = Guid.Parse("c2d4bb58-aa15-4659-8f42-e4e6326b6cf2"), SkillId = 109 }, // Unity
                new OfferSkill { OfferSkillId = 24, OfferId = Guid.Parse("c2d4bb58-aa15-4659-8f42-e4e6326b6cf2"), SkillId = 110 }, // Unreal Engine
                new OfferSkill { OfferSkillId = 25, OfferId = Guid.Parse("c2d4bb58-aa15-4659-8f42-e4e6326b6cf2"), SkillId = 105 }, // After Effects
                new OfferSkill { OfferSkillId = 26, OfferId = Guid.Parse("c2d4bb58-aa15-4659-8f42-e4e6326b6cf2"), SkillId = 106 }, // Final Cut Pro
                new OfferSkill { OfferSkillId = 27, OfferId = Guid.Parse("c2d4bb58-aa15-4659-8f42-e4e6326b6cf2"), SkillId = 137 }, // DaVinci Resolve
                new OfferSkill { OfferSkillId = 28, OfferId = Guid.Parse("c2d4bb58-aa15-4659-8f42-e4e6326b6cf2"), SkillId = 138 }, // Cinema 4D
                new OfferSkill { OfferSkillId = 29, OfferId = Guid.Parse("c2d4bb58-aa15-4659-8f42-e4e6326b6cf2"), SkillId = 85 }, // SAP
                new OfferSkill { OfferSkillId = 30, OfferId = Guid.Parse("c2d4bb58-aa15-4659-8f42-e4e6326b6cf2"), SkillId = 27 },  // Analytics de Marketing

                new OfferSkill { OfferSkillId = 31, OfferId = Guid.Parse("3b481a4c-0c63-4ff8-b1e4-0c726d300e0c"), SkillId = 45 }, // Análisis de mercado
                new OfferSkill { OfferSkillId = 32, OfferId = Guid.Parse("3b481a4c-0c63-4ff8-b1e4-0c726d300e0c"), SkillId = 85 }, // SAP
                new OfferSkill { OfferSkillId = 33, OfferId = Guid.Parse("3b481a4c-0c63-4ff8-b1e4-0c726d300e0c"), SkillId = 27 }, // Analytics de Marketing
                new OfferSkill { OfferSkillId = 34, OfferId = Guid.Parse("3b481a4c-0c63-4ff8-b1e4-0c726d300e0c"), SkillId = 38 }, // Cultura organizacional
                new OfferSkill { OfferSkillId = 35, OfferId = Guid.Parse("3b481a4c-0c63-4ff8-b1e4-0c726d300e0c"), SkillId = 39 }, // Gestión del cambio
                new OfferSkill { OfferSkillId = 36, OfferId = Guid.Parse("3b481a4c-0c63-4ff8-b1e4-0c726d300e0c"), SkillId = 27 }, // Analytics de Marketing
                new OfferSkill { OfferSkillId = 37, OfferId = Guid.Parse("3b481a4c-0c63-4ff8-b1e4-0c726d300e0c"), SkillId = 58 }, // Asesoría en tecnología
                new OfferSkill { OfferSkillId = 38, OfferId = Guid.Parse("3b481a4c-0c63-4ff8-b1e4-0c726d300e0c"), SkillId = 35 }, // Relaciones laborales
                new OfferSkill { OfferSkillId = 39, OfferId = Guid.Parse("3b481a4c-0c63-4ff8-b1e4-0c726d300e0c"), SkillId = 36 }, // Administración de nómina
                new OfferSkill { OfferSkillId = 40, OfferId = Guid.Parse("3b481a4c-0c63-4ff8-b1e4-0c726d300e0c"), SkillId = 66 },  // Facturación y cobranza

                new OfferSkill { OfferSkillId = 41, OfferId = Guid.Parse("fd98a956-2a04-4a29-89a6-fce06f13803f"), SkillId = 46 }, // Estrategia de precios
                new OfferSkill { OfferSkillId = 42, OfferId = Guid.Parse("fd98a956-2a04-4a29-89a6-fce06f13803f"), SkillId = 51 }, // Asesoría financiera
                new OfferSkill { OfferSkillId = 43, OfferId = Guid.Parse("fd98a956-2a04-4a29-89a6-fce06f13803f"), SkillId = 53 }, // Asesoría fiscal
                new OfferSkill { OfferSkillId = 44, OfferId = Guid.Parse("fd98a956-2a04-4a29-89a6-fce06f13803f"), SkillId = 67 }, // Control de gastos
                new OfferSkill { OfferSkillId = 45, OfferId = Guid.Parse("fd98a956-2a04-4a29-89a6-fce06f13803f"), SkillId = 76 }, // QuickBooks
                new OfferSkill { OfferSkillId = 46, OfferId = Guid.Parse("fd98a956-2a04-4a29-89a6-fce06f13803f"), SkillId = 85 }, // SAP
                new OfferSkill { OfferSkillId = 47, OfferId = Guid.Parse("fd98a956-2a04-4a29-89a6-fce06f13803f"), SkillId = 103 }, // InDesign
                new OfferSkill { OfferSkillId = 48, OfferId = Guid.Parse("fd98a956-2a04-4a29-89a6-fce06f13803f"), SkillId = 96 }, // Microsoft Teams
                new OfferSkill { OfferSkillId = 49, OfferId = Guid.Parse("fd98a956-2a04-4a29-89a6-fce06f13803f"), SkillId = 68 }, // Manejo de bases de datos
                new OfferSkill { OfferSkillId = 50, OfferId = Guid.Parse("fd98a956-2a04-4a29-89a6-fce06f13803f"), SkillId = 9 },   // Word

                new OfferSkill { OfferSkillId = 51, OfferId = Guid.Parse("90cc7e80-982b-4f36-8986-529bd7c11a1f"), SkillId = 45 }, // Análisis de mercado
                new OfferSkill { OfferSkillId = 52, OfferId = Guid.Parse("90cc7e80-982b-4f36-8986-529bd7c11a1f"), SkillId = 47 }, // Gestión de proveedores
                new OfferSkill { OfferSkillId = 53, OfferId = Guid.Parse("90cc7e80-982b-4f36-8986-529bd7c11a1f"), SkillId = 48 }, // Gestión de la cadena de suministro
                new OfferSkill { OfferSkillId = 54, OfferId = Guid.Parse("90cc7e80-982b-4f36-8986-529bd7c11a1f"), SkillId = 85 }, // SAP
                new OfferSkill { OfferSkillId = 55, OfferId = Guid.Parse("90cc7e80-982b-4f36-8986-529bd7c11a1f"), SkillId = 86 }, // Salesforce
                new OfferSkill { OfferSkillId = 56, OfferId = Guid.Parse("90cc7e80-982b-4f36-8986-529bd7c11a1f"), SkillId = 21 }, // SEO (Optimización de Motores de Búsqueda)
                new OfferSkill { OfferSkillId = 57, OfferId = Guid.Parse("90cc7e80-982b-4f36-8986-529bd7c11a1f"), SkillId = 38 }, // Cultura organizacional
                new OfferSkill { OfferSkillId = 58, OfferId = Guid.Parse("90cc7e80-982b-4f36-8986-529bd7c11a1f"), SkillId = 1 },  // C#
                new OfferSkill { OfferSkillId = 59, OfferId = Guid.Parse("90cc7e80-982b-4f36-8986-529bd7c11a1f"), SkillId = 81 },  // SketchUp

                new OfferSkill { OfferSkillId = 60, OfferId = Guid.Parse("f91f3aa0-66a8-4f4b-81e6-87d01e681d8d"), SkillId = 68 }, // Manejo de bases de datos
                new OfferSkill { OfferSkillId = 61, OfferId = Guid.Parse("f91f3aa0-66a8-4f4b-81e6-87d01e681d8d"), SkillId = 69 }, // Elaboración de informes
                new OfferSkill { OfferSkillId = 62, OfferId = Guid.Parse("f91f3aa0-66a8-4f4b-81e6-87d01e681d8d"), SkillId = 70 }, // Organización de eventos
                new OfferSkill { OfferSkillId = 63, OfferId = Guid.Parse("f91f3aa0-66a8-4f4b-81e6-87d01e681d8d"), SkillId = 9 },  // Word
                new OfferSkill { OfferSkillId = 64, OfferId = Guid.Parse("f91f3aa0-66a8-4f4b-81e6-87d01e681d8d"), SkillId = 75 }, // Microsoft Access
                new OfferSkill { OfferSkillId = 65, OfferId = Guid.Parse("f91f3aa0-66a8-4f4b-81e6-87d01e681d8d"), SkillId = 76 }, // QuickBooks
                new OfferSkill { OfferSkillId = 66, OfferId = Guid.Parse("f91f3aa0-66a8-4f4b-81e6-87d01e681d8d"), SkillId = 96 }, // Microsoft Teams
                new OfferSkill { OfferSkillId = 67, OfferId = Guid.Parse("f91f3aa0-66a8-4f4b-81e6-87d01e681d8d"), SkillId = 103 }, // InDesign
                new OfferSkill { OfferSkillId = 68, OfferId = Guid.Parse("f91f3aa0-66a8-4f4b-81e6-87d01e681d8d"), SkillId = 17 },  // Gestión del talento

                new OfferSkill { OfferSkillId = 69, OfferId = Guid.Parse("1539bb63-c5f2-4a8d-8843-7988d20669ec"), SkillId = 43 }, // Gestión de inventario
                new OfferSkill { OfferSkillId = 70, OfferId = Guid.Parse("1539bb63-c5f2-4a8d-8843-7988d20669ec"), SkillId = 98 }, // WebEx
                new OfferSkill { OfferSkillId = 71, OfferId = Guid.Parse("1539bb63-c5f2-4a8d-8843-7988d20669ec"), SkillId = 88 }, // JIRA
                new OfferSkill { OfferSkillId = 72, OfferId = Guid.Parse("1539bb63-c5f2-4a8d-8843-7988d20669ec"), SkillId = 89 }, // Confluence
                new OfferSkill { OfferSkillId = 73, OfferId = Guid.Parse("1539bb63-c5f2-4a8d-8843-7988d20669ec"), SkillId = 90 }, // Zendesk
                new OfferSkill { OfferSkillId = 74, OfferId = Guid.Parse("1539bb63-c5f2-4a8d-8843-7988d20669ec"), SkillId = 69 }, // Elaboración de informes
                new OfferSkill { OfferSkillId = 75, OfferId = Guid.Parse("1539bb63-c5f2-4a8d-8843-7988d20669ec"), SkillId = 17 }, // Gestión del talento
                new OfferSkill { OfferSkillId = 76, OfferId = Guid.Parse("1539bb63-c5f2-4a8d-8843-7988d20669ec"), SkillId = 27 }, // Analytics de Marketing
                new OfferSkill { OfferSkillId = 77, OfferId = Guid.Parse("1539bb63-c5f2-4a8d-8843-7988d20669ec"), SkillId = 38 },  // Cultura organizacional

                new OfferSkill { OfferSkillId = 78, OfferId = Guid.Parse("8a1a3ef3-358d-4cc2-8633-dbd57ac52006"), SkillId = 71 }, // PowerPoint
                new OfferSkill { OfferSkillId = 79, OfferId = Guid.Parse("8a1a3ef3-358d-4cc2-8633-dbd57ac52006"), SkillId = 73 }, // Google Docs
                new OfferSkill { OfferSkillId = 80, OfferId = Guid.Parse("8a1a3ef3-358d-4cc2-8633-dbd57ac52006"), SkillId = 74 }, // Google Slides
                new OfferSkill { OfferSkillId = 81, OfferId = Guid.Parse("8a1a3ef3-358d-4cc2-8633-dbd57ac52006"), SkillId = 90 }, // Zendesk
                new OfferSkill { OfferSkillId = 82, OfferId = Guid.Parse("8a1a3ef3-358d-4cc2-8633-dbd57ac52006"), SkillId = 91 }, // GitHub
                new OfferSkill { OfferSkillId = 83, OfferId = Guid.Parse("8a1a3ef3-358d-4cc2-8633-dbd57ac52006"), SkillId = 93 }, // Trello
                new OfferSkill { OfferSkillId = 84, OfferId = Guid.Parse("8a1a3ef3-358d-4cc2-8633-dbd57ac52006"), SkillId = 98 }, // WebEx
                new OfferSkill { OfferSkillId = 85, OfferId = Guid.Parse("8a1a3ef3-358d-4cc2-8633-dbd57ac52006"), SkillId = 99 }, // Skype
                new OfferSkill { OfferSkillId = 86, OfferId = Guid.Parse("8a1a3ef3-358d-4cc2-8633-dbd57ac52006"), SkillId = 100 }, // Google Meet
                new OfferSkill { OfferSkillId = 87, OfferId = Guid.Parse("8a1a3ef3-358d-4cc2-8633-dbd57ac52006"), SkillId = 87 },   // Tableau

                new OfferSkill { OfferSkillId = 88, OfferId = Guid.Parse("e5acde91-155a-4b5e-a0a1-f081298b1832"), SkillId = 41 }, // Compras y aprovisionamiento
                new OfferSkill { OfferSkillId = 89, OfferId = Guid.Parse("e5acde91-155a-4b5e-a0a1-f081298b1832"), SkillId = 42 }, // Logística de abastecimiento
                new OfferSkill { OfferSkillId = 90, OfferId = Guid.Parse("e5acde91-155a-4b5e-a0a1-f081298b1832"), SkillId = 43 }, // Gestión de inventario
                new OfferSkill { OfferSkillId = 91, OfferId = Guid.Parse("e5acde91-155a-4b5e-a0a1-f081298b1832"), SkillId = 44 }, // Planificación de la demanda
                new OfferSkill { OfferSkillId = 92, OfferId = Guid.Parse("e5acde91-155a-4b5e-a0a1-f081298b1832"), SkillId = 45 }, // Análisis de mercado
                new OfferSkill { OfferSkillId = 93, OfferId = Guid.Parse("e5acde91-155a-4b5e-a0a1-f081298b1832"), SkillId = 47 }, // Gestión de proveedores
                new OfferSkill { OfferSkillId = 94, OfferId = Guid.Parse("e5acde91-155a-4b5e-a0a1-f081298b1832"), SkillId = 48 }, // Gestión de la cadena de suministro
                new OfferSkill { OfferSkillId = 95, OfferId = Guid.Parse("e5acde91-155a-4b5e-a0a1-f081298b1832"), SkillId = 49 }, // Exportaciones e importaciones
                new OfferSkill { OfferSkillId = 96, OfferId = Guid.Parse("e5acde91-155a-4b5e-a0a1-f081298b1832"), SkillId = 36 }, // Administración de nómina
                new OfferSkill { OfferSkillId = 97, OfferId = Guid.Parse("e5acde91-155a-4b5e-a0a1-f081298b1832"), SkillId = 37 },  // Evaluación del desempeño

                new OfferSkill { OfferSkillId = 98, OfferId = Guid.Parse("5e7f9ee4-0e9e-4bc2-b64d-5ef6e2ad207e"), SkillId = 68 }, // Manejo de bases de datos
                new OfferSkill { OfferSkillId = 99, OfferId = Guid.Parse("5e7f9ee4-0e9e-4bc2-b64d-5ef6e2ad207e"), SkillId = 36 }, // Administración de nómina
                new OfferSkill { OfferSkillId = 100, OfferId = Guid.Parse("5e7f9ee4-0e9e-4bc2-b64d-5ef6e2ad207e"), SkillId = 37 }, // Evaluación del desempeño
                new OfferSkill { OfferSkillId = 101, OfferId = Guid.Parse("5e7f9ee4-0e9e-4bc2-b64d-5ef6e2ad207e"), SkillId = 38 }, // Cultura organizacional
                new OfferSkill { OfferSkillId = 102, OfferId = Guid.Parse("5e7f9ee4-0e9e-4bc2-b64d-5ef6e2ad207e"), SkillId = 39 }, // Gestión del cambio
                new OfferSkill { OfferSkillId = 103, OfferId = Guid.Parse("5e7f9ee4-0e9e-4bc2-b64d-5ef6e2ad207e"), SkillId = 40 },  // Gestión del rendimiento

                new OfferSkill { OfferSkillId = 104, OfferId = Guid.Parse("a8b52b4f-025d-4d48-82c1-990fbbdbb369"), SkillId = 68 }, // Manejo de bases de datos
                new OfferSkill { OfferSkillId = 105, OfferId = Guid.Parse("a8b52b4f-025d-4d48-82c1-990fbbdbb369"), SkillId = 70 }, // Organización de eventos
                new OfferSkill { OfferSkillId = 106, OfferId = Guid.Parse("a8b52b4f-025d-4d48-82c1-990fbbdbb369"), SkillId = 71 }, // PowerPoint
                new OfferSkill { OfferSkillId = 107, OfferId = Guid.Parse("a8b52b4f-025d-4d48-82c1-990fbbdbb369"), SkillId = 96 }, // Microsoft Teams
                new OfferSkill { OfferSkillId = 108, OfferId = Guid.Parse("a8b52b4f-025d-4d48-82c1-990fbbdbb369"), SkillId = 97 }, // Zoom
                new OfferSkill { OfferSkillId = 109, OfferId = Guid.Parse("a8b52b4f-025d-4d48-82c1-990fbbdbb369"), SkillId = 98 }, // WebEx
                new OfferSkill { OfferSkillId = 110, OfferId = Guid.Parse("a8b52b4f-025d-4d48-82c1-990fbbdbb369"), SkillId = 99 }, // Skype
                new OfferSkill { OfferSkillId = 111, OfferId = Guid.Parse("a8b52b4f-025d-4d48-82c1-990fbbdbb369"), SkillId = 100 }, // Google Meet
                new OfferSkill { OfferSkillId = 112, OfferId = Guid.Parse("a8b52b4f-025d-4d48-82c1-990fbbdbb369"), SkillId = 72 }, // Google Sheets
                new OfferSkill { OfferSkillId = 113, OfferId = Guid.Parse("a8b52b4f-025d-4d48-82c1-990fbbdbb369"), SkillId = 73 },  // Google Docs

                new OfferSkill { OfferSkillId = 114, OfferId = Guid.Parse("1b1d2d29-62c2-4ae3-bbfc-6a17514fc77d"), SkillId = 17 }, // Gestión del talento
                new OfferSkill { OfferSkillId = 115, OfferId = Guid.Parse("1b1d2d29-62c2-4ae3-bbfc-6a17514fc77d"), SkillId = 37 }, // Evaluación del desempeño
                new OfferSkill { OfferSkillId = 116, OfferId = Guid.Parse("1b1d2d29-62c2-4ae3-bbfc-6a17514fc77d"), SkillId = 38 }, // Cultura organizacional
                new OfferSkill { OfferSkillId = 117, OfferId = Guid.Parse("1b1d2d29-62c2-4ae3-bbfc-6a17514fc77d"), SkillId = 39 }, // Gestión del cambio
                new OfferSkill { OfferSkillId = 118, OfferId = Guid.Parse("1b1d2d29-62c2-4ae3-bbfc-6a17514fc77d"), SkillId = 40 }, // Gestión del rendimiento
                new OfferSkill { OfferSkillId = 119, OfferId = Guid.Parse("1b1d2d29-62c2-4ae3-bbfc-6a17514fc77d"), SkillId = 45 }, // Análisis de mercado
                new OfferSkill { OfferSkillId = 120, OfferId = Guid.Parse("1b1d2d29-62c2-4ae3-bbfc-6a17514fc77d"), SkillId = 59 }, // Asesoría en recursos humanos
                new OfferSkill { OfferSkillId = 121, OfferId = Guid.Parse("1b1d2d29-62c2-4ae3-bbfc-6a17514fc77d"), SkillId = 86 }, // Salesforce
                new OfferSkill { OfferSkillId = 122, OfferId = Guid.Parse("1b1d2d29-62c2-4ae3-bbfc-6a17514fc77d"), SkillId = 87 }, // Tableau
                new OfferSkill { OfferSkillId = 123, OfferId = Guid.Parse("1b1d2d29-62c2-4ae3-bbfc-6a17514fc77d"), SkillId = 88 },  // JIRA

                new OfferSkill { OfferSkillId = 124, OfferId = Guid.Parse("c2b9a7cb-8b3d-496f-80df-93f1928ef9d0"), SkillId = 23 }, // Gestión de proyectos
                new OfferSkill { OfferSkillId = 125, OfferId = Guid.Parse("c2b9a7cb-8b3d-496f-80df-93f1928ef9d0"), SkillId = 41 }, // Planificación y organización
                new OfferSkill { OfferSkillId = 126, OfferId = Guid.Parse("c2b9a7cb-8b3d-496f-80df-93f1928ef9d0"), SkillId = 42 }, // Resolución de problemas
                new OfferSkill { OfferSkillId = 127, OfferId = Guid.Parse("c2b9a7cb-8b3d-496f-80df-93f1928ef9d0"), SkillId = 43 }, // Toma de decisiones
                new OfferSkill { OfferSkillId = 128, OfferId = Guid.Parse("c2b9a7cb-8b3d-496f-80df-93f1928ef9d0"), SkillId = 44 }, // Liderazgo de equipos
                new OfferSkill { OfferSkillId = 129, OfferId = Guid.Parse("c2b9a7cb-8b3d-496f-80df-93f1928ef9d0"), SkillId = 51 }, // Gestión del tiempo
                new OfferSkill { OfferSkillId = 130, OfferId = Guid.Parse("c2b9a7cb-8b3d-496f-80df-93f1928ef9d0"), SkillId = 77 }, // Mantenimiento industrial
                new OfferSkill { OfferSkillId = 131, OfferId = Guid.Parse("c2b9a7cb-8b3d-496f-80df-93f1928ef9d0"), SkillId = 78 }, // Seguridad industrial
                new OfferSkill { OfferSkillId = 132, OfferId = Guid.Parse("c2b9a7cb-8b3d-496f-80df-93f1928ef9d0"), SkillId = 89 }, // Lean manufacturing
                new OfferSkill { OfferSkillId = 133, OfferId = Guid.Parse("c2b9a7cb-8b3d-496f-80df-93f1928ef9d0"), SkillId = 90 }, // Six Sigma

                new OfferSkill { OfferSkillId = 134, OfferId = Guid.Parse("1e40e017-20b7-4b5c-af8f-9b4f62e80a5d"), SkillId = 41 }, // Planificación y organización
                new OfferSkill { OfferSkillId = 135, OfferId = Guid.Parse("1e40e017-20b7-4b5c-af8f-9b4f62e80a5d"), SkillId = 42 }, // Resolución de problemas
                new OfferSkill { OfferSkillId = 136, OfferId = Guid.Parse("1e40e017-20b7-4b5c-af8f-9b4f62e80a5d"), SkillId = 43 }, // Toma de decisiones
                new OfferSkill { OfferSkillId = 137, OfferId = Guid.Parse("1e40e017-20b7-4b5c-af8f-9b4f62e80a5d"), SkillId = 44 }, // Liderazgo de equipos
                new OfferSkill { OfferSkillId = 138, OfferId = Guid.Parse("1e40e017-20b7-4b5c-af8f-9b4f62e80a5d"), SkillId = 51 }, // Gestión del tiempo
                new OfferSkill { OfferSkillId = 139, OfferId = Guid.Parse("1e40e017-20b7-4b5c-af8f-9b4f62e80a5d"), SkillId = 61 }, // Análisis de datos
                new OfferSkill { OfferSkillId = 140, OfferId = Guid.Parse("1e40e017-20b7-4b5c-af8f-9b4f62e80a5d"), SkillId = 77 }, // Gestión logística
                new OfferSkill { OfferSkillId = 141, OfferId = Guid.Parse("1e40e017-20b7-4b5c-af8f-9b4f62e80a5d"), SkillId = 82 }, // Relaciones con proveedores
                new OfferSkill { OfferSkillId = 142, OfferId = Guid.Parse("1e40e017-20b7-4b5c-af8f-9b4f62e80a5d"), SkillId = 90 }, // Six Sigma

                new OfferSkill { OfferSkillId = 143, OfferId = Guid.Parse("34ec9f13-279d-4453-98a8-1a0831e9e90d"), SkillId = 63 }, // Archivo y registro
                new OfferSkill { OfferSkillId = 144, OfferId = Guid.Parse("34ec9f13-279d-4453-98a8-1a0831e9e90d"), SkillId = 66 }, // Facturación y cobranza
                new OfferSkill { OfferSkillId = 145, OfferId = Guid.Parse("34ec9f13-279d-4453-98a8-1a0831e9e90d"), SkillId = 70 }, // Organización de eventos
                new OfferSkill { OfferSkillId = 146, OfferId = Guid.Parse("34ec9f13-279d-4453-98a8-1a0831e9e90d"), SkillId = 65 }, // Gestión de correos electrónicos
                new OfferSkill { OfferSkillId = 147, OfferId = Guid.Parse("34ec9f13-279d-4453-98a8-1a0831e9e90d"), SkillId = 71 }, // PowerPoint
                new OfferSkill { OfferSkillId = 148, OfferId = Guid.Parse("34ec9f13-279d-4453-98a8-1a0831e9e90d"), SkillId = 77 }, // Adobe Illustrator
                new OfferSkill { OfferSkillId = 149, OfferId = Guid.Parse("34ec9f13-279d-4453-98a8-1a0831e9e90d"), SkillId = 78 }, // Adobe InDesign
                new OfferSkill { OfferSkillId = 150, OfferId = Guid.Parse("34ec9f13-279d-4453-98a8-1a0831e9e90d"), SkillId = 79 }, // Adobe Premiere Pro
                new OfferSkill { OfferSkillId = 151, OfferId = Guid.Parse("34ec9f13-279d-4453-98a8-1a0831e9e90d"), SkillId = 76 }, // QuickBooks
                new OfferSkill { OfferSkillId = 152, OfferId = Guid.Parse("34ec9f13-279d-4453-98a8-1a0831e9e90d"), SkillId = 72 },  // Google Sheets

                new OfferSkill { OfferSkillId = 153, OfferId = Guid.Parse("c2d5c7d4-97df-4c9d-b292-515a0dbd25a5"), SkillId = 35 }, // Relaciones laborales
                new OfferSkill { OfferSkillId = 154, OfferId = Guid.Parse("c2d5c7d4-97df-4c9d-b292-515a0dbd25a5"), SkillId = 67 }, // Control de gastos
                new OfferSkill { OfferSkillId = 155, OfferId = Guid.Parse("c2d5c7d4-97df-4c9d-b292-515a0dbd25a5"), SkillId = 70 }, // Organización de eventos
                new OfferSkill { OfferSkillId = 156, OfferId = Guid.Parse("c2d5c7d4-97df-4c9d-b292-515a0dbd25a5"), SkillId = 106 }, // Final Cut Pro
                new OfferSkill { OfferSkillId = 157, OfferId = Guid.Parse("c2d5c7d4-97df-4c9d-b292-515a0dbd25a5"), SkillId = 129 }, // Substance Painter
                new OfferSkill { OfferSkillId = 158, OfferId = Guid.Parse("c2d5c7d4-97df-4c9d-b292-515a0dbd25a5"), SkillId = 51 }, // Asesoría financiera
                new OfferSkill { OfferSkillId = 159, OfferId = Guid.Parse("c2d5c7d4-97df-4c9d-b292-515a0dbd25a5"), SkillId = 46 }, // Estrategia de precios
                new OfferSkill { OfferSkillId = 160, OfferId = Guid.Parse("c2d5c7d4-97df-4c9d-b292-515a0dbd25a5"), SkillId = 1 },  // C#
                new OfferSkill { OfferSkillId = 161, OfferId = Guid.Parse("c2d5c7d4-97df-4c9d-b292-515a0dbd25a5"), SkillId = 2 },   // C

                new OfferSkill { OfferSkillId = 162, OfferId = Guid.Parse("b7f364c3-b50c-4ea0-bb24-6f6ddbf64d69"), SkillId = 67 }, // Control de gastos
                new OfferSkill { OfferSkillId = 163, OfferId = Guid.Parse("b7f364c3-b50c-4ea0-bb24-6f6ddbf64d69"), SkillId = 39 }, // Gestión del cambio
                new OfferSkill { OfferSkillId = 164, OfferId = Guid.Parse("b7f364c3-b50c-4ea0-bb24-6f6ddbf64d69"), SkillId = 69 }, // Elaboración de informes
                new OfferSkill { OfferSkillId = 165, OfferId = Guid.Parse("b7f364c3-b50c-4ea0-bb24-6f6ddbf64d69"), SkillId = 38 }, // Cultura organizacional
                new OfferSkill { OfferSkillId = 166, OfferId = Guid.Parse("b7f364c3-b50c-4ea0-bb24-6f6ddbf64d69"), SkillId = 68 }, // Manejo de bases de datos
                new OfferSkill { OfferSkillId = 167, OfferId = Guid.Parse("b7f364c3-b50c-4ea0-bb24-6f6ddbf64d69"), SkillId = 81 }, // SketchUp
                new OfferSkill { OfferSkillId = 168, OfferId = Guid.Parse("b7f364c3-b50c-4ea0-bb24-6f6ddbf64d69"), SkillId = 8 },  // Excel
                new OfferSkill { OfferSkillId = 169, OfferId = Guid.Parse("b7f364c3-b50c-4ea0-bb24-6f6ddbf64d69"), SkillId = 90 }, // Zendesk
                new OfferSkill { OfferSkillId = 170, OfferId = Guid.Parse("b7f364c3-b50c-4ea0-bb24-6f6ddbf64d69"), SkillId = 25 },  // Marketing en Redes Sociales

                new OfferSkill { OfferSkillId = 171, OfferId = Guid.Parse("cba5b59e-76f1-495a-9a6b-3a6d9b55f119"), SkillId = 93 }, // Trello
                new OfferSkill { OfferSkillId = 172, OfferId = Guid.Parse("cba5b59e-76f1-495a-9a6b-3a6d9b55f119"), SkillId = 89 }, // Confluence
                new OfferSkill { OfferSkillId = 173, OfferId = Guid.Parse("cba5b59e-76f1-495a-9a6b-3a6d9b55f119"), SkillId = 92 }, // GitLab
                new OfferSkill { OfferSkillId = 174, OfferId = Guid.Parse("cba5b59e-76f1-495a-9a6b-3a6d9b55f119"), SkillId = 81 }, // SketchUp
                new OfferSkill { OfferSkillId = 175, OfferId = Guid.Parse("cba5b59e-76f1-495a-9a6b-3a6d9b55f119"), SkillId = 87 }, // Tableau
                new OfferSkill { OfferSkillId = 176, OfferId = Guid.Parse("cba5b59e-76f1-495a-9a6b-3a6d9b55f119"), SkillId = 91 }, // GitHub
                new OfferSkill { OfferSkillId = 177, OfferId = Guid.Parse("cba5b59e-76f1-495a-9a6b-3a6d9b55f119"), SkillId = 74 }, // Google Slides
                new OfferSkill { OfferSkillId = 178, OfferId = Guid.Parse("cba5b59e-76f1-495a-9a6b-3a6d9b55f119"), SkillId = 71 }, // PowerPoint
                new OfferSkill { OfferSkillId = 179, OfferId = Guid.Parse("cba5b59e-76f1-495a-9a6b-3a6d9b55f119"), SkillId = 96 }, // Microsoft Teams
                new OfferSkill { OfferSkillId = 180, OfferId = Guid.Parse("cba5b59e-76f1-495a-9a6b-3a6d9b55f119"), SkillId = 95 },  // Slack

                new OfferSkill { OfferSkillId = 181, OfferId = Guid.Parse("ef768f5e-bfb2-4b5a-8595-2875a45cb23f"), SkillId = 1 },   // C#
                new OfferSkill { OfferSkillId = 182, OfferId = Guid.Parse("ef768f5e-bfb2-4b5a-8595-2875a45cb23f"), SkillId = 3 },   // JavaScript
                new OfferSkill { OfferSkillId = 183, OfferId = Guid.Parse("ef768f5e-bfb2-4b5a-8595-2875a45cb23f"), SkillId = 4 },   // Node.js
                new OfferSkill { OfferSkillId = 184, OfferId = Guid.Parse("ef768f5e-bfb2-4b5a-8595-2875a45cb23f"), SkillId = 8 },   // Excel
                new OfferSkill { OfferSkillId = 185, OfferId = Guid.Parse("ef768f5e-bfb2-4b5a-8595-2875a45cb23f"), SkillId = 15 },  // Presentaciones de ventas
                new OfferSkill { OfferSkillId = 186, OfferId = Guid.Parse("ef768f5e-bfb2-4b5a-8595-2875a45cb23f"), SkillId = 16 },  // Estrategias de venta
                new OfferSkill { OfferSkillId = 187, OfferId = Guid.Parse("ef768f5e-bfb2-4b5a-8595-2875a45cb23f"), SkillId = 18 },  // Selección de personal
                new OfferSkill { OfferSkillId = 188, OfferId = Guid.Parse("ef768f5e-bfb2-4b5a-8595-2875a45cb23f"), SkillId = 22 },  // SEM (Marketing en Motores de Búsqueda)
                new OfferSkill { OfferSkillId = 189, OfferId = Guid.Parse("ef768f5e-bfb2-4b5a-8595-2875a45cb23f"), SkillId = 23 },  // Marketing de Contenidos
                new OfferSkill { OfferSkillId = 190, OfferId = Guid.Parse("ef768f5e-bfb2-4b5a-8595-2875a45cb23f"), SkillId = 26 },   // Publicidad Digital

                new OfferSkill { OfferSkillId = 191, OfferId = Guid.Parse("3b15b056-2b44-4225-80ad-446252fd6864"), SkillId = 1 },    // C#
                new OfferSkill { OfferSkillId = 192, OfferId = Guid.Parse("3b15b056-2b44-4225-80ad-446252fd6864"), SkillId = 2 },    // Java
                new OfferSkill { OfferSkillId = 193, OfferId = Guid.Parse("3b15b056-2b44-4225-80ad-446252fd6864"), SkillId = 3 },    // JavaScript
                new OfferSkill { OfferSkillId = 194, OfferId = Guid.Parse("3b15b056-2b44-4225-80ad-446252fd6864"), SkillId = 4 },    // Node.js
                new OfferSkill { OfferSkillId = 195, OfferId = Guid.Parse("3b15b056-2b44-4225-80ad-446252fd6864"), SkillId = 5 },    // Angular
                new OfferSkill { OfferSkillId = 196, OfferId = Guid.Parse("3b15b056-2b44-4225-80ad-446252fd6864"), SkillId = 6 },    // React
                new OfferSkill { OfferSkillId = 197, OfferId = Guid.Parse("3b15b056-2b44-4225-80ad-446252fd6864"), SkillId = 7 },    // Vue.js
                new OfferSkill { OfferSkillId = 198, OfferId = Guid.Parse("3b15b056-2b44-4225-80ad-446252fd6864"), SkillId = 8 },    // Excel
                new OfferSkill { OfferSkillId = 199, OfferId = Guid.Parse("3b15b056-2b44-4225-80ad-446252fd6864"), SkillId = 11 },   // Git
                new OfferSkill { OfferSkillId = 200, OfferId = Guid.Parse("3b15b056-2b44-4225-80ad-446252fd6864"), SkillId = 12 },   // Docker
                new OfferSkill { OfferSkillId = 201, OfferId = Guid.Parse("3b15b056-2b44-4225-80ad-446252fd6864"), SkillId = 13 },   // Kubernetes
                new OfferSkill { OfferSkillId = 202, OfferId = Guid.Parse("3b15b056-2b44-4225-80ad-446252fd6864"), SkillId = 14 },   // AWS

                new OfferSkill { OfferSkillId = 203, OfferId = Guid.Parse("cf064e11-ebbb-4a2c-bbff-ef3e15bb68db"), SkillId = 24 },   // Ventas
                new OfferSkill { OfferSkillId = 204, OfferId = Guid.Parse("cf064e11-ebbb-4a2c-bbff-ef3e15bb68db"), SkillId = 25 },   // Servicio al cliente
                new OfferSkill { OfferSkillId = 205, OfferId = Guid.Parse("cf064e11-ebbb-4a2c-bbff-ef3e15bb68db"), SkillId = 26 },   // Negociación
                new OfferSkill { OfferSkillId = 206, OfferId = Guid.Parse("cf064e11-ebbb-4a2c-bbff-ef3e15bb68db"), SkillId = 27 },   // Comunicación efectiva
                new OfferSkill { OfferSkillId = 207, OfferId = Guid.Parse("cf064e11-ebbb-4a2c-bbff-ef3e15bb68db"), SkillId = 28 },   // Adaptabilidad
                new OfferSkill { OfferSkillId = 208, OfferId = Guid.Parse("cf064e11-ebbb-4a2c-bbff-ef3e15bb68db"), SkillId = 29 },   // Resolución de problemas
                new OfferSkill { OfferSkillId = 209, OfferId = Guid.Parse("cf064e11-ebbb-4a2c-bbff-ef3e15bb68db"), SkillId = 30 },   // Trabajo en equipo
                new OfferSkill { OfferSkillId = 210, OfferId = Guid.Parse("cf064e11-ebbb-4a2c-bbff-ef3e15bb68db"), SkillId = 31 },   // Organización
                new OfferSkill { OfferSkillId = 211, OfferId = Guid.Parse("cf064e11-ebbb-4a2c-bbff-ef3e15bb68db"), SkillId = 32 },   // Orientación al cliente
                new OfferSkill { OfferSkillId = 212, OfferId = Guid.Parse("cf064e11-ebbb-4a2c-bbff-ef3e15bb68db"), SkillId = 33 },   // Toma de decisiones
                new OfferSkill { OfferSkillId = 213, OfferId = Guid.Parse("cf064e11-ebbb-4a2c-bbff-ef3e15bb68db"), SkillId = 34 },   // Liderazgo

                new OfferSkill { OfferSkillId = 214, OfferId = Guid.Parse("73d35e46-f05d-49c0-8561-cda6f917d556"), SkillId = 35 },   // Desarrollo de aplicaciones móviles
                new OfferSkill { OfferSkillId = 215, OfferId = Guid.Parse("73d35e46-f05d-49c0-8561-cda6f917d556"), SkillId = 36 },   // iOS Development
                new OfferSkill { OfferSkillId = 216, OfferId = Guid.Parse("73d35e46-f05d-49c0-8561-cda6f917d556"), SkillId = 29 },   // Resolución de problemas
                new OfferSkill { OfferSkillId = 217, OfferId = Guid.Parse("73d35e46-f05d-49c0-8561-cda6f917d556"), SkillId = 30 },   // Trabajo en equipo
                new OfferSkill { OfferSkillId = 218, OfferId = Guid.Parse("73d35e46-f05d-49c0-8561-cda6f917d556"), SkillId = 37 },   // Agile Methodologies
                new OfferSkill { OfferSkillId = 219, OfferId = Guid.Parse("73d35e46-f05d-49c0-8561-cda6f917d556"), SkillId = 33 },   // Toma de decisiones
                new OfferSkill { OfferSkillId = 220, OfferId = Guid.Parse("73d35e46-f05d-49c0-8561-cda6f917d556"), SkillId = 28 },   // Adaptabilidad
                new OfferSkill { OfferSkillId = 221, OfferId = Guid.Parse("73d35e46-f05d-49c0-8561-cda6f917d556"), SkillId = 38 },   // Creatividad
                new OfferSkill { OfferSkillId = 222, OfferId = Guid.Parse("73d35e46-f05d-49c0-8561-cda6f917d556"), SkillId = 31 },   // Organización
                new OfferSkill { OfferSkillId = 223, OfferId = Guid.Parse("73d35e46-f05d-49c0-8561-cda6f917d556"), SkillId = 39 },   // Mejora continua
                new OfferSkill { OfferSkillId = 224, OfferId = Guid.Parse("73d35e46-f05d-49c0-8561-cda6f917d556"), SkillId = 34 },   // Liderazgo

                new OfferSkill { OfferSkillId = 225, OfferId = Guid.Parse("aece4b9c-1e0f-4385-bf2e-8ff209c8d684"), SkillId = 1 },    // C#
                new OfferSkill { OfferSkillId = 226, OfferId = Guid.Parse("aece4b9c-1e0f-4385-bf2e-8ff209c8d684"), SkillId = 2 },    // C++
                new OfferSkill { OfferSkillId = 227, OfferId = Guid.Parse("aece4b9c-1e0f-4385-bf2e-8ff209c8d684"), SkillId = 3 },    // JavaScript
                new OfferSkill { OfferSkillId = 228, OfferId = Guid.Parse("aece4b9c-1e0f-4385-bf2e-8ff209c8d684"), SkillId = 4 },    // Node.js
                new OfferSkill { OfferSkillId = 229, OfferId = Guid.Parse("aece4b9c-1e0f-4385-bf2e-8ff209c8d684"), SkillId = 5 },    // Ruby on Rails
                new OfferSkill { OfferSkillId = 230, OfferId = Guid.Parse("aece4b9c-1e0f-4385-bf2e-8ff209c8d684"), SkillId = 6 },    // AngularJS
                new OfferSkill { OfferSkillId = 231, OfferId = Guid.Parse("aece4b9c-1e0f-4385-bf2e-8ff209c8d684"), SkillId = 7 },    // React
                new OfferSkill { OfferSkillId = 232, OfferId = Guid.Parse("aece4b9c-1e0f-4385-bf2e-8ff209c8d684"), SkillId = 8 },    // Excel
                new OfferSkill { OfferSkillId = 233, OfferId = Guid.Parse("aece4b9c-1e0f-4385-bf2e-8ff209c8d684"), SkillId = 9 },    // SQL
                new OfferSkill { OfferSkillId = 234, OfferId = Guid.Parse("aece4b9c-1e0f-4385-bf2e-8ff209c8d684"), SkillId = 10 },   // MongoDB
                new OfferSkill { OfferSkillId = 235, OfferId = Guid.Parse("aece4b9c-1e0f-4385-bf2e-8ff209c8d684"), SkillId = 11 },   // PostgreSQL

                new OfferSkill { OfferSkillId = 236, OfferId = Guid.Parse("4c2e4700-6491-42c4-9da2-1c094bb09d1c"), SkillId = 9 },    // SQL
                new OfferSkill { OfferSkillId = 237, OfferId = Guid.Parse("4c2e4700-6491-42c4-9da2-1c094bb09d1c"), SkillId = 12 },   // Python
                new OfferSkill { OfferSkillId = 238, OfferId = Guid.Parse("4c2e4700-6491-42c4-9da2-1c094bb09d1c"), SkillId = 13 },   // R
                new OfferSkill { OfferSkillId = 239, OfferId = Guid.Parse("4c2e4700-6491-42c4-9da2-1c094bb09d1c"), SkillId = 14 },   // Tableau
                new OfferSkill { OfferSkillId = 240, OfferId = Guid.Parse("4c2e4700-6491-42c4-9da2-1c094bb09d1c"), SkillId = 15 },   // Power BI
                new OfferSkill { OfferSkillId = 241, OfferId = Guid.Parse("4c2e4700-6491-42c4-9da2-1c094bb09d1c"), SkillId = 16 },   // Data Analysis
                new OfferSkill { OfferSkillId = 242, OfferId = Guid.Parse("4c2e4700-6491-42c4-9da2-1c094bb09d1c"), SkillId = 17 },   // Data Visualization
                new OfferSkill { OfferSkillId = 243, OfferId = Guid.Parse("4c2e4700-6491-42c4-9da2-1c094bb09d1c"), SkillId = 18 },   // Database Management
                new OfferSkill { OfferSkillId = 244, OfferId = Guid.Parse("4c2e4700-6491-42c4-9da2-1c094bb09d1c"), SkillId = 19 },   // Digital Transformation
                new OfferSkill { OfferSkillId = 245, OfferId = Guid.Parse("4c2e4700-6491-42c4-9da2-1c094bb09d1c"), SkillId = 20 },   // Project Management

                new OfferSkill { OfferSkillId = 246, OfferId = Guid.Parse("4500dcbc-8d33-4814-9c95-4da24e53ff54"), SkillId = 21 },   // Sales
                new OfferSkill { OfferSkillId = 247, OfferId = Guid.Parse("4500dcbc-8d33-4814-9c95-4da24e53ff54"), SkillId = 22 },   // Customer Service
                new OfferSkill { OfferSkillId = 248, OfferId = Guid.Parse("4500dcbc-8d33-4814-9c95-4da24e53ff54"), SkillId = 23 },   // Communication
                new OfferSkill { OfferSkillId = 249, OfferId = Guid.Parse("4500dcbc-8d33-4814-9c95-4da24e53ff54"), SkillId = 24 },   // Negotiation
                new OfferSkill { OfferSkillId = 250, OfferId = Guid.Parse("4500dcbc-8d33-4814-9c95-4da24e53ff54"), SkillId = 25 },   // Financial Products
                new OfferSkill { OfferSkillId = 251, OfferId = Guid.Parse("4500dcbc-8d33-4814-9c95-4da24e53ff54"), SkillId = 26 },   // Relationship Management
                new OfferSkill { OfferSkillId = 252, OfferId = Guid.Parse("4500dcbc-8d33-4814-9c95-4da24e53ff54"), SkillId = 27 },   // Problem Solving

                new OfferSkill { OfferSkillId = 253, OfferId = Guid.Parse("6aa3a38a-dba0-4d26-8355-5c167f1501c6"), SkillId = 21 },   // Sales
                new OfferSkill { OfferSkillId = 254, OfferId = Guid.Parse("6aa3a38a-dba0-4d26-8355-5c167f1501c6"), SkillId = 22 },   // Customer Service
                new OfferSkill { OfferSkillId = 255, OfferId = Guid.Parse("6aa3a38a-dba0-4d26-8355-5c167f1501c6"), SkillId = 23 },   // Communication
                new OfferSkill { OfferSkillId = 256, OfferId = Guid.Parse("6aa3a38a-dba0-4d26-8355-5c167f1501c6"), SkillId = 24 },   // Negotiation
                new OfferSkill { OfferSkillId = 257, OfferId = Guid.Parse("6aa3a38a-dba0-4d26-8355-5c167f1501c6"), SkillId = 25 },   // Financial Products
                new OfferSkill { OfferSkillId = 258, OfferId = Guid.Parse("6aa3a38a-dba0-4d26-8355-5c167f1501c6"), SkillId = 26 },   // Relationship Management
                new OfferSkill { OfferSkillId = 259, OfferId = Guid.Parse("6aa3a38a-dba0-4d26-8355-5c167f1501c6"), SkillId = 27 },   // Problem Solving

                new OfferSkill { OfferSkillId = 260, OfferId = Guid.Parse("4e5e9b73-2141-48f6-a306-bb660dd6f451"), SkillId = 21 },   // Sales
                new OfferSkill { OfferSkillId = 261, OfferId = Guid.Parse("4e5e9b73-2141-48f6-a306-bb660dd6f451"), SkillId = 22 },   // Customer Service
                new OfferSkill { OfferSkillId = 262, OfferId = Guid.Parse("4e5e9b73-2141-48f6-a306-bb660dd6f451"), SkillId = 23 },   // Communication
                new OfferSkill { OfferSkillId = 263, OfferId = Guid.Parse("4e5e9b73-2141-48f6-a306-bb660dd6f451"), SkillId = 24 },   // Negotiation
                new OfferSkill { OfferSkillId = 264, OfferId = Guid.Parse("4e5e9b73-2141-48f6-a306-bb660dd6f451"), SkillId = 25 },   // Financial Products
                new OfferSkill { OfferSkillId = 265, OfferId = Guid.Parse("4e5e9b73-2141-48f6-a306-bb660dd6f451"), SkillId = 26 },   // Relationship Management
                new OfferSkill { OfferSkillId = 266, OfferId = Guid.Parse("4e5e9b73-2141-48f6-a306-bb660dd6f451"), SkillId = 27 },   // Problem Solving

                new OfferSkill { OfferSkillId = 267, OfferId = Guid.Parse("dfc5b3ac-af4e-42b4-bf9c-2a683a46059f"), SkillId = 41 }, // Compras y aprovisionamiento
                new OfferSkill { OfferSkillId = 268, OfferId = Guid.Parse("dfc5b3ac-af4e-42b4-bf9c-2a683a46059f"), SkillId = 42 }, // Logística de abastecimiento
                new OfferSkill { OfferSkillId = 269, OfferId = Guid.Parse("dfc5b3ac-af4e-42b4-bf9c-2a683a46059f"), SkillId = 38 }, // Cultura organizacional
                new OfferSkill { OfferSkillId = 270, OfferId = Guid.Parse("dfc5b3ac-af4e-42b4-bf9c-2a683a46059f"), SkillId = 39 }, // Gestión del cambio
                new OfferSkill { OfferSkillId = 271, OfferId = Guid.Parse("dfc5b3ac-af4e-42b4-bf9c-2a683a46059f"), SkillId = 5 },  // HTML
                new OfferSkill { OfferSkillId = 272, OfferId = Guid.Parse("dfc5b3ac-af4e-42b4-bf9c-2a683a46059f"), SkillId = 6 },  // CSS
                new OfferSkill { OfferSkillId = 273, OfferId = Guid.Parse("dfc5b3ac-af4e-42b4-bf9c-2a683a46059f"), SkillId = 27 }, // Analytics de Marketing
                new OfferSkill { OfferSkillId = 274, OfferId = Guid.Parse("dfc5b3ac-af4e-42b4-bf9c-2a683a46059f"), SkillId = 71 }, // PowerPoint
                new OfferSkill { OfferSkillId = 275, OfferId = Guid.Parse("dfc5b3ac-af4e-42b4-bf9c-2a683a46059f"), SkillId = 72 }, // Google Sheets
                new OfferSkill { OfferSkillId = 276, OfferId = Guid.Parse("dfc5b3ac-af4e-42b4-bf9c-2a683a46059f"), SkillId = 99 },  // Skype

                new OfferSkill { OfferSkillId = 277, OfferId = Guid.Parse("4c273bfd-06fd-4e2d-a5c1-d41e26a4ad13"), SkillId = 86 }, // Salesforce
                new OfferSkill { OfferSkillId = 278, OfferId = Guid.Parse("4c273bfd-06fd-4e2d-a5c1-d41e26a4ad13"), SkillId = 45 }, // Análisis de mercado
                new OfferSkill { OfferSkillId = 279, OfferId = Guid.Parse("4c273bfd-06fd-4e2d-a5c1-d41e26a4ad13"), SkillId = 47 }, // Gestión de proveedores
                new OfferSkill { OfferSkillId = 280, OfferId = Guid.Parse("4c273bfd-06fd-4e2d-a5c1-d41e26a4ad13"), SkillId = 48 }, // Gestión de la cadena de suministro
                new OfferSkill { OfferSkillId = 281, OfferId = Guid.Parse("4c273bfd-06fd-4e2d-a5c1-d41e26a4ad13"), SkillId = 82 }, // MATLAB
                new OfferSkill { OfferSkillId = 282, OfferId = Guid.Parse("4c273bfd-06fd-4e2d-a5c1-d41e26a4ad13"), SkillId = 134 }, // Rhino
                new OfferSkill { OfferSkillId = 283, OfferId = Guid.Parse("4c273bfd-06fd-4e2d-a5c1-d41e26a4ad13"), SkillId = 8 },  // Excel
                new OfferSkill { OfferSkillId = 284, OfferId = Guid.Parse("4c273bfd-06fd-4e2d-a5c1-d41e26a4ad13"), SkillId = 71 }, // PowerPoint
                new OfferSkill { OfferSkillId = 285, OfferId = Guid.Parse("4c273bfd-06fd-4e2d-a5c1-d41e26a4ad13"), SkillId = 27 }, // Analytics de Marketing
                new OfferSkill { OfferSkillId = 286, OfferId = Guid.Parse("4c273bfd-06fd-4e2d-a5c1-d41e26a4ad13"), SkillId = 6 },   // CSS

                new OfferSkill { OfferSkillId = 287, OfferId = Guid.Parse("4c273bfd-06fd-4e2d-a5c1-d41e26a9ad13"), SkillId = 94 }, // Control PLC
                new OfferSkill { OfferSkillId = 288, OfferId = Guid.Parse("4c273bfd-06fd-4e2d-a5c1-d41e26a9ad13"), SkillId = 95 }, // HMI/SCADA
                new OfferSkill { OfferSkillId = 289, OfferId = Guid.Parse("4c273bfd-06fd-4e2d-a5c1-d41e26a9ad13"), SkillId = 96 }, // Sistemas de visión artificial
                new OfferSkill { OfferSkillId = 290, OfferId = Guid.Parse("4c273bfd-06fd-4e2d-a5c1-d41e26a9ad13"), SkillId = 97 }, // Robótica
                new OfferSkill { OfferSkillId = 291, OfferId = Guid.Parse("4c273bfd-06fd-4e2d-a5c1-d41e26a9ad13"), SkillId = 82 }, // MATLAB
                new OfferSkill { OfferSkillId = 292, OfferId = Guid.Parse("4c273bfd-06fd-4e2d-a5c1-d41e26a9ad13"), SkillId = 27 }, // Analytics de Marketing
                new OfferSkill { OfferSkillId = 293, OfferId = Guid.Parse("4c273bfd-06fd-4e2d-a5c1-d41e26a9ad13"), SkillId = 6 },   // CSS

                new OfferSkill { OfferSkillId = 294, OfferId = Guid.Parse("2a727bb0-902d-4f96-b57b-2a6e39d8a60e"), SkillId = 70 }, // Organización de eventos
                new OfferSkill { OfferSkillId = 295, OfferId = Guid.Parse("2a727bb0-902d-4f96-b57b-2a6e39d8a60e"), SkillId = 43 }, // Gestión de inventario
                new OfferSkill { OfferSkillId = 296, OfferId = Guid.Parse("2a727bb0-902d-4f96-b57b-2a6e39d8a60e"), SkillId = 67 }, // Control de gastos
                new OfferSkill { OfferSkillId = 297, OfferId = Guid.Parse("2a727bb0-902d-4f96-b57b-2a6e39d8a60e"), SkillId = 37 }, // Evaluación del desempeño
                new OfferSkill { OfferSkillId = 298, OfferId = Guid.Parse("2a727bb0-902d-4f96-b57b-2a6e39d8a60e"), SkillId = 64 }, // Atención telefónica
                new OfferSkill { OfferSkillId = 299, OfferId = Guid.Parse("2a727bb0-902d-4f96-b57b-2a6e39d8a60e"), SkillId = 77 }, // Adobe Illustrator
                new OfferSkill { OfferSkillId = 300, OfferId = Guid.Parse("2a727bb0-902d-4f96-b57b-2a6e39d8a60e"), SkillId = 78 }, // Adobe InDesign
                new OfferSkill { OfferSkillId = 301, OfferId = Guid.Parse("2a727bb0-902d-4f96-b57b-2a6e39d8a60e"), SkillId = 75 }, // Microsoft Access
                new OfferSkill { OfferSkillId = 302, OfferId = Guid.Parse("2a727bb0-902d-4f96-b57b-2a6e39d8a60e"), SkillId = 76 }, // QuickBooks
                new OfferSkill { OfferSkillId = 303, OfferId = Guid.Parse("2a727bb0-902d-4f96-b57b-2a6e39d8a60e"), SkillId = 86 },  // Salesforce

                new OfferSkill { OfferSkillId = 304, OfferId = Guid.Parse("f4e7a8c0-0253-4baf-bd54-9a119ed81e5f"), SkillId = 42 }, // Logística de abastecimiento
                new OfferSkill { OfferSkillId = 305, OfferId = Guid.Parse("f4e7a8c0-0253-4baf-bd54-9a119ed81e5f"), SkillId = 48 }, // Gestión de la cadena de suministro
                new OfferSkill { OfferSkillId = 306, OfferId = Guid.Parse("f4e7a8c0-0253-4baf-bd54-9a119ed81e5f"), SkillId = 88 }, // JIRA
                new OfferSkill { OfferSkillId = 307, OfferId = Guid.Parse("f4e7a8c0-0253-4baf-bd54-9a119ed81e5f"), SkillId = 89 }, // Confluence
                new OfferSkill { OfferSkillId = 308, OfferId = Guid.Parse("f4e7a8c0-0253-4baf-bd54-9a119ed81e5f"), SkillId = 90 }, // Zendesk
                new OfferSkill { OfferSkillId = 309, OfferId = Guid.Parse("f4e7a8c0-0253-4baf-bd54-9a119ed81e5f"), SkillId = 64 }, // Atención telefónica
                new OfferSkill { OfferSkillId = 310, OfferId = Guid.Parse("f4e7a8c0-0253-4baf-bd54-9a119ed81e5f"), SkillId = 95 }, // Slack
                new OfferSkill { OfferSkillId = 311, OfferId = Guid.Parse("f4e7a8c0-0253-4baf-bd54-9a119ed81e5f"), SkillId = 92 }, // GitLab
                new OfferSkill { OfferSkillId = 312, OfferId = Guid.Parse("f4e7a8c0-0253-4baf-bd54-9a119ed81e5f"), SkillId = 86 }, // Salesforce
                new OfferSkill { OfferSkillId = 313, OfferId = Guid.Parse("f4e7a8c0-0253-4baf-bd54-9a119ed81e5f"), SkillId = 105 },  // After Effects

                new OfferSkill { OfferSkillId = 314, OfferId = Guid.Parse("c45c63c4-bc31-4397-a38a-84241e441028"), SkillId = 1 }, // C#
                new OfferSkill { OfferSkillId = 315, OfferId = Guid.Parse("c45c63c4-bc31-4397-a38a-84241e441028"), SkillId = 3 }, // JavaScript
                new OfferSkill { OfferSkillId = 316, OfferId = Guid.Parse("c45c63c4-bc31-4397-a38a-84241e441028"), SkillId = 34 }, // Compensación y beneficios
                new OfferSkill { OfferSkillId = 317, OfferId = Guid.Parse("c45c63c4-bc31-4397-a38a-84241e441028"), SkillId = 48 }, // Gestión de la cadena de suministro
                new OfferSkill { OfferSkillId = 318, OfferId = Guid.Parse("c45c63c4-bc31-4397-a38a-84241e441028"), SkillId = 28 }, // Estrategia de Marketing
                new OfferSkill { OfferSkillId = 319, OfferId = Guid.Parse("c45c63c4-bc31-4397-a38a-84241e441028"), SkillId = 27 }, // Analytics de Marketing
                new OfferSkill { OfferSkillId = 320, OfferId = Guid.Parse("c45c63c4-bc31-4397-a38a-84241e441028"), SkillId = 29 }, // Investigación de Mercado
                new OfferSkill { OfferSkillId = 321, OfferId = Guid.Parse("c45c63c4-bc31-4397-a38a-84241e441028"), SkillId = 4 }, // Node.Js
                new OfferSkill { OfferSkillId = 322, OfferId = Guid.Parse("c45c63c4-bc31-4397-a38a-84241e441028"), SkillId = 5 }, // HTML
                new OfferSkill { OfferSkillId = 323, OfferId = Guid.Parse("c45c63c4-bc31-4397-a38a-84241e441028"), SkillId = 6 },  // CSS

                new OfferSkill { OfferSkillId = 324, OfferId = Guid.Parse("bbd240b5-09f1-497f-a74f-24831e84dfe2"), SkillId = 68 }, // Manejo de bases de datos
                new OfferSkill { OfferSkillId = 325, OfferId = Guid.Parse("bbd240b5-09f1-497f-a74f-24831e84dfe2"), SkillId = 71 }, // PowerPoint
                new OfferSkill { OfferSkillId = 326, OfferId = Guid.Parse("bbd240b5-09f1-497f-a74f-24831e84dfe2"), SkillId = 65 }, // Gestión de correos electrónicos
                new OfferSkill { OfferSkillId = 327, OfferId = Guid.Parse("bbd240b5-09f1-497f-a74f-24831e84dfe2"), SkillId = 66 }, // Facturación y cobranza
                new OfferSkill { OfferSkillId = 328, OfferId = Guid.Parse("bbd240b5-09f1-497f-a74f-24831e84dfe2"), SkillId = 40 }, // Gestión del rendimiento
                new OfferSkill { OfferSkillId = 329, OfferId = Guid.Parse("bbd240b5-09f1-497f-a74f-24831e84dfe2"), SkillId = 69 }, // Elaboración de informes
                new OfferSkill { OfferSkillId = 330, OfferId = Guid.Parse("bbd240b5-09f1-497f-a74f-24831e84dfe2"), SkillId = 60 }, // Asesoría en marketing
                new OfferSkill { OfferSkillId = 331, OfferId = Guid.Parse("bbd240b5-09f1-497f-a74f-24831e84dfe2"), SkillId = 19 }, // Capacitación y desarrollo
                new OfferSkill { OfferSkillId = 332, OfferId = Guid.Parse("bbd240b5-09f1-497f-a74f-24831e84dfe2"), SkillId = 10 }, // Ventas consultivas
                new OfferSkill { OfferSkillId = 333, OfferId = Guid.Parse("bbd240b5-09f1-497f-a74f-24831e84dfe2"), SkillId = 11 },  // Cierre de ventas

                new OfferSkill { OfferSkillId = 334, OfferId = Guid.Parse("e7d81f16-93f1-462e-87c4-3a7b80db23d4"), SkillId = 49 }, // Exportaciones e importaciones
                new OfferSkill { OfferSkillId = 335, OfferId = Guid.Parse("e7d81f16-93f1-462e-87c4-3a7b80db23d4"), SkillId = 94 }, // Asana
                new OfferSkill { OfferSkillId = 336, OfferId = Guid.Parse("e7d81f16-93f1-462e-87c4-3a7b80db23d4"), SkillId = 10 }, // Ventas consultivas
                new OfferSkill { OfferSkillId = 337, OfferId = Guid.Parse("e7d81f16-93f1-462e-87c4-3a7b80db23d4"), SkillId = 9 },  // Word
                new OfferSkill { OfferSkillId = 338, OfferId = Guid.Parse("e7d81f16-93f1-462e-87c4-3a7b80db23d4"), SkillId = 38 }, // Cultura organizacional
                new OfferSkill { OfferSkillId = 339, OfferId = Guid.Parse("e7d81f16-93f1-462e-87c4-3a7b80db23d4"), SkillId = 70 }, // Organización de eventos
                new OfferSkill { OfferSkillId = 340, OfferId = Guid.Parse("e7d81f16-93f1-462e-87c4-3a7b80db23d4"), SkillId = 27 }, // Analytics de Marketing
                new OfferSkill { OfferSkillId = 341, OfferId = Guid.Parse("e7d81f16-93f1-462e-87c4-3a7b80db23d4"), SkillId = 46 }, // Estrategia de precios
                new OfferSkill { OfferSkillId = 342, OfferId = Guid.Parse("e7d81f16-93f1-462e-87c4-3a7b80db23d4"), SkillId = 67 }, // Control de gastos
                new OfferSkill { OfferSkillId = 343, OfferId = Guid.Parse("e7d81f16-93f1-462e-87c4-3a7b80db23d4"), SkillId = 60 },  // Asesoría en marketing

                new OfferSkill { OfferSkillId = 344, OfferId = Guid.Parse("a8f1d525-85cf-47c5-80dc-1a6db6b687b0"), SkillId = 3 },   // JavaScript
                new OfferSkill { OfferSkillId = 345, OfferId = Guid.Parse("a8f1d525-85cf-47c5-80dc-1a6db6b687b0"), SkillId = 4 },   // Node.Js
                new OfferSkill { OfferSkillId = 346, OfferId = Guid.Parse("a8f1d525-85cf-47c5-80dc-1a6db6b687b0"), SkillId = 80 },  // AutoCAD
                new OfferSkill { OfferSkillId = 347, OfferId = Guid.Parse("a8f1d525-85cf-47c5-80dc-1a6db6b687b0"), SkillId = 85 },  // SAP
                new OfferSkill { OfferSkillId = 348, OfferId = Guid.Parse("a8f1d525-85cf-47c5-80dc-1a6db6b687b0"), SkillId = 86 },  // Salesforce
                new OfferSkill { OfferSkillId = 349, OfferId = Guid.Parse("a8f1d525-85cf-47c5-80dc-1a6db6b687b0"), SkillId = 87 },  // Tableau
                new OfferSkill { OfferSkillId = 350, OfferId = Guid.Parse("a8f1d525-85cf-47c5-80dc-1a6db6b687b0"), SkillId = 88 },  // JIRA
                new OfferSkill { OfferSkillId = 351, OfferId = Guid.Parse("a8f1d525-85cf-47c5-80dc-1a6db6b687b0"), SkillId = 89 },  // Confluence
                new OfferSkill { OfferSkillId = 352, OfferId = Guid.Parse("a8f1d525-85cf-47c5-80dc-1a6db6b687b0"), SkillId = 90 },  // Zendesk
                new OfferSkill { OfferSkillId = 353, OfferId = Guid.Parse("a8f1d525-85cf-47c5-80dc-1a6db6b687b0"), SkillId = 91 },   // GitHub

                new OfferSkill { OfferSkillId = 354, OfferId = Guid.Parse("43172e18-c20b-41d1-b16d-5e15b7e788d7"), SkillId = 49 },  // Exportaciones e importaciones
                new OfferSkill { OfferSkillId = 355, OfferId = Guid.Parse("43172e18-c20b-41d1-b16d-5e15b7e788d7"), SkillId = 50 },  // Comercio electrónico
                new OfferSkill { OfferSkillId = 356, OfferId = Guid.Parse("43172e18-c20b-41d1-b16d-5e15b7e788d7"), SkillId = 52 },  // Asesoría legal
                new OfferSkill { OfferSkillId = 357, OfferId = Guid.Parse("43172e18-c20b-41d1-b16d-5e15b7e788d7"), SkillId = 59 },  // Asesoría en recursos humanos
                new OfferSkill { OfferSkillId = 358, OfferId = Guid.Parse("43172e18-c20b-41d1-b16d-5e15b7e788d7"), SkillId = 60 },  // Asesoría en marketing
                new OfferSkill { OfferSkillId = 359, OfferId = Guid.Parse("43172e18-c20b-41d1-b16d-5e15b7e788d7"), SkillId = 65 },  // Gestión de correos electrónicos
                new OfferSkill { OfferSkillId = 360, OfferId = Guid.Parse("43172e18-c20b-41d1-b16d-5e15b7e788d7"), SkillId = 68 },  // Manejo de bases de datos
                new OfferSkill { OfferSkillId = 361, OfferId = Guid.Parse("43172e18-c20b-41d1-b16d-5e15b7e788d7"), SkillId = 70 },  // Organización de eventos
                new OfferSkill { OfferSkillId = 362, OfferId = Guid.Parse("43172e18-c20b-41d1-b16d-5e15b7e788d7"), SkillId = 76 },  // QuickBooks
                new OfferSkill { OfferSkillId = 363, OfferId = Guid.Parse("43172e18-c20b-41d1-b16d-5e15b7e788d7"), SkillId = 94 },   // Asana

                new OfferSkill { OfferSkillId = 364, OfferId = Guid.Parse("1f8dbf01-6d33-4d6c-9d02-22686b739cf4"), SkillId = 14 },  // Programación
                new OfferSkill { OfferSkillId = 365, OfferId = Guid.Parse("1f8dbf01-6d33-4d6c-9d02-22686b739cf4"), SkillId = 15 },  // Bases de datos
                new OfferSkill { OfferSkillId = 366, OfferId = Guid.Parse("1f8dbf01-6d33-4d6c-9d02-22686b739cf4"), SkillId = 16 },  // Arquitectura de datos
                new OfferSkill { OfferSkillId = 367, OfferId = Guid.Parse("1f8dbf01-6d33-4d6c-9d02-22686b739cf4"), SkillId = 17 },  // Análisis de datos
                new OfferSkill { OfferSkillId = 368, OfferId = Guid.Parse("1f8dbf01-6d33-4d6c-9d02-22686b739cf4"), SkillId = 33 },  // Inglés avanzado
                new OfferSkill { OfferSkillId = 369, OfferId = Guid.Parse("1f8dbf01-6d33-4d6c-9d02-22686b739cf4"), SkillId = 36 },   // Trabajo en equipo

                new OfferSkill { OfferSkillId = 370, OfferId = Guid.Parse("99c4892f-d048-459e-ae27-7dd3fd0b0839"), SkillId = 41 }, // Compras y aprovisionamiento
                new OfferSkill { OfferSkillId = 371, OfferId = Guid.Parse("99c4892f-d048-459e-ae27-7dd3fd0b0839"), SkillId = 42 }, // Logística de abastecimiento
                new OfferSkill { OfferSkillId = 372, OfferId = Guid.Parse("99c4892f-d048-459e-ae27-7dd3fd0b0839"), SkillId = 43 }, // Gestión de inventario
                new OfferSkill { OfferSkillId = 373, OfferId = Guid.Parse("99c4892f-d048-459e-ae27-7dd3fd0b0839"), SkillId = 44 }, // Planificación de la demanda
                new OfferSkill { OfferSkillId = 374, OfferId = Guid.Parse("99c4892f-d048-459e-ae27-7dd3fd0b0839"), SkillId = 46 }, // Estrategia de precios
                new OfferSkill { OfferSkillId = 375, OfferId = Guid.Parse("99c4892f-d048-459e-ae27-7dd3fd0b0839"), SkillId = 47 }, // Gestión de proveedores
                new OfferSkill { OfferSkillId = 376, OfferId = Guid.Parse("99c4892f-d048-459e-ae27-7dd3fd0b0839"), SkillId = 48 }, // Gestión de la cadena de suministro
                new OfferSkill { OfferSkillId = 377, OfferId = Guid.Parse("99c4892f-d048-459e-ae27-7dd3fd0b0839"), SkillId = 69 }, // Elaboración de informes
                new OfferSkill { OfferSkillId = 378, OfferId = Guid.Parse("99c4892f-d048-459e-ae27-7dd3fd0b0839"), SkillId = 67 }, // Control de gastos
                new OfferSkill { OfferSkillId = 379, OfferId = Guid.Parse("99c4892f-d048-459e-ae27-7dd3fd0b0839"), SkillId = 40 },  // Gestión del rendimiento

                new OfferSkill { OfferSkillId = 380, OfferId = Guid.Parse("c64b0cc7-bd3d-4db3-91c1-4cc6f8dbb3d2"), SkillId = 10 }, // Ventas consultivas
                new OfferSkill { OfferSkillId = 381, OfferId = Guid.Parse("c64b0cc7-bd3d-4db3-91c1-4cc6f8dbb3d2"), SkillId = 11 }, // Cierre de ventas
                new OfferSkill { OfferSkillId = 382, OfferId = Guid.Parse("c64b0cc7-bd3d-4db3-91c1-4cc6f8dbb3d2"), SkillId = 12 }, // Prospección de clientes
                new OfferSkill { OfferSkillId = 383, OfferId = Guid.Parse("c64b0cc7-bd3d-4db3-91c1-4cc6f8dbb3d2"), SkillId = 13 }, // Manejo de objeciones
                new OfferSkill { OfferSkillId = 384, OfferId = Guid.Parse("c64b0cc7-bd3d-4db3-91c1-4cc6f8dbb3d2"), SkillId = 14 }, // Relaciones comerciales
                new OfferSkill { OfferSkillId = 385, OfferId = Guid.Parse("c64b0cc7-bd3d-4db3-91c1-4cc6f8dbb3d2"), SkillId = 15 }, // Presentaciones de ventas
                new OfferSkill { OfferSkillId = 386, OfferId = Guid.Parse("c64b0cc7-bd3d-4db3-91c1-4cc6f8dbb3d2"), SkillId = 16 }, // Estrategias de venta
                new OfferSkill { OfferSkillId = 387, OfferId = Guid.Parse("c64b0cc7-bd3d-4db3-91c1-4cc6f8dbb3d2"), SkillId = 17 }, // Gestión del talento
                new OfferSkill { OfferSkillId = 388, OfferId = Guid.Parse("c64b0cc7-bd3d-4db3-91c1-4cc6f8dbb3d2"), SkillId = 18 }, // Selección de personal
                new OfferSkill { OfferSkillId = 389, OfferId = Guid.Parse("c64b0cc7-bd3d-4db3-91c1-4cc6f8dbb3d2"), SkillId = 19 },  // Capacitación y desarrollo

                new OfferSkill { OfferSkillId = 390, OfferId = Guid.Parse("2cf0284d-143f-4375-8a07-4d5e2c38a54e"), SkillId = 10 }, // Ventas consultivas
                new OfferSkill { OfferSkillId = 391, OfferId = Guid.Parse("2cf0284d-143f-4375-8a07-4d5e2c38a54e"), SkillId = 11 }, // Cierre de ventas
                new OfferSkill { OfferSkillId = 392, OfferId = Guid.Parse("2cf0284d-143f-4375-8a07-4d5e2c38a54e"), SkillId = 12 }, // Prospección de clientes
                new OfferSkill { OfferSkillId = 393, OfferId = Guid.Parse("2cf0284d-143f-4375-8a07-4d5e2c38a54e"), SkillId = 13 }, // Manejo de objeciones
                new OfferSkill { OfferSkillId = 394, OfferId = Guid.Parse("2cf0284d-143f-4375-8a07-4d5e2c38a54e"), SkillId = 14 }, // Relaciones comerciales
                new OfferSkill { OfferSkillId = 395, OfferId = Guid.Parse("2cf0284d-143f-4375-8a07-4d5e2c38a54e"), SkillId = 16 }, // Estrategias de venta
                new OfferSkill { OfferSkillId = 396, OfferId = Guid.Parse("2cf0284d-143f-4375-8a07-4d5e2c38a54e"), SkillId = 17 }, // Gestión del talento
                new OfferSkill { OfferSkillId = 397, OfferId = Guid.Parse("2cf0284d-143f-4375-8a07-4d5e2c38a54e"), SkillId = 18 }, // Selección de personal
                new OfferSkill { OfferSkillId = 398, OfferId = Guid.Parse("2cf0284d-143f-4375-8a07-4d5e2c38a54e"), SkillId = 19 },  // Capacitación y desarrollo

                new OfferSkill { OfferSkillId = 399, OfferId = Guid.Parse("3a4c5c3d-8b42-4600-9a6a-6e34f1d98d4a"), SkillId = 20 }, // Análisis de mercado
                new OfferSkill { OfferSkillId = 400, OfferId = Guid.Parse("3a4c5c3d-8b42-4600-9a6a-6e34f1d98d4a"), SkillId = 21 }, // Investigación de mercado
                new OfferSkill { OfferSkillId = 401, OfferId = Guid.Parse("3a4c5c3d-8b42-4600-9a6a-6e34f1d98d4a"), SkillId = 22 }, // Análisis de competencia
                new OfferSkill { OfferSkillId = 402, OfferId = Guid.Parse("3a4c5c3d-8b42-4600-9a6a-6e34f1d98d4a"), SkillId = 23 }, // Modelos analíticos
                new OfferSkill { OfferSkillId = 403, OfferId = Guid.Parse("3a4c5c3d-8b42-4600-9a6a-6e34f1d98d4a"), SkillId = 24 }, // Indicadores clave de rendimiento (KPI)
                new OfferSkill { OfferSkillId = 404, OfferId = Guid.Parse("3a4c5c3d-8b42-4600-9a6a-6e34f1d98d4a"), SkillId = 25 }, // Herramientas de análisis de datos

                new OfferSkill { OfferSkillId = 405, OfferId = Guid.Parse("c7cfc748-3e39-42c8-8dd9-dc326d9a0362"), SkillId = 50 }, // Comercio electrónico
                new OfferSkill { OfferSkillId = 406, OfferId = Guid.Parse("c7cfc748-3e39-42c8-8dd9-dc326d9a0362"), SkillId = 39 }, // Gestión del cambio
                new OfferSkill { OfferSkillId = 407, OfferId = Guid.Parse("c7cfc748-3e39-42c8-8dd9-dc326d9a0362"), SkillId = 37 }, // Evaluación del desempeño
                new OfferSkill { OfferSkillId = 408, OfferId = Guid.Parse("c7cfc748-3e39-42c8-8dd9-dc326d9a0362"), SkillId = 2 },  // C
                new OfferSkill { OfferSkillId = 409, OfferId = Guid.Parse("c7cfc748-3e39-42c8-8dd9-dc326d9a0362"), SkillId = 85 }, // SAP
                new OfferSkill { OfferSkillId = 410, OfferId = Guid.Parse("c7cfc748-3e39-42c8-8dd9-dc326d9a0362"), SkillId = 114 }, // FL Studio
                new OfferSkill { OfferSkillId = 411, OfferId = Guid.Parse("c7cfc748-3e39-42c8-8dd9-dc326d9a0362"), SkillId = 54 }, // Asesoría en inversiones
                new OfferSkill { OfferSkillId = 412, OfferId = Guid.Parse("c7cfc748-3e39-42c8-8dd9-dc326d9a0362"), SkillId = 126 }, // CorelDRAW
                new OfferSkill { OfferSkillId = 413, OfferId = Guid.Parse("c7cfc748-3e39-42c8-8dd9-dc326d9a0362"), SkillId = 138 }, // Cinema 4D
                new OfferSkill { OfferSkillId = 414, OfferId = Guid.Parse("c7cfc748-3e39-42c8-8dd9-dc326d9a0362"), SkillId = 92 },  // GitLab

                new OfferSkill { OfferSkillId = 415, OfferId = Guid.Parse("9a2e26ab-9a47-4b71-907b-9a6c4e9db9d5"), SkillId = 23 }, // Marketing de Contenidos
                new OfferSkill { OfferSkillId = 416, OfferId = Guid.Parse("9a2e26ab-9a47-4b71-907b-9a6c4e9db9d5"), SkillId = 24 }, // Email Marketing
                new OfferSkill { OfferSkillId = 417, OfferId = Guid.Parse("9a2e26ab-9a47-4b71-907b-9a6c4e9db9d5"), SkillId = 25 }, // Marketing en Redes Sociales
                new OfferSkill { OfferSkillId = 418, OfferId = Guid.Parse("9a2e26ab-9a47-4b71-907b-9a6c4e9db9d5"), SkillId = 26 }, // Publicidad Digital
                new OfferSkill { OfferSkillId = 419, OfferId = Guid.Parse("9a2e26ab-9a47-4b71-907b-9a6c4e9db9d5"), SkillId = 71 }, // PowerPoint
                new OfferSkill { OfferSkillId = 420, OfferId = Guid.Parse("9a2e26ab-9a47-4b71-907b-9a6c4e9db9d5"), SkillId = 67 }, // Control de gastos
                new OfferSkill { OfferSkillId = 421, OfferId = Guid.Parse("9a2e26ab-9a47-4b71-907b-9a6c4e9db9d5"), SkillId = 38 }, // Cultura organizacional
                new OfferSkill { OfferSkillId = 422, OfferId = Guid.Parse("9a2e26ab-9a47-4b71-907b-9a6c4e9db9d5"), SkillId = 93 }, // Trello
                new OfferSkill { OfferSkillId = 423, OfferId = Guid.Parse("9a2e26ab-9a47-4b71-907b-9a6c4e9db9d5"), SkillId = 100 }, // Google Meet
                new OfferSkill { OfferSkillId = 424, OfferId = Guid.Parse("9a2e26ab-9a47-4b71-907b-9a6c4e9db9d5"), SkillId = 123 },  // Axure RP

                new OfferSkill { OfferSkillId = 425, OfferId = Guid.Parse("cbf7c2f6-fb22-4a5e-ae56-60798fcdaf35"), SkillId = 49 }, // Exportaciones e importaciones
                new OfferSkill { OfferSkillId = 426, OfferId = Guid.Parse("cbf7c2f6-fb22-4a5e-ae56-60798fcdaf35"), SkillId = 39 }, // Gestión del cambio
                new OfferSkill { OfferSkillId = 427, OfferId = Guid.Parse("cbf7c2f6-fb22-4a5e-ae56-60798fcdaf35"), SkillId = 37 }, // Evaluación del desempeño
                new OfferSkill { OfferSkillId = 428, OfferId = Guid.Parse("cbf7c2f6-fb22-4a5e-ae56-60798fcdaf35"), SkillId = 9 },  // Word
                new OfferSkill { OfferSkillId = 429, OfferId = Guid.Parse("cbf7c2f6-fb22-4a5e-ae56-60798fcdaf35"), SkillId = 85 }, // SAP
                new OfferSkill { OfferSkillId = 430, OfferId = Guid.Parse("cbf7c2f6-fb22-4a5e-ae56-60798fcdaf35"), SkillId = 3 },  // JavaScript
                new OfferSkill { OfferSkillId = 431, OfferId = Guid.Parse("cbf7c2f6-fb22-4a5e-ae56-60798fcdaf35"), SkillId = 100 }, // Google Meet
                new OfferSkill { OfferSkillId = 432, OfferId = Guid.Parse("cbf7c2f6-fb22-4a5e-ae56-60798fcdaf35"), SkillId = 113 }, // Ableton Live
                new OfferSkill { OfferSkillId = 433, OfferId = Guid.Parse("cbf7c2f6-fb22-4a5e-ae56-60798fcdaf35"), SkillId = 7 },  // Photoshop
                new OfferSkill { OfferSkillId = 434, OfferId = Guid.Parse("cbf7c2f6-fb22-4a5e-ae56-60798fcdaf35"), SkillId = 92 },  // GitLab

                new OfferSkill { OfferSkillId = 435, OfferId = Guid.Parse("cfb54849-13f6-4db0-aa4b-810c502b5de5"), SkillId = 49 }, // Exportaciones e importaciones
                new OfferSkill { OfferSkillId = 436, OfferId = Guid.Parse("cfb54849-13f6-4db0-aa4b-810c502b5de5"), SkillId = 25 }, // Marketing en Redes Sociales
                new OfferSkill { OfferSkillId = 437, OfferId = Guid.Parse("cfb54849-13f6-4db0-aa4b-810c502b5de5"), SkillId = 74 }, // Google Slides
                new OfferSkill { OfferSkillId = 438, OfferId = Guid.Parse("cfb54849-13f6-4db0-aa4b-810c502b5de5"), SkillId = 80 }, // AutoCAD
                new OfferSkill { OfferSkillId = 439, OfferId = Guid.Parse("cfb54849-13f6-4db0-aa4b-810c502b5de5"), SkillId = 6 },  // CSS
                new OfferSkill { OfferSkillId = 440, OfferId = Guid.Parse("cfb54849-13f6-4db0-aa4b-810c502b5de5"), SkillId = 19 }, // Capacitación y desarrollo
                new OfferSkill { OfferSkillId = 441, OfferId = Guid.Parse("cfb54849-13f6-4db0-aa4b-810c502b5de5"), SkillId = 35 }, // Relaciones laborales
                new OfferSkill { OfferSkillId = 442, OfferId = Guid.Parse("cfb54849-13f6-4db0-aa4b-810c502b5de5"), SkillId = 24 }, // Email Marketing
                new OfferSkill { OfferSkillId = 443, OfferId = Guid.Parse("cfb54849-13f6-4db0-aa4b-810c502b5de5"), SkillId = 62 }, // Coordinación de agendas
                new OfferSkill { OfferSkillId = 444, OfferId = Guid.Parse("cfb54849-13f6-4db0-aa4b-810c502b5de5"), SkillId = 97 },  // Zoom

                new OfferSkill { OfferSkillId = 445, OfferId = Guid.Parse("3bd4a3b0-d922-41f4-b32e-683372920c77"), SkillId = 103 }, // InDesign
                new OfferSkill { OfferSkillId = 446, OfferId = Guid.Parse("3bd4a3b0-d922-41f4-b32e-683372920c77"), SkillId = 121 }, // Marvel
                new OfferSkill { OfferSkillId = 447, OfferId = Guid.Parse("3bd4a3b0-d922-41f4-b32e-683372920c77"), SkillId = 76 },  // QuickBooks
                new OfferSkill { OfferSkillId = 448, OfferId = Guid.Parse("3bd4a3b0-d922-41f4-b32e-683372920c77"), SkillId = 93 },  // Trello
                new OfferSkill { OfferSkillId = 449, OfferId = Guid.Parse("3bd4a3b0-d922-41f4-b32e-683372920c77"), SkillId = 82 },  // MATLAB
                new OfferSkill { OfferSkillId = 450, OfferId = Guid.Parse("3bd4a3b0-d922-41f4-b32e-683372920c77"), SkillId = 52 },  // Asesoría legal
                new OfferSkill { OfferSkillId = 451, OfferId = Guid.Parse("3bd4a3b0-d922-41f4-b32e-683372920c77"), SkillId = 35 },  // Relaciones laborales
                new OfferSkill { OfferSkillId = 452, OfferId = Guid.Parse("3bd4a3b0-d922-41f4-b32e-683372920c77"), SkillId = 46 },  // Estrategia de precios
                new OfferSkill { OfferSkillId = 453, OfferId = Guid.Parse("3bd4a3b0-d922-41f4-b32e-683372920c77"), SkillId = 70 },  // Organización de eventos
                new OfferSkill { OfferSkillId = 454, OfferId = Guid.Parse("3bd4a3b0-d922-41f4-b32e-683372920c77"), SkillId = 48 },   // Gestión de la cadena de suministro

                new OfferSkill { OfferSkillId = 455, OfferId = Guid.Parse("d394e91d-6950-4485-b2d2-0c1e8f2ad588"), SkillId = 39 }, // Gestión del cambio
                new OfferSkill { OfferSkillId = 456, OfferId = Guid.Parse("d394e91d-6950-4485-b2d2-0c1e8f2ad588"), SkillId = 44 }, // Planificación de la demanda
                new OfferSkill { OfferSkillId = 457, OfferId = Guid.Parse("d394e91d-6950-4485-b2d2-0c1e8f2ad588"), SkillId = 46 }, // Estrategia de precios
                new OfferSkill { OfferSkillId = 458, OfferId = Guid.Parse("d394e91d-6950-4485-b2d2-0c1e8f2ad588"), SkillId = 70 }, // Organización de eventos
                new OfferSkill { OfferSkillId = 459, OfferId = Guid.Parse("d394e91d-6950-4485-b2d2-0c1e8f2ad588"), SkillId = 71 }, // PowerPoint
                new OfferSkill { OfferSkillId = 460, OfferId = Guid.Parse("d394e91d-6950-4485-b2d2-0c1e8f2ad588"), SkillId = 68 }, // Manejo de bases de datos
                new OfferSkill { OfferSkillId = 461, OfferId = Guid.Parse("d394e91d-6950-4485-b2d2-0c1e8f2ad588"), SkillId = 1 },  // C#
                new OfferSkill { OfferSkillId = 462, OfferId = Guid.Parse("d394e91d-6950-4485-b2d2-0c1e8f2ad588"), SkillId = 38 }, // Cultura organizacional
                new OfferSkill { OfferSkillId = 463, OfferId = Guid.Parse("d394e91d-6950-4485-b2d2-0c1e8f2ad588"), SkillId = 77 },  // Adobe Illustrator

                new OfferSkill { OfferSkillId = 464, OfferId = Guid.Parse("33f8289d-b24f-45d6-b537-0a61b3cb4bbd"), SkillId = 45 }, // Análisis de mercado
                new OfferSkill { OfferSkillId = 465, OfferId = Guid.Parse("33f8289d-b24f-45d6-b537-0a61b3cb4bbd"), SkillId = 69 }, // Elaboración de informes
                new OfferSkill { OfferSkillId = 466, OfferId = Guid.Parse("33f8289d-b24f-45d6-b537-0a61b3cb4bbd"), SkillId = 37 }, // Evaluación del desempeño
                new OfferSkill { OfferSkillId = 467, OfferId = Guid.Parse("33f8289d-b24f-45d6-b537-0a61b3cb4bbd"), SkillId = 88 }, // JIRA
                new OfferSkill { OfferSkillId = 468, OfferId = Guid.Parse("33f8289d-b24f-45d6-b537-0a61b3cb4bbd"), SkillId = 20 }, // Compensación y beneficios
                new OfferSkill { OfferSkillId = 469, OfferId = Guid.Parse("33f8289d-b24f-45d6-b537-0a61b3cb4bbd"), SkillId = 19 }, // Capacitación y desarrollo
                new OfferSkill { OfferSkillId = 470, OfferId = Guid.Parse("33f8289d-b24f-45d6-b537-0a61b3cb4bbd"), SkillId = 46 }, // Estrategia de precios
                new OfferSkill { OfferSkillId = 471, OfferId = Guid.Parse("33f8289d-b24f-45d6-b537-0a61b3cb4bbd"), SkillId = 70 }, // Organización de eventos
                new OfferSkill { OfferSkillId = 472, OfferId = Guid.Parse("33f8289d-b24f-45d6-b537-0a61b3cb4bbd"), SkillId = 74 },  // Google Slides

                new OfferSkill { OfferSkillId = 473, OfferId = Guid.Parse("ff46f91a-6509-462b-8ff3-92c89c17c738"), SkillId = 29 }, // Investigación de Mercado
                new OfferSkill { OfferSkillId = 474, OfferId = Guid.Parse("ff46f91a-6509-462b-8ff3-92c89c17c738"), SkillId = 27 }, // Analytics de Marketing
                new OfferSkill { OfferSkillId = 475, OfferId = Guid.Parse("ff46f91a-6509-462b-8ff3-92c89c17c738"), SkillId = 123 }, // Axure RP
                new OfferSkill { OfferSkillId = 476, OfferId = Guid.Parse("ff46f91a-6509-462b-8ff3-92c89c17c738"), SkillId = 87 }, // Tableau
                new OfferSkill { OfferSkillId = 477, OfferId = Guid.Parse("ff46f91a-6509-462b-8ff3-92c89c17c738"), SkillId = 89 }, // Confluence
                new OfferSkill { OfferSkillId = 478, OfferId = Guid.Parse("ff46f91a-6509-462b-8ff3-92c89c17c738"), SkillId = 96 }, // Microsoft Teams
                new OfferSkill { OfferSkillId = 479, OfferId = Guid.Parse("ff46f91a-6509-462b-8ff3-92c89c17c738"), SkillId = 95 }, // Slack
                new OfferSkill { OfferSkillId = 480, OfferId = Guid.Parse("ff46f91a-6509-462b-8ff3-92c89c17c738"), SkillId = 76 }, // QuickBooks
                new OfferSkill { OfferSkillId = 481, OfferId = Guid.Parse("ff46f91a-6509-462b-8ff3-92c89c17c738"), SkillId = 23 }, // Marketing de Contenidos
                new OfferSkill { OfferSkillId = 482, OfferId = Guid.Parse("ff46f91a-6509-462b-8ff3-92c89c17c738"), SkillId = 80 },  // AutoCAD

                new OfferSkill { OfferSkillId = 483, OfferId = Guid.Parse("6ee3d748-65bc-4fe4-8314-2033f1c002d1"), SkillId = 43 }, // Gestión de inventario
                new OfferSkill { OfferSkillId = 484, OfferId = Guid.Parse("6ee3d748-65bc-4fe4-8314-2033f1c002d1"), SkillId = 36 }, // Administración de nómina
                new OfferSkill { OfferSkillId = 485, OfferId = Guid.Parse("6ee3d748-65bc-4fe4-8314-2033f1c002d1"), SkillId = 87 }, // Tableau
                new OfferSkill { OfferSkillId = 486, OfferId = Guid.Parse("6ee3d748-65bc-4fe4-8314-2033f1c002d1"), SkillId = 93 }, // Trello
                new OfferSkill { OfferSkillId = 487, OfferId = Guid.Parse("6ee3d748-65bc-4fe4-8314-2033f1c002d1"), SkillId = 89 }, // Confluence
                new OfferSkill { OfferSkillId = 488, OfferId = Guid.Parse("6ee3d748-65bc-4fe4-8314-2033f1c002d1"), SkillId = 91 }, // GitHub
                new OfferSkill { OfferSkillId = 489, OfferId = Guid.Parse("6ee3d748-65bc-4fe4-8314-2033f1c002d1"), SkillId = 96 }, // Microsoft Teams
                new OfferSkill { OfferSkillId = 490, OfferId = Guid.Parse("6ee3d748-65bc-4fe4-8314-2033f1c002d1"), SkillId = 95 }, // Slack
                new OfferSkill { OfferSkillId = 491, OfferId = Guid.Parse("6ee3d748-65bc-4fe4-8314-2033f1c002d1"), SkillId = 29 }, // Investigación de Mercado
                new OfferSkill { OfferSkillId = 492, OfferId = Guid.Parse("6ee3d748-65bc-4fe4-8314-2033f1c002d1"), SkillId = 27 },  // Analytics de Marketing

                new OfferSkill { OfferSkillId = 493, OfferId = Guid.Parse("c1a438b6-8c42-4bc4-b11a-7999cb0f4f6e"), SkillId = 135 }, // Autodesk Fusion 360
                new OfferSkill { OfferSkillId = 494, OfferId = Guid.Parse("c1a438b6-8c42-4bc4-b11a-7999cb0f4f6e"), SkillId = 45 }, // Análisis de mercado
                new OfferSkill { OfferSkillId = 495, OfferId = Guid.Parse("c1a438b6-8c42-4bc4-b11a-7999cb0f4f6e"), SkillId = 29 }, // Investigación de Mercado
                new OfferSkill { OfferSkillId = 496, OfferId = Guid.Parse("c1a438b6-8c42-4bc4-b11a-7999cb0f4f6e"), SkillId = 87 }, // Tableau
                new OfferSkill { OfferSkillId = 497, OfferId = Guid.Parse("c1a438b6-8c42-4bc4-b11a-7999cb0f4f6e"), SkillId = 80 }, // AutoCAD
                new OfferSkill { OfferSkillId = 498, OfferId = Guid.Parse("c1a438b6-8c42-4bc4-b11a-7999cb0f4f6e"), SkillId = 26 }, // Publicidad Digital
                new OfferSkill { OfferSkillId = 499, OfferId = Guid.Parse("c1a438b6-8c42-4bc4-b11a-7999cb0f4f6e"), SkillId = 36 }, // Administración de nómina
                new OfferSkill { OfferSkillId = 500, OfferId = Guid.Parse("c1a438b6-8c42-4bc4-b11a-7999cb0f4f6e"), SkillId = 85 }, // SAP
                new OfferSkill { OfferSkillId = 501, OfferId = Guid.Parse("c1a438b6-8c42-4bc4-b11a-7999cb0f4f6e"), SkillId = 38 }, // Cultura organizacional
                new OfferSkill { OfferSkillId = 502, OfferId = Guid.Parse("c1a438b6-8c42-4bc4-b11a-7999cb0f4f6e"), SkillId = 10 },  // Ventas consultivas

                new OfferSkill { OfferSkillId = 503, OfferId = Guid.Parse("79f0f169-f7e1-48b6-aeb8-7584f47ac0aa"), SkillId = 47 }, // Gestión de proveedores
                new OfferSkill { OfferSkillId = 504, OfferId = Guid.Parse("79f0f169-f7e1-48b6-aeb8-7584f47ac0aa"), SkillId = 48 }, // Gestión de la cadena de suministro
                new OfferSkill { OfferSkillId = 505, OfferId = Guid.Parse("79f0f169-f7e1-48b6-aeb8-7584f47ac0aa"), SkillId = 135 }, // Autodesk Fusion 360
                new OfferSkill { OfferSkillId = 506, OfferId = Guid.Parse("79f0f169-f7e1-48b6-aeb8-7584f47ac0aa"), SkillId = 84 }, // SPSS
                new OfferSkill { OfferSkillId = 507, OfferId = Guid.Parse("79f0f169-f7e1-48b6-aeb8-7584f47ac0aa"), SkillId = 70 }, // Organización de eventos
                new OfferSkill { OfferSkillId = 508, OfferId = Guid.Parse("79f0f169-f7e1-48b6-aeb8-7584f47ac0aa"), SkillId = 85 }, // SAP
                new OfferSkill { OfferSkillId = 509, OfferId = Guid.Parse("79f0f169-f7e1-48b6-aeb8-7584f47ac0aa"), SkillId = 87 }, // Tableau
                new OfferSkill { OfferSkillId = 510, OfferId = Guid.Parse("79f0f169-f7e1-48b6-aeb8-7584f47ac0aa"), SkillId = 1 },  // C#
                new OfferSkill { OfferSkillId = 511, OfferId = Guid.Parse("79f0f169-f7e1-48b6-aeb8-7584f47ac0aa"), SkillId = 38 }, // Cultura organizacional
                new OfferSkill { OfferSkillId = 512, OfferId = Guid.Parse("79f0f169-f7e1-48b6-aeb8-7584f47ac0aa"), SkillId = 18 },  // Selección de personal

                new OfferSkill { OfferSkillId = 513, OfferId = Guid.Parse("6cbe28f0-4b85-457f-8a7e-24e2816a607b"), SkillId = 29 }, // Investigación de Mercado
                new OfferSkill { OfferSkillId = 514, OfferId = Guid.Parse("6cbe28f0-4b85-457f-8a7e-24e2816a607b"), SkillId = 23 }, // Marketing de Contenidos
                new OfferSkill { OfferSkillId = 515, OfferId = Guid.Parse("6cbe28f0-4b85-457f-8a7e-24e2816a607b"), SkillId = 25 }, // Marketing en Redes Sociales
                new OfferSkill { OfferSkillId = 516, OfferId = Guid.Parse("6cbe28f0-4b85-457f-8a7e-24e2816a607b"), SkillId = 76 }, // QuickBooks
                new OfferSkill { OfferSkillId = 517, OfferId = Guid.Parse("6cbe28f0-4b85-457f-8a7e-24e2816a607b"), SkillId = 94 }, // Asana
                new OfferSkill { OfferSkillId = 518, OfferId = Guid.Parse("6cbe28f0-4b85-457f-8a7e-24e2816a607b"), SkillId = 90 }, // Zendesk
                new OfferSkill { OfferSkillId = 519, OfferId = Guid.Parse("6cbe28f0-4b85-457f-8a7e-24e2816a607b"), SkillId = 67 }, // Control de gastos
                new OfferSkill { OfferSkillId = 520, OfferId = Guid.Parse("6cbe28f0-4b85-457f-8a7e-24e2816a607b"), SkillId = 38 }, // Cultura organizacional
                new OfferSkill { OfferSkillId = 521, OfferId = Guid.Parse("6cbe28f0-4b85-457f-8a7e-24e2816a607b"), SkillId = 36 }, // Administración de nómina
                new OfferSkill { OfferSkillId = 522, OfferId = Guid.Parse("6cbe28f0-4b85-457f-8a7e-24e2816a607b"), SkillId = 27 },  // Analytics de Marketing

                new OfferSkill { OfferSkillId = 523, OfferId = Guid.Parse("b18a1bb5-6b8a-4d90-985f-02c4792f18da"), SkillId = 31 }, // Gestión del talento
                new OfferSkill { OfferSkillId = 524, OfferId = Guid.Parse("b18a1bb5-6b8a-4d90-985f-02c4792f18da"), SkillId = 118 }, // Sketch
                new OfferSkill { OfferSkillId = 525, OfferId = Guid.Parse("b18a1bb5-6b8a-4d90-985f-02c4792f18da"), SkillId = 117 }, // Figma
                new OfferSkill { OfferSkillId = 526, OfferId = Guid.Parse("b18a1bb5-6b8a-4d90-985f-02c4792f18da"), SkillId = 87 }, // Tableau
                new OfferSkill { OfferSkillId = 527, OfferId = Guid.Parse("b18a1bb5-6b8a-4d90-985f-02c4792f18da"), SkillId = 88 }, // JIRA
                new OfferSkill { OfferSkillId = 528, OfferId = Guid.Parse("b18a1bb5-6b8a-4d90-985f-02c4792f18da"), SkillId = 89 }, // Confluence
                new OfferSkill { OfferSkillId = 529, OfferId = Guid.Parse("b18a1bb5-6b8a-4d90-985f-02c4792f18da"), SkillId = 93 }, // Trello
                new OfferSkill { OfferSkillId = 530, OfferId = Guid.Parse("b18a1bb5-6b8a-4d90-985f-02c4792f18da"), SkillId = 69 }, // Elaboración de informes
                new OfferSkill { OfferSkillId = 531, OfferId = Guid.Parse("b18a1bb5-6b8a-4d90-985f-02c4792f18da"), SkillId = 15 }, // Presentaciones de ventas
                new OfferSkill { OfferSkillId = 532, OfferId = Guid.Parse("b18a1bb5-6b8a-4d90-985f-02c4792f18da"), SkillId = 23 },  // Marketing de Contenidos

                new OfferSkill { OfferSkillId = 533, OfferId = Guid.Parse("05f44853-1a61-4e47-92c1-1051e7592de9"), SkillId = 42 }, // Logística de abastecimiento
                new OfferSkill { OfferSkillId = 534, OfferId = Guid.Parse("05f44853-1a61-4e47-92c1-1051e7592de9"), SkillId = 43 }, // Gestión de inventario
                new OfferSkill { OfferSkillId = 535, OfferId = Guid.Parse("05f44853-1a61-4e47-92c1-1051e7592de9"), SkillId = 49 }, // Exportaciones e importaciones
                new OfferSkill { OfferSkillId = 536, OfferId = Guid.Parse("05f44853-1a61-4e47-92c1-1051e7592de9"), SkillId = 50 }, // Comercio electrónico
                new OfferSkill { OfferSkillId = 537, OfferId = Guid.Parse("05f44853-1a61-4e47-92c1-1051e7592de9"), SkillId = 90 }, // Zendesk
                new OfferSkill { OfferSkillId = 538, OfferId = Guid.Parse("05f44853-1a61-4e47-92c1-1051e7592de9"), SkillId = 95 }, // Slack
                new OfferSkill { OfferSkillId = 539, OfferId = Guid.Parse("05f44853-1a61-4e47-92c1-1051e7592de9"), SkillId = 96 }, // Microsoft Teams
                new OfferSkill { OfferSkillId = 540, OfferId = Guid.Parse("05f44853-1a61-4e47-92c1-1051e7592de9"), SkillId = 97 }, // Zoom
                new OfferSkill { OfferSkillId = 541, OfferId = Guid.Parse("05f44853-1a61-4e47-92c1-1051e7592de9"), SkillId = 98 }, // WebEx
                new OfferSkill { OfferSkillId = 542, OfferId = Guid.Parse("05f44853-1a61-4e47-92c1-1051e7592de9"), SkillId = 99 },  // Skype

                new OfferSkill { OfferSkillId = 543, OfferId = Guid.Parse("88c99390-4e1b-4201-a10b-8a4b6a5b01ef"), SkillId = 29 }, // Investigación de Mercado
                new OfferSkill { OfferSkillId = 544, OfferId = Guid.Parse("88c99390-4e1b-4201-a10b-8a4b6a5b01ef"), SkillId = 42 }, // Logística de abastecimiento
                new OfferSkill { OfferSkillId = 545, OfferId = Guid.Parse("88c99390-4e1b-4201-a10b-8a4b6a5b01ef"), SkillId = 23 }, // Marketing de Contenidos
                new OfferSkill { OfferSkillId = 546, OfferId = Guid.Parse("88c99390-4e1b-4201-a10b-8a4b6a5b01ef"), SkillId = 27 }, // Analytics de Marketing
                new OfferSkill { OfferSkillId = 547, OfferId = Guid.Parse("88c99390-4e1b-4201-a10b-8a4b6a5b01ef"), SkillId = 91 }, // GitHub
                new OfferSkill { OfferSkillId = 548, OfferId = Guid.Parse("88c99390-4e1b-4201-a10b-8a4b6a5b01ef"), SkillId = 89 }, // Confluence
                new OfferSkill { OfferSkillId = 549, OfferId = Guid.Parse("88c99390-4e1b-4201-a10b-8a4b6a5b01ef"), SkillId = 99 }, // Skype
                new OfferSkill { OfferSkillId = 550, OfferId = Guid.Parse("88c99390-4e1b-4201-a10b-8a4b6a5b01ef"), SkillId = 95 }, // Slack
                new OfferSkill { OfferSkillId = 551, OfferId = Guid.Parse("88c99390-4e1b-4201-a10b-8a4b6a5b01ef"), SkillId = 96 }, // Microsoft Teams
                new OfferSkill { OfferSkillId = 552, OfferId = Guid.Parse("88c99390-4e1b-4201-a10b-8a4b6a5b01ef"), SkillId = 97 },  // Zoom

                new OfferSkill { OfferSkillId = 553, OfferId = Guid.Parse("02425ff4-5748-4da2-a32e-1b8d897e5f9e"), SkillId = 42 }, // Logística de abastecimiento
                new OfferSkill { OfferSkillId = 554, OfferId = Guid.Parse("02425ff4-5748-4da2-a32e-1b8d897e5f9e"), SkillId = 43 }, // Gestión de inventario
                new OfferSkill { OfferSkillId = 555, OfferId = Guid.Parse("02425ff4-5748-4da2-a32e-1b8d897e5f9e"), SkillId = 48 }, // Gestión de la cadena de suministro
                new OfferSkill { OfferSkillId = 556, OfferId = Guid.Parse("02425ff4-5748-4da2-a32e-1b8d897e5f9e"), SkillId = 50 }, // Comercio electrónico
                new OfferSkill { OfferSkillId = 557, OfferId = Guid.Parse("02425ff4-5748-4da2-a32e-1b8d897e5f9e"), SkillId = 68 }, // Manejo de bases de datos
                new OfferSkill { OfferSkillId = 558, OfferId = Guid.Parse("02425ff4-5748-4da2-a32e-1b8d897e5f9e"), SkillId = 77 }, // Adobe Illustrator
                new OfferSkill { OfferSkillId = 559, OfferId = Guid.Parse("02425ff4-5748-4da2-a32e-1b8d897e5f9e"), SkillId = 91 }, // GitHub
                new OfferSkill { OfferSkillId = 560, OfferId = Guid.Parse("02425ff4-5748-4da2-a32e-1b8d897e5f9e"), SkillId = 92 }, // GitLab
                new OfferSkill { OfferSkillId = 561, OfferId = Guid.Parse("02425ff4-5748-4da2-a32e-1b8d897e5f9e"), SkillId = 93 }, // Trello
                new OfferSkill { OfferSkillId = 562, OfferId = Guid.Parse("02425ff4-5748-4da2-a32e-1b8d897e5f9e"), SkillId = 95 },  // Slack

                new OfferSkill { OfferSkillId = 563, OfferId = Guid.Parse("340c99b3-c922-49cf-9d34-609b768e7f65"), SkillId = 39 }, // Capacitación y desarrollo
                new OfferSkill { OfferSkillId = 564, OfferId = Guid.Parse("340c99b3-c922-49cf-9d34-609b768e7f65"), SkillId = 40 }, // Gestión del rendimiento
                new OfferSkill { OfferSkillId = 565, OfferId = Guid.Parse("340c99b3-c922-49cf-9d34-609b768e7f65"), SkillId = 46 }, // Estrategia de precios
                new OfferSkill { OfferSkillId = 566, OfferId = Guid.Parse("340c99b3-c922-49cf-9d34-609b768e7f65"), SkillId = 65 }, // Gestión de correos electrónicos
                new OfferSkill { OfferSkillId = 567, OfferId = Guid.Parse("340c99b3-c922-49cf-9d34-609b768e7f65"), SkillId = 69 }, // Elaboración de informes
                new OfferSkill { OfferSkillId = 568, OfferId = Guid.Parse("340c99b3-c922-49cf-9d34-609b768e7f65"), SkillId = 76 }, // QuickBooks
                new OfferSkill { OfferSkillId = 569, OfferId = Guid.Parse("340c99b3-c922-49cf-9d34-609b768e7f65"), SkillId = 77 }, // Adobe Illustrator
                new OfferSkill { OfferSkillId = 570, OfferId = Guid.Parse("340c99b3-c922-49cf-9d34-609b768e7f65"), SkillId = 90 }, // Zendesk
                new OfferSkill { OfferSkillId = 571, OfferId = Guid.Parse("340c99b3-c922-49cf-9d34-609b768e7f65"), SkillId = 91 }, // GitHub
                new OfferSkill { OfferSkillId = 572, OfferId = Guid.Parse("340c99b3-c922-49cf-9d34-609b768e7f65"), SkillId = 92 }, // GitLab

                new OfferSkill { OfferSkillId = 573, OfferId = Guid.Parse("9e920f05-4e16-4536-b246-50c242d1a152"), SkillId = 47 }, // Gestión de proveedores
                new OfferSkill { OfferSkillId = 574, OfferId = Guid.Parse("9e920f05-4e16-4536-b246-50c242d1a152"), SkillId = 6 },  // CSS
                new OfferSkill { OfferSkillId = 575, OfferId = Guid.Parse("9e920f05-4e16-4536-b246-50c242d1a152"), SkillId = 95 }, // Slack
                new OfferSkill { OfferSkillId = 576, OfferId = Guid.Parse("9e920f05-4e16-4536-b246-50c242d1a152"), SkillId = 86 }, // Salesforce
                new OfferSkill { OfferSkillId = 577, OfferId = Guid.Parse("9e920f05-4e16-4536-b246-50c242d1a152"), SkillId = 85 }, // SAP
                new OfferSkill { OfferSkillId = 578, OfferId = Guid.Parse("9e920f05-4e16-4536-b246-50c242d1a152"), SkillId = 55 }, // Asesoría en seguros
                new OfferSkill { OfferSkillId = 579, OfferId = Guid.Parse("9e920f05-4e16-4536-b246-50c242d1a152"), SkillId = 77 }, // Adobe Illustrator
                new OfferSkill { OfferSkillId = 580, OfferId = Guid.Parse("9e920f05-4e16-4536-b246-50c242d1a152"), SkillId = 97 }, // Zoom
                new OfferSkill { OfferSkillId = 581, OfferId = Guid.Parse("9e920f05-4e16-4536-b246-50c242d1a152"), SkillId = 60 }, // Asesoría en marketing
                new OfferSkill { OfferSkillId = 582, OfferId = Guid.Parse("9e920f05-4e16-4536-b246-50c242d1a152"), SkillId = 71 }, // PowerPoint

                new OfferSkill { OfferSkillId = 583, OfferId = Guid.Parse("cf5ed95f-77e8-4a0e-85f8-78f7df4c2c78"), SkillId = 47 }, // Gestión de proveedores
                new OfferSkill { OfferSkillId = 584, OfferId = Guid.Parse("cf5ed95f-77e8-4a0e-85f8-78f7df4c2c78"), SkillId = 91 }, // GitHub
                new OfferSkill { OfferSkillId = 585, OfferId = Guid.Parse("cf5ed95f-77e8-4a0e-85f8-78f7df4c2c78"), SkillId = 108 }, // Maya
                new OfferSkill { OfferSkillId = 586, OfferId = Guid.Parse("cf5ed95f-77e8-4a0e-85f8-78f7df4c2c78"), SkillId = 109 }, // Unity
                new OfferSkill { OfferSkillId = 587, OfferId = Guid.Parse("cf5ed95f-77e8-4a0e-85f8-78f7df4c2c78"), SkillId = 24 }, // Email Marketing
                new OfferSkill { OfferSkillId = 588, OfferId = Guid.Parse("cf5ed95f-77e8-4a0e-85f8-78f7df4c2c78"), SkillId = 77 }, // Adobe Illustrator
                new OfferSkill { OfferSkillId = 589, OfferId = Guid.Parse("cf5ed95f-77e8-4a0e-85f8-78f7df4c2c78"), SkillId = 85 }, // SAP
                new OfferSkill { OfferSkillId = 590, OfferId = Guid.Parse("cf5ed95f-77e8-4a0e-85f8-78f7df4c2c78"), SkillId = 60 }, // Asesoría en marketing
                new OfferSkill { OfferSkillId = 591, OfferId = Guid.Parse("cf5ed95f-77e8-4a0e-85f8-78f7df4c2c78"), SkillId = 71 }, // PowerPoint
                new OfferSkill { OfferSkillId = 592, OfferId = Guid.Parse("cf5ed95f-77e8-4a0e-85f8-78f7df4c2c78"), SkillId = 86 },  // Salesforce

                new OfferSkill { OfferSkillId = 593, OfferId = Guid.Parse("85b1a6f1-1e05-4eae-a60d-51a334f54ad5"), SkillId = 68 }, // Manejo de bases de datos
                new OfferSkill { OfferSkillId = 594, OfferId = Guid.Parse("85b1a6f1-1e05-4eae-a60d-51a334f54ad5"), SkillId = 108 }, // Maya
                new OfferSkill { OfferSkillId = 595, OfferId = Guid.Parse("85b1a6f1-1e05-4eae-a60d-51a334f54ad5"), SkillId = 109 }, // Unity
                new OfferSkill { OfferSkillId = 596, OfferId = Guid.Parse("85b1a6f1-1e05-4eae-a60d-51a334f54ad5"), SkillId = 88 }, // JIRA
                new OfferSkill { OfferSkillId = 597, OfferId = Guid.Parse("85b1a6f1-1e05-4eae-a60d-51a334f54ad5"), SkillId = 91 }, // GitHub
                new OfferSkill { OfferSkillId = 598, OfferId = Guid.Parse("85b1a6f1-1e05-4eae-a60d-51a334f54ad5"), SkillId = 97 }, // Zoom
                new OfferSkill { OfferSkillId = 599, OfferId = Guid.Parse("85b1a6f1-1e05-4eae-a60d-51a334f54ad5"), SkillId = 105 }, // After Effects
                new OfferSkill { OfferSkillId = 600, OfferId = Guid.Parse("85b1a6f1-1e05-4eae-a60d-51a334f54ad5"), SkillId = 70 }, // Organización de eventos
                new OfferSkill { OfferSkillId = 601, OfferId = Guid.Parse("85b1a6f1-1e05-4eae-a60d-51a334f54ad5"), SkillId = 71 }, // PowerPoint
                new OfferSkill { OfferSkillId = 602, OfferId = Guid.Parse("85b1a6f1-1e05-4eae-a60d-51a334f54ad5"), SkillId = 86 },  // Salesforce

                new OfferSkill { OfferSkillId = 603, OfferId = Guid.Parse("23d4c9e5-88b4-44f0-9b64-8308e70e51eb"), SkillId = 23 }, // Marketing de Contenidos
                new OfferSkill { OfferSkillId = 604, OfferId = Guid.Parse("23d4c9e5-88b4-44f0-9b64-8308e70e51eb"), SkillId = 117 }, // Figma
                new OfferSkill { OfferSkillId = 605, OfferId = Guid.Parse("23d4c9e5-88b4-44f0-9b64-8308e70e51eb"), SkillId = 103 }, // InDesign
                new OfferSkill { OfferSkillId = 606, OfferId = Guid.Parse("23d4c9e5-88b4-44f0-9b64-8308e70e51eb"), SkillId = 76 }, // QuickBooks
                new OfferSkill { OfferSkillId = 607, OfferId = Guid.Parse("23d4c9e5-88b4-44f0-9b64-8308e70e51eb"), SkillId = 83 }, // SolidWorks
                new OfferSkill { OfferSkillId = 608, OfferId = Guid.Parse("23d4c9e5-88b4-44f0-9b64-8308e70e51eb"), SkillId = 28 }, // Estrategia de Marketing
                new OfferSkill { OfferSkillId = 609, OfferId = Guid.Parse("23d4c9e5-88b4-44f0-9b64-8308e70e51eb"), SkillId = 71 }, // PowerPoint
                new OfferSkill { OfferSkillId = 610, OfferId = Guid.Parse("23d4c9e5-88b4-44f0-9b64-8308e70e51eb"), SkillId = 94 }, // Asana
                new OfferSkill { OfferSkillId = 611, OfferId = Guid.Parse("23d4c9e5-88b4-44f0-9b64-8308e70e51eb"), SkillId = 95 }, // Slack
                new OfferSkill { OfferSkillId = 612, OfferId = Guid.Parse("23d4c9e5-88b4-44f0-9b64-8308e70e51eb"), SkillId = 63 },  // Archivo y registro

                new OfferSkill { OfferSkillId = 613, OfferId = Guid.Parse("b11dd7cf-8245-43a3-9b23-8c8893f83c13"), SkillId = 48 }, // Gestión de la cadena de suministro
                new OfferSkill { OfferSkillId = 614, OfferId = Guid.Parse("b11dd7cf-8245-43a3-9b23-8c8893f83c13"), SkillId = 83 }, // SolidWorks
                new OfferSkill { OfferSkillId = 615, OfferId = Guid.Parse("b11dd7cf-8245-43a3-9b23-8c8893f83c13"), SkillId = 88 }, // JIRA
                new OfferSkill { OfferSkillId = 616, OfferId = Guid.Parse("b11dd7cf-8245-43a3-9b23-8c8893f83c13"), SkillId = 109 }, // Unity
                new OfferSkill { OfferSkillId = 617, OfferId = Guid.Parse("b11dd7cf-8245-43a3-9b23-8c8893f83c13"), SkillId = 110 }, // Unreal Engine
                new OfferSkill { OfferSkillId = 618, OfferId = Guid.Parse("b11dd7cf-8245-43a3-9b23-8c8893f83c13"), SkillId = 86 }, // Salesforce
                new OfferSkill { OfferSkillId = 619, OfferId = Guid.Parse("b11dd7cf-8245-43a3-9b23-8c8893f83c13"), SkillId = 38 }, // Cultura organizacional
                new OfferSkill { OfferSkillId = 620, OfferId = Guid.Parse("b11dd7cf-8245-43a3-9b23-8c8893f83c13"), SkillId = 37 }, // Evaluación del desempeño
                new OfferSkill { OfferSkillId = 621, OfferId = Guid.Parse("b11dd7cf-8245-43a3-9b23-8c8893f83c13"), SkillId = 50 }, // Comercio electrónico
                new OfferSkill { OfferSkillId = 622, OfferId = Guid.Parse("b11dd7cf-8245-43a3-9b23-8c8893f83c13"), SkillId = 28 },  // Estrategia de Marketing

                new OfferSkill { OfferSkillId = 623, OfferId = Guid.Parse("e261493e-d760-4a48-bb24-9b5c9d7f4b1a"), SkillId = 19 }, // Capacitación y desarrollo
                new OfferSkill { OfferSkillId = 624, OfferId = Guid.Parse("e261493e-d760-4a48-bb24-9b5c9d7f4b1a"), SkillId = 37 }, // Evaluación del desempeño
                new OfferSkill { OfferSkillId = 625, OfferId = Guid.Parse("e261493e-d760-4a48-bb24-9b5c9d7f4b1a"), SkillId = 39 }, // Gestión del cambio
                new OfferSkill { OfferSkillId = 626, OfferId = Guid.Parse("e261493e-d760-4a48-bb24-9b5c9d7f4b1a"), SkillId = 41 }, // Compras y aprovisionamiento
                new OfferSkill { OfferSkillId = 627, OfferId = Guid.Parse("e261493e-d760-4a48-bb24-9b5c9d7f4b1a"), SkillId = 69 }, // Elaboración de informes
                new OfferSkill { OfferSkillId = 628, OfferId = Guid.Parse("e261493e-d760-4a48-bb24-9b5c9d7f4b1a"), SkillId = 68 }, // Manejo de bases de datos
                new OfferSkill { OfferSkillId = 629, OfferId = Guid.Parse("e261493e-d760-4a48-bb24-9b5c9d7f4b1a"), SkillId = 67 }, // Control de gastos
                new OfferSkill { OfferSkillId = 630, OfferId = Guid.Parse("e261493e-d760-4a48-bb24-9b5c9d7f4b1a"), SkillId = 51 }, // Asesoría financiera
                new OfferSkill { OfferSkillId = 631, OfferId = Guid.Parse("e261493e-d760-4a48-bb24-9b5c9d7f4b1a"), SkillId = 55 }, // Asesoría en seguros
                new OfferSkill { OfferSkillId = 632, OfferId = Guid.Parse("e261493e-d760-4a48-bb24-9b5c9d7f4b1a"), SkillId = 78 },  // Adobe InDesign

                new OfferSkill { OfferSkillId = 633, OfferId = Guid.Parse("fe4370bc-c706-4b09-9448-01bc6ff9b01f"), SkillId = 31 }, // Gestión del talento
                new OfferSkill { OfferSkillId = 634, OfferId = Guid.Parse("fe4370bc-c706-4b09-9448-01bc6ff9b01f"), SkillId = 38 }, // Cultura organizacional
                new OfferSkill { OfferSkillId = 635, OfferId = Guid.Parse("fe4370bc-c706-4b09-9448-01bc6ff9b01f"), SkillId = 66 }, // Facturación y cobranza
                new OfferSkill { OfferSkillId = 636, OfferId = Guid.Parse("fe4370bc-c706-4b09-9448-01bc6ff9b01f"), SkillId = 77 }, // Adobe Illustrator
                new OfferSkill { OfferSkillId = 637, OfferId = Guid.Parse("fe4370bc-c706-4b09-9448-01bc6ff9b01f"), SkillId = 85 }, // SAP
                new OfferSkill { OfferSkillId = 638, OfferId = Guid.Parse("fe4370bc-c706-4b09-9448-01bc6ff9b01f"), SkillId = 88 }, // JIRA
                new OfferSkill { OfferSkillId = 639, OfferId = Guid.Parse("fe4370bc-c706-4b09-9448-01bc6ff9b01f"), SkillId = 90 }, // Zendesk
                new OfferSkill { OfferSkillId = 640, OfferId = Guid.Parse("fe4370bc-c706-4b09-9448-01bc6ff9b01f"), SkillId = 91 }, // GitHub
                new OfferSkill { OfferSkillId = 641, OfferId = Guid.Parse("fe4370bc-c706-4b09-9448-01bc6ff9b01f"), SkillId = 97 }, // Zoom
                new OfferSkill { OfferSkillId = 642, OfferId = Guid.Parse("fe4370bc-c706-4b09-9448-01bc6ff9b01f"), SkillId = 99 },  // Skype

                new OfferSkill { OfferSkillId = 643, OfferId = Guid.Parse("3e7b2e42-9315-4395-b5dc-7c973d13a12e"), SkillId = 1 },   // C#
                new OfferSkill { OfferSkillId = 644, OfferId = Guid.Parse("3e7b2e42-9315-4395-b5dc-7c973d13a12e"), SkillId = 45 },  // Análisis de mercado
                new OfferSkill { OfferSkillId = 645, OfferId = Guid.Parse("3e7b2e42-9315-4395-b5dc-7c973d13a12e"), SkillId = 73 },  // Google Docs
                new OfferSkill { OfferSkillId = 646, OfferId = Guid.Parse("3e7b2e42-9315-4395-b5dc-7c973d13a12e"), SkillId = 76 },  // QuickBooks
                new OfferSkill { OfferSkillId = 647, OfferId = Guid.Parse("3e7b2e42-9315-4395-b5dc-7c973d13a12e"), SkillId = 91 },  // GitHub
                new OfferSkill { OfferSkillId = 648, OfferId = Guid.Parse("3e7b2e42-9315-4395-b5dc-7c973d13a12e"), SkillId = 92 },  // GitLab
                new OfferSkill { OfferSkillId = 649, OfferId = Guid.Parse("3e7b2e42-9315-4395-b5dc-7c973d13a12e"), SkillId = 97 },  // Zoom
                new OfferSkill { OfferSkillId = 650, OfferId = Guid.Parse("3e7b2e42-9315-4395-b5dc-7c973d13a12e"), SkillId = 98 },  // WebEx
                new OfferSkill { OfferSkillId = 651, OfferId = Guid.Parse("3e7b2e42-9315-4395-b5dc-7c973d13a12e"), SkillId = 99 },  // Skype
                new OfferSkill { OfferSkillId = 652, OfferId = Guid.Parse("3e7b2e42-9315-4395-b5dc-7c973d13a12e"), SkillId = 100 },  // Google Meet

                new OfferSkill { OfferSkillId = 653, OfferId = Guid.Parse("a6606e3d-b9de-4b4f-840b-83f8e2c29e92"), SkillId = 49 },   // Exportaciones e importaciones
                new OfferSkill { OfferSkillId = 654, OfferId = Guid.Parse("a6606e3d-b9de-4b4f-840b-83f8e2c29e92"), SkillId = 83 },   // SolidWorks
                new OfferSkill { OfferSkillId = 655, OfferId = Guid.Parse("a6606e3d-b9de-4b4f-840b-83f8e2c29e92"), SkillId = 90 },   // Zendesk
                new OfferSkill { OfferSkillId = 656, OfferId = Guid.Parse("a6606e3d-b9de-4b4f-840b-83f8e2c29e92"), SkillId = 94 },   // Asana
                new OfferSkill { OfferSkillId = 657, OfferId = Guid.Parse("a6606e3d-b9de-4b4f-840b-83f8e2c29e92"), SkillId = 96 },   // Microsoft Teams
                new OfferSkill { OfferSkillId = 658, OfferId = Guid.Parse("a6606e3d-b9de-4b4f-840b-83f8e2c29e92"), SkillId = 97 },   // Zoom
                new OfferSkill { OfferSkillId = 659, OfferId = Guid.Parse("a6606e3d-b9de-4b4f-840b-83f8e2c29e92"), SkillId = 99 },   // Skype
                new OfferSkill { OfferSkillId = 660, OfferId = Guid.Parse("a6606e3d-b9de-4b4f-840b-83f8e2c29e92"), SkillId = 101 },  // Inkscape
                new OfferSkill { OfferSkillId = 661, OfferId = Guid.Parse("a6606e3d-b9de-4b4f-840b-83f8e2c29e92"), SkillId = 105 },  // After Effects
                new OfferSkill { OfferSkillId = 662, OfferId = Guid.Parse("a6606e3d-b9de-4b4f-840b-83f8e2c29e92"), SkillId = 109 },  // Unity

                new OfferSkill { OfferSkillId = 663, OfferId = Guid.Parse("f6f63f9f-01e0-4e1f-b675-90c1ffdc17cb"), SkillId = 89 }, // Confluence
                new OfferSkill { OfferSkillId = 664, OfferId = Guid.Parse("f6f63f9f-01e0-4e1f-b675-90c1ffdc17cb"), SkillId = 88 }, // JIRA
                new OfferSkill { OfferSkillId = 665, OfferId = Guid.Parse("f6f63f9f-01e0-4e1f-b675-90c1ffdc17cb"), SkillId = 136 }, // Avid Media Composer
                new OfferSkill { OfferSkillId = 666, OfferId = Guid.Parse("f6f63f9f-01e0-4e1f-b675-90c1ffdc17cb"), SkillId = 102 }, // Illustrator
                new OfferSkill { OfferSkillId = 667, OfferId = Guid.Parse("f6f63f9f-01e0-4e1f-b675-90c1ffdc17cb"), SkillId = 104 }, // Premiere Pro
                new OfferSkill { OfferSkillId = 668, OfferId = Guid.Parse("f6f63f9f-01e0-4e1f-b675-90c1ffdc17cb"), SkillId = 77 }, // Adobe Illustrator
                new OfferSkill { OfferSkillId = 669, OfferId = Guid.Parse("f6f63f9f-01e0-4e1f-b675-90c1ffdc17cb"), SkillId = 79 }, // Adobe Premiere Pro
                new OfferSkill { OfferSkillId = 670, OfferId = Guid.Parse("f6f63f9f-01e0-4e1f-b675-90c1ffdc17cb"), SkillId = 116 }, // Adobe XD
                new OfferSkill { OfferSkillId = 671, OfferId = Guid.Parse("f6f63f9f-01e0-4e1f-b675-90c1ffdc17cb"), SkillId = 117 }, // Figma
                new OfferSkill { OfferSkillId = 672, OfferId = Guid.Parse("f6f63f9f-01e0-4e1f-b675-90c1ffdc17cb"), SkillId = 118 }, // Sketch

                new OfferSkill { OfferSkillId = 673, OfferId = Guid.Parse("25d6d135-1cb9-40aa-8962-f89173f8058b"), SkillId = 47 }, // Gestión de proveedores
                new OfferSkill { OfferSkillId = 674, OfferId = Guid.Parse("25d6d135-1cb9-40aa-8962-f89173f8058b"), SkillId = 50 }, // Comercio electrónico
                new OfferSkill { OfferSkillId = 675, OfferId = Guid.Parse("25d6d135-1cb9-40aa-8962-f89173f8058b"), SkillId = 91 }, // GitHub
                new OfferSkill { OfferSkillId = 676, OfferId = Guid.Parse("25d6d135-1cb9-40aa-8962-f89173f8058b"), SkillId = 66 }, // Facturación y cobranza
                new OfferSkill { OfferSkillId = 677, OfferId = Guid.Parse("25d6d135-1cb9-40aa-8962-f89173f8058b"), SkillId = 42 }, // Logística de abastecimiento
                new OfferSkill { OfferSkillId = 678, OfferId = Guid.Parse("25d6d135-1cb9-40aa-8962-f89173f8058b"), SkillId = 43 }, // Gestión de inventario
                new OfferSkill { OfferSkillId = 679, OfferId = Guid.Parse("25d6d135-1cb9-40aa-8962-f89173f8058b"), SkillId = 68 }, // Manejo de bases de datos
                new OfferSkill { OfferSkillId = 680, OfferId = Guid.Parse("25d6d135-1cb9-40aa-8962-f89173f8058b"), SkillId = 65 }, // Gestión de correos electrónicos
                new OfferSkill { OfferSkillId = 681, OfferId = Guid.Parse("25d6d135-1cb9-40aa-8962-f89173f8058b"), SkillId = 66 }, // Facturación y cobranza
                new OfferSkill { OfferSkillId = 682, OfferId = Guid.Parse("25d6d135-1cb9-40aa-8962-f89173f8058b"), SkillId = 69 },  // Elaboración de informes

                new OfferSkill { OfferSkillId = 683, OfferId = Guid.Parse("cb442d70-d201-457d-872e-5931991cd34d"), SkillId = 28 }, // Seguridad de la información
                new OfferSkill { OfferSkillId = 684, OfferId = Guid.Parse("cb442d70-d201-457d-872e-5931991cd34d"), SkillId = 30 }, // Gestión de riesgos
                new OfferSkill { OfferSkillId = 685, OfferId = Guid.Parse("cb442d70-d201-457d-872e-5931991cd34d"), SkillId = 29 }, // Análisis de vulnerabilidades
                new OfferSkill { OfferSkillId = 686, OfferId = Guid.Parse("cb442d70-d201-457d-872e-5931991cd34d"), SkillId = 25 }, // Gestión de seguridad de red
                new OfferSkill { OfferSkillId = 687, OfferId = Guid.Parse("cb442d70-d201-457d-872e-5931991cd34d"), SkillId = 26 }, // Criptografía
                new OfferSkill { OfferSkillId = 688, OfferId = Guid.Parse("cb442d70-d201-457d-872e-5931991cd34d"), SkillId = 27 }, // Seguridad de aplicaciones web
                new OfferSkill { OfferSkillId = 689, OfferId = Guid.Parse("cb442d70-d201-457d-872e-5931991cd34d"), SkillId = 34 }, // Seguridad en la nube
                new OfferSkill { OfferSkillId = 690, OfferId = Guid.Parse("cb442d70-d201-457d-872e-5931991cd34d"), SkillId = 35 }, // Pruebas de penetración
                new OfferSkill { OfferSkillId = 691, OfferId = Guid.Parse("cb442d70-d201-457d-872e-5931991cd34d"), SkillId = 31 }, // Cumplimiento normativo
                new OfferSkill { OfferSkillId = 692, OfferId = Guid.Parse("cb442d70-d201-457d-872e-5931991cd34d"), SkillId = 33 },  // Forense digital

                new OfferSkill { OfferSkillId = 693, OfferId = Guid.Parse("91a0529b-af68-4e6c-a67a-593cf3db1f34"), SkillId = 98 }, // WebEx
                new OfferSkill { OfferSkillId = 694, OfferId = Guid.Parse("91a0529b-af68-4e6c-a67a-593cf3db1f34"), SkillId = 85 }, // SAP
                new OfferSkill { OfferSkillId = 695, OfferId = Guid.Parse("91a0529b-af68-4e6c-a67a-593cf3db1f34"), SkillId = 38 }, // Cultura organizacional
                new OfferSkill { OfferSkillId = 696, OfferId = Guid.Parse("91a0529b-af68-4e6c-a67a-593cf3db1f34"), SkillId = 36 }, // Administración de nómina
                new OfferSkill { OfferSkillId = 697, OfferId = Guid.Parse("91a0529b-af68-4e6c-a67a-593cf3db1f34"), SkillId = 2 },  // C
                new OfferSkill { OfferSkillId = 698, OfferId = Guid.Parse("91a0529b-af68-4e6c-a67a-593cf3db1f34"), SkillId = 1 },  // C#
                new OfferSkill { OfferSkillId = 699, OfferId = Guid.Parse("91a0529b-af68-4e6c-a67a-593cf3db1f34"), SkillId = 3 },  // JavaScript
                new OfferSkill { OfferSkillId = 700, OfferId = Guid.Parse("91a0529b-af68-4e6c-a67a-593cf3db1f34"), SkillId = 4 },  // Node.Js
                new OfferSkill { OfferSkillId = 701, OfferId = Guid.Parse("91a0529b-af68-4e6c-a67a-593cf3db1f34"), SkillId = 9 },  // Word
                new OfferSkill { OfferSkillId = 702, OfferId = Guid.Parse("91a0529b-af68-4e6c-a67a-593cf3db1f34"), SkillId = 91 },  // GitHub

                new OfferSkill { OfferSkillId = 703, OfferId = Guid.Parse("b8f93f12-00de-4a26-bce2-4bf1d64ff1f4"), SkillId = 98 }, // WebEx
                new OfferSkill { OfferSkillId = 704, OfferId = Guid.Parse("b8f93f12-00de-4a26-bce2-4bf1d64ff1f4"), SkillId = 3 },  // JavaScript
                new OfferSkill { OfferSkillId = 705, OfferId = Guid.Parse("b8f93f12-00de-4a26-bce2-4bf1d64ff1f4"), SkillId = 1 },  // C#
                new OfferSkill { OfferSkillId = 706, OfferId = Guid.Parse("b8f93f12-00de-4a26-bce2-4bf1d64ff1f4"), SkillId = 91 }, // GitHub
                new OfferSkill { OfferSkillId = 707, OfferId = Guid.Parse("b8f93f12-00de-4a26-bce2-4bf1d64ff1f4"), SkillId = 99 }, // Skype
                new OfferSkill { OfferSkillId = 708, OfferId = Guid.Parse("b8f93f12-00de-4a26-bce2-4bf1d64ff1f4"), SkillId = 27 }, // Analytics de Marketing
                new OfferSkill { OfferSkillId = 709, OfferId = Guid.Parse("b8f93f12-00de-4a26-bce2-4bf1d64ff1f4"), SkillId = 36 }, // Administración de nómina
                new OfferSkill { OfferSkillId = 710, OfferId = Guid.Parse("b8f93f12-00de-4a26-bce2-4bf1d64ff1f4"), SkillId = 38 }, // Cultura organizacional
                new OfferSkill { OfferSkillId = 711, OfferId = Guid.Parse("b8f93f12-00de-4a26-bce2-4bf1d64ff1f4"), SkillId = 85 }, // SAP
                new OfferSkill { OfferSkillId = 712, OfferId = Guid.Parse("b8f93f12-00de-4a26-bce2-4bf1d64ff1f4"), SkillId = 109 }, // Unity

                new OfferSkill { OfferSkillId = 713, OfferId = Guid.Parse("cf9f4731-26f7-4ee7-94d3-44e7ee7443bc"), SkillId = 21 }, // SEO (Optimización de Motores de Búsqueda)
                new OfferSkill { OfferSkillId = 714, OfferId = Guid.Parse("cf9f4731-26f7-4ee7-94d3-44e7ee7443bc"), SkillId = 22 }, // SEM (Marketing en Motores de Búsqueda)
                new OfferSkill { OfferSkillId = 715, OfferId = Guid.Parse("cf9f4731-26f7-4ee7-94d3-44e7ee7443bc"), SkillId = 23 }, // Marketing de Contenidos
                new OfferSkill { OfferSkillId = 716, OfferId = Guid.Parse("cf9f4731-26f7-4ee7-94d3-44e7ee7443bc"), SkillId = 25 }, // Marketing en Redes Sociales
                new OfferSkill { OfferSkillId = 717, OfferId = Guid.Parse("cf9f4731-26f7-4ee7-94d3-44e7ee7443bc"), SkillId = 27 }, // Analytics de Marketing
                new OfferSkill { OfferSkillId = 718, OfferId = Guid.Parse("cf9f4731-26f7-4ee7-94d3-44e7ee7443bc"), SkillId = 28 }, // Estrategia de Marketing
                new OfferSkill { OfferSkillId = 719, OfferId = Guid.Parse("cf9f4731-26f7-4ee7-94d3-44e7ee7443bc"), SkillId = 30 }, // Branding
                new OfferSkill { OfferSkillId = 720, OfferId = Guid.Parse("cf9f4731-26f7-4ee7-94d3-44e7ee7443bc"), SkillId = 31 }, // Gestión del talento
                new OfferSkill { OfferSkillId = 721, OfferId = Guid.Parse("cf9f4731-26f7-4ee7-94d3-44e7ee7443bc"), SkillId = 32 }, // Selección de personal
                new OfferSkill { OfferSkillId = 722, OfferId = Guid.Parse("cf9f4731-26f7-4ee7-94d3-44e7ee7443bc"), SkillId = 33 }, // Capacitación y desarrollo

                new OfferSkill { OfferSkillId = 723, OfferId = Guid.Parse("87158aa4-8702-41be-bb46-11f3d7be70de"), SkillId = 10 }, // Ventas consultivas
                new OfferSkill { OfferSkillId = 724, OfferId = Guid.Parse("87158aa4-8702-41be-bb46-11f3d7be70de"), SkillId = 11 }, // Cierre de ventas
                new OfferSkill { OfferSkillId = 725, OfferId = Guid.Parse("87158aa4-8702-41be-bb46-11f3d7be70de"), SkillId = 14 }, // Relaciones comerciales
                new OfferSkill { OfferSkillId = 726, OfferId = Guid.Parse("87158aa4-8702-41be-bb46-11f3d7be70de"), SkillId = 16 }, // Estrategias de venta
                new OfferSkill { OfferSkillId = 727, OfferId = Guid.Parse("87158aa4-8702-41be-bb46-11f3d7be70de"), SkillId = 19 }, // Capacitación y desarrollo
                new OfferSkill { OfferSkillId = 728, OfferId = Guid.Parse("87158aa4-8702-41be-bb46-11f3d7be70de"), SkillId = 45 }, // Análisis de mercado
                new OfferSkill { OfferSkillId = 729, OfferId = Guid.Parse("87158aa4-8702-41be-bb46-11f3d7be70de"), SkillId = 46 }, // Estrategia de precios
                new OfferSkill { OfferSkillId = 730, OfferId = Guid.Parse("87158aa4-8702-41be-bb46-11f3d7be70de"), SkillId = 47 }, // Gestión de proveedores
                new OfferSkill { OfferSkillId = 731, OfferId = Guid.Parse("87158aa4-8702-41be-bb46-11f3d7be70de"), SkillId = 48 }, // Gestión de la cadena de suministro
                new OfferSkill { OfferSkillId = 732, OfferId = Guid.Parse("87158aa4-8702-41be-bb46-11f3d7be70de"), SkillId = 50 }, // Comercio electrónico

                new OfferSkill { OfferSkillId = 733, OfferId = Guid.Parse("b01bf51f-1bfa-4434-b70c-57c92e1b4c5d"), SkillId = 7 },  // Photoshop
                new OfferSkill { OfferSkillId = 734, OfferId = Guid.Parse("b01bf51f-1bfa-4434-b70c-57c92e1b4c5d"), SkillId = 8 },  // Excel
                new OfferSkill { OfferSkillId = 735, OfferId = Guid.Parse("b01bf51f-1bfa-4434-b70c-57c92e1b4c5d"), SkillId = 46 }, // Estrategia de precios
                new OfferSkill { OfferSkillId = 736, OfferId = Guid.Parse("b01bf51f-1bfa-4434-b70c-57c92e1b4c5d"), SkillId = 47 }, // Gestión de proveedores
                new OfferSkill { OfferSkillId = 737, OfferId = Guid.Parse("b01bf51f-1bfa-4434-b70c-57c92e1b4c5d"), SkillId = 48 }, // Gestión de la cadena de suministro
                new OfferSkill { OfferSkillId = 738, OfferId = Guid.Parse("b01bf51f-1bfa-4434-b70c-57c92e1b4c5d"), SkillId = 49 }, // Exportaciones e importaciones
                new OfferSkill { OfferSkillId = 739, OfferId = Guid.Parse("b01bf51f-1bfa-4434-b70c-57c92e1b4c5d"), SkillId = 68 }, // Manejo de bases de datos
                new OfferSkill { OfferSkillId = 740, OfferId = Guid.Parse("b01bf51f-1bfa-4434-b70c-57c92e1b4c5d"), SkillId = 69 }, // Elaboración de informes
                new OfferSkill { OfferSkillId = 741, OfferId = Guid.Parse("b01bf51f-1bfa-4434-b70c-57c92e1b4c5d"), SkillId = 70 }, // Organización de eventos
                new OfferSkill { OfferSkillId = 742, OfferId = Guid.Parse("b01bf51f-1bfa-4434-b70c-57c92e1b4c5d"), SkillId = 71 }, // PowerPoint

                new OfferSkill { OfferSkillId = 743, OfferId = Guid.Parse("cb440631-9b4e-4a3c-808b-6eefb7640244"), SkillId = 32 }, // Investigación de mercado
                new OfferSkill { OfferSkillId = 744, OfferId = Guid.Parse("cb440631-9b4e-4a3c-808b-6eefb7640244"), SkillId = 33 }, // Análisis de datos
                new OfferSkill { OfferSkillId = 745, OfferId = Guid.Parse("cb440631-9b4e-4a3c-808b-6eefb7640244"), SkillId = 34 }, // Presentaciones efectivas
                new OfferSkill { OfferSkillId = 746, OfferId = Guid.Parse("cb440631-9b4e-4a3c-808b-6eefb7640244"), SkillId = 35 }, // Proactividad
                new OfferSkill { OfferSkillId = 747, OfferId = Guid.Parse("cb440631-9b4e-4a3c-808b-6eefb7640244"), SkillId = 36 }, // Trabajo en equipo
                new OfferSkill { OfferSkillId = 748, OfferId = Guid.Parse("cb440631-9b4e-4a3c-808b-6eefb7640244"), SkillId = 37 }, // Autonomía
                new OfferSkill { OfferSkillId = 749, OfferId = Guid.Parse("cb440631-9b4e-4a3c-808b-6eefb7640244"), SkillId = 38 }, // Comunicación efectiva
                new OfferSkill { OfferSkillId = 750, OfferId = Guid.Parse("cb440631-9b4e-4a3c-808b-6eefb7640244"), SkillId = 39 }, // Iniciativa
                new OfferSkill { OfferSkillId = 751, OfferId = Guid.Parse("cb440631-9b4e-4a3c-808b-6eefb7640244"), SkillId = 40 }, // Gestión de proyectos
                new OfferSkill { OfferSkillId = 752, OfferId = Guid.Parse("cb440631-9b4e-4a3c-808b-6eefb7640244"), SkillId = 41 }, // Habilidades analíticas

                new OfferSkill { OfferSkillId = 753, OfferId = Guid.Parse("8212d2fc-d4e7-47ee-8aee-846d9242dc85"), SkillId = 41 }, // Habilidades analíticas
                new OfferSkill { OfferSkillId = 754, OfferId = Guid.Parse("8212d2fc-d4e7-47ee-8aee-846d9242dc85"), SkillId = 42 }, // Análisis financiero
                new OfferSkill { OfferSkillId = 755, OfferId = Guid.Parse("8212d2fc-d4e7-47ee-8aee-846d9242dc85"), SkillId = 43 }, // Elaboración de informes financieros
                new OfferSkill { OfferSkillId = 756, OfferId = Guid.Parse("8212d2fc-d4e7-47ee-8aee-846d9242dc85"), SkillId = 38 }, // Comunicación efectiva
                new OfferSkill { OfferSkillId = 757, OfferId = Guid.Parse("8212d2fc-d4e7-47ee-8aee-846d9242dc85"), SkillId = 35 }, // Proactividad
                new OfferSkill { OfferSkillId = 758, OfferId = Guid.Parse("8212d2fc-d4e7-47ee-8aee-846d9242dc85"), SkillId = 44 }, // Planificación financiera
                new OfferSkill { OfferSkillId = 759, OfferId = Guid.Parse("8212d2fc-d4e7-47ee-8aee-846d9242dc85"), SkillId = 45 }, // Presentaciones efectivas
                new OfferSkill { OfferSkillId = 760, OfferId = Guid.Parse("8212d2fc-d4e7-47ee-8aee-846d9242dc85"), SkillId = 46 }, // Control de gastos
                new OfferSkill { OfferSkillId = 761, OfferId = Guid.Parse("8212d2fc-d4e7-47ee-8aee-846d9242dc85"), SkillId = 47 }, // Elaboración de presupuestos
                new OfferSkill { OfferSkillId = 762, OfferId = Guid.Parse("8212d2fc-d4e7-47ee-8aee-846d9242dc85"), SkillId = 48 }, // Conocimientos de Excel avanzados

                new OfferSkill { OfferSkillId = 763, OfferId = Guid.Parse("4dbb52e1-d34e-4383-8bcb-049e545020f2"), SkillId = 1 }, // C#
                new OfferSkill { OfferSkillId = 764, OfferId = Guid.Parse("4dbb52e1-d34e-4383-8bcb-049e545020f2"), SkillId = 8 }, // SQL
                new OfferSkill { OfferSkillId = 765, OfferId = Guid.Parse("4dbb52e1-d34e-4383-8bcb-049e545020f2"), SkillId = 10 }, // Ventas consultivas
                new OfferSkill { OfferSkillId = 766, OfferId = Guid.Parse("4dbb52e1-d34e-4383-8bcb-049e545020f2"), SkillId = 11 }, // Cierre de ventas
                new OfferSkill { OfferSkillId = 767, OfferId = Guid.Parse("4dbb52e1-d34e-4383-8bcb-049e545020f2"), SkillId = 12 }, // Prospección de clientes
                new OfferSkill { OfferSkillId = 768, OfferId = Guid.Parse("4dbb52e1-d34e-4383-8bcb-049e545020f2"), SkillId = 13 }, // Manejo de objeciones
                new OfferSkill { OfferSkillId = 769, OfferId = Guid.Parse("4dbb52e1-d34e-4383-8bcb-049e545020f2"), SkillId = 14 }, // Relaciones comerciales
                new OfferSkill { OfferSkillId = 770, OfferId = Guid.Parse("4dbb52e1-d34e-4383-8bcb-049e545020f2"), SkillId = 15 }, // Presentaciones de ventas
                new OfferSkill { OfferSkillId = 771, OfferId = Guid.Parse("4dbb52e1-d34e-4383-8bcb-049e545020f2"), SkillId = 16 }, // Estrategias de venta
                new OfferSkill { OfferSkillId = 772, OfferId = Guid.Parse("4dbb52e1-d34e-4383-8bcb-049e545020f2"), SkillId = 17 },  // Gestión del talento

                new OfferSkill { OfferSkillId = 773, OfferId = Guid.Parse("7c081f3d-6f03-4a38-bc5d-88ebe23baf6e"), SkillId = 71 }, // PowerPoint
                new OfferSkill { OfferSkillId = 774, OfferId = Guid.Parse("7c081f3d-6f03-4a38-bc5d-88ebe23baf6e"), SkillId = 68 }, // Manejo de bases de datos
                new OfferSkill { OfferSkillId = 775, OfferId = Guid.Parse("7c081f3d-6f03-4a38-bc5d-88ebe23baf6e"), SkillId = 67 }, // Control de gastos
                new OfferSkill { OfferSkillId = 776, OfferId = Guid.Parse("7c081f3d-6f03-4a38-bc5d-88ebe23baf6e"), SkillId = 43 }, // Gestión de inventario
                new OfferSkill { OfferSkillId = 777, OfferId = Guid.Parse("7c081f3d-6f03-4a38-bc5d-88ebe23baf6e"), SkillId = 3 }, // JavaScript
                new OfferSkill { OfferSkillId = 778, OfferId = Guid.Parse("7c081f3d-6f03-4a38-bc5d-88ebe23baf6e"), SkillId = 48 }, // Gestión de la cadena de suministro
                new OfferSkill { OfferSkillId = 779, OfferId = Guid.Parse("7c081f3d-6f03-4a38-bc5d-88ebe23baf6e"), SkillId = 36 }, // Administración de nómina
                new OfferSkill { OfferSkillId = 780, OfferId = Guid.Parse("7c081f3d-6f03-4a38-bc5d-88ebe23baf6e"), SkillId = 49 }, // Exportaciones e importaciones
                new OfferSkill { OfferSkillId = 781, OfferId = Guid.Parse("7c081f3d-6f03-4a38-bc5d-88ebe23baf6e"), SkillId = 11 }, // Cierre de ventas
                new OfferSkill { OfferSkillId = 782, OfferId = Guid.Parse("7c081f3d-6f03-4a38-bc5d-88ebe23baf6e"), SkillId = 10 }, // Ventas consultivas

                new OfferSkill { OfferSkillId = 783, OfferId = Guid.Parse("a06d4fd8-3f4d-4bc7-8f70-4f9d3204000a"), SkillId = 1 }, // C#
                new OfferSkill { OfferSkillId = 784, OfferId = Guid.Parse("a06d4fd8-3f4d-4bc7-8f70-4f9d3204000a"), SkillId = 3 }, // JavaScript
                new OfferSkill { OfferSkillId = 785, OfferId = Guid.Parse("a06d4fd8-3f4d-4bc7-8f70-4f9d3204000a"), SkillId = 4 }, // Node.Js
                new OfferSkill { OfferSkillId = 786, OfferId = Guid.Parse("a06d4fd8-3f4d-4bc7-8f70-4f9d3204000a"), SkillId = 5 }, // HTML
                new OfferSkill { OfferSkillId = 787, OfferId = Guid.Parse("a06d4fd8-3f4d-4bc7-8f70-4f9d3204000a"), SkillId = 6 }, // CSS
                new OfferSkill { OfferSkillId = 788, OfferId = Guid.Parse("a06d4fd8-3f4d-4bc7-8f70-4f9d3204000a"), SkillId = 9 }, // Word
                new OfferSkill { OfferSkillId = 789, OfferId = Guid.Parse("a06d4fd8-3f4d-4bc7-8f70-4f9d3204000a"), SkillId = 16 }, // Estrategias de venta
                new OfferSkill { OfferSkillId = 790, OfferId = Guid.Parse("a06d4fd8-3f4d-4bc7-8f70-4f9d3204000a"), SkillId = 28 }, // Estrategia de Marketing
                new OfferSkill { OfferSkillId = 791, OfferId = Guid.Parse("a06d4fd8-3f4d-4bc7-8f70-4f9d3204000a"), SkillId = 70 }, // Organización de eventos
                new OfferSkill { OfferSkillId = 792, OfferId = Guid.Parse("a06d4fd8-3f4d-4bc7-8f70-4f9d3204000a"), SkillId = 86 }, // Salesforce

                new OfferSkill { OfferSkillId = 793, OfferId = Guid.Parse("1233490d-6014-4ebd-8ef5-1d3801d6b207"), SkillId = 28 }, // Estrategia de Marketing
                new OfferSkill { OfferSkillId = 794, OfferId = Guid.Parse("1233490d-6014-4ebd-8ef5-1d3801d6b207"), SkillId = 29 }, // Investigación de Mercado
                new OfferSkill { OfferSkillId = 795, OfferId = Guid.Parse("1233490d-6014-4ebd-8ef5-1d3801d6b207"), SkillId = 30 }, // Branding
                new OfferSkill { OfferSkillId = 796, OfferId = Guid.Parse("1233490d-6014-4ebd-8ef5-1d3801d6b207"), SkillId = 31 }, // Gestión del talento
                new OfferSkill { OfferSkillId = 797, OfferId = Guid.Parse("1233490d-6014-4ebd-8ef5-1d3801d6b207"), SkillId = 39 }, // Gestión del cambio
                new OfferSkill { OfferSkillId = 798, OfferId = Guid.Parse("1233490d-6014-4ebd-8ef5-1d3801d6b207"), SkillId = 86 }, // Salesforce
                new OfferSkill { OfferSkillId = 799, OfferId = Guid.Parse("1233490d-6014-4ebd-8ef5-1d3801d6b207"), SkillId = 87 }, // Tableau
                new OfferSkill { OfferSkillId = 800, OfferId = Guid.Parse("1233490d-6014-4ebd-8ef5-1d3801d6b207"), SkillId = 88 }, // JIRA
                new OfferSkill { OfferSkillId = 801, OfferId = Guid.Parse("1233490d-6014-4ebd-8ef5-1d3801d6b207"), SkillId = 89 }, // Confluence
                new OfferSkill { OfferSkillId = 802, OfferId = Guid.Parse("1233490d-6014-4ebd-8ef5-1d3801d6b207"), SkillId = 90 }, // Zendesk

                new OfferSkill { OfferSkillId = 803, OfferId = Guid.Parse("98c748ed-fb3e-46f0-881e-3f820ff28a4b"), SkillId = 1 }, // C#
                new OfferSkill { OfferSkillId = 804, OfferId = Guid.Parse("98c748ed-fb3e-46f0-881e-3f820ff28a4b"), SkillId = 9 }, // Word
                new OfferSkill { OfferSkillId = 805, OfferId = Guid.Parse("98c748ed-fb3e-46f0-881e-3f820ff28a4b"), SkillId = 28 }, // Estrategia de Marketing
                new OfferSkill { OfferSkillId = 806, OfferId = Guid.Parse("98c748ed-fb3e-46f0-881e-3f820ff28a4b"), SkillId = 29 }, // Investigación de Mercado
                new OfferSkill { OfferSkillId = 807, OfferId = Guid.Parse("98c748ed-fb3e-46f0-881e-3f820ff28a4b"), SkillId = 31 }, // Gestión del talento
                new OfferSkill { OfferSkillId = 808, OfferId = Guid.Parse("98c748ed-fb3e-46f0-881e-3f820ff28a4b"), SkillId = 39 }, // Gestión del cambio
                new OfferSkill { OfferSkillId = 809, OfferId = Guid.Parse("98c748ed-fb3e-46f0-881e-3f820ff28a4b"), SkillId = 41 }, // Compras y aprovisionamiento
                new OfferSkill { OfferSkillId = 810, OfferId = Guid.Parse("98c748ed-fb3e-46f0-881e-3f820ff28a4b"), SkillId = 42 }, // Logística de abastecimiento
                new OfferSkill { OfferSkillId = 811, OfferId = Guid.Parse("98c748ed-fb3e-46f0-881e-3f820ff28a4b"), SkillId = 43 }, // Gestión de inventario
                new OfferSkill { OfferSkillId = 812, OfferId = Guid.Parse("98c748ed-fb3e-46f0-881e-3f820ff28a4b"), SkillId = 44 }, // Planificación de la demanda

                new OfferSkill { OfferSkillId = 813, OfferId = Guid.Parse("e9e19908-2b38-4d06-8499-2d6545d9de4b"), SkillId = 4 }, // Node.Js
                new OfferSkill { OfferSkillId = 814, OfferId = Guid.Parse("e9e19908-2b38-4d06-8499-2d6545d9de4b"), SkillId = 28 }, // Estrategia de Marketing
                new OfferSkill { OfferSkillId = 815, OfferId = Guid.Parse("e9e19908-2b38-4d06-8499-2d6545d9de4b"), SkillId = 45 }, // Análisis de mercado
                new OfferSkill { OfferSkillId = 816, OfferId = Guid.Parse("e9e19908-2b38-4d06-8499-2d6545d9de4b"), SkillId = 52 }, // Asesoría legal
                new OfferSkill { OfferSkillId = 817, OfferId = Guid.Parse("e9e19908-2b38-4d06-8499-2d6545d9de4b"), SkillId = 64 }, // Archivo y registro
                new OfferSkill { OfferSkillId = 818, OfferId = Guid.Parse("e9e19908-2b38-4d06-8499-2d6545d9de4b"), SkillId = 68 }, // Manejo de bases de datos
                new OfferSkill { OfferSkillId = 819, OfferId = Guid.Parse("e9e19908-2b38-4d06-8499-2d6545d9de4b"), SkillId = 77 }, // Adobe Illustrator
                new OfferSkill { OfferSkillId = 820, OfferId = Guid.Parse("e9e19908-2b38-4d06-8499-2d6545d9de4b"), SkillId = 78 }, // Adobe InDesign
                new OfferSkill { OfferSkillId = 821, OfferId = Guid.Parse("e9e19908-2b38-4d06-8499-2d6545d9de4b"), SkillId = 79 }, // Adobe Premiere Pro

                new OfferSkill { OfferSkillId = 822, OfferId = Guid.Parse("4aa15359-2d8d-4e2c-9c07-7d6f1a5e7801"), SkillId = 51 }, // Asesoría financiera
                new OfferSkill { OfferSkillId = 823, OfferId = Guid.Parse("4aa15359-2d8d-4e2c-9c07-7d6f1a5e7801"), SkillId = 52 }, // Asesoría legal
                new OfferSkill { OfferSkillId = 824, OfferId = Guid.Parse("4aa15359-2d8d-4e2c-9c07-7d6f1a5e7801"), SkillId = 67 }, // Control de gastos
                new OfferSkill { OfferSkillId = 825, OfferId = Guid.Parse("4aa15359-2d8d-4e2c-9c07-7d6f1a5e7801"), SkillId = 69 }, // Elaboración de informes
                new OfferSkill { OfferSkillId = 826, OfferId = Guid.Parse("4aa15359-2d8d-4e2c-9c07-7d6f1a5e7801"), SkillId = 74 }, // Google Slides
                new OfferSkill { OfferSkillId = 827, OfferId = Guid.Parse("4aa15359-2d8d-4e2c-9c07-7d6f1a5e7801"), SkillId = 77 }, // Adobe Illustrator
                new OfferSkill { OfferSkillId = 828, OfferId = Guid.Parse("4aa15359-2d8d-4e2c-9c07-7d6f1a5e7801"), SkillId = 78 }, // Adobe InDesign
                new OfferSkill { OfferSkillId = 829, OfferId = Guid.Parse("4aa15359-2d8d-4e2c-9c07-7d6f1a5e7801"), SkillId = 79 }, // Adobe Premiere Pro
                new OfferSkill { OfferSkillId = 830, OfferId = Guid.Parse("4aa15359-2d8d-4e2c-9c07-7d6f1a5e7801"), SkillId = 88 }, // JIRA
                new OfferSkill { OfferSkillId = 831, OfferId = Guid.Parse("4aa15359-2d8d-4e2c-9c07-7d6f1a5e7801"), SkillId = 95 }, // Slack


                new OfferSkill { OfferSkillId = 832, OfferId = Guid.Parse("556e0544-f769-4d92-8a68-97148942b0b7"), SkillId = 31 }, // Gestión del talento
                new OfferSkill { OfferSkillId = 833, OfferId = Guid.Parse("556e0544-f769-4d92-8a68-97148942b0b7"), SkillId = 33 }, // Capacitación y desarrollo
                new OfferSkill { OfferSkillId = 834, OfferId = Guid.Parse("556e0544-f769-4d92-8a68-97148942b0b7"), SkillId = 60 }, // Asesoría en marketing
                new OfferSkill { OfferSkillId = 835, OfferId = Guid.Parse("556e0544-f769-4d92-8a68-97148942b0b7"), SkillId = 20 }, // Compensación y beneficios
                new OfferSkill { OfferSkillId = 836, OfferId = Guid.Parse("556e0544-f769-4d92-8a68-97148942b0b7"), SkillId = 38 }, // Cultura organizacional
                new OfferSkill { OfferSkillId = 837, OfferId = Guid.Parse("556e0544-f769-4d92-8a68-97148942b0b7"), SkillId = 40 }, // Gestión del rendimiento
                new OfferSkill { OfferSkillId = 838, OfferId = Guid.Parse("556e0544-f769-4d92-8a68-97148942b0b7"), SkillId = 52 }, // Asesoría legal
                new OfferSkill { OfferSkillId = 839, OfferId = Guid.Parse("556e0544-f769-4d92-8a68-97148942b0b7"), SkillId = 54 }, // Asesoría en inversiones
                new OfferSkill { OfferSkillId = 840, OfferId = Guid.Parse("556e0544-f769-4d92-8a68-97148942b0b7"), SkillId = 63 }, // Archivo y registro
                new OfferSkill { OfferSkillId = 841, OfferId = Guid.Parse("556e0544-f769-4d92-8a68-97148942b0b7"), SkillId = 67 }, // Control de gastos

                new OfferSkill { OfferSkillId = 842, OfferId = Guid.Parse("fc54aecd-32d3-4de3-94d0-e26d09d3a8e7"), SkillId = 51 }, // Asesoría financiera
                new OfferSkill { OfferSkillId = 843, OfferId = Guid.Parse("fc54aecd-32d3-4de3-94d0-e26d09d3a8e7"), SkillId = 52 }, // Asesoría legal
                new OfferSkill { OfferSkillId = 844, OfferId = Guid.Parse("fc54aecd-32d3-4de3-94d0-e26d09d3a8e7"), SkillId = 68 }, // Manejo de bases de datos
                new OfferSkill { OfferSkillId = 845, OfferId = Guid.Parse("fc54aecd-32d3-4de3-94d0-e26d09d3a8e7"), SkillId = 69 }, // Elaboración de informes
                new OfferSkill { OfferSkillId = 846, OfferId = Guid.Parse("fc54aecd-32d3-4de3-94d0-e26d09d3a8e7"), SkillId = 70 }, // Organización de eventos
                new OfferSkill { OfferSkillId = 847, OfferId = Guid.Parse("fc54aecd-32d3-4de3-94d0-e26d09d3a8e7"), SkillId = 73 }, // Google Docs
                new OfferSkill { OfferSkillId = 848, OfferId = Guid.Parse("fc54aecd-32d3-4de3-94d0-e26d09d3a8e7"), SkillId = 76 }, // QuickBooks
                new OfferSkill { OfferSkillId = 849, OfferId = Guid.Parse("fc54aecd-32d3-4de3-94d0-e26d09d3a8e7"), SkillId = 85 }, // SAP
                new OfferSkill { OfferSkillId = 850, OfferId = Guid.Parse("fc54aecd-32d3-4de3-94d0-e26d09d3a8e7"), SkillId = 88 }, // JIRA
                new OfferSkill { OfferSkillId = 851, OfferId = Guid.Parse("fc54aecd-32d3-4de3-94d0-e26d09d3a8e7"), SkillId = 96 }, // Microsoft Teams

                new OfferSkill { OfferSkillId = 852, OfferId = Guid.Parse("51ee0986-9f82-4a0f-86a7-64b1871ef3f2"), SkillId = 71 }, // PowerPoint
                new OfferSkill { OfferSkillId = 853, OfferId = Guid.Parse("51ee0986-9f82-4a0f-86a7-64b1871ef3f2"), SkillId = 60 }, // Asesoría en marketing
                new OfferSkill { OfferSkillId = 854, OfferId = Guid.Parse("51ee0986-9f82-4a0f-86a7-64b1871ef3f2"), SkillId = 46 }, // Estrategia de precios
                new OfferSkill { OfferSkillId = 855, OfferId = Guid.Parse("51ee0986-9f82-4a0f-86a7-64b1871ef3f2"), SkillId = 27 }, // Analytics de Marketing
                new OfferSkill { OfferSkillId = 856, OfferId = Guid.Parse("51ee0986-9f82-4a0f-86a7-64b1871ef3f2"), SkillId = 18 }, // Selección de personal
                new OfferSkill { OfferSkillId = 857, OfferId = Guid.Parse("51ee0986-9f82-4a0f-86a7-64b1871ef3f2"), SkillId = 1 },  // C#
                new OfferSkill { OfferSkillId = 858, OfferId = Guid.Parse("51ee0986-9f82-4a0f-86a7-64b1871ef3f2"), SkillId = 30 }, // Branding
                new OfferSkill { OfferSkillId = 859, OfferId = Guid.Parse("51ee0986-9f82-4a0f-86a7-64b1871ef3f2"), SkillId = 3 },  // JavaScript
                new OfferSkill { OfferSkillId = 860, OfferId = Guid.Parse("51ee0986-9f82-4a0f-86a7-64b1871ef3f2"), SkillId = 22 }, // SEM (Marketing en Motores de Búsqueda)
                new OfferSkill { OfferSkillId = 861, OfferId = Guid.Parse("51ee0986-9f82-4a0f-86a7-64b1871ef3f2"), SkillId = 28 }, // Estrategia de Marketing

                new OfferSkill { OfferSkillId = 862, OfferId = Guid.Parse("0e3a7879-7587-43f5-a9cf-657a824d1fc5"), SkillId = 86 }, // Salesforce
                new OfferSkill { OfferSkillId = 863, OfferId = Guid.Parse("0e3a7879-7587-43f5-a9cf-657a824d1fc5"), SkillId = 85 }, // SAP
                new OfferSkill { OfferSkillId = 864, OfferId = Guid.Parse("0e3a7879-7587-43f5-a9cf-657a824d1fc5"), SkillId = 88 }, // JIRA
                new OfferSkill { OfferSkillId = 865, OfferId = Guid.Parse("0e3a7879-7587-43f5-a9cf-657a824d1fc5"), SkillId = 89 }, // Confluence
                new OfferSkill { OfferSkillId = 866, OfferId = Guid.Parse("0e3a7879-7587-43f5-a9cf-657a824d1fc5"), SkillId = 77 }, // Adobe Illustrator
                new OfferSkill { OfferSkillId = 867, OfferId = Guid.Parse("0e3a7879-7587-43f5-a9cf-657a824d1fc5"), SkillId = 78 }, // Adobe InDesign
                new OfferSkill { OfferSkillId = 868, OfferId = Guid.Parse("0e3a7879-7587-43f5-a9cf-657a824d1fc5"), SkillId = 79 }, // Adobe Premiere Pro
                new OfferSkill { OfferSkillId = 869, OfferId = Guid.Parse("0e3a7879-7587-43f5-a9cf-657a824d1fc5"), SkillId = 64 }, // Atención telefónica
                new OfferSkill { OfferSkillId = 870, OfferId = Guid.Parse("0e3a7879-7587-43f5-a9cf-657a824d1fc5"), SkillId = 68 }, // Manejo de bases de datos

                new OfferSkill { OfferSkillId = 871, OfferId = Guid.Parse("d3d478ef-2b5a-4265-a81c-7d9123982fb9"), SkillId = 10 }, // Ventas consultivas
                new OfferSkill { OfferSkillId = 872, OfferId = Guid.Parse("d3d478ef-2b5a-4265-a81c-7d9123982fb9"), SkillId = 11 }, // Cierre de ventas
                new OfferSkill { OfferSkillId = 873, OfferId = Guid.Parse("d3d478ef-2b5a-4265-a81c-7d9123982fb9"), SkillId = 12 }, // Prospección de clientes
                new OfferSkill { OfferSkillId = 874, OfferId = Guid.Parse("d3d478ef-2b5a-4265-a81c-7d9123982fb9"), SkillId = 13 }, // Manejo de objeciones
                new OfferSkill { OfferSkillId = 875, OfferId = Guid.Parse("d3d478ef-2b5a-4265-a81c-7d9123982fb9"), SkillId = 14 }, // Relaciones comerciales
                new OfferSkill { OfferSkillId = 876, OfferId = Guid.Parse("d3d478ef-2b5a-4265-a81c-7d9123982fb9"), SkillId = 15 }, // Presentaciones de ventas
                new OfferSkill { OfferSkillId = 877, OfferId = Guid.Parse("d3d478ef-2b5a-4265-a81c-7d9123982fb9"), SkillId = 16 }, // Estrategias de venta
                new OfferSkill { OfferSkillId = 878, OfferId = Guid.Parse("d3d478ef-2b5a-4265-a81c-7d9123982fb9"), SkillId = 50 }, // Comercio electrónico
                new OfferSkill { OfferSkillId = 879, OfferId = Guid.Parse("d3d478ef-2b5a-4265-a81c-7d9123982fb9"), SkillId = 67 }, // Control de gastos
                new OfferSkill { OfferSkillId = 880, OfferId = Guid.Parse("d3d478ef-2b5a-4265-a81c-7d9123982fb9"), SkillId = 65 }, // Gestión de correos electrónicos

                new OfferSkill { OfferSkillId = 881, OfferId = Guid.Parse("c7aeb14d-01e7-4d08-b659-11c424e69728"), SkillId = 10 }, // Ventas consultivas
                new OfferSkill { OfferSkillId = 882, OfferId = Guid.Parse("c7aeb14d-01e7-4d08-b659-11c424e69728"), SkillId = 11 }, // Cierre de ventas
                new OfferSkill { OfferSkillId = 883, OfferId = Guid.Parse("c7aeb14d-01e7-4d08-b659-11c424e69728"), SkillId = 13 }, // Manejo de objeciones
                new OfferSkill { OfferSkillId = 884, OfferId = Guid.Parse("c7aeb14d-01e7-4d08-b659-11c424e69728"), SkillId = 14 }, // Relaciones comerciales
                new OfferSkill { OfferSkillId = 885, OfferId = Guid.Parse("c7aeb14d-01e7-4d08-b659-11c424e69728"), SkillId = 15 }, // Presentaciones de ventas
                new OfferSkill { OfferSkillId = 886, OfferId = Guid.Parse("c7aeb14d-01e7-4d08-b659-11c424e69728"), SkillId = 16 }, // Estrategias de venta
                new OfferSkill { OfferSkillId = 887, OfferId = Guid.Parse("c7aeb14d-01e7-4d08-b659-11c424e69728"), SkillId = 23 }, // Marketing de Contenidos
                new OfferSkill { OfferSkillId = 888, OfferId = Guid.Parse("c7aeb14d-01e7-4d08-b659-11c424e69728"), SkillId = 25 }, // Marketing en Redes Sociales
                new OfferSkill { OfferSkillId = 889, OfferId = Guid.Parse("c7aeb14d-01e7-4d08-b659-11c424e69728"), SkillId = 28 }, // Estrategia de Marketing
                new OfferSkill { OfferSkillId = 890, OfferId = Guid.Parse("c7aeb14d-01e7-4d08-b659-11c424e69728"), SkillId = 45 }, // Análisis de mercado

                new OfferSkill { OfferSkillId = 891, OfferId = Guid.Parse("4a6decd4-ae8b-4a6d-95eb-13aeb00770a7"), SkillId = 68 }, // Manejo de bases de datos
                new OfferSkill { OfferSkillId = 892, OfferId = Guid.Parse("4a6decd4-ae8b-4a6d-95eb-13aeb00770a7"), SkillId = 45 }, // Análisis de mercado
                new OfferSkill { OfferSkillId = 893, OfferId = Guid.Parse("4a6decd4-ae8b-4a6d-95eb-13aeb00770a7"), SkillId = 43 }, // Gestión de inventario
                new OfferSkill { OfferSkillId = 894, OfferId = Guid.Parse("4a6decd4-ae8b-4a6d-95eb-13aeb00770a7"), SkillId = 44 }, // Planificación de la demanda
                new OfferSkill { OfferSkillId = 895, OfferId = Guid.Parse("4a6decd4-ae8b-4a6d-95eb-13aeb00770a7"), SkillId = 28 }, // Estrategia de Marketing
                new OfferSkill { OfferSkillId = 896, OfferId = Guid.Parse("4a6decd4-ae8b-4a6d-95eb-13aeb00770a7"), SkillId = 25 }, // Marketing en Redes Sociales
                new OfferSkill { OfferSkillId = 897, OfferId = Guid.Parse("4a6decd4-ae8b-4a6d-95eb-13aeb00770a7"), SkillId = 86 }, // Salesforce
                new OfferSkill { OfferSkillId = 898, OfferId = Guid.Parse("4a6decd4-ae8b-4a6d-95eb-13aeb00770a7"), SkillId = 87 }, // Tableau
                new OfferSkill { OfferSkillId = 899, OfferId = Guid.Parse("4a6decd4-ae8b-4a6d-95eb-13aeb00770a7"), SkillId = 91 }, // GitHub
                new OfferSkill { OfferSkillId = 900, OfferId = Guid.Parse("4a6decd4-ae8b-4a6d-95eb-13aeb00770a7"), SkillId = 40 }, // Gestión del rendimiento

                new OfferSkill { OfferSkillId = 901, OfferId = Guid.Parse("87b7e22d-d7fd-45c0-b0c3-06da652cb9eb"), SkillId = 3 }, // JavaScript
                new OfferSkill { OfferSkillId = 902, OfferId = Guid.Parse("87b7e22d-d7fd-45c0-b0c3-06da652cb9eb"), SkillId = 4 }, // Node.Js
                new OfferSkill { OfferSkillId = 903, OfferId = Guid.Parse("87b7e22d-d7fd-45c0-b0c3-06da652cb9eb"), SkillId = 1 }, // C#
                new OfferSkill { OfferSkillId = 904, OfferId = Guid.Parse("87b7e22d-d7fd-45c0-b0c3-06da652cb9eb"), SkillId = 91 }, // GitHub
                new OfferSkill { OfferSkillId = 905, OfferId = Guid.Parse("87b7e22d-d7fd-45c0-b0c3-06da652cb9eb"), SkillId = 27 }, // Analytics de Marketing
                new OfferSkill { OfferSkillId = 906, OfferId = Guid.Parse("87b7e22d-d7fd-45c0-b0c3-06da652cb9eb"), SkillId = 88 }, // JIRA
                new OfferSkill { OfferSkillId = 907, OfferId = Guid.Parse("87b7e22d-d7fd-45c0-b0c3-06da652cb9eb"), SkillId = 95 }, // Slack
                new OfferSkill { OfferSkillId = 908, OfferId = Guid.Parse("87b7e22d-d7fd-45c0-b0c3-06da652cb9eb"), SkillId = 96 }, // Microsoft Teams
                new OfferSkill { OfferSkillId = 909, OfferId = Guid.Parse("87b7e22d-d7fd-45c0-b0c3-06da652cb9eb"), SkillId = 91 }, // GitHub
                new OfferSkill { OfferSkillId = 910, OfferId = Guid.Parse("87b7e22d-d7fd-45c0-b0c3-06da652cb9eb"), SkillId = 92 }, // GitLab

                new OfferSkill { OfferSkillId = 911, OfferId = Guid.Parse("2a47a025-03b4-46a3-985a-45e1a1e52b53"), SkillId = 10 }, // Ventas consultivas
                new OfferSkill { OfferSkillId = 912, OfferId = Guid.Parse("2a47a025-03b4-46a3-985a-45e1a1e52b53"), SkillId = 11 }, // Cierre de ventas
                new OfferSkill { OfferSkillId = 913, OfferId = Guid.Parse("2a47a025-03b4-46a3-985a-45e1a1e52b53"), SkillId = 12 }, // Prospección de clientes
                new OfferSkill { OfferSkillId = 914, OfferId = Guid.Parse("2a47a025-03b4-46a3-985a-45e1a1e52b53"), SkillId = 13 }, // Manejo de objeciones
                new OfferSkill { OfferSkillId = 915, OfferId = Guid.Parse("2a47a025-03b4-46a3-985a-45e1a1e52b53"), SkillId = 14 }, // Relaciones comerciales
                new OfferSkill { OfferSkillId = 916, OfferId = Guid.Parse("2a47a025-03b4-46a3-985a-45e1a1e52b53"), SkillId = 15 }, // Presentaciones de ventas
                new OfferSkill { OfferSkillId = 917, OfferId = Guid.Parse("2a47a025-03b4-46a3-985a-45e1a1e52b53"), SkillId = 16 }, // Estrategias de venta
                new OfferSkill { OfferSkillId = 918, OfferId = Guid.Parse("2a47a025-03b4-46a3-985a-45e1a1e52b53"), SkillId = 13 }, // Manejo de objeciones
                new OfferSkill { OfferSkillId = 919, OfferId = Guid.Parse("2a47a025-03b4-46a3-985a-45e1a1e52b53"), SkillId = 14 }, // Relaciones comerciales
                new OfferSkill { OfferSkillId = 920, OfferId = Guid.Parse("2a47a025-03b4-46a3-985a-45e1a1e52b53"), SkillId = 41 }, // Compras y aprovisionamiento
                new OfferSkill { OfferSkillId = 921, OfferId = Guid.Parse("2a47a025-03b4-46a3-985a-45e1a1e52b53"), SkillId = 44 }, // Planificación de la demanda

                new OfferSkill { OfferSkillId = 922, OfferId = Guid.Parse("0df2461b-f778-4d26-8a0b-88e63010bc63"), SkillId = 10 }, // Ventas consultivas
                new OfferSkill { OfferSkillId = 923, OfferId = Guid.Parse("0df2461b-f778-4d26-8a0b-88e63010bc63"), SkillId = 11 }, // Cierre de ventas
                new OfferSkill { OfferSkillId = 924, OfferId = Guid.Parse("0df2461b-f778-4d26-8a0b-88e63010bc63"), SkillId = 12 }, // Prospección de clientes
                new OfferSkill { OfferSkillId = 925, OfferId = Guid.Parse("0df2461b-f778-4d26-8a0b-88e63010bc63"), SkillId = 13 }, // Manejo de objeciones
                new OfferSkill { OfferSkillId = 926, OfferId = Guid.Parse("0df2461b-f778-4d26-8a0b-88e63010bc63"), SkillId = 14 }, // Relaciones comerciales
                new OfferSkill { OfferSkillId = 927, OfferId = Guid.Parse("0df2461b-f778-4d26-8a0b-88e63010bc63"), SkillId = 15 }, // Presentaciones de ventas
                new OfferSkill { OfferSkillId = 928, OfferId = Guid.Parse("0df2461b-f778-4d26-8a0b-88e63010bc63"), SkillId = 16 }, // Estrategias de venta
                new OfferSkill { OfferSkillId = 929, OfferId = Guid.Parse("0df2461b-f778-4d26-8a0b-88e63010bc63"), SkillId = 27 }, // Analytics de Marketing
                new OfferSkill { OfferSkillId = 930, OfferId = Guid.Parse("0df2461b-f778-4d26-8a0b-88e63010bc63"), SkillId = 28 }, // Estrategia de Marketing
                new OfferSkill { OfferSkillId = 931, OfferId = Guid.Parse("0df2461b-f778-4d26-8a0b-88e63010bc63"), SkillId = 41 }, // Compras y aprovisionamiento

                new OfferSkill { OfferSkillId = 932, OfferId = Guid.Parse("d63e5d07-606f-414b-86d7-2b9f9907bde0"), SkillId = 3 }, // JavaScript (para scripts y automatización)
                new OfferSkill { OfferSkillId = 933, OfferId = Guid.Parse("d63e5d07-606f-414b-86d7-2b9f9907bde0"), SkillId = 4 }, // Node.Js (para scripts y automatización)
                new OfferSkill { OfferSkillId = 934, OfferId = Guid.Parse("d63e5d07-606f-414b-86d7-2b9f9907bde0"), SkillId = 8 }, // Excel (para gestión de datos y reportes)
                new OfferSkill { OfferSkillId = 935, OfferId = Guid.Parse("d63e5d07-606f-414b-86d7-2b9f9907bde0"), SkillId = 27 }, // Analytics de Marketing (para monitoreo de seguridad)
                new OfferSkill { OfferSkillId = 936, OfferId = Guid.Parse("d63e5d07-606f-414b-86d7-2b9f9907bde0"), SkillId = 82 }, // MATLAB (para análisis técnico avanzado)
                new OfferSkill { OfferSkillId = 937, OfferId = Guid.Parse("d63e5d07-606f-414b-86d7-2b9f9907bde0"), SkillId = 85 }, // SAP (para gestión de datos y seguridad)
                new OfferSkill { OfferSkillId = 938, OfferId = Guid.Parse("d63e5d07-606f-414b-86d7-2b9f9907bde0"), SkillId = 86 }, // Salesforce (para integración y gestión de datos)
                new OfferSkill { OfferSkillId = 939, OfferId = Guid.Parse("d63e5d07-606f-414b-86d7-2b9f9907bde0"), SkillId = 91 }, // GitHub (para gestión de código y colaboración)
                new OfferSkill { OfferSkillId = 940, OfferId = Guid.Parse("d63e5d07-606f-414b-86d7-2b9f9907bde0"), SkillId = 97 }, // Zoom (para colaboración y reuniones)
                new OfferSkill { OfferSkillId = 941, OfferId = Guid.Parse("d63e5d07-606f-414b-86d7-2b9f9907bde0"), SkillId = 99 }, // Skype (para colaboración y reuniones)

                new OfferSkill { OfferSkillId = 942, OfferId = Guid.Parse("93c7688d-e348-44db-97ec-cd46e4e46d53"), SkillId = 86 }, // Salesforce
                new OfferSkill { OfferSkillId = 943, OfferId = Guid.Parse("93c7688d-e348-44db-97ec-cd46e4e46d53"), SkillId = 1 },  // C#
                new OfferSkill { OfferSkillId = 944, OfferId = Guid.Parse("93c7688d-e348-44db-97ec-cd46e4e46d53"), SkillId = 3 },  // JavaScript
                new OfferSkill { OfferSkillId = 945, OfferId = Guid.Parse("93c7688d-e348-44db-97ec-cd46e4e46d53"), SkillId = 4 },  // Node.Js
                new OfferSkill { OfferSkillId = 946, OfferId = Guid.Parse("93c7688d-e348-44db-97ec-cd46e4e46d53"), SkillId = 91 }, // GitHub
                new OfferSkill { OfferSkillId = 947, OfferId = Guid.Parse("93c7688d-e348-44db-97ec-cd46e4e46d53"), SkillId = 92 }, // GitLab
                new OfferSkill { OfferSkillId = 948, OfferId = Guid.Parse("93c7688d-e348-44db-97ec-cd46e4e46d53"), SkillId = 97 }, // Zoom
                new OfferSkill { OfferSkillId = 949, OfferId = Guid.Parse("93c7688d-e348-44db-97ec-cd46e4e46d53"), SkillId = 6 },  // CSS
                new OfferSkill { OfferSkillId = 950, OfferId = Guid.Parse("93c7688d-e348-44db-97ec-cd46e4e46d53"), SkillId = 21 }, // SEO (Optimización de Motores de Búsqueda)
                new OfferSkill { OfferSkillId = 951, OfferId = Guid.Parse("93c7688d-e348-44db-97ec-cd46e4e46d53"), SkillId = 25 },  // Marketing en Redes Sociales

                new OfferSkill { OfferSkillId = 952, OfferId = Guid.Parse("82b546bb-5fc3-40e0-b21e-1a9f01d79a92"), SkillId = 61 }, // Gestión de documentos
                new OfferSkill { OfferSkillId = 953, OfferId = Guid.Parse("82b546bb-5fc3-40e0-b21e-1a9f01d79a92"), SkillId = 62 }, // Coordinación de agendas
                new OfferSkill { OfferSkillId = 954, OfferId = Guid.Parse("82b546bb-5fc3-40e0-b21e-1a9f01d79a92"), SkillId = 63 }, // Archivo y registro
                new OfferSkill { OfferSkillId = 955, OfferId = Guid.Parse("82b546bb-5fc3-40e0-b21e-1a9f01d79a92"), SkillId = 64 }, // Atención telefónica
                new OfferSkill { OfferSkillId = 956, OfferId = Guid.Parse("82b546bb-5fc3-40e0-b21e-1a9f01d79a92"), SkillId = 65 }, // Gestión de correos electrónicos
                new OfferSkill { OfferSkillId = 957, OfferId = Guid.Parse("82b546bb-5fc3-40e0-b21e-1a9f01d79a92"), SkillId = 66 }, // Facturación y cobranza
                new OfferSkill { OfferSkillId = 958, OfferId = Guid.Parse("82b546bb-5fc3-40e0-b21e-1a9f01d79a92"), SkillId = 67 }, // Control de gastos
                new OfferSkill { OfferSkillId = 959, OfferId = Guid.Parse("82b546bb-5fc3-40e0-b21e-1a9f01d79a92"), SkillId = 68 }, // Manejo de bases de datos
                new OfferSkill { OfferSkillId = 960, OfferId = Guid.Parse("82b546bb-5fc3-40e0-b21e-1a9f01d79a92"), SkillId = 69 }, // Elaboración de informes
                new OfferSkill { OfferSkillId = 961, OfferId = Guid.Parse("82b546bb-5fc3-40e0-b21e-1a9f01d79a92"), SkillId = 70 },  // Organización de eventos

                new OfferSkill { OfferSkillId = 962, OfferId = Guid.Parse("cb6fe4d5-c44d-4f54-8826-d6b7b4528ef0"), SkillId = 3 }, // JavaScript
                new OfferSkill { OfferSkillId = 963, OfferId = Guid.Parse("cb6fe4d5-c44d-4f54-8826-d6b7b4528ef0"), SkillId = 1 }, // C#
                new OfferSkill { OfferSkillId = 964, OfferId = Guid.Parse("cb6fe4d5-c44d-4f54-8826-d6b7b4528ef0"), SkillId = 25 }, // Marketing en Redes Sociales
                new OfferSkill { OfferSkillId = 965, OfferId = Guid.Parse("cb6fe4d5-c44d-4f54-8826-d6b7b4528ef0"), SkillId = 17 }, // Gestión del talento
                new OfferSkill { OfferSkillId = 966, OfferId = Guid.Parse("cb6fe4d5-c44d-4f54-8826-d6b7b4528ef0"), SkillId = 18 }, // Selección de personal
                new OfferSkill { OfferSkillId = 967, OfferId = Guid.Parse("cb6fe4d5-c44d-4f54-8826-d6b7b4528ef0"), SkillId = 19 }, // Capacitación y desarrollo
                new OfferSkill { OfferSkillId = 968, OfferId = Guid.Parse("cb6fe4d5-c44d-4f54-8826-d6b7b4528ef0"), SkillId = 13 }, // Manejo de objeciones
                new OfferSkill { OfferSkillId = 969, OfferId = Guid.Parse("cb6fe4d5-c44d-4f54-8826-d6b7b4528ef0"), SkillId = 15 }, // Presentaciones de ventas
                new OfferSkill { OfferSkillId = 970, OfferId = Guid.Parse("cb6fe4d5-c44d-4f54-8826-d6b7b4528ef0"), SkillId = 66 }, // Facturación y cobranza
                new OfferSkill { OfferSkillId = 971, OfferId = Guid.Parse("cb6fe4d5-c44d-4f54-8826-d6b7b4528ef0"), SkillId = 62 }  // Coordinación de agendas


                );
        }
    }
}
