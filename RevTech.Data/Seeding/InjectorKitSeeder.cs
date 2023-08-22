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

            /*INJECTOR KIT ID 1*/
            /********************************************/

            current = new InjectorKit()
            {
                Id = 1,
                Manufacturer = "Bosch",
                Model = "550 cc Fuel Injectors - Set Of Four",
                HorsePowerBoost = 8,
                TorqueBoost = 16,
                ImageURL = "https://c1552172.ssl.cf0.rackcdn.com/87249_x450.webp",
                Price = 291.25m,
                EngineId = 1
            };

            collection.Add(current);

            current = new InjectorKit()
            {
                Id = 2,
                Manufacturer = "Bosch",
                Model = "550 cc Fuel Injectors - Set Of Four",
                HorsePowerBoost = 8,
                TorqueBoost = 16,
                ImageURL = "https://c1552172.ssl.cf0.rackcdn.com/87249_x450.webp",
                Price = 291.25m,
                EngineId = 2
            };

            collection.Add(current);

            current = new InjectorKit()
            {
                Id = 3,
                Manufacturer = "Bosch",
                Model = "550 cc Fuel Injectors - Set Of Four",
                HorsePowerBoost = 8,
                TorqueBoost = 16,
                ImageURL = "https://c1552172.ssl.cf0.rackcdn.com/87249_x450.webp",
                Price = 291.25m,
                EngineId = 3
            };

            collection.Add(current);


            /*INJECTOR KIT ID 2*/
            /********************************************/


            current = new InjectorKit()
            {
                Id = 4,
                Manufacturer = "Siemens",
                Model = "630 cc Fuel Injectors - Set Of Four",
                HorsePowerBoost = 9,
                TorqueBoost = 18,
                ImageURL = "https://c1552172.ssl.cf0.rackcdn.com/75141_x450.webp",
                Price = 312.80m,
                EngineId = 1
            };

            collection.Add(current);

            current = new InjectorKit()
            {
                Id = 5,
                Manufacturer = "Siemens",
                Model = "630 cc Fuel Injectors - Set Of Four",
                HorsePowerBoost = 9,
                TorqueBoost = 18,
                ImageURL = "https://c1552172.ssl.cf0.rackcdn.com/75141_x450.webp",
                Price = 312.80m,
                EngineId = 2
            };

            collection.Add(current);

            current = new InjectorKit()
            {
                Id = 6,
                Manufacturer = "Siemens",
                Model = "630 cc Fuel Injectors - Set Of Four",
                HorsePowerBoost = 9,
                TorqueBoost = 18,
                ImageURL = "https://c1552172.ssl.cf0.rackcdn.com/75141_x450.webp",
                Price = 312.80m,
                EngineId = 3
            };

            collection.Add(current);



            /*INJECTOR KIT ID 3*/
            /********************************************/


            current = new InjectorKit()
            {
                Id = 7,
                Manufacturer = "Bosch",
                Model = "750 cc Fuel Injectors - Set Of Four",
                HorsePowerBoost = 10,
                TorqueBoost = 20,
                ImageURL = "https://c1552172.ssl.cf0.rackcdn.com/1581767_x450.webp",
                Price = 411.72m,
                EngineId = 1
            };

            collection.Add(current);

            current = new InjectorKit()
            {
                Id = 8,
                Manufacturer = "Bosch",
                Model = "750 cc Fuel Injectors - Set Of Four",
                HorsePowerBoost = 10,
                TorqueBoost = 20,
                ImageURL = "https://c1552172.ssl.cf0.rackcdn.com/1581767_x450.webp",
                Price = 411.72m,
                EngineId = 2
            };

            collection.Add(current);

            current = new InjectorKit()
            {
                Id = 9,
                Manufacturer = "Bosch",
                Model = "750 cc Fuel Injectors - Set Of Four",
                HorsePowerBoost = 10,
                TorqueBoost = 20,
                ImageURL = "https://c1552172.ssl.cf0.rackcdn.com/1581767_x450.webp",
                Price = 411.72m,
                EngineId = 3
            };

            collection.Add(current);

            /*INJECTOR KIT ID 4*/
            /********************************************/


            current = new InjectorKit()
            {
                Id = 10,
                Manufacturer = "Bosch",
                Model = "750 cc Fuel Injectors - Set Of Six",
                HorsePowerBoost = 10,
                TorqueBoost = 20,
                ImageURL = "https://c1552172.ssl.cf0.rackcdn.com/1581767_x450.webp",
                Price = 617.58m,
                EngineId = 4
            };

            collection.Add(current);

            current = new InjectorKit()
            {
                Id = 11,
                Manufacturer = "Bosch",
                Model = "750 cc Fuel Injectors - Set Of Six",
                HorsePowerBoost = 10,
                TorqueBoost = 20,
                ImageURL = "https://c1552172.ssl.cf0.rackcdn.com/1581767_x450.webp",
                Price = 617.58m,
                EngineId = 5
            };

            collection.Add(current);


            /*INJECTOR KIT ID 5*/
            /********************************************/


            current = new InjectorKit()
            {
                Id = 12,
                Manufacturer = "Bosch",
                Model = "1000 cc Fuel Injectors - Set Of Six",
                HorsePowerBoost = 12,
                TorqueBoost = 22,
                ImageURL = "https://cdn.shopify.com/s/files/1/0109/5814/3547/products/32_710e4d04-15b1-40cf-8c72-48dc955e88d5_695x695.jpg?v=1670590394",
                Price = 650.12m,
                EngineId = 4
            };

            collection.Add(current);

            current = new InjectorKit()
            {
                Id = 13,
                Manufacturer = "Bosch",
                Model = "1000 cc Fuel Injectors - Set Of Six",
                HorsePowerBoost = 12,
                TorqueBoost = 22,
                ImageURL = "https://cdn.shopify.com/s/files/1/0109/5814/3547/products/32_710e4d04-15b1-40cf-8c72-48dc955e88d5_695x695.jpg?v=1670590394",
                Price = 650.12m,
                EngineId = 5
            };

            collection.Add(current);


            /*INJECTOR KIT ID 6*/
            /********************************************/


            current = new InjectorKit()
            {
                Id = 14,
                Manufacturer = "OEM",
                Model = "Tuning Fuel Injectors - Set Of Eight",
                HorsePowerBoost = 15,
                TorqueBoost = 30,
                ImageURL = "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg",
                Price = 1525.21m,
                EngineId = 6
            };

            collection.Add(current);

            current = new InjectorKit()
            {
                Id = 15,
                Manufacturer = "OEM",
                Model = "Tuning Fuel Injectors - Set Of Eight",
                HorsePowerBoost = 15,
                TorqueBoost = 30,
                ImageURL = "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg",
                Price = 1525.21m,
                EngineId = 7
            };

            collection.Add(current);

            collection.Add(current);

            current = new InjectorKit()
            {
                Id = 16,
                Manufacturer = "OEM",
                Model = "Tuning Fuel Injectors - Set Of Eight",
                HorsePowerBoost = 15,
                TorqueBoost = 30,
                ImageURL = "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg",
                Price = 1525.21m,
                EngineId = 8
            };

            collection.Add(current);

            current = new InjectorKit()
            {
                Id = 17,
                Manufacturer = "OEM",
                Model = "Tuning Fuel Injectors - Set Of Eight",
                HorsePowerBoost = 15,
                TorqueBoost = 30,
                ImageURL = "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg",
                Price = 1525.21m,
                EngineId = 11
            };

            collection.Add(current);

            current = new InjectorKit()
            {
                Id = 18,
                Manufacturer = "OEM",
                Model = "Tuning Fuel Injectors - Set Of Eight",
                HorsePowerBoost = 15,
                TorqueBoost = 30,
                ImageURL = "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg",
                Price = 1525.21m,
                EngineId = 12
            };

            collection.Add(current);

            current = new InjectorKit()
            {
                Id = 19,
                Manufacturer = "OEM",
                Model = "Tuning Fuel Injectors - Set Of Eight",
                HorsePowerBoost = 15,
                TorqueBoost = 30,
                ImageURL = "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg",
                Price = 1525.21m,
                EngineId = 13
            };

            collection.Add(current);


            /*INJECTOR KIT ID 7*/
            /********************************************/


            current = new InjectorKit()
            {
                Id = 20,
                Manufacturer = "OEM",
                Model = "Tuning Fuel Injectors - Set Of Four",
                HorsePowerBoost = 7,
                TorqueBoost = 15,
                ImageURL = "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg",
                Price = 762.61m,
                EngineId = 9
            };

            collection.Add(current);

            current = new InjectorKit()
            {
                Id = 21,
                Manufacturer = "OEM",
                Model = "Tuning Fuel Injectors - Set Of Four",
                HorsePowerBoost = 7,
                TorqueBoost = 15,
                ImageURL = "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg",
                Price = 762.61m,
                EngineId = 10
            };

            collection.Add(current);

            /*INJECTOR KIT ID 8*/
            /********************************************/

            current = new InjectorKit()
            {
                Id = 22,
                Manufacturer = "OEM",
                Model = "Tuning Fuel Injectors - Set Of Six",
                HorsePowerBoost = 9,
                TorqueBoost = 22,
                ImageURL = "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg",
                Price = 1143.92m,
                EngineId = 14
            };

            collection.Add(current);

            current = new InjectorKit()
            {
                Id = 23,
                Manufacturer = "OEM",
                Model = "Tuning Fuel Injectors - Set Of Six",
                HorsePowerBoost = 9,
                TorqueBoost = 22,
                ImageURL = "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg",
                Price = 1143.92m,
                EngineId = 15
            };

            collection.Add(current);

            current = new InjectorKit()
            {
                Id = 24,
                Manufacturer = "OEM",
                Model = "Tuning Fuel Injectors - Set Of Six",
                HorsePowerBoost = 9,
                TorqueBoost = 22,
                ImageURL = "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg",
                Price = 1143.92m,
                EngineId = 16
            };

            collection.Add(current);

            return collection;
        }
    }
}
