using RevTech.Data.ViewModels.User;
using RevTech.Data.ViewModels.Vehicles;

namespace RevTech.Core.Contracts
{
    public interface IVehicleService
    {
        public Task<ICollection<CarModelViewModel>> GetAllCarModelsAsync();
        public Task<ICollection<ManufacturerViewModel>> GetUserWithManufacturersAsync(string userId);
        public Task<ICollection<CarModelViewModel>> GetModelsByManufacturerIdAsync(int id);
        public Task<ICollection<EngineViewModel>> GetEnginesByModelIdAsync(int id);   
    }
}
