using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class DemoRequestRepository : Repository<DemoRequest>, IDemoRequestRepository
{
    public DemoRequestRepository(AppDbContext db) : base(db) { }

    public async Task<List<DemoRequest>> GetByStatusAsync(DemoRequestStatus status) =>
        await DbSet.Where(x => x.Status == status)
            .OrderByDescending(x => x.CreatedAtUtc)
            .ToListAsync();

    public async Task UpdateStatusAsync(Guid id, DemoRequestStatus status)
    {
        var entity = await DbSet.FindAsync(id)
            ?? throw new KeyNotFoundException($"DemoRequest {id} not found");
        entity.Status = status;
        await SaveChangesAsync();
    }
}
