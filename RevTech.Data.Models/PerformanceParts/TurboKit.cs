
namespace RevTech.Data.Models.PerformanceParts
{
    using RevTech.Data.Models.Vehicles;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static RevTech.Common.EntityValidations.PerformancePart;
    public class TurboKit
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(ModelMaxLength)]
        public string ModelName { get; set; } = null!;
        [Required]
        [MaxLength(ManufacturerMaxLength)]
        public string Manufacturer { get; set; } = null!;
        [Required]
        public int HorsePowerBoost { get; set; }
        public int TorqueBoost { get; set; }
        public decimal PressureBoost { get; set; }
        [Required]
        [ForeignKey(nameof(Engine))]
        public int EngineId { get; set; }
        public virtual Engine Engine { get; set; } = null!;
        [MaxLength(MaxImageUrlLength)]
        public string ImageURL { get; set; } = null!;
        [Required]
        public decimal Price { get; set; } 
    }
}
