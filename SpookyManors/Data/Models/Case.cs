using System.ComponentModel.DataAnnotations;

namespace SpookyManors.Data.Models
{
    public class Case
    {
        public int Id { get; init; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }


        public int CategoryId { get; set; }

        public Category Category { get; init; }

        public DateTime DateTime { get; set; }
    }
}
