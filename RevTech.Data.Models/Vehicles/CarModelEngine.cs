
namespace RevTech.Data.Models.Vehicles
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class CarModelEngine
    {
        [Required]
        [ForeignKey(nameof(CarModel))]
        public int CarModelId { get; set; }
        public virtual CarModel CarModel { get; set; } = null!;
        [Required]
        [ForeignKey(nameof(Engine))]
        public int EngineId { get; set; }
        public virtual Engine Engine { get; set; } = null!;

    }
}
