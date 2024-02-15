using Microsoft.EntityFrameworkCore;

namespace DateMe.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base (options)  //Constructor
        {
        }

        public DbSet<App> Applications { get; set; }

    }
}
