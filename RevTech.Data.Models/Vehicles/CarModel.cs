
namespace RevTech.Data.Models.Vehicles
{
    using RevTech.Data.Models.PerformanceParts;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static RevTech.Common.EntityValidations.CarModel;
    public class CarModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(NameMaxLength)]
        public string ModelName { get; set; } = null!;
        [Required]
        public int YearCreated_Start { get; set; }
        [Required]
        public int YearCreated_End { get; set; }
        [Required]
        [ForeignKey(nameof(Manufacturer))]
        public int ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; } = null!;
        [Required]
        [MaxLength(MaxImageUrlLength)]
        public string ImageURL { get; set; } = null!;

        public virtual ICollection<CarModelEngine> CarModelEngines { get; set; } = new HashSet<CarModelEngine>();
        public virtual ICollection<ExhaustKit> ExhaustKits { get; set; } = new HashSet<ExhaustKit>();
    }
}
