
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


        }

        [Test]
        public async Task TestSetup()
        {
            this.service = new VehicleService(this.data);
            this.data.Database.EnsureDeleted();
            SeedDatabase(this.data);
            var result = await this.service.GetAllCarModelsAsync();
            Assert.AreEqual(1, result.Count);
        }
    }
}