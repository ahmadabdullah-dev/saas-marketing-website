namespace Infrastructure.Interfaces;

public interface IDemoRequestRepository : IRepository<DemoRequest>
{
    Task<List<DemoRequest>> GetByStatusAsync(DemoRequestStatus status);
    Task UpdateStatusAsync(Guid id, DemoRequestStatus status);
}