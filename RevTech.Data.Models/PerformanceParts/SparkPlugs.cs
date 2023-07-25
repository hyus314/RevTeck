namespace RevTech.Data.Models.PerformanceParts
{
    using RevTech.Data.Models.Vehicles;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static RevTech.Common.EntityValidations.PerformancePart;
    public class SparkPlugs
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(ManufacturerMaxLength)]
        public string Manufacturer { get; set; } = null!;
        public decimal Price { get; set; }
        public virtual ICollection<Engine_SparkPlugKit> EngineSparkPlugKits { get; set; } = new HashSet<Engine_SparkPlugKit>();
        [Required]
        [MaxLength(MaxImageUrlLength)]
        public string ImageURL { get; set; } = null!;

    }
}
