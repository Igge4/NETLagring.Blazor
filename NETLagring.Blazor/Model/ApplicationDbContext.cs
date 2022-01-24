using Microsoft.EntityFrameworkCore;

namespace NETLagring.Blazor.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public virtual DbSet<Customer> Customers { get; set; }  
        public virtual DbSet<CustomersService> CustomersServices { get; set; }  
        
        
        
    }
}
