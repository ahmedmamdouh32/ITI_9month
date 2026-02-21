using Microsoft.AspNetCore.Identity;

namespace Day1.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string myProperty { set; get; }
    }
}
