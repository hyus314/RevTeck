using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevTech.Core.Contracts
{

    public interface IAdminService
    {
        public Task<bool> PasswordValidation(string inputPassword);
    }
}
