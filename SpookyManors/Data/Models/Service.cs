using System.ComponentModel.DataAnnotations;

namespace SpookyManors.Data.Models
{
    public class Service
    {
        //this needs to be what kinda seriveses 
        //are being offered ex.
        //tour day/night
        //gift shop
        //guide/no guide
        public int Id { get; init; }

        [Required]
        public string NameOfService { get; set; }

        [Required]
        public string Description { get; set; }

        public int Price { get; set; }

        [Required]
        public string Guide { get; set; }

        [Required]
        public string Hours { get; set; }
    }
}
