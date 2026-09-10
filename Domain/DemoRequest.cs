namespace Domain;
public class DemoRequest
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string FullName { get; set; } = default!;
    public string WorkEmail { get; set; } = default!;
    public string ClinicName { get; set; } = default!;
    public int? ClinicSize { get; set; }
    public string? PreferredDateTime { get; set; }
    public DemoRequestStatus Status { get; set; } = DemoRequestStatus.Pending;
    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
}

public enum DemoRequestStatus
{
    Pending,
    Scheduled,
    Completed,
    NoShow,
    Cancelled
}