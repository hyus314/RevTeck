

namespace RevTech.Data.Seeding
{
    using RevTech.Data.Models.Vehicles;
    public class EngineSeeder
    {
        public ICollection<Engine> GenerateEngines()
        {
            ICollection<Engine> engines = new HashSet<Engine>();

            Engine current;

            current = new Engine()
            {
                Id = 1,
                Name = "1.8t",
                HorsePower = 150,
                Torque = 210
            };

            engines.Add(current);

            current = new Engine()
            {
                Id = 2,
                Name = "1.8t",
                HorsePower = 163,
                Torque = 250,
            };

            engines.Add(current);

            current = new Engine()
            {
                Id = 3,
                Name = "1.8t",
                HorsePower = 180,
                Torque = 235
            };

            engines.Add(current);
            current = new Engine()
            {
                Id = 4,
                Name = "2.7tt",
                HorsePower = 265,
                Torque = 362
            };

            engines.Add(current);

            current = new Engine()
            {
                Id = 5,
                Name = "2.7tt",
                HorsePower = 250,
                Torque = 342
            };

            engines.Add(current);

            current = new Engine()
            {
                Id = 6,
                Name = "4.2 FSI",
                HorsePower = 450,
                Torque = 430
            };

            engines.Add(current);

            current = new Engine()
            {
                Id = 7,
                Name = "4.2 FSI",
                HorsePower = 354,
                Torque = 440
            };
           

            engines.Add(current);

            current = new Engine()
            {
                Id = 8,
                Name = "4.2 FSI",
                HorsePower = 350,
                Torque = 440
            };

            engines.Add(current);

            current = new Engine()
            {
                Id = 9,
                Name = "2.0 TFSI",
                HorsePower = 200,
                Torque = 280
            };

            engines.Add(current);
            current = new Engine()
            {
                Id = 10,
                Name = "2.0 TFSI",
                HorsePower = 211,
                Torque = 350
            };

            engines.Add(current);

            current = new Engine()
            {
                Id = 11,
                Name = "4.0 TFSI",
                HorsePower = 420,
                Torque = 600
            };

            engines.Add(current);

            current = new Engine()
            {
                Id = 12,
                Name = "4.0 TFSI",
                HorsePower = 560,
                Torque = 700
            };

            engines.Add(current);

            current = new Engine()
            {
                Id = 13,
                Name = "4.0 TFSI",
                HorsePower = 605,
                Torque = 700
            };

            engines.Add(current);

            current = new Engine()
            {
                Id = 14,
                Name = "3.0 TFSI",
                HorsePower = 333,
                Torque = 440
            };

            engines.Add(current);

            current = new Engine()
            {
                Id = 15,
                Name = "3.0 TFSI",
                HorsePower = 290,
                Torque = 420
            };

            engines.Add(current);

            current = new Engine()
            {
                Id = 16,
                Name = "3.0 TFSI",
                HorsePower = 310,
                Torque = 440
            };

            engines.Add(current);

            return engines;
        }
    }
}
