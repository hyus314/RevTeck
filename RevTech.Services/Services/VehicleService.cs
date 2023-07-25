namespace RevTech.Core.Services
{
    using RevTech.Data.ViewModels.Vehicles;
    using RevTech.Core.Contracts;
    using RevTech.Data;
    using Microsoft.EntityFrameworkCore;

    public class VehicleService : IVehicleService
    {
        private readonly RevtechDbContext data;
        public VehicleService(RevtechDbContext data)
        {
            this.data = data;
        }

        public async Task<ICollection<EngineViewModel>> GetEnginesByModelIdAsync(int id)
        {
            var engines = await this.data.CarModelsEngines.Where(x => x.CarModelId == id)
                .Select(e => new EngineViewModel()
                {
                    Id = e.EngineId,
                    Name = e.Engine.Name,
                    HorsePower = e.Engine.HorsePower,
                    Torque = e.Engine.Torque
                })
                .ToArrayAsync();

            return engines;
        }

        public async Task<ICollection<ManufacturerViewModel>> GetUserWithManufacturersAsync(string userId)
        {
            return await this.data.Manufacturers
            .Select(m => new ManufacturerViewModel()
            {
                Id = m.Id,
                Name = m.Name,
                ImageURL = m.ImageURL,
            }).ToListAsync();

        }

        public async Task<ICollection<CarModelViewModel>> GetModelsByManufacturerIdAsync(int id)
        {
            var models = await this.data.CarModels.Where(m => m.ManufacturerId == id)
                .Select(m => new CarModelViewModel()
                {
                    Id = m.Id,
                    ModelName = m.ModelName,
                    ManufacturerName = m.Manufacturer.Name,
                    YearCreated_Start = m.YearCreated_Start,
                    YearCreated_End = m.YearCreated_End,
                    ImageURL = m.ImageURL
                }).ToArrayAsync();

            return models;
        }
    }
}
