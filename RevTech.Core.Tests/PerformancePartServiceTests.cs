namespace RevTech.Core.Tests
{
    using Microsoft.EntityFrameworkCore;
    using RevTech.Core.Contracts;
    using RevTech.Data;
    using NUnit.Framework;
    using static RevTech.Core.Tests.Seeder;
    using RevTech.Core.Services;
    public class PerformancePartServiceTests
    {
        private DbContextOptions<RevtechDbContext> dataOptions;
        private RevtechDbContext data;
        private IPerformancePartService service;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            this.dataOptions = new DbContextOptionsBuilder<RevtechDbContext>()
                .UseInMemoryDatabase("RevTechInMemory" + Guid.NewGuid().ToString())
                .Options;

            this.data = new RevtechDbContext(dataOptions);

            this.data.Database.EnsureCreated();

            this.service = new PerformancePartService(this.data);

            this.data.Database.EnsureDeleted();
            SeedDatabase(this.data);
        }
        [Test]
        public async Task GetEcusForEngine_ShouldReturn_OneElement()
        {
            var engine = await this.data.Engines.FirstAsync();
            var result = await this.service.GetECUTuningsForEngineAsync(engine.Id);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(1));
        }
        [Test]
        public async Task GetEcusForEngine_ShouldReturn_EcuForMcLaren()
        {
            var engine = await this.data.Engines.FirstAsync();
            var result = await this.service.GetECUTuningsForEngineAsync(engine.Id);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.First().Name, Is.EqualTo("ECU Upgrade for LP720"));
        }

        [Test]
        public async Task GetExhaustsForEngineAndModel_ShouldReturn_OneElement()
        {
            var engine = await this.data.Engines.FirstAsync();
            var carModel = await this.data.CarModels.FirstAsync();
            var result = await this.service.GetExhaustsForModelAndEngineAsync(engine.Id, carModel.Id);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(1));
        }
        [Test]
        public async Task GetExhaustsForEngineAndModel_ShouldReturn_ExhaustForMcLaren()
        {
            var engine = await this.data.Engines.FirstAsync();
            var carModel = await this.data.CarModels.FirstAsync();
            var result = await this.service.GetExhaustsForModelAndEngineAsync(engine.Id, carModel.Id);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.First().Model, Is.EqualTo("Exhaust Kit for LP720"));
        }
        [Test]
        public async Task GetFuelPumps_ShouldReturn_OneElement()
        {
            var engine = await this.data.Engines.FirstAsync();
            var result = await this.service.GetFuelPumpForEngineAsync(engine.Id);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(1));
        }
        [Test]
        public async Task GetFuelPumps_ShouldReturn_FuelPumpForMcLaren()
        {
            var engine = await this.data.Engines.FirstAsync();
            var result = await this.service.GetFuelPumpForEngineAsync(engine.Id);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.First().Model, Is.EqualTo("Fuel Pump for LP720"));
        }
        [Test]
        public async Task GetInjectorKits_ShouldReturn_OneElement()
        {
            var engine = await this.data.Engines.FirstAsync();
            var result = await this.service.GetInjectorKitsForEngine(engine.Id);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(1));
        }
        [Test]
        public async Task GetInjectorKits_ShouldReturn_InjectorKitForMcLaren()
        {
            var engine = await this.data.Engines.FirstAsync();
            var result = await this.service.GetInjectorKitsForEngine(engine.Id);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.First().Model, Is.EqualTo("Injector Kit for LP720"));
        }
        [Test]
        public async Task GetOilCoolers_ShouldReturn_OneElement()
        {
            var engine = await this.data.Engines.FirstAsync();
            var result = await this.service.GetOilCoolersForEngineAsync(engine.Id);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(1));
        }
        [Test]
        public async Task GetOilCoolers_ShouldReturn_OilCoolerForMcLaren()
        {
            var engine = await this.data.Engines.FirstAsync();
            var result = await this.service.GetOilCoolersForEngineAsync(engine.Id);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.First().Model, Is.EqualTo("OilCooler"));
        }
        [Test]
        public async Task GetSparkPlugs_ShouldReturn_OneElement()
        {
            var engine = await this.data.Engines.FirstAsync();
            var result = await this.service.GetSparkPlugsForEngineAsync(engine.Id);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(1));
        }
        [Test]
        public async Task GetSparkPlugs_ShouldReturn_SparkPlugForMcLaren()
        {
            var engine = await this.data.Engines.FirstAsync();
            var result = await this.service.GetSparkPlugsForEngineAsync(engine.Id);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.First().Manufacturer, Is.EqualTo("SennaSpark"));
        }
        [Test]
        public async Task GetSuperchargers_ShouldReturn_OneElement()
        {
            var engine = await this.data.Engines.FirstAsync();
            var result = await this.service.GetSuperchargersForEngineAsync(engine.Id);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(1));
        }
        [Test]
        public async Task GetSuperchargers_ShouldReturn_SuperchargerForMcLaren()
        {
            var engine = await this.data.Engines.FirstAsync();
            var result = await this.service.GetSuperchargersForEngineAsync(engine.Id);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.First().ModelName, Is.EqualTo("SuperCharger For LP720"));
        }
        [Test]
        public async Task GetTcus_ShouldReturn_TopSpeedTCU()
        {
            var result = await this.service.GetTCUTuningsAsync();

            Assert.That(result, Is.Not.Null);
            Assert.That(result.First().Name, Is.EqualTo("Increase Top Speed"));
        }
        [Test]
        public async Task GetTCUs_ShouldReturn_OneElement()
        {
            var result = await this.service.GetTCUTuningsAsync();

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(1));
        }
        [Test]
        public async Task GetTurbos_ShouldReturn_TopSpeedTCU()
        {
            var engine = await this.data.Engines.FirstAsync();
            var result = await this.service.GetTurbosForEngineAsync(engine.Id);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(1));
        }
        [Test]
        public async Task GetTurbos_ShouldReturn_TurboForMcLaren()
        {
            var engine = await this.data.Engines.FirstAsync();
            var result = await this.service.GetTurbosForEngineAsync(engine.Id);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.First().ModelName, Is.EqualTo("Turbo For LP720"));
        }
    }
}
