using RevTech.Data.Models.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevTech.Data.Seeding
{
    public class CarModelEngineSeeder
    {
        public ICollection<CarModelEngine> GenerateEntities()
        {
            ICollection<CarModelEngine> collection = new HashSet<CarModelEngine>();

            CarModelEngine entity;

            entity = new CarModelEngine()
            {
                EngineId = 1,
                CarModelId = 1,
            };

            collection.Add(entity);

            entity = new CarModelEngine()
            {
                EngineId = 1,
                CarModelId = 2,
            };

            collection.Add(entity);
            entity = new CarModelEngine()
            {
                EngineId = 1,
                CarModelId = 3,
            };

            collection.Add(entity);

            entity = new CarModelEngine()
            {
                EngineId = 2,
                CarModelId = 3,
            };

            collection.Add(entity);

            entity = new CarModelEngine()
            {
                EngineId = 3,
                CarModelId = 1,
            };

            collection.Add(entity);

            entity = new CarModelEngine()
            {
                EngineId = 3,
                CarModelId = 2,
            };

            collection.Add(entity);

            entity = new CarModelEngine()
            {
                EngineId = 4,
                CarModelId = 4,
            };

            collection.Add(entity);

            entity = new CarModelEngine()
            {
                EngineId = 4,
                CarModelId = 1,
            };

            collection.Add(entity);

            entity = new CarModelEngine()
            {
                EngineId = 5,
                CarModelId = 1,
            };

            collection.Add(entity);

            entity = new CarModelEngine()
            {
                EngineId = 6,
                CarModelId = 8,
            };

            collection.Add(entity);

            entity = new CarModelEngine()
            {
                EngineId = 6,
                CarModelId = 5,
            };

            collection.Add(entity);

            entity = new CarModelEngine()
            {
                EngineId = 7,
                CarModelId = 6,
            };

            collection.Add(entity);

            entity = new CarModelEngine()
            {
                EngineId = 7,
                CarModelId = 7,
            };

            collection.Add(entity);

            entity = new CarModelEngine()
            {
                EngineId = 8,
                CarModelId = 9,
            };

            collection.Add(entity);


            entity = new CarModelEngine()
            {
                EngineId = 8,
                CarModelId = 19,
            };

            collection.Add(entity);

            entity = new CarModelEngine()
            {
                EngineId = 9,
                CarModelId = 10,
            };

            collection.Add(entity);

            entity = new CarModelEngine()
            {
                EngineId = 10,
                CarModelId = 11,
            };

            collection.Add(entity);

            entity = new CarModelEngine()
            {
                EngineId = 11,
                CarModelId = 12,
            };

            collection.Add(entity);

            entity = new CarModelEngine()
            {
                EngineId = 11,
                CarModelId = 16,
            };

            collection.Add(entity);

            entity = new CarModelEngine()
            {
                EngineId = 12,
                CarModelId = 13,
            };

            collection.Add(entity);

            entity = new CarModelEngine()
            {
                EngineId = 12,
                CarModelId = 17,
            };

            collection.Add(entity);

            entity = new CarModelEngine()
            {
                EngineId = 12,
                CarModelId = 14,
            };

            collection.Add(entity);

            entity = new CarModelEngine()
            {
                EngineId = 13,
                CarModelId = 15,
            };

            collection.Add(entity);

            entity = new CarModelEngine()
            {
                EngineId = 14,
                CarModelId = 6,
            };

            collection.Add(entity);

            entity = new CarModelEngine()
            {
                EngineId = 14,
                CarModelId = 7,
            };

            collection.Add(entity);

            entity = new CarModelEngine()
            {
                EngineId = 15,
                CarModelId = 9,
            };

            collection.Add(entity);

            entity = new CarModelEngine()
            {
                EngineId = 15,
                CarModelId = 19,
            };

            collection.Add(entity);

            entity = new CarModelEngine()
            {
                EngineId = 16,
                CarModelId = 19,
            };

            collection.Add(entity);

            entity = new CarModelEngine()
            {
                EngineId = 16,
                CarModelId = 18,
            };

            collection.Add(entity);

            return collection;
        }
    }
}
