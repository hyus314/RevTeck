using RevTech.Data.ViewModels.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevTech.Core.Contracts
{
    public interface IPerformancePartService
    {
        public Task<ICollection<SparkPlugsViewModel>> GetSparkPlugsForEngineAsync(int engineId);
        public Task<ICollection<OilCoolerViewModel>> GetOilCoolersForEngineAsync(int engineId);
        public Task<ICollection<InjectorKitViewModel>> GetInjectorKitsForEngine(int engineId);
        public Task<ICollection<FuelPumpViewModel>> GetFuelPumpForEngineAsync(int engineId);
        public Task<ICollection<ECUTuningViewModel>> GetECUTuningsForEngineAsync(int engineId);
        public Task<ICollection<ExhaustKitViewModel>> GetExhaustsForModelAndEngineAsync(int engineId, int carModelId);
        public Task<ICollection<TurboKitViewModel>> GetTurbosForEngineAsync(int engineId);
        public Task<ICollection<SuperchargerKitViewModel>> GetSuperchargersForEngineAsync(int engineId);
        public Task<ICollection<TCUTuningViewModel>> GetTCUTuningsAsync();
    }
}
