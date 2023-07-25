using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevTech.Data.ViewModels.User
{
    public class UserConfigurationViewModel
    {
        public string UserId { get; set; } = null!;
        public int ConfigurationId { get; set; }
        public string CarModelImageURL { get; set; } = null!;
        public int CarModelId { get; set; }
        public int EngineId { get; set; }
        public string CarModel { get; set; } = null!;
        public string Manufacturer { get; set; } = null!;
        public decimal Price { get; set; } 
        public int HorsePowerBoost { get; set; }
    }
}
