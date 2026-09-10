using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class DemoRequestConfiguration : IEntityTypeConfiguration<DemoRequest>
{
    public void Configure(EntityTypeBuilder<DemoRequest> builder)
    {
        builder.ToTable("DemoRequests");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.FullName).IsRequired().HasMaxLength(200);
        builder.Property(x => x.WorkEmail).IsRequired().HasMaxLength(256);
        builder.Property(x => x.ClinicName).IsRequired().HasMaxLength(200);
        builder.Property(x => x.PreferredDateTime).HasMaxLength(100);

        builder.Property(x => x.Status).HasConversion<string>().HasMaxLength(20);

        builder.HasIndex(x => x.WorkEmail);
        builder.HasIndex(x => x.Status);
    }
}