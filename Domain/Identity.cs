using Microsoft.AspNetCore.Identity;

namespace Domain;
public class AppUser : IdentityUser<Guid>
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public DateTime CreatedAt { get; set; }
}
public class AppRole : IdentityRole<Guid>
{
    public string? Description { get; set; }
}