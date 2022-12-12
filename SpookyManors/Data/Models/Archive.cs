using System.ComponentModel.DataAnnotations;
using static SpookyManors.Data.DataConstants;

namespace SpookyManors.Data.Models
{
    public class Archive
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(ArchiveHouseTitleMaxLength)]
        public string Title { get; set; }

        [Required]
        [MaxLength(ArchiveHouseAddressMaxLength)]
        public string Address { get; set; }

        [Required]
        [MaxLength(ArchiveHouseDescriptionMaxLength)]
        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public DateTime DateTime { get; set; }

        public string Comment { get; set; }

    }
}
