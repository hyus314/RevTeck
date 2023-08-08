
using RevTech.Data.ViewModels.Vehicles;

namespace RevTech.Data.ViewModels.Admin
{
    public class EditVehicleViewModel
    {
        public int Id { get; set; }
        public string ModelName { get; set; } = null!;
        public int YearCreated_Start { get; set; }
        public int YearCreated_End { get; set; }
        public int ManufacturerId { get; set; }
        public string ImageURL { get; set; } = null!;
        public ICollection<ManufacturerViewModel> Manufacturers { get; set; } = new HashSet<ManufacturerViewModel>();
    }
}
