using Microsoft.EntityFrameworkCore;
using WebApplication5.Model;

namespace WebApplication5.Data
{
    public class DataContext : DbContext
    {
        public DbSet<CelestialObject> CelestialObjects { get; set;  }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CA3;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}
