namespace Onion.JwtApp.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Definition { get; set; }
        // nav. property
        public List<Product>? Products { get; set; }
    }
}
