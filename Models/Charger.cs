using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SarbjitChargerMarket.Models
{
    public class Charger
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)] //validation 
        [Required]
        public string Name { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Type { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Color { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Manufacturing Date")]
        public DateTime ManufacturingDate { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        [StringLength(5)]
        [Required]
        public decimal Rating { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}