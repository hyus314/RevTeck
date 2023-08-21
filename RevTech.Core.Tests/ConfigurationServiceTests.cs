namespace RevTech.Core.Tests
{
    using Microsoft.AspNetCore.DataProtection;
    using Microsoft.EntityFrameworkCore;
    using RevTech.Core.Contracts;
    using RevTech.Core.Services;
    using RevTech.Data;
    using static RevTech.Core.Tests.Seeder;
    public class ConfigurationServiceTests
    {
        private DbContextOptions<RevtechDbContext> dataOptions;
        private RevtechDbContext data;
        private IConfigurationService service;
        private IDataProtectionProvider protectionProvider;
        [SetUp]
        public void OneTimeSetUp()
        {
            this.dataOptions = new DbContextOptionsBuilder<RevtechDbContext>()
                .UseInMemoryDatabase("RevTechInMemory" + Guid.NewGuid().ToString())
                .Options;

            this.data = new RevtechDbContext(dataOptions);
            this.data.Database.EnsureCreated();

            this.service = new ConfigurationService(this.data, protectionProvider);

            this.data.Database.EnsureDeleted();
            SeedDatabase(this.data);
        }

        [Test]
        public async Task GetConfigurationsForUser_ShouldReturn_OneConfiguration()
        {
            var user = await this.data.Users.FirstAsync();
            var result = await this.service.GetConfigurationsForUserAsync(user.Id);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(1));
        }
        [Test]
        public async Task GetConfigurationsForUser_ShouldReturn_CorrectPriceSum()
        {
            var user = await this.data.Users.FirstAsync();
            var result = await this.service.GetConfigurationsForUserAsync(user.Id);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.First().Price, Is.EqualTo(34100m));
        }
        [Test]
        public async Task GetConfigurationsForUser_ShouldReturn_CorrectHorsePowerBoostSum()
        {
            var user = await this.data.Users.FirstAsync();
            var result = await this.service.GetConfigurationsForUserAsync(user.Id);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.First().HorsePowerBoost, Is.EqualTo(1200));
        }
        [Test]
        public async Task RemoveConfiugration_ShouldWork_ForUserConfigurationTablee()
        {
            
            var user = await this.data.Users.FirstAsync();
            var configuration = await this.data.Configurations.FirstAsync();

            await this.service.RemoveConfigurationAsync(user.Id, configuration.Id);
            Assert.That(this.data.UsersConfiguration.Count, Is.EqualTo(0));
        }
        [Test]
        public async Task RemoveConfiugration_ShouldWork_ForConfigurationTable()
        {
            var user = await this.data.Users.FirstAsync();
            var configuration = await this.data.Configurations.FirstAsync();

            await this.service.RemoveConfigurationAsync(user.Id, configuration.Id);
            Assert.That(this.data.Configurations.Count, Is.EqualTo(0));
            
        }
        [Test]
        public async Task AddConfiguration_ShouldWork_ForConfigurationsTable()
        {
            var user = await this.data.Users.FirstAsync();
            var configuration = await this.data.Configurations.FirstAsync();
            var engine = await this.data.Engines.FirstAsync();

            await this.service.RemoveConfigurationAsync(user.Id, configuration.Id);

            Dictionary<string, int> partsSelected = new Dictionary<string, int>()
            {
                { "turbo", 1},
                { "tcu", 1},
                { "exhaustKit", 1},
                { "supercharger", 1},
                { "ecu", 1},
                { "fuelPump", 1},
                { "injectorKit", 1},
                { "oilCooler", 1},
                { "sparkPlug", 1},
            };

            await this.service.CreateConfigurationForUserAsync(partsSelected, user.Id, configuration.Id, engine.Id);
            Assert.That(this.data.Configurations.Count, Is.EqualTo(1));

        }

        [Test]
        public async Task AddConfiguration_ShouldWork_ForUserConfigurationsTablee()
        {
            var user = await this.data.Users.FirstAsync();
            var configuration = await this.data.Configurations.FirstAsync();
            var engine = await this.data.Engines.FirstAsync();

            await this.service.RemoveConfigurationAsync(user.Id, configuration.Id);

            Dictionary<string, int> partsSelected = new Dictionary<string, int>()
            {
                { "turbo", 1},
                { "tcu", 1},
                { "exhaustKit", 1},
                { "supercharger", 1},
                { "ecu", 1},
                { "fuelPump", 1},
                { "injectorKit", 1},
                { "oilCooler", 1},
                { "sparkPlug", 1},
            };

            await this.service.CreateConfigurationForUserAsync(partsSelected, user.Id, configuration.Id, engine.Id);
            Assert.That(this.data.UsersConfiguration.Count, Is.EqualTo(1));
        }
        [Test]
        public async Task EditConfiguration_ShouldWork_WhenRemovingASelectedPart()
        {
            var user = await this.data.Users.FirstAsync();
            var configuration = await this.data.Configurations.FirstAsync();

            Dictionary<string, int> partsSelected = new Dictionary<string, int>()
            {
                { "turbo", 0},
                { "tcu", 1},
                { "exhaustKit", 1},
                { "supercharger", 1},
                { "ecu", 1},
                { "fuelPump", 1},
                { "injectorKit", 1},
                { "oilCooler", 1},
                { "sparkPlug", 1},
            };

            await this.service.EditConfigurationAsync(partsSelected, configuration.Id, user.Id);

            Assert.That(this.data.Configurations.First().TurboKit, Is.Null);
        }
    }
}
