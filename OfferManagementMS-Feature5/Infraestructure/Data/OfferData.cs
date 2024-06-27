using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infraestructure.Data
{
    public class OfferData
    {
        public static void SeedData(EntityTypeBuilder<Offer> builder)
        {
            builder.HasData(
                new Offer 
                { 
                    OfferId = Guid.Parse("d4b57950-3920-4a06-a7f6-76bfb5e1d501"), 
                    CompanyId = Guid.Parse("ddc7879b-e104-4047-bd15-d0fade9bbeee"), 
                    Title = "Blue Journey Programa de Pasantía 2do Semestre Argentina 2024", 
                    Description = "En IBM, el trabajo es más que un trabajo, es una vocación: Construir. Diseñar. Codificar. Consultar. Pensar con los clientes y vender. Crear mercado. Inventar. Colaborar. No solo para hacer algo mejor, sino para intentar cosas que nunca creyó posibles. Estar al frente en esta nueva era de la tecnología y resolver algunos de los problemas más exigentes del mundo.\r\n\r\nSu función y responsabilidades\r\n\r\nLos estudiantes son empleados que se contratan para que desempeñen una labor preprofesional/profesional mientras estudian en la universidad/institución educativa o justo después de haber obtenido su titulación y que trabajan para IBM como parte necesaria de su programa académico o que trabajan durante las vacaciones o períodos festivos o como curso en prácticas; por ejemplo, las colaboraciones y los graduados en prácticas." +
                    "En este puesto, trabajará en uno de nuestros Centros de Innovación de Clientes de IBM Consulting (Centros de Entrega), donde brindamos una profunda experiencia técnica y de la industria a una amplia gama de clientes de los sectores público y privado en todo el mundo. Nuestros centros de entrega ofrecen nuestra Habilidades y experiencia técnica de nuestros clientes a nivel local para impulsar la innovación y la adopción de nuevas tecnologías.\r\n" +
                    "IBM Consulting es el socio comercial y tecnológico que las empresas eligen para enfrentar los desafíos más grandes de la transformación digital. Nos especializamos en ayudar a nuestros clientes a diseñar, construir y gestionar soluciones que crean un valor duradero. Ya sea que se trate de aprovechar tecnologías emergentes como inteligencia artificial, blockchain, IoT, nube híbrida, 5G o aprovechar al máximo las aplicaciones empresariales tradicionales, IBM Consulting ayuda a nuestros clientes a alcanzar el éxito.\r\n" +
                    "Como parte de nuestro equipo, trabajará con expertos líderes en la industria que están comprometidos con su desarrollo y éxito. IBM Consulting ofrece oportunidades únicas para aprender y crecer en un ambiente colaborativo y dinámico.\r\n" +
                    "Sus responsabilidades en este puesto incluirán:\r\n" +
                    "- Participar en el desarrollo de soluciones innovadoras para nuestros clientes.\r\n" +
                    "- Colaborar con equipos multifuncionales para diseñar y desarrollar aplicaciones y sistemas que aborden necesidades empresariales específicas.\r\n" +
                    "- Utilizar tecnologías avanzadas y metodologías ágiles para entregar proyectos de alta calidad dentro de los plazos establecidos.\r\n" +
                    "- Contribuir al desarrollo y la mejora continua de nuestras prácticas y estándares técnicos.\r\n" +
                    "- Trabajar en estrecha colaboración con los clientes para comprender sus requisitos y garantizar que las soluciones propuestas cumplan con sus expectativas.\r\n" +
                    "- Proporcionar soporte técnico y capacitación a los usuarios finales.\r\n" +
                    "IBM Consulting valora la diversidad y la inclusión. Creemos que un equipo diverso y una cultura inclusiva son esenciales para impulsar la innovación y el éxito empresarial. Fomentamos un ambiente donde todos los empleados pueden expresar sus ideas y perspectivas, y donde cada persona es valorada por sus contribuciones únicas.\r\n" +
                    "Para tener éxito en este puesto, se requiere:\r\n" +
                    "- Estar actualmente inscrito en un programa de educación superior en un campo relacionado con la tecnología o haber obtenido recientemente un título en dicho campo.\r\n" +
                    "- Tener un fuerte interés en el desarrollo de software, la consultoría tecnológica y la innovación.\r\n" +
                    "- Demostrar habilidades analíticas y de resolución de problemas.\r\n" +
                    "- Tener la capacidad de trabajar de manera independiente y en equipo.\r\n" +
                    "- Poseer excelentes habilidades de comunicación y capacidad para interactuar eficazmente con clientes y colegas.\r\n" +
                    "- Tener conocimientos en una o más de las siguientes áreas: desarrollo de software, inteligencia artificial, blockchain, IoT, nube híbrida, 5G, o aplicaciones empresariales tradicionales.\r\n" +
                    "IBM Consulting ofrece un paquete competitivo de beneficios, que incluye oportunidades de desarrollo profesional, capacitación continua, y acceso a recursos y herramientas de vanguardia. También proporcionamos un entorno de trabajo flexible que apoya el equilibrio entre la vida laboral y personal.\r\n" +
                    "Si está buscando una oportunidad para hacer una diferencia real y tener un impacto positivo en el mundo a través de la tecnología, IBM Consulting es el lugar para usted. Únase a nosotros y sea parte de un equipo que está liderando la innovación y la transformación digital.\r\n" +
                    "Para postularse a este programa de pasantía, envíe su CV actualizado y una carta de presentación que destaque su interés en el puesto y sus calificaciones relevantes. Estamos buscando a los mejores y más brillantes talentos para unirse a nuestro equipo y ayudar a dar forma al futuro de la tecnología.\r\n" +
                    "En IBM Consulting, creemos que el futuro de la tecnología está en las manos de aquellos que están dispuestos a desafiar lo convencional y explorar nuevas posibilidades. Estamos comprometidos con la creación de un ambiente de trabajo que fomente la creatividad, la colaboración y la innovación. Esperamos con interés recibir su solicitud y conocer cómo puede contribuir a nuestro equipo.",
                    JobOfferModeId = 1, 
                    PublicationDate = DateTime.Parse("07/05/2024"), 
                    CityId = 022007, 
                    StudyTypeId = 4, 
                    Vacancies = new Random().Next(1, 11)
                },
                new Offer
                {
                    OfferId = Guid.Parse("e4e8d3ec-9df2-46dc-a465-dc17a7815d56"),
                    CompanyId = Guid.Parse("ddc7879b-e104-4047-bd15-d0fade9bbeee"),
                    Title = "Developer .Net Core BE",
                    Description = "En este rol, trabajarás en uno de nuestros Centros de Innovación para Clientes de Consultoría de IBM (Centros de Entrega), donde ofrecemos una profunda experiencia técnica e industrial a una amplia gama de clientes del sector público y privado en todo el mundo. Nuestros centros de entrega ofrecen a nuestros clientes habilidades y experiencia técnica basadas localmente para impulsar la innovación y la adopción de nuevas tecnologías. Una carrera en Consultoría de IBM se fundamenta en relaciones a largo plazo y una estrecha colaboración con clientes en todo el mundo. Trabajarás con visionarios de múltiples industrias para mejorar el viaje hacia la nube híbrida y la inteligencia artificial para las empresas más innovadoras y valiosas del mundo. Tu capacidad para acelerar el impacto y lograr cambios significativos para tus clientes está habilitada por nuestro ecosistema de socios estratégicos y nuestras sólidas plataformas tecnológicas en todo el portafolio de IBM; incluyendo Software y Red Hat.\r\n\r\nEn este rol, trabajarás en uno de nuestros Centros de Innovación para Clientes de Consultoría de IBM (Centros de Entrega), donde ofrecemos una profunda experiencia técnica e industrial a una amplia gama de clientes del sector público y privado en todo el mundo. Nuestros centros de entrega ofrecen a nuestros clientes habilidades y experiencia técnica basadas localmente para impulsar la innovación y la adopción de nuevas tecnologías. Una carrera en Consultoría de IBM se fundamenta en relaciones a largo plazo y una estrecha colaboración con clientes en todo el mundo. Trabajarás con visionarios de múltiples industrias para mejorar el viaje hacia la nube híbrida y la inteligencia artificial para las empresas más innovadoras y valiosas del mundo. Tu capacidad para acelerar el impacto y lograr cambios significativos para tus clientes está habilitada por nuestro ecosistema de socios estratégicos y nuestras sólidas plataformas tecnológicas en todo el portafolio de IBM; incluyendo Software y Red Hat.\r\n\r\nEn este rol, trabajarás en uno de nuestros Centros de Innovación para Clientes de Consultoría de IBM (Centros de Entrega), donde ofrecemos una profunda experiencia técnica e industrial a una amplia gama de clientes del sector público y privado en todo el mundo. Nuestros centros de entrega ofrecen a nuestros clientes habilidades y experiencia técnica basadas localmente para impulsar la innovación y la adopción de nuevas tecnologías. Una carrera en Consultoría de IBM se fundamenta en relaciones a largo plazo y una estrecha colaboración con clientes en todo el mundo. Trabajarás con visionarios de múltiples industrias para mejorar el viaje hacia la nube híbrida y la inteligencia artificial para las empresas más innovadoras y valiosas del mundo. Tu capacidad para acelerar el impacto y lograr cambios significativos para tus clientes está habilitada por nuestro ecosistema de socios estratégicos y nuestras sólidas plataformas tecnológicas en todo el portafolio de IBM; incluyendo Software y Red Hat.",
                    JobOfferModeId = 1,
                    PublicationDate = DateTime.Parse("08/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4
                },
                new Offer
                {
                    OfferId = Guid.Parse("c2d4bb58-aa15-4659-8f42-e4e6326b6cf2"),
                    CompanyId = Guid.Parse("ddc7879b-e104-4047-bd15-d0fade9bbeee"),
                    Title = "Desarrollador BE Broker API SSR",
                    Description = @"En este puesto, como Desarrollador Backend para Broker API en SSR (Servicios de Sistemas Remotos), formarás parte de uno de los equipos de élite de IBM Consulting. Trabajarás en uno de nuestros innovadores Centros de Innovación de Clientes, los cuales son pilares esenciales para proporcionar soluciones técnicas y de la industria a una amplia gama de clientes, tanto del sector público como privado, en todo el mundo. Nuestros centros, ubicados estratégicamente, no solo son espacios de trabajo, sino también cunas de innovación donde se combinan habilidades técnicas y experiencia del cliente para impulsar la adopción de las últimas tecnologías y promover la innovación continua.\r\n" +
                    "Tu rol incluirá la participación activa en el diseño, desarrollo y mantenimiento de sistemas backend críticos para nuestros clientes. Trabajarás en estrecha colaboración con equipos multifuncionales para garantizar la entrega exitosa de soluciones que cumplan con los más altos estándares de calidad y satisfagan las necesidades empresariales específicas de nuestros clientes. Utilizarás tecnologías de vanguardia y adoptarás metodologías ágiles para asegurar que los proyectos se entreguen a tiempo y dentro del presupuesto.\r\n" +
                    "Además, tendrás la oportunidad de trabajar en una variedad de proyectos desafiantes y emocionantes, desde el diseño de arquitecturas de sistemas escalables hasta la implementación de API robustas y seguras. Tu contribución será crucial para ayudar a nuestros clientes a enfrentar los desafíos tecnológicos del futuro y lograr sus objetivos empresariales.\r\n" +
                    "Requisitos:\r\n" +
                    "- Experiencia sólida en el desarrollo de sistemas backend, preferiblemente en entornos empresariales.\r\n" +
                    "- Conocimiento profundo de tecnologías clave, como Java, .NET, Python, o similar.\r\n" +
                    "- Experiencia con bases de datos relacionales y no relacionales, así como con tecnologías de almacenamiento de datos.\r\n" +
                    "- Habilidades demostradas en el diseño y desarrollo de API RESTful.\r\n" +
                    "- Familiaridad con metodologías ágiles, como Scrum o Kanban.\r\n" +
                    "- Excelentes habilidades de comunicación y capacidad para trabajar en equipo.\r\n" +
                    "- Compromiso con la excelencia técnica y la mejora continua.\r\n" +
                    "Únete a nosotros en IBM Consulting y conviértete en parte de un equipo apasionado por la innovación y el éxito del cliente. Juntos, estamos impulsando la transformación digital y creando un futuro mejor para todos.\r\n" +
                    "¡Aplica ahora y sé parte de nuestra emocionante travesía tecnológica!\r\n",
                    JobOfferModeId = 1,
                    PublicationDate = DateTime.Parse("08/03/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },

                new Offer 
                { 
                    OfferId = Guid.Parse("3b481a4c-0c63-4ff8-b1e4-0c726d300e0c"), 
                    CompanyId = Guid.Parse("ddc7879b-e104-4047-bd15-d0fade9bbeee"), 
                    Title = "SAP MM Consultant", 
                    Description = "Como Consultor, usted servirá como un practicante orientado al cliente que vende, lidera e implementa servicios expertos utilizando la amplitud de las ofertas y tecnologías de IBM. Un Consultor exitoso es considerado por los clientes como un asesor comercial de confianza que colabora para proporcionar soluciones innovadoras utilizadas para resolver los problemas empresariales más desafiantes.\r\n\r\nSu papel y responsabilidades\r\n\r\nEl Consultor SAP MM es un profesional con experiencia en la implementación y optimización de los módulos de gestión de materiales (MM) en el sistema SAP. Su función principal es ayudar a los clientes a maximizar el valor de sus inversiones en tecnología SAP y a mejorar sus procesos comerciales relacionados con la gestión de materiales.\r\n\r\nComo Consultor SAP MM, sus responsabilidades incluirán:\r\n\r\n- Colaborar con los clientes para comprender sus necesidades comerciales y de TI relacionadas con la gestión de materiales.\r\n- Diseñar soluciones técnicas y funcionales que optimicen los procesos de gestión de materiales del cliente.\r\n- Configurar y personalizar el sistema SAP para satisfacer los requisitos específicos del cliente.\r\n- Realizar pruebas exhaustivas para garantizar la calidad y la integridad de las soluciones implementadas.\r\n- Proporcionar capacitación y soporte a los usuarios finales para garantizar una adopción exitosa del sistema SAP.\r\n- Colaborar con otros consultores y equipos técnicos para integrar soluciones SAP con otros sistemas empresariales.\r\n- Mantenerse al día con las últimas actualizaciones y tendencias en tecnología SAP y aplicar ese conocimiento para mejorar continuamente las soluciones y servicios ofrecidos a los clientes.\r\n\r\nIBM Consulting es líder en la implementación de soluciones SAP para empresas de todos los tamaños y sectores. Nuestros consultores tienen una profunda experiencia en la implementación exitosa de SAP MM en una variedad de entornos empresariales.\r\n\r\nPara tener éxito en este puesto, se requiere:\r\n\r\n- Experiencia previa en la implementación de SAP MM, incluida la configuración, personalización y prueba del sistema.\r\n- Conocimiento sólido de los procesos comerciales relacionados con la gestión de materiales, así como de las mejores prácticas de la industria.\r\n- Habilidades analíticas y de resolución de problemas para identificar y abordar eficazmente los desafíos comerciales del cliente.\r\n- Excelentes habilidades de comunicación y capacidad para interactuar con clientes y colegas en todos los niveles de la organización.\r\n- Certificación SAP y experiencia en otros módulos SAP son altamente valorados.\r\n\r\nIBM Consulting ofrece un entorno de trabajo dinámico y colaborativo donde los consultores tienen la oportunidad de trabajar en proyectos emocionantes y desafiantes para algunos de los clientes más grandes y prestigiosos del mundo. Además de un paquete competitivo de beneficios y oportunidades de desarrollo profesional, IBM Consulting brinda un ambiente que fomenta la diversidad, la inclusión y el crecimiento personal y profesional.\r\n\r\nSi está buscando una carrera gratificante en consultoría SAP y desea formar parte de un equipo de élite de profesionales de IBM Consulting, ¡esperamos recibir su solicitud!\r\n\r\nPara postularse a esta posición de Consultor SAP MM, envíe su CV actualizado y una carta de presentación que destaque su experiencia y calificaciones relevantes. ¡Únase a nosotros y contribuya al éxito de nuestros clientes y al crecimiento continuo de IBM Consulting!\r\n", 
                    JobOfferModeId = 1, 
                    PublicationDate = DateTime.Parse("09/05/2024"), 
                    CityId = 022007,  
                    StudyTypeId = 4,
                },

                new Offer
                {
                    OfferId = Guid.Parse("fd98a956-2a04-4a29-89a6-fce06f13803f"),
                    CompanyId = Guid.Parse("ddc7879b-e104-4047-bd15-d0fade9bbeee"),
                    Title = "US Tax Professional",
                    Description = "We are looking for highly skilled Tax Analysts to join our team. In this role, you will be responsible for the settlement and payment of Indirect Taxes in Canada and the US. Your tasks will include entering accounting entries, performing variation analysis, supporting the accounting department with reconciliations, maintaining controls, and ensuring compliance with audits.\r\n\r\nAs a Tax Analyst, you will play a crucial role in the standardization of processes and the assembly of electronic books. You will have the opportunity to work in a dynamic environment where your contributions are valued and encouraged.\r\n\r\nKey Responsibilities:\r\n- Settlement and payment of Indirect Taxes in Canada and the US.\r\n- Entering accounting entries and performing variation analysis.\r\n- Supporting the accounting department with reconciliations.\r\n- Maintaining controls and ensuring compliance with audits.\r\n- Participating in the standardization of processes and the assembly of electronic books.\r\n\r\nRequirements:\r\n- Bachelor's degree in Accounting, Finance, or related field.\r\n- Strong understanding of tax regulations and compliance requirements.\r\n- Experience in accounting software and proficiency in Microsoft Excel.\r\n- Excellent analytical and problem-solving skills.\r\n- Ability to work independently and as part of a team.\r\n- Effective communication and interpersonal skills.\r\n- Attention to detail and accuracy.\r\n\r\nJoin our team and become part of a company that values innovation, diversity, and professional growth. We offer competitive compensation, opportunities for advancement, and a supportive work environment.\r\n\r\nIf you are passionate about tax analysis and are looking for a challenging and rewarding career opportunity, we encourage you to apply now!\r\n",
                    JobOfferModeId = 1,
                    PublicationDate = DateTime.Parse("09/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },

                new Offer
                {
                    OfferId = Guid.Parse("90cc7e80-982b-4f36-8986-529bd7c11a1f"),
                    CompanyId = Guid.Parse("ddc7879b-e104-4047-bd15-d0fade9bbeee"),
                    Title = "SAP PM Sr",
                    Description = "En este emocionante puesto de SAP PM Senior, tendrás la oportunidad de sumergirte en el mundo dinámico de la gestión de la planta y mantenimiento en SAP, llevando tus habilidades y experiencia al siguiente nivel.\r\n\r\nResponsabilidades clave incluyen:\r\n\r\nGestión de la logística de salida: Proceso de entrega de salida con determinación de ruta, verificación de disponibilidad, preparación y empaque integrado con el sistema de almacén 3PL.\r\nIntegración de EDI para ASN para enviar a la parte receptora.\r\nGestión de la logística de entrada: Proceso de entrega de entrada con recepción de mercancías integrada con el sistema de almacén 3PL.\r\nSubcontratación para cambios menores en el producto ejecutados por el proveedor local.\r\nAjuste de stock y movimiento de materiales (calidad, bloqueo, no restringido) integrado con el sistema de almacén 3PL.\r\n\r\nEstamos buscando a un profesional apasionado y experimentado que traiga consigo un profundo conocimiento de SAP PM y un historial probado de éxito en la implementación y gestión de proyectos relacionados con la gestión de plantas y mantenimiento. Además de tus habilidades técnicas, valoramos la capacidad de trabajar en equipo, la resolución de problemas y la comunicación efectiva con los compañeros de equipo y los interesados.\r\n\r\nEsta posición ofrece la oportunidad de trabajar en un entorno colaborativo y desafiante, donde cada día es diferente y cada proyecto presenta nuevas oportunidades de aprendizaje y crecimiento. Únete a nuestro equipo y sé parte de una organización líder en su sector, impulsando la innovación y la excelencia en la gestión de plantas y mantenimiento con SAP.\r\n\r\nFecha de publicación: 08/05/2024\r\nUbicación: Argentina\r\nTipo de Estudio: Tiempo Completo\r\nNúmero de Vacantes: 1 a 10",
                    JobOfferModeId = 1,
                    PublicationDate = DateTime.Parse("08/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4
                },

                new Offer
                {
                    OfferId = Guid.Parse("f91f3aa0-66a8-4f4b-81e6-87d01e681d8d"),
                    CompanyId = Guid.Parse("ecdb5eda-1cee-4e68-b100-160203158d57"),
                    Title = "Analista Desarrollador",
                    Description = "Como Desarrollador, te sumergirás en el emocionante mundo de la gestión de datos logísticos, aplicando tus habilidades técnicas y analíticas para mantener y actualizar bases de datos críticas, proyectar volúmenes de transporte y analizar costos asociados.\r\n\r\nTus responsabilidades incluirán:\r\n\r\n- Mantenimiento y actualización de la base de datos de variables logísticas.\r\n- Ajuste de proyecciones de volúmenes de transporte y costos estándar asociados.\r\n- Generación y mantenimiento de bases de datos operativas.\r\n- Creación, mantenimiento y actualización de KPIs operativos, costos y pagos.\r\n- Asistencia en el análisis técnico del armado del presupuesto.\r\n- Realización de cálculos técnicos frente a propuestas de mejoras operativas y cuantificación de ahorros potenciales.\r\n\r\nBuscamos a un profesional apasionado por los datos y el análisis, con experiencia en la gestión de bases de datos y la generación de informes operativos. Además de tus habilidades técnicas, valoramos la capacidad de trabajar en equipo, la resolución de problemas y la comunicación efectiva con los compañeros de equipo y los interesados.\r\n\r\nEsta posición ofrece la oportunidad de trabajar en un entorno dinámico y colaborativo, donde cada día es una nueva oportunidad para aprender y crecer. Únete a nuestro equipo y sé parte de una organización líder en su sector, impulsando la excelencia en la gestión de datos y la toma de decisiones estratégicas.\r\n\r\nFecha de publicación: 10/05/2024\r\nUbicación: Argentina\r\nTipo de Estudio: Tiempo Completo\r\nNúmero de Vacantes: 1 a 10",
                    JobOfferModeId = 1,
                    PublicationDate = DateTime.Parse("10/05/2024"),
                    CityId = 060568,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("1539bb63-c5f2-4a8d-8843-7988d20669ec"),
                    CompanyId = Guid.Parse("ecdb5eda-1cee-4e68-b100-160203158d57"),
                    Title = "Analista Senior de Prevención de Pérdidas",
                    Description = "Como Analista Senior de Prevención de Pérdidas, tu misión será garantizar la seguridad de nuestras instalaciones y envíos, identificando constantemente oportunidades de mejora y fortaleciendo las medidas preventivas necesarias para proteger nuestros activos.\r\n\r\nTus responsabilidades incluirán:\r\n\r\n- Analizar de manera constante la seguridad de nuestras instalaciones y envíos, detectando oportunidades de mejora y eficientizando las medidas preventivas necesarias.\r\n- Efectuar el análisis de zonas y rutas peligrosas, manteniendo actualizado el mapa de situación general en coordinación con el área operativa.\r\n- Realizar la explotación de datos y análisis de incidentes en la cadena para efectuar las recomendaciones o propuestas que mitiguen la consecuencia de los mismos.\r\n- Conducir la revisión permanente de procesos y procedimientos de seguridad, asegurando su adecuación a las mejores prácticas y estándares de la industria.\r\n- Generar las auditorías e informes relacionados con las certificaciones y habilitaciones actuales y futuras, garantizando el cumplimiento de las normativas y regulaciones pertinentes.\r\n- Implementar el plan de capacitación general de seguridad para el personal de la gerencia y de la empresa en su conjunto, promoviendo una cultura de seguridad proactiva y consciente.\r\n- Generar y mantener actualizados planes de gerenciamiento de riesgo en el transporte, identificando y mitigando los riesgos potenciales para nuestras operaciones logísticas.\r\n- Analizar las métricas y su consiguiente explotación para apoyo en la toma de decisiones basadas en análisis de datos, proporcionando información clave para la optimización de nuestras estrategias de seguridad y prevención de pérdidas.\r\n- Participar en la capacitación y concientización de todo el personal de la empresa en lo relacionado con sus funciones, promoviendo la responsabilidad individual y el compromiso con la seguridad y el cumplimiento.\r\n\r\nBuscamos a un profesional altamente analítico y proactivo, con experiencia en seguridad y prevención de pérdidas en entornos logísticos. Valoramos especialmente la capacidad para trabajar de manera autónoma y en equipo, así como la habilidad para comunicarse de manera efectiva con diferentes niveles de la organización.\r\n\r\nÚnete a nuestro equipo y sé parte de una organización líder en su sector, comprometida con la excelencia en seguridad y la protección de nuestros activos.\r\n\r\nFecha de publicación: 09/05/2024\r\nUbicación: Argentina\r\nTipo de Estudio: Tiempo Completo",
                    JobOfferModeId = 1,
                    PublicationDate = DateTime.Parse("09/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("8a1a3ef3-358d-4cc2-8633-dbd57ac52006"),
                    CompanyId = Guid.Parse("d51252c3-6e21-4ffc-aab3-f4bda791a574"),
                    Title = "Business Intelligence Analyst",
                    Description = "Como Business Intelligence Analyst, tendrás la oportunidad de desempeñarte en un rol clave dentro de nuestra organización, contribuyendo al desarrollo de aplicaciones innovadoras y al análisis de datos para la toma de decisiones estratégicas.\r\n\r\nTus responsabilidades incluirán:\r\n\r\n- Desarrollo de aplicaciones en PowerApps, aprovechando la versatilidad y facilidad de uso de esta plataforma para crear soluciones personalizadas que satisfagan las necesidades de nuestros usuarios.\r\n- Descripción de rutinas automatizadas en Power Automate, optimizando procesos y liberando recursos para tareas de mayor valor añadido.\r\n- Mapeo de procesos, interpretación de las necesidades de las partes interesadas y traducción al lenguaje técnico de desarrollo, garantizando una comunicación efectiva y una comprensión clara de los requerimientos del negocio.\r\n- Liderando proyectos locales e internacionales, coordinando equipos multidisciplinarios y asegurando el cumplimiento de los objetivos establecidos.\r\n- Apoyar el liderazgo en el seguimiento y definición de proyectos, colaborando estrechamente con el equipo directivo para garantizar el éxito de las iniciativas estratégicas.\r\n- Desarrollo de aplicaciones híbridas, combinando lo mejor de las tecnologías móviles y web para ofrecer experiencias de usuario optimizadas y accesibles desde cualquier dispositivo.\r\n- Utilización de la plataforma Azure para la integración de datos, aprovechando las capacidades de análisis y almacenamiento en la nube para obtener insights valiosos a partir de grandes volúmenes de información.\r\n- Relación con usuarios clave y liderazgo de proyectos, actuando como punto focal entre el equipo técnico y los stakeholders del negocio para garantizar la alineación de los proyectos con los objetivos estratégicos de la organización.\r\n\r\nBuscamos a un profesional altamente analítico y proactivo, con experiencia en desarrollo de aplicaciones y análisis de datos en entornos empresariales. Valoramos especialmente la capacidad para trabajar de manera autónoma y en equipo, así como la habilidad para comunicarse de manera efectiva con diferentes niveles de la organización.\r\n\r\nÚnete a nuestro equipo y sé parte de una organización líder en su sector, comprometida con la innovación y la excelencia en Business Intelligence.\r\n\r\nFecha de publicación: 10/05/2024\r\nUbicación: Argentina\r\nTipo de Estudio: Tiempo Completo",
                    JobOfferModeId = 1,
                    PublicationDate = DateTime.Parse("10/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("e5acde91-155a-4b5e-a0a1-f081298b1832"),
                    CompanyId = Guid.Parse("d51252c3-6e21-4ffc-aab3-f4bda791a574"),
                    Title = "Compliance Manager",
                    Description = "Liderar la ejecución del programa de Compliance (Gobernanza& Cultura ,Comunicación & Capacitación, Seguimiento & Cierre de brechas) de Región Plata. Desarrollar e implementar los planes de entrenamiento de Compliance, asegurando la realización de las capacitaciones obligatorios de Compliance del mercado. Contribuir a las auditorías internas para identificar áreas de vulnerabilidad y riesgo de Compliance. Apoyar la ejecución de las auditorías C.A.R.E. Gestionar la herramienta SPEAK UP (Canal de denuncias internas de la compañía) y seguimiento de los casos reportados. Liderar el comité de Compliance de Región Plata. Desarrollar iniciativas de prevención de fraude en toda la región y de otras iniciativas de Compliance. Monitorear y auditar el cumplimiento de las políticas y principios globales relacionados con Compliance.\r\nEl Compliance Manager desempeña un papel fundamental en las organizaciones modernas, garantizando que todas las operaciones y prácticas comerciales cumplan con las leyes y regulaciones aplicables. Este rol implica una amplia gama de responsabilidades, que van desde el desarrollo e implementación de políticas y procedimientos hasta la educación y capacitación del personal sobre cuestiones de cumplimiento. Además, el Compliance Manager también supervisa las auditorías internas y externas, identifica áreas de riesgo y vulnerabilidad, y desarrolla estrategias para mitigar esos riesgos. En resumen, el Compliance Manager es responsable de garantizar que la empresa opere de manera ética y legal en todas sus actividades. Al liderar el programa de cumplimiento, el Compliance Manager debe tener un profundo conocimiento de las leyes y regulaciones relevantes, así como una comprensión sólida de los procesos y operaciones comerciales. También debe tener excelentes habilidades de comunicación y capacidad para trabajar en equipo, ya que interactuará con una variedad de departamentos y empleados en toda la organización. La gestión eficaz del cumplimiento requiere una combinación de experiencia técnica y habilidades interpersonales. Los Compliance Managers también deben mantenerse actualizados sobre los cambios en las leyes y regulaciones que puedan afectar a la empresa y ajustar sus políticas y procedimientos en consecuencia. Además, deben estar preparados para responder a denuncias o investigaciones de posibles violaciones de cumplimiento, lo que puede implicar colaborar con abogados internos o externos y agencias reguladoras. En resumen, el papel del Compliance Manager es fundamental para garantizar la integridad y el éxito a largo plazo de una organización. Es un puesto desafiante pero gratificante que requiere un alto nivel de compromiso y ética profesional.",
                    JobOfferModeId = 1,
                    PublicationDate = DateTime.Parse("06/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                    Vacancies = 5
                },
                new Offer
                {
                    OfferId = Guid.Parse("5e7f9ee4-0e9e-4bc2-b64d-5ef6e2ad207e"),
                    CompanyId = Guid.Parse("d51252c3-6e21-4ffc-aab3-f4bda791a574"),
                    Title = "Especialista SHE",
                    Description = "Definir, validar e implementar la estrategia de SHE (Salud, Seguridad y Medio Ambiente) para el sitio con la finalidad de garantizar que los sitios cuentan con las condiciones seguras para ser operados y mantener una cultura en materia de seguridad para evitar los accidentes en sitio a través de auditorías y recorridos en piso.\r\nEl Especialista SHE desempeña un papel crucial en la gestión de la salud, seguridad y medio ambiente en el lugar de trabajo. Su principal responsabilidad es garantizar que el sitio cumpla con todos los requisitos legales y reglamentarios en materia de seguridad y salud ocupacional. Esto implica desarrollar, implementar y mantener programas y procedimientos de seguridad para prevenir accidentes y lesiones en el lugar de trabajo.\r\nAdemás, el Especialista SHE también se encarga de realizar inspecciones y auditorías periódicas para identificar posibles riesgos y áreas de mejora en el sitio. Estas inspecciones pueden incluir la evaluación de equipos de protección personal, la revisión de procedimientos de emergencia y la identificación de peligros potenciales en el entorno laboral.\r\nEl Especialista SHE trabaja en estrecha colaboración con el personal de operaciones y otros departamentos para promover una cultura de seguridad en toda la organización. Esto puede implicar la organización de sesiones de capacitación sobre seguridad, la distribución de materiales educativos y la implementación de programas de reconocimiento para recompensar el comportamiento seguro.\r\nAdemás de su enfoque en la seguridad en el lugar de trabajo, el Especialista SHE también se preocupa por el impacto ambiental de las operaciones de la empresa. Esto puede incluir la implementación de prácticas de gestión ambiental sostenible, la supervisión del manejo de residuos y la reducción del consumo de recursos naturales.\r\nEn resumen, el Especialista SHE juega un papel integral en la protección de la salud y seguridad de los empleados, así como en la preservación del medio ambiente en el lugar de trabajo. Es un puesto desafiante que requiere un profundo conocimiento de las regulaciones de seguridad y salud ocupacional, así como excelentes habilidades de comunicación y capacidad para trabajar en equipo.",
                    JobOfferModeId = 1,
                    PublicationDate = DateTime.Parse("06/05/2024"),
                    CityId = 820147,
                    StudyTypeId = 4,
                    Vacancies = 3
                },
                new Offer
                {
                    OfferId = Guid.Parse("a8b52b4f-025d-4d48-82c1-990fbbdbb369"),
                    CompanyId = Guid.Parse("925b2ab6-5a03-40a7-891e-7bb594086e61"),
                    Title = "Mecánico Automotriz",
                    Description = "Experiencia comprobable en mecánica general, tren delantero, frenos, embragues, cambio de correas de distribución, diagnóstico y resolución de fallas eléctricas, mantenimiento preventivo, manejo de scanner. Sólidos conocimientos en mecánica y electricidad automotriz. Conocimientos en: Paquete Office. (Nivel Medio: Excel, Word, Outlook, PowerPoint)\r\nResidir en Capital Federal. Secundario Técnico Mecánico. Flexibilidad horaria. Buscamos perfiles proactivo con iniciativa, capacidad para trabajar en equipo y administrar el tiempo de su jornada laboral, con predisposición para las emergencias, examinar los vehículos para detectar e informar otro problema.\r\nRequisito General no Excluyente: Licencia de conducir. El Mecánico Automotriz es un profesional altamente capacitado en el mantenimiento y reparación de vehículos automotores. Su trabajo es esencial para garantizar el funcionamiento seguro y eficiente de los automóviles, camiones y otros vehículos de motor. Los mecánicos automotrices realizan una variedad de tareas, que van desde la solución de problemas y diagnóstico de fallas hasta la reparación y reemplazo de piezas defectuosas. Esto puede incluir la reparación de motores, sistemas de transmisión, sistemas de frenos, sistemas de dirección y suspensión, sistemas eléctricos y electrónicos, entre otros. Además de su habilidad técnica, los mecánicos automotrices también deben tener un buen conocimiento de la teoría de funcionamiento de los vehículos y estar al tanto de las últimas tecnologías y tendencias en la industria automotriz. Esto les permite realizar diagnósticos precisos y realizar reparaciones eficientes utilizando las herramientas y técnicas más avanzadas disponibles. Los mecánicos automotrices pueden trabajar en una variedad de entornos, que van desde talleres de reparación independientes hasta concesionarios de automóviles y flotas comerciales. Independientemente del entorno de trabajo, los mecánicos automotrices deben seguir estrictas normas de seguridad y procedimientos de trabajo para garantizar su propia seguridad y la seguridad de sus colegas y clientes. Además de las habilidades técnicas, los mecánicos automotrices también deben tener buenas habilidades de comunicación y servicio al cliente. Esto les permite interactuar efectivamente con los clientes para entender sus necesidades y explicar los problemas y soluciones de manera clara y comprensible. En resumen, el trabajo de un mecánico automotriz es fundamental para mantener en funcionamiento los vehículos que dependemos en nuestra vida diaria. Es un trabajo exigente pero gratificante que ofrece oportunidades para el crecimiento profesional y personal.",
                    JobOfferModeId = 1,
                    PublicationDate = DateTime.Parse("11/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 2,
                    Vacancies = 5
                },
                new Offer
                {
                    OfferId = Guid.Parse("1b1d2d29-62c2-4ae3-bbfc-6a17514fc77d"),
                    CompanyId = Guid.Parse("925b2ab6-5a03-40a7-891e-7bb594086e61"),
                    Title = "Jefe de Seguridad e Higiene",
                    Description = "El profesional que ocupe esta posición deberá tener a su cargo la gestión del área de higiene y seguridad. Será responsable de implementar y supervisar las políticas y procedimientos de seguridad en el lugar de trabajo, así como de garantizar el cumplimiento de las regulaciones y normativas pertinentes. Además, será responsable de liderar y coordinar el equipo de seguridad e higiene, brindando orientación y apoyo para promover un entorno de trabajo seguro y saludable para todos los empleados.\r\n\r\nEntre las responsabilidades específicas de este puesto se incluyen:\r\n\r\n- Desarrollar, implementar y mantener programas y procedimientos de seguridad y salud ocupacional para identificar, evaluar y controlar los riesgos en el lugar de trabajo.\r\n\r\n- Realizar inspecciones regulares de seguridad para identificar posibles peligros y áreas de mejora, y tomar medidas correctivas según sea necesario.\r\n\r\n- Investigar accidentes, incidentes y enfermedades relacionadas con el trabajo para determinar las causas subyacentes y desarrollar estrategias para prevenir futuros incidentes.\r\n\r\n- Coordinar la formación en seguridad para todos los empleados, incluida la capacitación en procedimientos de emergencia y el uso seguro de equipos y herramientas.\r\n\r\n- Mantener registros precisos de incidentes, investigaciones y acciones correctivas, y preparar informes periódicos sobre el rendimiento del programa de seguridad y salud ocupacional.\r\n\r\n- Colaborar con otros departamentos para garantizar el cumplimiento de las normas y regulaciones aplicables, así como para promover una cultura de seguridad en toda la organización.\r\n\r\n- Mantenerse al día con las tendencias y desarrollos en el campo de la seguridad y la salud ocupacional, y recomendar medidas proactivas para mejorar continuamente los programas y prácticas existentes.\r\n\r\nEl candidato ideal para este puesto tendrá una sólida formación en seguridad e higiene ocupacional, así como experiencia previa en la gestión de programas de seguridad en el lugar de trabajo. Deberá poseer excelentes habilidades de comunicación y liderazgo, así como la capacidad de trabajar de manera efectiva tanto de forma independiente como en equipo.\r\n\r\nSe valorará positivamente la posesión de certificaciones relevantes en seguridad y salud ocupacional, así como la experiencia previa en la implementación de sistemas de gestión de la seguridad, como OHSAS 18001 o ISO 45001.\r\n\r\nEn resumen, este puesto ofrece una oportunidad emocionante para un profesional apasionado por la seguridad y la salud ocupacional para asumir un papel de liderazgo en una organización dedicada a promover un entorno de trabajo seguro y saludable para todos sus empleados.\r\n\r\nSi está interesado en postularse para esta posición, por favor envíe su currículum actualizado junto con una carta de presentación que destaque su experiencia relevante y sus motivaciones para unirse a nuestro equipo. Estamos buscando a un líder en seguridad comprometido con la excelencia y la mejora continua, y esperamos recibir su solicitud.\r\n",
                    JobOfferModeId = 1,
                    PublicationDate = DateTime.Parse("09/05/2024"),
                    CityId = 060260,
                    StudyTypeId = 3,
                },
                new Offer
                {
                    OfferId = Guid.Parse("c2b9a7cb-8b3d-496f-80df-93f1928ef9d0"),
                    CompanyId = Guid.Parse("925b2ab6-5a03-40a7-891e-7bb594086e61"),
                    Title = "Gerente de Mantenimiento (Planta Frigorífica)",
                    Description = "Gestión integral del mantenimiento de la planta.\r\nCoordinación de los sectores de mantenimiento: Electricidad, Refrigeración, Maquinas y Medios de Elevación.\r\nDesarrollo de un modelo de mantenimiento para poder dar servicio a todas las dependencias de la planta frigorífica.\r\nLiderar la gestión operativa cumpliendo con los planes de mantenimiento.\r\nDesarrollo de gestión de proyectos en relación a las diferentes áreas de mantenimiento.\r\n\r\nComo gerente de mantenimiento de una planta frigorífica, serás responsable de supervisar y dirigir todas las actividades relacionadas con el mantenimiento y la operación eficiente de la planta. Tu papel será fundamental para garantizar que todos los equipos y sistemas de la planta funcionen correctamente, minimizando el tiempo de inactividad y maximizando la productividad.\r\n\r\nUna de tus principales responsabilidades será gestionar integralmente el mantenimiento de la planta. Esto implicará coordinar los diferentes sectores de mantenimiento, como electricidad, refrigeración, maquinaria y medios de elevación, para garantizar un funcionamiento óptimo de todas las instalaciones.\r\n\r\nAdemás, deberás desarrollar un modelo de mantenimiento que permita dar servicio a todas las dependencias de la planta frigorífica. Esto incluirá la implementación de programas de mantenimiento preventivo y predictivo, así como la realización de inspecciones regulares para identificar y corregir posibles problemas antes de que se conviertan en fallas importantes.\r\n\r\nComo parte de tu función, también liderarás la gestión operativa de la planta, asegurándote de que se cumplan los planes de mantenimiento establecidos y de que se implementen las mejores prácticas en términos de seguridad y calidad.\r\n\r\nOtra de tus responsabilidades será el desarrollo y la gestión de proyectos en relación con las diferentes áreas de mantenimiento. Esto puede implicar la implementación de nuevas tecnologías o sistemas, la mejora de los procesos existentes o la optimización de la utilización de los recursos disponibles.\r\n\r\nPara tener éxito en este rol, es esencial contar con una sólida formación técnica en áreas relacionadas con el mantenimiento industrial, así como con experiencia previa en posiciones de liderazgo en entornos de producción o manufactura. Además, se valorará la capacidad para trabajar bajo presión, tomar decisiones informadas y resolver problemas de manera eficaz.\r\n\r\nEn resumen, como gerente de mantenimiento de una planta frigorífica, desempeñarás un papel clave en la optimización del funcionamiento de la planta, asegurando su eficiencia operativa y contribuyendo al logro de los objetivos organizacionales. Serás responsable de liderar equipos de trabajo, implementar estrategias de mantenimiento efectivas y garantizar el cumplimiento de los estándares de calidad y seguridad. Si te apasiona el desafío de trabajar en un entorno dinámico y exigente, este puesto puede ser la oportunidad que estás buscando para desarrollar tu carrera profesional y contribuir al éxito de la empresa.\r\n",
                    JobOfferModeId = 1,
                    PublicationDate = DateTime.Parse("10/05/2024"),
                    CityId = 820147,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("1e40e017-20b7-4b5c-af8f-9b4f62e80a5d"),
                    CompanyId = Guid.Parse("925b2ab6-5a03-40a7-891e-7bb594086e61"),
                    Title = "Comprador No Alimentos",
                    Description = "Asistir al comprador de área para que juntos definan la estrategia comercial del sector.\r\n" +
                  "Cargar los productos a publicar negociados por el comprador a cargo.\r\n" +
                  "Analizar los distintos escenarios en base a las oportunidades de nuevos negocios que se pueden presentar.\r\n" +
                  "Generar reportes de los avances de ventas, margen y unidades.\r\n" +
                  "Controlar las entregas semanales de proveedores ya sea en nuestro Centro Logístico o en las sucursales.\r\n" +
                  "Controlar la eficiencia de los repositores externos de los proveedores para corregir los desvíos.\r\n" +
                  "Analizar los faltantes de productos donde deberá hacer un seguimiento junto con los proveedores para mejorar dicha ratio. " +
                  "El comprador de no alimentos es un puesto clave dentro de la organización, encargado de gestionar y optimizar la adquisición de productos no alimentarios para su posterior comercialización. Este rol implica una serie de responsabilidades y tareas fundamentales para el éxito de la empresa.\r\n" +
                  "En primer lugar, el comprador de no alimentos colabora estrechamente con el comprador de área para definir la estrategia comercial del sector. Esto implica analizar el mercado, identificar tendencias, establecer objetivos y desarrollar planes de acción para alcanzar los resultados deseados. La capacidad de trabajar en equipo y comunicarse eficazmente son habilidades esenciales para desempeñar esta función de manera efectiva.\r\n" +
                  "Una vez definida la estrategia, el comprador de no alimentos es responsable de cargar los productos negociados por el comprador a cargo en el sistema. Esto requiere un seguimiento meticuloso de los acuerdos comerciales y una atención constante a los cambios en las condiciones del mercado. La capacidad de análisis y la atención al detalle son cruciales para garantizar la precisión y la integridad de la información registrada.\r\n" +
                  "Además de la carga de productos, el comprador de no alimentos debe estar preparado para analizar diferentes escenarios en función de las oportunidades de nuevos negocios que puedan surgir. Esto implica evaluar el rendimiento de productos existentes, identificar áreas de mejora y explorar nuevas líneas de productos que puedan impulsar el crecimiento y la rentabilidad del negocio. La capacidad de tomar decisiones informadas y adaptarse rápidamente a los cambios en el entorno comercial son habilidades críticas en este aspecto del rol.\r\n" +
                  "Otra responsabilidad clave del comprador de no alimentos es generar reportes periódicos sobre los avances de ventas, margen y unidades. Estos informes proporcionan información valiosa sobre el rendimiento del negocio y ayudan a guiar la toma de decisiones estratégicas. La capacidad de análisis de datos y la habilidad para comunicar eficazmente los resultados son habilidades importantes en este aspecto del rol.\r\n" +
                  "Además de los reportes de ventas, el comprador de no alimentos también es responsable de controlar las entregas semanales de proveedores. Esto implica coordinar con el equipo de logística para garantizar que los productos lleguen a tiempo y en condiciones óptimas. La capacidad de gestionar múltiples tareas y prioridades simultáneamente es esencial para cumplir con este aspecto del rol de manera efectiva.\r\n" +
                  "Otro aspecto importante del rol es controlar la eficiencia de los repositores externos de los proveedores. Esto implica monitorear el desempeño de los repositores en términos de precisión, puntualidad y calidad del trabajo realizado. La capacidad de identificar y abordar los problemas de manera proactiva es esencial para garantizar un flujo de productos eficiente y sin problemas.\r\n" +
                  "Finalmente, el comprador de no alimentos también es responsable de analizar los faltantes de productos y tomar medidas correctivas según sea necesario. Esto implica trabajar en estrecha colaboración con los proveedores para identificar las causas subyacentes de los faltantes y desarrollar soluciones efectivas para mitigarlos. La capacidad de resolver problemas de manera creativa y colaborativa es esencial para tener éxito en este aspecto del rol.\r\n" +
                  "En resumen, el comprador de no alimentos es un rol multifacético que requiere una combinación única de habilidades y competencias. Desde la definición de estrategias comerciales hasta el seguimiento de entregas de proveedores, este rol desempeña un papel fundamental en el éxito y la rentabilidad del negocio. Con la capacidad de análisis, la atención al detalle y la capacidad de colaborar efectivamente con otros equipos, el comprador de no alimentos está bien posicionado para hacer una contribución significativa al éxito de la empresa.\r\n",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("10/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("34ec9f13-279d-4453-98a8-1a0831e9e90d"),
                    CompanyId = Guid.Parse("9d8b9e84-33a7-4c28-a6c0-5941a68f1968"),
                    Title = "Administrativo de correo",
                    Description = "Proveer a las tiendas del material promocional de vidrieras, actas de altas y bajas y demas carteleria. \r\n" +
                  "Recepcionar los pedidos de insumos necesarios para las tiendas. \r\n" +
                  "Controlar y direccionar el envio de la información a las tiendas. \r\n" +
                  "Gestionar stock y mantenimiento de formularios de tiendas. \r\n" +
                  "Realizar impresión y el abastecimiento de plano gramas. \r\n" +
                  "El puesto de Administrativo de Correo implica tareas administrativas fundamentales en el contexto de las operaciones de las tiendas. Desde la provisión de material promocional hasta la gestión del stock y el mantenimiento de formularios, este rol desempeña un papel crucial en garantizar la eficiencia y el flujo adecuado de información en la organización.\r\n" +
                  "Una de las responsabilidades clave del administrativo de correo es abastecer a las tiendas con el material promocional necesario para las vidrieras. Esto incluye la entrega de actas de altas y bajas, carteles y otros elementos visuales que contribuyen a la presentación de la tienda y promueven productos y ofertas. Además, el administrativo de correo es responsable de recibir y procesar los pedidos de insumos de las tiendas, asegurando que cuenten con los recursos necesarios para operar de manera eficiente.\r\n" +
                  "Otra función importante es controlar y dirigir el envío de información a las tiendas. Esto implica garantizar que la información relevante, como comunicados internos, directivas y actualizaciones de políticas, se distribuya de manera oportuna y llegue a las manos adecuadas en cada tienda. Esta tarea requiere un alto nivel de organización y atención al detalle para garantizar que la comunicación interna sea clara y efectiva.\r\n" +
                  "La gestión del stock y el mantenimiento de los formularios de las tiendas también son responsabilidades clave del administrativo de correo. Esto implica realizar un seguimiento de los niveles de inventario, realizar pedidos cuando sea necesario y asegurarse de que los formularios y documentos necesarios estén disponibles en todo momento. Mantener un stock adecuado y asegurar que los formularios estén actualizados y sean accesibles es esencial para garantizar que las operaciones de la tienda se desarrollen sin problemas.\r\n" +
                  "Además de estas responsabilidades, el administrativo de correo también puede ser responsable de realizar impresiones y abastecer plano gramas. Esto puede implicar la preparación de materiales de marketing, informes internos y otros documentos impresos según sea necesario para apoyar las operaciones de la tienda y las iniciativas corporativas.\r\n",
                    JobOfferModeId = 1,
                    PublicationDate = DateTime.Parse("09/05/2024"),
                    CityId = 060861,
                    StudyTypeId = 2,
                },
                new Offer
                {
                    OfferId = Guid.Parse("c2d5c7d4-97df-4c9d-b292-515a0dbd25a5"),
                    CompanyId = Guid.Parse("9d8b9e84-33a7-4c28-a6c0-5941a68f1968"),
                    Title = "Líder de Tienda",
                    Description = "Liderar el equipo de trabajo a su cargo. \r\nLlevar adelante la implementación de las mejoras, estableciendo vínculos adecuados con todas las áreas intervinientes. \r\nControl de la gestión administrativa y operativa de la tienda\r\nControl de rectificaciones, ingreso y egreso de proveedores \r\n" +
                    "El líder de tienda es una figura clave dentro de la estructura de una tienda. Su rol principal es garantizar que la tienda funcione de manera eficiente y rentable, supervisando todas las operaciones diarias y liderando al equipo de trabajo.\r\n" +
                    "Una de las responsabilidades más importantes del líder de tienda es liderar y motivar al equipo. Esto implica establecer metas claras, proporcionar retroalimentación regular y asegurarse de que todos los miembros del equipo estén capacitados y motivados para alcanzar el éxito.\r\n" +
                    "Además de liderar al equipo, el líder de tienda también es responsable de garantizar que la tienda cumpla con los estándares de calidad y servicio al cliente. Esto incluye garantizar que la tienda esté limpia y ordenada, que los productos estén correctamente etiquetados y que se cumplan todas las regulaciones y normativas pertinentes.\r\n" +
                    "Otra parte importante del rol del líder de tienda es la gestión de inventario y suministros. Esto implica realizar un seguimiento de las existencias, realizar pedidos de reposición cuando sea necesario y garantizar que los productos estén siempre disponibles para los clientes.\r\n" +
                    "El líder de tienda también juega un papel clave en la gestión de las finanzas de la tienda. Esto incluye la elaboración de presupuestos, la supervisión de los gastos y la garantía de que la tienda alcance sus objetivos de ventas y rentabilidad.\r\n" +
                    "Además de estas responsabilidades operativas, el líder de tienda también es responsable de gestionar las relaciones con los clientes. Esto implica garantizar un excelente servicio al cliente en todo momento y abordar cualquier problema o queja de manera rápida y efectiva.\r\n" +
                    "Para ser un líder de tienda exitoso, se requiere una combinación única de habilidades y atributos. Esto incluye una fuerte ética de trabajo, excelentes habilidades de comunicación, capacidad para trabajar bajo presión y tomar decisiones difíciles, y una pasión por el servicio al cliente y la venta minorista.\r\n" +
                    "En resumen, el líder de tienda es una figura clave dentro de una tienda minorista, responsable de garantizar que la tienda funcione de manera eficiente y rentable, liderando al equipo de trabajo, garantizando un excelente servicio al cliente y cumpliendo con todos los estándares de calidad y regulaciones pertinentes.\r\n",
                    JobOfferModeId = 1,
                    PublicationDate = DateTime.Parse("10/05/2024"),
                    CityId = 060218,
                    StudyTypeId = 2,
                },
                new Offer
                {
                    OfferId = Guid.Parse("b7f364c3-b50c-4ea0-bb24-6f6ddbf64d69"),
                    CompanyId = Guid.Parse("9d8b9e84-33a7-4c28-a6c0-5941a68f1968"),
                    Title = "Supervisor Almacén",
                    Description = "Control de KPI'S y generación de planes de acción.\r\nGestión de personal dentro de convenio camioneros y su progreso en áreas productivas.\r\nControl de calidad de pedidos e incidencias del almacén según procedimientos establecidos.\r\nAnálisis de datos y manejo de herramientas informáticas (As400, Excel, Querry).\r\n" +
                    "El Supervisor de Almacén es una posición clave en el ámbito de la gestión logística y el almacenamiento de mercancías. Este rol implica la supervisión y coordinación de diversas actividades relacionadas con la recepción, almacenamiento y envío de productos en un almacén o depósito. La persona en este puesto es responsable de garantizar que todas las operaciones se realicen de manera eficiente, segura y en cumplimiento con los estándares de calidad establecidos.\r\n\r\n" +
                    "Las responsabilidades del Supervisor de Almacén pueden variar según el tipo y tamaño del almacén, así como las necesidades específicas de la empresa. Sin embargo, algunas de las funciones comunes incluyen:\r\n" +
                    "1. Control de KPI'S: Los KPI'S (Indicadores Clave de Rendimiento) son métricas utilizadas para medir el desempeño y la eficiencia del almacén. El Supervisor de Almacén es responsable de monitorear estos indicadores y tomar medidas correctivas cuando sea necesario para garantizar el cumplimiento de los objetivos operativos y financieros.\r\n" +
                    "2. Generación de planes de acción: En base a los resultados obtenidos de la evaluación de los KPI'S, el Supervisor de Almacén debe desarrollar planes de acción para abordar cualquier desviación o área de mejora identificada. Estos planes pueden incluir cambios en los procesos, capacitación del personal, inversión en tecnología, entre otros.\r\n" +
                    "3. Gestión de personal: El Supervisor de Almacén es responsable de liderar y supervisar al equipo de trabajo asignado al almacén. Esto incluye la asignación de tareas, la capacitación del personal, la resolución de conflictos y la evaluación del desempeño.\r\n" +
                    "4. Control de calidad: Garantizar que todos los productos almacenados en el almacén cumplan con los estándares de calidad establecidos es una parte fundamental del rol del Supervisor de Almacén. Esto implica realizar inspecciones regulares, identificar y corregir posibles problemas de calidad, y mantener registros precisos de las incidencias.\r\n" +
                    "5. Análisis de datos: El Supervisor de Almacén debe ser capaz de analizar grandes volúmenes de datos relacionados con las operaciones del almacén y utilizar esta información para tomar decisiones informadas. Esto puede incluir la identificación de tendencias, la detección de patrones, y la generación de informes para la alta dirección.\r\n" +
                    "6. Manejo de herramientas informáticas: En el entorno moderno de los almacenes, el uso de herramientas informáticas es fundamental para optimizar las operaciones. El Supervisor de Almacén debe tener habilidades sólidas en el manejo de software especializado, como sistemas de gestión de almacenes (WMS), hojas de cálculo (Excel), y sistemas de base de datos (Querry).\r\n" +
                    "El Supervisor de Almacén debe poseer habilidades de liderazgo sólidas, una capacidad demostrada para trabajar bajo presión, y excelentes habilidades de comunicación. También se valorará la capacidad para resolver problemas de manera creativa, trabajar en equipo, y adaptarse a un entorno de trabajo dinámico y cambiante.\r\n" +
                    "Si te apasiona la logística y estás buscando una oportunidad para crecer y desarrollarte profesionalmente en este campo, el puesto de Supervisor de Almacén puede ser el adecuado para ti. Únete a nuestro equipo y contribuye al éxito de nuestra empresa mediante la optimización de nuestras operaciones de almacenamiento y distribución.\r\n",
                    JobOfferModeId = 1,
                    PublicationDate = DateTime.Parse("10/05/2024"),
                    CityId = 060515,
                    StudyTypeId = 2,
                },
                new Offer
                {
                    OfferId = Guid.Parse("cba5b59e-76f1-495a-9a6b-3a6d9b55f119"),
                    CompanyId = Guid.Parse("09260ec0-0368-4da8-80d5-6e8b9c574920"),
                    Title = "CloudOps Engineer SR",
                    Description = "Desarrollar Tools para CI/CD como Gitlab, Azure DEvOps o Jenkins.\r\nDesarrollar métricas DevOps, Engineering e indicadores de gestión.\r\nColaborar con equipos Cross/Funcionales para lograr delivery de productos de calidad.\r\nColaborar con implementación de buenas prácticas (CAF AWS, AZURE). La posición de Ingeniero CloudOps SR implica trabajar en estrecha colaboración con equipos multifuncionales para desarrollar y mantener la infraestructura de la nube y las operaciones de TI.\r\n" +
                    "En este papel, tendrá la oportunidad de liderar y contribuir a proyectos clave que impulsan la innovación y el crecimiento empresarial. Su experiencia y habilidades serán fundamentales para el éxito de nuestro equipo y la entrega de soluciones técnicas de clase mundial a nuestros clientes.\r\n" +
                    "El Ingeniero CloudOps SR es responsable de diseñar, implementar y mantener soluciones de infraestructura de nube escalables, seguras y de alto rendimiento. Trabajará en estrecha colaboración con arquitectos de soluciones, desarrolladores de software, equipos de seguridad y operaciones para garantizar la integridad y el rendimiento de nuestros sistemas en la nube.\r\n" +
                    "Las responsabilidades principales incluyen:\r\n" +
                    "- Diseñar e implementar arquitecturas de infraestructura de nube utilizando las mejores prácticas de la industria.\r\n" +
                    "- Desarrollar y mantener scripts de automatización para aprovisionar, configurar y gestionar recursos de nube.\r\n" +
                    "- Supervisar y optimizar el rendimiento de los sistemas en la nube para garantizar la disponibilidad y la capacidad de respuesta.\r\n" +
                    "- Colaborar con equipos multifuncionales para diseñar e implementar soluciones de seguridad de la nube que protejan los datos y los activos empresariales.\r\n" +
                    "- Gestionar la configuración y el cumplimiento de las políticas de seguridad y cumplimiento de la nube.\r\n" +
                    "- Participar en la planificación y ejecución de proyectos de migración a la nube y modernización de aplicaciones.\r\n" +
                    "- Investigar y evaluar nuevas tecnologías y herramientas de nube para mejorar la eficiencia y la eficacia de nuestras operaciones.\r\n" +
                    "El candidato ideal para esta posición tendrá experiencia y habilidades en las siguientes áreas:\r\n" +
                    "- Experiencia en diseño, implementación y administración de infraestructura de nube en plataformas como AWS, Azure o Google Cloud Platform.\r\n" +
                    "- Conocimientos profundos de los servicios de nube como computación, almacenamiento, redes, bases de datos, seguridad y gestión.\r\n" +
                    "- Experiencia en scripting y automatización utilizando herramientas como PowerShell, Python, Bash o Terraform.\r\n" +
                    "- Conocimientos de seguridad de la nube y prácticas recomendadas, incluyendo IAM, cifrado, seguridad de red y gestión de identidades y accesos.\r\n" +
                    "- Habilidades de resolución de problemas y capacidad para diagnosticar y solucionar problemas de infraestructura de nube en entornos de producción.\r\n" +
                    "- Fuertes habilidades de comunicación y capacidad para trabajar de manera efectiva con equipos distribuidos globalmente.\r\n" +
                    "- Certificaciones en plataformas de nube como AWS Certified Solutions Architect, Microsoft Certified Azure Solutions Architect o Google Cloud Certified Architect son una ventaja.\r\n" +
                    "En resumen, la posición de Ingeniero CloudOps SR es una oportunidad emocionante para un profesional de la tecnología apasionado por la nube y las operaciones de TI. Si está buscando un desafío gratificante en un entorno dinámico y colaborativo, ¡nos encantaría saber de usted!\r\n",
                    JobOfferModeId = 3,
                    PublicationDate = DateTime.Parse("06/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("ef768f5e-bfb2-4b5a-8595-2875a45cb23f"),
                    CompanyId = Guid.Parse("09260ec0-0368-4da8-80d5-6e8b9c574920"),
                    Title = "Staff Engineer Node.js",
                    Description = "Hacer propuestas de soluciones con diseños técnicos simples, mantenibles, escalables y resilientes. Ser embajador/a de buenas prácticas y la calidad de las soluciones.\r\n" +
                    "Como Staff Engineer Node.js, tendrás la oportunidad de liderar el diseño y desarrollo de aplicaciones utilizando Node.js y otras tecnologías de vanguardia. Trabajarás en un entorno dinámico y colaborativo donde podrás poner a prueba tus habilidades técnicas y contribuir al éxito del equipo y la empresa.\r\n" +
                    "Nuestras soluciones se utilizan en una variedad de industrias, desde finanzas hasta salud, y requieren un enfoque meticuloso para garantizar la escalabilidad, la seguridad y el rendimiento. Como parte de nuestro equipo de ingeniería, tendrás la oportunidad de trabajar en proyectos emocionantes que están en la vanguardia de la innovación tecnológica.\r\n" +
                    "Responsabilidades del puesto:\r\n" +
                    "- Diseñar y desarrollar aplicaciones backend utilizando Node.js y otros marcos de trabajo relacionados.\r\n" +
                    "- Colaborar con equipos multifuncionales para comprender los requisitos del negocio y traducirlos en soluciones técnicas efectivas.\r\n" +
                    "- Desarrollar y mantener código limpio y bien documentado que cumpla con los estándares de calidad y las mejores prácticas de ingeniería.\r\n" +
                    "- Realizar pruebas unitarias y de integración para garantizar la fiabilidad y la estabilidad de las aplicaciones.\r\n" +
                    "- Investigar nuevas tecnologías y metodologías para mejorar continuamente nuestros procesos de desarrollo y entrega.\r\n" +
                    "- Colaborar con equipos de operaciones para implementar y mantener soluciones en entornos de producción.\r\n" +
                    "- Participar en revisiones de código y proporcionar retroalimentación constructiva a otros miembros del equipo.\r\n" +
                    "Requisitos del puesto:\r\n" +
                    "- Experiencia previa trabajando como ingeniero de software o desarrollador backend, preferiblemente con enfoque en Node.js.\r\n" +
                    "- Conocimiento sólido de los principios de programación orientada a objetos y diseño de software.\r\n" +
                    "- Experiencia con bases de datos relacionales y no relacionales, como MySQL, MongoDB, etc.\r\n" +
                    "- Familiaridad con el desarrollo de API RESTful y servicios web.\r\n" +
                    "- Habilidades sólidas de resolución de problemas y capacidad para trabajar de forma independiente y en equipo.\r\n" +
                    "- Excelentes habilidades de comunicación verbal y escrita en español e inglés.\r\n" +
                    "- Capacidad para aprender y adaptarse rápidamente a nuevas tecnologías y entornos.\r\n" +
                    "- Experiencia trabajando en entornos ágiles y utilizando herramientas como Git, Jira, etc.\r\n" +
                    "En esta posición, tendrás la oportunidad de contribuir significativamente al éxito de nuestro equipo de ingeniería y ayudar a impulsar la innovación en nuestra empresa. Ofrecemos un entorno de trabajo dinámico y desafiante, oportunidades de desarrollo profesional y un paquete de beneficios competitivo.\r\n" +
                    "Si estás buscando un nuevo desafío emocionante en el campo del desarrollo de software y tienes las habilidades y la experiencia necesarias, ¡queremos saber de ti! ¡Únete a nuestro equipo hoy mismo y sé parte de nuestra misión de crear soluciones tecnológicas innovadoras que cambien el mundo!\r\n",
                    JobOfferModeId = 3,
                    PublicationDate = DateTime.Parse("08/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },

                new Offer
                {
                    OfferId = Guid.Parse("3b15b056-2b44-4225-80ad-446252fd6864"),
                    CompanyId = Guid.Parse("09260ec0-0368-4da8-80d5-6e8b9c574920"),
                    Title = "Node.JS Software Engineer SR",
                    Description = "Diseñar y crear desarrollos desde cero con tecnologías Cloud.\r\nTrabajar en equipos multidisciplinarios, participando del diseño de nuevos productos bajo metodología scrum.\r\nColaborar activamente con el equipo de arquitectura en las definiciones de tecnología.\r\nIdentificar y brindar soluciones a problemas complejos velando por la calidad del código.\r\n\r\nEn el mundo actual de la tecnología, las empresas están recurriendo cada vez más a soluciones basadas en la nube para satisfacer sus necesidades de infraestructura, almacenamiento de datos y desarrollo de software. Como ingeniero de software Node.JS Senior, tendrás la emocionante oportunidad de formar parte de este emocionante viaje hacia la nube y contribuir al desarrollo de soluciones innovadoras para resolver problemas empresariales complejos.\r\n\r\nComo parte de tu papel, tendrás la responsabilidad de diseñar y crear desarrollos desde cero utilizando tecnologías Cloud. Esto implica trabajar en estrecha colaboración con equipos multidisciplinarios, participando en el diseño de nuevos productos bajo la metodología scrum. Tu experiencia y conocimientos serán fundamentales para identificar y brindar soluciones a problemas complejos, velando siempre por la calidad del código.\r\n\r\nLa agilidad y la capacidad de adaptación son aspectos clave de este puesto. Trabajarás en un entorno dinámico y colaborativo, donde cada día presenta nuevos desafíos y oportunidades de aprendizaje. Tu capacidad para colaborar activamente con el equipo de arquitectura en la definición de tecnologías será fundamental para el éxito de los proyectos.\r\n\r\nAdemás de tus habilidades técnicas, se espera que demuestres un fuerte compromiso con la calidad y la excelencia en todo lo que hagas. La capacidad para trabajar de manera independiente y en equipo, así como la habilidad para comunicarte eficazmente con colegas y clientes, serán aspectos críticos de tu desempeño en este rol.\r\n\r\nEste puesto es ideal para alguien que disfruta de un desafío y está buscando crecer y desarrollarse profesionalmente en un entorno estimulante y gratificante. Si estás listo para unirte a un equipo apasionado y motivado y contribuir al desarrollo de soluciones innovadoras en la nube, esta podría ser la oportunidad perfecta para ti.\r\n\r\nLa fecha de publicación de esta oferta es el 08/05/2024, y está dirigida a personas que residan en la ciudad con el código 022007 y que tengan el tipo de estudio 4.\r\n\r\nNo pierdas la oportunidad de formar parte de un equipo dinámico y colaborativo en el emocionante campo del desarrollo de software basado en la nube. Aplica ahora y comienza tu viaje hacia una carrera gratificante y llena de posibilidades en el mundo de la tecnología.\r\n\r\nEn este puesto, tendrás la oportunidad de trabajar con las últimas tecnologías y herramientas disponibles en la industria. Esto incluye el uso de plataformas de desarrollo en la nube, frameworks de Node.JS y otras tecnologías de vanguardia. Tendrás acceso a recursos y herramientas que te permitirán crear soluciones innovadoras y eficientes para nuestros clientes.\r\n\r\nComo parte de tu rol, también tendrás la oportunidad de participar en programas de capacitación y desarrollo profesional. La empresa valora el crecimiento y desarrollo de sus empleados y ofrece una variedad de oportunidades de formación y desarrollo para ayudarte a mejorar tus habilidades y avanzar en tu carrera.\r\n\r\nAdemás, trabajarás en un entorno que fomenta la creatividad y la innovación. Se te animará a pensar de manera crítica y a proponer nuevas ideas y enfoques para resolver problemas. Tu capacidad para innovar y tu disposición para desafiar el status quo serán aspectos clave de tu éxito en este puesto.\r\n\r\nLa colaboración es otro aspecto importante de este rol. Trabajarás con un equipo diverso de profesionales, cada uno con sus propias habilidades y experiencias. Se valorará tu capacidad para colaborar y trabajar en equipo, así como tu habilidad para comunicarte eficazmente con tus colegas y clientes.\r\n\r\nLa empresa también valora la diversidad y la inclusión. Se compromete a crear un entorno de trabajo inclusivo donde todos los empleados se sientan valorados y respetados. Se espera que demuestres un fuerte compromiso con estos valores y que trabajes para promover un entorno de trabajo inclusivo y respetuoso.\r\n\r\nAdemás de tus responsabilidades técnicas, también tendrás la oportunidad de asumir responsabilidades de liderazgo. Esto puede incluir la mentoría de colegas más jóvenes, la gestión de proyectos y la toma de decisiones estratégicas. Tu capacidad para liderar y motivar a otros será un aspecto importante de tu rol.\r\n\r\nEl equilibrio entre el trabajo y la vida personal también es importante para la empresa. Se ofrece un entorno de trabajo flexible que te permite equilibrar tus responsabilidades laborales con tus necesidades personales y familiares. Esto incluye la posibilidad de trabajar de manera remota, horarios de trabajo flexibles y otros beneficios que apoyan tu bienestar y tu equilibrio entre el trabajo y la vida personal.\r\n\r\nEn términos de compensación, la empresa ofrece un paquete de beneficios competitivo que incluye un salario atractivo, beneficios de salud, programas de bienestar y otras ventajas. Se reconoce y recompensa tu arduo trabajo y tu dedicación, y se te ofrece una compensación que refleja tu valor y tus contribuciones a la empresa.\r\n\r\nEste es un momento emocionante para unirse a la empresa. Está en una fase de crecimiento y expansión, y hay muchas oportunidades para el desarrollo profesional y el avance en la carrera. Tendrás la oportunidad de formar parte de un equipo que está trabajando en proyectos innovadores y que está haciendo una diferencia en la industria.\r\n\r\nSi estás buscando un puesto que te desafíe y te permita crecer y desarrollarte profesionalmente, esta es la oportunidad perfecta para ti. Aplica ahora y únete a un equipo apasionado y motivado que está trabajando para crear soluciones innovadoras y hacer una diferencia en la industria.\r\n\r\nFinalmente, es importante destacar que este puesto no solo se trata de las habilidades técnicas y la experiencia. También se valora tu actitud, tu pasión por la tecnología y tu deseo de aprender y crecer. Se busca a alguien que esté entusiasmado por la oportunidad de trabajar en un entorno dinámico y en constante cambio, y que esté comprometido con la excelencia y la calidad en todo lo que hace.\r\n\r\nSi te identificas con estos valores y estás listo para asumir un nuevo desafío, te animamos a que apliques a este puesto. Esta es una oportunidad para hacer una diferencia, para aprender y crecer, y para formar parte de un equipo que está haciendo un trabajo increíble en el campo de la tecnología. No pierdas esta oportunidad de avanzar en tu carrera y de contribuir a proyectos emocionantes e innovadores.\r\n\r\nLa empresa está deseando conocerte y ver cómo puedes contribuir a su éxito. Aplica ahora y comienza tu viaje hacia una carrera gratificante y llena de posibilidades en el mundo de la tecnología.\r\n\r\n",
                    JobOfferModeId = 3,
                    PublicationDate = DateTime.Parse("08/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                    Vacancies = 5
                },
                new Offer
                {
                    OfferId = Guid.Parse("cf064e11-ebbb-4a2c-bbff-ef3e15bb68db"),
                    CompanyId = Guid.Parse("09260ec0-0368-4da8-80d5-6e8b9c574920"),
                    Title = "Asesor de Experiencia y Ventas",
                    Description = "Como Asesor de Experiencia y Ventas, serás responsable de brindar una excelente experiencia a nuestros clientes merchants y promover la venta de productos financieros. Tu principal objetivo será asesorar y guiar a los clientes en la toma de decisiones financieras, ofreciendo soluciones personalizadas y maximizando las oportunidades de ventas. Trabajarás estrechamente con un equipo dinámico y colaborativo para alcanzar los objetivos comerciales establecidos.\r\n\r\n" +
                  "El papel de Asesor de Experiencia y Ventas es fundamental para nuestra empresa, ya que los asesores son la cara visible y el primer punto de contacto para nuestros clientes. Tu habilidad para comprender las necesidades y preocupaciones de los clientes será crucial para ofrecerles la mejor solución financiera. Esto no solo mejorará la satisfacción del cliente, sino que también impulsará las ventas y fomentará la lealtad del cliente.\r\n\r\n" +
                  "En tu día a día, estarás interactuando con una diversa gama de clientes, desde pequeñas empresas hasta grandes corporaciones. Deberás ser capaz de adaptar tu enfoque para satisfacer las necesidades únicas de cada cliente, utilizando tus conocimientos sobre productos financieros para ofrecer soluciones que se alineen con sus objetivos financieros. Además, estarás informado sobre las últimas tendencias y productos en el mercado financiero para proporcionar asesoramiento actualizado y relevante.\r\n\r\n" +
                  "Una parte esencial de tu rol será identificar y aprovechar las oportunidades de venta cruzada y venta adicional. Deberás estar atento a cualquier señal de que un cliente pueda beneficiarse de un producto o servicio adicional y ser capaz de comunicar eficazmente los beneficios de estos productos de manera que resuene con el cliente. Esto requerirá no solo un profundo conocimiento de nuestros productos, sino también una habilidad para construir relaciones de confianza con los clientes.\r\n\r\n" +
                  "Trabajarás en un entorno dinámico y de ritmo rápido, donde la capacidad de manejar múltiples tareas y prioridades será crucial. La colaboración con tu equipo será fundamental, y se espera que contribuyas activamente a las reuniones de equipo, compartas ideas y estrategias, y apoyes a tus colegas cuando sea necesario. El espíritu de equipo y la colaboración son valores centrales de nuestra empresa, y se espera que todos los empleados los encarnen en su trabajo diario.\r\n\r\n" +
                  "Además de las interacciones con los clientes, también estarás trabajando estrechamente con otros departamentos dentro de la empresa, como marketing, operaciones y atención al cliente, para asegurar una experiencia del cliente fluida y coherente. Esta colaboración interdepartamental es clave para el éxito de nuestros esfuerzos de ventas y para la satisfacción general del cliente.\r\n\r\n" +
                  "Nuestro objetivo es no solo cumplir, sino superar las expectativas de nuestros clientes en cada interacción. Como Asesor de Experiencia y Ventas, tendrás la oportunidad de tener un impacto directo y positivo en la vida financiera de nuestros clientes, ayudándolos a alcanzar sus metas y construir un futuro financiero más seguro. Estamos buscando a alguien que sea apasionado por la atención al cliente, tenga un fuerte deseo de aprender y crecer, y esté motivado para alcanzar y superar objetivos de ventas.\r\n\r\n" +
                  "Para tener éxito en este rol, deberás ser proactivo, adaptable y tener una actitud positiva. Deberás ser capaz de pensar rápidamente y resolver problemas de manera eficiente, mientras mantienes una actitud profesional y amigable en todo momento. La capacidad para trabajar de manera independiente, así como en equipo, es esencial, y se valorará tu disposición para asumir nuevas responsabilidades y desafíos a medida que surjan.\r\n\r\n" +
                  "La capacitación continua es una parte integral de nuestro enfoque para asegurar que nuestros empleados estén bien equipados para desempeñar sus roles de manera efectiva. Ofrecemos una variedad de programas de capacitación y desarrollo profesional para ayudarte a mejorar tus habilidades y avanzar en tu carrera. Como Asesor de Experiencia y Ventas, tendrás acceso a estos recursos y oportunidades para seguir creciendo y desarrollándote profesionalmente.\r\n\r\n" +
                  "En resumen, el rol de Asesor de Experiencia y Ventas es una oportunidad emocionante y gratificante para aquellos que desean tener un impacto positivo en la vida financiera de los clientes y contribuir al éxito general de nuestra empresa. Si eres apasionado por las ventas, disfrutas trabajando con clientes y estás buscando un rol dinámico y desafiante, te animamos a que apliques. Únete a nuestro equipo y sé parte de una empresa que valora la innovación, la colaboración y el servicio al cliente de excelencia.\r\n\r\n" +
                  "En esta posición, también tendrás la responsabilidad de mantener un registro detallado de tus interacciones con los clientes, utilizando nuestras herramientas y sistemas internos para rastrear el progreso y las actividades de ventas. Este seguimiento no solo es vital para tu éxito personal, sino también para proporcionar información valiosa al equipo de ventas y otros departamentos sobre las tendencias del cliente y las áreas de mejora.\r\n\r\n" +
                  "La capacidad para manejar la retroalimentación de los clientes de manera constructiva es otra habilidad esencial para este rol. Deberás ser capaz de escuchar atentamente las preocupaciones de los clientes y trabajar con ellos para encontrar soluciones satisfactorias. Esto no solo mejorará la experiencia del cliente, sino que también ayudará a identificar posibles áreas de mejora en nuestros productos y servicios.\r\n\r\n" +
                  "Además, se espera que participes en eventos y actividades de networking para promover nuestra empresa y productos. Estos eventos pueden incluir ferias comerciales, seminarios y otras reuniones de la industria donde tendrás la oportunidad de interactuar con clientes potenciales y actuales, así como con otros profesionales de la industria. Estas actividades son cruciales para construir y mantener una red sólida de contactos y para mantenerse al día con las tendencias y desarrollos de la industria.\r\n\r\n" +
                  "Nuestro equipo de ventas está comprometido a ofrecer un ambiente de trabajo positivo y de apoyo, donde se valoran las ideas y se fomenta la creatividad. Estamos buscando a alguien que pueda contribuir a este ambiente con su energía y entusiasmo, y que esté dispuesto a trabajar duro para alcanzar nuestros objetivos comunes. El compromiso con la excelencia y la disposición para ir más allá para nuestros clientes son cualidades que buscamos en todos nuestros empleados.\r\n\r\n" +
                  "Para apoyarte en tu rol, proporcionamos acceso a una variedad de herramientas y recursos diseñados para ayudarte a tener éxito. Estos incluyen sistemas de gestión de relaciones con clientes (CRM), materiales de capacitación, y acceso a expertos internos que pueden proporcionar orientación y asistencia cuando sea necesario. Creemos que el acceso a estos recursos es fundamental para tu éxito y para el éxito general de nuestro equipo de ventas.\r\n\r\n" +
                  "En nuestra empresa, valoramos la diversidad y creemos que una fuerza laboral diversa es esencial para nuestro éxito. Estamos comprometidos a proporcionar un ambiente inclusivo donde todos los empleados se sientan valorados y respetados. Fomentamos la diversidad de pensamiento y experiencia, y creemos que esto nos ayuda a innovar y a proporcionar un mejor servicio a nuestros clientes. Como parte de nuestro equipo, se espera que apoyes y promuevas estos valores en todas tus interacciones con colegas y clientes.\r\n\r\n" +
                  "Finalmente, el rol de Asesor de Experiencia y Ventas también ofrece la oportunidad de avanzar en tu carrera dentro de nuestra empresa. Proporcionamos un camino claro para el desarrollo profesional y alentamos a nuestros empleados a buscar oportunidades para crecer y asumir roles de mayor responsabilidad. Creemos en recompensar el desempeño y proporcionar oportunidades para el desarrollo continuo, y estamos comprometidos a ayudarte a alcanzar tus objetivos profesionales.\r\n\r\n" +
                  "Estamos emocionados por la posibilidad de que te unas a nuestro equipo y esperamos poder trabajar contigo para alcanzar nuestros objetivos comerciales y proporcionar un excelente servicio a nuestros clientes. Si estás listo para asumir este emocionante desafío y crees que tienes lo que se necesita para tener éxito en este rol, te invitamos a aplicar. Esperamos recibir tu solicitud y aprender más sobre cómo puedes contribuir a nuestro equipo.\r\n\r\n" +
                  "Recuerda que como Asesor de Experiencia y Ventas, estarás en el corazón de nuestra empresa, ayudando a dar forma a la experiencia del cliente y a impulsar nuestras ventas. Tu trabajo tendrá un impacto directo en la satisfacción del cliente y en el éxito de nuestra empresa. Esta es una oportunidad única para aquellos que están apasionados por las ventas y el servicio al cliente y que están buscando una carrera desafiante y gratificante.\r\n\r\n" +
                  "En conclusión, el papel de Asesor de Experiencia y Ventas en nuestra empresa es una posición crucial y gratificante que ofrece una oportunidad única para aquellos que desean tener un impacto positivo en la vida financiera de nuestros clientes. Si tienes pasión por las ventas, disfrutas interactuando con los clientes y estás buscando un rol desafiante y dinámico, te animamos a que te postules. Únete a nuestro equipo y ayúdanos a continuar brindando un excelente servicio a nuestros clientes mientras alcanzamos nuestros objetivos comerciales.\r\n\r\n",
                    JobOfferModeId = 1,
                    PublicationDate = DateTime.Parse("04/05/2024"),
                    CityId = 060371,
                    StudyTypeId = 2,
                    Vacancies = 5
                },
                new Offer
                {
                    OfferId = Guid.Parse("73d35e46-f05d-49c0-8561-cda6f917d556"),
                    CompanyId = Guid.Parse("09260ec0-0368-4da8-80d5-6e8b9c574920"),
                    Title = "iOS Software Engineer SR",
                    Description = "Diseñar y crear funcionalidades y módulos desde cero\r\nTrabajar en equipos multidisciplinarios bajo metodologías ágiles.\r\nIdentificar y brindar soluciones a problemas complejos velando por la calidad del código\r\nAprendizaje constante.\r\n\r\n" +
                  "El rol de iOS Software Engineer SR es crucial para el desarrollo y éxito de nuestros proyectos móviles. Como parte de nuestro equipo, serás responsable de diseñar y crear funcionalidades innovadoras desde cero, trabajando en un entorno ágil y colaborativo. Tu capacidad para identificar y resolver problemas complejos será esencial para mantener la calidad y eficiencia del código.\r\n\r\n" +
                  "En tu día a día, colaborarás con equipos multidisciplinarios, incluyendo diseñadores, desarrolladores de backend, y gerentes de producto, para asegurarte de que cada funcionalidad esté alineada con los objetivos del proyecto y las necesidades del usuario final. Trabajar en equipos ágiles te permitirá adaptarte rápidamente a los cambios y mejorar continuamente los productos que desarrollamos.\r\n\r\n" +
                  "La calidad del código es una prioridad en nuestra empresa, y se espera que todos los miembros del equipo sigan las mejores prácticas de desarrollo y participen en revisiones de código regulares. Esto no solo asegura la calidad del producto final, sino que también fomenta un ambiente de aprendizaje y mejora continua. Tu experiencia y habilidades serán cruciales para guiar a otros miembros del equipo y contribuir a su desarrollo profesional.\r\n\r\n" +
                  "El aprendizaje constante es una parte integral de tu rol como iOS Software Engineer SR. El mundo de la tecnología móvil está en constante evolución, y mantenerse actualizado con las últimas tendencias y tecnologías es esencial. Ofrecemos acceso a una variedad de recursos de aprendizaje y oportunidades de desarrollo profesional para ayudarte a crecer en tu carrera. Ya sea a través de cursos en línea, conferencias, o talleres internos, estamos comprometidos a apoyarte en tu desarrollo continuo.\r\n\r\n" +
                  "Tu creatividad y habilidades técnicas jugarán un papel importante en el diseño de experiencias de usuario excepcionales. Trabajarás estrechamente con los diseñadores para implementar interfaces de usuario atractivas y funcionales que cumplan con los estándares de la plataforma iOS. Tu atención al detalle y pasión por la excelencia serán fundamentales para crear aplicaciones que no solo funcionen bien, sino que también ofrezcan una experiencia de usuario superior.\r\n\r\n" +
                  "Además de tus responsabilidades técnicas, también se espera que participes en la planificación y estimación de proyectos. Tu capacidad para comprender los requisitos del proyecto y traducirlos en soluciones técnicas viables será clave para el éxito del equipo. La comunicación efectiva con los stakeholders y otros miembros del equipo es esencial para asegurar que todos estén alineados y trabajando hacia los mismos objetivos.\r\n\r\n" +
                  "El papel de iOS Software Engineer SR también incluye la mentoría y apoyo a desarrolladores más junior. Compartir tu conocimiento y experiencia no solo beneficia a tus colegas, sino que también fortalece el equipo como un todo. Estamos buscando a alguien que esté dispuesto a invertir en el crecimiento de otros y que disfrute viendo a sus compañeros prosperar.\r\n\r\n" +
                  "La colaboración es un valor central en nuestra empresa, y se espera que contribuyas activamente a un ambiente de trabajo positivo y de apoyo. Valoramos las ideas y perspectivas de todos los miembros del equipo, y creemos que la diversidad de pensamiento es fundamental para la innovación. Tu capacidad para trabajar bien con otros y fomentar una cultura de respeto y colaboración será crucial para nuestro éxito continuo.\r\n\r\n" +
                  "En esta posición, también tendrás la oportunidad de influir en la dirección técnica de nuestros proyectos móviles. Participarás en discusiones estratégicas sobre arquitectura y tecnología, ayudando a definir las mejores prácticas y estándares que guiarán nuestros desarrollos futuros. Tu input será valioso para tomar decisiones informadas que impacten la calidad y sostenibilidad de nuestras soluciones tecnológicas.\r\n\r\n" +
                  "Nuestro objetivo es no solo cumplir, sino superar las expectativas de nuestros usuarios. Como iOS Software Engineer SR, tu trabajo tendrá un impacto directo en la vida de las personas que utilizan nuestras aplicaciones. Estamos buscando a alguien que esté apasionado por la tecnología móvil y que esté motivado por el desafío de crear productos innovadores y de alta calidad.\r\n\r\n" +
                  "Para tener éxito en este rol, necesitarás una combinación de habilidades técnicas, creatividad, y la capacidad para trabajar bien en equipo. Deberás ser proactivo, adaptable, y capaz de manejar múltiples tareas y prioridades. Estamos buscando a alguien que sea un solucionador de problemas nato, con un ojo para los detalles y una pasión por la excelencia.\r\n\r\n" +
                  "En resumen, el rol de iOS Software Engineer SR es una oportunidad emocionante para aquellos que desean tener un impacto significativo en el desarrollo de aplicaciones móviles. Si eres apasionado por la tecnología móvil, disfrutas trabajando en un entorno ágil y colaborativo, y estás buscando un rol desafiante y gratificante, te animamos a aplicar. Únete a nuestro equipo y ayuda a dar forma al futuro de nuestras soluciones móviles.\r\n\r\n" +
                  "Además de tus responsabilidades técnicas, también estarás involucrado en la revisión y mejora continua de nuestros procesos de desarrollo. Siempre estamos buscando maneras de ser más eficientes y efectivos, y valoramos las ideas y contribuciones de todos los miembros del equipo. Tu experiencia y perspectiva serán esenciales para identificar áreas de mejora y proponer soluciones innovadoras.\r\n\r\n" +
                  "La cultura de nuestra empresa se basa en el respeto, la colaboración y el deseo de ofrecer productos de alta calidad a nuestros usuarios. Creemos que un ambiente de trabajo positivo y de apoyo es esencial para el éxito, y nos esforzamos por crear un espacio donde todos se sientan valorados y motivados. Esperamos que todos los miembros de nuestro equipo compartan estos valores y trabajen juntos para alcanzar nuestros objetivos comunes.\r\n\r\n" +
                  "Estamos emocionados por la posibilidad de que te unas a nuestro equipo y esperamos poder trabajar contigo para crear aplicaciones móviles excepcionales. Si estás listo para asumir este emocionante desafío y crees que tienes lo que se necesita para tener éxito en este rol, te invitamos a aplicar. Esperamos recibir tu solicitud y aprender más sobre cómo puedes contribuir a nuestro equipo.\r\n\r\n" +
                  "Recuerda que como iOS Software Engineer SR, estarás en el corazón de nuestros proyectos móviles, ayudando a dar forma a la experiencia del usuario y a impulsar nuestras aplicaciones al siguiente nivel. Tu trabajo tendrá un impacto directo en la satisfacción del usuario y en el éxito de nuestra empresa. Esta es una oportunidad única para aquellos que están apasionados por la tecnología móvil y que están buscando una carrera desafiante y gratificante.\r\n\r\n" +
                  "En conclusión, el papel de iOS Software Engineer SR en nuestra empresa es una posición crucial y gratificante que ofrece una oportunidad única para aquellos que desean tener un impacto positivo en el desarrollo de aplicaciones móviles. Si tienes pasión por la tecnología móvil, disfrutas trabajando en un entorno ágil y colaborativo, y estás buscando un rol desafiante y dinámico, te animamos a que te postules. Únete a nuestro equipo y ayúdanos a continuar brindando excelentes aplicaciones móviles a nuestros usuarios mientras alcanzamos nuestros objetivos tecnológicos.\r\n\r\n",
                    JobOfferModeId = 3,
                    PublicationDate = DateTime.Parse("04/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                    Vacancies = 7
                },
                new Offer
                {
                    OfferId = Guid.Parse("aece4b9c-1e0f-4385-bf2e-8ff209c8d684"),
                    CompanyId = Guid.Parse("09260ec0-0368-4da8-80d5-6e8b9c574920"),
                    Title = "Full Stack Software Engineer SR",
                    Description = "Trabajar en el desarrollo de una solución en partnership con distintos merchants.\r\nParticipar en el diseño de arquitectura y desarrollar soluciones en microfrontend y microservicios.\r\nImpulsar buenas prácticas de desarrollo a nivel frontend y backend.\r\nImplementar patrones de diseño y principios de clean code.\r\n\r\n" +
                 "Como Full Stack Software Engineer SR, serás una pieza clave en el desarrollo de soluciones innovadoras y de alta calidad en colaboración con diversos merchants. En este rol, tu responsabilidad principal será trabajar en la creación y mejora de aplicaciones utilizando tecnologías de vanguardia y siguiendo las mejores prácticas de la industria.\r\n\r\n" +
                 "Tu día a día incluirá la participación activa en el diseño de arquitectura, asegurando que las soluciones sean escalables, eficientes y seguras. Trabajarás con un enfoque en microfrontend y microservicios, lo que te permitirá desarrollar componentes reutilizables y modulares que pueden integrarse fácilmente en diferentes partes del sistema. Este enfoque no solo mejora la mantenibilidad del código, sino que también facilita la implementación de nuevas funcionalidades y la resolución de problemas.\r\n\r\n" +
                 "Impulsarás buenas prácticas de desarrollo tanto a nivel frontend como backend. Esto incluye la implementación de patrones de diseño y principios de clean code que aseguran que el código sea legible, mantenible y libre de errores. Tu experiencia y conocimientos serán fundamentales para establecer estándares de codificación y garantizar que todos los miembros del equipo los sigan. Además, participarás en revisiones de código y ofrecerás feedback constructivo a tus compañeros para fomentar un ambiente de aprendizaje y mejora continua.\r\n\r\n" +
                 "En tu rol, también serás responsable de identificar y solucionar problemas complejos que puedan surgir durante el desarrollo. Esto requiere un pensamiento crítico y una capacidad para analizar problemas desde múltiples perspectivas. Tu habilidad para encontrar soluciones creativas y efectivas será crucial para el éxito de los proyectos en los que trabajes.\r\n\r\n" +
                 "La colaboración es un aspecto clave de este rol. Trabajarás estrechamente con diseñadores, otros desarrolladores, gerentes de producto y stakeholders para garantizar que las soluciones que desarrolles cumplan con los requisitos del cliente y las expectativas del usuario final. La comunicación efectiva y la capacidad para trabajar bien en equipo son esenciales para asegurar que los proyectos se completen de manera exitosa y a tiempo.\r\n\r\n" +
                 "Además de tus responsabilidades técnicas, también tendrás la oportunidad de influir en la dirección estratégica de los proyectos. Participarás en discusiones sobre nuevas tecnologías y herramientas que podrían beneficiar al equipo y mejorar los productos que desarrollamos. Tu input será valioso para tomar decisiones informadas que impacten la calidad y eficiencia de nuestras soluciones tecnológicas.\r\n\r\n" +
                 "Como Full Stack Software Engineer SR, estarás en un constante proceso de aprendizaje y crecimiento. El mundo de la tecnología está en constante evolución, y es importante mantenerse actualizado con las últimas tendencias y desarrollos. Ofrecemos acceso a una variedad de recursos educativos y oportunidades de desarrollo profesional para ayudarte a crecer en tu carrera. Ya sea a través de cursos en línea, conferencias, o talleres internos, estamos comprometidos a apoyarte en tu desarrollo continuo.\r\n\r\n" +
                 "Tu creatividad y habilidades técnicas serán esenciales para diseñar experiencias de usuario excepcionales. Trabajarás con diseñadores para implementar interfaces de usuario atractivas y funcionales que cumplan con los estándares de la plataforma. Tu atención al detalle y pasión por la excelencia serán fundamentales para crear aplicaciones que no solo funcionen bien, sino que también ofrezcan una experiencia de usuario superior.\r\n\r\n" +
                 "En resumen, el rol de Full Stack Software Engineer SR es una oportunidad emocionante para aquellos que desean tener un impacto significativo en el desarrollo de aplicaciones innovadoras. Si eres apasionado por la tecnología, disfrutas trabajando en un entorno ágil y colaborativo, y estás buscando un rol desafiante y gratificante, te animamos a aplicar. Únete a nuestro equipo y ayuda a dar forma al futuro de nuestras soluciones tecnológicas.\r\n\r\n" +
                 "Estamos buscando a alguien que sea proactivo, adaptable y capaz de manejar múltiples tareas y prioridades. Deberás ser un solucionador de problemas nato, con un ojo para los detalles y una pasión por la excelencia. Valoramos la diversidad de pensamiento y la colaboración, y creemos que estas cualidades son fundamentales para la innovación.\r\n\r\n" +
                 "En esta posición, también tendrás la oportunidad de mentorizar a desarrolladores más junior, compartiendo tu conocimiento y experiencia para ayudarles a crecer profesionalmente. Esta mentoría no solo beneficia a tus colegas, sino que también fortalece el equipo como un todo. Estamos buscando a alguien que esté dispuesto a invertir en el crecimiento de otros y que disfrute viendo a sus compañeros prosperar.\r\n\r\n" +
                 "La cultura de nuestra empresa se basa en el respeto, la colaboración y el deseo de ofrecer productos de alta calidad a nuestros usuarios. Creemos que un ambiente de trabajo positivo y de apoyo es esencial para el éxito, y nos esforzamos por crear un espacio donde todos se sientan valorados y motivados. Esperamos que todos los miembros de nuestro equipo compartan estos valores y trabajen juntos para alcanzar nuestros objetivos comunes.\r\n\r\n" +
                 "Además de tus responsabilidades técnicas, también estarás involucrado en la revisión y mejora continua de nuestros procesos de desarrollo. Siempre estamos buscando maneras de ser más eficientes y efectivos, y valoramos las ideas y contribuciones de todos los miembros del equipo. Tu experiencia y perspectiva serán esenciales para identificar áreas de mejora y proponer soluciones innovadoras.\r\n\r\n" +
                 "Estamos emocionados por la posibilidad de que te unas a nuestro equipo y esperamos poder trabajar contigo para crear aplicaciones excepcionales. Si estás listo para asumir este emocionante desafío y crees que tienes lo que se necesita para tener éxito en este rol, te invitamos a aplicar. Esperamos recibir tu solicitud y aprender más sobre cómo puedes contribuir a nuestro equipo.\r\n\r\n" +
                 "Recuerda que como Full Stack Software Engineer SR, estarás en el corazón de nuestros proyectos tecnológicos, ayudando a dar forma a la experiencia del usuario y a impulsar nuestras soluciones al siguiente nivel. Tu trabajo tendrá un impacto directo en la satisfacción del usuario y en el éxito de nuestra empresa. Esta es una oportunidad única para aquellos que están apasionados por la tecnología y que están buscando una carrera desafiante y gratificante.\r\n\r\n" +
                 "En conclusión, el papel de Full Stack Software Engineer SR en nuestra empresa es una posición crucial y gratificante que ofrece una oportunidad única para aquellos que desean tener un impacto positivo en el desarrollo de aplicaciones. Si tienes pasión por la tecnología, disfrutas trabajando en un entorno ágil y colaborativo, y estás buscando un rol desafiante y dinámico, te animamos a que te postules. Únete a nuestro equipo y ayúdanos a continuar brindando excelentes soluciones a nuestros usuarios mientras alcanzamos nuestros objetivos tecnológicos.\r\n\r\n",
                    JobOfferModeId = 3,
                    PublicationDate = DateTime.Parse("09/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                    Vacancies = 4
                },
                new Offer
                {
                    OfferId = Guid.Parse("4c2e4700-6491-42c4-9da2-1c094bb09d1c"),
                    CompanyId = Guid.Parse("09260ec0-0368-4da8-80d5-6e8b9c574920"),
                    Title = "Data Transformation Analyst",
                    Description = "Como Data Transformation Analyst, serás responsable de promover y desarrollar una cultura organizativa que valore y aproveche los datos como un activo estratégico. Esto implica trabajar en estrecha colaboración con diferentes equipos y líderes para identificar oportunidades de mejora en el uso de los datos, desarrollar iniciativas de capacitación, y establecer prácticas y políticas que fomenten la confianza y el uso eficaz de los datos en todos los niveles de la organización.\r\n\r\n" +
                 "En este rol, tu función principal será liderar la transformación de datos a través de la empresa, asegurando que se utilicen de manera óptima para apoyar la toma de decisiones y el crecimiento del negocio. Trabajarás con grandes volúmenes de datos provenientes de diversas fuentes, utilizando herramientas avanzadas de análisis y visualización para extraer insights valiosos.\r\n\r\n" +
                 "Tu día a día incluirá la identificación de necesidades y oportunidades para el uso de datos dentro de la organización. Colaborarás con equipos multifuncionales para desarrollar y ejecutar estrategias de datos que mejoren la eficiencia operativa y la efectividad de los procesos empresariales. Esto incluirá la creación de dashboards interactivos, reportes y otros artefactos visuales que faciliten la comprensión y el uso de los datos por parte de los stakeholders.\r\n\r\n" +
                 "Otra responsabilidad clave será garantizar la calidad y la integridad de los datos. Implementarás procesos y herramientas para la limpieza, validación y transformación de datos, asegurando que la información sea precisa y esté actualizada. Trabajarás en estrecha colaboración con los equipos de TI y de datos para diseñar e implementar soluciones que mejoren la calidad y la accesibilidad de los datos en toda la organización.\r\n\r\n" +
                 "Además, serás responsable de fomentar una cultura de datos en la empresa. Esto incluye la organización y conducción de sesiones de capacitación y workshops para educar a los empleados sobre la importancia de los datos y cómo pueden ser utilizados para mejorar sus tareas diarias. Crearás políticas y procedimientos que promuevan el uso ético y responsable de los datos, asegurando el cumplimiento de las normativas y regulaciones pertinentes.\r\n\r\n" +
                 "Tu rol también implicará la gestión de proyectos de datos, desde la concepción hasta la implementación. Serás responsable de definir los objetivos del proyecto, desarrollar planes de trabajo detallados, asignar recursos y monitorear el progreso para asegurar que se cumplan los plazos y los objetivos establecidos. Tendrás la oportunidad de liderar equipos de trabajo y coordinar esfuerzos con stakeholders internos y externos.\r\n\r\n" +
                 "En cuanto a las habilidades técnicas, deberás tener experiencia en el uso de herramientas de análisis de datos y visualización como SQL, Python, R, Tableau, y Power BI. Conocimiento en gestión de bases de datos y experiencia en proyectos de transformación digital serán altamente valorados. Además, deberás estar al tanto de las últimas tendencias y avances en el campo de la ciencia de datos y la inteligencia artificial.\r\n\r\n" +
                 "Una parte fundamental de tu trabajo será la comunicación efectiva de los insights de datos a diferentes audiencias dentro de la organización. Deberás ser capaz de traducir datos complejos y técnicas de análisis en información clara y accionable que pueda ser entendida y utilizada por personas con diferentes niveles de experiencia técnica. Esto incluirá la preparación de presentaciones y reportes que destaquen las oportunidades clave y las recomendaciones basadas en datos.\r\n\r\n" +
                 "Como Data Transformation Analyst, también tendrás un papel estratégico en la definición y ejecución de la estrategia de datos de la empresa. Trabajarás con la alta dirección para identificar las prioridades estratégicas y desarrollar iniciativas que alineen el uso de datos con los objetivos de negocio. Esto incluye la identificación de nuevas oportunidades para el uso de datos y la recomendación de inversiones en tecnología y capacitación que fortalezcan las capacidades de datos de la organización.\r\n\r\n" +
                 "Otro aspecto importante de tu rol será la colaboración con socios externos y proveedores de tecnología. Negociarás y gestionarás contratos, asegurando que las soluciones adquiridas sean adecuadas para las necesidades de la empresa y que se implementen de manera efectiva. Trabajarás en estrecha colaboración con proveedores para personalizar y adaptar soluciones a las necesidades específicas de la organización.\r\n\r\n" +
                 "Tu capacidad para liderar el cambio y gestionar la resistencia será crucial. Implementarás estrategias de gestión del cambio que faciliten la adopción de nuevas tecnologías y procesos basados en datos. Esto incluye la comunicación de beneficios, la capacitación de los empleados y el monitoreo continuo para asegurar que las nuevas prácticas se mantengan y mejoren con el tiempo.\r\n\r\n" +
                 "Además de tus responsabilidades principales, tendrás la oportunidad de participar en proyectos de innovación y desarrollo. Colaborarás con equipos de I+D para explorar nuevas tecnologías y métodos que puedan ser aplicados para mejorar la eficiencia y la efectividad de la empresa. Esto incluye la experimentación con tecnologías emergentes como el machine learning, el análisis predictivo y la automatización de procesos.\r\n\r\n" +
                 "Finalmente, en tu rol de Data Transformation Analyst, serás un embajador de la cultura de datos en toda la organización. Promoverás el uso de datos como una herramienta esencial para la toma de decisiones y el desarrollo de estrategias, y trabajarás para asegurar que todos los empleados comprendan y valoren el papel de los datos en el éxito de la empresa. Tu trabajo contribuirá significativamente a la transformación digital de la empresa y al establecimiento de una cultura de datos sólida y sostenible.\r\n\r\n" +
                 "En resumen, el rol de Data Transformation Analyst es esencial para impulsar la transformación digital y maximizar el valor de los datos en nuestra organización. Si tienes pasión por los datos, habilidades técnicas sólidas y la capacidad de liderar y colaborar efectivamente, te invitamos a unirte a nuestro equipo y contribuir a nuestro éxito. Esta es una oportunidad emocionante para aquellos que buscan un rol desafiante y gratificante en el campo de la ciencia de datos y la inteligencia empresarial.\r\n\r\n",
                    JobOfferModeId = 3,
                    PublicationDate = DateTime.Parse("10/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                    Vacancies = 7
                },
                new Offer
                {
                    OfferId = Guid.Parse("4500dcbc-8d33-4814-9c95-4da24e53ff54"),
                    CompanyId = Guid.Parse("09260ec0-0368-4da8-80d5-6e8b9c574920"),
                    Title = "Asesor de Experiencia & Ventas",
                    Description = "Como Asesor de Experiencia y Ventas, serás responsable de brindar una excelente experiencia a nuestros clientes merchants y promover la venta de productos financieros. Tu principal objetivo será asesorar y guiar a los clientes en la toma de decisiones financieras, ofreciendo soluciones personalizadas y maximizando las oportunidades de ventas. Trabajarás estrechamente con un equipo dinámico y colaborativo para alcanzar los objetivos comerciales establecidos.\r\n\r\n" +
                 "Tu día a día incluirá la atención y asesoría a clientes, identificando sus necesidades y proponiendo soluciones adecuadas. Deberás estar actualizado sobre los productos y servicios financieros que ofrecemos, para así poder explicar sus características y beneficios de manera clara y persuasiva. Además, serás responsable de gestionar y mantener las relaciones con los clientes, asegurando su satisfacción y fidelidad a largo plazo.\r\n\r\n" +
                 "Además de la atención al cliente, tendrás un rol activo en la promoción y venta de nuestros productos financieros. Esto incluirá la identificación de oportunidades de venta, la preparación de propuestas comerciales y la negociación de términos y condiciones con los clientes. Trabajarás en estrecha colaboración con otros departamentos para coordinar actividades de ventas y marketing, asegurando una oferta coherente y atractiva para nuestros clientes.\r\n\r\n" +
                 "En tu rol, también serás responsable de realizar un seguimiento de las ventas y de los objetivos comerciales. Deberás analizar los resultados y reportar el progreso a la gerencia, identificando áreas de mejora y proponiendo acciones correctivas cuando sea necesario. Esto te permitirá contribuir de manera activa al desarrollo y crecimiento de nuestra empresa, apoyando la toma de decisiones estratégicas basadas en datos concretos.\r\n\r\n" +
                 "Una parte importante de tu trabajo será la capacitación y desarrollo continuo. Participarás en programas de formación para mejorar tus habilidades y conocimientos en ventas y productos financieros. Además, tendrás la oportunidad de compartir tus conocimientos y experiencias con tus compañeros, contribuyendo al desarrollo de un equipo fuerte y cohesionado.\r\n\r\n" +
                 "En cuanto a las habilidades necesarias, deberás tener excelentes habilidades de comunicación y negociación, así como una fuerte orientación al cliente y a los resultados. Serás capaz de trabajar de manera independiente y en equipo, manejando múltiples tareas y prioridades en un entorno dinámico y exigente. Tu capacidad para adaptarte y aprender rápidamente será crucial para tu éxito en este rol.\r\n\r\n" +
                 "Además de tus responsabilidades principales, también tendrás la oportunidad de participar en iniciativas de mejora continua. Esto incluirá la identificación de oportunidades para mejorar nuestros procesos y prácticas de ventas, y la implementación de nuevas estrategias y herramientas que mejoren la eficiencia y efectividad de nuestras operaciones.\r\n\r\n" +
                 "Tu papel como Asesor de Experiencia y Ventas será fundamental para el éxito de nuestra empresa. Contribuirás de manera significativa a la satisfacción y fidelización de nuestros clientes, impulsando las ventas y el crecimiento del negocio. Si tienes pasión por las ventas, una fuerte orientación al cliente y habilidades de comunicación excepcionales, te invitamos a unirte a nuestro equipo y ser parte de nuestro éxito.\r\n\r\n" +
                 "En resumen, este rol ofrece una oportunidad emocionante y desafiante para aquellos que buscan desarrollar una carrera en ventas y servicios financieros. Ofrecemos un entorno de trabajo dinámico y colaborativo, con oportunidades de crecimiento y desarrollo profesional. Esperamos contar contigo para continuar ofreciendo una experiencia excepcional a nuestros clientes y alcanzar juntos nuestros objetivos comerciales.\r\n\r\n" +
                 "Trabajarás en un ambiente que valora la innovación y la mejora continua, donde cada día trae nuevos desafíos y oportunidades. Serás parte de un equipo comprometido con la excelencia y el éxito, donde tu contribución será reconocida y valorada. Tu capacidad para construir relaciones sólidas con los clientes y entender sus necesidades será clave para lograr resultados sobresalientes.\r\n\r\n" +
                 "La clave para el éxito en este rol será tu capacidad para adaptarte a las necesidades cambiantes del mercado y de nuestros clientes. Deberás estar siempre dispuesto a aprender y a mejorar, manteniéndote al día con las últimas tendencias y desarrollos en el sector financiero. Tu proactividad y tu enfoque orientado a resultados te permitirán identificar y aprovechar las oportunidades de ventas, maximizando el valor para nuestros clientes y para la empresa.\r\n\r\n" +
                 "Finalmente, como Asesor de Experiencia y Ventas, tendrás la oportunidad de influir en la dirección y el crecimiento de nuestra empresa. Serás una pieza clave en nuestro equipo, contribuyendo con tus ideas y tu energía para alcanzar nuestros objetivos. Si estás listo para aceptar este desafío y hacer una diferencia, esperamos recibir tu aplicación y conocerte mejor.\r\n\r\n",
                    JobOfferModeId = 1,
                    PublicationDate = DateTime.Parse("10/05/2024"),
                    CityId = 060760,
                    StudyTypeId = 2,
                    Vacancies = 5
                },
                new Offer
                {
                    OfferId = Guid.Parse("6aa3a38a-dba0-4d26-8355-5c167f1501c6"),
                    CompanyId = Guid.Parse("09260ec0-0368-4da8-80d5-6e8b9c574920"),
                    Title = "Asesor de Experiencia & Ventas",
                    Description = "Como Asesor de Experiencia y Ventas, serás responsable de brindar una excelente experiencia a nuestros clientes y promover la venta de productos financieros. Tu principal objetivo será asesorar y guiar a los clientes en la toma de decisiones financieras, ofreciendo soluciones personalizadas y maximizando las oportunidades de ventas. Trabajarás estrechamente con un equipo dinámico y colaborativo para alcanzar los objetivos comerciales establecidos.\r\n\r\n" +
                 "En este rol, tu jornada laboral incluirá la atención y asesoramiento a clientes, identificando sus necesidades y proponiendo soluciones adecuadas. Deberás mantenerte actualizado sobre los productos y servicios financieros que ofrecemos, para poder explicar sus características y beneficios de manera clara y persuasiva. Además, serás responsable de gestionar y mantener relaciones con los clientes, asegurando su satisfacción y lealtad a largo plazo.\r\n\r\n" +
                 "Además de la atención al cliente, tendrás un papel activo en la promoción y venta de nuestros productos financieros. Esto incluye la identificación de oportunidades de venta, la preparación de propuestas comerciales y la negociación de términos y condiciones con los clientes. Trabajarás en estrecha colaboración con otros departamentos para coordinar actividades de ventas y marketing, asegurando una oferta coherente y atractiva para nuestros clientes.\r\n\r\n" +
                 "Como parte de tus responsabilidades, realizarás un seguimiento de las ventas y de los objetivos comerciales. Deberás analizar los resultados y reportar el progreso a la gerencia, identificando áreas de mejora y proponiendo acciones correctivas cuando sea necesario. Esto te permitirá contribuir activamente al desarrollo y crecimiento de nuestra empresa, apoyando la toma de decisiones estratégicas basadas en datos concretos.\r\n\r\n" +
                 "Una parte importante de tu trabajo será la capacitación y desarrollo continuo. Participarás en programas de formación para mejorar tus habilidades y conocimientos en ventas y productos financieros. Además, tendrás la oportunidad de compartir tus conocimientos y experiencias con tus compañeros, contribuyendo al desarrollo de un equipo fuerte y cohesionado.\r\n\r\n" +
                 "En cuanto a las habilidades necesarias, deberás tener excelentes habilidades de comunicación y negociación, así como una fuerte orientación al cliente y a los resultados. Serás capaz de trabajar de manera independiente y en equipo, manejando múltiples tareas y prioridades en un entorno dinámico y exigente. Tu capacidad para adaptarte y aprender rápidamente será crucial para tu éxito en este rol.\r\n\r\n" +
                 "Además de tus responsabilidades principales, también tendrás la oportunidad de participar en iniciativas de mejora continua. Esto incluye la identificación de oportunidades para mejorar nuestros procesos y prácticas de ventas, y la implementación de nuevas estrategias y herramientas que mejoren la eficiencia y efectividad de nuestras operaciones.\r\n\r\n" +
                 "Tu papel como Asesor de Experiencia y Ventas será fundamental para el éxito de nuestra empresa. Contribuirás significativamente a la satisfacción y fidelización de nuestros clientes, impulsando las ventas y el crecimiento del negocio. Si tienes pasión por las ventas, una fuerte orientación al cliente y habilidades de comunicación excepcionales, te invitamos a unirte a nuestro equipo y ser parte de nuestro éxito.\r\n\r\n" +
                 "En resumen, este rol ofrece una oportunidad emocionante y desafiante para aquellos que buscan desarrollar una carrera en ventas y servicios financieros. Ofrecemos un entorno de trabajo dinámico y colaborativo, con oportunidades de crecimiento y desarrollo profesional. Esperamos contar contigo para continuar ofreciendo una experiencia excepcional a nuestros clientes y alcanzar juntos nuestros objetivos comerciales.\r\n\r\n" +
                 "Trabajarás en un ambiente que valora la innovación y la mejora continua, donde cada día trae nuevos desafíos y oportunidades. Serás parte de un equipo comprometido con la excelencia y el éxito, donde tu contribución será reconocida y valorada. Tu capacidad para construir relaciones sólidas con los clientes y entender sus necesidades será clave para lograr resultados sobresalientes.\r\n\r\n" +
                 "La clave para el éxito en este rol será tu capacidad para adaptarte a las necesidades cambiantes del mercado y de nuestros clientes. Deberás estar siempre dispuesto a aprender y a mejorar, manteniéndote al día con las últimas tendencias y desarrollos en el sector financiero. Tu proactividad y tu enfoque orientado a resultados te permitirán identificar y aprovechar las oportunidades de ventas, maximizando el valor para nuestros clientes y para la empresa.\r\n\r\n" +
                 "Finalmente, como Asesor de Experiencia y Ventas, tendrás la oportunidad de influir en la dirección y el crecimiento de nuestra empresa. Serás una pieza clave en nuestro equipo, contribuyendo con tus ideas y tu energía para alcanzar nuestros objetivos. Si estás listo para aceptar este desafío y hacer una diferencia, esperamos recibir tu aplicación y conocerte mejor.\r\n\r\n" +
                 "Además de lo anterior, tu rol implicará la creación de estrategias efectivas para la captación de nuevos clientes y la retención de los actuales. Deberás identificar y analizar las tendencias del mercado para desarrollar campañas de marketing que atraigan a potenciales clientes y mantengan el interés de los existentes. Esta tarea requerirá un entendimiento profundo del comportamiento del consumidor y de los factores que influyen en sus decisiones de compra.\r\n\r\n" +
                 "Tu capacidad para trabajar con datos y analizar métricas de ventas será crucial. Utilizarás estas métricas para evaluar el desempeño de las estrategias implementadas y para hacer ajustes necesarios que mejoren los resultados. Este enfoque basado en datos no solo ayudará a optimizar nuestras tácticas de ventas, sino que también proporcionará insights valiosos que pueden informar decisiones de negocio más amplias.\r\n\r\n" +
                 "En términos de herramientas y tecnologías, estarás equipado con las últimas plataformas de CRM (Customer Relationship Management) y software de análisis de ventas. Estas herramientas te permitirán gestionar de manera eficiente las interacciones con los clientes, registrar sus preferencias y comportamientos, y personalizar las ofertas según sus necesidades específicas. La tecnología será tu aliada para mantener un registro detallado de todas las actividades de ventas y para asegurar una comunicación fluida y efectiva con el equipo.\r\n\r\n" +
                 "El desarrollo profesional será una constante en tu trayectoria. Participarás en talleres y seminarios que te mantendrán al día con las mejores prácticas en ventas y servicios financieros. Tendrás acceso a una red de profesionales y mentores que te guiarán y apoyarán en tu crecimiento. Esta inversión en tu desarrollo personal y profesional te permitirá mejorar tus habilidades y avanzar en tu carrera.\r\n\r\n" +
                 "Tu éxito en este rol también dependerá de tu habilidad para gestionar tu tiempo y prioridades de manera efectiva. Con múltiples proyectos y clientes a la vez, será crucial que seas capaz de organizar tus tareas y enfocarte en las actividades que generen el mayor impacto. La gestión del tiempo y la eficiencia en el trabajo te permitirán cumplir con los plazos y superar las expectativas de los clientes.\r\n\r\n" +
                 "Finalmente, en este rol, la integridad y la ética serán fundamentales. Deberás actuar siempre con honestidad y transparencia, asegurando que las soluciones ofrecidas a los clientes sean las más adecuadas para sus necesidades. Tu reputación y la de nuestra empresa dependerán de tu compromiso con estos valores. La confianza que generes en los clientes será la base de relaciones duraderas y exitosas.\r\n\r\n",
                    JobOfferModeId = 1,
                    PublicationDate = DateTime.Parse("06/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 2,
                    Vacancies = 7
                },
                new Offer
                {
                    OfferId = Guid.Parse("4e5e9b73-2141-48f6-a306-bb660dd6f451"),
                    CompanyId = Guid.Parse("09260ec0-0368-4da8-80d5-6e8b9c574920"),
                    Title = "Asesor de Ventas",
                    Description = "Como Asesor de Experiencia y Ventas, serás responsable de brindar una excelente experiencia a nuestros clientes y promover la venta de productos financieros. Tu principal objetivo será asesorar y guiar a los clientes en la toma de decisiones financieras, ofreciendo soluciones personalizadas y maximizando las oportunidades de ventas. Trabajarás estrechamente con un equipo dinámico y colaborativo para alcanzar los objetivos comerciales establecidos.\r\n\r\n" +
                 "En este rol, tu jornada laboral incluirá la atención y asesoramiento a clientes, identificando sus necesidades y proponiendo soluciones adecuadas. Deberás mantenerte actualizado sobre los productos y servicios financieros que ofrecemos, para poder explicar sus características y beneficios de manera clara y persuasiva. Además, serás responsable de gestionar y mantener relaciones con los clientes, asegurando su satisfacción y lealtad a largo plazo.\r\n\r\n" +
                 "Además de la atención al cliente, tendrás un papel activo en la promoción y venta de nuestros productos financieros. Esto incluye la identificación de oportunidades de venta, la preparación de propuestas comerciales y la negociación de términos y condiciones con los clientes. Trabajarás en estrecha colaboración con otros departamentos para coordinar actividades de ventas y marketing, asegurando una oferta coherente y atractiva para nuestros clientes.\r\n\r\n" +
                 "Como parte de tus responsabilidades, realizarás un seguimiento de las ventas y de los objetivos comerciales. Deberás analizar los resultados y reportar el progreso a la gerencia, identificando áreas de mejora y proponiendo acciones correctivas cuando sea necesario. Esto te permitirá contribuir activamente al desarrollo y crecimiento de nuestra empresa, apoyando la toma de decisiones estratégicas basadas en datos concretos.\r\n\r\n" +
                 "Una parte importante de tu trabajo será la capacitación y desarrollo continuo. Participarás en programas de formación para mejorar tus habilidades y conocimientos en ventas y productos financieros. Además, tendrás la oportunidad de compartir tus conocimientos y experiencias con tus compañeros, contribuyendo al desarrollo de un equipo fuerte y cohesionado.\r\n\r\n" +
                 "En cuanto a las habilidades necesarias, deberás tener excelentes habilidades de comunicación y negociación, así como una fuerte orientación al cliente y a los resultados. Serás capaz de trabajar de manera independiente y en equipo, manejando múltiples tareas y prioridades en un entorno dinámico y exigente. Tu capacidad para adaptarte y aprender rápidamente será crucial para tu éxito en este rol.\r\n\r\n" +
                 "Además de tus responsabilidades principales, también tendrás la oportunidad de participar en iniciativas de mejora continua. Esto incluye la identificación de oportunidades para mejorar nuestros procesos y prácticas de ventas, y la implementación de nuevas estrategias y herramientas que mejoren la eficiencia y efectividad de nuestras operaciones.\r\n\r\n" +
                 "Tu papel como Asesor de Experiencia y Ventas será fundamental para el éxito de nuestra empresa. Contribuirás significativamente a la satisfacción y fidelización de nuestros clientes, impulsando las ventas y el crecimiento del negocio. Si tienes pasión por las ventas, una fuerte orientación al cliente y habilidades de comunicación excepcionales, te invitamos a unirte a nuestro equipo y ser parte de nuestro éxito.\r\n\r\n" +
                 "En resumen, este rol ofrece una oportunidad emocionante y desafiante para aquellos que buscan desarrollar una carrera en ventas y servicios financieros. Ofrecemos un entorno de trabajo dinámico y colaborativo, con oportunidades de crecimiento y desarrollo profesional. Esperamos contar contigo para continuar ofreciendo una experiencia excepcional a nuestros clientes y alcanzar juntos nuestros objetivos comerciales.\r\n\r\n" +
                 "Trabajarás en un ambiente que valora la innovación y la mejora continua, donde cada día trae nuevos desafíos y oportunidades. Serás parte de un equipo comprometido con la excelencia y el éxito, donde tu contribución será reconocida y valorada. Tu capacidad para construir relaciones sólidas con los clientes y entender sus necesidades será clave para lograr resultados sobresalientes.\r\n\r\n" +
                 "La clave para el éxito en este rol será tu capacidad para adaptarte a las necesidades cambiantes del mercado y de nuestros clientes. Deberás estar siempre dispuesto a aprender y a mejorar, manteniéndote al día con las últimas tendencias y desarrollos en el sector financiero. Tu proactividad y tu enfoque orientado a resultados te permitirán identificar y aprovechar las oportunidades de ventas, maximizando el valor para nuestros clientes y para la empresa.\r\n\r\n" +
                 "Finalmente, como Asesor de Experiencia y Ventas, tendrás la oportunidad de influir en la dirección y el crecimiento de nuestra empresa. Serás una pieza clave en nuestro equipo, contribuyendo con tus ideas y tu energía para alcanzar nuestros objetivos. Si estás listo para aceptar este desafío y hacer una diferencia, esperamos recibir tu aplicación y conocerte mejor.\r\n\r\n" +
                 "Además de lo anterior, tu rol implicará la creación de estrategias efectivas para la captación de nuevos clientes y la retención de los actuales. Deberás identificar y analizar las tendencias del mercado para desarrollar campañas de marketing que atraigan a potenciales clientes y mantengan el interés de los existentes. Esta tarea requerirá un entendimiento profundo del comportamiento del consumidor y de los factores que influyen en sus decisiones de compra.\r\n\r\n" +
                 "Tu capacidad para trabajar con datos y analizar métricas de ventas será crucial. Utilizarás estas métricas para evaluar el desempeño de las estrategias implementadas y para hacer ajustes necesarios que mejoren los resultados. Este enfoque basado en datos no solo ayudará a optimizar nuestras tácticas de ventas, sino que también proporcionará insights valiosos que pueden informar decisiones de negocio más amplias.\r\n\r\n" +
                 "En términos de herramientas y tecnologías, estarás equipado con las últimas plataformas de CRM (Customer Relationship Management) y software de análisis de ventas. Estas herramientas te permitirán gestionar de manera eficiente las interacciones con los clientes, registrar sus preferencias y comportamientos, y personalizar las ofertas según sus necesidades específicas. La tecnología será tu aliada para mantener un registro detallado de todas las actividades de ventas y para asegurar una comunicación fluida y efectiva con el equipo.\r\n\r\n" +
                 "El desarrollo profesional será una constante en tu trayectoria. Participarás en talleres y seminarios que te mantendrán al día con las mejores prácticas en ventas y servicios financieros. Tendrás acceso a una red de profesionales y mentores que te guiarán y apoyarán en tu crecimiento. Esta inversión en tu desarrollo personal y profesional te permitirá mejorar tus habilidades y avanzar en tu carrera.\r\n\r\n" +
                 "Tu éxito en este rol también dependerá de tu habilidad para gestionar tu tiempo y prioridades de manera efectiva. Con múltiples proyectos y clientes a la vez, será crucial que seas capaz de organizar tus tareas y enfocarte en las actividades que generen el mayor impacto. La gestión del tiempo y la eficiencia en el trabajo te permitirán cumplir con los plazos y superar las expectativas de los clientes.\r\n\r\n" +
                 "Finalmente, en este rol, la integridad y la ética serán fundamentales. Deberás actuar siempre con honestidad y transparencia, asegurando que las soluciones ofrecidas a los clientes sean las más adecuadas para sus necesidades. Tu reputación y la de nuestra empresa dependerán de tu compromiso con estos valores. La confianza que generes en los clientes será la base de relaciones duraderas y exitosas.\r\n\r\n",
                    JobOfferModeId = 1,
                    PublicationDate = DateTime.Parse("06/05/2024"),
                    CityId = 060568,
                    StudyTypeId = 2,
                    Vacancies = 8
                },
                new Offer
                {
                    OfferId = Guid.Parse("dfc5b3ac-af4e-42b4-bf9c-2a683a46059f"),
                    CompanyId = Guid.Parse("09260ec0-0368-4da8-80d5-6e8b9c574920"),
                    Title = "Oportunidades laborales para Personas con Discapacidad",
                    Description = "Estamos creando un ecosistema de soluciones tecnológicas financieras que queremos que se diferencie por ofrecer la mejor experiencia y facilidad en el acceso.\r\n\r\n" +
                 "Si te identificás con todas las posibilidades para impactar, sumate a nuestra Base de Talento para Personas con Discapacidad.\r\n\r\n" +
                 "Nuestro objetivo es crear un ambiente inclusivo y diverso, donde cada individuo tenga la oportunidad de contribuir y crecer. Creemos que la diversidad enriquece nuestro entorno laboral y fomenta la innovación. Buscamos personas con diferentes habilidades y experiencias que puedan aportar nuevas perspectivas a nuestro equipo.\r\n\r\n" +
                 "Al unirte a nuestra Base de Talento, tendrás acceso a una amplia gama de oportunidades laborales adaptadas a tus habilidades y competencias. Queremos que te sientas valorado y apoyado en cada etapa de tu carrera. Ofrecemos programas de capacitación y desarrollo profesional para ayudarte a alcanzar tus metas y superar tus expectativas.\r\n\r\n" +
                 "Nos comprometemos a proporcionar un entorno de trabajo accesible y amigable, donde todos los empleados puedan desenvolverse con comodidad. Implementamos medidas y herramientas de accesibilidad para garantizar que todos puedan realizar su trabajo de manera eficiente y efectiva. Además, promovemos una cultura de respeto y apoyo, donde cada voz es escuchada y valorada.\r\n\r\n" +
                 "La inclusión no es solo una política para nosotros, es una práctica diaria. Nos esforzamos por eliminar las barreras que impiden la plena participación de las personas con discapacidad en el ámbito laboral. Creemos en la igualdad de oportunidades y trabajamos activamente para crear un entorno donde todos tengan las mismas oportunidades de éxito.\r\n\r\n" +
                 "Trabajar con nosotros significa ser parte de una organización que valora la diversidad y la inclusión. Tendrás la oportunidad de colaborar con un equipo de profesionales dedicados y apasionados por su trabajo. Juntos, podemos lograr grandes cosas y marcar una diferencia positiva en la sociedad.\r\n\r\n" +
                 "Además, nos aseguramos de que cada empleado tenga acceso a los recursos y el apoyo necesarios para tener éxito. Ofrecemos adaptaciones razonables y ajustes en el lugar de trabajo para satisfacer las necesidades individuales. Ya sea que necesites tecnología asistida, horarios flexibles o modificaciones en el entorno físico, estamos aquí para ayudarte.\r\n\r\n" +
                 "Te invitamos a unirte a nuestra comunidad y explorar las oportunidades que tenemos para ofrecer. Valoramos tu talento y estamos comprometidos a proporcionarte un entorno de trabajo inclusivo y enriquecedor. Tu éxito es nuestro éxito, y juntos podemos construir un futuro mejor.\r\n\r\n" +
                 "En nuestra empresa, la inclusión y la diversidad no son solo palabras, son principios fundamentales que guían nuestras acciones y decisiones. Estamos dedicados a crear un lugar de trabajo donde todos se sientan bienvenidos, respetados y empoderados para alcanzar su máximo potencial.\r\n\r\n" +
                 "Si estás listo para unirte a un equipo que valora la inclusión y la diversidad, y donde tu talento será reconocido y apreciado, te animamos a postularte. Juntos, podemos crear un entorno de trabajo que refleje nuestra misión de ofrecer la mejor experiencia y facilidad en el acceso a soluciones tecnológicas financieras.\r\n\r\n" +
                 "Además de los programas de capacitación y desarrollo, ofrecemos mentorías y oportunidades de networking para apoyar tu crecimiento profesional. Creemos en el desarrollo continuo y te proporcionaremos las herramientas y recursos necesarios para tu progreso. Trabajarás en proyectos desafiantes y significativos que te permitirán desarrollar nuevas habilidades y conocimientos.\r\n\r\n" +
                 "Nuestro compromiso con la inclusión también se refleja en nuestras políticas de contratación y promoción. Nos esforzamos por garantizar que todos los procesos sean justos y equitativos, y que cada candidato sea evaluado en función de sus habilidades y méritos. Valoramos la contribución única que cada persona puede hacer a nuestra organización.\r\n\r\n" +
                 "Te proporcionaremos un entorno de trabajo seguro y saludable, donde se respeten tus derechos y se valore tu bienestar. Implementamos políticas y prácticas que fomentan el equilibrio entre la vida laboral y personal, y promovemos la salud y el bienestar de nuestros empleados. Queremos que disfrutes de tu trabajo y te sientas realizado tanto personal como profesionalmente.\r\n\r\n" +
                 "En resumen, unirte a nuestra Base de Talento para Personas con Discapacidad te ofrecerá la oportunidad de desarrollar tu carrera en un entorno inclusivo, accesible y diverso. Trabajarás en proyectos emocionantes y significativos, rodeado de un equipo que valora tu contribución y te apoya en tu desarrollo. Si estás buscando un lugar donde tu talento sea reconocido y apreciado, y donde puedas marcar una diferencia, te invitamos a unirte a nosotros.\r\n\r\n" +
                 "Estamos ansiosos por conocerte y explorar cómo podemos apoyarte en tu camino profesional. Juntos, podemos construir un futuro donde la inclusión y la diversidad sean la norma, y donde cada persona tenga la oportunidad de alcanzar su máximo potencial.\r\n\r\n" +
                 "Al unirte a nuestra Base de Talento, formarás parte de una comunidad que celebra la diversidad y fomenta un entorno de trabajo inclusivo y respetuoso. Trabajaremos contigo para identificar tus habilidades y encontrar las oportunidades que mejor se adapten a tus intereses y objetivos. Queremos que te sientas empoderado para contribuir con tus ideas y experiencias únicas, y para crecer profesionalmente dentro de nuestra organización.\r\n\r\n" +
                 "Además, ofrecemos beneficios competitivos y programas de bienestar para apoyar tu salud y tu equilibrio entre la vida laboral y personal. Sabemos que un empleado feliz y saludable es más productivo y está más comprometido, por lo que nos esforzamos por crear un ambiente donde puedas prosperar en todos los aspectos de tu vida.\r\n\r\n" +
                 "Estamos comprometidos a mantener un diálogo abierto y continuo con nuestros empleados sobre temas de inclusión y diversidad. Valoramos tu feedback y estamos siempre buscando maneras de mejorar nuestras prácticas y políticas. Queremos asegurarnos de que todos se sientan escuchados y valorados, y de que cada empleado tenga la oportunidad de influir en la dirección de nuestra empresa.\r\n\r\n" +
                 "Si tienes pasión por la tecnología y las finanzas, y estás buscando un lugar donde tu talento sea valorado y tus contribuciones sean reconocidas, te invitamos a unirte a nuestra Base de Talento para Personas con Discapacidad. Juntos, podemos hacer una diferencia y construir un futuro más inclusivo y accesible para todos.\r\n\r\n" +
                 "En resumen, nuestra misión es crear un entorno de trabajo donde todos se sientan bienvenidos y apoyados, y donde cada individuo tenga la oportunidad de alcanzar su máximo potencial. Valoramos la diversidad y la inclusión, y estamos comprometidos a proporcionar un entorno de trabajo accesible y acogedor. Si estás listo para unirte a nosotros y hacer una diferencia, esperamos recibir tu aplicación.\r\n\r\n",
                    JobOfferModeId = 1,
                    PublicationDate = DateTime.Parse("06/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 2,
                    Vacancies = 6
                },

                new Offer
                {
                    OfferId = Guid.Parse("4c273bfd-06fd-4e2d-a5c1-d41e26a4ad13"),
                    CompanyId = Guid.Parse("a3fb7e92-6b31-4630-835c-3ea7d11e4306"),
                    Title = "CPS AR Automation engineer intern",
                    Description = "Participar en el desarrollo y ejecución de proyectos enfocados en la automatización y digitalización de nuestras operaciones en planta.\r\n" +
                  "Identificar y gestionar proveedores para soluciones integrales, mejorando nuestras eficiencias operacionales.\r\n" +
                  "Monitorear presupuestos y gastos de proyectos, asegurando un uso óptimo de recursos y una administración financiera responsable.\r\n" +
                  "Apoyar al equipo de Mantenimiento identificando y solucionando problemas para abordar fallos, contribuyendo a la fiabilidad y rendimiento general de nuestros sistemas.\r\n" +
                  "Nuestro equipo de automatización e ingeniería está buscando un estudiante talentoso y apasionado para unirse a nuestro programa de pasantías como Ingeniero de Automatización CPS AR. Este rol es una oportunidad emocionante para adquirir experiencia práctica en el desarrollo e implementación de soluciones de automatización en un entorno industrial dinámico. Como pasante de ingeniería de automatización, tendrás la oportunidad de trabajar en proyectos innovadores que impactan directamente en la eficiencia operativa y la competitividad de nuestra planta. Trabajarás en estrecha colaboración con nuestro equipo de ingeniería para diseñar, implementar y optimizar sistemas de control y monitoreo de procesos en toda la planta.\r\n" +
                  "Además de trabajar en proyectos específicos de ingeniería de automatización, tendrás la oportunidad de participar en actividades de desarrollo profesional, incluyendo sesiones de capacitación técnica, talleres de resolución de problemas y oportunidades de mentoría con expertos en la industria. Nuestro objetivo es proporcionarte una experiencia integral que te prepare para una exitosa carrera en el campo de la automatización industrial.\r\n" +
                  "Como parte de nuestro equipo de ingeniería de automatización, tendrás la oportunidad de aprender y trabajar con tecnologías de vanguardia en el campo de la automatización industrial, incluyendo sistemas de control PLC, HMI/SCADA, sistemas de visión artificial, robótica, y más. Trabajarás en proyectos emocionantes que abarcan desde la optimización de procesos existentes hasta el diseño y desarrollo de soluciones innovadoras para desafíos específicos de la planta.\r\n" +
                  "Nuestro programa de pasantías ofrece una experiencia única que combina aprendizaje práctico en el lugar de trabajo con oportunidades de desarrollo profesional y crecimiento personal. Nos comprometemos a brindarte las herramientas y el apoyo que necesitas para tener éxito en tu rol y avanzar en tu carrera en ingeniería de automatización.\r\n" +
                  "Si estás interesado en unirte a nuestro equipo como Ingeniero de Automatización CPS AR, nos encantaría saber de ti. ¡Aplica hoy para comenzar tu viaje hacia una emocionante carrera en la automatización industrial!\r\n",
                    JobOfferModeId = 1,
                    PublicationDate = DateTime.Parse("06/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("4c273bfd-06fd-4e2d-a5c1-d41e26a9ad13"),
                    CompanyId = Guid.Parse("a3fb7e92-6b31-4630-835c-3ea7d11e4306"),
                    Title = "CPS AR Automation engineer intern",
                    Description = "Participar en el desarrollo y ejecución de proyectos enfocados en la automatización y digitalización de nuestras operaciones en planta.\r\n" +
                  "Identificar y gestionar proveedores para soluciones integrales, mejorando nuestras eficiencias operacionales.\r\n" +
                  "Monitorear presupuestos y gastos de proyectos, asegurando un uso óptimo de recursos y una administración financiera responsable.\r\n" +
                  "Apoyar al equipo de Mantenimiento identificando y solucionando problemas para abordar fallos, contribuyendo a la fiabilidad y rendimiento general de nuestros sistemas.\r\n" +
                  "Nuestro equipo de automatización e ingeniería está buscando un estudiante talentoso y apasionado para unirse a nuestro programa de pasantías como Ingeniero de Automatización CPS AR. Este rol es una oportunidad emocionante para adquirir experiencia práctica en el desarrollo e implementación de soluciones de automatización en un entorno industrial dinámico. Como pasante de ingeniería de automatización, tendrás la oportunidad de trabajar en proyectos innovadores que impactan directamente en la eficiencia operativa y la competitividad de nuestra planta. Trabajarás en estrecha colaboración con nuestro equipo de ingeniería para diseñar, implementar y optimizar sistemas de control y monitoreo de procesos en toda la planta.\r\n" +
                  "Además de trabajar en proyectos específicos de ingeniería de automatización, tendrás la oportunidad de participar en actividades de desarrollo profesional, incluyendo sesiones de capacitación técnica, talleres de resolución de problemas y oportunidades de mentoría con expertos en la industria. Nuestro objetivo es proporcionarte una experiencia integral que te prepare para una exitosa carrera en el campo de la automatización industrial.\r\n" +
                  "Como parte de nuestro equipo de ingeniería de automatización, tendrás la oportunidad de aprender y trabajar con tecnologías de vanguardia en el campo de la automatización industrial, incluyendo sistemas de control PLC, HMI/SCADA, sistemas de visión artificial, robótica, y más. Trabajarás en proyectos emocionantes que abarcan desde la optimización de procesos existentes hasta el diseño y desarrollo de soluciones innovadoras para desafíos específicos de la planta.\r\n" +
                  "Nuestro programa de pasantías ofrece una experiencia única que combina aprendizaje práctico en el lugar de trabajo con oportunidades de desarrollo profesional y crecimiento personal. Nos comprometemos a brindarte las herramientas y el apoyo que necesitas para tener éxito en tu rol y avanzar en tu carrera en ingeniería de automatización.\r\n" +
                  "Si estás interesado en unirte a nuestro equipo como Ingeniero de Automatización CPS AR, nos encantaría saber de ti. ¡Aplica hoy para comenzar tu viaje hacia una emocionante carrera en la automatización industrial!\r\n",
                    JobOfferModeId = 1,
                    PublicationDate = DateTime.Parse("06/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("2a727bb0-902d-4f96-b57b-2a6e39d8a60e"),
                    CompanyId = Guid.Parse("a3fb7e92-6b31-4630-835c-3ea7d11e4306"),
                    Title = "CPS AR Laboratory Intern",
                    Description = "Follow-up of operational excellence tools\r\n" +
                  "Assistance to the area of sensory and microbiology\r\n" +
                  "Ingredient Validations\r\n" +
                  "Material life extension process\r\n" +
                  "Performance measurement of packaging supplies.\r\n" +
                  "We are looking for a Laboratory Intern to join our team in CPS AR. In this role, you will have the opportunity to work in a dynamic and innovative environment, supporting our laboratory operations and contributing to the development of new products and processes. As a Laboratory Intern, you will work closely with our team of scientists and engineers to conduct experiments, analyze data, and assist with day-to-day laboratory tasks. This is a great opportunity for a student or recent graduate to gain hands-on experience in a real-world laboratory setting and learn from industry experts.\r\n" +
                  "Responsibilities:\r\n" +
                  "- Follow-up of operational excellence tools to ensure compliance with quality standards.\r\n" +
                  "- Assistance to the area of sensory and microbiology, including sample preparation, analysis, and reporting.\r\n" +
                  "- Ingredient Validations: Assist with the validation of new ingredients and raw materials for use in our products.\r\n" +
                  "- Material life extension process: Support the team in testing and evaluating the shelf life of materials used in our packaging.\r\n" +
                  "- Performance measurement of packaging supplies: Help measure and analyze the performance of our packaging materials to ensure they meet our quality standards.\r\n" +
                  "Qualifications:\r\n" +
                  "- Currently enrolled in a Bachelor's or Master's degree program in Food Science, Biology, Chemistry, or related field.\r\n" +
                  "- Strong analytical and problem-solving skills.\r\n" +
                  "- Excellent communication and teamwork abilities.\r\n" +
                  "- Ability to work independently and collaboratively in a fast-paced environment.\r\n" +
                  "- Experience with laboratory techniques and equipment is a plus.\r\n" +
                  "If you are passionate about science and eager to gain valuable hands-on experience in a laboratory setting, we encourage you to apply for our Laboratory Intern position at CPS AR. Join us in our mission to develop innovative solutions that enhance the quality of life for people around the world.\r\n",
                    JobOfferModeId = 1,
                    PublicationDate = DateTime.Parse("04/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },

                new Offer
                {
                    OfferId = Guid.Parse("f4e7a8c0-0253-4baf-bd54-9a119ed81e5f"),
                    CompanyId = Guid.Parse("a3fb7e92-6b31-4630-835c-3ea7d11e4306"),
                    Title = "CPS AR Operador de producción interna",
                    Description = "Gestión de Materiales: Responsable de la recepción, almacenamiento y despacho de ingredientes, materiales de empaque y productos terminados. Usarás equipos como zorras, autoelevadores y/o apiladoras para mover estos materiales de manera eficiente.\r\n" +
                  "Uso de Tecnología: Manejar el sistema WMRF (Radiofrecuencia) para el cumplimiento de los procesos de almacenamiento y abastecimiento, garantizando la precisión en el manejo de inventarios.\r\n" +
                  "Optimización de Procesos: Llevar a cabo tareas de Picking, Packing, control de bultos, armado de pedidos, etiquetado e identificación de materiales, asegurando la máxima eficiencia en la cadena de suministro.\r\n" +
                  "Calidad y Seguridad: Operar siguiendo el Sistema de Gestión Integrado, abarcando normas como OHSAS 18000, ISO 9001, FSSC 22000, ISO 14001, GMP, y HACCP, manteniendo el alto estándar de calidad y seguridad de Coca-Cola.\r\n" +
                  "We are looking for a Production Operator Intern to join our team at CPS AR. In this role, you will be responsible for managing materials, using technology, optimizing processes, and ensuring quality and safety standards are met. This is a great opportunity to gain hands-on experience in a dynamic production environment and contribute to the success of our operations.\r\n" +
                  "Responsibilities:\r\n" +
                  "- Material Management: Responsible for receiving, storing, and dispatching ingredients, packaging materials, and finished products. Use equipment such as pallet jacks, forklifts, and/or stackers to move these materials efficiently.\r\n" +
                  "- Technology Use: Operate the WMRF (Radio Frequency) system to fulfill storage and replenishment processes, ensuring inventory handling accuracy.\r\n" +
                  "- Process Optimization: Perform tasks such as picking, packing, bundle control, order assembly, labeling, and material identification, ensuring maximum efficiency in the supply chain.\r\n" +
                  "- Quality and Safety: Operate following the Integrated Management System, covering standards such as OHSAS 18000, ISO 9001, FSSC 22000, ISO 14001, GMP, and HACCP, maintaining Coca-Cola's high quality and safety standards.\r\n" +
                  "Qualifications:\r\n" +
                  "- Currently enrolled in a Bachelor's or Master's degree program in Engineering, Operations Management, Supply Chain Management, or related field.\r\n" +
                  "- Strong analytical and problem-solving skills.\r\n" +
                  "- Ability to work independently and collaboratively in a fast-paced environment.\r\n" +
                  "- Excellent communication and teamwork abilities.\r\n" +
                  "- Experience with warehouse management systems and/or inventory control software is a plus.\r\n" +
                  "If you are passionate about operations and eager to gain valuable experience in a production environment, we encourage you to apply for our Production Operator Intern position at CPS AR. Join us in our mission to create refreshing moments of happiness for our consumers and make a positive impact on the world.\r\n",
                    JobOfferModeId = 1,
                    PublicationDate = DateTime.Parse("04/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("c45c63c4-bc31-4397-a38a-84241e441028"),
                    CompanyId = Guid.Parse("02bdfba1-5d7d-46f8-89c7-5d02a5fc7655"),
                    Title = "Desarrollador/a Fullstack (C#)",
                    Description = "Participar del desarrollo full stack (backend y frontend) de los nuevos sistemas de gestión que comercializará la empresa, mediante el uso de las tecnologías que se describen como excluyentes en la sección de requerimientos a continuación.\r\n" +
                  "Participar de las distintas etapas del proceso de desarrollo trabajando dentro del Área de Investigación y Desarrollo de la organización con un equipo conformado por un Gerente a cargo, un Jefe de Proyecto y dos o tres programadores.\r\n" +
                  "We are looking for a Fullstack Developer (C#) to join our team. In this role, you will participate in the full stack development (backend and frontend) of the new management systems that the company will commercialize. You will work with the technologies described as exclusive in the requirements section below and participate in the different stages of the development process within the Research and Development Area of the organization, with a team consisting of a Manager in charge, a Project Manager, and two or three programmers.\r\n" +
                  "Responsibilities:\r\n" +
                  "- Participate in the full stack development of new management systems, using the technologies described in the requirements section.\r\n" +
                  "- Work collaboratively with a team of professionals, including a Manager and Project Manager, to ensure successful project completion.\r\n" +
                  "- Contribute to the design, development, and testing of software solutions, adhering to best practices and coding standards.\r\n" +
                  "- Collaborate with stakeholders to gather requirements, analyze user needs, and deliver high-quality software products.\r\n" +
                  "- Stay updated on emerging technologies and industry trends to continuously improve development processes and solutions.\r\n" +
                  "Requirements:\r\n" +
                  "- Bachelor's degree in Computer Science, Software Engineering, or related field.\r\n" +
                  "- Proven experience in full stack development using C# and related technologies.\r\n" +
                  "- Strong understanding of software development methodologies, principles, and best practices.\r\n" +
                  "- Experience working in Agile environments and using version control systems (e.g., Git).\r\n" +
                  "- Excellent problem-solving skills and attention to detail.\r\n" +
                  "If you are a passionate Fullstack Developer with experience in C# and are eager to contribute to the development of innovative management systems, we encourage you to apply for our Desarrollador/a Fullstack (C#) position. Join us in our mission to create cutting-edge solutions that drive business success and improve user experiences.\r\n",
                    JobOfferModeId = 3,
                    PublicationDate = DateTime.Parse("07/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },

                new Offer
                {
                    OfferId = Guid.Parse("bbd240b5-09f1-497f-a74f-24831e84dfe2"),
                    CompanyId = Guid.Parse("02bdfba1-5d7d-46f8-89c7-5d02a5fc7655"),
                    Title = "Programador/a Visual Basic 6",
                    Description = "Mantenimiento y Desarrollo de Sistemas Administrativos, Contables, RRHH y Sueldos. \r\n" +
                  "Participar de las distintas etapas del proceso de desarrollo trabajando dentro del Área de Investigación y Desarrollo de la organización con un equipo conformado por un Gerente a cargo, un Jefe de Proyecto y dos o tres programadores. \r\n" +
                  "We are seeking a Visual Basic 6 Programmer to join our team. In this role, you will be responsible for the maintenance and development of administrative, accounting, HR, and payroll systems. You will participate in various stages of the development process within the Research and Development Area of the organization, working with a team consisting of a Manager in charge, a Project Manager, and two or three programmers.\r\n" +
                  "Responsibilities:\r\n" +
                  "- Maintain and develop administrative, accounting, HR, and payroll systems using Visual Basic 6.\r\n" +
                  "- Collaborate with a team of professionals to ensure successful project completion.\r\n" +
                  "- Participate in all stages of the development process, from planning and design to implementation and testing.\r\n" +
                  "- Work closely with stakeholders to gather requirements and ensure that solutions meet user needs.\r\n" +
                  "- Provide technical support and troubleshooting for existing systems.\r\n" +
                  "Requirements:\r\n" +
                  "- Bachelor's degree in Computer Science, Software Engineering, or related field.\r\n" +
                  "- Proven experience in Visual Basic 6 programming and software development.\r\n" +
                  "- Strong problem-solving skills and attention to detail.\r\n" +
                  "- Ability to work collaboratively in a team environment.\r\n" +
                  "- Excellent communication and interpersonal skills.\r\n" +
                  "If you are a skilled Visual Basic 6 Programmer with a passion for developing and maintaining systems, we encourage you to apply for our Programador/a Visual Basic 6 position. Join us in our mission to deliver high-quality software solutions that drive business success and streamline operations.\r\n",
                    JobOfferModeId = 3,
                    PublicationDate = DateTime.Parse("07/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("e7d81f16-93f1-462e-87c4-3a7b80db23d4"),
                    CompanyId = Guid.Parse("02bdfba1-5d7d-46f8-89c7-5d02a5fc7655"),
                    Title = "Analista de Siniestros ",
                    Description = "Gestión de siniestros de Robo (no Mobile) y Mercado Financiero.\r\n" +
                  "Análisis de coberturas, términos y condiciones de contratación, exclusiones, etc.\r\n" +
                  "Redacción de escritos, respuesta a oficios de organismos de control e informes.\r\n" +
                  "Intercambio de información con otros sectores de la Compañía, socios comerciales y clientes.\r\n" +
                  "Análisis de procesos internos en búsqueda de oportunidades de mejora y optimización.\r\n" +
                  "Participación en proyectos y armado de reportes.\r\n" +
                  "We are seeking a Claims Analyst to join our team. In this role, you will be responsible for managing theft (non-mobile) and financial market claims. You will analyze coverage, terms and conditions of contracts, exclusions, etc., and draft written responses to requests from regulatory agencies and reports. Additionally, you will collaborate with other departments within the company, business partners, and clients to exchange information. You will also analyze internal processes to identify opportunities for improvement and optimization, participate in projects, and prepare reports.\r\n" +
                  "Responsibilities:\r\n" +
                  "- Manage theft (non-mobile) and financial market claims.\r\n" +
                  "- Analyze coverage, terms and conditions of contracts, exclusions, etc.\r\n" +
                  "- Draft written responses to requests from regulatory agencies and reports.\r\n" +
                  "- Exchange information with other departments within the company, business partners, and clients.\r\n" +
                  "- Analyze internal processes to identify opportunities for improvement and optimization.\r\n" +
                  "- Participate in projects and prepare reports.\r\n" +
                  "Requirements:\r\n" +
                  "- Bachelor's degree in Insurance, Business Administration, or related field.\r\n" +
                  "- Proven experience in claims management or a related field.\r\n" +
                  "- Strong analytical and problem-solving skills.\r\n" +
                  "- Excellent written and verbal communication skills.\r\n" +
                  "- Ability to work independently and collaboratively in a team environment.\r\n" +
                  "If you have a passion for claims management and are looking for an opportunity to contribute to a dynamic team, we encourage you to apply for our Analista de Siniestros position. Join us in our mission to provide exceptional service and support to our clients while driving business success.\r\n",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("09/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("a8f1d525-85cf-47c5-80dc-1a6db6b687b0"),
                    CompanyId = Guid.Parse("02bdfba1-5d7d-46f8-89c7-5d02a5fc7655"),
                    Title = "Desarrollador/a PHP+Laravel SSR",
                    Description = "Desarrollar y mantener aplicaciones web, utilizando PHP - Laravel, siguiendo los estándares de codificación y las mejores prácticas de desarrollo.\r\n" +
                  "Colaborar con el equipo de desarrollo en el diseño de soluciones técnicas y de arquitectura que cumplan con los requisitos del proyecto.\r\n" +
                  "Realizar pruebas unitarias y de integración, para garantizar la estabilidad, la seguridad y el rendimiento de las aplicaciones.\r\n" +
                  "Participar proactivamente en las ceremonias de Scrum con el equipo de desarrollo.\r\n" +
                  "We are seeking a PHP+Laravel Developer to join our team. In this role, you will be responsible for developing and maintaining web applications using PHP - Laravel, following coding standards and best development practices. You will collaborate with the development team in designing technical solutions and architectures that meet project requirements. Additionally, you will conduct unit and integration tests to ensure application stability, security, and performance. You will also actively participate in Scrum ceremonies with the development team.\r\n" +
                  "Responsibilities:\r\n" +
                  "- Develop and maintain web applications using PHP - Laravel.\r\n" +
                  "- Collaborate with the development team in designing technical solutions and architectures.\r\n" +
                  "- Conduct unit and integration tests to ensure application stability, security, and performance.\r\n" +
                  "- Actively participate in Scrum ceremonies with the development team.\r\n" +
                  "Requirements:\r\n" +
                  "- Bachelor's degree in Computer Science, Software Engineering, or related field.\r\n" +
                  "- Proven experience in developing web applications using PHP - Laravel.\r\n" +
                  "- Strong understanding of coding standards and best development practices.\r\n" +
                  "- Experience with unit testing frameworks.\r\n" +
                  "- Knowledge of Scrum methodology.\r\n" +
                  "If you have a passion for web development and are proficient in PHP - Laravel, we encourage you to apply for our Desarrollador/a PHP+Laravel SSR position. Join us in our mission to deliver high-quality solutions that meet our clients' needs and exceed their expectations.\r\n",
                    JobOfferModeId = 3,
                    PublicationDate = DateTime.Parse("09/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("43172e18-c20b-41d1-b16d-5e15b7e788d7"),
                    CompanyId = Guid.Parse("02bdfba1-5d7d-46f8-89c7-5d02a5fc7655"),
                    Title = "Asesor Comercial de Recursos Humanos",
                    Description = "En esta emocionante oportunidad como Asesor Comercial de Recursos Humanos, te convertirás en un miembro valioso de nuestro equipo, desempeñando un papel fundamental en la captación comercial y el desarrollo de cuentas corporativas.\r\n" +
                  "Tu principal responsabilidad será brindar asesoramiento de mercado y consultoría de recursos humanos a una variedad de clientes corporativos. Esto incluirá comprender la segmentación del mercado y recopilar datos de contacto de clientes potenciales y existentes para desarrollar estrategias comerciales efectivas.\r\n" +
                  "Una parte integral de tu función será la planificación comercial, tanto proactiva como reactiva. Esto implica realizar visitas a clientes activos y potenciales, realizar televentas, enviar mailings y sensibilizar a los clientes sobre nuestros servicios y soluciones de recursos humanos.\r\n" +
                  "Además de tus tareas comerciales, serás responsable de la selección de perfiles profesionales para los clientes asignados, asegurando que sus necesidades de contratación sean atendidas de manera efectiva y eficiente. También tendrás la oportunidad de fidelizar a los clientes asignados, garantizando que estén satisfechos con nuestros servicios y generando una relación de confianza y colaboración a largo plazo.\r\n" +
                  "Nuestra misión es brindar la mejor experiencia posible a nuestros clientes, y como Asesor Comercial de Recursos Humanos, desempeñarás un papel crucial en la consecución de este objetivo. Tu capacidad para comprender las necesidades de los clientes, ofrecer soluciones personalizadas y establecer relaciones sólidas será fundamental para el éxito en esta función.\r\n" +
                  "Responsabilidades:\r\n" +
                  "- Captar clientes corporativos y desarrollar cuentas existentes.\r\n" +
                  "- Brindar asesoramiento de mercado y consultoría de recursos humanos.\r\n" +
                  "- Planificar y ejecutar estrategias comerciales proactivas y reactivas.\r\n" +
                  "- Seleccionar perfiles profesionales para clientes asignados.\r\n" +
                  "- Fidelizar a los clientes asignados y generar relaciones sólidas.\r\n" +
                  "Requisitos:\r\n" +
                  "- Experiencia previa en ventas, preferiblemente en el sector de recursos humanos.\r\n" +
                  "- Excelentes habilidades de comunicación y capacidad para establecer relaciones.\r\n" +
                  "- Orientación hacia resultados y capacidad para trabajar de manera autónoma.\r\n" +
                  "- Conocimiento del mercado laboral y tendencias en recursos humanos.\r\n" +
                  "- Licenciatura en Administración de Empresas, Recursos Humanos u otro campo relacionado.\r\n" +
                  "Si estás buscando una oportunidad emocionante en el campo de los recursos humanos y tienes pasión por las ventas y el servicio al cliente, ¡nos encantaría saber de ti! Únete a nuestro equipo y ayuda a impulsar el éxito de nuestros clientes y de nuestra empresa.\r\n",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("07/05/2024"),
                    CityId = 820147,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("1f8dbf01-6d33-4d6c-9d02-22686b739cf4"),
                    CompanyId = Guid.Parse("02bdfba1-5d7d-46f8-89c7-5d02a5fc7655"),
                    Title = "Data Engineer SSR - (c/inglés)",
                    Description = "El Data Engineer SSR, dentro de nuestra organización, juega un papel crítico en el diseño, desarrollo y mantenimiento de infraestructuras de datos robustas y eficientes para facilitar la toma de decisiones basada en datos. Su misión principal será integrar diversas fuentes de datos utilizando tecnologías de última generación, lo que permitirá a la empresa obtener información valiosa para impulsar su negocio hacia adelante.\r\n\r\nEn este rol, colaborará estrechamente con otros miembros del equipo para identificar, diseñar y construir conjuntos de datos y relaciones que permitan el análisis de datos complejos. Esto implicará la refactorización de las plataformas de datos existentes para integrarlas de manera efectiva con las soluciones de vanguardia disponibles en el mercado.\r\n\r\nUna de las responsabilidades clave será garantizar el cumplimiento de los estándares de datos y contribuir a la evolución de la arquitectura de datos de la empresa. Esto incluirá la implementación de infraestructura y procesos para garantizar la calidad de los datos, así como para mantener la integridad y seguridad de la información almacenada.\r\n\r\nAdemás, el Data Engineer SSR participará activamente en la evaluación y adopción de nuevas tecnologías y herramientas que mejoren la eficiencia y efectividad de los procesos de gestión de datos. Se espera que esté al tanto de las tendencias emergentes en el campo de la ciencia de datos y la ingeniería de datos, y que aplique ese conocimiento para impulsar la innovación dentro de la empresa.\r\n\r\nEste puesto requerirá habilidades sólidas en programación, conocimientos profundos de bases de datos y experiencia en el diseño e implementación de arquitecturas de datos escalables y resilientes. Además, la capacidad para trabajar en equipo, comunicarse de manera efectiva y adaptarse rápidamente a los cambios serán aspectos fundamentales para el éxito en esta función.\r\n\r\nComo requisito adicional, se valorará el dominio del idioma inglés, ya que parte de la comunicación y colaboración puede requerir interactuar con equipos internacionales y utilizar recursos en línea disponibles en ese idioma.\r\n\r\nEn resumen, el Data Engineer SSR desempeñará un papel esencial en el desarrollo y mantenimiento de los cimientos tecnológicos que respaldan la toma de decisiones basada en datos en nuestra empresa. Este es un rol desafiante y gratificante para aquellos que buscan contribuir significativamente al éxito y crecimiento de una organización en constante evolución en el campo de la tecnología y los datos.",
                    JobOfferModeId = 3,
                    PublicationDate = DateTime.Parse("07/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("99c4892f-d048-459e-ae27-7dd3fd0b0839"),
                    CompanyId = Guid.Parse("02bdfba1-5d7d-46f8-89c7-5d02a5fc7655"),
                    Title = "Gerente de Logística",
                    Description = "El rol de Gerente de Logística es fundamental en cualquier organización que maneje operaciones de distribución y abastecimiento. Esta posición implica una serie de responsabilidades cruciales para el éxito de la empresa. El Gerente de Logística tiene como principal objetivo coordinar y gestionar todas las actividades relacionadas con la logística y el abastecimiento, asegurando un flujo eficiente de productos desde el punto de origen hasta el destino final.\r\n\r\nUna de las principales responsabilidades del Gerente de Logística es liderar y gestionar el equipo de trabajo. Esto incluye reclutar, capacitar y supervisar al personal, así como también establecer objetivos claros y proporcionar orientación y dirección para garantizar un rendimiento óptimo del equipo. El Gerente de Logística debe fomentar un ambiente de trabajo colaborativo y motivador que promueva la excelencia y el crecimiento profesional.\r\n\r\nOtra tarea importante del Gerente de Logística es coordinar y ser responsable de los procesos de recepción, despacho y abastecimiento de clientes. Esto implica asegurar que los productos sean entregados en tiempo y forma, cumpliendo con los estándares de calidad y servicio establecidos por la empresa. El Gerente de Logística debe trabajar en estrecha colaboración con otros departamentos, como producción, ventas y atención al cliente, para garantizar una comunicación fluida y una coordinación eficiente de las operaciones.\r\n\r\nAdemás de supervisar las operaciones diarias, el Gerente de Logística también tiene la responsabilidad de rediseñar procesos y generar eficiencias en la administración y efectividad de los espacios. Esto puede implicar la implementación de nuevas tecnologías, la optimización de rutas de entrega, la negociación con proveedores y la identificación de áreas de mejora en los procesos existentes.\r\n\r\nLa sistematización del área es otro aspecto clave del rol del Gerente de Logística. Esto implica implementar sistemas de gestión de almacenes y seguimiento de inventario que permitan una gestión eficiente de los recursos y una visibilidad completa de las operaciones en tiempo real. El Gerente de Logística debe estar al tanto de las últimas tendencias y tecnologías en logística y abastecimiento, y estar dispuesto a adoptar nuevas herramientas y metodologías para mejorar continuamente las operaciones de la empresa.\r\n\r\nDesarrollar e implementar políticas, procedimientos e iniciativas que permitan cumplir con los requisitos de la organización es una responsabilidad clave del Gerente de Logística. Esto incluye establecer estándares de calidad y servicio, definir procesos de control de calidad y seguridad, y garantizar el cumplimiento de las normativas y regulaciones locales e internacionales.\r\n\r\nDetectar áreas de mejora y proponer medidas correctivas es una parte integral del rol del Gerente de Logística. Esto implica analizar los datos y métricas de rendimiento, identificar oportunidades de optimización y tomar medidas proactivas para abordar cualquier problema o desafío que pueda surgir en las operaciones de la empresa.\r\n\r\nFinalmente, el Gerente de Logística tiene la responsabilidad de asegurar el cumplimiento en tiempo y forma de los planes de entrega y recepción. Esto implica coordinar con transportistas y proveedores externos, monitorear el progreso de los envíos y resolver cualquier problema o retraso que pueda surgir durante el proceso de entrega.\r\n\r\nEn resumen, el Gerente de Logística desempeña un papel fundamental en la gestión de las operaciones de distribución y abastecimiento de una empresa. Este rol requiere habilidades de liderazgo, conocimientos técnicos y capacidad para tomar decisiones efectivas en un entorno dinámico y exigente. Si estás interesado en asumir este desafío y contribuir al éxito de una organización, ¡esperamos tu solicitud para esta posición emocionante y gratificante!",
                    JobOfferModeId = 1,
                    PublicationDate = DateTime.Parse("09/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 3,
                },
                new Offer
                {
                    OfferId = Guid.Parse("c64b0cc7-bd3d-4db3-91c1-4cc6f8dbb3d2"),
                    CompanyId = Guid.Parse("02bdfba1-5d7d-46f8-89c7-5d02a5fc7655"),
                    Title = "Coordinadora Comercial",
                    Description = "¡Únete a nuestro equipo como Coordinadora Comercial y sé parte de una empresa en constante crecimiento y desarrollo! En este emocionante rol, serás responsable de gestionar y liderar a nuestra fuerza de ventas, desempeñando un papel crucial en la satisfacción y fidelización de nuestros valiosos clientes.\r\n" +
                  "Como Coordinadora Comercial, serás el punto focal en la interacción con nuestros clientes, brindando soluciones rápidas y efectivas a consultas y problemas. Tu capacidad para comprender las necesidades de los clientes y proporcionar respuestas precisas y oportuas será fundamental para garantizar una experiencia excepcional del cliente.\r\n" +
                  "Una de tus responsabilidades principales será coordinar todas las acciones de nuestros locales, asegurando la excelencia y los estándares de atención al cliente en cada interacción. Esto incluirá la supervisión del personal, la implementación de procedimientos operativos efectivos y la resolución de cualquier problema o desafío que pueda surgir.\r\n" +
                  "Además de liderar al equipo de ventas y coordinar las operaciones de los locales, también serás responsable de la correcta administración y funcionamiento de los locales a tu cargo. Esto implicará la gestión del inventario completo, incluidos los elementos de marketing, los accesorios y el servicio técnico. Tu capacidad para mantener un inventario preciso y organizado garantizará que tengamos los recursos necesarios para satisfacer las demandas de nuestros clientes en todo momento.\r\n" +
                  "Requisitos para el puesto:\r\n" +
                  "- Experiencia previa en roles de coordinación comercial o gestión de ventas.\r\n" +
                  "- Habilidades sólidas de liderazgo y capacidad para motivar y desarrollar equipos.\r\n" +
                  "- Excelentes habilidades de comunicación y capacidad para interactuar efectivamente con clientes y colegas.\r\n" +
                  "- Orientación al cliente y pasión por brindar un servicio excepcional.\r\n" +
                  "- Capacidad para trabajar de manera efectiva en un entorno dinámico y de ritmo rápido.\r\n" +
                  "Si estás listo para asumir un nuevo desafío emocionante y tienes la experiencia y las habilidades necesarias para tener éxito como Coordinador Comercial, ¡esperamos con interés recibir tu solicitud y darte la bienvenida a nuestro equipo!\r\n",
                    JobOfferModeId = 3,
                    PublicationDate = DateTime.Parse("07/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("2cf0284d-143f-4375-8a07-4d5e2c38a54e"),
                    CompanyId = Guid.Parse("02bdfba1-5d7d-46f8-89c7-5d02a5fc7655"),
                    Title = "Director Comercial",
                    Description = "¡Únete a nuestro equipo como Director Comercial y lidera el camino hacia el éxito! En este emocionante rol, serás responsable de dirigir y supervisar al equipo comercial para alcanzar y superar los objetivos establecidos por la empresa.\r\n" +
                  "Como Director Comercial, serás el arquitecto de nuestras estrategias de ventas, diseñando y ejecutando planes para impulsar el crecimiento del negocio y expandir nuestra red de concesionarias en todo el país. Tu capacidad para analizar el mercado y las tendencias te permitirá identificar nuevas oportunidades de negocio y desarrollar enfoques innovadores para satisfacer las necesidades de nuestros clientes.\r\n" +
                  "Una de tus responsabilidades clave será establecer relaciones sólidas con clientes clave y socios comerciales, asegurando una colaboración efectiva y beneficios mutuos. Además, gestionarás y optimizarás los recursos comerciales disponibles para garantizar la eficiencia y rentabilidad de nuestras operaciones.\r\n" +
                  "Como líder del equipo comercial, implementarás sistemas y procesos para mejorar la gestión de ventas y aumentar el rendimiento del equipo. Tu capacidad para inspirar y motivar a tu equipo será fundamental para cultivar un entorno de trabajo dinámico y orientado a resultados.\r\n" +
                  "Requisitos para el puesto:\r\n" +
                  "- Experiencia previa en roles de dirección comercial o gestión de ventas, preferiblemente en el sector automotriz.\r\n" +
                  "- Habilidades demostradas para liderar y motivar equipos hacia el éxito.\r\n" +
                  "- Excelentes habilidades de comunicación y negociación.\r\n" +
                  "- Orientación al cliente y enfoque en la satisfacción del cliente.\r\n" +
                  "- Capacidad para tomar decisiones estratégicas y resolver problemas de manera efectiva.\r\n" +
                  "Si estás listo para asumir este emocionante desafío y tienes la experiencia y habilidades necesarias para tener éxito como Director Comercial, ¡esperamos con interés recibir tu solicitud y darte la bienvenida a nuestro equipo!\r\n",
                    JobOfferModeId = 1,
                    PublicationDate = DateTime.Parse("04/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("3a4c5c3d-8b42-4600-9a6a-6e34f1d98d4a"),
                    CompanyId = Guid.Parse("02bdfba1-5d7d-46f8-89c7-5d02a5fc7655"),
                    Title = "Analista de Planeamiento Sr.",
                    Description = "¡Únete a nuestro equipo como Analista de Planeamiento Sr. y sé parte de la estrategia de crecimiento y desarrollo de nuestra empresa! En este apasionante rol, serás responsable de realizar análisis de proyectos de inversión y desarrollos de nuevos negocios, contribuyendo directamente a la toma de decisiones estratégicas de la compañía.\r\n" +
                  "Como Analista de Planeamiento Sr., llevarás a cabo investigaciones y análisis exhaustivos del mercado y la competencia para identificar amenazas y oportunidades estratégicas. Utilizando tus habilidades analíticas, participarás en el desarrollo y creación de previsiones de escenarios y modelos analíticos que respalden la toma de decisiones a nivel gerencial.\r\n" +
                  "Una de tus responsabilidades clave será el seguimiento de los indicadores clave de rendimiento (KPI) para controlar y ajustar el plan estratégico de la compañía, asegurando el cumplimiento de los objetivos establecidos. Además, estarás a cargo de realizar análisis ad hoc para abordar preguntas específicas o situaciones emergentes que requieran análisis detallados.\r\n" +
                  "Requisitos para el puesto:\r\n" +
                  "- Experiencia previa en roles de planeamiento, análisis de negocios o estrategia, preferiblemente en el sector empresarial.\r\n" +
                  "- Sólidas habilidades analíticas y capacidad para interpretar datos complejos.\r\n" +
                  "- Conocimiento avanzado de herramientas de análisis y visualización de datos (por ejemplo, Excel, Power BI, Tableau).\r\n" +
                  "- Excelentes habilidades de comunicación y capacidad para trabajar en equipo.\r\n" +
                  "- Orientación a resultados y capacidad para trabajar bajo presión en un entorno dinámico.\r\n" +
                  "Si estás buscando un desafío estimulante en el área de planeamiento estratégico y tienes la experiencia y habilidades necesarias para destacarte en este rol, ¡esperamos con interés recibir tu solicitud y considerarte para unirte a nuestro equipo!\r\n",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("04/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("c7cfc748-3e39-42c8-8dd9-dc326d9a0362"),
                    CompanyId = Guid.Parse("be76d6cb-0532-4dd5-8e4e-f944faf0106b"),
                    Title = "Analista de Prevención de Lavado de Dinero",
                    Description = "¡Únete a nuestro equipo como Analista de Prevención de Lavado de Dinero y contribuye a proteger nuestra empresa y clientes contra actividades financieras ilícitas! En este rol desafiante, serás responsable de proporcionar soporte funcional de segundo nivel para el software de Anti Money Laundering (AML), asegurando su correcto funcionamiento y cumplimiento de los requisitos regulatorios.\r\n" +
                  "Como Analista de Prevención de Lavado de Dinero, tendrás la tarea de analizar y derivar los casos de soporte, lo cual incluye el reconocimiento del problema, su evaluación y síntesis para su resolución efectiva. Además, colaborarás en la configuración de las implementaciones del software, apoyando el soporte operativo de las soluciones actuales y proponiendo mejoras para optimizar su rendimiento y eficacia.\r\n" +
                  "Una parte crucial de tu función será la creación de automatizaciones de reportes que eficienticen la tarea de los analistas, permitiendo una detección más rápida y precisa de posibles actividades sospechosas. Además, serás responsable de diseñar y aplicar controles tendientes a resguardar nuestro ecosistema y prevenir el lavado de dinero y otros delitos financieros.\r\n" +
                  "Requisitos para el puesto:\r\n" +
                  "- Experiencia previa en funciones similares en el sector financiero o de servicios financieros, con conocimiento sólido de las regulaciones y prácticas anti lavado de dinero.\r\n" +
                  "- Conocimiento técnico de sistemas de Anti Money Laundering (AML) y experiencia en su implementación y configuración.\r\n" +
                  "- Habilidades analíticas avanzadas y capacidad para resolver problemas complejos de manera efectiva.\r\n" +
                  "- Excelentes habilidades de comunicación y capacidad para trabajar en equipo en un entorno colaborativo y multidisciplinario.\r\n" +
                  "- Orientación a resultados y capacidad para trabajar bajo presión en un entorno dinámico y regulado.\r\n" +
                  "Si estás buscando un desafío emocionante en el campo de la prevención del lavado de dinero y tienes la experiencia y habilidades necesarias para sobresalir en este rol, ¡esperamos con interés recibir tu solicitud y considerarte para unirte a nuestro equipo!\r\n",
                    JobOfferModeId = 1,
                    PublicationDate = DateTime.Parse("09/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("9a2e26ab-9a47-4b71-907b-9a6c4e9db9d5"),
                    CompanyId = Guid.Parse("be76d6cb-0532-4dd5-8e4e-f944faf0106b"),
                    Title = "Analista de Estrategia, Engagement & Growth Marketing",
                    Description = "¡Únete a nuestro equipo como Analista de Estrategia, Engagement & Growth Marketing y sé parte de nuestra misión de hacer crecer nuestro negocio en Mercado Libre a través de estrategias innovadoras y efectivas de adquisición, activación y engagement de usuarios!\r\n" +
                  "En este rol desafiante, serás responsable de diseñar y ejecutar estrategias de adquisición, recovery, activación y engagement de usuarios de Mercado Libre, utilizando canales propios como Push, Email y WhatsApp. Tu objetivo principal será optimizar la performance de estas estrategias en base al ROI de las campañas, asegurando un crecimiento sostenible y rentable del negocio.\r\n" +
                  "Como Analista de Estrategia, Engagement & Growth Marketing, monitorearás de cerca la performance de las estrategias y analizarás las métricas obtenidas para identificar oportunidades de mejora y optimización. Ejecutarás la mejora continua de las campañas a través de acciones de experimentación y optimización, incluyendo segmentación de audiencias, A/B testing, automatización de journeys y más.\r\n" +
                  "Una parte crucial de tu función será la identificación de oportunidades mediante el análisis de grandes volúmenes de datos relacionados con el comportamiento de usuarios, indicadores de negocio y performance de campañas. Además, coordinarás mesas de trabajo con los principales stakeholders, incluyendo áreas como Modeling para desarrollar modelos de Machine Learning, Producto, Negocio, Marketing, Tecnología y User Experience, con el objetivo de acelerar el crecimiento del negocio y asegurar una experiencia de usuario excepcional.\r\n" +
                  "Requisitos para el puesto:\r\n" +
                  "- Experiencia previa en roles similares en el área de marketing digital, adquisición de usuarios o growth marketing, preferentemente en empresas de tecnología o comercio electrónico.\r\n" +
                  "- Conocimiento sólido de herramientas y plataformas de marketing digital, así como métricas de performance y análisis de datos.\r\n" +
                  "- Habilidades analíticas avanzadas y capacidad para interpretar y actuar en base a datos.\r\n" +
                  "- Excelentes habilidades de comunicación y capacidad para trabajar en equipo en un entorno multidisciplinario y colaborativo.\r\n" +
                  "- Orientación a resultados y capacidad para trabajar bajo presión en un entorno dinámico y competitivo.\r\n" +
                  "Si estás buscando un desafío emocionante en el campo del marketing digital y tienes la experiencia y habilidades necesarias para sobresalir en este rol, ¡esperamos con interés recibir tu solicitud y considerarte para unirte a nuestro equipo!\r\n",
                    JobOfferModeId = 1,
                    PublicationDate = DateTime.Parse("09/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("cbf7c2f6-fb22-4a5e-ae56-60798fcdaf35"),
                    CompanyId = Guid.Parse("be76d6cb-0532-4dd5-8e4e-f944faf0106b"),
                    Title = "Analista de Prevención de Lavado de Dinero",
                    Description = "¡Únete a nuestro equipo como Analista de Prevención de Lavado de Dinero y contribuye a proteger nuestro ecosistema financiero mediante la detección y prevención de actividades ilícitas de lavado de dinero!\r\n" +
                  "En este rol desafiante, serás responsable de brindar soporte funcional de segundo nivel del software de Anti Money Laundering, asegurando un entendimiento profundo del comportamiento del software en un contexto regulatorio. Serás el punto de contacto clave para analizar y derivar los casos de soporte, incluyendo el reconocimiento del problema, su evaluación y síntesis.\r\n" +
                  "Además, serás responsable de configurar las implementaciones del software, colaborar en el soporte operativo de las soluciones actuales y proponer mejoras para optimizar su performance. Utilizarás tu expertise para crear automatizaciones de reportes que eficienticen la tarea de los analistas y contribuirás activamente a la creación de controles tendientes a resguardar nuestro ecosistema.\r\n" +
                  "Requisitos para el puesto:\r\n" +
                  "- Experiencia previa en roles similares en instituciones financieras, empresas de tecnología financiera o áreas de cumplimiento normativo, especialmente en el área de prevención de lavado de dinero.\r\n" +
                  "- Conocimiento sólido de regulaciones y normativas relacionadas con la prevención de lavado de dinero, así como de herramientas y técnicas de detección de actividades sospechosas.\r\n" +
                  "- Habilidades analíticas avanzadas y capacidad para interpretar y actuar en base a datos complejos.\r\n" +
                  "- Excelentes habilidades de comunicación y capacidad para trabajar en equipo en un entorno multidisciplinario y colaborativo.\r\n" +
                  "- Orientación a resultados y capacidad para trabajar bajo presión en un entorno dinámico y competitivo.\r\n" +
                  "Si estás buscando un desafío emocionante en el campo de la prevención de lavado de dinero y tienes la experiencia y habilidades necesarias para sobresalir en este rol, ¡esperamos con interés recibir tu solicitud y considerarte para unirte a nuestro equipo!\r\n",
                    JobOfferModeId = 1,
                    PublicationDate = DateTime.Parse("09/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("cfb54849-13f6-4db0-aa4b-810c502b5de5"),
                    CompanyId = Guid.Parse("d51252c3-6e21-4ffc-aab3-f4bda791a574"),
                    Title = "Analista Comercial de Pagos Offline - Mercado Pago",
                    Description = "Seguir democratizando los pagos y desarrollando las grandes cuentas de Buenos Aires.\r\nDetectar oportunidades de negocio para nuestro porfolio de soluciones de cobros presenciales vía QR y Point, y colaborar en el diseño e implementación de una estrategia que asegure el desarrollo del negocio.\r\nImpulsar la adopción de nuestras soluciones en determinados segmentos y sectores, y actuar como responsable del territorio asignado.\r\nAsistir y capacitar a nuevas y nuevos clientes de la cartera asesorada, en la puesta en marcha de sus operaciones con Mercado Pago, a fin de optimizar su desempeño.\r\nMonitorear los indicadores de performance de los sectores y negocios, en pos de la mejora continua.\r\n\r\nEl Analista Comercial de Pagos Offline de Mercado Pago tiene una tarea fundamental en la empresa. Su labor contribuye directamente a la misión de democratizar los pagos, ofreciendo soluciones innovadoras y accesibles para todos. En este rol, el analista no solo se enfoca en el presente, sino que también mira hacia el futuro, identificando oportunidades de negocio y diseñando estrategias para asegurar el crecimiento sostenible de la empresa.\r\n\r\nUna de las principales responsabilidades del analista es detectar oportunidades de negocio en el mercado de pagos offline. Esto implica estudiar el comportamiento de los consumidores, analizar tendencias del mercado y evaluar la competencia. Con esta información, el analista puede proponer nuevas soluciones o mejorar las existentes para satisfacer las necesidades de los clientes y aumentar la participación de mercado de Mercado Pago.\r\n\r\nOtra tarea importante del analista es impulsar la adopción de las soluciones de Mercado Pago en diversos segmentos y sectores. Para lograrlo, el analista debe trabajar en estrecha colaboración con el equipo de ventas, brindando capacitación y asesoramiento a los clientes para que puedan implementar las soluciones de manera efectiva. Además, el analista actúa como responsable del territorio asignado, asegurando que se cumplan los objetivos comerciales en esa área.\r\n\r\nLa capacitación y el soporte a los clientes son aspectos clave del trabajo del analista. Al interactuar directamente con los clientes, el analista puede comprender mejor sus necesidades y desafíos, lo que le permite brindar soluciones personalizadas y efectivas. Además, el analista monitorea de cerca los indicadores de performance de los sectores y negocios, identificando oportunidades de mejora y ajustando las estrategias según sea necesario.\r\n\r\nEn resumen, el Analista Comercial de Pagos Offline de Mercado Pago juega un papel crucial en la expansión y consolidación de la empresa en el mercado de pagos. Su trabajo no solo implica identificar oportunidades de negocio y desarrollar estrategias para aprovecharlas, sino también brindar un servicio excepcional a los clientes y contribuir al crecimiento y éxito continuo de Mercado Pago en la industria de pagos.\r\n\r\n",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("10/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("3bd4a3b0-d922-41f4-b32e-683372920c77"),
                    CompanyId = Guid.Parse("d51252c3-6e21-4ffc-aab3-f4bda791a574"),
                    Title = "Software Senior Expert Mercado Play - IT",
                    Description = "Únete a nuestro equipo como Software Senior Expert Mercado Play - IT y lidera múltiples iniciativas técnicas en el stack de Frontend (Web, Android, iOS y Connected TVs), desarrollando soluciones escalables y de alta disponibilidad para OTT.\r\n" +
                  "En este rol, trabajarás de manera hands-on junto a los equipos, con un enfoque tanto en el frontend como en el backend, reconociendo que un buen diseño es fundamental para la performance de las experiencias de usuario. Gestionarás el trabajo con los stakeholders, demostrando habilidades para manejar expectativas y comunicar información compleja de manera clara y efectiva a una audiencia diversa.\r\n" +
                  "Serás el encargado de resolver problemas críticos de software en un contexto de emergencia, a la vez que compartirás tu conocimiento técnico con el equipo para promover el crecimiento y la excelencia técnica.\r\n" +
                  "Requisitos para el puesto:\r\n" +
                  "- Experiencia sólida en desarrollo de software, con un enfoque especial en el stack de Frontend y experiencia en plataformas OTT.\r\n" +
                  "- Habilidades técnicas avanzadas en tecnologías como Web, Android, iOS y Connected TVs.\r\n" +
                  "- Capacidad para liderar y gestionar proyectos técnicos complejos, trabajando de manera efectiva en un entorno colaborativo y multidisciplinario.\r\n" +
                  "- Excelentes habilidades de comunicación y capacidad para influir en los demás.\r\n" +
                  "- Orientación a resultados y capacidad para tomar decisiones en situaciones de presión.\r\n" +
                  "Si estás buscando un desafío emocionante en el campo de la tecnología y tienes la experiencia y habilidades necesarias para destacarte en este rol, ¡esperamos con interés recibir tu solicitud y considerarte para unirte a nuestro equipo!\r\n",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("05/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("d394e91d-6950-4485-b2d2-0c1e8f2ad588"),
                    CompanyId = Guid.Parse("d51252c3-6e21-4ffc-aab3-f4bda791a574"),
                    Title = "Analista de Capacidad y Transporte - Mercado Envíos",
                    Description = "Únete a nuestro equipo como Analista de Capacidad y Transporte en Mercado Envíos y lidera la identificación y desarrollo de casos de negocio para mejorar la eficiencia operativa, la calidad del servicio y la velocidad de entrega.\r\n" +
                  "En este rol desafiante, evaluarás el impacto de factores externos, como la estacionalidad y eventos, en las proyecciones de demanda para asegurar el correcto dimensionamiento de la red. Monitorearás métricas de red para detectar oportunidades de mejora y diseñar soluciones junto con otros equipos. Además, desarrollarás nuevas herramientas, análisis e insights para optimizar continuamente el proceso, agregando valor al ecosistema y haciéndolo más eficiente y escalable.\r\n" +
                  "Requisitos para el puesto:\r\n" +
                  "- Experiencia previa en análisis de capacidad y transporte, preferiblemente en el sector logístico o ecommerce.\r\n" +
                  "- Conocimiento sólido de herramientas y metodologías de análisis de datos.\r\n" +
                  "- Habilidades analíticas avanzadas y capacidad para trabajar con grandes volúmenes de datos.\r\n" +
                  "- Excelentes habilidades de comunicación y capacidad para colaborar eficazmente con equipos multidisciplinarios.\r\n" +
                  "- Orientación a resultados y capacidad para tomar decisiones basadas en datos.\r\n" +
                  "Si estás buscando un desafío emocionante en el campo de la logística y tienes la experiencia y habilidades necesarias para sobresalir en este rol, ¡esperamos con interés recibir tu solicitud y considerarte para unirte a nuestro equipo!\r\n",
                    JobOfferModeId = 1,
                    PublicationDate = DateTime.Parse("09/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("33f8289d-b24f-45d6-b537-0a61b3cb4bbd"),
                    CompanyId = Guid.Parse("d51252c3-6e21-4ffc-aab3-f4bda791a574"),
                    Title = "Analista de Riesgo de Créditos - Mercado Crédito",
                    Description = "¡Únete a nuestro equipo como Analista de Riesgo de Créditos en Mercado Crédito y contribuye a optimizar nuestra cartera de clientes con productos de crédito mediante análisis y segmentación!\r\n" +
                  "En este rol desafiante, serás responsable de analizar la cartera de clientes y asistir en su segmentación por perfil de riesgo y pricing, trabajando en conjunto con el equipo de Modelos. Aportarás ideas para el desarrollo de modelos predictivos de riesgo de crédito y adopción, con el objetivo de mejorar las tasas de mora de la cartera y la efectividad de las campañas.\r\n" +
                  "Además, realizarás análisis cuantitativos sobre el negocio, abordando aspectos como mora, adopción y rentabilidad, con aperturas de segmentos, modelos, entre otros.\r\n" +
                  "Como requisitos para el puesto, valoraremos tu experiencia previa en análisis de riesgo de créditos, preferiblemente en el sector financiero o fintech. Es fundamental contar con un conocimiento sólido de técnicas y herramientas de análisis cuantitativo, así como experiencia en modelado predictivo. Además, buscamos personas con habilidades analíticas avanzadas y capacidad para interpretar y comunicar resultados de manera efectiva. La orientación a resultados y la capacidad para trabajar en equipo en un entorno dinámico y colaborativo son cualidades que valoramos en nuestros colaboradores.\r\n" +
                  "Si estás buscando un desafío emocionante en el campo de la gestión de riesgos crediticios y tienes la experiencia y habilidades necesarias para sobresalir en este rol, ¡esperamos con interés recibir tu solicitud y considerarte para unirte a nuestro equipo!\r\n" +
                  "Nuestro compromiso con la excelencia y la innovación nos impulsa a buscar constantemente talento excepcional que comparta nuestra visión y nuestros valores. En Mercado Crédito, nos esforzamos por crear un ambiente de trabajo inclusivo y diverso donde todas las personas sean valoradas y respetadas por sus contribuciones únicas. Valoramos la diversidad de pensamiento y experiencias, y creemos que esta diversidad nos hace más fuertes como equipo. Al unirte a nosotros, tendrás la oportunidad de trabajar en proyectos desafiantes y significativos que impactan directamente en millones de usuarios en toda la región. Te ofrecemos un entorno dinámico y colaborativo donde podrás desarrollarte profesionalmente y alcanzar tu máximo potencial.\r\n" +
                  "Si estás listo para enfrentar nuevos desafíos y contribuir al éxito de un equipo apasionado y diverso, ¡esperamos con interés conocerte y explorar juntos las oportunidades que tenemos para ofrecerte en Mercado Crédito!\r\n",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("09/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("ff46f91a-6509-462b-8ff3-92c89c17c738"),
                    CompanyId = Guid.Parse("d51252c3-6e21-4ffc-aab3-f4bda791a574"),
                    Title = "Especialista de Herramientas de Growth - Mercado Pago.",
                    Description = "¡Únete a nuestro equipo como Especialista de Herramientas de Growth en Mercado Pago y contribuye a mejorar y optimizar nuestras herramientas de crecimiento para impulsar el negocio!\r\n" +
                  "En este rol desafiante, serás responsable de identificar oportunidades para mejorar y optimizar los contenidos y herramientas de crecimiento utilizadas en el negocio. Utilizarás análisis de datos para identificar tendencias y sacar conclusiones que ayuden a tomar decisiones efectivas.\r\n" +
                  "Además, colaborarás estrechamente con equipos internos para implementar cambios y mejoras en las herramientas existentes, actuando como un punto de contacto clave entre diferentes equipos de negocio, marketing, producto, tecnología, entre otros.\r\n" +
                  "Medirás y reportarás el impacto de las mejoras implementadas en las herramientas de crecimiento, asegurando la eficacia de las estrategias implementadas.\r\n" +
                  "Como requisitos para el puesto, valoraremos tu experiencia previa en roles similares, preferiblemente en el sector financiero o tecnológico. Es fundamental contar con habilidades analíticas avanzadas y capacidad para interpretar y comunicar resultados de manera efectiva. Además, buscamos personas con capacidad para trabajar en equipo y gestionar relaciones interdepartamentales en un entorno dinámico y colaborativo.\r\n" +
                  "Si estás buscando un desafío emocionante en el campo de las herramientas de crecimiento y tienes la experiencia y habilidades necesarias para sobresalir en este rol, ¡esperamos con interés recibir tu solicitud y considerarte para unirte a nuestro equipo!\r\n",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("06/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },

                new Offer
                {
                    OfferId = Guid.Parse("6ee3d748-65bc-4fe4-8314-2033f1c002d1"),
                    CompanyId = Guid.Parse("d51252c3-6e21-4ffc-aab3-f4bda791a574"),
                    Title = "Analista de Integración con Producto y Nuevas Conexiones - Mercado Pago",
                    Description = "¡Únete a nuestro equipo como Analista de Integración con Producto y Nuevas Conexiones en Mercado Pago y sé parte del proceso de diseño e integración de nuevos productos y conexiones que se lanzan en Mercado Pago cross regiones!\r\n" +
                  "En este emocionante rol, serás el punto focal durante el diseño e integración de nuevos productos y conexiones, actuando como el nexo entre Operaciones y las áreas de negocio regional, negocio corporativo, producto e IT.\r\n" +
                  "Tu responsabilidad principal será realizar el mapeo y entendimiento del flujo a desarrollar, con el objetivo de diseñar productos robustos y escalables. Evitarás la deuda técnica y asegurarás la performance operativa de las entidades externas mediante herramientas de medición y contractuales.\r\n" +
                  "Además, colaborarás estrechamente con equipos internos para implementar cambios y mejoras en las herramientas existentes, actuando como un punto de contacto clave entre diferentes áreas de la empresa, como negocio, marketing, producto y tecnología.\r\n" +
                  "Como parte de tus funciones, también medirás y reportarás el impacto de las mejoras implementadas en las herramientas de crecimiento, asegurando una continua optimización del proceso y agregando valor al ecosistema de Mercado Pago.\r\n" +
                  "Para ser exitoso en este rol, buscamos personas con experiencia previa en roles similares, preferiblemente en el sector financiero o tecnológico. Debes contar con sólidos conocimientos en integración de sistemas y flujo de datos, así como habilidades para gestionar relaciones interdepartamentales en un entorno dinámico y colaborativo.\r\n" +
                  "Si estás buscando un desafío en el campo de la integración de productos y conexiones y tienes la experiencia y habilidades necesarias para sobresalir en este rol, ¡esperamos con interés recibir tu solicitud y considerarte para unirte a nuestro equipo!\r\n",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("06/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("c1a438b6-8c42-4bc4-b11a-7999cb0f4f6e"),
                    CompanyId = Guid.Parse("d51252c3-6e21-4ffc-aab3-f4bda791a574"),
                    Title = "Especialista de Operaciones de Insurtech - Mercado Pago",
                    Description = "¡Únete a nuestro equipo como Especialista de Operaciones de Insurtech en Mercado Pago y sé parte del proceso de implementación y gestión del modelo de gestión de reclamos en los diferentes sites!\r\n" +
                  "En este desafiante rol, serás responsable de implementar el modelo de gestión de reclamos en nombre de la aseguradora, considerando todas las perspectivas y asegurando la correcta medición de indicadores clave como LR vs LRT y Expense Ratio.\r\n" +
                  "Además, estarás a cargo de establecer y mantener el sistema de scoring de claims, así como de monitorear los indicadores para medir la experiencia de los clientes en lo referido a reclamos. Realizarás análisis comparativos con compañías de seguros para identificar oportunidades de mejora.\r\n" +
                  "Como Especialista de Operaciones de Insurtech, también tendrás la responsabilidad de retroalimentar al equipo de Producto, Pricing y Business Development en las mejoras necesarias para optimizar la gestión de reclamos y la experiencia del usuario.\r\n" +
                  "Otro aspecto clave de tu rol será llevar la gestión de auditoría de siniestros con las Compañías, asegurando el cumplimiento de los estándares de calidad y contribuyendo a la mejora continua del proceso.\r\n" +
                  "Buscamos candidatos con experiencia previa en operaciones de seguros o insurtech, con sólidos conocimientos en gestión de reclamos y análisis de datos. Debes ser proactivo, orientado a resultados y capaz de trabajar en un entorno dinámico y colaborativo.\r\n" +
                  "Si estás buscando un desafío en el campo de la operaciones de insurtech y tienes la experiencia y habilidades necesarias para sobresalir en este rol, ¡esperamos con interés recibir tu solicitud y considerarte para unirte a nuestro equipo!\r\n",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("02/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 3,
                },
                new Offer
                {
                    OfferId = Guid.Parse("79f0f169-f7e1-48b6-aeb8-7584f47ac0aa"),
                    CompanyId = Guid.Parse("d51252c3-6e21-4ffc-aab3-f4bda791a574"),
                    Title = "Analista Senior de Mantenimiento - Mercado Envíos",
                    Description = "¡Únete a nuestro equipo como Analista Senior de Mantenimiento en Mercado Envíos y sé parte del proceso de garantizar el cumplimiento del plan de mantenimiento de los centros de distribución de Argentina!\r\n" +
                  "En este rol desafiante, serás responsable de acompañar las nuevas aperturas de sitios, brindar asesoramiento técnico, buscar proveedores, gestionar licitaciones, pliegos técnicos y verificaciones, y luego continuar con el mantenimiento de los centros de distribución.\r\n" +
                  "Además, tendrás la responsabilidad de garantizar el cumplimiento del plan de mantenimiento (hard y soft) de los centros de distribución en las distintas regiones de Argentina. Gestionarás y supervisarás trabajos de contratistas, y desarrollarás una cartera de proveedores de la región.\r\n" +
                  "Otro aspecto clave de tu rol será llevar a cabo el seguimiento del presupuesto, los costos y el análisis de indicadores del área, garantizando la maximización del desempeño y la eficiencia operativa.\r\n" +
                  "Buscamos candidatos con experiencia previa en mantenimiento de centros de distribución o áreas relacionadas, con sólidos conocimientos técnicos y capacidad para gestionar proyectos y equipos de trabajo. Debes ser proactivo, orientado a resultados y tener habilidades de comunicación y liderazgo.\r\n" +
                  "Si estás buscando un desafío en el campo del mantenimiento de centros de distribución y tienes la experiencia y habilidades necesarias para sobresalir en este rol, ¡esperamos con interés recibir tu solicitud y considerarte para unirte a nuestro equipo!\r\n" +
                  "Principales responsabilidades:\r\n" +
                  "- Acompañar en las nuevas aperturas de sitios, asesoramiento técnico, búsqueda de proveedores, licitaciones, pliegos técnicos, verificaciones y luego continuar con el mantenimiento.\r\n" +
                  "- Garantizar el cumplimiento del plan de mantenimiento (hard y soft) de los centros de distribución de las distintas regiones de Argentina.\r\n" +
                  "- Gestionar y supervisar trabajos de contratistas, y desarrollar una cartera de proveedores de la región.\r\n" +
                  "- Llevar a cabo el seguimiento del presupuesto, los costos y el análisis de indicadores del área, garantizando la maximización del desempeño.\r\n" +
                  "- Colaborar con otros equipos para optimizar los procesos de mantenimiento y mejorar la eficiencia operativa.\r\n" +
                  "- Participar en la definición de políticas y procedimientos relacionados con el mantenimiento de los centros de distribución.\r\n" +
                  "Requisitos:\r\n" +
                  "- Experiencia previa en mantenimiento de centros de distribución o áreas relacionadas.\r\n" +
                  "- Conocimientos técnicos sólidos en mantenimiento industrial.\r\n" +
                  "- Capacidad para gestionar proyectos y equipos de trabajo.\r\n" +
                  "- Proactividad y orientación a resultados.\r\n" +
                  "- Excelentes habilidades de comunicación y liderazgo.\r\n" +
                  "- Disponibilidad para viajar dentro del país.\r\n" +
                  "Ofrecemos:\r\n" +
                  "- Un ambiente de trabajo dinámico y desafiante.\r\n" +
                  "- Oportunidades de crecimiento y desarrollo profesional.\r\n" +
                  "- Capacitación continua en tecnologías y metodologías de trabajo.\r\n" +
                  "- Beneficios corporativos.\r\n" +
                  "Si estás buscando un nuevo desafío en el campo del mantenimiento de centros de distribución y cumples con los requisitos mencionados, ¡no dudes en postularte! ¡Esperamos con interés conocerte y considerarte para unirte a nuestro equipo!\r\n",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("09/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 3,
                },
                new Offer
                {
                    OfferId = Guid.Parse("6cbe28f0-4b85-457f-8a7e-24e2816a607b"),
                    CompanyId = Guid.Parse("be76d6cb-0532-4dd5-8e4e-f944faf0106b"),
                    Title = "Especialista de Negocio para Marketing Marketplace",
                    Description = "¡Únete a nuestro equipo como Especialista de Negocio para Marketing Marketplace y sé parte del análisis y generación de insights a partir de la data de MercadoLibre!\r\n" +
                  "En este rol, serás responsable de explorar y analizar la data del negocio y de marketing de MercadoLibre para generar insights que impulsen el crecimiento y la efectividad de las iniciativas de marketing.\r\n" +
                  "Tus responsabilidades incluirán analizar los resultados de las diversas iniciativas de marketing, detectar oportunidades de mejora y brindar soporte en el armado y generación de reportes que conecten la data del negocio con los diferentes canales de comunicación y campañas realizadas desde Marketing.\r\n" +
                  "Además, medirás el impacto de principio a fin de cada acción realizada desde Marketing, facilitando y agilizando la operación diaria del negocio y la toma de decisiones frente a las diversas iniciativas. Serás responsable de generar y presentar los distintos learnings sobre los insights generados y planes de acción a toda la organización, incluyendo a los equipos de Negocio, Producto y Marketing.\r\n" +
                  "Buscamos candidatos con experiencia previa en análisis de datos, especialmente en el ámbito del marketing digital. Debes tener habilidades analíticas sólidas, capacidad para trabajar con grandes volúmenes de información y habilidades de comunicación para presentar tus hallazgos de manera clara y concisa.\r\n" +
                  "Si te apasiona el análisis de datos y quieres formar parte de un equipo dinámico y colaborativo en el ámbito del marketing digital, ¡esperamos con interés recibir tu solicitud!\r\n" +
                  "Principales responsabilidades:\r\n" +
                  "- Explorar y analizar la data del negocio y de marketing de MercadoLibre para la generación de insights.\r\n" +
                  "- Analizar resultados de las diversas iniciativas de marketing y detectar oportunidades de mejora.\r\n" +
                  "- Brindar soporte en el armado y generación de reportes conectando la data del negocio con los diferentes canales de comunicación/campañas que se realicen desde Marketing.\r\n" +
                  "- Medir el impacto de principio a fin de cada una de las acciones realizadas desde Marketing.\r\n" +
                  "- Generar y presentar los distintos learnings sobre los insights generados y planes de acción a toda la organización.\r\n" +
                  "Requisitos:\r\n" +
                  "- Experiencia previa en análisis de datos, especialmente en el ámbito del marketing digital.\r\n" +
                  "- Habilidades analíticas sólidas y capacidad para trabajar con grandes volúmenes de información.\r\n" +
                  "- Habilidades de comunicación para presentar hallazgos de manera clara y concisa.\r\n" +
                  "- Capacidad para trabajar de manera colaborativa en un entorno dinámico.\r\n" +
                  "Ofrecemos:\r\n" +
                  "- Oportunidades de crecimiento y desarrollo profesional en una empresa líder en el mercado.\r\n" +
                  "- Ambiente de trabajo dinámico y colaborativo.\r\n" +
                  "- Beneficios corporativos.\r\n" +
                  "Si estás listo para enfrentar este desafío y contribuir al éxito de nuestras iniciativas de marketing, ¡esperamos con interés recibir tu solicitud y considerarte para unirte a nuestro equipo!\r\n",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("09/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("b18a1bb5-6b8a-4d90-985f-02c4792f18da"),
                    CompanyId = Guid.Parse("be76d6cb-0532-4dd5-8e4e-f944faf0106b"),
                    Title = "Diseñadora / Diseñador de User Experience",
                    Description = "¡Únete a nuestro equipo como Diseñador/a de User Experience y lidera todas las fases de diseño de producto para diferentes proyectos web, asegurando la mejor experiencia de usuario en cada iniciativa!\r\n" +
                  "En este rol desafiante, serás responsable de investigar las nuevas tendencias del sector y aplicarlas en nuestras plataformas para garantizar una experiencia de usuario de primera clase.\r\n" +
                  "Trabajarás en estrecha colaboración con el equipo de Desarrollo para detectar oportunidades de optimización en el producto y asegurar la coherencia entre el diseño y la funcionalidad.\r\n" +
                  "Buscamos candidatos con experiencia previa en diseño de experiencia de usuario, sólidos conocimientos en diseño de interfaces de usuario y capacidad para trabajar en un entorno colaborativo y dinámico.\r\n" +
                  "Si tienes pasión por el diseño y la experiencia del usuario, y estás listo para unirte a un equipo innovador y apasionado, ¡esperamos con interés recibir tu solicitud!\r\n" +
                  "Responsabilidades:\r\n" +
                  "- Liderar todas las fases de diseño de producto para diferentes proyectos web.\r\n" +
                  "- Investigar las nuevas tendencias del sector y aplicarlas en nuestras plataformas.\r\n" +
                  "- Trabajar junto al equipo de Desarrollo para detectar oportunidades de optimización en el producto.\r\n" +
                  "Requisitos:\r\n" +
                  "- Experiencia previa en diseño de experiencia de usuario.\r\n" +
                  "- Conocimientos sólidos en diseño de interfaces de usuario.\r\n" +
                  "- Capacidad para trabajar en un entorno colaborativo y dinámico.\r\n" +
                  "Ofrecemos:\r\n" +
                  "- Oportunidades de crecimiento y desarrollo profesional en un entorno innovador.\r\n" +
                  "- Ambiente de trabajo colaborativo y dinámico.\r\n" +
                  "- Beneficios corporativos.\r\n" +
                  "Si estás listo para enfrentar este desafío y contribuir al éxito de nuestros proyectos web, ¡esperamos con interés recibir tu solicitud y considerarte para unirte a nuestro equipo!\r\n",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("07/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("05f44853-1a61-4e47-92c1-1051e7592de9"),
                    CompanyId = Guid.Parse("ac270f24-3f1f-43a6-b291-1f0ce4489bfd"),
                    Title = "DevOps Engineer - Personal Pay",
                    Description = "¡Únete a nuestro equipo en Personal Pay como DevOps Engineer y sé parte de la aceleración del ciclo de vida del desarrollo sin perder de vista la calidad!\r\n" +
                  "Buscamos un profesional que combine tecnologías existentes y emergentes con prácticas de integración, entrega, testing y monitoreo continuo.\r\n" +
                  "En este rol desafiante, serás responsable de implementar soluciones DevOps que impulsen la eficiencia y la calidad en el desarrollo de software, colaborando estrechamente con los equipos de desarrollo y operaciones.\r\n" +
                  "Si tienes experiencia en DevOps, sólidos conocimientos en tecnologías de integración y entrega continua, y estás listo para enfrentar este desafío, ¡esperamos con interés recibir tu solicitud!\r\n" +
                  "Responsabilidades:\r\n" +
                  "- Implementar soluciones DevOps para acelerar el ciclo de vida del desarrollo de software.\r\n" +
                  "- Colaborar con los equipos de desarrollo y operaciones para asegurar la eficiencia y la calidad del proceso de desarrollo.\r\n" +
                  "- Mantener y mejorar continuamente las prácticas de integración, entrega, testing y monitoreo continuo.\r\n" +
                  "Requisitos:\r\n" +
                  "- Experiencia previa en roles de DevOps.\r\n" +
                  "- Conocimientos sólidos en tecnologías de integración y entrega continua.\r\n" +
                  "- Capacidad para trabajar en un entorno colaborativo y dinámico.\r\n" +
                  "Ofrecemos:\r\n" +
                  "- Oportunidades de crecimiento y desarrollo profesional en un entorno innovador.\r\n" +
                  "- Ambiente de trabajo colaborativo y dinámico.\r\n" +
                  "- Beneficios corporativos.\r\n" +
                  "Si estás listo para contribuir al éxito de nuestros proyectos en Personal Pay, ¡esperamos con interés recibir tu solicitud y considerarte para unirte a nuestro equipo!\r\n",
                    JobOfferModeId = 3,
                    PublicationDate = DateTime.Parse("07/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("88c99390-4e1b-4201-a10b-8a4b6a5b01ef"),
                    CompanyId = Guid.Parse("ac270f24-3f1f-43a6-b291-1f0ce4489bfd"),
                    Title = "Product Owner TRACK PAYMENTS - Personal Pay",
                    Description = "¡Únete a nuestro equipo en Personal Pay como Product Owner y sé parte de la mejora continua de la experiencia del usuario en nuestros procesos de onboarding digital!\r\n" +
                  "En este rol, serás responsable de idear, establecer y priorizar el desarrollo de soluciones que mejoren la conversión en los procesos de onboarding digital de usuarios de Personal Pay.\r\n" +
                  "Trabajarás en estrecha colaboración con los equipos de UX y Desarrollo, utilizando análisis de información y métricas para impulsar mejoras significativas en la experiencia del usuario.\r\n" +
                  "Responsabilidades:\r\n" +
                  "- Idear, establecer y priorizar el desarrollo de soluciones para mejorar la conversión en los procesos de onboarding digital.\r\n" +
                  "- Colaborar estrechamente con los equipos de UX y Desarrollo para implementar soluciones efectivas.\r\n" +
                  "- Dar soporte al seguimiento y cumplimiento del backlog de producto.\r\n" +
                  "Requisitos:\r\n" +
                  "- Experiencia previa como Product Owner o en roles similares.\r\n" +
                  "- Conocimiento de metodologías ágiles y de gestión de proyectos.\r\n" +
                  "- Capacidad para trabajar en un entorno dinámico y colaborativo.\r\n" +
                  "Ofrecemos:\r\n" +
                  "- Oportunidades de crecimiento y desarrollo profesional en un entorno innovador.\r\n" +
                  "- Ambiente de trabajo colaborativo y dinámico.\r\n" +
                  "- Beneficios corporativos.\r\n" +
                  "Si estás buscando un desafío emocionante en la mejora de la experiencia del usuario y tienes la experiencia y habilidades necesarias, ¡esperamos con interés recibir tu solicitud y considerarte para unirte a nuestro equipo en Personal Pay!\r\n",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("07/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("02425ff4-5748-4da2-a32e-1b8d897e5f9e"),
                    CompanyId = Guid.Parse("ac270f24-3f1f-43a6-b291-1f0ce4489bfd"),
                    Title = "DevOps Engineer",
                    Description = "¡Únete a nuestro equipo en Personal PAY como DevOps Engineer y sé parte de la innovación en un entorno desafiante y dinámico!\r\n" +
                  "Buscamos profesionales apasionados por la innovación y con habilidades para desempeñarse en un entorno dinámico, donde puedan ser protagonistas en el desarrollo y la implementación de soluciones tecnológicas.\r\n" +
                  "Responsabilidades:\r\n" +
                  "- Colaborar en el diseño, implementación y mantenimiento de la infraestructura y plataformas tecnológicas.\r\n" +
                  "- Automatizar procesos de integración, entrega y despliegue continuo (CI/CD).\r\n" +
                  "- Garantizar la disponibilidad, escalabilidad y seguridad de los sistemas.\r\n" +
                  "- Colaborar con equipos de desarrollo para optimizar el rendimiento de las aplicaciones.\r\n" +
                  "Requisitos:\r\n" +
                  "- Experiencia previa como DevOps Engineer o en roles similares.\r\n" +
                  "- Conocimientos en herramientas de automatización y orquestación como Docker, Kubernetes, Jenkins, etc.\r\n" +
                  "- Familiaridad con infraestructura como código (IaC).\r\n" +
                  "- Capacidad para trabajar en un entorno ágil y colaborativo.\r\n" +
                  "Ofrecemos:\r\n" +
                  "- Oportunidades de crecimiento y desarrollo profesional en un entorno innovador.\r\n" +
                  "- Ambiente de trabajo colaborativo y dinámico.\r\n" +
                  "- Beneficios corporativos.\r\n" +
                  "Si estás buscando un desafío emocionante en el campo de la tecnología y tienes la experiencia y habilidades necesarias, ¡esperamos con interés recibir tu solicitud y considerarte para unirte a nuestro equipo en Personal PAY!\r\n",
                    JobOfferModeId = 1,
                    PublicationDate = DateTime.Parse("08/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("340c99b3-c922-49cf-9d34-609b768e7f65"),
                    CompanyId = Guid.Parse("ac270f24-3f1f-43a6-b291-1f0ce4489bfd"),
                    Title = "Data Analyst",
                    Description = "¡Únete a nuestro equipo en Personal PAY como Data Analyst y sé parte de la revolución de los datos en el sector de las telecomunicaciones!\r\n" +
                  "En este emocionante rol, serás responsable de analizar, definir y co-construir con el negocio los productos analíticos de datos, incluyendo modelos, procesos y dashboards. Tu enfoque estará en entregar valor al negocio y facilitar el self-service de usuarios de diversas áreas de Telecom.\r\n" +
                  "Trabajarás en equipo con otros Data Engineers y Tech Leads para construir una plataforma escalable y robusta que permita solucionar los desafíos del equipo y acompañar la evolución del producto.\r\n" +
                  "Responsabilidades:\r\n" +
                  "- Analizar las necesidades del negocio y traducirlas en requerimientos de datos y modelos analíticos.\r\n" +
                  "- Co-crear dashboards y reportes que proporcionen insights accionables a los stakeholders.\r\n" +
                  "- Desarrollar y mantener modelos predictivos y de segmentación para optimizar las estrategias comerciales.\r\n" +
                  "- Colaborar con equipos multidisciplinarios para implementar soluciones innovadoras basadas en datos.\r\n" +
                  "- Participar en la construcción y mejora continua de la plataforma analítica, asegurando su escalabilidad y rendimiento.\r\n" +
                  "Requisitos:\r\n" +
                  "- Experiencia previa en análisis de datos, preferiblemente en el sector de las telecomunicaciones.\r\n" +
                  "- Conocimientos sólidos de herramientas y lenguajes de programación para análisis de datos, como SQL, Python, R, etc.\r\n" +
                  "- Capacidad para comunicar resultados de análisis de manera clara y efectiva a audiencias no técnicas.\r\n" +
                  "- Habilidad para trabajar en equipo y colaborar con diferentes áreas de la empresa.\r\n" +
                  "Ofrecemos:\r\n" +
                  "- Oportunidades de desarrollo profesional en un entorno innovador y dinámico.\r\n" +
                  "- Ambiente de trabajo colaborativo y flexible.\r\n" +
                  "- Beneficios corporativos y programas de bienestar para empleados.\r\n" +
                  "Si estás buscando un desafío apasionante en el campo de los datos y tienes la experiencia y habilidades necesarias, ¡esperamos con interés recibir tu solicitud y considerarte para unirte a nuestro equipo en Personal PAY!\r\n",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("10/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("9e920f05-4e16-4536-b246-50c242d1a152"),
                    CompanyId = Guid.Parse("ac270f24-3f1f-43a6-b291-1f0ce4489bfd"),
                    Title = "Analista de Prevención de Fraude Sr - Personal Pay",
                    Description = "¡Únete a nuestro equipo en Personal Pay como Analista de Prevención de Fraude Sr y sé parte de nuestra misión de potenciar la vida digital de nuestros clientes!\r\n" +
                  "En nuestra Fintech Personal Pay, confiamos y creemos en las personas como diferencial en la entrega de valor a nuestros clientes. Nos impulsa el propósito de innovar y ser protagonistas en un entorno desafiante y dinámico.\r\n" +
                  "Como Analista de Prevención de Fraude Sr, serás responsable de proteger a nuestros clientes y la empresa de actividades fraudulentas, aplicando técnicas y herramientas avanzadas de detección y prevención de fraude.\r\n" +
                  "Responsabilidades:\r\n" +
                  "- Analizar y monitorear transacciones y comportamientos sospechosos para detectar posibles fraudes.\r\n" +
                  "- Desarrollar y mejorar continuamente modelos y algoritmos de detección de fraude.\r\n" +
                  "- Colaborar con otros equipos para implementar medidas de seguridad y controles preventivos.\r\n" +
                  "- Investigar casos de fraude y colaborar con autoridades y equipos internos en su resolución.\r\n" +
                  "- Mantenerse actualizado sobre las últimas tendencias y técnicas de fraude para mejorar los procesos y herramientas de prevención.\r\n" +
                  "Requisitos:\r\n" +
                  "- Experiencia previa en prevención de fraude, preferiblemente en el sector financiero o Fintech.\r\n" +
                  "- Conocimiento sólido de herramientas y metodologías de detección y prevención de fraude.\r\n" +
                  "- Habilidad para analizar datos y identificar patrones y anomalías.\r\n" +
                  "- Capacidad para trabajar en equipo y comunicar eficazmente hallazgos y recomendaciones.\r\n" +
                  "Ofrecemos:\r\n" +
                  "- Oportunidades de desarrollo profesional en un ambiente colaborativo y desafiante.\r\n" +
                  "- Flexibilidad y ambiente de trabajo dinámico.\r\n" +
                  "- Beneficios corporativos y programas de bienestar para empleados.\r\n" +
                  "Si estás listo para enfrentar el desafío de proteger a nuestros clientes y a la empresa contra el fraude y tienes la experiencia y habilidades necesarias, ¡esperamos con interés recibir tu solicitud y considerarte para unirte a nuestro equipo en Personal Pay!\r\n",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("10/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("cf5ed95f-77e8-4a0e-85f8-78f7df4c2c78"),
                    CompanyId = Guid.Parse("ac270f24-3f1f-43a6-b291-1f0ce4489bfd"),
                    Title = "Analista Sr Gestión de Mora Fintech - Personal Pay",
                    Description = "Únete a nuestro equipo en Personal Pay como Analista Sr. de Gestión de Mora y sé parte de nuestra misión de potenciar la vida digital de nuestros clientes a través de soluciones financieras innovadoras.\r\n" +
                  "En el equipo de Gestión de Mora de la compañía, confiamos en la pasión por la innovación y en la capacidad de ser protagonistas en un entorno desafiante y dinámico.\r\n" +
                  "Como Analista Sr. de Gestión de Mora, serás responsable de gestionar estratégicamente la mora y minimizar el riesgo crediticio, contribuyendo al crecimiento y la estabilidad financiera de la empresa.\r\n" +
                  "Responsabilidades:\r\n" +
                  "- Analizar la cartera de préstamos y evaluar el riesgo crediticio de los clientes.\r\n" +
                  "- Implementar estrategias para reducir la morosidad y maximizar la recuperación de deudas.\r\n" +
                  "- Desarrollar e implementar políticas y procedimientos efectivos de gestión de mora.\r\n" +
                  "- Colaborar con equipos internos para identificar oportunidades de mejora en los procesos de gestión de mora.\r\n" +
                  "- Monitorear y analizar indicadores clave de rendimiento relacionados con la gestión de mora.\r\n" +
                  "Requisitos:\r\n" +
                  "- Experiencia previa en gestión de mora, preferiblemente en el sector financiero o Fintech.\r\n" +
                  "- Conocimiento sólido de políticas y regulaciones relacionadas con la gestión de riesgos crediticios.\r\n" +
                  "- Habilidad para analizar datos y desarrollar estrategias basadas en información cuantitativa y cualitativa.\r\n" +
                  "- Capacidad para trabajar en equipo y comunicar eficazmente con diferentes áreas de la empresa.\r\n" +
                  "Ofrecemos:\r\n" +
                  "- Oportunidades de desarrollo profesional en un ambiente colaborativo y desafiante.\r\n" +
                  "- Flexibilidad y ambiente de trabajo dinámico.\r\n" +
                  "- Beneficios corporativos y programas de bienestar para empleados.\r\n" +
                  "Si estás listo para enfrentar el desafío de gestionar estratégicamente la mora y contribuir al crecimiento financiero de la empresa, ¡esperamos con interés recibir tu solicitud y considerarte para unirte a nuestro equipo en Personal Pay!\r\n",
                    JobOfferModeId = 1,
                    PublicationDate = DateTime.Parse("08/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("85b1a6f1-1e05-4eae-a60d-51a334f54ad5"),
                    CompanyId = Guid.Parse("ac270f24-3f1f-43a6-b291-1f0ce4489bfd"),
                    Title = "Data Engineer Ssr",
                    Description = "Únete a nuestro equipo en el área de Data Engineering y sé parte de nuestra misión de impulsar la innovación y la excelencia en el manejo de datos para potenciar la vida digital de nuestros clientes.\r\n" +
                  "En el equipo de Data Engineering de la compañía, valoramos la pasión por la innovación y la capacidad de ser protagonistas en un entorno desafiante y dinámico.\r\n" +
                  "Como Data Engineer Ssr, tendrás la oportunidad de trabajar en proyectos emocionantes y desafiantes que impulsan la toma de decisiones informadas y la creación de soluciones de datos de clase mundial.\r\n" +
                  "Responsabilidades:\r\n" +
                  "- Colaborar con el equipo de Data Engineering para diseñar, desarrollar e implementar soluciones de datos escalables y eficientes.\r\n" +
                  "- Diseñar y mantener arquitecturas de datos optimizadas que cumplan con los requisitos de rendimiento y escalabilidad.\r\n" +
                  "- Desarrollar pipelines de datos robustos para la ingesta, procesamiento y análisis de grandes volúmenes de datos.\r\n" +
                  "- Implementar y mantener sistemas de monitoreo y alerta para garantizar la integridad y disponibilidad de los datos.\r\n" +
                  "- Colaborar con otros equipos técnicos y de negocio para comprender y satisfacer sus necesidades de datos.\r\n" +
                  "Requisitos:\r\n" +
                  "- Experiencia previa en roles de Data Engineering, preferiblemente en entornos de datos distribuidos y escalables.\r\n" +
                  "- Conocimiento sólido de herramientas y tecnologías de almacenamiento y procesamiento de datos, como Hadoop, Spark, Kafka, etc.\r\n" +
                  "- Experiencia en el diseño y desarrollo de pipelines de datos utilizando herramientas como Airflow, Luigi, etc.\r\n" +
                  "- Habilidades de programación en lenguajes como Python, Scala, Java, etc.\r\n" +
                  "- Fuertes habilidades analíticas y capacidad para resolver problemas complejos de manera efectiva.\r\n" +
                  "Ofrecemos:\r\n" +
                  "- Oportunidades de crecimiento profesional en un ambiente colaborativo y dinámico.\r\n" +
                  "- Flexibilidad y autonomía para proponer y desarrollar soluciones innovadoras.\r\n" +
                  "- Beneficios corporativos y programas de capacitación para el desarrollo personal y profesional.\r\n" +
                  "Si estás listo para unirte a un equipo apasionado por la innovación y el manejo de datos, ¡esperamos con interés recibir tu solicitud para el puesto de Data Engineer Ssr en nuestra compañía!\r\n",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("10/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("23d4c9e5-88b4-44f0-9b64-8308e70e51eb"),
                    CompanyId = Guid.Parse("ac270f24-3f1f-43a6-b291-1f0ce4489bfd"),
                    Title = "Content Designer",
                    Description = "Únete a nuestro equipo en el área de Content y sé parte de nuestra misión de impulsar la innovación y la excelencia en la experiencia del usuario a través del diseño de contenido.\r\n" +
                  "En el equipo Content de la compañía, valoramos la pasión por la innovación y la capacidad de ser protagonistas en un entorno desafiante y dinámico.\r\n" +
                  "Como Content Designer, tendrás la oportunidad de colaborar en el desarrollo de estrategias y recursos que mejoren la experiencia de los usuarios y usuarias en nuestras plataformas digitales.\r\n" +
                  "Responsabilidades:\r\n" +
                  "- Colaborar en la definición de la estrategia de contenido para diferentes proyectos y productos digitales.\r\n" +
                  "- Diseñar y crear contenido digital que sea claro, conciso y atractivo para los usuarios.\r\n" +
                  "- Trabajar en estrecha colaboración con equipos multidisciplinarios para asegurar la coherencia del contenido con la visión del producto y la marca.\r\n" +
                  "- Realizar pruebas de usabilidad y obtener feedback para iterar y mejorar el contenido.\r\n" +
                  "- Mantenerse al tanto de las tendencias en diseño de contenido y mejores prácticas en la industria.\r\n" +
                  "Requisitos:\r\n" +
                  "- Experiencia previa en roles de diseño de contenido, preferiblemente en entornos digitales.\r\n" +
                  "- Conocimiento sólido de principios de diseño y experiencia del usuario.\r\n" +
                  "- Habilidades de redacción creativa y capacidad para comunicar ideas de manera efectiva.\r\n" +
                  "- Familiaridad con herramientas de diseño y prototipado, como Adobe Creative Suite, Sketch, Figma, etc.\r\n" +
                  "- Capacidad para trabajar en equipo y adaptarse a un entorno de trabajo ágil.\r\n" +
                  "Ofrecemos:\r\n" +
                  "- Oportunidades de crecimiento profesional en un ambiente colaborativo y dinámico.\r\n" +
                  "- Flexibilidad y autonomía para proponer y desarrollar soluciones innovadoras.\r\n" +
                  "- Beneficios corporativos y programas de capacitación para el desarrollo personal y profesional.\r\n" +
                  "Si estás listo para unirte a un equipo apasionado por la innovación en diseño de contenido, ¡esperamos con interés recibir tu solicitud para el puesto de Content Designer en nuestra compañía!\r\n",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("07/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("b11dd7cf-8245-43a3-9b23-8c8893f83c13"),
                    CompanyId = Guid.Parse("ac270f24-3f1f-43a6-b291-1f0ce4489bfd"),
                    Title = "Tech Lead (Soluciones Financieras) - Personal Pay",
                    Description = "Únete a nuestro equipo en Personal Pay y sé parte de nuestra misión de impulsar la innovación y la excelencia en las soluciones financieras digitales.\r\n" +
                  "Estamos buscando Tech Leads apasionados por la tecnología y con habilidades para liderar equipos en un entorno desafiante y dinámico.\r\n" +
                  "Como Tech Lead en el equipo de Soluciones Financieras, tendrás la oportunidad de liderar el desarrollo de soluciones innovadoras que mejoren la experiencia de nuestros usuarios y usuarias en el ámbito financiero.\r\n" +
                  "Responsabilidades:\r\n" +
                  "- Liderar el diseño, desarrollo e implementación de soluciones financieras digitales.\r\n" +
                  "- Colaborar con equipos multidisciplinarios para definir la arquitectura de las soluciones y asegurar su calidad y escalabilidad.\r\n" +
                  "- Gestionar y liderar equipos técnicos, brindando orientación y apoyo en la resolución de problemas técnicos.\r\n" +
                  "- Participar en la planificación y estimación de proyectos, asegurando la entrega en tiempo y forma.\r\n" +
                  "- Mantenerse actualizado con las tendencias tecnológicas y aplicarlas en el desarrollo de soluciones innovadoras.\r\n" +
                  "Requisitos:\r\n" +
                  "- Experiencia previa como líder técnico en proyectos de desarrollo de software, preferiblemente en el sector financiero.\r\n" +
                  "- Conocimiento sólido de tecnologías y metodologías de desarrollo, como Java, Spring Boot, Microservicios, etc.\r\n" +
                  "- Habilidades de liderazgo y capacidad para trabajar en equipo.\r\n" +
                  "- Excelentes habilidades de comunicación y capacidad para gestionar relaciones interpersonales.\r\n" +
                  "- Capacidad para trabajar en un entorno ágil y adaptarse a cambios rápidos.\r\n" +
                  "Ofrecemos:\r\n" +
                  "- Oportunidades de desarrollo profesional en un ambiente colaborativo y estimulante.\r\n" +
                  "- Flexibilidad y autonomía para proponer y desarrollar soluciones innovadoras.\r\n" +
                  "- Beneficios corporativos y programas de capacitación para el desarrollo personal y profesional.\r\n" +
                  "Si estás listo para liderar el desarrollo de soluciones financieras innovadoras, ¡esperamos con interés recibir tu solicitud para el puesto de Tech Lead en nuestro equipo de Soluciones Financieras en Personal Pay!\r\n",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("06/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("e261493e-d760-4a48-bb24-9b5c9d7f4b1a"),
                    CompanyId = Guid.Parse("ac270f24-3f1f-43a6-b291-1f0ce4489bfd"),
                    Title = "Analista Sr Administración Fintech",
                    Description = "Únete a nuestro equipo en el área de Administración Fintech y sé parte de nuestra misión de impulsar la innovación y la excelencia en el sector financiero digital.\r\n" +
                  "Estamos en búsqueda de Analistas Administrativos Contables con experiencia y pasión por el área financiera y contable, que deseen ser protagonistas en un entorno desafiante y dinámico.\r\n" +
                  "Como Analista Sr Administración Fintech, tendrás la oportunidad de trabajar en un equipo multidisciplinario y colaborativo, contribuyendo al desarrollo y la implementación de procesos administrativos y contables que impulsen el crecimiento de la compañía.\r\n" +
                  "Responsabilidades:\r\n" +
                  "- Participar en la gestión y supervisión de las operaciones administrativas y contables de la compañía.\r\n" +
                  "- Colaborar en la preparación y análisis de informes financieros y contables.\r\n" +
                  "- Realizar conciliaciones bancarias y contables.\r\n" +
                  "- Contribuir al diseño e implementación de políticas y procedimientos administrativos y contables.\r\n" +
                  "- Asistir en la preparación de presupuestos y pronósticos financieros.\r\n" +
                  "Requisitos:\r\n" +
                  "- Experiencia previa en puestos administrativos o contables, preferiblemente en el sector financiero.\r\n" +
                  "- Conocimiento sólido de principios contables y financieros.\r\n" +
                  "- Capacidad para trabajar con sistemas y herramientas contables.\r\n" +
                  "- Habilidades analíticas y capacidad para trabajar en equipo.\r\n" +
                  "- Excelentes habilidades de comunicación y organización.\r\n" +
                  "Ofrecemos:\r\n" +
                  "- Oportunidades de desarrollo profesional en un ambiente dinámico y desafiante.\r\n" +
                  "- Participación en proyectos innovadores que impactan en el sector financiero digital.\r\n" +
                  "- Beneficios corporativos y programas de capacitación para el crecimiento personal y profesional.\r\n" +
                  "Si estás listo para formar parte de nuestro equipo y contribuir al éxito de la compañía en el área de Administración Fintech, ¡esperamos con interés recibir tu solicitud para el puesto de Analista Sr Administración Fintech!\r\n",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("07/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("fe4370bc-c706-4b09-9448-01bc6ff9b01f"),
                    CompanyId = Guid.Parse("ac270f24-3f1f-43a6-b291-1f0ce4489bfd"),
                    Title = "Engineering Manager - Personal Pay",
                    Description = "En Personal Pay, nuestra visión es liderar la transformación digital del sector financiero, ofreciendo soluciones innovadoras y de calidad que mejoren la vida de nuestros clientes. Para lograr este objetivo, estamos en búsqueda de un líder excepcional en el rol de Engineering Manager, alguien apasionado por la tecnología, con la capacidad de inspirar a equipos multidisciplinarios y la determinación para impulsar el éxito en un entorno desafiante y dinámico.\r\n\r\nComo Engineering Manager, tendrás la oportunidad de liderar un equipo de ingenieros de software talentosos y motivados, colaborando estrechamente con ellos para desarrollar productos y soluciones que superen las expectativas de nuestros clientes. Serás responsable de guiar el ciclo de vida completo de desarrollo de software, desde la concepción de ideas hasta la implementación y entrega, asegurando la calidad y la excelencia en cada etapa del proceso.\r\n\r\nResponsabilidades:\r\n\r\n- Liderar y motivar a un equipo de ingenieros de software, fomentando un ambiente de trabajo colaborativo y de alto rendimiento.\r\n- Definir la visión técnica y estratégica del equipo, alineándola con los objetivos del negocio y los requisitos del cliente.\r\n- Colaborar con otros líderes de equipos y stakeholders para establecer prioridades, resolver desafíos y garantizar la entrega oportuna y exitosa de proyectos.\r\n- Fomentar una cultura de aprendizaje y desarrollo dentro del equipo, proporcionando mentoría y oportunidades de crecimiento profesional.\r\n- Promover las mejores prácticas de ingeniería de software, la innovación tecnológica y la excelencia técnica en todas las áreas de trabajo.\r\n- Participar activamente en la contratación y retención de talento, identificando las habilidades y competencias necesarias para fortalecer el equipo.\r\n\r\nRequisitos:\r\n\r\n- Experiencia previa en roles de liderazgo técnico, preferiblemente como Engineering Manager o en posiciones similares.\r\n- Profundo conocimiento en desarrollo de software, arquitectura de sistemas y metodologías ágiles.\r\n- Excelentes habilidades de comunicación y capacidad para trabajar de manera efectiva con equipos interdisciplinarios y en entornos de ritmo acelerado.\r\n- Fuerte orientación a resultados y capacidad para tomar decisiones informadas en situaciones complejas.\r\n- Pasión por la tecnología, el aprendizaje continuo y la mejora constante.\r\n- Experiencia en la industria financiera o fintech será altamente valorada, pero no es un requisito excluyente.\r\n\r\nOfrecemos:\r\n\r\n- Oportunidades de crecimiento y desarrollo profesional en una empresa líder en el sector financiero digital.\r\n- Ambiente de trabajo colaborativo y dinámico, donde la innovación y la excelencia son valores fundamentales.\r\n- Remuneración competitiva y beneficios corporativos.\r\n- Participación en proyectos desafiantes y significativos que impactan positivamente en la vida de millones de usuarios.\r\n\r\nSi estás listo para asumir un desafío apasionante y contribuir al éxito de Personal Pay como líder técnico, ¡esperamos con interés recibir tu solicitud para el puesto de Engineering Manager!\r\n",
                    JobOfferModeId = 1,
                    PublicationDate = DateTime.Parse("07/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("3e7b2e42-9315-4395-b5dc-7c973d13a12e"),
                    CompanyId = Guid.Parse("ac270f24-3f1f-43a6-b291-1f0ce4489bfd"),
                    Title = "Sr QA Automation - Personal PAY",
                    Description = "En Personal PAY, nuestra misión es ofrecer soluciones financieras digitales de calidad que mejoren la vida de nuestros clientes. Para lograr este objetivo, buscamos sumar a nuestro equipo un Senior QA Automation con pasión por la calidad, la innovación y la excelencia técnica.\r\n\r\nComo Senior QA Automation, serás responsable de diseñar, implementar y ejecutar pruebas automatizadas para garantizar la calidad y el rendimiento de nuestros productos y sistemas. Trabajarás en estrecha colaboración con los equipos de desarrollo y operaciones para identificar y solucionar problemas, optimizar los procesos de prueba y mejorar continuamente la experiencia del usuario.\r\n\r\nResponsabilidades:\r\n\r\n- Diseñar y desarrollar casos de prueba automatizados para aplicaciones web, móviles y APIs, utilizando herramientas y frameworks como Selenium, Appium, TestNG, JUnit, etc.\r\n- Implementar estrategias de prueba automatizada para garantizar la cobertura y la eficacia de las pruebas.\r\n- Configurar y mantener entornos de prueba automatizados, integrándolos con sistemas de integración continua y entrega continua (CI/CD).\r\n- Colaborar con los equipos de desarrollo y operaciones para identificar y solucionar problemas, y asegurar la calidad y el rendimiento de los sistemas.\r\n- Analizar y reportar resultados de pruebas, identificando defectos y proponiendo soluciones para mejorar la calidad del software.\r\n- Contribuir al desarrollo y la mejora de los procesos y herramientas de prueba, promoviendo las mejores prácticas y la eficiencia en el ciclo de vida del desarrollo de software.\r\n\r\nRequisitos:\r\n\r\n- Experiencia sólida en pruebas de software y automatización, preferiblemente en entornos financieros o fintech.\r\n- Conocimientos profundos de herramientas y frameworks de prueba automatizada, así como de metodologías ágiles y prácticas de desarrollo de software.\r\n- Habilidades técnicas sólidas en programación, scripting y tecnologías relacionadas con la automatización de pruebas.\r\n- Capacidad para trabajar de manera independiente y en equipo, gestionando múltiples tareas y prioridades en un entorno dinámico.\r\n- Excelentes habilidades de comunicación y colaboración, con la capacidad de interactuar efectivamente con diferentes stakeholders y equipos técnicos.\r\n- Orientación a resultados y atención al detalle, con un enfoque en la entrega de productos de alta calidad y rendimiento.\r\n\r\nOfrecemos:\r\n\r\n- Oportunidades de crecimiento y desarrollo profesional en una empresa líder en el sector financiero digital.\r\n- Ambiente de trabajo colaborativo y dinámico, donde la innovación y la excelencia son valores fundamentales.\r\n- Remuneración competitiva y beneficios corporativos.\r\n- Participación en proyectos desafiantes y significativos que impactan positivamente en la vida de millones de usuarios.\r\n\r\nSi estás buscando un nuevo desafío en tu carrera y quieres formar parte de un equipo apasionado por la calidad y la innovación, ¡esperamos con interés recibir tu solicitud para el puesto de Senior QA Automation en Personal PAY!\r\n",
                    JobOfferModeId = 3,
                    PublicationDate = DateTime.Parse("08/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("a6606e3d-b9de-4b4f-840b-83f8e2c29e92"),
                    CompanyId = Guid.Parse("ac270f24-3f1f-43a6-b291-1f0ce4489bfd"),
                    Title = "Analista Sr Contabilidad Fintech",
                    Description = "En el equipo de Activos y Pasivos Financieros de la compañía, estamos sumando profesionales Analista Sr Contable, con pasión por la innovación, ganas de ser protagonistas y facilidad para el desempeño en un entorno desafiante y dinámico.\r\n\r\nComo Analista Sr Contabilidad, serás responsable de llevar a cabo tareas contables y financieras clave para apoyar las operaciones y el crecimiento de la empresa. Trabajarás en estrecha colaboración con otros equipos y departamentos para garantizar la precisión y la integridad de los registros contables, así como para proporcionar análisis y recomendaciones que impulsen la toma de decisiones estratégicas.\r\n\r\nResponsabilidades:\r\n\r\n- Realizar conciliaciones bancarias y de cuentas contables, asegurando la precisión y la integridad de los registros financieros.\r\n- Preparar y analizar estados financieros mensuales, trimestrales y anuales, identificando tendencias, variaciones y áreas de mejora.\r\n- Colaborar con los equipos de auditoría interna y externa para facilitar la revisión y el cumplimiento de los requisitos legales y regulatorios.\r\n- Participar en la preparación y presentación de informes financieros y regulatorios, asegurando la exactitud y la puntualidad de la información proporcionada.\r\n- Contribuir al desarrollo y la implementación de políticas, procedimientos y controles internos para mejorar la eficiencia y la eficacia de las operaciones contables y financieras.\r\n- Investigar y resolver discrepancias y problemas contables, identificando las causas subyacentes y recomendando soluciones y acciones correctivas.\r\n- Mantenerse al tanto de las tendencias y los desarrollos en el campo de la contabilidad y las finanzas, y aplicar los conocimientos adquiridos para mejorar continuamente los procesos y prácticas contables de la empresa.\r\n\r\nRequisitos:\r\n\r\n- Título universitario en Contabilidad, Finanzas o campo relacionado.\r\n- Experiencia previa en roles contables o financieros, preferiblemente en el sector financiero o fintech.\r\n- Conocimientos sólidos de principios contables, normas y regulaciones financieras.\r\n- Habilidades analíticas y de resolución de problemas, con atención al detalle y capacidad para trabajar con datos complejos y cifras financieras.\r\n- Excelentes habilidades de comunicación y colaboración, con la capacidad de interactuar efectivamente con diferentes stakeholders y equipos.\r\n- Orientación a resultados y capacidad para trabajar bajo presión en un entorno dinámico y exigente.\r\n- Conocimientos de herramientas y software contables, así como de sistemas ERP y paquetes de software financieros.\r\n\r\nOfrecemos:\r\n\r\n- Oportunidades de crecimiento y desarrollo profesional en una empresa líder en el sector fintech.\r\n- Ambiente de trabajo colaborativo y dinámico, donde la innovación y la excelencia son valores fundamentales.\r\n- Remuneración competitiva y beneficios corporativos.\r\n- Participación en proyectos significativos que impactan positivamente en la vida de millones de usuarios.\r\n\r\nSi estás buscando un nuevo desafío en tu carrera y quieres formar parte de un equipo apasionado por la innovación y el éxito, ¡esperamos con interés recibir tu solicitud para el puesto de Analista Sr Contabilidad Fintech en nuestra compañía!\r\n",
                    JobOfferModeId = 1,
                    PublicationDate = DateTime.Parse("08/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("f6f63f9f-01e0-4e1f-b675-90c1ffdc17cb"),
                    CompanyId = Guid.Parse("ac270f24-3f1f-43a6-b291-1f0ce4489bfd"),
                    Title = "Sr. Software Architect - Personal Pay",
                    Description = "El Sr. Software Architect desempeña un papel fundamental en la definición y guía de la arquitectura de software de Personal Pay, asegurando que las soluciones tecnológicas sean robustas, escalables, eficientes y cumplan con los estándares de calidad y las mejores prácticas del sector fintech.\r\n\r\nComo líder técnico, el Sr. Software Architect colabora estrechamente con los equipos de ingeniería y producto para identificar los requisitos clave, definir los atributos de calidad y tomar decisiones estratégicas en el diseño de las soluciones tecnológicas. Además, comparte una visión integral del panorama fintech, basada en su vasta experiencia y en las mejores prácticas obtenidas de las Comunidades de Interés (CoI) para difundir y promover las mejores prácticas en arquitectura de software.\r\n\r\nResponsabilidades:\r\n\r\n- Liderar la definición y evolución de la arquitectura de software de Personal Pay, garantizando la alineación con los objetivos del negocio y los estándares de calidad.\r\n- Colaborar con los equipos de ingeniería y producto para comprender los requisitos y desafíos técnicos, y definir soluciones técnicas adecuadas y escalables.\r\n- Identificar y definir los atributos de calidad de las soluciones tecnológicas, como la escalabilidad, la seguridad, el rendimiento y la modularidad.\r\n- Tomar decisiones arquitectónicas clave, incluida la selección de tecnologías, frameworks y patrones de diseño apropiados para cada proyecto.\r\n- Realizar revisiones y auditorías de la arquitectura de software existente, identificando áreas de mejora y proponiendo soluciones para optimizar la eficiencia y la calidad.\r\n- Colaborar con las Comunidades de Interés (CoI) para compartir conocimientos, experiencias y mejores prácticas en arquitectura de software, contribuyendo al desarrollo profesional y la excelencia técnica del equipo.\r\n- Mantenerse al tanto de las tendencias y avances en el campo de la arquitectura de software fintech, evaluando su relevancia y aplicabilidad en el contexto de Personal Pay.\r\n\r\nRequisitos:\r\n\r\n- Experiencia sólida como arquitecto de software en entornos fintech o de tecnología financiera.\r\n- Amplio conocimiento y experiencia en el diseño e implementación de arquitecturas de software escalables, robustas y seguras.\r\n- Experiencia en la definición y aplicación de patrones de diseño, principios de arquitectura y estándares de calidad en soluciones tecnológicas.\r\n- Habilidades de liderazgo y comunicación, con capacidad para influir y guiar a los equipos técnicos en la adopción de la arquitectura propuesta.\r\n- Capacidad para trabajar de manera colaborativa en un entorno ágil, interactuando con múltiples equipos y partes interesadas.\r\n- Orientación a resultados y capacidad para tomar decisiones claras y fundamentadas en situaciones complejas.\r\n- Titulación universitaria en Ingeniería Informática, Ciencias de la Computación o campo relacionado.\r\n- Certificaciones relevantes en arquitectura de software (por ejemplo, TOGAF, AWS Certified Solutions Architect) serán valoradas positivamente.\r\n\r\nOfrecemos:\r\n\r\n- Oportunidades de crecimiento y desarrollo profesional en una empresa líder en el sector fintech.\r\n- Ambiente de trabajo colaborativo y dinámico, donde la innovación y la excelencia son valores fundamentales.\r\n- Remuneración competitiva y beneficios corporativos.\r\n- Participación en proyectos significativos que impactan positivamente en la vida de millones de usuarios.\r\n\r\nSi estás buscando un nuevo desafío en tu carrera y quieres formar parte de un equipo apasionado por la innovación y el éxito, ¡esperamos con interés recibir tu solicitud para el puesto de Sr. Software Architect en Personal Pay!\r\n",
                    JobOfferModeId = 3,
                    PublicationDate = DateTime.Parse("06/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("25d6d135-1cb9-40aa-8962-f89173f8058b"),
                    CompanyId = Guid.Parse("ac270f24-3f1f-43a6-b291-1f0ce4489bfd"),
                    Title = "Lider de Tesoreria - Personal Pay",
                    Description = "En Personal Pay, estamos buscando sumar un líder de Tesorería a nuestro equipo. El propósito principal de este rol es mejorar la eficiencia, agilidad y seguridad en la gestión de los recursos financieros de la compañía, contribuyendo así al cumplimiento de los objetivos financieros y estratégicos de Personal Pay.\r\n\r\nComo líder de Tesorería, serás responsable de supervisar y dirigir las operaciones diarias relacionadas con la gestión de efectivo, la liquidez, las inversiones y el riesgo financiero. Trabajarás en estrecha colaboración con otros departamentos, incluidos Finanzas, Contabilidad, Riesgo y Operaciones, para desarrollar e implementar estrategias financieras efectivas que optimicen el uso de los recursos financieros de la compañía y minimicen los riesgos asociados.\r\n\r\nResponsabilidades:\r\n\r\n- Supervisar y dirigir las actividades diarias de tesorería, incluida la gestión de la liquidez, la administración de efectivo, las inversiones y el riesgo financiero.\r\n- Desarrollar e implementar políticas, procedimientos y controles internos para garantizar la seguridad y eficiencia de las operaciones de tesorería.\r\n- Gestionar las relaciones con bancos y otras instituciones financieras, negociando términos y condiciones favorables para la compañía.\r\n- Supervisar la preparación y presentación de informes financieros relacionados con la tesorería, asegurando la precisión y la puntualidad de la información.\r\n- Realizar análisis financieros y proyecciones de flujo de efectivo para respaldar la toma de decisiones estratégicas y la planificación financiera.\r\n- Identificar y evaluar oportunidades de mejora en los procesos y sistemas de tesorería, implementando soluciones eficientes y automatizadas.\r\n- Gestionar y desarrollar al equipo de tesorería, brindando orientación, capacitación y apoyo continuo para maximizar el rendimiento y el crecimiento profesional.\r\n\r\nRequisitos:\r\n\r\n- Experiencia previa en roles de liderazgo en tesorería o finanzas, preferiblemente en el sector financiero o fintech.\r\n- Sólidos conocimientos en gestión financiera, liquidez, inversiones y riesgo financiero.\r\n- Capacidad para analizar datos financieros y realizar proyecciones de flujo de efectivo con precisión y eficacia.\r\n- Excelentes habilidades de comunicación y negociación, con la capacidad de establecer y mantener relaciones efectivas con socios comerciales internos y externos.\r\n- Orientación a resultados y capacidad para tomar decisiones estratégicas en un entorno dinámico y cambiante.\r\n- Experiencia en el desarrollo y la implementación de políticas, procedimientos y controles internos relacionados con la tesorería.\r\n- Titulación universitaria en Finanzas, Economía, Administración de Empresas o campo relacionado. Se valorarán las certificaciones financieras adicionales.\r\n\r\nOfrecemos:\r\n\r\n- Oportunidades de crecimiento y desarrollo profesional en una empresa líder en el sector fintech.\r\n- Ambiente de trabajo colaborativo y dinámico, donde la innovación y la excelencia son valores fundamentales.\r\n- Remuneración competitiva y beneficios corporativos.\r\n- Participación en proyectos significativos que impactan positivamente en la vida de millones de usuarios.\r\n\r\nSi estás buscando un nuevo desafío en tu carrera y quieres formar parte de un equipo apasionado por la innovación y el éxito, ¡esperamos con interés recibir tu solicitud para el puesto de Líder de Tesorería en Personal Pay!\r\n",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("10/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("cb442d70-d201-457d-872e-5931991cd34d"),
                    CompanyId = Guid.Parse("ac270f24-3f1f-43a6-b291-1f0ce4489bfd"),
                    Title = "Sr. Cybersecurity Engineer - Personal Pay",
                    Description = "En Personal Pay, estamos buscando sumar profesionales Senior Cybersecurity Engineer para desempeñar un papel crucial en nuestra fintech. Este rol implica gestionar la identificación, promoción y mantenimiento de prácticas de seguridad sólidas en todos los aspectos del desarrollo y operaciones de software. Colaborarás estrechamente con equipos multifuncionales, liderando iniciativas para garantizar la integridad, confidencialidad y disponibilidad de los datos, así como la protección contra amenazas de seguridad.\r\n\r\nResponsabilidades:\r\n\r\n- Desarrollar e implementar estrategias y políticas de seguridad cibernética para proteger los sistemas y datos de la organización.\r\n- Realizar evaluaciones de riesgos de seguridad y análisis de vulnerabilidades para identificar y mitigar posibles amenazas.\r\n- Liderar la implementación de controles de seguridad en el desarrollo de software y en la infraestructura de TI, siguiendo las mejores prácticas y estándares de la industria.\r\n- Supervisar la detección y respuesta a incidentes de seguridad, investigando y gestionando activamente las amenazas y vulnerabilidades identificadas.\r\n- Colaborar con equipos de desarrollo y operaciones para integrar la seguridad en todas las etapas del ciclo de vida del desarrollo de software y en la infraestructura de TI.\r\n- Realizar pruebas de penetración y evaluaciones de seguridad, identificando y remediando debilidades en los sistemas y aplicaciones.\r\n- Mantenerse al tanto de las últimas tendencias y amenazas en seguridad cibernética, proporcionando orientación y recomendaciones para mejorar la postura de seguridad de la organización.\r\n- Participar en la creación y revisión de políticas de seguridad, procedimientos y estándares, asegurando su alineación con las regulaciones y requisitos de cumplimiento.\r\n\r\nRequisitos:\r\n\r\n- Experiencia previa en roles de seguridad cibernética, preferiblemente en el sector financiero o fintech.\r\n- Conocimientos sólidos de tecnologías y herramientas de seguridad cibernética, incluidas firewalls, sistemas de detección de intrusos, cifrado, autenticación y control de acceso.\r\n- Experiencia en la implementación y gestión de sistemas de gestión de seguridad de la información (ISMS) y programas de cumplimiento normativo (por ejemplo, ISO 27001, GDPR, PCI DSS).\r\n- Capacidad para identificar y evaluar vulnerabilidades de seguridad en sistemas y aplicaciones, y recomendar soluciones efectivas y pragmáticas.\r\n- Excelentes habilidades de comunicación y capacidad para trabajar en equipo, colaborando con diversas partes interesadas para lograr objetivos comunes.\r\n- Certificaciones de seguridad cibernética, como CISSP, CISM, CEH, son altamente valoradas.\r\n\r\nOfrecemos:\r\n\r\n- Oportunidades de crecimiento y desarrollo profesional en una empresa líder en el sector fintech.\r\n- Ambiente de trabajo colaborativo y dinámico, donde la innovación y la excelencia son valores fundamentales.\r\n- Remuneración competitiva y beneficios corporativos.\r\n- Participación en proyectos significativos que impactan positivamente en la vida de millones de usuarios.\r\n\r\nSi estás buscando un nuevo desafío en tu carrera y quieres formar parte de un equipo apasionado por la innovación y la seguridad, ¡esperamos con interés recibir tu solicitud para el puesto de Senior Cybersecurity Engineer en Personal Pay!\r\n",
                    JobOfferModeId = 3,
                    PublicationDate = DateTime.Parse("12/04/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("91a0529b-af68-4e6c-a67a-593cf3db1f34"),
                    CompanyId = Guid.Parse("ac270f24-3f1f-43a6-b291-1f0ce4489bfd"),
                    Title = "QA Automation SR Martech",
                    Description = "En nuestro equipo de Martech, estamos buscando un QA Automation Senior para contribuir al desarrollo y mantenimiento de un marco de automatización robusto utilizando herramientas y tecnologías actuales. Este rol implica escribir scripts de prueba automatizados eficientes y escalables utilizando lenguajes de programación como Java, Python o JavaScript. También serás responsable de implementar pruebas de API utilizando herramientas como Postman o SoapUI para verificar la funcionalidad y la integridad de las interfaces de programación de aplicaciones.\r\n\r\nResponsabilidades:\r\n\r\n- Desarrollar y mantener un marco de automatización robusto para pruebas de software.\r\n- Escribir scripts de prueba automatizados eficientes y escalables utilizando lenguajes de programación como Java, Python o JavaScript.\r\n- Diseñar y ejecutar pruebas de API utilizando herramientas como Postman o SoapUI para verificar la funcionalidad y la integridad de las interfaces de programación de aplicaciones.\r\n- Colaborar con equipos de desarrollo para comprender los requisitos de las pruebas y garantizar la cobertura adecuada.\r\n- Identificar y documentar problemas de calidad de software, seguimiento de errores y colaboración con equipos para su resolución.\r\n- Contribuir a la mejora continua de los procesos y prácticas de calidad del software en el equipo.\r\n\r\nRequisitos:\r\n\r\n- Experiencia previa en roles de QA Automation, preferiblemente en entornos de Martech.\r\n- Conocimientos sólidos de herramientas y tecnologías de automatización de pruebas, así como de lenguajes de programación como Java, Python o JavaScript.\r\n- Experiencia en el diseño y ejecución de pruebas de API utilizando herramientas como Postman o SoapUI.\r\n- Capacidad para trabajar de manera efectiva en un entorno ágil, colaborando con equipos multifuncionales para lograr objetivos comunes.\r\n- Excelentes habilidades de comunicación y capacidad para trabajar de forma independiente y en equipo.\r\n\r\nOfrecemos:\r\n\r\n- Oportunidades de crecimiento y desarrollo profesional en una empresa líder en el sector de Martech.\r\n- Ambiente de trabajo colaborativo y dinámico, donde la innovación y la excelencia son valores fundamentales.\r\n- Remuneración competitiva y beneficios corporativos.\r\n- Participación en proyectos significativos que impactan positivamente en la vida de millones de usuarios.\r\n\r\nSi estás buscando un nuevo desafío en tu carrera y quieres formar parte de un equipo apasionado por la calidad del software en el área de Martech, ¡esperamos con interés recibir tu solicitud para el puesto de QA Automation Senior en nuestro equipo!\r\n",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("20/04/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("b8f93f12-00de-4a26-bce2-4bf1d64ff1f4"),
                    CompanyId = Guid.Parse("ac270f24-3f1f-43a6-b291-1f0ce4489bfd"),
                    Title = "QA Automation SSR Martech",
                    Description = "En el equipo de Campañas / Martech de la compañía, estamos sumando profesionales QA Automation SSR, con pasión por la innovación, ganas de ser protagonistas y facilidad para el desempeño en un entorno desafiante y dinámico.\r\n\r\nComo parte de nuestro equipo, serás responsable de contribuir al desarrollo y mantenimiento de un marco de automatización sólido y eficiente para pruebas de software en el área de Campañas / Martech. Este rol implica escribir y ejecutar scripts de prueba automatizados, diseñar y ejecutar pruebas de API, colaborar con equipos multifuncionales y contribuir a la mejora continua de los procesos de calidad del software en el equipo.\r\n\r\nResponsabilidades:\r\n\r\n- Desarrollar y mantener un marco de automatización sólido y eficiente para pruebas de software en el área de Campañas / Martech.\r\n- Escribir y ejecutar scripts de prueba automatizados eficientes y escalables utilizando lenguajes de programación como Java, Python o JavaScript.\r\n- Diseñar y ejecutar pruebas de API utilizando herramientas como Postman o SoapUI para verificar la funcionalidad y la integridad de las interfaces de programación de aplicaciones.\r\n- Colaborar con equipos multifuncionales para comprender los requisitos de las pruebas y garantizar la cobertura adecuada.\r\n- Identificar y documentar problemas de calidad de software, seguimiento de errores y colaboración con equipos para su resolución.\r\n- Contribuir a la mejora continua de los procesos y prácticas de calidad del software en el equipo.\r\n\r\nRequisitos:\r\n\r\n- Experiencia previa en roles de QA Automation, preferiblemente en entornos de Campañas / Martech.\r\n- Conocimientos sólidos de herramientas y tecnologías de automatización de pruebas, así como de lenguajes de programación como Java, Python o JavaScript.\r\n- Experiencia en el diseño y ejecución de pruebas de API utilizando herramientas como Postman o SoapUI.\r\n- Capacidad para trabajar de manera efectiva en un entorno ágil, colaborando con equipos multifuncionales para lograr objetivos comunes.\r\n- Excelentes habilidades de comunicación y capacidad para trabajar de forma independiente y en equipo.\r\n\r\nOfrecemos:\r\n\r\n- Oportunidades de crecimiento y desarrollo profesional en una empresa líder en el sector de Campañas / Martech.\r\n- Ambiente de trabajo colaborativo y dinámico, donde la innovación y la excelencia son valores fundamentales.\r\n- Remuneración competitiva y beneficios corporativos.\r\n- Participación en proyectos significativos que impactan positivamente en la vida de millones de usuarios.\r\n\r\nSi estás buscando un nuevo desafío en tu carrera y quieres formar parte de un equipo apasionado por la calidad del software en el área de Campañas / Martech, ¡esperamos con interés recibir tu solicitud para el puesto de QA Automation SSR en nuestro equipo!\r\n",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("20/04/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("cf9f4731-26f7-4ee7-94d3-44e7ee7443bc"),
                    CompanyId = Guid.Parse("0d4ad714-56a4-4bfc-b4b4-d776cfd51fd8"),
                    Title = "Analista SEO",
                    Description = "En el equipo de TELECOM, estamos buscando un Analista SEO para liderar la estrategia de optimización de motores de búsqueda y aumentar el tráfico orgánico de nuestros sitios web. Este rol desempeñará un papel clave en la implementación de prácticas de SEO efectivas y colaborará estrechamente con otras áreas para asegurar la ejecución exitosa de las estrategias de mejora de SEO.\r\n\r\nResponsabilidades:\r\n\r\n1. Desarrollar y ejecutar estrategias de SEO para mejorar la visibilidad y el ranking de los sitios web de TELECOM en los motores de búsqueda.\r\n\r\n2. Realizar análisis exhaustivos de palabras clave, investigación de competidores y auditorías técnicas de SEO para identificar oportunidades de mejora.\r\n\r\n3. Optimizar el contenido existente y crear nuevo contenido optimizado para SEO, incluyendo títulos de páginas, meta descripciones, etiquetas de encabezado, etc.\r\n\r\n4. Colaborar con equipos de desarrollo web y de contenido para implementar las mejores prácticas de SEO en los sitios web.\r\n\r\n5. Monitorear y analizar el rendimiento de SEO utilizando herramientas analíticas y generar informes periódicos sobre métricas clave.\r\n\r\n6. Mantenerse al día con las tendencias y cambios en los algoritmos de búsqueda y ajustar las estrategias de SEO en consecuencia.\r\n\r\n7. Identificar y proponer nuevas oportunidades de mejora de SEO, incluyendo la optimización de la estructura del sitio, la arquitectura de enlaces internos, etc.\r\n\r\n8. Colaborar con equipos internos y externos para implementar cambios técnicos y de contenido necesarios para mejorar el rendimiento de SEO.\r\n\r\n9. Establecer y mantener relaciones con agencias y proveedores externos para apoyar las iniciativas de SEO, si es necesario.\r\n\r\nRequisitos:\r\n\r\n- Experiencia demostrada en SEO, preferiblemente en un entorno corporativo o de agencia.\r\n\r\n- Conocimiento sólido de las mejores prácticas de SEO, incluyendo investigación de palabras clave, optimización de contenido, enlaces internos y externos, etc.\r\n\r\n- Familiaridad con herramientas de SEO como Google Analytics, Google Search Console, SEMrush, Ahrefs, Moz, etc.\r\n\r\n- Excelentes habilidades analíticas y capacidad para interpretar datos y métricas de rendimiento de SEO.\r\n\r\n- Fuertes habilidades de comunicación y capacidad para colaborar efectivamente con equipos multidisciplinarios.\r\n\r\n- Orientación a resultados y capacidad para trabajar en un entorno dinámico y orientado a objetivos.\r\n\r\n- Certificaciones o cursos en SEO y marketing digital son una ventaja.\r\n\r\nOfrecemos:\r\n\r\n- Oportunidades de crecimiento y desarrollo profesional en una empresa líder en el sector de telecomunicaciones.\r\n\r\n- Ambiente de trabajo colaborativo y dinámico, donde la innovación y la excelencia son valores fundamentales.\r\n\r\n- Remuneración competitiva y beneficios corporativos.\r\n\r\n- Participación en proyectos estratégicos que impactan positivamente en la experiencia de nuestros usuarios y clientes.\r\n\r\nSi estás buscando un nuevo desafío en tu carrera y tienes experiencia en SEO, ¡esperamos con interés recibir tu solicitud para el puesto de Analista SEO en nuestro equipo de TELECOM!\r\n",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("11/04/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("87158aa4-8702-41be-bb46-11f3d7be70de"),
                    CompanyId = Guid.Parse("ac270f24-3f1f-43a6-b291-1f0ce4489bfd"),
                    Title = "Ejecutivo/a de Cuentas Gobierno",
                    Description = "En el equipo de VENTAS SECTOR PÚBLICO NACIÓN de la compañía, estamos buscando un/a Ejecutivo/a de Cuentas con experiencia en ventas y gestión de cuentas gubernamentales. Este rol será responsable de desarrollar relaciones comerciales con organismos gubernamentales a nivel nacional, identificar oportunidades de negocio y cerrar acuerdos comerciales que impulsen el crecimiento de la empresa en este sector.\r\n\r\nResponsabilidades:\r\n\r\n1. Desarrollar e implementar estrategias de ventas para el sector público, en línea con los objetivos comerciales de la empresa.\r\n\r\n2. Identificar y prospectar oportunidades de negocio en organismos gubernamentales a nivel nacional.\r\n\r\n3. Establecer y mantener relaciones comerciales sólidas con clientes gubernamentales, construyendo una cartera de cuentas estratégicas.\r\n\r\n4. Colaborar con otros equipos internos para garantizar la entrega efectiva de productos y servicios a clientes gubernamentales.\r\n\r\n5. Participar en licitaciones y procesos de contratación pública, asegurando el cumplimiento de los requisitos legales y comerciales.\r\n\r\n6. Negociar y cerrar acuerdos comerciales que generen valor para la empresa y sus clientes gubernamentales.\r\n\r\n7. Realizar seguimiento de las ventas, analizar el desempeño y elaborar informes periódicos para la dirección comercial.\r\n\r\n8. Mantenerse actualizado sobre las políticas y regulaciones gubernamentales relevantes que puedan afectar al negocio.\r\n\r\nRequisitos:\r\n\r\n- Experiencia previa en ventas y gestión de cuentas en el sector público, preferiblemente en el área de telecomunicaciones o tecnología.\r\n\r\n- Conocimiento sólido del proceso de contratación pública y de las normativas que rigen las relaciones comerciales con el sector público.\r\n\r\n- Habilidades de negociación y capacidad para cerrar acuerdos comerciales.\r\n\r\n- Excelentes habilidades de comunicación y capacidad para construir relaciones comerciales efectivas.\r\n\r\n- Orientación a resultados y capacidad para trabajar en un entorno competitivo.\r\n\r\n- Disponibilidad para viajar dentro del país, según sea necesario.\r\n\r\nOfrecemos:\r\n\r\n- Oportunidades de crecimiento y desarrollo profesional en una empresa líder en el sector de telecomunicaciones.\r\n\r\n- Ambiente de trabajo colaborativo y dinámico, donde la innovación y la excelencia son valores fundamentales.\r\n\r\n- Remuneración competitiva y beneficios corporativos.\r\n\r\n- Participación en proyectos estratégicos que impactan positivamente en la sociedad y en la transformación digital del país.\r\n\r\nSi tienes experiencia en ventas y cuentas gubernamentales y estás buscando un nuevo desafío en tu carrera, ¡esperamos recibir tu solicitud para unirte a nuestro equipo como Ejecutivo/a de Cuentas Gobierno en VENTAS SECTOR PÚBLICO NACIÓN!\r\n",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("27/04/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("b01bf51f-1bfa-4434-b70c-57c92e1b4c5d"),
                    CompanyId = Guid.Parse("ac270f24-3f1f-43a6-b291-1f0ce4489bfd"),
                    Title = "Líder de Tesorería",
                    Description = "En Personal Pay buscamos sumar al equipo un Líder de Tesorería. El propósito de este rol es mejorar la eficiencia, agilidad y seguridad en la gestión de los recursos financieros de la compañía.\r\n\r\nComo Líder de Tesorería, serás responsable de supervisar todas las actividades relacionadas con la gestión de efectivo, inversiones, financiamiento y riesgo financiero. Trabajarás en estrecha colaboración con otros equipos financieros para garantizar el cumplimiento de los objetivos corporativos y maximizar el valor para los accionistas.\r\n\r\nPrincipales responsabilidades:\r\n\r\n1. Desarrollar e implementar estrategias para la gestión eficiente de la liquidez y los flujos de efectivo de la empresa.\r\n\r\n2. Supervisar las transacciones financieras diarias, incluidos los pagos, cobros y transferencias bancarias.\r\n\r\n3. Evaluar y gestionar los riesgos financieros, incluidos los riesgos de tipo de cambio, interés y crédito.\r\n\r\n4. Realizar análisis financiero para respaldar la toma de decisiones estratégicas y operativas.\r\n\r\n5. Mantener relaciones sólidas con instituciones financieras, proveedores y otras partes interesadas.\r\n\r\n6. Implementar controles internos efectivos para garantizar la integridad y seguridad de los activos financieros de la empresa.\r\n\r\n7. Supervisar la preparación y presentación de informes financieros internos y externos.\r\n\r\n8. Dirigir y motivar a un equipo de profesionales de tesorería, brindando orientación y desarrollo profesional.\r\n\r\nRequisitos:\r\n\r\n- Experiencia previa en roles de tesorería o finanzas, preferiblemente en el sector financiero o corporativo.\r\n\r\n- Conocimientos sólidos en gestión de efectivo, inversiones y riesgo financiero.\r\n\r\n- Habilidades analíticas y capacidad para tomar decisiones basadas en datos.\r\n\r\n- Excelentes habilidades de comunicación y capacidad para trabajar en equipo.\r\n\r\n- Liderazgo demostrado y habilidades para motivar y desarrollar equipos.\r\n\r\n- Título universitario en Finanzas, Administración de Empresas, Economía o campo relacionado.\r\n\r\nOfrecemos:\r\n\r\n- Oportunidades de crecimiento y desarrollo profesional en una empresa líder en el sector de tecnología financiera.\r\n\r\n- Ambiente de trabajo dinámico y colaborativo, donde se fomenta la innovación y el aprendizaje continuo.\r\n\r\n- Remuneración competitiva y beneficios corporativos.\r\n\r\n- Participación en proyectos estratégicos que impactan positivamente en la sociedad y en la transformación digital del país.\r\n\r\nSi tienes experiencia en tesorería y estás buscando un nuevo desafío en tu carrera, ¡esperamos recibir tu solicitud para unirte a nuestro equipo como Líder de Tesorería en Personal Pay!\r\n",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("23/04/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("cb440631-9b4e-4a3c-808b-6eefb7640244"),
                    CompanyId = Guid.Parse("f4c4ffe2-e95d-4c05-a958-d32b26fecfc2"),
                    Title = "Pasante de Tecnología",
                    Description = "En nuestro equipo regional de estrategia y gobierno de tecnología, estamos buscando incorporar un Pasante para colaborar y apoyar en la planificación y ejecución de proyectos. \r\n\r\nComo Pasante de Tecnología, serás parte de un equipo dinámico y colaborativo, donde tendrás la oportunidad de aprender y desarrollarte en el área de estrategia y gobierno de tecnología. Trabajarás en estrecha colaboración con profesionales del sector, participando en proyectos clave y adquiriendo experiencia práctica en un entorno real de trabajo.\r\n\r\nPrincipales responsabilidades:\r\n\r\n1. Acompañar y asistir en la investigación y análisis de datos para informar la toma de decisiones estratégicas. Esto incluye la recopilación y análisis de datos relacionados con proyectos tecnológicos, tendencias del mercado, y mejores prácticas en el ámbito de la tecnología.\r\n\r\n2. Participar activamente en reuniones y presentaciones para comprender los objetivos y prioridades del equipo. Serás parte de discusiones estratégicas y tendrás la oportunidad de contribuir con ideas y sugerencias para mejorar los procesos y resultados del equipo.\r\n\r\n3. Contribuir con ideas y sugerencias para mejorar los procesos y resultados del equipo. Aportarás tu perspectiva fresca y tus habilidades analíticas para identificar áreas de mejora y proponer soluciones innovadoras.\r\n\r\n4. Realizar actividades de forma independiente en colaboración con la comunidad de tecnología regional. Tendrás la oportunidad de llevar a cabo proyectos individuales y trabajar en colaboración con otros pasantes y profesionales del equipo para alcanzar los objetivos establecidos.\r\n\r\nRequisitos:\r\n\r\n- Estudiante universitario o recién graduado en áreas relacionadas con tecnología, ingeniería, administración de empresas o afines. Buscamos personas apasionadas por la tecnología y con interés en aprender y desarrollarse en el área de estrategia y gobierno de tecnología.\r\n\r\n- Habilidades analíticas y capacidad para trabajar con datos. Serás responsable de realizar análisis de datos para informar la toma de decisiones, por lo que es importante que tengas habilidades analíticas sólidas y capacidad para trabajar con herramientas de análisis de datos.\r\n\r\n- Excelentes habilidades de comunicación y capacidad para trabajar en equipo. Serás parte de un equipo multidisciplinario, por lo que es fundamental que tengas habilidades de comunicación efectivas y capacidad para trabajar de manera colaborativa con otros profesionales del equipo.\r\n\r\n- Proactividad y capacidad para llevar a cabo tareas de manera independiente. Buscamos personas proactivas, con iniciativa y capacidad para trabajar de forma autónoma en la realización de tareas asignadas.\r\n\r\nOfrecemos:\r\n\r\n- Oportunidad de aprendizaje y desarrollo profesional en un entorno dinámico y desafiante. Como Pasante de Tecnología, tendrás la oportunidad de adquirir experiencia práctica en proyectos estratégicos de tecnología y desarrollar tus habilidades en un entorno real de trabajo.\r\n\r\n- Posibilidad de adquirir experiencia práctica en proyectos estratégicos de tecnología. Trabajarás en proyectos clave y tendrás la oportunidad de contribuir con ideas y soluciones innovadoras que impacten positivamente en el área de tecnología de la compañía.\r\n\r\n- Ambiente de trabajo colaborativo, donde se valora la innovación y el crecimiento personal. Serás parte de un equipo dinámico y colaborativo, donde se fomenta el intercambio de ideas, la innovación y el trabajo en equipo.\r\n\r\n- Posibilidad de realizar prácticas remuneradas. Ofrecemos la posibilidad de realizar prácticas remuneradas, donde recibirás una compensación económica por tu trabajo y contribución al equipo.\r\n\r\nSi estás buscando una oportunidad para poner en práctica tus conocimientos y crecer profesionalmente, ¡esta posición de Pasante de Tecnología puede ser ideal para ti! ¡Esperamos recibir tu solicitud!",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("06/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("8212d2fc-d4e7-47ee-8aee-846d9242dc85"),
                    CompanyId = Guid.Parse("f4c4ffe2-e95d-4c05-a958-d32b26fecfc2"),
                    Title = "Analista Financiero para Proyectos en Argentina y Uruguay",
                    Description = "En esta posición, tendrás la oportunidad de participar en proyectos financieros clave para Argentina y Uruguay. Serás responsable de diversas tareas relacionadas con el análisis y seguimiento financiero, asegurando el cumplimiento de los requerimientos de la compañía y contribuyendo al desarrollo de estrategias financieras efectivas.\r\n\r\nPrincipales responsabilidades:\r\n\r\n1. Armar, consolidar y actualizar mensualmente templates para enviar a casa matriz sobre métricas del área y Third Party Distribution. Esto incluye la recopilación y análisis de datos financieros para elaborar informes precisos y actualizados.\r\n\r\n2. Subir información a la plataforma UM Planning. Serás responsable de cargar información relevante en la plataforma UM Planning, asegurando la precisión y calidad de los datos.\r\n\r\n3. Confeccionar templates de gastos OPEX y ODC requeridos por la compañía. Deberás asegurar la correcta elaboración de estos templates, garantizando la consistencia y precisión de la información.\r\n\r\n4. Realizar el control Actual vs Plan. Serás responsable de comparar los resultados financieros actuales con el plan establecido, identificando desviaciones y proponiendo medidas correctivas.\r\n\r\n5. Armado de presentaciones de gastos para las diferentes áreas. Deberás preparar presentaciones claras y concisas sobre los gastos del área, proporcionando información relevante para la toma de decisiones.\r\n\r\n6. Participar en la confección del Plan Anual. Colaborarás en la elaboración del Plan Anual, aportando información y análisis financiero para respaldar las decisiones estratégicas de la compañía.\r\n\r\n7. Realizar presentaciones para el Country Manager, el CFO y otros stakeholders. Deberás comunicar de manera efectiva los resultados financieros y las estrategias propuestas ante diferentes audiencias, asegurando la comprensión y el respaldo de las mismas.\r\n\r\nRequisitos:\r\n\r\n- Estudios universitarios completos en áreas relacionadas con Finanzas, Economía, Administración de Empresas o afines.\r\n\r\n- Experiencia previa en posiciones similares, preferentemente en el área financiera de empresas multinacionales.\r\n\r\n- Conocimientos avanzados de Excel y herramientas de análisis financiero.\r\n\r\n- Habilidades analíticas y capacidad para trabajar con datos financieros complejos.\r\n\r\n- Excelentes habilidades de comunicación y capacidad para trabajar en equipo.\r\n\r\nOfrecemos:\r\n\r\n- Oportunidad de integrarte a una empresa líder en el mercado, con un equipo profesional y dinámico.\r\n\r\n- Posibilidad de participar en proyectos desafiantes y desarrollar tu carrera profesional en el área financiera.\r\n\r\n- Excelente ambiente de trabajo y beneficios corporativos.\r\n\r\nSi buscas un desafío en el área financiera y cumples con los requisitos mencionados, ¡te invitamos a formar parte de nuestro equipo como Analista Financiero para Proyectos en Argentina y Uruguay!",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("06/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("4dbb52e1-d34e-4383-8bcb-049e545020f2"),
                    CompanyId = Guid.Parse("f4c4ffe2-e95d-4c05-a958-d32b26fecfc2"),
                    Title = "Ingeniero Ejecutivo en Desarrollo de Software",
                    Description = "En esta emocionante posición como Ingeniero Ejecutivo en Desarrollo de Software, tendrás la responsabilidad de construir, mantener y respaldar las aplicaciones propiedad de nuestra compañía. Tu contribución será fundamental para garantizar que nuestras aplicaciones cumplan con los más altos estándares de seguridad y arquitectura, proporcionando soluciones robustas y confiables a nuestros clientes y usuarios internos.\r\n\r\nPrincipales responsabilidades:\r\n\r\n1. Construir, mantener y soportar las aplicaciones de propiedad de la compañía, asegurando su correcto funcionamiento y rendimiento.\r\n\r\n2. Garantizar que las aplicaciones desarrolladas cumplan con los estándares de seguridad y arquitectura de la compañía, implementando las mejores prácticas de desarrollo y las medidas de seguridad necesarias.\r\n\r\n3. Resolución de incidentes: Serás responsable de identificar y resolver cualquier incidente relacionado con las aplicaciones, asegurando una rápida recuperación y minimizando el impacto en los usuarios.\r\n\r\n4. Relevar funcionalidades actuales, diseñar y proponer mejoras: Serás responsable de analizar las funcionalidades actuales de las aplicaciones, proponer mejoras y diseñar soluciones innovadoras para satisfacer las necesidades del negocio.\r\n\r\n5. Mentoreo de desarrolladores .NET Junior: Brindarás orientación y soporte a los desarrolladores .NET Junior, compartiendo tu experiencia y conocimientos para impulsar su crecimiento y desarrollo profesional.\r\n\r\n6. Diseño de funciones API en REST y servicios web: Participarás en el diseño y desarrollo de funciones API en REST y servicios web, asegurando su eficiencia, escalabilidad y seguridad.\r\n\r\n7. Integración con bases de datos SQL: Implementarás la integración de las aplicaciones con bases de datos SQL, garantizando una gestión eficiente de los datos y un rendimiento óptimo de las aplicaciones.\r\n\r\n8. Programación de ETLs SQL: Desarrollarás y mantendrás procesos de extracción, transformación y carga de datos utilizando lenguaje SQL, asegurando la integridad y calidad de los datos.\r\n\r\n9. Cumplir con las metodologías de la compañía (AGILE, ITIL, otras): Seguirás las metodologías de desarrollo y gestión de proyectos establecidas por la compañía, asegurando la adopción de las mejores prácticas y la entrega exitosa de los proyectos.\r\n\r\nSi eres un apasionado del desarrollo de software, con sólidos conocimientos técnicos y habilidades de liderazgo, ¡te invitamos a formar parte de nuestro equipo como Ingeniero Ejecutivo en Desarrollo de Software y contribuir al éxito de nuestros proyectos!",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("06/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("7c081f3d-6f03-4a38-bc5d-88ebe23baf6e"),
                    CompanyId = Guid.Parse("f4c4ffe2-e95d-4c05-a958-d32b26fecfc2"),
                    Title = "Consultor de Riesgo Operativo",
                    Description = "Únete a nuestro equipo como Consultor de Riesgo Operativo y desempeña un papel clave en la implementación y gestión de los riesgos no financieros en nuestra región. Tu contribución será fundamental para garantizar la seguridad y estabilidad de nuestras operaciones, identificando y mitigando los riesgos operativos en cada país.\r\n\r\nPrincipales responsabilidades:\r\n\r\n1. Apoyar a la región en la implementación de la evaluación de riesgos no financieros, asegurando el cumplimiento de los estándares y políticas establecidos.\r\n\r\n2. Supervisar el registro de nuevos problemas y la documentación de cierre en cada país, garantizando la precisión y exhaustividad de la información.\r\n\r\n3. Revisar la calidad de los riesgos y controles evaluados en páginas abiertas, identificando áreas de mejora y oportunidades de fortalecimiento.\r\n\r\n4. Asistir en la implementación de políticas de riesgo operativo, asegurando su alineación con las mejores prácticas y estándares internacionales.\r\n\r\n5. Liderar la evaluación de objetivos regionales requeridos, colaborando estrechamente con los equipos locales para identificar y abordar los riesgos críticos.\r\n\r\n6. Asistir en la preparación de material para comités en América Latina, proporcionando información y análisis relevante para la toma de decisiones estratégicas.\r\n\r\n7. Desarrollar y monitorear diferentes indicadores clave para la gestión de riesgos, identificando tendencias y áreas de preocupación para una acción proactiva.\r\n\r\n8. Brindar apoyo a los países en el registro y escalada de eventos de riesgo, asegurando una respuesta eficaz y oportuna ante situaciones críticas.\r\n\r\nSi tienes experiencia en gestión de riesgos y estás buscando un desafío emocionante en un entorno dinámico y colaborativo, ¡únete a nuestro equipo como Consultor de Riesgo Operativo y contribuye al éxito de nuestra organización! En esta posición, tendrás la oportunidad de aplicar tus habilidades analíticas y estratégicas para gestionar y mitigar los riesgos operativos en nuestra región. Trabajarás en estrecha colaboración con equipos multifuncionales para implementar políticas y procedimientos que garanticen la seguridad y estabilidad de nuestras operaciones.\r\n\r\nAdemás, tendrás la oportunidad de liderar evaluaciones de riesgos regionales y participar en la preparación de material para comités, proporcionando información valiosa para la toma de decisiones estratégicas. Si estás buscando un desafío emocionante en un entorno dinámico y colaborativo, ¡esta posición es para ti!",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("08/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("a06d4fd8-3f4d-4bc7-8f70-4f9d3204000a"),
                    CompanyId = Guid.Parse("f4c4ffe2-e95d-4c05-a958-d32b26fecfc2"),
                    Title = "Sr. Full Stack Software Engineer",
                    Description = "Únete a nuestro equipo como Sr. Full Stack Software Engineer y desempeña un papel clave en el diseño y desarrollo de soluciones de extremo a extremo y arquitecturas de referencia, trabajando en un entorno ágil.\r\n\r\nPrincipales responsabilidades:\r\n\r\n1. Colaborar con los equipos de productos y soluciones para diseñar y desarrollar soluciones de extremo a extremo y arquitecturas de referencia, asegurando la alineación con los objetivos comerciales y las necesidades del cliente.\r\n\r\n2. Diseñar soluciones y ayudar a los equipos a ejecutar la implementación técnica para iniciativas digitales en la nube en América Latina, garantizando la escalabilidad, seguridad y eficiencia de las soluciones propuestas.\r\n\r\n3. Entregar soluciones que se alineen con las necesidades y requisitos comerciales del cliente, discutiendo los beneficios y riesgos de las diferentes opciones y asegurando una comprensión clara de la propuesta de valor.\r\n\r\n4. Liderar la implementación de prácticas de desarrollo ágil, fomentando la colaboración, la transparencia y la entrega continua de valor.\r\n\r\n5. Colaborar con equipos multifuncionales en un entorno distribuido para asegurar la calidad, el rendimiento y la escalabilidad de las soluciones implementadas.\r\n\r\n6. Participar en la revisión y mejora continua de los procesos y prácticas de desarrollo, identificando oportunidades de optimización y proponiendo soluciones innovadoras.\r\n\r\n7. Mantenerse actualizado sobre las tendencias tecnológicas y las mejores prácticas de la industria, aplicando conocimientos y habilidades para mejorar constantemente nuestras soluciones y procesos.\r\n\r\nSi tienes experiencia en el desarrollo de software Full Stack y estás buscando un desafío emocionante en un entorno dinámico y colaborativo, ¡únete a nuestro equipo como Sr. Full Stack Software Engineer y contribuye al éxito de nuestros proyectos digitales en América Latina!",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("06/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("1233490d-6014-4ebd-8ef5-1d3801d6b207"),
                    CompanyId = Guid.Parse("f4c4ffe2-e95d-4c05-a958-d32b26fecfc2"),
                    Title = "Release Train Engineer III",
                    Description = "Únete a nuestro equipo como Release Train Engineer III y lidera y orienta equipos ágiles en varios países de América Latina como parte de un modelo regional distribuido.\r\n\r\nResponsabilidades principales:\r\n\r\n1. Proporcionar liderazgo técnico y orientación a los equipos de desarrollo sobre arquitectura y diseño de soluciones, asegurando la coherencia y la alineación con las mejores prácticas y estándares de la compañía.\r\n\r\n2. Coordinar y alinear a más de 5 equipos ágiles en iniciativas grandes y complejas utilizando marcos de escala como SAFe (Scaled Agile Framework), garantizando una entrega integrada y alineada con los objetivos del negocio.\r\n\r\n3. Gestionar la entrega de soluciones regionales de principio a fin, abarcando desde la definición de requisitos hasta el desarrollo, pruebas y despliegue, asegurando la calidad y el cumplimiento de los plazos.\r\n\r\n4. Impulsar la mejora continua a través de la optimización de procesos, la automatización de tareas y la implementación de iniciativas de transformación digital, buscando maximizar la eficiencia y la productividad de los equipos y sistemas.\r\n\r\n5. Colaborar estrechamente con diversos socios comerciales y tecnológicos, así como con partes interesadas internas y externas, para comprender las necesidades del negocio y traducirlas en soluciones técnicas efectivas.\r\n\r\n6. Fomentar una cultura de colaboración, aprendizaje y mejora continua dentro de los equipos ágiles, promoviendo la transparencia, la responsabilidad y el trabajo en equipo.\r\n\r\nSi tienes experiencia en liderar equipos ágiles en entornos complejos y estás buscando un desafío emocionante en una compañía líder en su industria, ¡únete a nuestro equipo como Release Train Engineer III y contribuye al éxito de nuestros proyectos regionales en América Latina!",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("06/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("98c748ed-fb3e-46f0-881e-3f820ff28a4b"),
                    CompanyId = Guid.Parse("f4c4ffe2-e95d-4c05-a958-d32b26fecfc2"),
                    Title = "Auditor ejecutivo de Tecnología Informática II",
                    Description = "Únete a nuestro equipo como Auditor ejecutivo de Tecnología Informática II y lidera la planificación y ejecución de auditorías locales y regionales relacionadas con las funciones de tecnología informática y sistemas de información.\r\n\r\nPrincipales responsabilidades:\r\n\r\n1. Cubrir el plan de auditoría local de TI y proporcionar información para el plan regional, asegurando la entrega oportuna de auditorías relacionadas con las funciones de TI y SI, así como ayudar en auditorías integradas con auditores de negocios.\r\n\r\n2. Integrar otras disciplinas en estas auditorías, incluyendo: gestión de datos, analítica de datos, privacidad de datos y otros expertos en la materia según sea necesario.\r\n\r\n3. Preparar informes de auditoría para la revisión del AVP de Auditoría de TI y el Director de Auditoría de TI.\r\n\r\n4. Proponer programas de auditoría de TI y SI. Además, colaborar en el ejercicio anual de riesgo de universo de auditoría.\r\n\r\n5. Ejecutar la evaluación y prueba de procesos y controles, así como la identificación de áreas de riesgo en las áreas de responsabilidad y áreas relacionadas de Gestión de Riesgos.\r\n\r\n6. Mantenerse al tanto de los cambios en la auditoría, prácticas regulatorias, prácticas de la industria, entorno de amenazas de TI, nuevos marcos de riesgo de TI, soluciones y herramientas, y recomendar cambios en las evaluaciones de riesgo de auditoría y procedimientos de auditoría en consecuencia.\r\n\r\n7. Mantener una relación de trabajo positiva con los auditados y sostener una relación continua con los contactos clave del negocio.\r\n\r\nSi tienes experiencia en auditoría de tecnología informática y sistemas de información y estás buscando un desafío emocionante en una compañía líder en su industria, ¡únete a nuestro equipo como Auditor ejecutivo de Tecnología Informática II y contribuye al éxito de nuestros proyectos locales y regionales!",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("09/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("e9e19908-2b38-4d06-8499-2d6545d9de4b"),
                    CompanyId = Guid.Parse("f4c4ffe2-e95d-4c05-a958-d32b26fecfc2"),
                    Title = "Sr. Site Reliability Engineer",
                    Description = "Únete a nuestro equipo como Sr. Site Reliability Engineer y guía a los equipos de Active Directory en implementaciones en la nube, trabajando en un entorno ágil.\r\n\r\nPrincipales responsabilidades:\r\n\r\n1. Orientar a los equipos de Active Directory en la implementación de soluciones en la nube, asegurando la integración adecuada con las soluciones existentes y los estándares de seguridad de la compañía.\r\n\r\n2. Ser responsable de garantizar la ingeniería de fiabilidad del sitio incorporada dentro del diseño de la solución en la nube para garantizar la mantenibilidad y la disponibilidad de los servicios.\r\n\r\n3. Trabajar en estrecha colaboración con los equipos de implementación para comprender las necesidades específicas y el contexto de cada país, de modo que puedan implementar la solución de integración adecuada dadas las características del ecosistema local.\r\n\r\n4. Colaborar con otros equipos técnicos y de negocio para identificar oportunidades de mejora continua en la infraestructura y los procesos de operación, buscando aumentar la eficiencia y la confiabilidad de los servicios en la nube.\r\n\r\n5. Participar en la evaluación y selección de herramientas y tecnologías que mejoren la operación y el monitoreo de la infraestructura en la nube, asegurando la adopción de las mejores prácticas de la industria y los estándares de la compañía.\r\n\r\n6. Contribuir al diseño y desarrollo de arquitecturas resilientes y escalables para las aplicaciones y servicios en la nube, asegurando la alineación con las metas y objetivos de la empresa.\r\n\r\n7. Ser un referente técnico dentro del equipo, compartiendo conocimientos y buenas prácticas con los demás miembros, y promoviendo una cultura de aprendizaje continuo y mejora constante.\r\n\r\nSi tienes experiencia en la implementación y operación de servicios en la nube, y estás buscando un desafío estimulante en una empresa líder en su industria, ¡únete a nuestro equipo como Sr. Site Reliability Engineer y contribuye al éxito de nuestros proyectos en la nube!",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("01/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("4aa15359-2d8d-4e2c-9c07-7d6f1a5e7801"),
                    CompanyId = Guid.Parse("f4c4ffe2-e95d-4c05-a958-d32b26fecfc2"),
                    Title = "Senior Financial Consultant",
                    Description = "Únete a nuestro equipo como Senior Financial Consultant y lidera el proceso con los Directores Regionales para el monitoreo, reporte y análisis de la experiencia para dos de las seis regiones dentro del mercado de 2,000 a 5,000 vidas y PEO/Asociaciones.\r\n\r\nPrincipales responsabilidades:\r\n\r\n1. Responsabilidad directa por evaluar estrategias de fijación de precios de productos (nuevos negocios y renovaciones) para permitir que la empresa logre sus objetivos de crecimiento y rentabilidad.\r\n\r\n2. Responsabilidad directa por la identificación, evaluación, implementación y monitoreo de iniciativas de mercado local.\r\n\r\n3. Trabajar en estrecha colaboración con los equipos de ventas, marketing y operaciones para comprender las necesidades del mercado y desarrollar estrategias efectivas para impulsar el crecimiento y la rentabilidad.\r\n\r\n4. Colaborar con otros equipos funcionales y áreas de la empresa para identificar oportunidades de mejora en los procesos y procedimientos financieros, buscando aumentar la eficiencia y la efectividad de las operaciones.\r\n\r\n5. Participar en la evaluación y selección de herramientas y tecnologías financieras que mejoren la eficacia y la eficiencia de las operaciones financieras de la empresa.\r\n\r\n6. Contribuir al desarrollo y mantenimiento de modelos financieros para evaluar el desempeño financiero de la empresa y apoyar la toma de decisiones estratégicas.\r\n\r\n7. Ser un referente técnico dentro del equipo, compartiendo conocimientos y buenas prácticas con los demás miembros, y promoviendo una cultura de aprendizaje continuo y mejora constante.\r\n\r\nSi tienes experiencia en consultoría financiera y estás buscando un desafío estimulante en una empresa líder en su industria, ¡únete a nuestro equipo como Senior Financial Consultant y contribuye al éxito de nuestros proyectos financieros!",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("04/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("556e0544-f769-4d92-8a68-97148942b0b7"),
                    CompanyId = Guid.Parse("f4c4ffe2-e95d-4c05-a958-d32b26fecfc2"),
                    Title = "Instructor ejecutivo I",
                    Description = "Como Instructor Ejecutivo I, tendrás la responsabilidad de supervisar todo el ciclo de entrega de aprendizaje y desarrollo (L&D) desde la estrategia hasta la ejecución, aprovechando múltiples recursos y trabajando con diferentes socios, incluido el proveedor de servicios de procesamiento de negocios (BPO) y proveedores externos.\r\n\r\nEn colaboración con el equipo regional, supervisarás las finanzas y presupuestos de L&D para la respectiva línea de negocio (LoB), país(es) y función(es).\r\n\r\nDiseñarás el marco del programa específico de LoB (definición del alcance, modelo de entrega, conceptos), incluidas las comunicaciones previas y posteriores, y las expectativas de marketing, patrocinio y participación; aprovecharás GP para diseñar/desarrollar soluciones centradas en el aprendiz, medibles.\r\n\r\nConsultarás con líderes del cliente sobre la estrategia de aprendizaje y cómo aumentar el impacto del aprendizaje.\r\n\r\nTu papel implica liderar iniciativas de L&D que impacten positivamente en el crecimiento y desarrollo de los empleados, alineadas con la estrategia empresarial y las necesidades del cliente. Además, colaborarás estrechamente con equipos multifuncionales para garantizar la calidad y efectividad de los programas de capacitación.\r\n\r\nComo parte de tus responsabilidades, deberás estar al tanto de las últimas tendencias en aprendizaje y desarrollo, identificar oportunidades de mejora y proponer soluciones innovadoras para impulsar la eficacia de los programas de L&D. También serás responsable de establecer relaciones sólidas con los principales interesados y partes interesadas, asegurando su compromiso y apoyo a las iniciativas de capacitación.\r\n\r\nPara tener éxito en este rol, deberás tener una sólida comprensión de los principios de aprendizaje y desarrollo, así como habilidades avanzadas en comunicación, liderazgo y gestión de proyectos. Además, se valorará la experiencia previa en roles similares, así como la capacidad de trabajar de manera efectiva en entornos dinámicos y colaborativos.\r\n\r\nSi estás buscando una oportunidad emocionante para liderar y transformar las iniciativas de aprendizaje y desarrollo en una empresa líder en su industria, ¡esta posición podría ser para ti! ¡Esperamos recibir tu solicitud y conocerte pronto!\r\n",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("06/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("fc54aecd-32d3-4de3-94d0-e26d09d3a8e7"),
                    CompanyId = Guid.Parse("f4c4ffe2-e95d-4c05-a958-d32b26fecfc2"),
                    Title = "Analista Ejecutivo Financiero",
                    Description = @"Para la posición de Analista Ejecutivo Financiero, estamos buscando un profesional altamente capacitado y motivado para unirse a nuestro equipo en el área financiera de LATAM. Este rol es fundamental para garantizar la precisión y la integridad de nuestros registros financieros, así como para proporcionar análisis y apoyo críticos para nuestras operaciones.

                        Responsabilidades clave:

                        Revisión de transacciones complejas: Evaluar y revisar transacciones financieras complejas para garantizar su precisión y adecuación.

                        Preparación y contabilización de asientos contables: Preparar y contabilizar los asientos de diario necesarios para reflejar con precisión las transacciones financieras en los libros contables.

                        Reconciliación de balances y estados financieros: Realizar la conciliación entre los balances y estados financieros de LATAM según las normas GAAP/HYPE y los sistemas de contabilidad principales y auxiliares.

                        Análisis financiero y tendencias: Ayudar en el análisis de datos financieros, identificar tendencias y patrones, y preparar informes mensuales y reportes ad-hoc para respaldar la toma de decisiones informadas.

                        Implementación y mantenimiento de controles internos: Colaborar en la implementación y mantenimiento de controles internos para garantizar la integridad de los datos financieros y documentar los procesos.

                        Soporte para auditorías: Brindar apoyo durante las auditorías internas y externas, proporcionando información y documentación necesaria y respondiendo a las solicitudes de los auditores.

                        Requisitos:

                        Educación: Licenciatura en Contabilidad, Finanzas o un campo relacionado.

                        Experiencia: Experiencia previa en contabilidad financiera, análisis financiero o roles similares preferida.

                        Habilidades analíticas: Capacidad para analizar datos financieros complejos y derivar conclusiones significativas.

                        Excelentes habilidades comunicativas: Capacidad para comunicarse de manera efectiva con diferentes niveles de la organización y con partes externas.

                        Conocimiento técnico: Conocimiento sólido de los principios contables y financieros, así como experiencia con sistemas contables y Excel avanzado.

                        Orientación al detalle: Atención meticulosa a los detalles y capacidad para trabajar con precisión en un entorno exigente.

                        Esta es una oportunidad emocionante para unirse a una empresa líder en la región y contribuir al éxito financiero de la organización. Ofrecemos un entorno de trabajo dinámico y colaborativo, oportunidades de desarrollo profesional y un paquete de beneficios competitivos. Si cumples con los requisitos mencionados y estás listo para asumir este desafío, ¡esperamos recibir tu solicitud!",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("04/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("51ee0986-9f82-4a0f-86a7-64b1871ef3f2"),
                    CompanyId = Guid.Parse("f4c4ffe2-e95d-4c05-a958-d32b26fecfc2"),
                    Title = "Instructor Ejecutivo II",
                    Description = "Para la posición de Instructor Ejecutivo II, estamos buscando a un individuo altamente capacitado y motivado para liderar nuestras iniciativas de desarrollo y capacitación en toda la región. Este rol es esencial para garantizar la excelencia en la entrega de programas de aprendizaje y desarrollo que impulsen el crecimiento y el éxito de nuestra organización. Responsabilidades clave:\r\n\r\n1. Supervisión del ciclo de entrega de L&D: Supervisar todo el ciclo de entrega de aprendizaje y desarrollo, desde la estrategia hasta la ejecución, colaborando con múltiples recursos y trabajando con diferentes socios, incluidos proveedores de BPO y terceros.\r\n2. Gestión financiera de L&D: Colaborar con el equipo regional para supervisar las finanzas y los presupuestos de L&D para las áreas de negocio, países y funciones respectivos.\r\n3. Diseño de programas específicos de LoB: Diseñar el marco de programas específicos de línea de negocio (LoB), incluidos el alcance, el modelo de entrega, los conceptos y las expectativas de comunicación, marketing, patrocinio y participación previas y posteriores; aprovechar las mejores prácticas para diseñar y desarrollar soluciones centradas en el aprendiz y medibles.\r\n4. Consultoría estratégica de aprendizaje: Colaborar con líderes del cliente en estrategias de aprendizaje y cómo aumentar el impacto del aprendizaje en sus organizaciones.\r\n\r\nRequisitos:\r\n- Educación: Licenciatura en Psicología, Educación, Administración de Empresas u otro campo relacionado. Se prefiere una maestría o certificación en Desarrollo Organizacional o Gestión de Recursos Humanos.\r\n- Experiencia: Experiencia previa en roles de liderazgo en aprendizaje y desarrollo, preferiblemente en un entorno multinacional.\r\n- Habilidades de liderazgo: Fuertes habilidades de liderazgo y capacidad para trabajar de manera efectiva con equipos multidisciplinarios y diversos.\r\n- Orientación al cliente: Enfoque orientado al cliente y capacidad para comprender las necesidades y expectativas de los clientes internos y externos.\r\n- Excelentes habilidades comunicativas: Habilidades excepcionales de comunicación verbal y escrita en inglés y español.\r\n- Gestión del tiempo y organización: Capacidad para gestionar múltiples proyectos y prioridades de manera eficiente y cumplir con los plazos establecidos.\r\n\r\nEste es un emocionante desafío para un profesional apasionado por el desarrollo organizacional y el aprendizaje continuo. Ofrecemos un entorno de trabajo dinámico, oportunidades de crecimiento profesional y un paquete de beneficios competitivo. Si cumples con los requisitos mencionados y estás listo para liderar nuestras iniciativas de aprendizaje y desarrollo, ¡esperamos recibir tu solicitud!",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("08/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("0e3a7879-7587-43f5-a9cf-657a824d1fc5"),
                    CompanyId = Guid.Parse("f4c4ffe2-e95d-4c05-a958-d32b26fecfc2"),
                    Title = "Senior Data Architect",
                    Description = "Para la posición de Arquitecto de Datos Senior, estamos buscando a un individuo altamente capacitado y motivado para liderar nuestros proyectos de gestión de datos en toda la región. Este rol es esencial para garantizar la excelencia en la gestión y la calidad de los datos que impulsan el éxito de nuestra organización. Responsabilidades clave:\r\n\r\n1. Colaborar con el equipo de Gestión de Datos y Análisis (DnA) y otras partes interesadas para documentar los requisitos de Gobernanza de Datos y Calidad de Datos para la implementación de diversos proyectos de datos.\r\n2. Trabajar con el equipo de Gobernanza de Datos y socios comerciales para investigar, evaluar, documentar y mantener estándares, mejores prácticas y patrones de diseño en torno a los requisitos del proyecto y varios otros aspectos de las tecnologías ETL existentes y emergentes en apoyo de la implementación en la nube y Big Data.\r\n3. Recopilar requisitos para proyectos desde la perspectiva del equipo de Gobernanza de Datos y participar en la implementación general del proyecto.\r\n\r\nRequisitos:\r\n- Educación: Licenciatura en Ciencias de la Computación, Ingeniería de Software, o campo relacionado. Se valora la certificación en Gobernanza de Datos y Calidad de Datos.\r\n- Experiencia: Experiencia previa en roles de arquitectura de datos, preferiblemente en un entorno multinacional.\r\n- Habilidades técnicas: Conocimientos sólidos en tecnologías de gestión de datos, incluidas ETL, almacenamiento en la nube y Big Data.\r\n- Habilidades analíticas: Capacidad para analizar y comprender los requisitos de los proyectos de datos y traducirlos en soluciones técnicas efectivas.\r\n- Habilidades de comunicación: Excelentes habilidades de comunicación verbal y escrita en inglés y español.\r\n- Gestión del tiempo y organización: Capacidad para gestionar múltiples proyectos y prioridades de manera eficiente y cumplir con los plazos establecidos.\r\n\r\nEste es un emocionante desafío para un profesional apasionado por la gestión de datos y la arquitectura de datos. Ofrecemos un entorno de trabajo dinámico, oportunidades de crecimiento profesional y un paquete de beneficios competitivo. Si cumples con los requisitos mencionados y estás listo para liderar nuestros proyectos de gestión de datos, ¡esperamos recibir tu solicitud!",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("09/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4,
                },
                new Offer
                {
                    OfferId = Guid.Parse("d3d478ef-2b5a-4265-a81c-7d9123982fb9"),
                    CompanyId = Guid.Parse("ddc7879b-e104-4047-bd15-d0fade9bbeee"),
                    Title = "Hunter",
                    Description = "¡Únete a nuestro equipo como Hunter y sé parte de nuestra misión de expandir nuestra red de restaurantes aliados! Como Hunter, serás responsable de establecer nuevas alianzas con restaurantes a través de trabajo en campo y visitas diarias a posibles aliados. Tus principales responsabilidades incluirán:\r\n\r\n- Crear y mantener relaciones sólidas con los restaurantes locales mediante visitas regulares y presentación de nuestras propuestas de colaboración.\r\n- Cumplir con las metas de adquisición mensuales establecidas por la empresa.\r\n- Identificar y contactar a potenciales aliados en las ciudades designadas para expandir nuestra presencia en el mercado.\r\n\r\nSi te apasiona el trabajo en campo, tienes habilidades de persuasión y te gusta establecer nuevas conexiones comerciales, ¡esta es la oportunidad perfecta para ti! Requisitos:\r\n- Experiencia previa en ventas, preferiblemente en la industria de servicios de alimentos o similares.\r\n- Habilidades de comunicación efectivas y capacidad para construir relaciones sólidas con clientes potenciales.\r\n- Orientación a resultados y capacidad para trabajar bajo presión para alcanzar objetivos mensuales.\r\n- Motivación y entusiasmo para trabajar en un entorno dinámico y en constante cambio.\r\n\r\nOfrecemos un ambiente de trabajo colaborativo, oportunidades de crecimiento profesional y un paquete de beneficios competitivo. Si estás listo para aceptar el desafío y contribuir al crecimiento de nuestra empresa, ¡esperamos recibir tu solicitud!",
                    JobOfferModeId = 1,
                    PublicationDate = DateTime.Parse("10/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4
                },
                new Offer
                {
                    OfferId = Guid.Parse("c7aeb14d-01e7-4d08-b659-11c424e69728"),
                    CompanyId = Guid.Parse("ddc7879b-e104-4047-bd15-d0fade9bbeee"),
                    Title = "Key Account Manager",
                    Description = "¡Únete a nuestro equipo como Key Account Manager y sé parte de nuestra emocionante misión de transformar la manera en que las personas se conectan con los servicios esenciales a través de la tecnología! En Rappi, estamos comprometidos con ofrecer experiencias excepcionales a nuestros clientes y construir relaciones sólidas con nuestros socios comerciales. Como Key Account Manager, tendrás la oportunidad de liderar nuestra estrategia de gestión de cuentas clave y ser el principal punto de contacto entre Rappi y nuestros socios comerciales más importantes. Tus responsabilidades incluirán:\r\n\r\n- Desarrollar y mantener relaciones sólidas con los principales socios comerciales de Rappi en Argentina, asegurando una colaboración efectiva y de beneficio mutuo.\r\n- Identificar oportunidades de crecimiento y colaboración con los socios comerciales existentes, buscando maximizar el valor generado para ambas partes.\r\n- Gestionar el ciclo de vida completo de la relación con los socios comerciales, desde la incorporación inicial hasta la renovación y expansión continua de la colaboración.\r\n- Coordinar internamente con equipos interfuncionales, incluyendo operaciones, marketing, finanzas y servicio al cliente, para garantizar la entrega exitosa de los compromisos acordados con los socios comerciales.\r\n- Monitorizar y analizar métricas clave de rendimiento relacionadas con la colaboración con los socios comerciales, identificando áreas de mejora y oportunidades para optimizar el desempeño.\r\n- Representar a Rappi en reuniones y eventos con socios comerciales, proporcionando actualizaciones sobre el desempeño de la colaboración y buscando activamente oportunidades para fortalecer la relación.\r\n\r\nBuscamos a un profesional motivado y orientado a resultados, con una sólida experiencia en gestión de cuentas clave y una pasión por construir relaciones comerciales sólidas y duraderas. Requisitos:\r\n- Experiencia previa en gestión de cuentas clave o ventas empresariales, preferiblemente en la industria de tecnología, logística o servicios digitales.\r\n- Excelentes habilidades de comunicación y negociación, con la capacidad de establecer relaciones efectivas con una amplia gama de interlocutores.\r\n- Orientación al cliente y capacidad para comprender las necesidades y desafíos de los socios comerciales, buscando soluciones innovadoras y creativas para satisfacer sus requerimientos.\r\n- Capacidad para trabajar de forma autónoma y gestionar múltiples proyectos simultáneamente en un entorno dinámico y en constante evolución.\r\n- Mentalidad analítica y capacidad para analizar datos y métricas para identificar tendencias, oportunidades y desafíos en la colaboración con los socios comerciales.\r\n\r\nOfrecemos un ambiente de trabajo dinámico y colaborativo, oportunidades de crecimiento profesional y un paquete de beneficios competitivo. Si estás listo para aceptar el desafío y contribuir al éxito de una de las empresas tecnológicas líderes en América Latina, ¡esperamos recibir tu solicitud! Para más información, consulta nuestra página web en [https://about.rappi.com/es](https://about.rappi.com/es) y revisa las reseñas de nuestros empleados en Glassdoor en [https://acortar.link/Eqm07Q](https://acortar.link/Eqm07Q)",
                    JobOfferModeId = 1,
                    PublicationDate = DateTime.Parse("10/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4
                },
                new Offer
                {
                    OfferId = Guid.Parse("4a6decd4-ae8b-4a6d-95eb-13aeb00770a7"),
                    CompanyId = Guid.Parse("ddc7879b-e104-4047-bd15-d0fade9bbeee"),
                    Title = "Operations Analyst",
                    Description = "¡Únete a nuestro equipo como Operations Analyst y sé parte de nuestra misión de optimizar las operaciones de Groceries en Rappi! En este emocionante rol, serás responsable de garantizar una experiencia de 360 grados para todo el ecosistema comercial de Groceries, incluidos los usuarios, los repartidores (RTs), los Shoppers y los socios comerciales. Tus responsabilidades incluirán:\r\n\r\n- Optimizar las operaciones de Groceries en Rappi, asegurando que se cumplan consistentemente los SLAs clave y proporcionando una experiencia excepcional para todos los participantes.\r\n- Identificar proactivamente problemas operativos y proponer soluciones efectivas para abordarlos, garantizando la eficiencia y la calidad en todas las áreas de la operación.\r\n- Crear análisis detallados para generar ideas accionables y proporcionar información estratégica a los equipos de liderazgo y toma de decisiones.\r\n- Trabajar en colaboración estrecha con nuestros equipos comerciales, tecnológicos y de datos para resolver problemas complejos y mejorar continuamente las operaciones de Groceries.\r\n\r\nBuscamos a un profesional con experiencia en análisis de operaciones, con un enfoque orientado a resultados y una pasión por la mejora continua. Requisitos:\r\n- Experiencia previa en análisis de operaciones, preferiblemente en la industria de tecnología, logística o servicios digitales.\r\n- Excelentes habilidades analíticas y capacidad para convertir datos en acciones tangibles, generando ideas innovadoras y soluciones efectivas.\r\n- Orientación al cliente y capacidad para comprender las necesidades y desafíos de los usuarios y socios comerciales, buscando soluciones creativas para mejorar su experiencia.\r\n- Habilidades de comunicación y trabajo en equipo, con la capacidad de colaborar eficazmente con una variedad de equipos interfuncionales en un entorno dinámico.\r\n\r\nOfrecemos un ambiente de trabajo dinámico y colaborativo, oportunidades de crecimiento profesional y un paquete de beneficios competitivo. Si estás listo para aceptar el desafío y contribuir al éxito de una de las empresas tecnológicas líderes en América Latina, ¡esperamos recibir tu solicitud!",
                    JobOfferModeId = 1,
                    PublicationDate = DateTime.Parse("05/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4
                },
                new Offer
                {
                    OfferId = Guid.Parse("87b7e22d-d7fd-45c0-b0c3-06da652cb9eb"),
                    CompanyId = Guid.Parse("ddc7879b-e104-4047-bd15-d0fade9bbeee"),
                    Title = "Backend Developer",
                    Description = "¡Únete a nuestro equipo como Backend Developer y contribuye al desarrollo y mantenimiento de microservicios utilizando tecnologías de vanguardia como Kotlin y Node JS! En este emocionante rol, serás parte integral del ciclo de vida de los microservicios, participando en su diseño, implementación, pruebas y liberación. Tus responsabilidades incluirán:\r\n\r\n- Desarrollar y mantener microservicios utilizando tecnologías modernas como Kotlin y Node JS, asegurando la escalabilidad, el rendimiento y la fiabilidad del sistema.\r\n- Participar en todas las etapas del ciclo de vida de los microservicios, desde la definición de requisitos hasta la liberación y mantenimiento en producción.\r\n- Crear pruebas unitarias y de integración para garantizar la calidad y estabilidad de los microservicios desarrollados.\r\n- Escribir código limpio, modular y reutilizable, siguiendo las mejores prácticas de desarrollo de software y contribuyendo al crecimiento y mantenimiento del código base.\r\n- Colaborar estrechamente con otros miembros del equipo de desarrollo para definir y diseñar la arquitectura de los microservicios, asegurando su coherencia y cohesión.\r\n- Participar en pruebas y depuración de los microservicios, identificando y resolviendo eficientemente problemas y errores.\r\n- Liberar nuevas funcionalidades a producción de forma regular y segura, siguiendo los procedimientos establecidos y garantizando la disponibilidad y estabilidad del sistema.\r\n- Documentar la aplicación y sus procesos, proporcionando información clara y completa para facilitar su comprensión y mantenimiento.\r\n- Contribuir al diseño y definición de APIs, asegurando su coherencia, facilidad de uso y compatibilidad con los requisitos del sistema.\r\n\r\nBuscamos a un profesional apasionado por el desarrollo de software, con experiencia en el desarrollo de microservicios y un sólido conocimiento de tecnologías como Kotlin y Node JS.\r\n\r\nRequisitos:\r\n- Experiencia previa en el desarrollo de microservicios utilizando tecnologías como Kotlin y Node JS, preferiblemente en entornos de alta disponibilidad y escalabilidad.\r\n- Conocimiento sólido de pruebas unitarias y de integración, así como de metodologías ágiles de desarrollo de software como Scrum o Kanban.\r\n- Habilidades de comunicación y trabajo en equipo, con la capacidad de colaborar eficazmente con otros miembros del equipo y stakeholders en un entorno dinámico y colaborativo.\r\n- Orientación a resultados y capacidad para trabajar de forma autónoma y proactiva, gestionando eficientemente su tiempo y prioridades para cumplir con los objetivos del proyecto.\r\n\r\nOfrecemos un ambiente de trabajo dinámico y colaborativo, oportunidades de crecimiento profesional y un paquete de beneficios competitivo. Si estás listo para aceptar el desafío y contribuir al éxito de una de las empresas tecnológicas líderes en América Latina, ¡esperamos recibir tu solicitud!",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("20/04/2024"),
                    CityId = 022007,
                    StudyTypeId = 4
                },
                new Offer
                {
                    OfferId = Guid.Parse("2a47a025-03b4-46a3-985a-45e1a1e52b53"),
                    CompanyId = Guid.Parse("ddc7879b-e104-4047-bd15-d0fade9bbeee"),
                    Title = "Street Hunter",
                    Description = "¡Únete a nuestro equipo como Street Hunter y sé parte de la creación de nuevas alianzas con restaurantes a través de trabajo en campo! En este emocionante rol, serás responsable de realizar visitas diarias a nuestros aliados para fortalecer nuestras relaciones y expandir nuestra red de colaboradores.\r\n\r\nTus responsabilidades incluirán:\r\n- Realizar visitas diarias a nuestros aliados para establecer y fortalecer relaciones comerciales, identificar oportunidades de colaboración y resolver posibles problemas o inconvenientes.\r\n- Cumplir con las metas mensuales establecidas, trabajando de manera proactiva y eficiente para alcanzar y superar los objetivos comerciales y de crecimiento del negocio.\r\n- Identificar y contactar potenciales aliados en ciudades predeterminadas, utilizando estrategias efectivas de prospección y comunicación para generar interés y cerrar acuerdos comerciales.\r\n\r\nBuscamos a un profesional proactivo y orientado a resultados, con excelentes habilidades de comunicación y negociación.\r\n\r\nRequisitos:\r\n- Experiencia previa en ventas o atención al cliente, preferiblemente en la industria de alimentos y bebidas o servicios de entrega a domicilio.\r\n- Habilidades de negociación y persuasión, con la capacidad de cerrar acuerdos comerciales y establecer relaciones sólidas con los aliados.\r\n- Orientación a resultados y capacidad para trabajar de forma autónoma y proactiva, gestionando eficientemente su tiempo y recursos para alcanzar los objetivos establecidos.\r\n\r\nOfrecemos un ambiente de trabajo dinámico y colaborativo, oportunidades de crecimiento profesional y un paquete de beneficios competitivo.\r\n\r\nSi estás listo para aceptar el desafío y contribuir al éxito de una de las empresas tecnológicas líderes en América Latina, ¡esperamos recibir tu solicitud!",
                    JobOfferModeId = 1,
                    PublicationDate = DateTime.Parse("26/04/2024"),
                    CityId = 022007,
                    StudyTypeId = 4
                },
                new Offer
                {
                    OfferId = Guid.Parse("0df2461b-f778-4d26-8a0b-88e63010bc63"),
                    CompanyId = Guid.Parse("ddc7879b-e104-4047-bd15-d0fade9bbeee"),
                    Title = "Top Deal Hunter",
                    Description = "¡Únete a nuestro equipo como Top Deal Hunter y conviértete en un experto en la negociación y perfilamiento de clientes clave en Buenos Aires! En este apasionante rol, serás responsable de gestionar cuentas estratégicas, planificar y preparar tu cartera de clientes, realizar análisis de la competencia y mantener un conocimiento especializado del mercado de restaurantes en la región. Además, utilizarás tus habilidades de influencia y presentación para cerrar acuerdos exitosos y contribuir al crecimiento y éxito de nuestra plataforma.\r\n\r\nResponsabilidades:\r\n- Negociación avanzada con clientes clave para asegurar acuerdos beneficiosos para ambas partes.\r\n- Planificación y preparación de la cartera de clientes, identificando oportunidades de crecimiento y desarrollo.\r\n- Análisis continuo de la competencia y del mercado de restaurantes para identificar tendencias y oportunidades.\r\n- Desarrollo de relaciones sólidas con los clientes, construyendo confianza y manteniendo una comunicación abierta y efectiva.\r\n- Utilización de habilidades de influencia y presentación para persuadir a clientes potenciales y cerrar acuerdos comerciales exitosos.\r\n\r\nRequisitos:\r\n- Experiencia previa en ventas, negociación o gestión de cuentas clave, preferiblemente en la industria de alimentos y bebidas o servicios de entrega a domicilio.\r\n- Conocimiento sólido del mercado de restaurantes en Buenos Aires y capacidad para identificar oportunidades de negocio.\r\n- Alta capacidad de influencia y habilidades de comunicación efectiva, tanto verbal como escrita.\r\n- Orientación a resultados y capacidad para trabajar de manera autónoma y en equipo.\r\n\r\nOfrecemos un ambiente de trabajo dinámico y desafiante, oportunidades de desarrollo profesional y un paquete de beneficios competitivo.\r\n\r\nSi estás buscando un nuevo desafío y tienes pasión por las ventas y la negociación, ¡te invitamos a formar parte de nuestro equipo como Top Deal Hunter en Buenos Aires!",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("26/04/2024"),
                    CityId = 022007,
                    StudyTypeId = 4
                },
                new Offer
                {
                    OfferId = Guid.Parse("d63e5d07-606f-414b-86d7-2b9f9907bde0"),
                    CompanyId = Guid.Parse("9d8b9e84-33a7-4c28-a6c0-5941a68f1968"),
                    Title = "Azure Engineer",
                    Description = "Únete a nuestro equipo como Azure Engineer y desempeña un papel fundamental en la implementación y mantenimiento de políticas, estándares y procedimientos de seguridad específicos para la nube. En este emocionante rol, serás responsable de administrar y configurar inquilinos de Azure, establecer políticas de acceso, configurar ExpressRoute, administrar firewalls, monitorear y auditar eventos de seguridad, proteger datos sensibles y gestionar cuentas y claves de contraseña.\r\n\r\nAdemás, llevarás a cabo comprobaciones de estado técnico y brindarás apoyo en implementaciones de producción, garantizando la estabilidad y seguridad de nuestra infraestructura en la nube.\r\n\r\nRequisitos:\r\n- Experiencia previa en administración de infraestructura en la nube, preferiblemente en Azure.\r\n- Conocimiento sólido de políticas de seguridad en la nube, controles de acceso y auditoría.\r\n- Capacidad para realizar comprobaciones de estado técnico y resolver problemas de manera efectiva.\r\n- Certificaciones relevantes en Azure son altamente valoradas.\r\n- Excelentes habilidades de comunicación y trabajo en equipo.\r\n\r\nResponsabilidades:\r\n- Colaborar con equipos de desarrollo y operaciones para garantizar la implementación efectiva de políticas de seguridad.\r\n- Participar en la planificación y ejecución de estrategias de seguridad en la nube.\r\n- Realizar evaluaciones de riesgos y recomendaciones para mejorar la seguridad de la infraestructura.\r\n- Mantenerse al día con las últimas tendencias y tecnologías en seguridad en la nube.\r\n\r\nOfrecemos un ambiente de trabajo dinámico y desafiante, oportunidades de desarrollo profesional y un paquete de beneficios competitivo.\r\n\r\nSi estás buscando un nuevo desafío en el campo de la seguridad en la nube y tienes experiencia en Azure, ¡te invitamos a aplicar para unirte a nuestro equipo como Azure Engineer!",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("10/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4
                },
                new Offer
                {
                    OfferId = Guid.Parse("93c7688d-e348-44db-97ec-cd46e4e46d53"),
                    CompanyId = Guid.Parse("9d8b9e84-33a7-4c28-a6c0-5941a68f1968"),
                    Title = "Salesforce Integrations",
                    Description = "Únete a nuestro equipo como especialista en Salesforce Integrations y sé parte de grandes proyectos a nivel local y global. En este emocionante rol, tendrás la oportunidad de implementar tecnologías de vanguardia y participar activamente en la transformación digital de nuestra organización.\r\n\r\nResponsabilidades:\r\n- Colaborar en la planificación, diseño e implementación de integraciones de Salesforce en proyectos estratégicos.\r\n- Desarrollar soluciones técnicas para integraciones complejas entre Salesforce y otros sistemas empresariales.\r\n- Configurar y personalizar Salesforce para cumplir con los requisitos específicos del negocio.\r\n- Realizar pruebas exhaustivas y garantizar la calidad de las integraciones implementadas.\r\n- Brindar soporte técnico y resolver problemas relacionados con las integraciones de Salesforce.\r\n\r\nRequisitos:\r\n- Experiencia previa en el desarrollo e implementación de integraciones de Salesforce.\r\n- Conocimiento sólido de las herramientas y tecnologías de integración de Salesforce, como Apex, Visualforce, Lightning Components, REST/SOAP APIs, etc.\r\n- Capacidad para trabajar en equipo y comunicarse eficazmente con diferentes partes interesadas.\r\n- Certificaciones de Salesforce son altamente valoradas.\r\n\r\nOfrecemos un ambiente de trabajo dinámico, oportunidades de crecimiento profesional y un paquete de beneficios competitivo.\r\n\r\nResponsabilidades adicionales:\r\n- Investigar y evaluar nuevas funcionalidades de Salesforce para mejorar las integraciones existentes.\r\n- Colaborar con equipos de desarrollo externos para garantizar la integración fluida de Salesforce con otros sistemas.\r\n- Desarrollar y mantener documentación técnica detallada sobre las integraciones de Salesforce.\r\n- Participar en reuniones y presentaciones para demostrar el valor de las integraciones de Salesforce y proporcionar actualizaciones sobre el progreso del proyecto.\r\n- Identificar y resolver problemas de rendimiento y escalabilidad en las integraciones de Salesforce.\r\n- Mantenerse actualizado sobre las últimas tendencias y prácticas recomendadas en integración de sistemas y tecnologías relacionadas con Salesforce.\r\n\r\nBeneficios adicionales:\r\n- Horario flexible y posibilidad de teletrabajo.\r\n- Programas de capacitación y desarrollo profesional.\r\n- Ambiente de trabajo colaborativo y motivador.\r\n- Oportunidades de crecimiento dentro de la empresa.\r\n\r\n¡Si estás listo para unirte a un equipo apasionado por la innovación y la excelencia, no dudes en aplicar para esta emocionante oportunidad como especialista en Salesforce Integrations!",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("10/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4
                },
                new Offer
                {
                    OfferId = Guid.Parse("82b546bb-5fc3-40e0-b21e-1a9f01d79a92"),
                    CompanyId = Guid.Parse("9d8b9e84-33a7-4c28-a6c0-5941a68f1968"),
                    Title = "Workplace Service Delivery Analyst",
                    Description = "Únete a nuestro equipo como Analista de Entrega de Servicios en el Lugar de Trabajo y sé parte de la experiencia de cliente dentro de las oficinas de Accenture. En este rol, serás responsable de entregar soluciones relacionadas con el uso del espacio, la reserva de salas, el estacionamiento y los pedidos de catering. Además, trabajarás en la estandarización de procesos para mejorar los indicadores de rendimiento del sector y coordinarás proveedores de servicios en sala, mozos, catering, entre otros.\r\n\r\nResponsabilidades:\r\n- Entregar soluciones de experiencia de cliente relacionadas con el uso del espacio, la reserva de salas, el estacionamiento y los pedidos de catering.\r\n- Estandarizar procesos para mejorar los indicadores de performance del sector.\r\n- Imaginar, crear, describir e implementar soluciones innovadoras relacionadas con la experiencia de cliente dentro de las oficinas de Accenture.\r\n- Coordinar proveedores de servicios en sala, mozos, catering, entre otros.\r\n\r\nRequisitos:\r\n- Experiencia previa en roles similares dentro del área de servicios al cliente o gestión de instalaciones.\r\n- Conocimiento de herramientas y procesos relacionados con la gestión de espacios y servicios en el lugar de trabajo.\r\n- Habilidades para la estandarización de procesos y mejora continua.\r\n- Capacidad para imaginar, crear e implementar soluciones innovadoras.\r\n- Excelentes habilidades de comunicación y coordinación con proveedores externos.\r\n\r\nOfrecemos un ambiente de trabajo dinámico, oportunidades de crecimiento profesional y un paquete de beneficios competitivo.\r\n\r\nResponsabilidades adicionales:\r\n- Realizar seguimiento de la satisfacción del cliente y proponer mejoras en los servicios ofrecidos.\r\n- Colaborar con otros equipos para garantizar una experiencia de cliente excepcional en todas las interacciones.\r\n- Participar en proyectos de mejora continua y optimización de procesos.\r\n- Mantenerse actualizado sobre las tendencias y mejores prácticas en la gestión de servicios en el lugar de trabajo.\r\n- Contribuir al desarrollo y ejecución de la estrategia global de experiencia de cliente de Accenture.\r\n\r\nBeneficios adicionales:\r\n- Horario flexible y posibilidad de teletrabajo.\r\n- Programas de capacitación y desarrollo profesional.\r\n- Ambiente de trabajo colaborativo y motivador.\r\n- Oportunidades de crecimiento dentro de la empresa.\r\n\r\n¡Si estás listo para unirte a un equipo apasionado por brindar experiencias excepcionales a nuestros clientes, no dudes en aplicar para esta emocionante oportunidad como Analista de Entrega de Servicios en el Lugar de Trabajo!",
                    JobOfferModeId = 1,
                    PublicationDate = DateTime.Parse("05/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4
                },
                new Offer
                {
                    OfferId = Guid.Parse("cb6fe4d5-c44d-4f54-8826-d6b7b4528ef0"),
                    CompanyId = Guid.Parse("9d8b9e84-33a7-4c28-a6c0-5941a68f1968"),
                    Title = "Senior Analyst - Career Launch Representative",
                    Description = "¡Únete a nuestro equipo como Analista Senior Representante de Lanzamiento de Carrera y sé parte de una experiencia de integración única para nuestros nuevos empleados! En este rol, serás responsable de realizar llamadas con los nuevos integrantes, brindándoles una experiencia de integración personalizada y de alta calidad.\r\n\r\nResponsabilidades:\r\n\r\n1. Realizar llamadas con los nuevos integrantes: Serás el primer punto de contacto para nuestros nuevos empleados, proporcionándoles una cálida bienvenida y guiándolos a través del proceso de integración.\r\n\r\n2. Revisar y registrar datos de los nuevos integrantes: Serás responsable de asegurarte de que toda la información proporcionada por los nuevos empleados se registre con precisión en nuestros sistemas internos.\r\n\r\n3. Demostrar capacidad para realizar múltiples tareas: En este rol, deberás ser capaz de manejar varias llamadas y tareas administrativas al mismo tiempo, manteniendo siempre un alto nivel de precisión y atención al detalle.\r\n\r\n4. Ingresar a los nuevos integrantes en la herramienta de programación de orientación: Serás responsable de coordinar la programación de las sesiones de orientación para los nuevos empleados, asegurándote de que estén correctamente programadas y que los empleados reciban la información necesaria para tener éxito en su nuevo rol.\r\n\r\nRequisitos:\r\n\r\n- Experiencia previa en roles de atención al cliente, recursos humanos o integración de personal: Valoramos la experiencia previa en roles similares, especialmente aquella relacionada con la atención al cliente o la gestión de recursos humanos.\r\n\r\n- Habilidades de comunicación excepcionales y capacidad para establecer relaciones sólidas con los nuevos empleados: La capacidad para comunicarse de manera efectiva y establecer relaciones sólidas con los nuevos empleados es fundamental para tener éxito en este rol.\r\n\r\n- Capacidad para trabajar en un entorno dinámico y de ritmo rápido: Nuestro equipo de integración de empleados opera en un entorno dinámico y de ritmo rápido, por lo que es importante que los candidatos sean capaces de adaptarse rápidamente a los cambios y trabajar de manera eficiente bajo presión.\r\n\r\n- Excelentes habilidades organizativas y atención al detalle: La capacidad para mantenerse organizado y prestar atención a los detalles es esencial para asegurar que todas las tareas administrativas se completen con precisión y puntualidad.\r\n\r\nOfrecemos un ambiente de trabajo colaborativo, oportunidades de crecimiento profesional y un equipo dedicado a brindar experiencias excepcionales a nuestros empleados.\r\n\r\nSi estás buscando unirte a un equipo apasionado por el desarrollo y crecimiento profesional de nuestros empleados, ¡aplica ahora para esta emocionante oportunidad como Analista Senior Representante de Lanzamiento de Carrera!",
                    JobOfferModeId = 2,
                    PublicationDate = DateTime.Parse("10/05/2024"),
                    CityId = 022007,
                    StudyTypeId = 4
                });
     
	    }
 
	}
}
