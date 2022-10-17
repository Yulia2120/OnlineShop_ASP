using BLogic.Domain;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options)
           : base(options){}
        public DbSet<Company> Companies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<AnimalCategory> AnimalCategories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
    }
}
