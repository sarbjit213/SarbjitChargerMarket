using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SarbjitChargerMarket.Data;
using System;
using System.Linq;

namespace SarbjitChargerMarket.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SarbjitChargerMarketContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SarbjitChargerMarketContext>>()))
            {
                // Look for any movies.
                if (context.Charger.Any())
                {
                    return;   // DB has been seeded
                }

                context.Charger.AddRange(
                    new Charger
                    {
                        Name = "FastPlug Wall Charger",
                        Type = "USB-A",
                        Color = "Black",
                        ManufacturingDate = DateTime.Parse("2022-10-10"),
                        Rating = 4.6M,
                        Price = 16.87M
                    },

                    new Charger
                    {
                        Name = "PowerBoost Car Charger",
                        Type = "USB-A",
                        Color = "Gray",
                        ManufacturingDate = DateTime.Parse("2022-09-20"),
                        Rating = 4.5M,
                        Price = 27.99M
                    },

                    new Charger
                    {
                        Name = "QuickCharge Slim Charger",
                        Type = "Wireless",
                        Color = "White",
                        ManufacturingDate = DateTime.Parse("2023-03-10"),
                        Rating = 4.8M,
                        Price = 32.46M
                    },

                    new Charger
                    {
                        Name = "PowerFlex Foldable Charger",
                        Type = "Travel Charger",
                        Color = "Black",
                        ManufacturingDate = DateTime.Parse("2021-02-12"),
                        Rating = 3.8M,
                        Price = 47.79M
                    },

                    new Charger
                    {
                        Name = "PowerWave Wireless Charger",
                        Type = "Wireless Charger",
                        Color = "Midnight Blue",
                        ManufacturingDate = DateTime.Parse("2023-06-22"),
                        Rating = 4.7M,
                        Price = 30.66M
                    },

                    new Charger
                    {
                        Name = "SuperCharge Dual USB Charger",
                        Type = "Wall Charger",
                        Color = "White",
                        ManufacturingDate = DateTime.Parse("2022-10-05"),
                        Rating = 4.6M,
                        Price = 22.54M
                    },

                    new Charger
                    {
                        Name = "TurboPlug Wall Charger",
                        Type = "USB-C",
                        Color = "Silver",
                        ManufacturingDate = DateTime.Parse("2022-04-12"),
                        Rating = 4.4M,
                        Price = 20.76M
                    },

                    new Charger
                    {
                        Name = "SuperJuice Portable Charger",
                        Type = "USB-C",
                        Color = "Red",
                        ManufacturingDate = DateTime.Parse("2023-01-05"),
                        Rating = 3.8M,
                        Price = 26.09M
                    },

                    new Charger
                    {
                        Name = "PowerMax Rapid Charger",
                        Type = "USB-A",
                        Color = "Black",
                        ManufacturingDate = DateTime.Parse("2021-05-02"),
                        Rating = 4.2M,
                        Price = 16.00M
                    },

                    new Charger
                    {
                        Name = "TurboCharge Pro Charger",
                        Type = "USB-C",
                        Color = "Silver",
                        ManufacturingDate = DateTime.Parse("2021-11-15"),
                        Rating = 4.6M,
                        Price = 28.77M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}