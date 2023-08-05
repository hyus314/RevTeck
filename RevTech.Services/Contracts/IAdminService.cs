using RevTech.Data.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevTech.Core.Contracts
{

    public interface IAdminService
    {
        public bool PasswordValidation(string inputPassword);
        public Task<RevTeckUser> GetUserById(string userId);
    }
}
