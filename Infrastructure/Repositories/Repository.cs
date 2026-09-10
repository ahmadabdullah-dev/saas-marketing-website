using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    protected readonly AppDbContext Db;
    protected readonly DbSet<T> DbSet;

    public Repository(AppDbContext db)
    {
        Db = db;
        DbSet = db.Set<T>();
    }

    public async Task<T?> GetByIdAsync(Guid id) => await DbSet.FindAsync(id);

    public async Task<List<T>> GetAllAsync() => await DbSet.ToListAsync();

    public async Task AddAsync(T entity) => await DbSet.AddAsync(entity);

    public void Update(T entity) => DbSet.Update(entity);

    public void Remove(T entity) => DbSet.Remove(entity);

    public Task<int> SaveChangesAsync() => Db.SaveChangesAsync();
}

