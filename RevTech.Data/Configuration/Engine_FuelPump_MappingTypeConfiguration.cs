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
    public class Engine_FuelPump_MappingTypeConfiguration : IEntityTypeConfiguration<Engine_FuelPump>
    {
        private readonly Engine_FuelPump_MappingTableSeeder seeder = new Engine_FuelPump_MappingTableSeeder();
        public void Configure(EntityTypeBuilder<Engine_FuelPump> builder)
        {
            builder.HasData(this.seeder.GenerateData());
        }
    }
}
