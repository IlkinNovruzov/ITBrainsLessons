using Microsoft.EntityFrameworkCore;

namespace Grocery.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=DESKTOP-VCSVAMO\\SQLEXPRESS;database=GroceryDB;integrated security=true;TrustServerCertificate=true;");
        }
        public DbSet<Product> Products { get; set; }
    }
}
