namespace RevTech.Data.Models.Vehicles
{
    using System.ComponentModel.DataAnnotations;
    using static RevTech.Common.EntityValidations.Manufacturer;
    public class Manufacturer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;
        [Required]
        [MaxLength(MaxImageUrlLength)]
        public string ImageURL { get; set; } = null!;
        public virtual ICollection<CarModel> CarModels { get; set; } = new HashSet<CarModel>();
    }
}
