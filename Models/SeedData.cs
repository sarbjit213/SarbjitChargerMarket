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
                        Name = "When Harry Met Sally",
                        Type = "When Harry Met Sally",
                        Color = "When Harry Met Sally",
                        ManufacturingDate = DateTime.Parse("1989-2-12"),
                        Rating = 4.6M,
                        Price = 7.99M
                    },

                    new Charger
                    {
                        Name = "When Harry Met Sally",
                        Type = "When Harry Met Sally",
                        Color = "When Harry Met Sally",
                        ManufacturingDate = DateTime.Parse("1989-2-12"),
                        Rating = 4.6M,
                        Price = 7.99M
                    },

                    new Charger
                    {
                        Name = "When Harry Met Sally",
                        Type = "When Harry Met Sally",
                        Color = "When Harry Met Sally",
                        ManufacturingDate = DateTime.Parse("1989-2-12"),
                        Rating = 4.6M,
                        Price = 7.99M
                    },

                    new Charger
                    {
                        Name = "When Harry Met Sally",
                        Type = "When Harry Met Sally",
                        Color = "When Harry Met Sally",
                        ManufacturingDate = DateTime.Parse("1989-2-12"),
                        Rating = 4.6M,
                        Price = 7.99M
                    },

                    new Charger
                    {
                        Name = "When Harry Met Sally",
                        Type = "When Harry Met Sally",
                        Color = "When Harry Met Sally",
                        ManufacturingDate = DateTime.Parse("1989-2-12"),
                        Rating = 4.6M,
                        Price = 7.99M
                    },

                    new Charger
                    {
                        Name = "When Harry Met Sally",
                        Type = "When Harry Met Sally",
                        Color = "When Harry Met Sally",
                        ManufacturingDate = DateTime.Parse("1989-2-12"),
                        Rating = 4.6M,
                        Price = 7.99M
                    },

                    new Charger
                    {
                        Name = "When Harry Met Sally",
                        Type = "When Harry Met Sally",
                        Color = "When Harry Met Sally",
                        ManufacturingDate = DateTime.Parse("1989-2-12"),
                        Rating = 4.6M,
                        Price = 7.99M
                    },

                    new Charger
                    {
                        Name = "When Harry Met Sally",
                        Type = "When Harry Met Sally",
                        Color = "When Harry Met Sally",
                        ManufacturingDate = DateTime.Parse("1989-2-12"),
                        Rating = 4.6M,
                        Price = 7.99M
                    },

                    new Charger
                    {
                        Name = "When Harry Met Sally",
                        Type = "When Harry Met Sally",
                        Color = "When Harry Met Sally",
                        ManufacturingDate = DateTime.Parse("1989-2-12"),
                        Rating = 4.6M,
                        Price = 7.99M
                    },

                    new Charger
                    {
                        Name = "When Harry Met Sally",
                        Type = "When Harry Met Sally",
                        Color = "When Harry Met Sally",
                        ManufacturingDate = DateTime.Parse("1989-2-12"),
                        Rating = 4.6M,
                        Price = 7.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}