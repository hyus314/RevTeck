using RevTech.Data.Models.PerformanceParts;

namespace RevTech.Data.Seeding
{
    public class ECUTuningSeeder
    {
        public ICollection<ECUTuning> GenerateECUTunings()
        {
            ICollection<ECUTuning> collection = new HashSet<ECUTuning>();
            ECUTuning current;

            current = new ECUTuning()
            {
                Id = 1,
                Manufacturer = "Quantum Tuning",
                HorsePowerBoost = 45,
                TorqueBoost = 100,
                Name = "ECU Upgrade for 1.8t",
                EngineId = 1,
                ImageURL = "https://motoristprod.s3.amazonaws.com/uploads/redactor_rails/picture/data/3244/motorist-ecu-tuning-june-2020.png",
                Price = 150.0m
            };

            collection.Add(current);

            current = new ECUTuning()
            {
                Id = 2,
                Manufacturer = "Quantum Tuning",
                HorsePowerBoost = 45,
                TorqueBoost = 100,
                Name = "ECU Upgrade for 1.8t",
                EngineId = 2,
                ImageURL = "https://motoristprod.s3.amazonaws.com/uploads/redactor_rails/picture/data/3244/motorist-ecu-tuning-june-2020.png",
                Price = 150.0m
            };

            collection.Add(current);

            current = new ECUTuning()
            {
                Id = 3,
                Manufacturer = "Quantum Tuning",
                HorsePowerBoost = 45,
                TorqueBoost = 100,
                Name = "ECU Upgrade for 1.8t",
                EngineId = 3,
                ImageURL = "https://motoristprod.s3.amazonaws.com/uploads/redactor_rails/picture/data/3244/motorist-ecu-tuning-june-2020.png",
                Price = 150.0m
            };

            collection.Add(current);

            current = new ECUTuning()
            {
                Id = 4,
                Manufacturer = "034Motorsport",
                HorsePowerBoost = 65,
                TorqueBoost = 90,
                Name = "ECU Upgrade for 2.7t",
                EngineId = 4,
                ImageURL = "https://www.034motorsport.com/media/fishpig/webp/catalog/product/cache/1151afdc91a7a37549ca32dea82af8c6/b/5/b5_s4_stage1.webp",
                Price = 495.0m
            };

            collection.Add(current);

            current = new ECUTuning()
            {
                Id = 5,
                Manufacturer = "034Motorsport",
                HorsePowerBoost = 65,
                TorqueBoost = 90,
                Name = "ECU Upgrade for 2.7t",
                EngineId = 5,
                ImageURL = "https://www.034motorsport.com/media/fishpig/webp/catalog/product/cache/1151afdc91a7a37549ca32dea82af8c6/b/5/b5_s4_stage1.webp",
                Price = 495.0m
            };

            collection.Add(current);

            current = new ECUTuning()
            {
                Id = 6,
                Manufacturer = "APR",
                HorsePowerBoost = 10,
                TorqueBoost = 50,
                Name = "ECU Upgrade for 4.2 FSI",
                EngineId = 6,
                ImageURL = "https://images.goapr.com/583x/apr_ecu.png",
                Price = 499.95m
            };

            collection.Add(current);

            current = new ECUTuning()
            {
                Id = 7,
                Manufacturer = "APR",
                HorsePowerBoost = 10,
                TorqueBoost = 50,
                Name = "ECU Upgrade for 4.2 FSI",
                EngineId = 7,
                ImageURL = "https://images.goapr.com/583x/apr_ecu.png",
                Price = 499.95m
            };

            collection.Add(current);

            current = new ECUTuning()
            {
                Id = 8,
                Manufacturer = "APR",
                HorsePowerBoost = 10,
                TorqueBoost = 50,
                Name = "ECU Upgrade for 4.2 FSI",
                EngineId = 8,
                ImageURL = "https://images.goapr.com/583x/apr_ecu.png",
                Price = 499.95m
            };

            collection.Add(current);

            current = new ECUTuning()
            {
                Id = 9,
                Manufacturer = "APR",
                HorsePowerBoost = 55,
                TorqueBoost = 70,
                Name = "ECU Upgrade for 2.0 TFSI",
                EngineId = 9,
                ImageURL = "https://images.goapr.com/583x/apr_ecu.png",
                Price = 399.95m
            };

            collection.Add(current);

            current = new ECUTuning()
            {
                Id = 10,
                Manufacturer = "APR",
                HorsePowerBoost = 55,
                TorqueBoost = 70,
                Name = "ECU Upgrade for 2.0 TFSI",
                EngineId = 10,
                ImageURL = "https://images.goapr.com/583x/apr_ecu.png",
                Price = 399.95m
            };

            collection.Add(current);


            current = new ECUTuning()
            {
                Id = 11,
                Manufacturer = "APR",
                HorsePowerBoost = 130,
                TorqueBoost = 180,
                Name = "ECU Upgrade for 4.0 TFSI",
                EngineId = 11,
                ImageURL = "https://clptuning.co.uk/wp-content/uploads/2016/11/APR-Stage-1-300x300.jpg",
                Price = 1200.00m
            };

            collection.Add(current);

            current = new ECUTuning()
            {
                Id = 12,
                Manufacturer = "APR",
                HorsePowerBoost = 80,
                TorqueBoost = 130,
                Name = "ECU Upgrade for 4.0 TFSI",
                EngineId = 12,
                ImageURL = "https://images.goapr.com/583x/apr_ecu.png",
                Price = 800.00m
            };

            collection.Add(current);

            current = new ECUTuning()
            {
                Id = 13,
                Manufacturer = "APR",
                HorsePowerBoost = 80,
                TorqueBoost = 130,
                Name = "ECU Upgrade for 4.0 TFSI",
                EngineId = 13,
                ImageURL = "https://images.goapr.com/583x/apr_ecu.png",
                Price = 800.00m
            };

            collection.Add(current);

            current = new ECUTuning()
            {
                Id = 14,
                Manufacturer = "APR",
                HorsePowerBoost = 120,
                TorqueBoost = 70,
                Name = "ECU Upgrade for 3.0 TFSI",
                EngineId = 14,
                ImageURL = "http://www.goapr.co.uk/includes/img/icons/apr-ecu.png",
                Price = 900.00m
            };

            collection.Add(current);

            current = new ECUTuning()
            {
                Id = 15,
                Manufacturer = "APR",
                HorsePowerBoost = 120,
                TorqueBoost = 70,
                Name = "ECU Upgrade for 3.0 TFSI",
                EngineId = 15,
                ImageURL = "http://www.goapr.co.uk/includes/img/icons/apr-ecu.png",
                Price = 900.00m
            };

            collection.Add(current);

            current = new ECUTuning()
            {
                Id = 16,
                Manufacturer = "APR",
                HorsePowerBoost = 120,
                TorqueBoost = 70,
                Name = "ECU Upgrade for 3.0 TFSI",
                EngineId = 16,
                ImageURL = "http://www.goapr.co.uk/includes/img/icons/apr-ecu.png",
                Price = 900.00m
            };

            collection.Add(current);

            return collection;
        }
    }
}
