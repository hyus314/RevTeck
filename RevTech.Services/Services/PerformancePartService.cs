using Microsoft.EntityFrameworkCore;
using RevTech.Core.Contracts;
using RevTech.Data;
using RevTech.Data.ViewModels.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RevTech.Core.Services
{
    public class PerformancePartService : IPerformancePartService
    {
        private readonly RevtechDbContext data;
        public PerformancePartService(RevtechDbContext data)
        {
            this.data = data;
        }

        public async Task<ICollection<ECUTuningViewModel>> GetECUTuningsForEngineAsync(int engineId)
        {

            var ecuTunings = await this.data.ECUTunings.Where(x => x.EngineId == engineId)
                .AsNoTracking()
                .Select(ecu => new ECUTuningViewModel()
                {
                    Id = ecu.Id,
                    Manufacturer = ecu.Manufacturer,
                    HorsePowerBoost = ecu.HorsePowerBoost,
                    TorqueBoost = ecu.TorqueBoost,
                    Name = ecu.Name,
                    Price = ecu.Price,
                    ImageURL = ecu.ImageURL,
                }).ToArrayAsync();

            return ecuTunings;
        }

        public async Task<ICollection<ExhaustKitViewModel>> GetExhaustsForModelAndEngineAsync(int engineId, int carModelId)
        {
            var exhausts = await this.data.ExhaustKits.Where(x => x.EngineId == engineId && x.CarModelId == carModelId)
                .AsNoTracking()
                .Select(x => new ExhaustKitViewModel()
                {
                    Id = x.Id,
                    Manufacturer = x.Manufacturer,
                    Model = x.Model,
                    Price = x.Price,
                    HorsePowerBoost = x.HorsePowerBoost,
                    TorqueBoost = x.TorqueBoost,
                    ImageURl = x.ImageURL,
                }).ToArrayAsync();

            return exhausts;
        }

        public async Task<ICollection<FuelPumpViewModel>> GetFuelPumpForEngineAsync(int engineId)
        {
            var fuelPumps = await this.data.FuelPumps.Where(x => x.EngineId == engineId)
                .AsNoTracking()
                .Select(fp => new FuelPumpViewModel()
                {
                    Id = fp.Id,
                    Manufacturer = fp.Manufacturer,
                    Model = fp.Model,
                    HorsePowerBoost = fp.HorsePowerBoost,
                    TorqueBoost = fp.TorqueBoost,
                    Price = fp.Price,
                    ImageURl = fp.ImageURL
                }).ToArrayAsync();

            return fuelPumps;
        }

        public async Task<ICollection<InjectorKitViewModel>> GetInjectorKitsForEngine(int engineId)
        {
            var injectorKits = await this.data.InjectorKits.Where(x => x.EngineId == engineId)
                .AsNoTracking()
                .Select(ik => new InjectorKitViewModel()
                {
                    Id = ik.Id,
                    Manufacturer = ik.Manufacturer,
                    Model = ik.Model,
                    HorsePowerBoost = ik.HorsePowerBoost,
                    TorqueBoost = ik.TorqueBoost,
                    Price = ik.Price,
                    ImageURL = ik.ImageURL
                }).ToArrayAsync();

            return injectorKits;
        }

        public async Task<ICollection<OilCoolerViewModel>> GetOilCoolersForEngineAsync(int engineId)
        {
            var oilCoolers = await this.data.OilCoolers.Where(x => x.EngineId == engineId)
                .AsNoTracking()
                .Select(oc => new OilCoolerViewModel()
                {
                    Id = oc.Id,
                    Manufacturer = oc.Manufacturer,
                    Model = oc.Model,
                    Price = oc.Price,
                    ImageURL = oc.ImageURL
                }).ToArrayAsync();
            
            return oilCoolers;
        }

        public async Task<ICollection<SparkPlugsViewModel>> GetSparkPlugsForEngineAsync(int engineId)
        {
            var sparkPlugs = await this.data.SparkPlugsKits.Where(x => x.EngineId == engineId)
                .AsNoTracking()
                .Select(sp => new SparkPlugsViewModel()
                {
                    Id = sp.Id,
                    Manufacturer = sp.Manufacturer,
                    Price = sp.Price,
                    ImageURl = sp.ImageURL
                }).ToArrayAsync();

            return sparkPlugs;
        }

        public async Task<ICollection<SuperchargerKitViewModel>> GetSuperchargersForEngineAsync(int engineId)
        {
            var superchargers = await this.data.SuperchargerKits.Where(x => x.EngineId == engineId)
                .AsNoTracking()
                .Select(s => new SuperchargerKitViewModel()
                {
                    Id = s.Id,
                    ModelName = s.ModelName,
                    Manufacturer = s.Manufacturer,
                    HorsePowerBoost = s.HorsePowerBoost,
                    TorqueBoost = s.TorqueBoost,
                    ImageURL = s.ImageURL,
                    Price = s.Price
                }).ToArrayAsync();

            return superchargers;
        }

        public async Task<ICollection<TCUTuningViewModel>> GetTCUTuningsAsync()
        {
            var tcuTunings = await this.data.TCUTunings.Select(x => new TCUTuningViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                ImageURL = x.ImageURL
            }).ToArrayAsync();

            return tcuTunings;
        }

        public async Task<ICollection<TurboKitViewModel>> GetTurbosForEngineAsync(int engineId)
        {
            var turbos = await this.data.TurboKits.Where(x => x.EngineId == engineId)
                .AsNoTracking()
                .Select(t => new TurboKitViewModel()
                {
                    Id = t.Id,
                    ModelName = t.ModelName,
                    Manufacturer = t.Manufacturer,
                    HorsePowerBoost = t.HorsePowerBoost,
                    TorqueBoost = t.TorqueBoost,
                    PressureBoost = t.PressureBoost,
                    ImageURL = t.ImageURL,
                    Price = t.Price
                }).ToArrayAsync();

            return turbos;
        }
    }
}
