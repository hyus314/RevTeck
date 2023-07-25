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
    public class Engine_InjectorKit_EntityTypeConfiguration : IEntityTypeConfiguration<Engine_InjectorKit>
    {
        private readonly Engine_InjectorKit_MappingSeeder seeder = new Engine_InjectorKit_MappingSeeder();
        public void Configure(EntityTypeBuilder<Engine_InjectorKit> builder)
        {
            builder.HasData(this.seeder.GenerateData());
        }
    }
}
