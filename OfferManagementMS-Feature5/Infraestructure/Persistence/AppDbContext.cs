using Domain.Entities;
using Infraestructure.EntityConfig;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public DbSet<Domain.Entities.Aplication> Applications { get; set; }
        public DbSet<ApplicationStatusType> ApplicationStatusTypes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<JobOfferMode> JobOfferModes { get; set; }
        public DbSet<OfferCategory> OfferCategories { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<OfferSkill> OfferSkills { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<StudyType> StudyTypes { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=OfferManagement;Trusted_Connection=True; TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new SkillConfig());
            modelBuilder.ApplyConfiguration(new JobOfferModeConfig());
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new ApplicationStatusTypeConfig());
            modelBuilder.ApplyConfiguration(new ApplicationConfig());
            modelBuilder.ApplyConfiguration(new CountryConfig());
            modelBuilder.ApplyConfiguration(new ProvinceConfig());
            modelBuilder.ApplyConfiguration(new CityConfig());
            modelBuilder.ApplyConfiguration(new StudyTypeConfig());
            modelBuilder.ApplyConfiguration(new OfferConfig());
            modelBuilder.ApplyConfiguration(new OfferCategoryConfig());
            modelBuilder.ApplyConfiguration(new OfferSkillConfig());
        }
    }
}
