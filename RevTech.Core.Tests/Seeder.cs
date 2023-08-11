using RevTech.Data;
using RevTech.Data.Models.PerformanceParts;
using RevTech.Data.Models.UserConfiguration;
using RevTech.Data.Models.Vehicles;
using RevTech.Data.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace RevTech.Core.Tests
{
    public static class Seeder
    {
        public static RevTeckUser User;
        public static Manufacturer Manufacturer;
        public static CarModel CarModel;
        public static Engine Engine;
        public static CarModelEngine CarModelEngine;
        public static TurboKit TurboKit;
        public static TCUTuning TCUTuning;
        public static SuperchargerKit SuperchargerKit;
        public static SparkPlugs SparkPlugs;
        public static OilCooler OilCooler;
        public static ECU_TCU_ConnectionTable ECU_TCU_ConnectionTable;
        public static Engine_FuelPump Engine_FuelPump;
        public static ECUTuning ECUTuning;
        public static Engine_InjectorKit Engine_InjectorKit;
        public static InjectorKit InjectorKit;
        public static Engine_OilCooler Engine_OilCooler;
        public static FuelPump FuelPump;
        public static Engine_SparkPlugKit Engine_SparkPlugKit;
        public static ExhaustKit ExhaustKit;
        public static Configuration Configuration;
        public static UserConfiguration UserConfiguration;
        public static void SeedDatabase(RevtechDbContext data)
        {
            data.Database.EnsureDeleted();

            User = new RevTeckUser()
            {
                UserName = "senna11",
                NormalizedUserName = "SENNA11",
                NormalizedEmail = "SENNA@GMAIL.COM",
                EmailConfirmed = false,
                PasswordHash = "$2y$10$kciWDMtkTjsvI.ciLNauvOza1wqzrvUoojXx3I.aKsz34eDNfvtIe",
                SecurityStamp = "23K6BQ5FVMIRIQOMIGQL3L27DH3Z4Q7L",
                ConcurrencyStamp = "4f2515c2-dfd8-458f-9e65-62287c3ba88e",
                TwoFactorEnabled = false,
                FirstName = "Ayrton",
                LastName = "Senna"
            };
            data.Users.Add(User);
            Manufacturer = new Manufacturer()
            {
                Name = "McLaren",
                ImageURL = "https://listcarbrands.com/wp-content/uploads/2016/12/McLaren-Logo.png"
            };
            data.Manufacturers.Add(Manufacturer);
            CarModel = new CarModel()
            {
                ModelName = "LP720",
                Manufacturer = Manufacturer,
                YearCreated_Start = 2015,
                YearCreated_End = 2020,
                ImageURL = "https://mclaren.scene7.com/is/image/mclaren/04.%20Coupe_Front%203_4_High_Temple_v1:crop-16x9?wid=1920&hei=1080",
            };
            data.CarModels.Add(CarModel);
            Engine = new Engine()
            {
                Name = "4.0 V8TT",
                HorsePower = 710,
                Torque = 770,
            };
            data.Engines.Add(Engine);
            CarModelEngine = new CarModelEngine()
            {
                CarModel = CarModel,
                Engine = Engine,
            };
            data.CarModelsEngines.Add(CarModelEngine);
            TurboKit = new TurboKit()
            {
                ModelName = "Turbo For LP720",
                Manufacturer = "SennaTurbos",
                HorsePowerBoost = 200,
                TorqueBoost = 200,
                PressureBoost = 2.2m,
                Engine = Engine,
                ImageURL = "https://www.turbo-total.com/media/image/64/78/f0/McLaren-720S_600x600.jpg",
                Price = 10000.00m
            };
            data.TurboKits.Add(TurboKit);
            TCUTuning = new TCUTuning()
            {
                Name = "Increase Top Speed",
                Description = "Once this selected TCU Option is installed, it will result in a higher Top Speed, but the acceleration rate will be reduced",
                ImageURL = "https://tuitionphysics.com/wp-content/uploads/2020/06/speed-velocity-and-acceleration-concepts-differences.jpg"
            };
            data.TCUTunings.Add(TCUTuning);
            SuperchargerKit = new SuperchargerKit()
            {
                ModelName = "SuperCharger For LP720",
                Manufacturer = "SennaChargers",
                HorsePowerBoost = 200,
                TorqueBoost = 200,
                Engine = Engine,
                ImageURL = "https://magnusonsuperchargers.com/cdn/shop/files/CorvetteHotRod.jpg?v=1686584281",
                Price = 10000.00m
            };
            data.SuperchargerKits.Add(SuperchargerKit);
            OilCooler = new OilCooler()
            {
                Manufacturer = "SennaCooling",
                Model = "OilCooler",
                Price = 1000.00m,
                ImageURL = "https://c1552172.ssl.cf0.rackcdn.com/1509007_x450.webp"
            };
            data.OilCoolers.Add(OilCooler);
            ECUTuning = new ECUTuning()
            {
                Manufacturer = "SennaDigitalWorks",
                HorsePowerBoost = 200,
                TorqueBoost = 200,
                Engine = Engine,
                ImageURL = "https://motoristprod.s3.amazonaws.com/uploads/redactor_rails/picture/data/3244/motorist-ecu-tuning-june-2020.png",
                Name = "ECU Upgrade for LP720",
                Price = 1000.00m,
            };
            data.ECUTunings.Add(ECUTuning);
            InjectorKit = new InjectorKit()
            {
                Manufacturer = "SennaInjectionSystems",
                Model = "Injector Kit for LP720",
                HorsePowerBoost = 200,
                TorqueBoost = 200,
                ImageURL = "https://c1552172.ssl.cf0.rackcdn.com/87249_x450.webp",
                Price = 1000.00m
            };
            data.InjectorKits.Add(InjectorKit);
            Engine_OilCooler = new Engine_OilCooler()
            {
                Engine = Engine,
                OilCooler = OilCooler
            };
            data.Engine_OilCoolers.Add(Engine_OilCooler);
            FuelPump = new FuelPump()
            {
                Manufacturer = "SennaInjectionSystems",
                Model = "Fuel Pump for LP720",
                HorsePowerBoost = 200,
                TorqueBoost = 200,
                Price = 1000.00m,
                ImageURL = "https://cdn11.bigcommerce.com/s-6y7pa5d/images/stencil/1280x1280/products/24113/25401/stage_3__b7rs4_hpfps_1_1__82083.1542907995.jpg?c=2",
            };
            data.FuelPumps.Add(FuelPump);
            SparkPlugs = new SparkPlugs()
            {
                Manufacturer = "SennaSpark",
                Price = 100.00m,
                ImageURL = "https://i.ebayimg.com/images/g/ceQAAOSwiDFYQVzW/s-l1600.jpg"
            };
            data.SparkPlugsKits.Add(SparkPlugs);
            Engine_SparkPlugKit = new Engine_SparkPlugKit()
            {
                Engine = Engine,
                SparkPlugKit = SparkPlugs
            };
            data.Engine_SparkPlugKits.Add(Engine_SparkPlugKit);
            ExhaustKit = new ExhaustKit()
            {
                Manufacturer = "SennaExhausts",
                Model = "Exhaust Kit for LP720",
                Price = 10000.00m,
                HorsePowerBoost = 200,
                TorqueBoost = 200,
                ImageURL = "https://www.evox-performance.com/6715-product-watermak/ipe-exhaust-system-mclaren-gt-.jpg",
                Engine = Engine,
                CarModel = CarModel,
            };
            data.ExhaustKits.Add(ExhaustKit);
            ECU_TCU_ConnectionTable = new ECU_TCU_ConnectionTable()
            {
                ECUTuning = ECUTuning,
                TCUTuning = TCUTuning,
            };
            data.ECU_TCU_Connection.Add(ECU_TCU_ConnectionTable);
            Engine_FuelPump = new Engine_FuelPump()
            {
                Engine = Engine,
                FuelPump = FuelPump
            };
            data.Engine_FuelPumps.Add(Engine_FuelPump);
            Engine_InjectorKit = new Engine_InjectorKit()
            {
                Engine = Engine,
                InjectorKit = InjectorKit
            };
            data.Engine_InjectorKits.Add(Engine_InjectorKit);

            Configuration = new Configuration()
            {
                CarModel = CarModel,
                Engine = Engine,
                TurboKit = TurboKit,
                ECUTuning = ECUTuning,
                ExhaustKit = ExhaustKit,
                FuelPump = FuelPump,
                InjectorKit = InjectorKit,
                OilCooler = OilCooler,
                SparkPlugs = SparkPlugs,
                SuperchargerKit = SuperchargerKit,
                TCUTuning = TCUTuning,
            };
            data.Configurations.Add(Configuration);

            UserConfiguration = new UserConfiguration()
            {
                User = User,
                Configuration = Configuration
            };
            data.UsersConfiguration.Add(UserConfiguration);
            data.SaveChanges();

        }
    }

}
