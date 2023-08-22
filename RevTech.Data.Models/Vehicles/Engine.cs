namespace RevTech.Data.Models.Vehicles
{
    using RevTech.Data.Models.PerformanceParts;
    using RevTech.Data.Models.Vehicles;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static RevTech.Common.EntityValidations.Engine;
    public class Engine
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;
        public int HorsePower { get; set; }
        public int Torque { get; set; }
        public virtual ICollection<TurboKit> TurboKits { get; set; } = new HashSet<TurboKit>();
        public virtual ICollection<CarModelEngine> CarModelEngines { get; set; } = new HashSet<CarModelEngine>();
        public virtual ICollection<ECUTuning> ECUTunings { get; set; } = new HashSet<ECUTuning>();
        public virtual ICollection<ExhaustKit> ExhaustKits { get; set; } = new HashSet<ExhaustKit>();
        public virtual ICollection<FuelPump> FuelPumps { get; set; } = new HashSet<FuelPump>();
        public virtual ICollection<Engine_InjectorKit> EngineInjectorKits { get; set; } = new HashSet<Engine_InjectorKit>();
        public virtual ICollection<Engine_OilCooler> EngineOilCoolers { get; set; } = new HashSet<Engine_OilCooler>();
        public virtual ICollection<Engine_SparkPlugKit> EngineSparkPlugs { get; set; } = new HashSet<Engine_SparkPlugKit>();
        public virtual ICollection<SuperchargerKit> SuperchargerKits { get; set; } = new HashSet<SuperchargerKit>();

    }
}
