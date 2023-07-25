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
    public class ECU_TCU_EntityTypeConfiguration : IEntityTypeConfiguration<ECU_TCU_ConnectionTable>
    {
        private readonly ECU_TCU_MappingSeeder seeder = new ECU_TCU_MappingSeeder();
        public void Configure(EntityTypeBuilder<ECU_TCU_ConnectionTable> builder)
        {
            builder.HasData(this.seeder.GenerateData());
        }
    }
}
