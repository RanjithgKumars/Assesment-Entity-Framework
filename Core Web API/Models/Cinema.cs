using System.ComponentModel.DataAnnotations;

namespace Core_Web_API.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public string MovieName { get; set; }
        public string Descriptions { get; set; }
        public string Movie_Type { get; set; }
        public string Languages { get; set; }
    }
}
