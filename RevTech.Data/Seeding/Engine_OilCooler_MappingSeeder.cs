using RevTech.Data.Models.PerformanceParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevTech.Data.Seeding
{
    public class Engine_OilCooler_MappingSeeder
    {
        public ICollection<Engine_OilCooler> GenerateData()
        {
            var collection = new HashSet<Engine_OilCooler>();

            Engine_OilCooler current;

            current = new Engine_OilCooler()
            {
                OilCoolerId = 1,
                EngineId = 1,
            };

            collection.Add(current);
            current = new Engine_OilCooler()
            {
                OilCoolerId = 1,
                EngineId = 2,
            };

            collection.Add(current);
            current = new Engine_OilCooler()
            {
                OilCoolerId = 1,
                EngineId = 3,
            };

            collection.Add(current);
            current = new Engine_OilCooler()
            {
                OilCoolerId = 2,
                EngineId = 4,
            };

            collection.Add(current);

            current = new Engine_OilCooler()
            {
                OilCoolerId = 2,
                EngineId = 5,
            };

            collection.Add(current);
            current = new Engine_OilCooler()
            {
                OilCoolerId = 3,
                EngineId = 6,
            };

            collection.Add(current);

            current = new Engine_OilCooler()
            {
                OilCoolerId = 3,
                EngineId = 7,
            };

            collection.Add(current);

            current = new Engine_OilCooler()
            {
                OilCoolerId = 3,
                EngineId = 8,
            };

            collection.Add(current);

            current = new Engine_OilCooler()
            {
                OilCoolerId = 4,
                EngineId = 9,
            };

            collection.Add(current);

            current = new Engine_OilCooler()
            {
                OilCoolerId = 4,
                EngineId = 10,
            };

            collection.Add(current);

            for (int i = 1; i <= 16; i++)
            {
                current = new Engine_OilCooler()
                {
                    OilCoolerId = 5,
                    EngineId = i,
                };
                collection.Add(current);
            }

            return collection;
        }
    }
}
