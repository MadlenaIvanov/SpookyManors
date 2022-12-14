using System.ComponentModel.DataAnnotations;

namespace SpookyManors.Data.Models
{
    public class Condition
    {
        public int Id { get; init; }

        [Required]
        public string Description { get; set; }

        public bool IsGood { get; init; }


    }
}
