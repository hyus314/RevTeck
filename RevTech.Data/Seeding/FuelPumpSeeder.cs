using RevTech.Data.Models.PerformanceParts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace RevTech.Data.Seeding
{
    public class FuelPumpSeeder
    {
        public ICollection<FuelPump> GenerateFuelPumps()
        {
            ICollection<FuelPump> collection = new HashSet<FuelPump>();

            FuelPump current;

            current = new FuelPump()
            {
                Id = 1,
                Manufacturer = "Bosch",
                Model = "High Flow Fuel Pump",
                HorsePowerBoost = 50,
                TorqueBoost = 70,
                Price = 589.13m,
                ImageURL = "https://strperformance.com/42122-large_default/high-flow-fuel-pump-assembly-bosch-044-034motorsport-for-audi-a4-s4-b5-s2-rs2-a6-c5-s6-c7-18t-22-27-40-fsi.jpg"
            };

            collection.Add(current);

            current = new FuelPump()
            {
                Id = 2,
                Manufacturer = "APR",
                Model = "High Pressure Fuel Pump For 4.2 FSI",
                HorsePowerBoost = 70,
                TorqueBoost = 90,
                Price = 3172.55m,
                ImageURL = "https://cdn11.bigcommerce.com/s-6y7pa5d/images/stencil/1280x1280/products/24113/25401/stage_3__b7rs4_hpfps_1_1__82083.1542907995.jpg?c=2"
            };

            collection.Add(current);

            current = new FuelPump()
            {
                Id = 3,
                Manufacturer = "APR",
                Model = "High Pressure Fuel Pump For 2.0 TFSI",
                HorsePowerBoost = 35,
                TorqueBoost = 45,
                Price = 1713.18m,
                ImageURL = "https://clptuning.co.uk/wp-content/uploads/2016/11/fsi_pump__11368.1449608918.1280.1280-300x300.jpg"
            };

            collection.Add(current);

            current = new FuelPump()
            {
                Id = 4,
                Manufacturer = "Nostrum High Performance",
                Model = "High Pressure Fuel Pump Kit For 4.0 TFSI",
                HorsePowerBoost = 145,
                TorqueBoost = 180,
                Price = 2450.00m,
                ImageURL = "https://cdn11.bigcommerce.com/s-a4fc6cbe36/images/stencil/1280x1280/products/209/1324/4.0L_Audi_TT_High_Pressure_Fuel_Pump_Kit__06817.1671545289.jpg?c=1"
            };

            collection.Add(current);

            current = new FuelPump()
            {
                Id = 5,
                Manufacturer = "APR",
                Model = "High Pressure Fuel Pump For 3.0 TFSI",
                HorsePowerBoost = 50,
                TorqueBoost = 90,
                Price = 1199.95m,
                ImageURL = "https://images.goapr.com/583x/ms100207_001.jpg"
            };

            collection.Add(current);

            return collection;
        }
    }
}
//[Key]
//public int Id { get; set; }
//[Required]
//[MaxLength(ManufacturerMaxLength)]
//public string Manufacturer { get; set; } = null!;
//[Required]
//[MaxLength(ModelMaxLength)]
//public string Model { get; set; } = null!;
//[Required]
//public int HorsePowerBoost { get; set; }
//[Required]
//public int TorqueBoost { get; set; }
//[Required]
//public decimal Price { get; set; }
//[Required]
//[MaxLength(MaxImageUrlLength)]
//public string ImageURL { get; set; } = null!;