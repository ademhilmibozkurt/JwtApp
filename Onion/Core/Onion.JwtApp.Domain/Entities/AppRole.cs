namespace Onion.JwtApp.Domain.Entities
{
    public class AppRole
    {
        public int Id { get; set; }
        public string Definition { get; set; }
        // navigation property
        public List<AppUser>? AppUsers { get; set; }
    }
}
