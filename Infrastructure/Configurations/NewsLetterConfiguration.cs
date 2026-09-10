namespace Infrastructure.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


public class NewsletterSubscriberConfiguration : IEntityTypeConfiguration<NewsletterSubscriber>
{
    public void Configure(EntityTypeBuilder<NewsletterSubscriber> builder)
    {
        builder.ToTable("NewsletterSubscribers");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Email).IsRequired().HasMaxLength(256);
        builder.Property(x => x.ConfirmationToken).HasMaxLength(100);

        builder.HasIndex(x => x.Email).IsUnique();
    }
}