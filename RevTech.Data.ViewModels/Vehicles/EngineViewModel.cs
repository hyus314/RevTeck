
namespace RevTech.Data.ViewModels.Vehicles
{
    public class EngineViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int HorsePower { get; set; }
        public int Torque { get; set; }
    }
}
