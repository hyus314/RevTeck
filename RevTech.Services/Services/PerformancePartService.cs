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
            var fuelPumps = await this.data.Engine_FuelPumps.Where(x => x.EngineId == engineId)
                .Select(fp => new FuelPumpViewModel()
                {
                    Id = fp.FuelPumpId,
                    Manufacturer = fp.FuelPump.Manufacturer,
                    Model = fp.FuelPump.Model,
                    HorsePowerBoost = fp.FuelPump.HorsePowerBoost,
                    TorqueBoost = fp.FuelPump.TorqueBoost,
                    Price = fp.FuelPump.Price,
                    ImageURl = fp.FuelPump.ImageURL
                }).ToArrayAsync();

            return fuelPumps;
        }

        public async Task<ICollection<InjectorKitViewModel>> GetInjectorKitsForEngine(int engineId)
        {
            var injectorKits = await this.data.Engine_InjectorKits.Where(x => x.EngineId == engineId)
                .Select(ik => new InjectorKitViewModel()
                {
                    Id = ik.InjectorKitId,
                    Manufacturer = ik.InjectorKit.Manufacturer,
                    Model = ik.InjectorKit.Model,
                    HorsePowerBoost = ik.InjectorKit.HorsePowerBoost,
                    TorqueBoost = ik.InjectorKit.TorqueBoost,
                    Price = ik.InjectorKit.Price,
                    ImageURL = ik.InjectorKit.ImageURL
                }).ToArrayAsync();

            return injectorKits;
        }

        public async Task<ICollection<OilCoolerViewModel>> GetOilCoolersForEngineAsync(int engineId)
        {
            var oilCoolers = await this.data.Engine_OilCoolers.Where(x => x.EngineId == engineId)
                .Select(oc => new OilCoolerViewModel()
                {
                    Id = oc.OilCoolerId,
                    Manufacturer = oc.OilCooler.Manufacturer,
                    Model = oc.OilCooler.Model,
                    Price = oc.OilCooler.Price,
                    ImageURL = oc.OilCooler.ImageURL
                }).ToArrayAsync();
            
            return oilCoolers;
        }

        public async Task<ICollection<SparkPlugsViewModel>> GetSparkPlugsForEngineAsync(int engineId)
        {
            var sparkPlugs = await this.data.Engine_SparkPlugKits.Where(x => x.EngineId == engineId)
                .Select(sp => new SparkPlugsViewModel()
                {
                    Id = sp.SparkPlugKitId,
                    Manufacturer = sp.SparkPlugKit.Manufacturer,
                    Price = sp.SparkPlugKit.Price,
                    ImageURl = sp.SparkPlugKit.ImageURL
                }).ToArrayAsync();

            return sparkPlugs;
        }

        public async Task<ICollection<SuperchargerKitViewModel>> GetSuperchargersForEngineAsync(int engineId)
        {
            var superchargers = await this.data.SuperchargerKits.Where(x => x.EngineId == engineId)
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
