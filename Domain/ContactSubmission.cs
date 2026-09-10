namespace Domain;
public class ContactSubmission
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string FullName { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string? Phone { get; set; }
    public string? ClinicName { get; set; }
    public string? Message { get; set; }
    public ContactSubmissionType Type { get; set; } = ContactSubmissionType.GeneralInquiry;
    public ContactSubmissionStatus Status { get; set; } = ContactSubmissionStatus.New;
    public string? SourcePage { get; set; }
    public string? UtmSource { get; set; }
    public string? UtmMedium { get; set; }
    public string? UtmCampaign { get; set; }
    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
}

public enum ContactSubmissionType
{
    GeneralInquiry,
    SalesQuestion,
    Support
}

public enum ContactSubmissionStatus
{
    New,
    Contacted,
    Qualified,
    Closed
}