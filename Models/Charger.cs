using System;
using System.ComponentModel.DataAnnotations;

namespace SarbjitChargerMarket.Models
{
    public class Charger
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }

        [DataType(DataType.Date)]
        public DateTime ManufacturingDate { get; set; }
        public decimal Rating { get; set; }
        public decimal Price { get; set; }
    }
}