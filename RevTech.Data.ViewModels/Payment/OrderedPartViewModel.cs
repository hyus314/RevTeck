
namespace RevTech.Data.ViewModels.Payment
{
    public class OrderedPartViewModel
    {
        public string PartType { get; set; } = null!;
        public string PartManufacturer { get; set; } = null!;
        public string PartModel { get; set; } = null!;
        public decimal PartPrice { get; set; } 
    }
}
