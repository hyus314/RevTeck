using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevTech.Data.ViewModels.Admin.Vehicle
{
    public class AllCarModelViewModel
    {
        public int Id { get; set; }
        public int ManufacturerId { get; set; }
        public string ModelName { get; set; } = null!;
        public int YearCreated_Start { get; set; }
        public int YearCreated_End { get; set; }
        public string ImageURL { get; set; } = null!;
    }
}
