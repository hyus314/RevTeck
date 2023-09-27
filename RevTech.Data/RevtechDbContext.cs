namespace RevTech.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using RevTech.Data.Models.PerformanceParts;
    using RevTech.Data.Models.Vehicles;
    using RevTech.Data.User;
    using RevTech.Data.Configuration;
    using System.Reflection.Emit;

    public class RevtechDbContext : IdentityDbContext<RevTeckUser>
    {
        public RevtechDbContext(DbContextOptions<RevtechDbContext> options)
            : base(options)
        {
        }
        public DbSet<UserConfiguration> UsersConfiguration { get; set; } = null!;
        public DbSet<CarModelEngine> CarModelsEngines { get; set; } = null!;
        public DbSet<CarModel> CarModels { get; set; } = null!;
        public DbSet<Engine> Engines { get; set; } = null!;
        public DbSet<Manufacturer> Manufacturers { get; set; } = null!;
        public DbSet<ECUTuning> ECUTunings { get; set; } = null!;
        public DbSet<ExhaustKit> ExhaustKits { get; set; } = null!;
        public DbSet<FuelPump> FuelPumps { get; set; } = null!;
        public DbSet<InjectorKit> InjectorKits { get; set; } = null!;
        public DbSet<OilCooler> OilCoolers { get; set; } = null!;
        public DbSet<SparkPlugs> SparkPlugsKits { get; set; } = null!;
        public DbSet<SuperchargerKit> SuperchargerKits { get; set; } = null!;
        public DbSet<TCUTuning> TCUTunings { get; set; } = null!;
        public DbSet<TurboKit> TurboKits { get; set; } = null!;
        public DbSet<UserPayment> Payments { get; set; } = null!;
        public DbSet<Models.UserConfiguration.Configuration> Configurations { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<ECUTuning>()
           .Property(p => p.Price)
           .HasPrecision(18, 2);

            builder.Entity<ExhaustKit>()
         .Property(p => p.Price)
         .HasPrecision(18, 2);

            builder.Entity<InjectorKit>()
                .Property(p => p.Price)
                .HasPrecision(18, 2);

            builder.Entity<FuelPump>()
         .Property(p => p.Price)
         .HasPrecision(18, 2);

            builder.Entity<OilCooler>()
         .Property(p => p.Price)
         .HasPrecision(18, 2);

            builder.Entity<SparkPlugs>()
         .Property(p => p.Price)
         .HasPrecision(18, 2);

            builder.Entity<SuperchargerKit>()
         .Property(p => p.Price)
         .HasPrecision(18, 2);

            builder.Entity<TurboKit>()
         .Property(p => p.Price)
         .HasPrecision(18, 2);

            builder.Entity<Models.UserConfiguration.Configuration>()
      .Property(p => p.TotalPrice)
      .HasPrecision(18, 2);

            builder.Entity<TurboKit>()
     .Property(p => p.PressureBoost)
     .HasPrecision(3, 1);

            builder.Entity<UserConfiguration>()
                  .HasKey(uvc => new { uvc.UserId, uvc.ConfigurationId });

            builder.Entity<CarModelEngine>()
                 .HasKey(cme => new { cme.CarModelId, cme.EngineId });

            builder.Entity<TurboKit>()
       .HasOne(c => c.Engine)
       .WithMany(p => p.TurboKits)
       .HasForeignKey(c => c.EngineId);


            builder.Entity<UserConfiguration>()
                .HasOne(a => a.Configuration)
                .WithMany() 
                .HasForeignKey(a => a.ConfigurationId);

            builder.Entity<UserPayment>()
     .HasOne(e => e.Client)
     .WithMany() 
     .HasForeignKey(e => e.ClientId)
     .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<UserPayment>()
        .Property(p => p.Amount)
        .HasPrecision(18, 2);

            builder.Entity<UserPayment>()
                .HasOne(e => e.Configuration)
                .WithOne() 
                .HasForeignKey<UserPayment>(e => e.ConfigurationId)
                .OnDelete(DeleteBehavior.Cascade); 


            builder.ApplyConfiguration(new ManufacturerTypeEntityConfiguration());
            builder.ApplyConfiguration(new CarModelEntityConfiguration());
            builder.ApplyConfiguration(new EngineEntityConfiguration());
            builder.ApplyConfiguration(new TurboKitEntityConfiguration());
            builder.ApplyConfiguration(new SuperchargerKitEntityConfiguration());
            builder.ApplyConfiguration(new CarModelEngineTypeEntityConfiguration());
            builder.ApplyConfiguration(new ECUTypeEntityConfiguration());
            builder.ApplyConfiguration(new TCUTypeEntityConfiguration());
            builder.ApplyConfiguration(new ExhaustKitEntityTypeConfiguration());
            builder.ApplyConfiguration(new FuelPumpTypeEntityConfiguration());
            builder.ApplyConfiguration(new InjectorKitTypeEntityConfiguration());
            builder.ApplyConfiguration(new OilCoolerEntityTypeConfiguration());
            builder.ApplyConfiguration(new SparkPlugKitTypeConfiguration());

            base.OnModelCreating(builder);
        }
    }
}