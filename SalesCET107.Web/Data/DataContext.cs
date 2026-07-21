using Microsoft.EntityFrameworkCore;
using SalesCET107.Web.Data.Entities;

namespace SalesCET107.Web.Data
{
    public class DataContext : DbContext
    {
       
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Product> Products { get; set; }

        
    }
}
