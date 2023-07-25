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
                ImageURL = "https://w7.pngwing.com/pngs/115/486/png-transparent-audi-tt-car-volkswagen-group-audi-rs-6-audi-text-trademark-logo.png",
                Name = "Audi"
            };

            collection.Add(current);

            current = new Manufacturer()
            {
                Id = 2,
                ImageURL = "https://w7.pngwing.com/pngs/986/859/png-transparent-mercedes-benz-u-s-international-car-daimler-ag-mercedes-benz-angle-trademark-logo.png",
                Name = "Mercedes-Benz"
            };
            collection.Add(current);

            current = new Manufacturer()
            {
                Id = 3,
                ImageURL = "https://image.similarpng.com/very-thumbnail/2020/06/Logo-bmw-vector-transparent-PNG.png",
                Name = "BMW"
            };

            collection.Add(current);

            return collection;
        }
    }
}
