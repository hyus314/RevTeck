using RevTech.Data.ViewModels.Vehicles;

namespace RevTech.Data.ViewModels.User
{
    public class UserViewModel
    {
        public string UserId { get; set; } = null!;
        public int CarModelId { get; set; }
        public SelectedVehicleViewModel? CarModel { get; set; }
    }
}
