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
    public class InjectorKitTypeEntityConfiguration : IEntityTypeConfiguration<InjectorKit>
    {
        private readonly InjectorKitSeeder seeder = new InjectorKitSeeder();
        public void Configure(EntityTypeBuilder<InjectorKit> builder)
        {
            builder.HasData(this.seeder.GenerateInjectorKits());
        }
    }
}
