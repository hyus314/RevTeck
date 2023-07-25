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
    public class SparkPlugKitTypeConfiguration : IEntityTypeConfiguration<SparkPlugs>
    {
        private readonly SparkPlugKitSeeder seeder = new SparkPlugKitSeeder();
        public void Configure(EntityTypeBuilder<SparkPlugs> builder)
        {
            builder.HasData(this.seeder.GenerateSparkPlugs());
        }
    }
}
