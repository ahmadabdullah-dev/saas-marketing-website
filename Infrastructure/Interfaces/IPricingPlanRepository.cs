namespace Infrastructure.Interfaces;

public interface IPricingPlanRepository : IRepository<PricingPlan>
{
    Task<List<PricingPlan>> GetPublishedAsync();
    Task<PricingPlan?> GetBySlugAsync(string slug);
}