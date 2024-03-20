using JwtApp.Back.Core.Domain;
using JwtApp.Back.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;

namespace JwtApp.Back.Persistence.Context
{
    public class JwtContext : DbContext
    {
        public DbSet<Product> Products => this.Set<Product>();
        public DbSet<AppUser> AppUsers => this.Set<AppUser>();
        public DbSet<AppRole> AppRoles => this.Set<AppRole>();
        public DbSet<Category> Categories => this.Set<Category>();

        public JwtContext(DbContextOptions<JwtContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
