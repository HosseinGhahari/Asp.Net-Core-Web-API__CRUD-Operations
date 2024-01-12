using Microsoft.EntityFrameworkCore;
using Web_Api___Repository_Pattern.Model;

namespace Web_Api___Repository_Pattern.Context
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options) {}
        public DbSet<Customer> Customers { get; set; }

    }
}
