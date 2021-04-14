using Microsoft.EntityFrameworkCore;

namespace webAppToAzure
{
    public class myDbContext : DbContext
    {
        public myDbContext(DbContextOptions<myDbContext> options) : base(options) { }
        public DbSet<City> Cities { get; set; }
    }
}
