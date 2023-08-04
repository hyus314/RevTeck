using Microsoft.Extensions.Configuration;
using RevTech.Core.Contracts;
using RevTech.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevTech.Core.Services
{
    public class AdminService : IAdminService
    {
        private readonly RevtechDbContext data;
        private readonly string adminPassword;
        public AdminService(RevtechDbContext data, IConfiguration configuration)
        {
            this.data = data;
            adminPassword = configuration.GetSection("Passwords")["AdminPassword"];
        }

        public bool PasswordValidation(string inputPassword)
        {
            if (inputPassword == adminPassword)
            {
                return true;
            }

            return false;
        }
    }
}
