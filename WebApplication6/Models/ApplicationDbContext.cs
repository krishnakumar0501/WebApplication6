using Microsoft.EntityFrameworkCore;
namespace WebApplication6.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext
            (DbContextOptions<ApplicationDbContext>options):
            base(options)
        { }
        public DbSet<Location> Location { get; set; }  
        public DbSet<Customer> Customer { get; set; }

    }
}
