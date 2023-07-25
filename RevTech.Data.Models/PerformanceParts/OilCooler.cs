namespace RevTech.Data.Models.PerformanceParts
{
    using RevTech.Data.Models.Vehicles;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static RevTech.Common.EntityValidations.PerformancePart;
    public class OilCooler
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(ManufacturerMaxLength)]
        public string Manufacturer { get; set; } = null!;
        [Required]
        [MaxLength(ModelMaxLength)]
        public string Model { get; set; } = null!;
        [Required]
        public decimal Price { get; set; }
        [Required]
        [MaxLength(MaxImageUrlLength)]
        public string ImageURL { get; set; } = null!;
        public virtual ICollection<Engine_OilCooler> EngineOilCoolers { get; set; } = new HashSet<Engine_OilCooler>();
    }
}
