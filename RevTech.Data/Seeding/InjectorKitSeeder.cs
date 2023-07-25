using RevTech.Data.Models.PerformanceParts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevTech.Data.Seeding
{
    public class InjectorKitSeeder
    {
        public ICollection<InjectorKit> GenerateInjectorKits()
        {
            var collection = new HashSet<InjectorKit>();

            InjectorKit current;

            current = new InjectorKit()
            {
                Id = 1,
                Manufacturer = "Bosch",
                Model = "550 cc Fuel Injectors - Set Of Four",
                HorsePowerBoost = 8,
                TorqueBoost = 16,
                ImageURL = "https://c1552172.ssl.cf0.rackcdn.com/87249_x450.webp",
                Price = 291.25m
            };

            collection.Add(current);

            current = new InjectorKit()
            {
                Id = 2,
                Manufacturer = "Siemens",
                Model = "630 cc Fuel Injectors - Set Of Four",
                HorsePowerBoost = 9,
                TorqueBoost = 18,
                ImageURL = "https://c1552172.ssl.cf0.rackcdn.com/75141_x450.webp",
                Price = 312.80m
            };

            collection.Add(current);

            current = new InjectorKit()
            {
                Id = 3,
                Manufacturer = "Bosch",
                Model = "750 cc Fuel Injectors - Set Of Four",
                HorsePowerBoost = 10,
                TorqueBoost = 20,
                ImageURL = "https://c1552172.ssl.cf0.rackcdn.com/1581767_x450.webp",
                Price = 411.72m
            };

            collection.Add(current);

            current = new InjectorKit()
            {
                Id = 4,
                Manufacturer = "Bosch",
                Model = "750 cc Fuel Injectors - Set Of Six",
                HorsePowerBoost = 10,
                TorqueBoost = 20,
                ImageURL = "https://c1552172.ssl.cf0.rackcdn.com/1581767_x450.webp",
                Price = 617.58m
            };

            collection.Add(current);

            current = new InjectorKit()
            {
                Id = 5,
                Manufacturer = "Bosch",
                Model = "1000 cc Fuel Injectors - Set Of Six",
                HorsePowerBoost = 12,
                TorqueBoost = 22,
                ImageURL = "https://cdn.shopify.com/s/files/1/0109/5814/3547/products/32_710e4d04-15b1-40cf-8c72-48dc955e88d5_695x695.jpg?v=1670590394",
                Price = 650.12m
            };

            collection.Add(current);

            current = new InjectorKit()
            {
                Id = 6,
                Manufacturer = "OEM",
                Model = "Tuning Fuel Injectors - Set Of Eight",
                HorsePowerBoost = 15,
                TorqueBoost = 30,
                ImageURL = "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg",
                Price = 1525.21m
            };

            collection.Add(current);

            current = new InjectorKit()
            {
                Id = 7,
                Manufacturer = "OEM",
                Model = "Tuning Fuel Injectors - Set Of Four",
                HorsePowerBoost = 7,
                TorqueBoost = 15,
                ImageURL = "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg",
                Price = 762.61m
            };

            collection.Add(current);

            current = new InjectorKit()
            {
                Id = 8,
                Manufacturer = "OEM",
                Model = "Tuning Fuel Injectors - Set Of Six",
                HorsePowerBoost = 9,
                TorqueBoost = 22,
                ImageURL = "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg",
                Price = 1143.92m
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
//[MaxLength(MaxImageUrlLength)]
//public string ImageURL { get; set; } = null!;
//public decimal Price { get; set; }
//public ICollection<Engine_InjectorKit> Engine_InjectorKits { get; set; } = new HashSet<Engine_InjectorKit>();