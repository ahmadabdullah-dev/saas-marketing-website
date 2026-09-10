
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class TestimonialConfiguration : IEntityTypeConfiguration<Testimonial>
{
    public void Configure(EntityTypeBuilder<Testimonial> builder)
    {
        builder.ToTable("Testimonials");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.AuthorName).IsRequired().HasMaxLength(150);
        builder.Property(x => x.AuthorTitle).HasMaxLength(200);
        builder.Property(x => x.Quote).IsRequired().HasMaxLength(1000);
        builder.Property(x => x.AvatarUrl).HasMaxLength(500);

        builder.HasIndex(x => new { x.IsPublished, x.SortOrder });
    }
}