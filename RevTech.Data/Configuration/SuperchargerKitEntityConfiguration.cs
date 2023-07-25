using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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
    public class SuperchargerKitEntityConfiguration : IEntityTypeConfiguration<SuperchargerKit>
    {
        private readonly SuperchargerKitSeeder seeder = new SuperchargerKitSeeder();
        public void Configure(EntityTypeBuilder<SuperchargerKit> builder)
        {
            builder.HasData(this.seeder.GenerateSuperchargers());
        }

    }
}
