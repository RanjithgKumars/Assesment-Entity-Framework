using System.ComponentModel.DataAnnotations;

namespace Core_Web_API.Models
{
    public class UsersInfo
    {
        [Key]
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

}

