using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevTech.Data.ViewModels.Admin
{
    public class ManufacturerRemoveViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string ImageURL { get; set; } = null!;
        public ICollection<CarModelRemoveViewModel> Models { get; set; } = new HashSet<CarModelRemoveViewModel>();
    }
}
