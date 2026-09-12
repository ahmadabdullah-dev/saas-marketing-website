namespace Application.Services;

public class PricingService : IPricingService
{
    private readonly IPricingPlanRepository _pricingPlanRepository;
    public PricingService(IPricingPlanRepository pricingPlanRepository)
    {
        _pricingPlanRepository = pricingPlanRepository;   
    }
}
