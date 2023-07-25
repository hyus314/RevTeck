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
    public class OilCoolerEntityTypeConfiguration : IEntityTypeConfiguration<OilCooler>
    {
        private readonly OilCoolerSeeder seeder = new OilCoolerSeeder();
        public void Configure(EntityTypeBuilder<OilCooler> builder)
        {
            builder.HasData(this.seeder.GenerateOilCoolers());
        }
    }
}
