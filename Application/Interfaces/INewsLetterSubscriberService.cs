namespace Application.Interfaces;

public interface INewsLetterSubscriberService
{
    Task<Result<string>> SubscribeAsync(string email);
}
