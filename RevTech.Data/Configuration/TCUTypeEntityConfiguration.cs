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
    public class TCUTypeEntityConfiguration : IEntityTypeConfiguration<TCUTuning>
    {
        private readonly TCUTuningSeeder seeder = new TCUTuningSeeder();
        public void Configure(EntityTypeBuilder<TCUTuning> builder)
        {
            builder.HasData(this.seeder.GenerateTCUTunings());
        }
    }
}
