using Microsoft.EntityFrameworkCore;

namespace Mission06_Jergensen.Models
{
    public class MovieApplicationContext : DbContext
    {
        public MovieApplicationContext(DbContextOptions<MovieApplicationContext> options) : base (options) //Constructor
        {
        }

        public DbSet<Application> Applications { get; set; }
    }
}
