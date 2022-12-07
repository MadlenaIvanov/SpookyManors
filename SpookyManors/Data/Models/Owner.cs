using System.ComponentModel.DataAnnotations;

namespace SpookyManors.Data.Models
{
    public class Owner
    {
        public int Id { get; init; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string Experience { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
