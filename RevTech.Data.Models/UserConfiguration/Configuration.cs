namespace RevTech.Data.Models.UserConfiguration
{
    using RevTech.Data.Models.PerformanceParts;
    using RevTech.Data.Models.Vehicles;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Configuration
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(CarModel))]
        public int CarModelId { get; set; }
        public CarModel CarModel { get; set; } = null!;
        [ForeignKey(nameof(Engine))]
        public int EngineId { get; set; }
        public Engine Engine { get; set; } = null!;
        [ForeignKey(nameof(TurboKit))]
        public int? TurboKitId { get; set; }
        public TurboKit? TurboKit { get; set; }
        [ForeignKey(nameof(ECUTuning))]
        public int? ECUTuningId { get; set; }
        public ECUTuning? ECUTuning { get; set; }
        [ForeignKey(nameof(ExhaustKit))]
        public int? ExhaustKitId { get; set; }
        public ExhaustKit? ExhaustKit { get; set; }
        [ForeignKey(nameof(FuelPump))]
        public int? FuelPumpId { get; set; }
        public FuelPump? FuelPump { get; set; }
        [ForeignKey(nameof(InjectorKit))]
        public int? InjectorKitId { get; set; }
        public InjectorKit? InjectorKit { get; set; }
        [ForeignKey(nameof(OilCooler))]
        public int? OilCoolerId { get; set; }
        public OilCooler? OilCooler { get; set; }
        [ForeignKey(nameof(SparkPlugs))]
        public int? SparkPlugsId { get; set; }
        public SparkPlugs? SparkPlugs { get; set; }
        [ForeignKey(nameof(SuperchargerKit))]
        public int? SuperchargerKitId { get; set; }
        public SuperchargerKit? SuperchargerKit { get; set; }
        [ForeignKey(nameof(TCUTuning))]
        public int? TCUTuningId { get; set; }
        public TCUTuning? TCUTuning { get; set; }
        public decimal TotalPrice { get; set; }
        public int HorsePowerBoostTotal { get; set; }
        public int TorqueBoostTotal { get; set; }
    }

}
