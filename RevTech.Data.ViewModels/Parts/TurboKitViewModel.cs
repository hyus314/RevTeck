namespace RevTech.Data.ViewModels.Parts
{
    public class TurboKitViewModel
    {
        public int Id { get; set; }
        public string ModelName { get; set; } = null!;
        public string Manufacturer { get; set; } = null!;
        public int HorsePowerBoost { get; set; }
        public int TorqueBoost { get; set; }
        public decimal PressureBoost { get; set; }
        public string ImageURL { get; set; } = null!;
        public decimal Price { get; set; }

    }
}
