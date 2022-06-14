using Microsoft.EntityFrameworkCore;

namespace LondonStock.Models
{
    public class StocksContext : DbContext
    {
        public StocksContext(DbContextOptions<StocksContext> options)
              : base(options)
        {
        }

        public DbSet<Stocks> Stocks { get; set; } = null!;
    }
}
