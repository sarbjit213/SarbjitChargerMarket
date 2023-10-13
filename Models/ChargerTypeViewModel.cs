using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace SarbjitChargerMarket.Models
{
    public class ChargerTypeViewModel
    {
        public List<Charger> Chargers { get; set; }
        public SelectList Types { get; set; }
        public string ChargerType { get; set; }
        public string SearchString { get; set; }
    }
}