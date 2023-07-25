using RevTech.Data.Models.PerformanceParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevTech.Data.Seeding
{
    public class Engine_SparkPlugKit_MappingSeeder
    {
        public ICollection<Engine_SparkPlugKit> GenerateData()
        {
            var collection = new HashSet<Engine_SparkPlugKit>();

            Engine_SparkPlugKit current;

            current = new Engine_SparkPlugKit()
            {
                SparkPlugKitId = 1,
                EngineId = 1
            };

            collection.Add(current);

            current = new Engine_SparkPlugKit()
            {
                SparkPlugKitId = 1,
                EngineId = 2
            };

            collection.Add(current);

            current = new Engine_SparkPlugKit()
            {
                SparkPlugKitId = 1,
                EngineId = 3
            };

            collection.Add(current);

            current = new Engine_SparkPlugKit()
            {
                SparkPlugKitId = 2,
                EngineId = 4
            };

            collection.Add(current);

            current = new Engine_SparkPlugKit()
            {
                SparkPlugKitId = 2,
                EngineId = 5
            };

            collection.Add(current);

            current = new Engine_SparkPlugKit()
            {
                SparkPlugKitId = 3,
                EngineId = 6
            };

            collection.Add(current);
            current = new Engine_SparkPlugKit()
            {
                SparkPlugKitId = 3,
                EngineId = 7
            };

            collection.Add(current);

            current = new Engine_SparkPlugKit()
            {
                SparkPlugKitId = 3,
                EngineId = 8
            };

            collection.Add(current);

            current = new Engine_SparkPlugKit()
            {
                SparkPlugKitId = 4,
                EngineId = 9
            };

            collection.Add(current);

            current = new Engine_SparkPlugKit()
            {
                SparkPlugKitId = 4,
                EngineId = 10
            };

            collection.Add(current);

            current = new Engine_SparkPlugKit()
            {
                SparkPlugKitId = 5,
                EngineId = 11
            };

            collection.Add(current);

            current = new Engine_SparkPlugKit()
            {
                SparkPlugKitId = 5,
                EngineId = 12
            };

            collection.Add(current);

            current = new Engine_SparkPlugKit()
            {
                SparkPlugKitId = 5,
                EngineId = 13
            };

            collection.Add(current);

            current = new Engine_SparkPlugKit()
            {
                SparkPlugKitId = 6,
                EngineId = 14
            };

            collection.Add(current);

            current = new Engine_SparkPlugKit()
            {
                SparkPlugKitId = 6,
                EngineId = 15
            };

            collection.Add(current);

            current = new Engine_SparkPlugKit()
            {
                SparkPlugKitId = 6,
                EngineId = 16
            };

            collection.Add(current);

            return collection; 
        }
    }
}
