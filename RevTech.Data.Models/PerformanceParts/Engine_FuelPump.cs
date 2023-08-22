//using RevTech.Data.Models.Vehicles;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace RevTech.Data.Models.PerformanceParts
//{
//    public class Engine_FuelPump
//    {
//        [ForeignKey(nameof(Engine))]
//        public int EngineId { get; set; }
//        public virtual Engine Engine { get; set; } = null!;
//        [ForeignKey(nameof(FuelPump))]
//        public int FuelPumpId { get; set; }
//        public virtual FuelPump FuelPump { get; set; } = null!;
//    }
//}
