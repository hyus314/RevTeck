using Microsoft.AspNetCore.Identity;
using RevTech.Data.Models.UserConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace RevTech.Data.User
{
    public class UserConfiguration
    {
        [ForeignKey(nameof(User))]
        public string UserId { get; set; } = null!;
        public virtual IdentityUser User { get; set; } = null!;
        [ForeignKey(nameof(Configuration))]
        public int ConfigurationId { get; set; }
        public virtual Models.UserConfiguration.Configuration Configuration { get; set; } = null!;
    }
}
