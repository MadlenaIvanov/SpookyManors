using System.ComponentModel.DataAnnotations;

namespace SpookyManors.Data.Models
{
    public class Property
    {
        public int Id { get; init; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Size { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public decimal Tax { get; set; }


    }
}
