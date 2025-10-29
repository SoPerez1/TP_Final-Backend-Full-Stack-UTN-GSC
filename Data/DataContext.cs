using Microsoft.EntityFrameworkCore;
using TP_Final.Modelo;

namespace TP_Final.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Products> Products { get; set; }
    }
}
