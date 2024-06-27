using Domain.Entities;
using Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfig
{
    public class OfferConfig : IEntityTypeConfiguration<Offer>
    {
        public void Configure(EntityTypeBuilder<Offer> builder)
        {
            builder.ToTable("Offer");
            builder.HasKey(i => i.OfferId);
            builder.Property(i => i.OfferId);
            builder.Property(c => c.CompanyId)
                   .IsRequired();
            builder.Property(t => t.Title)
                   .IsRequired();
            builder.Property(d => d.Description)
                   .IsRequired();
            builder.Property(m => m.MinSalary);
            builder.Property(m => m.MaxSalary);
            builder.Property(d => d.JobOfferModeId).IsRequired();
            builder.Property(d => d.PublicationDate)
                   .IsRequired()
                   .HasDefaultValue(DateTime.Now);
            builder.Property(d => d.CityId)
                   .IsRequired();
            builder.Property(d => d.AvailabilityToTravel)
                   .IsRequired();
            builder.Property(d => d.AvailabilityChangeOfResidence)
                   .IsRequired();
            builder.Property(d => d.StudyTypeId)
                   .IsRequired();
            builder.Property(d => d.Status)
                   .IsRequired();

            builder.HasOne<StudyType>(j => j.StudyType)
                   .WithMany(o => o.Offers)
                   .HasForeignKey(fk => fk.StudyTypeId);

            builder.HasOne<JobOfferMode>(j => j.JobOfferMode)
                   .WithMany(o => o.Offers)
                   .HasForeignKey(fk => fk.JobOfferModeId);

            builder.HasOne<City>(j => j.City)
                   .WithMany(o => o.Offers)
                   .HasForeignKey(fk => fk.CityId);   

            builder.HasMany<Aplication>(j => j.Applications)
                   .WithOne(c => c.Offer)
                   .HasForeignKey(fk => fk.OfferId);

            builder.HasMany<OfferCategory>(j => j.OfferCategories)
                   .WithOne(o => o.Offer)
                   .HasForeignKey(fk => fk.OfferId);

            builder.HasMany<OfferSkill>(o => o.OfferSkills)
                   .WithOne(o => o.Offer)
                   .HasForeignKey(fk => fk.OfferId);

            OfferData.SeedData(builder);
        }
    }
}
