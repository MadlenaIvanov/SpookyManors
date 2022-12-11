using System.ComponentModel.DataAnnotations;

namespace SpookyManors.Data.Models
{
    public class History
    {
        public int Id { get; init; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string About { get; set; }

        [Required]
        public string ImageUrl { get; set; }
    }
}
