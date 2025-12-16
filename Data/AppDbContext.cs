using Microsoft.EntityFrameworkCore;
using azureapp_swar.Models;

namespace azureapp_swar.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
    }
}
