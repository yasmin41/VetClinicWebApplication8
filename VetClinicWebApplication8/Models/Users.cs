using Microsoft.AspNetCore.Identity;

namespace VetClinicWebApplication8.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }
    }
}
