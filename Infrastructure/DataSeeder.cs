using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;
public class DataSeeder
{
    private readonly UserManager<AppUser> _userManager;
    private readonly RoleManager<AppRole> _roleManager;

    public DataSeeder(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
    {
        _userManager = userManager;
        _roleManager = roleManager;
    }
    public async Task Seed()
    {
        await SeedRoles();
        await SeedUsers();
    }
    public async Task SeedRoles()
    {
        var dbRoles = await _roleManager.Roles.ToListAsync();

        var roles = new List<AppRole>()
        {
            new() {Name = "SuperAdmin"},
            new() {Name = "Admin"},
        };

        foreach(var role in roles)
        {
            if (!dbRoles.Contains(role))
            {
                await _roleManager.CreateAsync(role);
            }
        }
    }
    public async Task SeedUsers()
    {
        var users = new List<(AppUser user, string role)>()
        {
            (new() { FirstName = "SuperAdminFN",LastName = "SuperAdminLN"  ,UserName = "superadmin@test.com", Email= "superadmin@test.com", EmailConfirmed = true}, "SuperAdmin"),
            (new() { FirstName = "AdminFN", LastName = "AdminLN" ,UserName = "admin@test.com", Email= "admin@test.com", EmailConfirmed = true}, "Admin"),
        };
        
        foreach (var (user,role) in users)
        {
            var existingUser = await _userManager.FindByNameAsync(user.UserName!);
         
            if (existingUser == null)
            {
                var result = await _userManager.CreateAsync(user,"Pa$$w0rd");       
               
                if(result.Succeeded)
                    await _userManager.AddToRoleAsync(user, role);
            }
        }
    }
}
