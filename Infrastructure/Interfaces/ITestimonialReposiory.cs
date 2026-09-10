namespace Infrastructure.Interfaces;

public interface ITestimonialRepository : IRepository<Testimonial>
{
    Task<List<Testimonial>> GetPublishedAsync();
}