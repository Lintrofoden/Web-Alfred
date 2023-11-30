using Microsoft.EntityFrameworkCore;

namespace Web_develop.Models
{
    public class AppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public AppContext(DbContextOptions<AppContext> options)
            : base(options)
        {
            Database.EnsureCreated(); 
        }
    }
}