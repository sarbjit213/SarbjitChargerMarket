using Microsoft.EntityFrameworkCore;
using SarbjitChargerMarket.Models;

namespace SarbjitChargerMarket.Data
{
    public class SarbjitChargerMarketContext : DbContext
    {
        public SarbjitChargerMarketContext(DbContextOptions<SarbjitChargerMarketContext> options)
            : base(options)
        {
        }

        public DbSet<Charger> Charger { get; set; }
    }
}