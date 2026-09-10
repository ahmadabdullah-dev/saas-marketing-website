namespace Domain;
public class Testimonial
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string AuthorName { get; set; } = default!;
    public string? AuthorTitle { get; set; }
    public string Quote { get; set; } = default!;
    public string? AvatarUrl { get; set; }
    public bool IsPublished { get; set; } = true;
    public int SortOrder { get; set; }
}