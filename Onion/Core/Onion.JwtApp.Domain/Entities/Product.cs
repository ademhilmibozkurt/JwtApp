namespace Onion.JwtApp.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public Decimal Price { get; set; }
        public int CategoryId { get; set; }
        // nav. property
        public Category? Category { get; set; }
    }
}
