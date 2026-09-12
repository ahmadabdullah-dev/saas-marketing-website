namespace Application.Services;

public class NewsLetterSubscriberService : INewsLetterSubscriberService
{
    private readonly IEmailService _emailService;
    private readonly INewsLetterSubscriberRepository _newsletterSubscriberRepository;
    public NewsLetterSubscriberService(IEmailService emailService,
        INewsLetterSubscriberRepository newsletterSubscriberRepository)
    {
        _emailService = emailService;
        _newsletterSubscriberRepository = newsletterSubscriberRepository;
    }

    public Task<Result<string>> SubscribeAsync(string email)
    {
        throw new NotImplementedException();
    }
}
