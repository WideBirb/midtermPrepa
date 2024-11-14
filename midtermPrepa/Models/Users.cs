using Microsoft.AspNetCore.Identity;

namespace midtermPrepa.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }
    }
}
 