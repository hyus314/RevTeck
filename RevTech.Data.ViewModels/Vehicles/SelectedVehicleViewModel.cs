using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevTech.Data.ViewModels.Vehicles
{
    public class SelectedVehicleViewModel
    {
        public int Id { get; set; }
        public string ModelName { get; set; } = null!;
        public int YearCreated_Start { get; set; }
        public int YearCreated_End { get; set; }
        public string ManufacturerName { get; set; } = null!;
        public string ImageURL { get; set; } = null!;
        public EngineViewModel Engine { get; set; } = null!;
    }
}
