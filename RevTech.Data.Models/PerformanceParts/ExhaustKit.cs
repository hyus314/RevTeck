
namespace RevTech.Data.Models.PerformanceParts
{
    using RevTech.Data.Models.Vehicles;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static RevTech.Common.EntityValidations.PerformancePart;
    public class ExhaustKit
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
        public int HorsePowerBoost { get; set; }
        [Required]
        public int TorqueBoost{ get; set; }
        [Required]
        [MaxLength(MaxImageUrlLength)]
        public string ImageURL { get; set; } = null!;
        [Required]
        [ForeignKey(nameof(Engine))]
        public int EngineId { get; set; }
        public virtual Engine Engine { get; set; } = null!;
        [Required]
        [ForeignKey(nameof(CarModel))]
        public int CarModelId { get; set; }
        public virtual CarModel CarModel { get; set; } = null!;
    }
}
