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
    public class Engine_OilCooler_EntityTypeConfiguration : IEntityTypeConfiguration<Engine_OilCooler>
    {
        private readonly Engine_OilCooler_MappingSeeder seeder = new Engine_OilCooler_MappingSeeder();
        public void Configure(EntityTypeBuilder<Engine_OilCooler> builder)
        {
            builder.HasData(this.seeder.GenerateData());
        }
    }
}
