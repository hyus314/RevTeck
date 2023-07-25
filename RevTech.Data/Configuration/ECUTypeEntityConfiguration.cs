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
    public class ECUTypeEntityConfiguration : IEntityTypeConfiguration<ECUTuning>
    {
        private readonly ECUTuningSeeder seeder = new ECUTuningSeeder();
        public void Configure(EntityTypeBuilder<ECUTuning> builder)
        {
            builder.HasData(seeder.GenerateECUTunings());
        }
    }
}
