using Microsoft.AspNetCore.Identity;

namespace ZadanieNr._8.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string RefreshToken { get; set; }
    }
}