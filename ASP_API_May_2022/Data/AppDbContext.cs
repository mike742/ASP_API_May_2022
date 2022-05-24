using ASP_API_May_2022.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP_API_May_2022.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> op) : base(op) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProducts> OrderProducts { get; set; }
    }
}
