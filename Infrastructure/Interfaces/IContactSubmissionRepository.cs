namespace Infrastructure.Interfaces;

public interface IContactSubmissionRepository : IRepository<ContactSubmission>
{
    Task<List<ContactSubmission>> GetByStatusAsync(ContactSubmissionStatus status);
    Task<List<ContactSubmission>> GetByEmailAsync(string email);
}
