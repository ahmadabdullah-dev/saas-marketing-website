namespace Infrastructure.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class PricingPlanConfiguration : IEntityTypeConfiguration<PricingPlan>
{
    public void Configure(EntityTypeBuilder<PricingPlan> builder)
    {
        builder.ToTable("PricingPlans");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Slug).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Currency).IsRequired().HasMaxLength(3);
        builder.Property(x => x.MonthlyPrice).HasColumnType("decimal(10,2)");
        builder.Property(x => x.AnnualPrice).HasColumnType("decimal(10,2)");

        builder.HasIndex(x => x.Slug).IsUnique();

        builder.HasMany(x => x.Features)
            .WithOne(x => x.PricingPlan)
            .HasForeignKey(x => x.PricingPlanId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}

public class PricingFeatureConfiguration : IEntityTypeConfiguration<PricingFeature>
{
    public void Configure(EntityTypeBuilder<PricingFeature> builder)
    {
        builder.ToTable("PricingFeatures");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Description).IsRequired().HasMaxLength(300);

        builder.HasIndex(x => new { x.PricingPlanId, x.SortOrder });
    }
}