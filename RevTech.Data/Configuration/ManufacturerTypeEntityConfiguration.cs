using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RevTech.Data.Models.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace RevTech.Data.Configuration
{
    public class ManufacturerTypeEntityConfiguration : IEntityTypeConfiguration<Manufacturer>
    {
        public void Configure(EntityTypeBuilder<Manufacturer> builder)
        {
            builder.HasData(this.SeedManufacturers());
        }
        private ICollection<Manufacturer> SeedManufacturers()
        {
            ICollection<Manufacturer> collection = new HashSet<Manufacturer>();

            Manufacturer current;

            current = new Manufacturer()
            {
                Id = 1,
                ImageURL = "https://www.freepnglogos.com/uploads/audi-logo-29.png",
                Name = "Audi"
            };

            collection.Add(current);

            current = new Manufacturer()
            {
                Id = 2,
                ImageURL = "https://www.freepnglogos.com/uploads/mercedes-logo-png/mercedes-logo-world-car-mercedes-benz-class-cdi-1.png",
                Name = "Mercedes-Benz"
            };
            collection.Add(current);

            current = new Manufacturer()
            {
                Id = 3,
                ImageURL = "https://cdn.freebiesupply.com/logos/large/2x/bmw-logo-png-transparent.png",
                Name = "BMW"
            };

            collection.Add(current);

            return collection;
        }
    }
}
