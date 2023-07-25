using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevTech.Data.ViewModels.Parts
{
    public class OilCoolerViewModel
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; } = null!;
        public string Model { get; set; } = null!;
        public decimal Price  { get; set; }
        public string ImageURL { get; set; } = null!;
    }
}
