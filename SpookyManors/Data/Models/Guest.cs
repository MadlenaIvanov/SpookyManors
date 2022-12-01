namespace SpookyManors.Data.Models
{
    public class Guest
    {
        public int Id { get; init; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string Gender { get; set; }
    }
}
