
namespace RevTech.Data.Seeding
{
    using RevTech.Data.Models.PerformanceParts;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;

    public class SuperchargerKitSeeder
    {
        public ICollection<SuperchargerKit> GenerateSuperchargers()
        {
            ICollection<SuperchargerKit> collection = new HashSet<SuperchargerKit>();

            SuperchargerKit current;

            current = new SuperchargerKit()
            {
                Id = 1,
                ModelName = "TVS1740 Stage 3+",
                Manufacturer = "APR",
                HorsePowerBoost = 200,
                TorqueBoost = 210,
                EngineId = 6,
                ImageURL = "/img/superchargerKitId1.jpg",
                Price = 18000.99m
            };

            collection.Add(current);

            current = new SuperchargerKit()
            {
                Id = 2,
                ModelName = "95 RON",
                Manufacturer = "APR",
                HorsePowerBoost = 180,
                TorqueBoost = 140,
                EngineId = 7,
                ImageURL = "/img/superchargerKitId2.jpg",
                Price = 17000.99m
            };

            collection.Add(current);

            current = new SuperchargerKit()
            {
                Id = 3,
                ModelName = "Whipple 140AX",
                Manufacturer = "PES",
                HorsePowerBoost = 180,
                TorqueBoost = 140,
                EngineId = 8,
                ImageURL = "https://fr-rtuning-shop.co.uk/images/cache/pes_supercharger.270.jpg",
                Price = 15000.99m
            };

            collection.Add(current);

            current = new SuperchargerKit()
            {
                Id = 4,
                ModelName = "Ported",
                Manufacturer = "CNC",
                HorsePowerBoost = 120,
                TorqueBoost = 100,
                EngineId = 13,
                ImageURL = "https://fr-rtuning-shop.co.uk/images/cache/pes_supercharger.270.jpg",
                Price = 2099.70m
            };

            collection.Add(current);

            current = new SuperchargerKit()
            {
                Id = 5,
                ModelName = "Ported",
                Manufacturer = "CNC",
                HorsePowerBoost = 120,
                TorqueBoost = 100,
                EngineId = 14,
                ImageURL = "https://fr-rtuning-shop.co.uk/images/cache/pes_supercharger.270.jpg",
                Price = 2099.70m
            };

            collection.Add(current);


            current = new SuperchargerKit()
            {
                Id = 6,
                ModelName = "Ported",
                Manufacturer = "CNC",
                HorsePowerBoost = 120,
                TorqueBoost = 100,
                EngineId = 15,
                ImageURL = "https://fr-rtuning-shop.co.uk/images/cache/pes_supercharger.270.jpg",
                Price = 2099.70m
            };

            collection.Add(current);

            return collection;
        }
    }
}

