namespace JwtApp.Back.Core.Domain
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int AppRoleId { get; set; }
        // navigation property
        public AppRole? AppRole { get; set; }
    }
}
