namespace Domain;
public class NewsletterSubscriber
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Email { get; set; } = default!;
    public bool IsConfirmed { get; set; } = false;
    public string? ConfirmationToken { get; set; }
    public DateTime SubscribedAtUtc { get; set; } = DateTime.UtcNow;
    public DateTime? UnsubscribedAtUtc { get; set; }
}