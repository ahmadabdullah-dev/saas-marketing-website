using Microsoft.EntityFrameworkCore;

namespace Infrastructure;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<ContactSubmission> ContactSubmissions => Set<ContactSubmission>();
    public DbSet<DemoRequest> DemoRequests => Set<DemoRequest>();
    public DbSet<NewsletterSubscriber> NewsletterSubscribers => Set<NewsletterSubscriber>();
    public DbSet<PricingPlan> PricingPlans => Set<PricingPlan>();
    public DbSet<PricingFeature> PricingFeatures => Set<PricingFeature>();
    public DbSet<Testimonial> Testimonials => Set<Testimonial>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}