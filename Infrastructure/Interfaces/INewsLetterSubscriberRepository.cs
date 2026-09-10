namespace Infrastructure.Interfaces;

public interface INewsLetterSubscriberRepository : IRepository<NewsLetterSubscriber>
{
    Task<NewsLetterSubscriber?> GetByEmailAsync(string email);
    Task<bool> IsSubscribedAsync(string email);
}