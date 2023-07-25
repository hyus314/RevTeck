using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RevTech.Data.Models.Vehicles;
using RevTech.Data.Seeding;

namespace RevTech.Data.Configuration
{
    public class CarModelEntityConfiguration : IEntityTypeConfiguration<CarModel>
    {
        private readonly CarModelSeeder seeder = new CarModelSeeder();
        public void Configure(EntityTypeBuilder<CarModel> builder)
        {
            builder.HasData(this.seeder.GenerateModels());
        }
    }
}
