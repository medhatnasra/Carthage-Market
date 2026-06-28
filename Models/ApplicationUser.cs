using Microsoft.AspNetCore.Identity;

namespace Carthage_Market.Models
{
    public class ApplicationUser : IdentityUser
    {
        
        public List<Order> Orders { get; set; } = new(); 
    }
}
