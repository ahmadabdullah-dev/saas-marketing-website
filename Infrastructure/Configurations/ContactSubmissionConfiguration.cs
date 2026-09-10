using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class ContactSubmissionConfiguration : IEntityTypeConfiguration<ContactSubmission>
{
    public void Configure(EntityTypeBuilder<ContactSubmission> builder)
    {
        builder.ToTable("ContactSubmissions");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.FullName).IsRequired().HasMaxLength(200);
        builder.Property(x => x.Email).IsRequired().HasMaxLength(256);
        builder.Property(x => x.Phone).HasMaxLength(30);
        builder.Property(x => x.ClinicName).HasMaxLength(200);
        builder.Property(x => x.Message).HasMaxLength(2000);

        builder.Property(x => x.Type).HasConversion<string>().HasMaxLength(20);
        builder.Property(x => x.Status).HasConversion<string>().HasMaxLength(20);

        builder.Property(x => x.SourcePage).HasMaxLength(300);
        builder.Property(x => x.UtmSource).HasMaxLength(100);
        builder.Property(x => x.UtmMedium).HasMaxLength(100);
        builder.Property(x => x.UtmCampaign).HasMaxLength(100);

        builder.HasIndex(x => x.Email);
        builder.HasIndex(x => x.CreatedAtUtc);
    }
}