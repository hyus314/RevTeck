using RevTech.Core.Contracts;
using RevTech.Data;
using RevTech.Data.Models.UserConfiguration;
using RevTech.Data.User;
using RevTech.Data.ViewModels.Payment;
using RevTech.Security;
using Stripe;

namespace RevTech.Core.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly RevtechDbContext data;
        private readonly ConfigurationDataProtector configDataProtector;

        public PaymentService(RevtechDbContext data, ConfigurationDataProtector configDataProtector)
        {
            this.data = data;
            this.configDataProtector = configDataProtector;
        }

        public async Task<PaymentDetailsViewModel> GeneratePaymentViewModelAsync(string configurationId, RevTeckUser user)
        {
            var configuration = await this.data.Configurations.FindAsync(this.configDataProtector.Decrypt(configurationId));

            if (configuration == null)
            {
                throw new InvalidOperationException("Configuration with this Id does not exist!");
            }

            var carModel = await this.data.CarModels.FindAsync(configuration.CarModelId);
            var engine = await this.data.Engines.FindAsync(configuration.EngineId);

            var userCarDetails = $"{carModel!.Manufacturer} {carModel!.ModelName} {engine!.Name}";

            var model = new PaymentDetailsViewModel()
            {
                UserCarDetails = userCarDetails,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Amount = configuration.TotalPrice
            };

            return model;
        }

        public async Task<ICollection<OrderedPartViewModel>> GetAllOrderedPartsForPayment(string configurationId)
        {
            var configuration = await this.data.Configurations.FindAsync(this.configDataProtector.Decrypt(configurationId));

            if (configuration == null)
            {
                throw new InvalidOperationException("Configuration with this Id does not exist!");
            }

            return await PopulateCollectionOfOrderedParts(configuration);
        }

        public async Task<string> CreatePaymentIntent_ClientSecret(ClientPaymentInfo paymentInfo, string amountString)
        {
            try
            {
                var options = new PaymentIntentCreateOptions()
                {
                    Amount = CalculateAmount(amountString),
                    Currency = "usd",
                    PaymentMethod = paymentInfo.PaymentMethodId,
                    Confirm = false,
                    ConfirmationMethod = "automatic"
                };

                var service = new PaymentIntentService();
                var paymentIntent = await service.CreateAsync(options);

                return paymentIntent.ClientSecret;
            }
            catch (StripeException e)
            {
                // Log the exception or take other appropriate actions
                return null;
            }
        }


        private static long? CalculateAmount(string amountString)
        {
            var amount = Decimal.Parse(amountString) * 100;
            return long.Parse(amount.ToString().Substring(0, amount.ToString().Length - 3));
        }

        private async Task<ICollection<OrderedPartViewModel>> PopulateCollectionOfOrderedParts(Configuration configuration)
        {
            ICollection<OrderedPartViewModel> orderedParts = new HashSet<OrderedPartViewModel>();
            var turbo = await this.data.TurboKits.FindAsync(configuration.TurboKitId);
            if (turbo != null)
            {
                var turboViewModel = new OrderedPartViewModel()
                {
                    PartType = "Turbo Kit",
                    PartManufacturer = turbo.Manufacturer,
                    PartModel = turbo.ModelName,
                    PartPrice = turbo.Price,
                };
                orderedParts.Add(turboViewModel);
            }

            var ecuTuning = await this.data.ECUTunings.FindAsync(configuration.ECUTuningId);
            if (ecuTuning != null)
            {
                var ecuTuningViewModel = new OrderedPartViewModel()
                {
                    PartType = "ECU Tuning",
                    PartManufacturer = ecuTuning.Manufacturer,
                    PartModel = ecuTuning.Name,
                    PartPrice = ecuTuning.Price,
                };
                orderedParts.Add(ecuTuningViewModel);
            }

            var exhaustKit = await this.data.ExhaustKits.FindAsync(configuration.ExhaustKitId);
            if (exhaustKit != null)
            {
                var exhaustKitViewModel = new OrderedPartViewModel()
                {
                    PartType = "Exhaust Kit",
                    PartManufacturer = exhaustKit.Manufacturer,
                    PartModel = exhaustKit.Model,
                    PartPrice = exhaustKit.Price,
                };
                orderedParts.Add(exhaustKitViewModel);
            }

            var fuelPump = await this.data.FuelPumps.FindAsync(configuration.FuelPumpId);
            if (fuelPump != null)
            {
                var fuelPumpViewModel = new OrderedPartViewModel()
                {
                    PartType = "Fuel Pump",
                    PartManufacturer = fuelPump.Manufacturer,
                    PartModel = fuelPump.Model,
                    PartPrice = fuelPump.Price,
                };
                orderedParts.Add(fuelPumpViewModel);
            }

            var injectorKit = await this.data.InjectorKits.FindAsync(configuration.InjectorKitId);
            if (injectorKit != null)
            {
                var injectorKitViewModel = new OrderedPartViewModel()
                {
                    PartType = "Injector Kit",
                    PartManufacturer = injectorKit.Manufacturer,
                    PartModel = injectorKit.Model,
                    PartPrice = injectorKit.Price,
                };
                orderedParts.Add(injectorKitViewModel);
            }

            var oilCooler = await this.data.OilCoolers.FindAsync(configuration.OilCoolerId);
            if (oilCooler != null)
            {
                var oilCoolerViewModel = new OrderedPartViewModel()
                {
                    PartType = "Oil Cooler",
                    PartManufacturer = oilCooler.Manufacturer,
                    PartModel = oilCooler.Model,
                    PartPrice = oilCooler.Price,
                };
                orderedParts.Add(oilCoolerViewModel);
            }

            var sparkPlugs = await this.data.SparkPlugsKits.FindAsync(configuration.SparkPlugsId);
            if (sparkPlugs != null)
            {
                var sparkPlugsViewModel = new OrderedPartViewModel()
                {
                    PartType = "Spark Plugs Kit",
                    PartManufacturer = sparkPlugs.Manufacturer,
                    PartPrice = sparkPlugs.Price,
                };
                orderedParts.Add(sparkPlugsViewModel);
            }

            var superchargerKit = await this.data.SuperchargerKits.FindAsync(configuration.SuperchargerKitId);
            if (superchargerKit != null)
            {
                var superchargerKitViewModel = new OrderedPartViewModel()
                {
                    PartType = "Supercharger Kit",
                    PartManufacturer = superchargerKit.Manufacturer,
                    PartModel = superchargerKit.ModelName,
                    PartPrice = superchargerKit.Price,
                };
                orderedParts.Add(superchargerKitViewModel);
            }

            var tcu = await this.data.TCUTunings.FindAsync(configuration.TCUTuningId);
            if ( tcu != null )
            {
                var tcuViewModel = new OrderedPartViewModel()
                {
                    PartType = "TCU Software",
                    PartModel = tcu.Name,
                };
                orderedParts.Add(tcuViewModel);
            }

            return orderedParts.OrderByDescending(x => x.PartPrice)
                .ThenBy(x => x.PartType)
                .ToArray();

        }
    }
}
