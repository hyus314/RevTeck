namespace RevTech.Core.Services
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using RevTech.Core.Contracts;
    using RevTech.Data;
    using RevTech.Data.Models.Vehicles;
    using RevTech.Data.User;
    using RevTech.Data.ViewModels.Admin;
    using RevTech.Data.ViewModels.Vehicles;
    public class AdminService : IAdminService
    {
        private readonly RevtechDbContext data;
        private readonly string adminPassword;
        public AdminService(RevtechDbContext data, IConfiguration configuration)
        {
            this.data = data;
            adminPassword = configuration.GetSection("Passwords")["AdminPassword"];
        }

        public async Task AddVehicleAsync(AddVehicleViewModel model)
        {
            var car = new CarModel()
            {
                ManufacturerId = model.ManufacturerId,
                ModelName = model.ModelName,
                YearCreated_Start = model.YearCreated_Start,
                YearCreated_End = model.YearCreated_End,
                ImageURL = model.ImageURL
            };

            await this.data.CarModels.AddAsync(car);
            await this.data.SaveChangesAsync();
        }

        public async Task EditVehicleAsync(EditVehicleViewModel model)
        {
            var entity = await this.data.CarModels.FindAsync(model.Id);

            entity.ImageURL = model.ImageURL;
            entity.ManufacturerId = model.ManufacturerId;
            entity.ModelName = model.ModelName;
            entity.YearCreated_End = model.YearCreated_End;
            entity.YearCreated_Start = model.YearCreated_Start;

            await this.data.SaveChangesAsync();
        }

        public async Task<AddVehicleViewModel> GenerateAddViewModelAsync()
        {
            var manufacturers = await this.data.Manufacturers
                .Select(x => new ManufacturerViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    ImageURL = x.ImageURL
                })
                .ToArrayAsync();

            var model = new AddVehicleViewModel()
            {
                Manufacturers = manufacturers
            };

            return model;

        }

        public async Task<EditVehicleViewModel> GenerateEditViewModelAsync(int carModelId)
        {
            var manufacturers = await this.data.Manufacturers
               .Select(x => new ManufacturerViewModel()
               {
                   Id = x.Id,
                   Name = x.Name,
                   ImageURL = x.ImageURL
               })
               .ToArrayAsync();
            var entity = await this.data.CarModels.FindAsync(carModelId);

            var model = new EditVehicleViewModel()
            {
                Id = entity.Id,
                ModelName = entity.ModelName,
                ManufacturerId = entity.ManufacturerId,
                YearCreated_Start = entity.YearCreated_Start,
                YearCreated_End = entity.YearCreated_End,
                ImageURL = entity.ImageURL,
                Manufacturers = manufacturers
            };

            return model;
        }

        public async Task<ICollection<AllManufacturerViewModel>> GenerateAllViewModelsAsync()
        {
            var manufacturers = await this.data.Manufacturers
                .AsNoTracking()
                .Select(x => new AllManufacturerViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    ImageURL = x.ImageURL,
                    Models = this.data.CarModels
                .AsNoTracking()
                .Where(y => y.ManufacturerId == x.Id)
                .Select(z => new AllCarModelViewModel()
                {
                    Id = z.Id,
                    ManufacturerId = z.ManufacturerId,
                    ModelName = z.ModelName,
                    YearCreated_End = z.YearCreated_End,
                    YearCreated_Start = z.YearCreated_Start,
                    ImageURL = z.ImageURL
                }).ToArray()

                }).ToArrayAsync();

            return manufacturers;
        }

        public async Task<RevTeckUser> GetUserByIdAsync(string userId)
        {
            return await this.data.Users.FirstOrDefaultAsync(x => x.Id == userId);

        }

        public bool PasswordValidation(string inputPassword)
        {
            if (inputPassword == adminPassword)
            {
                return true;
            }

            return false;
        }

        public async Task RemoveCarModelAsync(int carModelId)
        {
            var carModel = await this.data.CarModels.FindAsync(carModelId);
            this.data.CarModels.Remove(carModel!);
            await this.data.SaveChangesAsync();
        }
    }
}
