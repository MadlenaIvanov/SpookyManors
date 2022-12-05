using System.ComponentModel.DataAnnotations;

namespace SpookyManors.Data.Models
{
    public class Guide
    {
        //this would be for the guide workers

        public int Id { get; init; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string Gender { get; set; }

        //this would be years + guide title
        [Required]
        public string Experience { get; set; }

        [Required]
        public string Description { get; set; }

        //add houses they work in

        public IEnumerable<Guest> Guests { get; set; }

    }
}
