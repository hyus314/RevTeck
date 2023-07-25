using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevTech.Data.ViewModels.Parts
{
    public class SparkPlugsViewModel
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; } = null!;
        public decimal Price  { get; set; }
        public string ImageURl { get; set; } = null!;
    }
}
