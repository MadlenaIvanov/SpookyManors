using System.ComponentModel.DataAnnotations;

namespace SpookyManors.Data.Models
{
    public class Schedule
    {
        public int Id { get; init; }

        [Required]
        public bool Availability { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}
