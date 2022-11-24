using System.ComponentModel.DataAnnotations;
using static SpookyManors.Data.DataConstants;

namespace SpookyManors.Data.Models
{
    public class Category
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(CategoryNameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(CategoryDescriptionMaxLength)]
        public string Description { get; set; }

        public IEnumerable<House> Houses { get; set; }

    }
}
