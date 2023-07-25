namespace RevTech.Data.ViewModels.Vehicles
{
    public class CarModelViewModel
    {
        public int Id { get; set; }
        public string ModelName { get; set; } = null!;
        public int YearCreated_Start { get; set; }
        public int YearCreated_End { get; set; }
        public string ManufacturerName { get; set; } = null!;
        public string ImageURL { get; set; } = null!;

    }
}
