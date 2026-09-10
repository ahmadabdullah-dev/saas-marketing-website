namespace Domain;
public class PricingPlan
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = default!;
    public string Slug { get; set; } = default!;
    public decimal MonthlyPrice { get; set; }
    public decimal? AnnualPrice { get; set; }
    public string Currency { get; set; } = "USD";
    public int? MaxPractitioners { get; set; }
    public bool IsFeatured { get; set; } = false;
    public bool IsPublished { get; set; } = true;
    public int SortOrder { get; set; }

    public ICollection<PricingFeature> Features { get; set; } = new List<PricingFeature>();
}

public class PricingFeature
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid PricingPlanId { get; set; }
    public PricingPlan PricingPlan { get; set; } = default!;
    public string Description { get; set; } = default!;
    public bool Included { get; set; } = true;
    public int SortOrder { get; set; }
}