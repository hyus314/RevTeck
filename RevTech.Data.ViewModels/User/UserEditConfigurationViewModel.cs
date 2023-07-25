using RevTech.Data.ViewModels.Parts;
using RevTech.Data.ViewModels.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevTech.Data.ViewModels.User
{ 
    public class UserEditConfigurationViewModel
    {
        public int Id { get; set; }
        public CarModelViewModel CarModel { get; set; } = null!;
        public EngineViewModel Engine { get; set; } = null!;
        public int? TurboKitId { get; set; }
        public int? ECUTuningId { get; set; }
        public int? ExhaustKitId { get; set; }
        public int? FuelPumpId { get; set; }
        public int? InjectorKitId { get; set; }
        public int? OilCoolerId { get; set; }
        public int? SparkPlugsId { get; set; }
        public int? SuperchargerKitId { get; set; }
        public int? TCUTuningId { get; set; }
        public decimal TotalPrice { get; set; }
        public int HorsePowerBoostTotal { get; set; }
        public int TorqueBoostTotal { get; set; }

    }
}
