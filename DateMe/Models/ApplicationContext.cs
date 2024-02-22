using Microsoft.EntityFrameworkCore;
using Mission06_Overly.Models;

namespace DateMe.Models
{
    public class ApplicationContext : DbContext  // Liaison from the app to the database
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base (options)  //Constructor
        {
        }

        public DbSet<App> Movies { get; set; }
        public DbSet<Categories> Categories { get; set; }

    }
}
