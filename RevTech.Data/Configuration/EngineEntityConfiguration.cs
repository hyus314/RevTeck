using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RevTech.Data.Models.Vehicles;
using RevTech.Data.Seeding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevTech.Data.Configuration
{
    public class EngineEntityConfiguration : IEntityTypeConfiguration<Engine>
    {
        private readonly EngineSeeder seeder = new EngineSeeder();
        public void Configure(EntityTypeBuilder<Engine> builder)
        {
            builder.HasData(this.seeder.GenerateEngines());
        }
    }
}
