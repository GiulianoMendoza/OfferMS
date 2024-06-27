using Domain.Entities;
using Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfig
{
    public class OfferCategoryConfig : IEntityTypeConfiguration<OfferCategory>
    {
        public void Configure(EntityTypeBuilder<OfferCategory> builder)
        {
            builder.ToTable("OfferCategory");
            builder.HasKey(i => i.OfferCategoryId);
            builder.Property(i => i.OfferCategoryId)
                   .ValueGeneratedOnAdd();
            builder.Property(c => c.CategoryId).IsRequired();
            builder.Property(o => o.OfferId).IsRequired();
            
            builder.HasOne<Offer>(j => j.Offer)
               .WithMany(c => c.OfferCategories)
               .HasForeignKey(c => c.OfferId);
            
            builder.HasOne<Category>(j => j.Category)
               .WithMany(c => c.OfferCategories)
               .HasForeignKey(c => c.CategoryId);

            OfferCategoryData.SeedData(builder);
        }
    }
}
