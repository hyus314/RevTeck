using RevTech.Data.Models.PerformanceParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevTech.Data.Seeding
{
    public class Engine_FuelPump_MappingTableSeeder
    {
        public ICollection<Engine_FuelPump> GenerateData()
        {
            var collection = new HashSet<Engine_FuelPump>();

            Engine_FuelPump current;

            current = new Engine_FuelPump()
            {
                EngineId = 1,
                FuelPumpId = 1
            };

            collection.Add(current);

            current = new Engine_FuelPump()
            {
                EngineId = 2,
                FuelPumpId = 1
            };

            collection.Add(current);
            current = new Engine_FuelPump()
            {
                EngineId = 3,
                FuelPumpId = 1
            };

            collection.Add(current);
            current = new Engine_FuelPump()
            {
                EngineId = 4,
                FuelPumpId = 1
            };

            collection.Add(current);
            current = new Engine_FuelPump()
            {
                EngineId = 5,
                FuelPumpId = 1
            };

            collection.Add(current);
            current = new Engine_FuelPump()
            {
                EngineId = 11,
                FuelPumpId = 1
            };

            collection.Add(current);
            //asdasdasdasd
            current = new Engine_FuelPump()
            {
                EngineId = 6,
                FuelPumpId = 2
            };

            collection.Add(current);
            current = new Engine_FuelPump()
            {
                EngineId = 7,
                FuelPumpId = 2
            };

            collection.Add(current);
            current = new Engine_FuelPump()
            {
                EngineId = 9,
                FuelPumpId = 3
            };

            collection.Add(current);

            current = new Engine_FuelPump()
            {
                EngineId = 10,
                FuelPumpId = 3
            };

            collection.Add(current);

            current = new Engine_FuelPump()
            {
                EngineId = 11,
                FuelPumpId = 4
            };

            collection.Add(current);

            current = new Engine_FuelPump()
            {
                EngineId = 12,
                FuelPumpId = 4
            };

            collection.Add(current);


            current = new Engine_FuelPump()
            {
                EngineId = 13,
                FuelPumpId = 4
            };

            collection.Add(current);

            current = new Engine_FuelPump()
            {
                EngineId = 14,
                FuelPumpId = 5
            };

            collection.Add(current);

            current = new Engine_FuelPump()
            {
                EngineId = 15,
                FuelPumpId = 5
            };

            collection.Add(current);

            current = new Engine_FuelPump()
            {
                EngineId = 16,
                FuelPumpId = 5
            };

            collection.Add(current);

            return collection;
        }
    }
}
