using RevTech.Data.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevTech.Core.Contracts
{
    public interface IConfigurationService
    {
        public Task<UserEditConfigurationViewModel> GenerateEditViewModelAsync(int configurationId);
        public Task CreateConfigurationForUserAsync(Dictionary<string, int> selectedParts, string userId, int engineId, int carModelId);
        public UserViewModel GenerateUserConfiguration(string userId);
        public Task<UserViewModel> GenerateUserViewModelAsync(int engineId, int carModelId, string userId);
        public Task<ICollection<UserConfigurationViewModel>> GetConfigurationsForUserAsync(string userId);
        public Task RemoveConfigurationAsync(string userId, int configurationId);
        public Task EditConfigurationAsync(Dictionary<string, int> selectedParts, int configurationId, string userId);
    }
}
