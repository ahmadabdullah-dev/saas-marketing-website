using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class TestimonialRepository : Repository<Testimonial>, ITestimonialRepository
{
    public TestimonialRepository(AppDbContext db) : base(db) { }

    public async Task<List<Testimonial>> GetPublishedAsync() =>
        await DbSet.Where(x => x.IsPublished)
            .OrderBy(x => x.SortOrder)
            .ToListAsync();
}