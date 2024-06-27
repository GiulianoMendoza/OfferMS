using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data
{
    public class OfferCategoryData
    {
        public static void SeedData(EntityTypeBuilder<OfferCategory> builder)
        {
            builder.HasData(
                new OfferCategory { OfferCategoryId = 1, OfferId = Guid.Parse("d4b57950-3920-4a06-a7f6-76bfb5e1d501"), CategoryId = 1 }, // Diseño y Desarrollo
                new OfferCategory { OfferCategoryId = 2, OfferId = Guid.Parse("d4b57950-3920-4a06-a7f6-76bfb5e1d501"), CategoryId = 5 }, // Tecnología, Sistemas y Telecomunicaciones
                new OfferCategory { OfferCategoryId = 3, OfferId = Guid.Parse("d4b57950-3920-4a06-a7f6-76bfb5e1d501"), CategoryId = 2 }, // Comercial, Ventas y Negocios
                new OfferCategory { OfferCategoryId = 4, OfferId = Guid.Parse("d4b57950-3920-4a06-a7f6-76bfb5e1d501"), CategoryId = 18 }, // Gerencia y Dirección General

                new OfferCategory { OfferCategoryId = 5, OfferId = Guid.Parse("e4e8d3ec-9df2-46dc-a465-dc17a7815d56"), CategoryId = 1 }, // Diseño y Desarrollo
                new OfferCategory { OfferCategoryId = 6, OfferId = Guid.Parse("e4e8d3ec-9df2-46dc-a465-dc17a7815d56"), CategoryId = 5 }, // Tecnología, Sistemas y Telecomunicaciones
                new OfferCategory { OfferCategoryId = 7, OfferId = Guid.Parse("e4e8d3ec-9df2-46dc-a465-dc17a7815d56"), CategoryId = 2 }, // Comercial, Ventas y Negocios
                new OfferCategory { OfferCategoryId = 8, OfferId = Guid.Parse("e4e8d3ec-9df2-46dc-a465-dc17a7815d56"), CategoryId = 18 }, // Gerencia y Dirección General

                new OfferCategory { OfferCategoryId = 9, OfferId = Guid.Parse("c2d4bb58-aa15-4659-8f42-e4e6326b6cf2"), CategoryId = 1 }, // Diseño y Desarrollo
                new OfferCategory { OfferCategoryId = 10, OfferId = Guid.Parse("c2d4bb58-aa15-4659-8f42-e4e6326b6cf2"), CategoryId = 5 }, // Tecnología, Sistemas y Telecomunicaciones
                new OfferCategory { OfferCategoryId = 11, OfferId = Guid.Parse("c2d4bb58-aa15-4659-8f42-e4e6326b6cf2"), CategoryId = 2 }, // Comercial, Ventas y Negocios
                new OfferCategory { OfferCategoryId = 12, OfferId = Guid.Parse("c2d4bb58-aa15-4659-8f42-e4e6326b6cf2"), CategoryId = 18 }, // Gerencia y Dirección General

                new OfferCategory { OfferCategoryId = 13, OfferId = Guid.Parse("3b481a4c-0c63-4ff8-b1e4-0c726d300e0c"), CategoryId = 5 }, // Tecnología, Sistemas y Telecomunicaciones
                new OfferCategory { OfferCategoryId = 14, OfferId = Guid.Parse("3b481a4c-0c63-4ff8-b1e4-0c726d300e0c"), CategoryId = 2 }, // Comercial, Ventas y Negocios
                new OfferCategory { OfferCategoryId = 15, OfferId = Guid.Parse("3b481a4c-0c63-4ff8-b1e4-0c726d300e0c"), CategoryId = 3 }, // Administración, Contabilidad y Finanzas
                new OfferCategory { OfferCategoryId = 16, OfferId = Guid.Parse("3b481a4c-0c63-4ff8-b1e4-0c726d300e0c"), CategoryId = 18 }, // Gerencia y Dirección General

                new OfferCategory { OfferCategoryId = 17, OfferId = Guid.Parse("fd98a956-2a04-4a29-89a6-fce06f13803f"), CategoryId = 3 }, // Administración, Contabilidad y Finanzas
                new OfferCategory { OfferCategoryId = 18, OfferId = Guid.Parse("fd98a956-2a04-4a29-89a6-fce06f13803f"), CategoryId = 9 }, // Abastecimiento y Logística
                new OfferCategory { OfferCategoryId = 19, OfferId = Guid.Parse("fd98a956-2a04-4a29-89a6-fce06f13803f"), CategoryId = 14 }, // Legales

                new OfferCategory { OfferCategoryId = 20, OfferId = Guid.Parse("90cc7e80-982b-4f36-8986-529bd7c11a1f"), CategoryId = 5 }, // Tecnología, Sistemas y Telecomunicaciones
                new OfferCategory { OfferCategoryId = 21, OfferId = Guid.Parse("90cc7e80-982b-4f36-8986-529bd7c11a1f"), CategoryId = 9 }, // Abastecimiento y Logística
                new OfferCategory { OfferCategoryId = 22, OfferId = Guid.Parse("90cc7e80-982b-4f36-8986-529bd7c11a1f"), CategoryId = 16 }, // Ingeniería Civil y Construcción
                new OfferCategory { OfferCategoryId = 23, OfferId = Guid.Parse("90cc7e80-982b-4f36-8986-529bd7c11a1f"), CategoryId = 13 }, // Producción y Manufactura

                new OfferCategory { OfferCategoryId = 24, OfferId = Guid.Parse("90cc7e80-982b-4f36-8986-529bd7c11a1f"), CategoryId = 4 }, // Ingenierías
                new OfferCategory { OfferCategoryId = 25, OfferId = Guid.Parse("90cc7e80-982b-4f36-8986-529bd7c11a1f"), CategoryId = 5 }, // Tecnología de la Información

                new OfferCategory { OfferCategoryId = 26, OfferId = Guid.Parse("f91f3aa0-66a8-4f4b-81e6-87d01e681d8d"), CategoryId = 1 }, // Diseño y Desarrollo
                new OfferCategory { OfferCategoryId = 27, OfferId = Guid.Parse("f91f3aa0-66a8-4f4b-81e6-87d01e681d8d"), CategoryId = 5 }, // Tecnología, Sistemas y Telecomunicaciones

                new OfferCategory { OfferCategoryId = 28, OfferId = Guid.Parse("1539bb63-c5f2-4a8d-8843-7988d20669ec"), CategoryId = 9 }, // Abastecimiento y Logística
                new OfferCategory { OfferCategoryId = 29, OfferId = Guid.Parse("1539bb63-c5f2-4a8d-8843-7988d20669ec"), CategoryId = 17 }, // Seguros
                new OfferCategory { OfferCategoryId = 30, OfferId = Guid.Parse("1539bb63-c5f2-4a8d-8843-7988d20669ec"), CategoryId = 13 }, // Producción y Manufactura

                new OfferCategory { OfferCategoryId = 31, OfferId = Guid.Parse("8a1a3ef3-358d-4cc2-8633-dbd57ac52006"), CategoryId = 1 }, // Diseño y Desarrollo
                new OfferCategory { OfferCategoryId = 32, OfferId = Guid.Parse("8a1a3ef3-358d-4cc2-8633-dbd57ac52006"), CategoryId = 5 }, // Tecnología, Sistemas y Telecomunicaciones
                new OfferCategory { OfferCategoryId = 33, OfferId = Guid.Parse("8a1a3ef3-358d-4cc2-8633-dbd57ac52006"), CategoryId = 2 }, // Comercial, Ventas y Negocios
                new OfferCategory { OfferCategoryId = 34, OfferId = Guid.Parse("8a1a3ef3-358d-4cc2-8633-dbd57ac52006"), CategoryId = 18 }, // Gerencia y Dirección General

                new OfferCategory { OfferCategoryId = 35, OfferId = Guid.Parse("e5acde91-155a-4b5e-a0a1-f081298b1832"), CategoryId = 14 }, // Legales
                new OfferCategory { OfferCategoryId = 36, OfferId = Guid.Parse("e5acde91-155a-4b5e-a0a1-f081298b1832"), CategoryId = 11 }, // Recursos Humanos y Capacitación
                new OfferCategory { OfferCategoryId = 37, OfferId = Guid.Parse("e5acde91-155a-4b5e-a0a1-f081298b1832"), CategoryId = 18 }, // Gerencia y Dirección General
                new OfferCategory { OfferCategoryId = 38, OfferId = Guid.Parse("e5acde91-155a-4b5e-a0a1-f081298b1832"), CategoryId = 17 }, // Seguros

                new OfferCategory { OfferCategoryId = 39, OfferId = Guid.Parse("5e7f9ee4-0e9e-4bc2-b64d-5ef6e2ad207e"), CategoryId = 12 }, // Salud, Medicina y Farmacia
                new OfferCategory { OfferCategoryId = 40, OfferId = Guid.Parse("5e7f9ee4-0e9e-4bc2-b64d-5ef6e2ad207e"), CategoryId = 13 }, // Producción y Manufactura
                new OfferCategory { OfferCategoryId = 41, OfferId = Guid.Parse("5e7f9ee4-0e9e-4bc2-b64d-5ef6e2ad207e"), CategoryId = 16 }, // Ingeniería Civil y Construcción

                new OfferCategory { OfferCategoryId = 42, OfferId = Guid.Parse("a8b52b4f-025d-4d48-82c1-990fbbdbb369"), CategoryId = 13 }, // Producción y Manufactura
                new OfferCategory { OfferCategoryId = 43, OfferId = Guid.Parse("a8b52b4f-025d-4d48-82c1-990fbbdbb369"), CategoryId = 22 }, // Departamento Técnico

                new OfferCategory { OfferCategoryId = 44, OfferId = Guid.Parse("1b1d2d29-62c2-4ae3-bbfc-6a17514fc77d"), CategoryId = 17 }, // Seguros
                new OfferCategory { OfferCategoryId = 45, OfferId = Guid.Parse("1b1d2d29-62c2-4ae3-bbfc-6a17514fc77d"), CategoryId = 12 }, // Salud, Medicina y Farmacia
                new OfferCategory { OfferCategoryId = 46, OfferId = Guid.Parse("1b1d2d29-62c2-4ae3-bbfc-6a17514fc77d"), CategoryId = 18 }, // Gerencia y Dirección General

                new OfferCategory { OfferCategoryId = 47, OfferId = Guid.Parse("c2b9a7cb-8b3d-496f-80df-93f1928ef9d0"), CategoryId = 10 }, // Ingeniería y Producción
                new OfferCategory { OfferCategoryId = 48, OfferId = Guid.Parse("c2b9a7cb-8b3d-496f-80df-93f1928ef9d0"), CategoryId = 18 }, // Gerencia y Dirección General

                new OfferCategory { OfferCategoryId = 49, OfferId = Guid.Parse("1e40e017-20b7-4b5c-af8f-9b4f62e80a5d"), CategoryId = 6 }, // Compras
                new OfferCategory { OfferCategoryId = 50, OfferId = Guid.Parse("1e40e017-20b7-4b5c-af8f-9b4f62e80a5d"), CategoryId = 18 }, // Gerencia y Dirección General

                new OfferCategory { OfferCategoryId = 51, OfferId = Guid.Parse("34ec9f13-279d-4453-98a8-1a0831e9e90d"), CategoryId = 6 }, // Secretarias y Recepción
                new OfferCategory { OfferCategoryId = 52, OfferId = Guid.Parse("34ec9f13-279d-4453-98a8-1a0831e9e90d"), CategoryId = 9 }, // Abastecimiento y Logística

                new OfferCategory { OfferCategoryId = 53, OfferId = Guid.Parse("c2d5c7d4-97df-4c9d-b292-515a0dbd25a5"), CategoryId = 4 }, // Gerencia y Dirección
                new OfferCategory { OfferCategoryId = 54, OfferId = Guid.Parse("c2d5c7d4-97df-4c9d-b292-515a0dbd25a5"), CategoryId = 6 }, // Secretarias y Recepción
                new OfferCategory { OfferCategoryId = 55, OfferId = Guid.Parse("c2d5c7d4-97df-4c9d-b292-515a0dbd25a5"), CategoryId = 11 }, // Ventas

                new OfferCategory { OfferCategoryId = 56, OfferId = Guid.Parse("b7f364c3-b50c-4ea0-bb24-6f6ddbf64d69"), CategoryId = 4 }, // Gerencia y Dirección
                new OfferCategory { OfferCategoryId = 57, OfferId = Guid.Parse("b7f364c3-b50c-4ea0-bb24-6f6ddbf64d69"), CategoryId = 15 }, // Logística y Distribución

                new OfferCategory { OfferCategoryId = 58, OfferId = Guid.Parse("cba5b59e-76f1-495a-9a6b-3a6d9b55f119"), CategoryId = 6 }, // Ingeniería y Tecnología
                new OfferCategory { OfferCategoryId = 59, OfferId = Guid.Parse("cba5b59e-76f1-495a-9a6b-3a6d9b55f119"), CategoryId = 17 }, // Informática y Sistemas

                new OfferCategory { OfferCategoryId = 60, OfferId = Guid.Parse("ef768f5e-bfb2-4b5a-8595-2875a45cb23f"), CategoryId = 6 }, // Ingeniería y Tecnología
                new OfferCategory { OfferCategoryId = 61, OfferId = Guid.Parse("ef768f5e-bfb2-4b5a-8595-2875a45cb23f"), CategoryId = 17 }, // Informática y Sistemas

                new OfferCategory { OfferCategoryId = 62, OfferId = Guid.Parse("3b15b056-2b44-4225-80ad-446252fd6864"), CategoryId = 6 }, // Ingeniería y Tecnología
                new OfferCategory { OfferCategoryId = 63, OfferId = Guid.Parse("3b15b056-2b44-4225-80ad-446252fd6864"), CategoryId = 17 }, // Informática y Sistemas

                new OfferCategory { OfferCategoryId = 64, OfferId = Guid.Parse("cf064e11-ebbb-4a2c-bbff-ef3e15bb68db"), CategoryId = 2 }, // Atención al Cliente
                new OfferCategory { OfferCategoryId = 65, OfferId = Guid.Parse("cf064e11-ebbb-4a2c-bbff-ef3e15bb68db"), CategoryId = 11 }, // Ventas
                new OfferCategory { OfferCategoryId = 66, OfferId = Guid.Parse("cf064e11-ebbb-4a2c-bbff-ef3e15bb68db"), CategoryId = 13 }, // Finanzas

                new OfferCategory { OfferCategoryId = 67, OfferId = Guid.Parse("73d35e46-f05d-49c0-8561-cda6f917d556"), CategoryId = 5 }, // Tecnología e Ingeniería
                new OfferCategory { OfferCategoryId = 68, OfferId = Guid.Parse("73d35e46-f05d-49c0-8561-cda6f917d556"), CategoryId = 7 }, // Desarrollo de Software
                new OfferCategory { OfferCategoryId = 69, OfferId = Guid.Parse("73d35e46-f05d-49c0-8561-cda6f917d556"), CategoryId = 8 }, // Diseño y UX/UI

                new OfferCategory { OfferCategoryId = 70, OfferId = Guid.Parse("aece4b9c-1e0f-4385-bf2e-8ff209c8d684"), CategoryId = 10 }, // Ingeniería y Tecnología
                new OfferCategory { OfferCategoryId = 71, OfferId = Guid.Parse("aece4b9c-1e0f-4385-bf2e-8ff209c8d684"), CategoryId = 7 }, // Desarrollo de Software

                new OfferCategory { OfferCategoryId = 72, OfferId = Guid.Parse("4c2e4700-6491-42c4-9da2-1c094bb09d1c"), CategoryId = 3 }, // Administración, Contabilidad y Finanzas
                new OfferCategory { OfferCategoryId = 73, OfferId = Guid.Parse("4c2e4700-6491-42c4-9da2-1c094bb09d1c"), CategoryId = 5 }, // Tecnología, Sistemas y Telecomunicaciones
                new OfferCategory { OfferCategoryId = 74, OfferId = Guid.Parse("4c2e4700-6491-42c4-9da2-1c094bb09d1c"), CategoryId = 18 }, // Gerencia y Dirección General

                new OfferCategory { OfferCategoryId = 75, OfferId = Guid.Parse("4500dcbc-8d33-4814-9c95-4da24e53ff54"), CategoryId = 2 }, // Comercial, Ventas y Negocios
                new OfferCategory { OfferCategoryId = 76, OfferId = Guid.Parse("4500dcbc-8d33-4814-9c95-4da24e53ff54"), CategoryId = 10 }, // Atención al Cliente, Call Center y Telemarketing
                new OfferCategory { OfferCategoryId = 77, OfferId = Guid.Parse("4500dcbc-8d33-4814-9c95-4da24e53ff54"), CategoryId = 18 }, // Gerencia y Dirección General

                new OfferCategory { OfferCategoryId = 78, OfferId = Guid.Parse("6aa3a38a-dba0-4d26-8355-5c167f1501c6"), CategoryId = 2 }, // Comercial, Ventas y Negocios
                new OfferCategory { OfferCategoryId = 79, OfferId = Guid.Parse("6aa3a38a-dba0-4d26-8355-5c167f1501c6"), CategoryId = 10 }, // Atención al Cliente, Call Center y Telemarketing
                new OfferCategory { OfferCategoryId = 80, OfferId = Guid.Parse("6aa3a38a-dba0-4d26-8355-5c167f1501c6"), CategoryId = 18 }, // Gerencia y Dirección General

                new OfferCategory { OfferCategoryId = 81, OfferId = Guid.Parse("4e5e9b73-2141-48f6-a306-bb660dd6f451"), CategoryId = 2 }, // Comercial, Ventas y Negocios
                new OfferCategory { OfferCategoryId = 82, OfferId = Guid.Parse("4e5e9b73-2141-48f6-a306-bb660dd6f451"), CategoryId = 10 }, // Atención al Cliente, Call Center y Telemarketing

                new OfferCategory { OfferCategoryId = 83, OfferId = Guid.Parse("dfc5b3ac-af4e-42b4-bf9c-2a683a46059f"), CategoryId = 1 }, // Diseño y Desarrollo
                new OfferCategory { OfferCategoryId = 84, OfferId = Guid.Parse("dfc5b3ac-af4e-42b4-bf9c-2a683a46059f"), CategoryId = 6 }, // Secretarias y Recepción
                new OfferCategory { OfferCategoryId = 85, OfferId = Guid.Parse("dfc5b3ac-af4e-42b4-bf9c-2a683a46059f"), CategoryId = 10 }, // Atención al Cliente, Call Center y Telemarketing
                new OfferCategory { OfferCategoryId = 86, OfferId = Guid.Parse("dfc5b3ac-af4e-42b4-bf9c-2a683a46059f"), CategoryId = 21 }, // Educación, Docencia e Investigación

                new OfferCategory { OfferCategoryId = 87, OfferId = Guid.Parse("4c273bfd-06fd-4e2d-a5c1-d41e26a4ad13"), CategoryId = 4 }, // Ingenierías
                new OfferCategory { OfferCategoryId = 88, OfferId = Guid.Parse("4c273bfd-06fd-4e2d-a5c1-d41e26a4ad13"), CategoryId = 13 }, // Producción y Manufactura
                new OfferCategory { OfferCategoryId = 89, OfferId = Guid.Parse("4c273bfd-06fd-4e2d-a5c1-d41e26a4ad13"), CategoryId = 16 }, // Ingeniería Civil y Construcción

                new OfferCategory { OfferCategoryId = 90, OfferId = Guid.Parse("4c273bfd-06fd-4e2d-a5c1-d41e26a9ad13"), CategoryId = 1 }, // Diseño y Desarrollo
                new OfferCategory { OfferCategoryId = 91, OfferId = Guid.Parse("4c273bfd-06fd-4e2d-a5c1-d41e26a9ad13"), CategoryId = 4 }, // Ingenierías
                new OfferCategory { OfferCategoryId = 92, OfferId = Guid.Parse("4c273bfd-06fd-4e2d-a5c1-d41e26a9ad13"), CategoryId = 13 }, // Producción y Manufactura
                new OfferCategory { OfferCategoryId = 93, OfferId = Guid.Parse("4c273bfd-06fd-4e2d-a5c1-d41e26a9ad13"), CategoryId = 22 }, // Departamento Técnico

                new OfferCategory { OfferCategoryId = 94, OfferId = Guid.Parse("2a727bb0-902d-4f96-b57b-2a6e39d8a60e"), CategoryId = 12 }, // Salud, Medicina y Farmacia
                new OfferCategory { OfferCategoryId = 95, OfferId = Guid.Parse("2a727bb0-902d-4f96-b57b-2a6e39d8a60e"), CategoryId = 13 }, // Producción y Manufactura
                new OfferCategory { OfferCategoryId = 96, OfferId = Guid.Parse("2a727bb0-902d-4f96-b57b-2a6e39d8a60e"), CategoryId = 9 }, // Abastecimiento y Logística

                new OfferCategory { OfferCategoryId = 97, OfferId = Guid.Parse("f4e7a8c0-0253-4baf-bd54-9a119ed81e5f"), CategoryId = 13 }, // Producción y Manufactura
                new OfferCategory { OfferCategoryId = 98, OfferId = Guid.Parse("f4e7a8c0-0253-4baf-bd54-9a119ed81e5f"), CategoryId = 9 }, // Abastecimiento y Logística
                new OfferCategory { OfferCategoryId = 99, OfferId = Guid.Parse("f4e7a8c0-0253-4baf-bd54-9a119ed81e5f"), CategoryId = 25 }, // Naviero, Marítimo, Portuario

                new OfferCategory { OfferCategoryId = 100, OfferId = Guid.Parse("c45c63c4-bc31-4397-a38a-84241e441028"), CategoryId = 1 }, // Diseño y Desarrollo
                new OfferCategory { OfferCategoryId = 101, OfferId = Guid.Parse("c45c63c4-bc31-4397-a38a-84241e441028"), CategoryId = 5 }, // Tecnología, Sistemas y Telecomunicaciones
                new OfferCategory { OfferCategoryId = 102, OfferId = Guid.Parse("c45c63c4-bc31-4397-a38a-84241e441028"), CategoryId = 4 }, // Ingenierías

                new OfferCategory { OfferCategoryId = 103, OfferId = Guid.Parse("bbd240b5-09f1-497f-a74f-24831e84dfe2"), CategoryId = 4 }, // Ingenierías
                new OfferCategory { OfferCategoryId = 104, OfferId = Guid.Parse("bbd240b5-09f1-497f-a74f-24831e84dfe2"), CategoryId = 5 }, // Tecnología, Sistemas y Telecomunicaciones
                new OfferCategory { OfferCategoryId = 105, OfferId = Guid.Parse("bbd240b5-09f1-497f-a74f-24831e84dfe2"), CategoryId = 4 }, // Ingenierías

                new OfferCategory { OfferCategoryId = 106, OfferId = Guid.Parse("e7d81f16-93f1-462e-87c4-3a7b80db23d4"), CategoryId = 14 }, // Legales
                new OfferCategory { OfferCategoryId = 107, OfferId = Guid.Parse("e7d81f16-93f1-462e-87c4-3a7b80db23d4"), CategoryId = 3 }, // Administración, Contabilidad y Finanzas
                new OfferCategory { OfferCategoryId = 108, OfferId = Guid.Parse("e7d81f16-93f1-462e-87c4-3a7b80db23d4"), CategoryId = 2 }, // Comercial, Ventas y Negocios
                new OfferCategory { OfferCategoryId = 109, OfferId = Guid.Parse("e7d81f16-93f1-462e-87c4-3a7b80db23d4"), CategoryId = 17 }, // Seguros

                new OfferCategory { OfferCategoryId = 110, OfferId = Guid.Parse("a8f1d525-85cf-47c5-80dc-1a6db6b687b0"), CategoryId = 1 }, // Diseño y Desarrollo
                new OfferCategory { OfferCategoryId = 111, OfferId = Guid.Parse("a8f1d525-85cf-47c5-80dc-1a6db6b687b0"), CategoryId = 5 }, // Tecnología, Sistemas y Telecomunicaciones
                new OfferCategory { OfferCategoryId = 112, OfferId = Guid.Parse("a8f1d525-85cf-47c5-80dc-1a6db6b687b0"), CategoryId = 22 }, // Departamento Técnico

                new OfferCategory { OfferCategoryId = 113, OfferId = Guid.Parse("43172e18-c20b-41d1-b16d-5e15b7e788d7"), CategoryId = 2 }, // Comercial, Ventas y Negocios
                new OfferCategory { OfferCategoryId = 114, OfferId = Guid.Parse("43172e18-c20b-41d1-b16d-5e15b7e788d7"), CategoryId = 11 }, // Recursos Humanos y Capacitación
                new OfferCategory { OfferCategoryId = 115, OfferId = Guid.Parse("43172e18-c20b-41d1-b16d-5e15b7e788d7"), CategoryId = 18 }, // Gerencia y Dirección General

                new OfferCategory { OfferCategoryId = 116, OfferId = Guid.Parse("1f8dbf01-6d33-4d6c-9d02-22686b739cf4"), CategoryId = 4 }, // Ingenierías
                new OfferCategory { OfferCategoryId = 117, OfferId = Guid.Parse("1f8dbf01-6d33-4d6c-9d02-22686b739cf4"), CategoryId = 5 }, // Tecnología, Sistemas y Telecomunicaciones
                new OfferCategory { OfferCategoryId = 118, OfferId = Guid.Parse("1f8dbf01-6d33-4d6c-9d02-22686b739cf4"), CategoryId = 26 }, // Marketing y Publicidad

                new OfferCategory { OfferCategoryId = 119, OfferId = Guid.Parse("99c4892f-d048-459e-ae27-7dd3fd0b0839"), CategoryId = 9 }, // Abastecimiento y Logística
                new OfferCategory { OfferCategoryId = 120, OfferId = Guid.Parse("99c4892f-d048-459e-ae27-7dd3fd0b0839"), CategoryId = 18 }, // Gerencia y Dirección General
                new OfferCategory { OfferCategoryId = 121, OfferId = Guid.Parse("99c4892f-d048-459e-ae27-7dd3fd0b0839"), CategoryId = 13 }, // Producción y Manufactura

                new OfferCategory { OfferCategoryId = 122, OfferId = Guid.Parse("c64b0cc7-bd3d-4db3-91c1-4cc6f8dbb3d2"), CategoryId = 2 }, // Comercial, Ventas y Negocios
                new OfferCategory { OfferCategoryId = 123, OfferId = Guid.Parse("c64b0cc7-bd3d-4db3-91c1-4cc6f8dbb3d2"), CategoryId = 18 }, // Gerencia y Dirección General
                new OfferCategory { OfferCategoryId = 124, OfferId = Guid.Parse("c64b0cc7-bd3d-4db3-91c1-4cc6f8dbb3d2"), CategoryId = 20 }, // Comunicación y Relaciones Públicas

                new OfferCategory { OfferCategoryId = 125, OfferId = Guid.Parse("2cf0284d-143f-4375-8a07-4d5e2c38a54e"), CategoryId = 2 }, // Comercial, Ventas y Negocios
                new OfferCategory { OfferCategoryId = 126, OfferId = Guid.Parse("2cf0284d-143f-4375-8a07-4d5e2c38a54e"), CategoryId = 18 }, // Gerencia y Dirección General
                new OfferCategory { OfferCategoryId = 127, OfferId = Guid.Parse("2cf0284d-143f-4375-8a07-4d5e2c38a54e"), CategoryId = 20 }, // Comunicación y Relaciones Públicas

                new OfferCategory { OfferCategoryId = 128, OfferId = Guid.Parse("3a4c5c3d-8b42-4600-9a6a-6e34f1d98d4a"), CategoryId = 3 }, // Administración, Contabilidad y Finanzas
                new OfferCategory { OfferCategoryId = 129, OfferId = Guid.Parse("3a4c5c3d-8b42-4600-9a6a-6e34f1d98d4a"), CategoryId = 18 }, // Gerencia y Dirección General

                new OfferCategory { OfferCategoryId = 130, OfferId = Guid.Parse("c7cfc748-3e39-42c8-8dd9-dc326d9a0362"), CategoryId = 3 }, // Administración, Contabilidad y Finanzas
                new OfferCategory { OfferCategoryId = 131, OfferId = Guid.Parse("c7cfc748-3e39-42c8-8dd9-dc326d9a0362"), CategoryId = 17 }, // Seguros
                new OfferCategory { OfferCategoryId = 132, OfferId = Guid.Parse("c7cfc748-3e39-42c8-8dd9-dc326d9a0362"), CategoryId = 18 }, // Gerencia y Dirección General

                new OfferCategory { OfferCategoryId = 133, OfferId = Guid.Parse("9a2e26ab-9a47-4b71-907b-9a6c4e9db9d5"), CategoryId = 2 }, // Comercial, Ventas y Negocios
                new OfferCategory { OfferCategoryId = 134, OfferId = Guid.Parse("9a2e26ab-9a47-4b71-907b-9a6c4e9db9d5"), CategoryId = 26 }, // Marketing y Publicidad

                new OfferCategory { OfferCategoryId = 135, OfferId = Guid.Parse("cbf7c2f6-fb22-4a5e-ae56-60798fcdaf35"), CategoryId = 3 }, // Administración, Contabilidad y Finanzas
                new OfferCategory { OfferCategoryId = 136, OfferId = Guid.Parse("cbf7c2f6-fb22-4a5e-ae56-60798fcdaf35"), CategoryId = 17 }, // Seguros
                new OfferCategory { OfferCategoryId = 137, OfferId = Guid.Parse("cbf7c2f6-fb22-4a5e-ae56-60798fcdaf35"), CategoryId = 18 }, // Gerencia y Dirección General

                new OfferCategory { OfferCategoryId = 138, OfferId = Guid.Parse("cfb54849-13f6-4db0-aa4b-810c502b5de5"), CategoryId = 3 }, // Administración, Contabilidad y Finanzas
                new OfferCategory { OfferCategoryId = 139, OfferId = Guid.Parse("cfb54849-13f6-4db0-aa4b-810c502b5de5"), CategoryId = 2 }, // Comercial, Ventas y Negocios
                new OfferCategory { OfferCategoryId = 140, OfferId = Guid.Parse("cfb54849-13f6-4db0-aa4b-810c502b5de5"), CategoryId = 9 }, // Abastecimiento y Logística

                new OfferCategory { OfferCategoryId = 141, OfferId = Guid.Parse("3bd4a3b0-d922-41f4-b32e-683372920c77"), CategoryId = 1 }, // Diseño y Desarrollo
                new OfferCategory { OfferCategoryId = 142, OfferId = Guid.Parse("3bd4a3b0-d922-41f4-b32e-683372920c77"), CategoryId = 5 }, // Tecnología, Sistemas y Telecomunicaciones
                new OfferCategory { OfferCategoryId = 143, OfferId = Guid.Parse("3bd4a3b0-d922-41f4-b32e-683372920c77"), CategoryId = 26 }, // Marketing y Publicidad

                new OfferCategory { OfferCategoryId = 144, OfferId = Guid.Parse("d394e91d-6950-4485-b2d2-0c1e8f2ad588"), CategoryId = 9 }, // Abastecimiento y Logística
                new OfferCategory { OfferCategoryId = 145, OfferId = Guid.Parse("d394e91d-6950-4485-b2d2-0c1e8f2ad588"), CategoryId = 18 }, // Gerencia y Dirección General

                new OfferCategory { OfferCategoryId = 146, OfferId = Guid.Parse("33f8289d-b24f-45d6-b537-0a61b3cb4bbd"), CategoryId = 3 }, // Administración, Contabilidad y Finanzas
                new OfferCategory { OfferCategoryId = 147, OfferId = Guid.Parse("33f8289d-b24f-45d6-b537-0a61b3cb4bbd"), CategoryId = 17 }, // Seguros
                new OfferCategory { OfferCategoryId = 148, OfferId = Guid.Parse("33f8289d-b24f-45d6-b537-0a61b3cb4bbd"), CategoryId = 18 }, // Gerencia y Dirección General

                new OfferCategory { OfferCategoryId = 149, OfferId = Guid.Parse("ff46f91a-6509-462b-8ff3-92c89c17c738"), CategoryId = 5 }, // Tecnología, Sistemas y Telecomunicaciones
                new OfferCategory { OfferCategoryId = 150, OfferId = Guid.Parse("ff46f91a-6509-462b-8ff3-92c89c17c738"), CategoryId = 20 }, // Comunicación y Relaciones Públicas
                new OfferCategory { OfferCategoryId = 151, OfferId = Guid.Parse("ff46f91a-6509-462b-8ff3-92c89c17c738"), CategoryId = 18 }, // Gerencia y Dirección General

                new OfferCategory { OfferCategoryId = 152, OfferId = Guid.Parse("6ee3d748-65bc-4fe4-8314-2033f1c002d1"), CategoryId = 5 }, // Tecnología, Sistemas y Telecomunicaciones
                new OfferCategory { OfferCategoryId = 153, OfferId = Guid.Parse("6ee3d748-65bc-4fe4-8314-2033f1c002d1"), CategoryId = 22 }, // Departamento Técnico
                new OfferCategory { OfferCategoryId = 154, OfferId = Guid.Parse("6ee3d748-65bc-4fe4-8314-2033f1c002d1"), CategoryId = 18 }, // Gerencia y Dirección General

                new OfferCategory { OfferCategoryId = 155, OfferId = Guid.Parse("c1a438b6-8c42-4bc4-b11a-7999cb0f4f6e"), CategoryId = 17 }, // Seguros
                new OfferCategory { OfferCategoryId = 156, OfferId = Guid.Parse("c1a438b6-8c42-4bc4-b11a-7999cb0f4f6e"), CategoryId = 18 }, // Gerencia y Dirección General
                new OfferCategory { OfferCategoryId = 157, OfferId = Guid.Parse("c1a438b6-8c42-4bc4-b11a-7999cb0f4f6e"), CategoryId = 13 }, // Producción y Manufactura

                new OfferCategory { OfferCategoryId = 158, OfferId = Guid.Parse("79f0f169-f7e1-48b6-aeb8-7584f47ac0aa"), CategoryId = 13 }, // Producción y Manufactura
                new OfferCategory { OfferCategoryId = 159, OfferId = Guid.Parse("79f0f169-f7e1-48b6-aeb8-7584f47ac0aa"), CategoryId = 9 },  // Abastecimiento y Logística
                new OfferCategory { OfferCategoryId = 160, OfferId = Guid.Parse("79f0f169-f7e1-48b6-aeb8-7584f47ac0aa"), CategoryId = 16 }, // Ingeniería Civil y Construcción

                new OfferCategory { OfferCategoryId = 161, OfferId = Guid.Parse("6cbe28f0-4b85-457f-8a7e-24e2816a607b"), CategoryId = 2 }, // Comercial, Ventas y Negocios
                new OfferCategory { OfferCategoryId = 162, OfferId = Guid.Parse("6cbe28f0-4b85-457f-8a7e-24e2816a607b"), CategoryId = 26 }, // Marketing y Publicidad
                new OfferCategory { OfferCategoryId = 163, OfferId = Guid.Parse("6cbe28f0-4b85-457f-8a7e-24e2816a607b"), CategoryId = 20 }, // Comunicación y Relaciones Públicas

                new OfferCategory { OfferCategoryId = 164, OfferId = Guid.Parse("b18a1bb5-6b8a-4d90-985f-02c4792f18da"), CategoryId = 1 }, // Diseño y Desarrollo
                new OfferCategory { OfferCategoryId = 165, OfferId = Guid.Parse("b18a1bb5-6b8a-4d90-985f-02c4792f18da"), CategoryId = 5 }, // Tecnología, Sistemas y Telecomunicaciones

                new OfferCategory { OfferCategoryId = 166, OfferId = Guid.Parse("05f44853-1a61-4e47-92c1-1051e7592de9"), CategoryId = 5 }, // Tecnología, Sistemas y Telecomunicaciones
                new OfferCategory { OfferCategoryId = 167, OfferId = Guid.Parse("05f44853-1a61-4e47-92c1-1051e7592de9"), CategoryId = 4 }, // Ingenierías

                new OfferCategory { OfferCategoryId = 168, OfferId = Guid.Parse("88c99390-4e1b-4201-a10b-8a4b6a5b01ef"), CategoryId = 2 }, // Comercial, Ventas y Negocios
                new OfferCategory { OfferCategoryId = 169, OfferId = Guid.Parse("88c99390-4e1b-4201-a10b-8a4b6a5b01ef"), CategoryId = 20 }, // Comunicación y Relaciones Públicas
                new OfferCategory { OfferCategoryId = 170, OfferId = Guid.Parse("88c99390-4e1b-4201-a10b-8a4b6a5b01ef"), CategoryId = 26 }, // Marketing y Publicidad

                new OfferCategory { OfferCategoryId = 171, OfferId = Guid.Parse("02425ff4-5748-4da2-a32e-1b8d897e5f9e"), CategoryId = 5 }, // Tecnología, Sistemas y Telecomunicaciones
                new OfferCategory { OfferCategoryId = 172, OfferId = Guid.Parse("02425ff4-5748-4da2-a32e-1b8d897e5f9e"), CategoryId = 1 }, // Diseño y Desarrollo
                new OfferCategory { OfferCategoryId = 173, OfferId = Guid.Parse("02425ff4-5748-4da2-a32e-1b8d897e5f9e"), CategoryId = 4 }, // Ingenierías

                new OfferCategory { OfferCategoryId = 174, OfferId = Guid.Parse("340c99b3-c922-49cf-9d34-609b768e7f65"), CategoryId = 5 }, // Tecnología, Sistemas y Telecomunicaciones
                new OfferCategory { OfferCategoryId = 175, OfferId = Guid.Parse("340c99b3-c922-49cf-9d34-609b768e7f65"), CategoryId = 3 }, // Administración, Contabilidad y Finanzas
                new OfferCategory { OfferCategoryId = 176, OfferId = Guid.Parse("340c99b3-c922-49cf-9d34-609b768e7f65"), CategoryId = 26 }, // Marketing y Publicidad

                new OfferCategory { OfferCategoryId = 177, OfferId = Guid.Parse("9e920f05-4e16-4536-b246-50c242d1a152"), CategoryId = 14 }, // Legales
                new OfferCategory { OfferCategoryId = 178, OfferId = Guid.Parse("9e920f05-4e16-4536-b246-50c242d1a152"), CategoryId = 18 }, // Gerencia y Dirección General

                new OfferCategory { OfferCategoryId = 179, OfferId = Guid.Parse("cf5ed95f-77e8-4a0e-85f8-78f7df4c2c78"), CategoryId = 3 }, // Administración, Contabilidad y Finanzas
                new OfferCategory { OfferCategoryId = 180, OfferId = Guid.Parse("cf5ed95f-77e8-4a0e-85f8-78f7df4c2c78"), CategoryId = 18 }, // Gerencia y Dirección General
                new OfferCategory { OfferCategoryId = 181, OfferId = Guid.Parse("cf5ed95f-77e8-4a0e-85f8-78f7df4c2c78"), CategoryId = 22 }, // Departamento Técnico

                new OfferCategory { OfferCategoryId = 182, OfferId = Guid.Parse("85b1a6f1-1e05-4eae-a60d-51a334f54ad5"), CategoryId = 4 }, // Ingenierías
                new OfferCategory { OfferCategoryId = 183, OfferId = Guid.Parse("85b1a6f1-1e05-4eae-a60d-51a334f54ad5"), CategoryId = 5 }, // Tecnología, Sistemas y Telecomunicaciones
                new OfferCategory { OfferCategoryId = 184, OfferId = Guid.Parse("85b1a6f1-1e05-4eae-a60d-51a334f54ad5"), CategoryId = 26 }, // Marketing y Publicidad

                new OfferCategory { OfferCategoryId = 185, OfferId = Guid.Parse("23d4c9e5-88b4-44f0-9b64-8308e70e51eb"), CategoryId = 1 }, // Diseño y Desarrollo
                new OfferCategory { OfferCategoryId = 186, OfferId = Guid.Parse("23d4c9e5-88b4-44f0-9b64-8308e70e51eb"), CategoryId = 20 }, // Comunicación y Relaciones Públicas
                new OfferCategory { OfferCategoryId = 187, OfferId = Guid.Parse("23d4c9e5-88b4-44f0-9b64-8308e70e51eb"), CategoryId = 26 }, // Marketing y Publicidad

                new OfferCategory { OfferCategoryId = 188, OfferId = Guid.Parse("b11dd7cf-8245-43a3-9b23-8c8893f83c13"), CategoryId = 4 }, // Ingenierías
                new OfferCategory { OfferCategoryId = 189, OfferId = Guid.Parse("b11dd7cf-8245-43a3-9b23-8c8893f83c13"), CategoryId = 5 }, // Tecnología, Sistemas y Telecomunicaciones
                new OfferCategory { OfferCategoryId = 190, OfferId = Guid.Parse("b11dd7cf-8245-43a3-9b23-8c8893f83c13"), CategoryId = 18 }, // Gerencia y Dirección General
                new OfferCategory { OfferCategoryId = 191, OfferId = Guid.Parse("b11dd7cf-8245-43a3-9b23-8c8893f83c13"), CategoryId = 20 }, // Comunicación y Relaciones Públicas

                new OfferCategory { OfferCategoryId = 192, OfferId = Guid.Parse("e261493e-d760-4a48-bb24-9b5c9d7f4b1a"), CategoryId = 3 }, // Administración, Contabilidad y Finanzas
                new OfferCategory { OfferCategoryId = 193, OfferId = Guid.Parse("e261493e-d760-4a48-bb24-9b5c9d7f4b1a"), CategoryId = 22 }, // Departamento Técnico
                new OfferCategory { OfferCategoryId = 194, OfferId = Guid.Parse("e261493e-d760-4a48-bb24-9b5c9d7f4b1a"), CategoryId = 18 }, // Gerencia y Dirección General

                new OfferCategory { OfferCategoryId = 195, OfferId = Guid.Parse("fe4370bc-c706-4b09-9448-01bc6ff9b01f"), CategoryId = 4 }, // Ingenierías
                new OfferCategory { OfferCategoryId = 196, OfferId = Guid.Parse("fe4370bc-c706-4b09-9448-01bc6ff9b01f"), CategoryId = 5 }, // Tecnología, Sistemas y Telecomunicaciones
                new OfferCategory { OfferCategoryId = 197, OfferId = Guid.Parse("fe4370bc-c706-4b09-9448-01bc6ff9b01f"), CategoryId = 18 }, // Gerencia y Dirección General
                new OfferCategory { OfferCategoryId = 198, OfferId = Guid.Parse("fe4370bc-c706-4b09-9448-01bc6ff9b01f"), CategoryId = 26 }, // Marketing y Publicidad

                new OfferCategory { OfferCategoryId = 199, OfferId = Guid.Parse("3e7b2e42-9315-4395-b5dc-7c973d13a12e"), CategoryId = 5 }, // Tecnología, Sistemas y Telecomunicaciones
                new OfferCategory { OfferCategoryId = 200, OfferId = Guid.Parse("3e7b2e42-9315-4395-b5dc-7c973d13a12e"), CategoryId = 22 }, // Departamento Técnico
                new OfferCategory { OfferCategoryId = 201, OfferId = Guid.Parse("3e7b2e42-9315-4395-b5dc-7c973d13a12e"), CategoryId = 4 }, // Ingenierías

                new OfferCategory { OfferCategoryId = 202, OfferId = Guid.Parse("a6606e3d-b9de-4b4f-840b-83f8e2c29e92"), CategoryId = 3 }, // Administración, Contabilidad y Finanzas
                new OfferCategory { OfferCategoryId = 203, OfferId = Guid.Parse("a6606e3d-b9de-4b4f-840b-83f8e2c29e92"), CategoryId = 18 }, // Gerencia y Dirección General

                new OfferCategory { OfferCategoryId = 204, OfferId = Guid.Parse("f6f63f9f-01e0-4e1f-b675-90c1ffdc17cb"), CategoryId = 4 }, // Ingenierías
                new OfferCategory { OfferCategoryId = 205, OfferId = Guid.Parse("f6f63f9f-01e0-4e1f-b675-90c1ffdc17cb"), CategoryId = 5 }, // Tecnología, Sistemas y Telecomunicaciones
                new OfferCategory { OfferCategoryId = 206, OfferId = Guid.Parse("f6f63f9f-01e0-4e1f-b675-90c1ffdc17cb"), CategoryId = 22 }, // Departamento Técnico

                new OfferCategory { OfferCategoryId = 207, OfferId = Guid.Parse("25d6d135-1cb9-40aa-8962-f89173f8058b"), CategoryId = 3 }, // Administración, Contabilidad y Finanzas
                new OfferCategory { OfferCategoryId = 208, OfferId = Guid.Parse("25d6d135-1cb9-40aa-8962-f89173f8058b"), CategoryId = 20 }, // Comunicación y Relaciones Públicas
                new OfferCategory { OfferCategoryId = 209, OfferId = Guid.Parse("25d6d135-1cb9-40aa-8962-f89173f8058b"), CategoryId = 18 }, // Gerencia y Dirección General
                new OfferCategory { OfferCategoryId = 210, OfferId = Guid.Parse("25d6d135-1cb9-40aa-8962-f89173f8058b"), CategoryId = 22 }, // Departamento Técnico

                new OfferCategory { OfferCategoryId = 211, OfferId = Guid.Parse("cb442d70-d201-457d-872e-5931991cd34d"), CategoryId = 5 }, // Tecnología, Sistemas y Telecomunicaciones
                new OfferCategory { OfferCategoryId = 212, OfferId = Guid.Parse("cb442d70-d201-457d-872e-5931991cd34d"), CategoryId = 14 }, // Legales
                new OfferCategory { OfferCategoryId = 213, OfferId = Guid.Parse("cb442d70-d201-457d-872e-5931991cd34d"), CategoryId = 4 }, // Ingenierías

                new OfferCategory { OfferCategoryId = 214, OfferId = Guid.Parse("91a0529b-af68-4e6c-a67a-593cf3db1f34"), CategoryId = 5 }, // Tecnología, Sistemas y Telecomunicaciones
                new OfferCategory { OfferCategoryId = 215, OfferId = Guid.Parse("91a0529b-af68-4e6c-a67a-593cf3db1f34"), CategoryId = 4 }, // Ingenierías
                new OfferCategory { OfferCategoryId = 216, OfferId = Guid.Parse("91a0529b-af68-4e6c-a67a-593cf3db1f34"), CategoryId = 22 }, // Departamento Técnico

                new OfferCategory { OfferCategoryId = 217, OfferId = Guid.Parse("b8f93f12-00de-4a26-bce2-4bf1d64ff1f4"), CategoryId = 5 }, // Tecnología, Sistemas y Telecomunicaciones
                new OfferCategory { OfferCategoryId = 218, OfferId = Guid.Parse("b8f93f12-00de-4a26-bce2-4bf1d64ff1f4"), CategoryId = 4 }, // Ingenierías
                new OfferCategory { OfferCategoryId = 219, OfferId = Guid.Parse("b8f93f12-00de-4a26-bce2-4bf1d64ff1f4"), CategoryId = 26 }, // Departamento Técnico

                new OfferCategory { OfferCategoryId = 220, OfferId = Guid.Parse("cf9f4731-26f7-4ee7-94d3-44e7ee7443bc"), CategoryId = 5 }, // Tecnología, Sistemas y Telecomunicaciones
                new OfferCategory { OfferCategoryId = 221, OfferId = Guid.Parse("cf9f4731-26f7-4ee7-94d3-44e7ee7443bc"), CategoryId = 26 }, // Marketing y Publicidad
                new OfferCategory { OfferCategoryId = 222, OfferId = Guid.Parse("cf9f4731-26f7-4ee7-94d3-44e7ee7443bc"), CategoryId = 4 }, // Ingenierías

                new OfferCategory { OfferCategoryId = 223, OfferId = Guid.Parse("87158aa4-8702-41be-bb46-11f3d7be70de"), CategoryId = 2 }, // Comercial, Ventas y Negocios
                new OfferCategory { OfferCategoryId = 224, OfferId = Guid.Parse("87158aa4-8702-41be-bb46-11f3d7be70de"), CategoryId = 15 }, // Aduana y Comercio Exterior
                new OfferCategory { OfferCategoryId = 225, OfferId = Guid.Parse("87158aa4-8702-41be-bb46-11f3d7be70de"), CategoryId = 18 }, // Gerencia y Dirección General
                new OfferCategory { OfferCategoryId = 226, OfferId = Guid.Parse("87158aa4-8702-41be-bb46-11f3d7be70de"), CategoryId = 14 }, // Legales

                new OfferCategory { OfferCategoryId = 227, OfferId = Guid.Parse("b01bf51f-1bfa-4434-b70c-57c92e1b4c5d"), CategoryId = 3 }, // Administración, Contabilidad y Finanzas
                new OfferCategory { OfferCategoryId = 228, OfferId = Guid.Parse("b01bf51f-1bfa-4434-b70c-57c92e1b4c5d"), CategoryId = 18 }, // Gerencia y Dirección General
                new OfferCategory { OfferCategoryId = 229, OfferId = Guid.Parse("b01bf51f-1bfa-4434-b70c-57c92e1b4c5d"), CategoryId = 26 }, // Marketing y Publicidad
                new OfferCategory { OfferCategoryId = 230, OfferId = Guid.Parse("b01bf51f-1bfa-4434-b70c-57c92e1b4c5d"), CategoryId = 2 }, // Comercial, Ventas y Negocios

                new OfferCategory { OfferCategoryId = 231, OfferId = Guid.Parse("cb440631-9b4e-4a3c-808b-6eefb7640244"), CategoryId = 5 }, // Tecnología, Sistemas y Telecomunicaciones
                new OfferCategory { OfferCategoryId = 232, OfferId = Guid.Parse("cb440631-9b4e-4a3c-808b-6eefb7640244"), CategoryId = 4 }, // Ingenierías
                new OfferCategory { OfferCategoryId = 233, OfferId = Guid.Parse("cb440631-9b4e-4a3c-808b-6eefb7640244"), CategoryId = 1 }, // Diseño y Desarrollo

                new OfferCategory { OfferCategoryId = 234, OfferId = Guid.Parse("8212d2fc-d4e7-47ee-8aee-846d9242dc85"), CategoryId = 3 }, // Administración, Contabilidad y Finanzas
                new OfferCategory { OfferCategoryId = 235, OfferId = Guid.Parse("8212d2fc-d4e7-47ee-8aee-846d9242dc85"), CategoryId = 18 }, // Gerencia y Dirección General
                new OfferCategory { OfferCategoryId = 236, OfferId = Guid.Parse("8212d2fc-d4e7-47ee-8aee-846d9242dc85"), CategoryId = 14 }, // Legales

                new OfferCategory { OfferCategoryId = 237, OfferId = Guid.Parse("4dbb52e1-d34e-4383-8bcb-049e545020f2"), CategoryId = 1 }, // Diseño y Desarrollo
                new OfferCategory { OfferCategoryId = 238, OfferId = Guid.Parse("4dbb52e1-d34e-4383-8bcb-049e545020f2"), CategoryId = 5 }, // Tecnología, Sistemas y Telecomunicaciones
                new OfferCategory { OfferCategoryId = 239, OfferId = Guid.Parse("4dbb52e1-d34e-4383-8bcb-049e545020f2"), CategoryId = 4 }, // Ingenierías

                new OfferCategory { OfferCategoryId = 240, OfferId = Guid.Parse("7c081f3d-6f03-4a38-bc5d-88ebe23baf6e"), CategoryId = 3 }, // Administración, Contabilidad y Finanzas
                new OfferCategory { OfferCategoryId = 241, OfferId = Guid.Parse("7c081f3d-6f03-4a38-bc5d-88ebe23baf6e"), CategoryId = 18 }, // Gerencia y Dirección General
                new OfferCategory { OfferCategoryId = 242, OfferId = Guid.Parse("7c081f3d-6f03-4a38-bc5d-88ebe23baf6e"), CategoryId = 14 }, // Legales

                new OfferCategory { OfferCategoryId = 243, OfferId = Guid.Parse("a06d4fd8-3f4d-4bc7-8f70-4f9d3204000a"), CategoryId = 1 }, // Diseño y Desarrollo
                new OfferCategory { OfferCategoryId = 244, OfferId = Guid.Parse("a06d4fd8-3f4d-4bc7-8f70-4f9d3204000a"), CategoryId = 5 }, // Tecnología, Sistemas y Telecomunicaciones
                new OfferCategory { OfferCategoryId = 245, OfferId = Guid.Parse("a06d4fd8-3f4d-4bc7-8f70-4f9d3204000a"), CategoryId = 4 }, // Ingenierías

                new OfferCategory { OfferCategoryId = 246, OfferId = Guid.Parse("1233490d-6014-4ebd-8ef5-1d3801d6b207"), CategoryId = 4 }, // Ingenierías
                new OfferCategory { OfferCategoryId = 247, OfferId = Guid.Parse("1233490d-6014-4ebd-8ef5-1d3801d6b207"), CategoryId = 18 }, // Gerencia y Dirección General
                new OfferCategory { OfferCategoryId = 248, OfferId = Guid.Parse("1233490d-6014-4ebd-8ef5-1d3801d6b207"), CategoryId = 1 }, // Diseño y Desarrollo

                new OfferCategory { OfferCategoryId = 249, OfferId = Guid.Parse("98c748ed-fb3e-46f0-881e-3f820ff28a4b"), CategoryId = 5 }, // Tecnología, Sistemas y Telecomunicaciones
                new OfferCategory { OfferCategoryId = 250, OfferId = Guid.Parse("98c748ed-fb3e-46f0-881e-3f820ff28a4b"), CategoryId = 14 }, // Legales
                new OfferCategory { OfferCategoryId = 251, OfferId = Guid.Parse("98c748ed-fb3e-46f0-881e-3f820ff28a4b"), CategoryId = 18 }, // Gerencia y Dirección General

                new OfferCategory { OfferCategoryId = 252, OfferId = Guid.Parse("e9e19908-2b38-4d06-8499-2d6545d9de4b"), CategoryId = 5 }, // Tecnología, Sistemas y Telecomunicaciones
                new OfferCategory { OfferCategoryId = 253, OfferId = Guid.Parse("e9e19908-2b38-4d06-8499-2d6545d9de4b"), CategoryId = 1 }, // Diseño y Desarrollo
                new OfferCategory { OfferCategoryId = 254, OfferId = Guid.Parse("e9e19908-2b38-4d06-8499-2d6545d9de4b"), CategoryId = 22 }, // Departamento Técnico

                new OfferCategory { OfferCategoryId = 255, OfferId = Guid.Parse("4aa15359-2d8d-4e2c-9c07-7d6f1a5e7801"), CategoryId = 3 }, // Administración, Contabilidad y Finanzas
                new OfferCategory { OfferCategoryId = 256, OfferId = Guid.Parse("4aa15359-2d8d-4e2c-9c07-7d6f1a5e7801"), CategoryId = 18 }, // Gerencia y Dirección General
                new OfferCategory { OfferCategoryId = 257, OfferId = Guid.Parse("4aa15359-2d8d-4e2c-9c07-7d6f1a5e7801"), CategoryId = 26 }, // Marketing y Publicidad

                new OfferCategory { OfferCategoryId = 258, OfferId = Guid.Parse("556e0544-f769-4d92-8a68-97148942b0b7"), CategoryId = 11 }, // Recursos Humanos y Capacitación
                new OfferCategory { OfferCategoryId = 259, OfferId = Guid.Parse("556e0544-f769-4d92-8a68-97148942b0b7"), CategoryId = 18 }, // Gerencia y Dirección General
                new OfferCategory { OfferCategoryId = 260, OfferId = Guid.Parse("556e0544-f769-4d92-8a68-97148942b0b7"), CategoryId = 21 }, // Educación, Docencia e Investigación

                new OfferCategory { OfferCategoryId = 261, OfferId = Guid.Parse("fc54aecd-32d3-4de3-94d0-e26d09d3a8e7"), CategoryId = 3 }, // Administración, Contabilidad y Finanzas
                new OfferCategory { OfferCategoryId = 262, OfferId = Guid.Parse("fc54aecd-32d3-4de3-94d0-e26d09d3a8e7"), CategoryId = 18 }, // Gerencia y Dirección General
                new OfferCategory { OfferCategoryId = 263, OfferId = Guid.Parse("fc54aecd-32d3-4de3-94d0-e26d09d3a8e7"), CategoryId = 26 }, // Marketing y Publicidad

                new OfferCategory { OfferCategoryId = 264, OfferId = Guid.Parse("51ee0986-9f82-4a0f-86a7-64b1871ef3f2"), CategoryId = 11 }, // Recursos Humanos y Capacitación
                new OfferCategory { OfferCategoryId = 265, OfferId = Guid.Parse("51ee0986-9f82-4a0f-86a7-64b1871ef3f2"), CategoryId = 18 }, // Gerencia y Dirección General
                new OfferCategory { OfferCategoryId = 266, OfferId = Guid.Parse("51ee0986-9f82-4a0f-86a7-64b1871ef3f2"), CategoryId = 21 }, // Educación, Docencia e Investigación

                new OfferCategory { OfferCategoryId = 267, OfferId = Guid.Parse("0e3a7879-7587-43f5-a9cf-657a824d1fc5"), CategoryId = 4 }, // Ingenierías
                new OfferCategory { OfferCategoryId = 268, OfferId = Guid.Parse("0e3a7879-7587-43f5-a9cf-657a824d1fc5"), CategoryId = 5 }, // Tecnología, Sistemas y Telecomunicaciones
                new OfferCategory { OfferCategoryId = 269, OfferId = Guid.Parse("0e3a7879-7587-43f5-a9cf-657a824d1fc5"), CategoryId = 1 }, // Diseño y Desarrollo

                new OfferCategory { OfferCategoryId = 270, OfferId = Guid.Parse("d3d478ef-2b5a-4265-a81c-7d9123982fb9"), CategoryId = 2 }, // Comercial, Ventas y Negocios
                new OfferCategory { OfferCategoryId = 271, OfferId = Guid.Parse("d3d478ef-2b5a-4265-a81c-7d9123982fb9"), CategoryId = 8 }, // Gastronomía y Turismo
                new OfferCategory { OfferCategoryId = 272, OfferId = Guid.Parse("d3d478ef-2b5a-4265-a81c-7d9123982fb9"), CategoryId = 20 }, // Comunicación y Relaciones Públicas

                new OfferCategory { OfferCategoryId = 273, OfferId = Guid.Parse("c7aeb14d-01e7-4d08-b659-11c424e69728"), CategoryId = 2 }, // Comercial, Ventas y Negocios
                new OfferCategory { OfferCategoryId = 274, OfferId = Guid.Parse("c7aeb14d-01e7-4d08-b659-11c424e69728"), CategoryId = 18 }, // Gerencia y Dirección General
                new OfferCategory { OfferCategoryId = 275, OfferId = Guid.Parse("c7aeb14d-01e7-4d08-b659-11c424e69728"), CategoryId = 9 }, // Abastecimiento y Logística

                new OfferCategory { OfferCategoryId = 276, OfferId = Guid.Parse("4a6decd4-ae8b-4a6d-95eb-13aeb00770a7"), CategoryId = 2 }, // Comercial, Ventas y Negocios
                new OfferCategory { OfferCategoryId = 277, OfferId = Guid.Parse("4a6decd4-ae8b-4a6d-95eb-13aeb00770a7"), CategoryId = 9 }, // Abastecimiento y Logística
                new OfferCategory { OfferCategoryId = 278, OfferId = Guid.Parse("4a6decd4-ae8b-4a6d-95eb-13aeb00770a7"), CategoryId = 18 }, // Gerencia y Dirección General

                new OfferCategory { OfferCategoryId = 279, OfferId = Guid.Parse("87b7e22d-d7fd-45c0-b0c3-06da652cb9eb"), CategoryId = 1 }, // Diseño y Desarrollo
                new OfferCategory { OfferCategoryId = 280, OfferId = Guid.Parse("87b7e22d-d7fd-45c0-b0c3-06da652cb9eb"), CategoryId = 5 }, // Tecnología, Sistemas y Telecomunicaciones
                new OfferCategory { OfferCategoryId = 281, OfferId = Guid.Parse("87b7e22d-d7fd-45c0-b0c3-06da652cb9eb"), CategoryId = 22 }, // Departamento Técnico
                new OfferCategory { OfferCategoryId = 282, OfferId = Guid.Parse("87b7e22d-d7fd-45c0-b0c3-06da652cb9eb"), CategoryId = 4 }, // Ingenierías

                new OfferCategory { OfferCategoryId = 283, OfferId = Guid.Parse("2a47a025-03b4-46a3-985a-45e1a1e52b53"), CategoryId = 2 }, // Comercial, Ventas y Negocios
                new OfferCategory { OfferCategoryId = 284, OfferId = Guid.Parse("2a47a025-03b4-46a3-985a-45e1a1e52b53"), CategoryId = 8 }, // Gastronomía y Turismo
                new OfferCategory { OfferCategoryId = 285, OfferId = Guid.Parse("2a47a025-03b4-46a3-985a-45e1a1e52b53"), CategoryId = 20 }, // Comunicación y Relaciones Públicas

                new OfferCategory { OfferCategoryId = 286, OfferId = Guid.Parse("0df2461b-f778-4d26-8a0b-88e63010bc63"), CategoryId = 2 }, // Comercial, Ventas y Negocios
                new OfferCategory { OfferCategoryId = 287, OfferId = Guid.Parse("0df2461b-f778-4d26-8a0b-88e63010bc63"), CategoryId = 8 }, // Gastronomía y Turismo
                new OfferCategory { OfferCategoryId = 288, OfferId = Guid.Parse("0df2461b-f778-4d26-8a0b-88e63010bc63"), CategoryId = 20 }, // Comunicación y Relaciones Públicas

                new OfferCategory { OfferCategoryId = 289, OfferId = Guid.Parse("d63e5d07-606f-414b-86d7-2b9f9907bde0"), CategoryId = 5 }, // Tecnología, Sistemas y Telecomunicaciones
                new OfferCategory { OfferCategoryId = 290, OfferId = Guid.Parse("d63e5d07-606f-414b-86d7-2b9f9907bde0"), CategoryId = 4 }, // Ingenierías
                new OfferCategory { OfferCategoryId = 291, OfferId = Guid.Parse("d63e5d07-606f-414b-86d7-2b9f9907bde0"), CategoryId = 22 }, // Departamento Técnico
                new OfferCategory { OfferCategoryId = 292, OfferId = Guid.Parse("d63e5d07-606f-414b-86d7-2b9f9907bde0"), CategoryId = 1 }, // Diseño y Desarrollo

                new OfferCategory { OfferCategoryId = 293, OfferId = Guid.Parse("93c7688d-e348-44db-97ec-cd46e4e46d53"), CategoryId = 2 }, // Comercial, Ventas y Negocios
                new OfferCategory { OfferCategoryId = 294, OfferId = Guid.Parse("93c7688d-e348-44db-97ec-cd46e4e46d53"), CategoryId = 26 }, // Marketing y Publicidad
                new OfferCategory { OfferCategoryId = 295, OfferId = Guid.Parse("93c7688d-e348-44db-97ec-cd46e4e46d53"), CategoryId = 1 }, // Diseño y Desarrollo

                new OfferCategory { OfferCategoryId = 296, OfferId = Guid.Parse("82b546bb-5fc3-40e0-b21e-1a9f01d79a92"), CategoryId = 6 }, // Secretarias y Recepción
                new OfferCategory { OfferCategoryId = 297, OfferId = Guid.Parse("82b546bb-5fc3-40e0-b21e-1a9f01d79a92"), CategoryId = 9 }, // Abastecimiento y Logística
                new OfferCategory { OfferCategoryId = 298, OfferId = Guid.Parse("82b546bb-5fc3-40e0-b21e-1a9f01d79a92"), CategoryId = 18 }, // Gerencia y Dirección General

                new OfferCategory { OfferCategoryId = 299, OfferId = Guid.Parse("cb6fe4d5-c44d-4f54-8826-d6b7b4528ef0"), CategoryId = 10 }, // Atención al Cliente, Call Center y Telemarketing
                new OfferCategory { OfferCategoryId = 300, OfferId = Guid.Parse("cb6fe4d5-c44d-4f54-8826-d6b7b4528ef0"), CategoryId = 11 },  // Recursos Humanos y Capacitación
                new OfferCategory { OfferCategoryId = 301, OfferId = Guid.Parse("cb6fe4d5-c44d-4f54-8826-d6b7b4528ef0"), CategoryId = 6 } // Secretarias y Recepción
                );
        }
    }
}