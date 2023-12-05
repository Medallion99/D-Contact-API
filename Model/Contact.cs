using System.ComponentModel.DataAnnotations.Schema;

namespace BookAPI.Model
{
    public class Contact
    {
        public string Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string UserId { get; set; }
        [NotMapped]
        public User? User { get; set; }
    }
}
