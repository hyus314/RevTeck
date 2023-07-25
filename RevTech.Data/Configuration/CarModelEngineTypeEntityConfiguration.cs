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
    public class CarModelEngineTypeEntityConfiguration : IEntityTypeConfiguration<CarModelEngine>
    {
        private readonly CarModelEngineSeeder seeder = new CarModelEngineSeeder();
        public void Configure(EntityTypeBuilder<CarModelEngine> builder)
        {
            builder.HasData(this.seeder.GenerateEntities());
        }
    }
}
