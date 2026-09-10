using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class ContactSubmissionRepository : Repository<ContactSubmission>, IContactSubmissionRepository
{
    public ContactSubmissionRepository(AppDbContext db) : base(db) { }

    public async Task<List<ContactSubmission>> GetByStatusAsync(ContactSubmissionStatus status) =>
        await DbSet.Where(x => x.Status == status)
            .OrderByDescending(x => x.CreatedAtUtc)
            .ToListAsync();

    public async Task<List<ContactSubmission>> GetByEmailAsync(string email) =>
        await DbSet.Where(x => x.Email == email)
            .OrderByDescending(x => x.CreatedAtUtc)
            .ToListAsync();
} 