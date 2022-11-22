namespace SpookyManors.Data.Models
{
    public class Category
    {
        public int Id { get; init; }

        public string Name { get; set; }

        public string Description { get; set; }

        public IEnumerable<House> Houses { get; set; }

    }
}
