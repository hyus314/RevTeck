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
    public class TurboKitEntityConfiguration : IEntityTypeConfiguration<TurboKit>
    {
        private readonly TurboKitSeeder seeder = new TurboKitSeeder();
        public void Configure(EntityTypeBuilder<TurboKit> builder)
        {
            builder.HasData(this.seeder.GenerateTurboKits());
        }
    }
}
