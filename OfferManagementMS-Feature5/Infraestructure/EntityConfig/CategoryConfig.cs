using Domain.Entities;
using Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfig
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
            builder.HasKey(i => i.CategoryId);
            builder.Property(i => i.CategoryId);
            builder.Property(n => n.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.HasMany<OfferCategory>(o => o.OfferCategories)
                   .WithOne(c => c.Category)
                   .HasForeignKey(c => c.CategoryId);

            CategoryData.SeedData(builder);
        }
    }
}
