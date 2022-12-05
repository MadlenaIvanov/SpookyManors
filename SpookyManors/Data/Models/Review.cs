using System.ComponentModel.DataAnnotations;
using static SpookyManors.Data.DataConstants;

namespace SpookyManors.Data.Models
{
    public class Review
    {
        //people can review their experiences
        //they can be logged in or not
        //if they are logged in - take their name
        //if not let them write their own name 
        //maybe upload a picture - not required

        public int Id { get; init; }

        [Required]
        [MaxLength(ReviewNameMaxLength)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(ReviewCommentMaxLength)]
        public string Comment { get; set; }

        public string ImageUrl { get; set; }

        public DateTime DateTime { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; init; }
    }
}
