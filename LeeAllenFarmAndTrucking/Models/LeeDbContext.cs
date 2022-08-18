using Microsoft.EntityFrameworkCore;

namespace LeeAllenFarmAndTrucking.Models
{
    public class LeeDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public LeeDbContext(DbContextOptions
            <LeeDbContext> options) : base(options)
        {

        }
    }
}
