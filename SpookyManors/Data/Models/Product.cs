using System.ComponentModel.DataAnnotations;

namespace SpookyManors.Data.Models
{
    public class Product
    {
        public int Id { get; init; }

        [Required]
        public string NameOfProduct { get; set; }

        [Required]
        public string Price { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }
    }
}
