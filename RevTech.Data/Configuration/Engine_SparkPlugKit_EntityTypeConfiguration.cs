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
    public class Engine_SparkPlugKit_EntityTypeConfiguration : IEntityTypeConfiguration<Engine_SparkPlugKit>
    {
        private readonly Engine_SparkPlugKit_MappingSeeder seeder = new Engine_SparkPlugKit_MappingSeeder();
        public void Configure(EntityTypeBuilder<Engine_SparkPlugKit> builder)
        {
            builder.HasData(seeder.GenerateData());
        }

    }
}
