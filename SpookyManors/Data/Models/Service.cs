using System.ComponentModel.DataAnnotations;

namespace SpookyManors.Data.Models
{
    public class Service
    {
        public int Id { get; init; }

        [Required]
        public string NameOfService { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
