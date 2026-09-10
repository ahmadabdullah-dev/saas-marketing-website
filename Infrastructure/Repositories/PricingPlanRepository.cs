using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class PricingPlanRepository : Repository<PricingPlan>, IPricingPlanRepository
{
    public PricingPlanRepository(AppDbContext db) : base(db) { }

    public async Task<List<PricingPlan>> GetPublishedAsync() =>
        await DbSet.Where(x => x.IsPublished)
            .Include(x => x.Features.OrderBy(f => f.SortOrder))
            .OrderBy(x => x.SortOrder)
            .ToListAsync();

    public async Task<PricingPlan?> GetBySlugAsync(string slug) =>
        await DbSet.Include(x => x.Features.OrderBy(f => f.SortOrder))
            .FirstOrDefaultAsync(x => x.Slug == slug);
}
