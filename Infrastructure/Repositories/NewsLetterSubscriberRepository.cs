using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class NewsletterSubscriberRepository : Repository<NewsLetterSubscriber>, INewsLetterSubscriberRepository
{
    public NewsletterSubscriberRepository(AppDbContext db) : base(db) { }

    public async Task<NewsLetterSubscriber?> GetByEmailAsync(string email) =>
        await DbSet.FirstOrDefaultAsync(x => x.Email == email);

    public async Task<bool> IsSubscribedAsync(string email) =>
        await DbSet.AnyAsync(x => x.Email == email && x.UnsubscribedAtUtc == null);
}
