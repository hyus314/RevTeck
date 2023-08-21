
namespace RevTech.Core.Services
{
    using Microsoft.AspNetCore.DataProtection;
    using Microsoft.EntityFrameworkCore;
    using RevTech.Core.Contracts;
    using RevTech.Data;
    using RevTech.Data.Models.PerformanceParts;
    using RevTech.Data.Models.UserConfiguration;
    using RevTech.Data.User;
    using RevTech.Data.ViewModels.User;
    using RevTech.Data.ViewModels.Vehicles;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class ConfigurationService : IConfigurationService
    {
        private readonly IDataProtector dataProtector;
        private readonly RevtechDbContext data;

        public ConfigurationService(RevtechDbContext data, IDataProtectionProvider protectionProvider)
        {
            this.data = data;
            this.dataProtector = protectionProvider.CreateProtector("ProtectMyConfigurationId");
        }

        public async Task<UserViewModel> GenerateUserViewModelAsync(int engineId, int carModelId, string userId)
        {
            var engine = await this.data.Engines.FindAsync(engineId);

            var engineViewModel = new EngineViewModel()
            {
                Id = engineId,
                Name = engine!.Name,
                HorsePower = engine.HorsePower,
                Torque = engine.Torque
            };

            var carModel = await this.data.CarModels.FindAsync(carModelId);

            var manufacturer = await this.data.Manufacturers.FindAsync(carModel!.ManufacturerId);

            var carModelViewModel = new SelectedVehicleViewModel()
            {
                Id = carModelId,
                ModelName = carModel.ModelName,
                YearCreated_Start = carModel.YearCreated_Start,
                YearCreated_End = carModel.YearCreated_End,
                ManufacturerName = manufacturer!.Name,
                ImageURL = carModel.ImageURL,
                Engine = engineViewModel
            };

            var userViewModel = new UserViewModel()
            {
                UserId = userId,
                CarModelId = carModelId,
                CarModel = carModelViewModel
            };

            return userViewModel;
        }

        public UserViewModel GenerateUserConfiguration(string userId)
        {
            var configuration = new UserViewModel()
            {
                UserId = userId,
            };

            return configuration;
        }


        public async Task CreateConfigurationForUserAsync(Dictionary<string, int> selectedParts, string userId, int engineId, int carModelId)
        {
            var turbo = await this.data.TurboKits.FindAsync(selectedParts["turbo"]);
            var exhaustKit = await this.data.ExhaustKits.FindAsync(selectedParts["exhaustKit"]);
            var supercharger = await this.data.SuperchargerKits.FindAsync(selectedParts["supercharger"]);
            var ecu = await this.data.ECUTunings.FindAsync(selectedParts["ecu"]);
            var fuelPump = await this.data.FuelPumps.FindAsync(selectedParts["fuelPump"]);
            var injectorKit = await this.data.InjectorKits.FindAsync(selectedParts["injectorKit"]);
            var oilCooler = await this.data.OilCoolers.FindAsync(selectedParts["oilCooler"]);
            var sparkPlug = await this.data.SparkPlugsKits.FindAsync(selectedParts["sparkPlug"]);


            var totalPowerBoost = GetTotalUpgradeSums(turbo, exhaustKit, supercharger, ecu, fuelPump, injectorKit);
            var totalPrice = GetPricesFromParts(turbo, exhaustKit, supercharger, ecu, fuelPump, injectorKit, oilCooler, sparkPlug);

            var configuration = new Configuration()
            {
                EngineId = engineId,
                CarModelId = carModelId,
                TurboKitId = selectedParts["turbo"] == 0 ? null : selectedParts["turbo"],
                TCUTuningId = selectedParts["tcu"] == 0 ? null : selectedParts["tcu"],
                ExhaustKitId = selectedParts["exhaustKit"] == 0 ? null : selectedParts["exhaustKit"],
                SuperchargerKitId = selectedParts["supercharger"] == 0 ? null : selectedParts["supercharger"],
                ECUTuningId = selectedParts["ecu"] == 0 ? null : selectedParts["ecu"],
                FuelPumpId = selectedParts["fuelPump"] == 0 ? null : selectedParts["fuelPump"],
                InjectorKitId = selectedParts["injectorKit"] == 0 ? null : selectedParts["injectorKit"],
                OilCoolerId = selectedParts["oilCooler"] == 0 ? null : selectedParts["oilCooler"],
                SparkPlugsId = selectedParts["sparkPlug"] == 0 ? null : selectedParts["sparkPlug"],
                HorsePowerBoostTotal = totalPowerBoost[0],
                TorqueBoostTotal = totalPowerBoost[1],
                TotalPrice = totalPrice
            };

            await this.data.Configurations.AddAsync(configuration);
            await this.data.SaveChangesAsync();

            var userConfiguration = new UserConfiguration()
            {
                UserId = userId,
                Configuration = configuration
            };

            await this.data.UsersConfiguration.AddAsync(userConfiguration);
            await this.data.SaveChangesAsync();
        }


        private int[] GetTotalUpgradeSums(TurboKit? turbo, ExhaustKit? exhaustKit, SuperchargerKit? supercharger, ECUTuning? ecu, FuelPump? fuelPump, InjectorKit? injectorKit)
        {
            var turboHpBoost = turbo != null ? turbo.HorsePowerBoost : 0;
            var exhaustKitHpBoost = exhaustKit != null ? exhaustKit.HorsePowerBoost : 0;
            var superchargerHpBoost = supercharger != null ? supercharger.HorsePowerBoost : 0;
            var ecuHpBoost = ecu != null ? ecu.HorsePowerBoost : 0;
            var fuelPumpHpBoost = fuelPump != null ? fuelPump.HorsePowerBoost : 0;
            var injectorKitHpBoost = injectorKit != null ? injectorKit.HorsePowerBoost : 0;

            var totalHpBoost = turboHpBoost +
                exhaustKitHpBoost +
                superchargerHpBoost +
                ecuHpBoost +
                fuelPumpHpBoost +
                superchargerHpBoost +
                injectorKitHpBoost;

            var turboTqBoost = turbo != null ? turbo.TorqueBoost : 0;
            var exhaustKitTqBoost = exhaustKit != null ? exhaustKit.TorqueBoost : 0;
            var superchargerTqBoost = supercharger != null ? supercharger.TorqueBoost : 0;
            var ecuTqBoost = ecu != null ? ecu.TorqueBoost : 0;
            var fuelPumpTqBoost = fuelPump != null ? fuelPump.TorqueBoost : 0;
            var injectorKitTqBoost = injectorKit != null ? injectorKit.TorqueBoost : 0;

            var totalTqBoost = turboTqBoost +
                exhaustKitTqBoost +
                superchargerTqBoost +
                ecuTqBoost +
                fuelPumpTqBoost +
                superchargerTqBoost +
                injectorKitTqBoost;

            var totalBoost = new int[]
            {
                totalHpBoost,
                totalTqBoost
            };

            return totalBoost;
        }

        private decimal GetPricesFromParts(
            TurboKit? turbo,
            ExhaustKit? exhaustKit,
            SuperchargerKit? supercharger,
            ECUTuning? ecu,
            FuelPump? fuelPump,
            InjectorKit? injectorKit,
            OilCooler? oilCooler,
            SparkPlugs? sparkPlug)
        {
            var turboPrice = turbo != null ? turbo.Price : 0;
            var exhaustKitPrice = exhaustKit != null ? exhaustKit.Price : 0;
            var superchargerPrice = supercharger != null ? supercharger.Price : 0;
            var ecuPrice = ecu != null ? ecu.Price : 0;
            var fuelPumpPrice = fuelPump != null ? fuelPump.Price : 0;
            var injectorKitPrice = injectorKit != null ? injectorKit.Price : 0;
            var oilCoolerPrice = oilCooler != null ? oilCooler.Price : 0;
            var sparkPlugsPrice = sparkPlug != null ? sparkPlug.Price : 0;

            var totalPrice = turboPrice +
                exhaustKitPrice +
                superchargerPrice +
                ecuPrice +
                fuelPumpPrice +
                injectorKitPrice +
                oilCoolerPrice +
                sparkPlugsPrice;

            return Decimal.Round(totalPrice, 2);
        }

        public async Task<ICollection<UserConfigurationViewModel>> GetConfigurationsForUserAsync(string userId)
        {
            var configurations = await this.data.UsersConfiguration.Where(x => x.UserId == userId)
                .Select(x => new UserConfigurationViewModel()
                {
                    UserId = x.User.Id,
                    ConfigurationId = dataProtector.Protect(x.ConfigurationId.ToString()),
                    CarModel = x.Configuration.CarModel.ModelName,
                    CarModelId = x.Configuration.CarModelId,
                    EngineId = x.Configuration.EngineId,
                    Manufacturer = x.Configuration.CarModel.Manufacturer.Name,
                    CarModelImageURL = x.Configuration.CarModel.ImageURL,
                    Price = x.Configuration.TotalPrice,
                    HorsePowerBoost = x.Configuration.HorsePowerBoostTotal
                }).ToArrayAsync();

            return configurations;
        }

        public async Task RemoveConfigurationAsync(string userId, int configurationId)
        {
            this.data.UsersConfiguration.Remove(await this.data.UsersConfiguration.FirstAsync(x => x.UserId == userId && x.ConfigurationId == configurationId));
            this.data.Configurations.Remove(await this.data.Configurations.FirstAsync(x => x.Id == configurationId));
            await this.data.SaveChangesAsync();
        }

        public async Task<UserEditConfigurationViewModel> GenerateEditViewModelAsync(string encryptedConfigurationId)
        {
           var configurationId = DecryptConfigurationId(encryptedConfigurationId);
            var entity = await this.data.Configurations.FirstAsync(x => x.Id == configurationId);

            var model = new UserEditConfigurationViewModel();
            var carModel = new CarModelViewModel();

            var entityCarModel = await this.data.CarModels.FirstAsync(x => x.Id == entity.CarModelId);
            var entityCarModelManyfacturer = await this.data.Manufacturers.FirstAsync(x => x.Id == entityCarModel.ManufacturerId);

            carModel.ManufacturerName = entityCarModelManyfacturer.Name;
            carModel.Id = entityCarModel.Id;
            carModel.ModelName = entityCarModel.ModelName;
            carModel.YearCreated_Start = entityCarModel.YearCreated_Start;
            carModel.YearCreated_End = entityCarModel.YearCreated_End;
            carModel.ImageURL = entityCarModel.ImageURL;

            var engine = new EngineViewModel();
            var entityEngine = await this.data.Engines.FirstAsync(x => x.Id == entity.EngineId);

            engine.Id = entityEngine.Id;
            engine.Name = entityEngine.Name;
            engine.HorsePower = entityEngine.HorsePower;
            engine.Torque = entityEngine.Torque;


            model = new UserEditConfigurationViewModel()
            {
                Id = entity.Id,
                CarModel = carModel,
                Engine = engine,
                TurboKitId = entity.TurboKitId == null ? null : entity.TurboKitId,
                ECUTuningId = entity.ECUTuningId == null ? null : entity.ECUTuningId,
                ExhaustKitId = entity.ExhaustKitId == null ? null : entity.ExhaustKitId,
                FuelPumpId = entity.FuelPumpId == null ? null : entity.FuelPumpId,
                InjectorKitId = entity.InjectorKitId == null ? null : entity.InjectorKitId,
                OilCoolerId = entity.OilCoolerId == null ? null : entity.OilCoolerId,
                SparkPlugsId = entity.SparkPlugsId == null ? null : entity.SparkPlugsId,
                SuperchargerKitId = entity.SuperchargerKitId == null ? null : entity.SuperchargerKitId,
                TCUTuningId = entity.TCUTuningId == null ? null : entity.TCUTuningId,
                TotalPrice = entity.TotalPrice,
                HorsePowerBoostTotal = entity.HorsePowerBoostTotal,
                TorqueBoostTotal = entity.TorqueBoostTotal
            };

            return model;
        }

        public async Task EditConfigurationAsync(Dictionary<string, int> selectedParts, int configurationId, string userId)
        {
            var configurationEntity = await this.data.Configurations.FirstAsync(x => x.Id == configurationId);

            var turbo = await this.data.TurboKits.FindAsync(selectedParts["turbo"]);
            var exhaustKit = await this.data.ExhaustKits.FindAsync(selectedParts["exhaustKit"]);
            var supercharger = await this.data.SuperchargerKits.FindAsync(selectedParts["supercharger"]);
            var ecu = await this.data.ECUTunings.FindAsync(selectedParts["ecu"]);
            var fuelPump = await this.data.FuelPumps.FindAsync(selectedParts["fuelPump"]);
            var injectorKit = await this.data.InjectorKits.FindAsync(selectedParts["injectorKit"]);
            var oilCooler = await this.data.OilCoolers.FindAsync(selectedParts["oilCooler"]);
            var sparkPlug = await this.data.SparkPlugsKits.FindAsync(selectedParts["sparkPlug"]);

            var totalPowerBoost = GetTotalUpgradeSums(turbo, exhaustKit, supercharger, ecu, fuelPump, injectorKit);
            var totalPrice = GetPricesFromParts(turbo, exhaustKit, supercharger, ecu, fuelPump, injectorKit, oilCooler, sparkPlug);


            configurationEntity.TurboKitId = selectedParts["turbo"] == 0 ? null : selectedParts["turbo"];
            configurationEntity.ECUTuningId = selectedParts["ecu"] == 0 ? null : selectedParts["ecu"];
            configurationEntity.ExhaustKitId = selectedParts["exhaustKit"] == 0 ? null : selectedParts["exhaustKit"];
            configurationEntity.FuelPumpId = selectedParts["fuelPump"] == 0 ? null : selectedParts["fuelPump"];
            configurationEntity.InjectorKitId = selectedParts["injectorKit"] == 0 ? null : selectedParts["injectorKit"];
            configurationEntity.OilCoolerId = selectedParts["oilCooler"] == 0 ? null : selectedParts["oilCooler"];
            configurationEntity.SuperchargerKitId = selectedParts["supercharger"] == 0 ? null : selectedParts["supercharger"];
            configurationEntity.TCUTuningId = selectedParts["tcu"] == 0 ? null : selectedParts["tcu"];
            configurationEntity.TotalPrice = totalPrice;
            configurationEntity.HorsePowerBoostTotal = totalPowerBoost[0];
            configurationEntity.TorqueBoostTotal = totalPowerBoost[1];

            await this.data.SaveChangesAsync();
        }

        public int? DecryptConfigurationId(string encryptedConfigurationId)
        {
            try
            {
                var decryptedString = dataProtector.Unprotect(encryptedConfigurationId);
                return int.TryParse(decryptedString, out int configurationId) ? configurationId : (int?)null;
            }
            catch
            {
                // Log error or handle as needed.
                return null;
            }
        }
    }
}

