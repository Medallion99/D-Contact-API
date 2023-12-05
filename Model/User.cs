using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookAPI.Model
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        
    }
}
