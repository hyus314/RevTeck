﻿using RevTech.Data.User;
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
        public Task RemoveCarModel(int carModelId);
        public Task<ICollection<AllManufacturerViewModel>> GenerateRemoveViewModels();
        public Task AddVehicleAsync(AddVehicleViewModel model);
        public bool PasswordValidation(string inputPassword);
        public Task<RevTeckUser> GetUserById(string userId);
        public Task<AddVehicleViewModel> GenerateAddViewModel();
    }
}