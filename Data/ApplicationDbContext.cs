using Microsoft.EntityFrameworkCore;

namespace Music_Library_Frontend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Models.Song> Songs { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        {

        }
    }
}
