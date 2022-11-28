using System.ComponentModel.DataAnnotations;
using static SpookyManors.Data.DataConstants;

namespace SpookyManors.Data.Models
{
    public class House
    {
        public int Id { get; init; } 

        [Required]
        [MaxLength(HouseTitleMaxLength)]
        public string Title { get; set; }

        [Required]
        [MaxLength(HouseAddressMaxLength)]
        public string Address { get; set; }

        [Required]
        [MaxLength(HouseDescriptionMaxLength)]
        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }


        public int CategoryId { get; set; }

        public Category Category { get; init; }


        public DateTime DateTime { get; set; }





    }
}
