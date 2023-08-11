
namespace RevTech.Core.Tests
{
    using Microsoft.EntityFrameworkCore;
    using RevTech.Core.Contracts;
    using RevTech.Data;
    using NUnit.Framework;
    using static RevTech.Core.Tests.Seeder;
    using RevTech.Core.Services;

    public class VehicleServiceTests
    {
        private DbContextOptions<RevtechDbContext> dataOptions;
        private RevtechDbContext data;
        private IVehicleService service;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            this.dataOptions = new DbContextOptionsBuilder<RevtechDbContext>()
                .UseInMemoryDatabase("RevTechInMemory" + Guid.NewGuid().ToString())
                .Options;

            this.data = new RevtechDbContext(dataOptions);

            this.data.Database.EnsureCreated();

            this.service = new VehicleService(this.data);

            this.data.Database.EnsureDeleted();
            SeedDatabase(this.data);
        }

        [Test]
        public async Task TestSetup()
        {
            var result = await this.service.GetAllCarModelsAsync();
            Assert.That(result, Has.Count.EqualTo(1));
        }
        [Test]
        public async Task Test_GetEngine_ShouldReturn_OneEngine()
        {
            var model = await this.data.CarModels.FirstAsync();
            var result = await this.service.GetEnginesByModelIdAsync(model.Id);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(1));
        }
        [Test]
        public async Task Test_GetEngine_ShouldReturn_DummyDataEngine()
        {
            var model = await this.data.CarModels.FirstAsync();
            var result = await this.service.GetEnginesByModelIdAsync(model.Id);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.First().Name, Is.EqualTo("4.0 V8TT"));
        }
        [Test]
        public async Task Test_GetManufacturers_ShouldReturnOnlyOne_McLaren()
        {
            var result = await this.service.GetUserWithManufacturersAsync("userId");
            
            Assert.That(result, Is.Not.Null);
            Assert.That(result.First().Name, Is.EqualTo("McLaren"));
        }
        [Test]
        public async Task Test_GetModelsByManufacturer_ShouldReturnOnlyOne()
        {
            var manufacturer = await this.data.Manufacturers.FirstAsync();
            var result= await this.service.GetModelsByManufacturerIdAsync(manufacturer.Id);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(1));
        }

        [Test]
        public async Task Test_GetModelsByManufacturer_ShouldReturn_McLarenModel()
        {
            var manufacturer = await this.data.Manufacturers.FirstAsync();
            var result = await this.service.GetModelsByManufacturerIdAsync(manufacturer.Id);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.First().ModelName, Is.EqualTo("LP720"));
        }
    }
}