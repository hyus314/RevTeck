using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RevTech.Data.Models.PerformanceParts;
using RevTech.Data.Seeding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevTech.Data.Configuration
{
    public class FuelPumpTypeEntityConfiguration : IEntityTypeConfiguration<FuelPump>
    {
        private readonly FuelPumpSeeder seeder = new FuelPumpSeeder();
        public void Configure(EntityTypeBuilder<FuelPump> builder)
        
        {
            builder.HasData(this.seeder.GenerateFuelPumps());
        }
    }
}
