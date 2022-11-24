using System.ComponentModel.DataAnnotations;
using static SpookyManors.Data.DataConstants;

namespace SpookyManors.Data.Models
{
    public class Review
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(ReviewNameMaxLength)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(ReviewCommentMaxLength)]
        public string Comment { get; set; }
    }
}
