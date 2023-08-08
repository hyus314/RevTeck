using RevTech.Data.User;
using RevTech.Data.ViewModels.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevTech.Core.Contracts
{

    public interface IAdminService
    {
        public Task EditVehicleAsync(EditVehicleViewModel model);
        public Task<EditVehicleViewModel> GenerateEditViewModelAsync(int carModelId);
        public Task RemoveCarModelAsync(int carModelId);
        public Task<ICollection<AllManufacturerViewModel>> GenerateAllViewModelsAsync();
        public Task AddVehicleAsync(AddVehicleViewModel model);
        public bool PasswordValidation(string inputPassword);
        public Task<RevTeckUser> GetUserByIdAsync(string userId);
        public Task<AddVehicleViewModel> GenerateAddViewModelAsync();
    }
}
