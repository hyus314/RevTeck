using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevTech.Data.User
{
    public class RevTeckUser : IdentityUser
    {
        public string UserName { get; set; } = null!;
    }
}
