using Domain.Entities;
using Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfig
{
    public class SkillConfig : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder.ToTable("Skill");
            builder.HasKey(i => i.SkillId);
            builder.Property(n => n.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.HasMany<OfferSkill>(o => o.OfferSkills)
                   .WithOne(o => o.Skill)
                   .HasForeignKey(fk => fk.SkillId);

            SkillData.SeedData(builder);
        }
    }
}
