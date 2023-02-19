using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Models
{
    public class EcommerceDbContext:DbContext
    {
        public  EcommerceDbContext(DbContextOptions<EcommerceDbContext> options):base(options)
        {

        }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderMaster> orderMasters { get; set; }
        public DbSet<OrderDetails> orderDetails { get; set; }

        
    }
}
