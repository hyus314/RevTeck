using RevTech.Data.Models.PerformanceParts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevTech.Data.Seeding
{
    public class OilCoolerSeeder
    {
        public ICollection<OilCooler> GenerateOilCoolers()
        {
            var collection = new HashSet<OilCooler>();

            OilCooler current;

            current = new OilCooler()
            {
                Id = 1,
                Manufacturer = "BAR-TEK",
                Model = "Oil Cooler Kit for 1.8t",
                Price = 299.71m,
                ImageURL = "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1280/https://www.bar-tek-tuning.com/thumbnail/42/68/50/1652867207/oelkuehler_13reihen_dash_kl99c4c_1280x1280.webp"
            };

            collection.Add(current);

            current = new OilCooler()
            {
                Id = 2,
                Manufacturer = "WAGNERTUNING",
                Model = "Oil Cooler Kit for 2.7tt",
                Price = 1035.35m,
                ImageURL = "https://r-parts-store.com/media/image/product/120679/lg/wt-250001001_wagnertuning-upgrade-oil-cooler-kit-audi-rs4-b5-27biturbo.jpg"
            };

            collection.Add(current);

            current = new OilCooler()
            {
                Id = 3,
                Manufacturer = "Forge",
                Model = "Oil Cooler Kit for 4.2 FSI",
                Price = 1144.33m,
                ImageURL = "https://cdn11.bigcommerce.com/s-6y7pa5d/images/stencil/1280x1280/products/23136/24066/fmocrs4__35308.1449614047.jpg?c=2"
            };

            collection.Add(current);

            current = new OilCooler()
            {
                Id = 4,
                Manufacturer = "Bar-Tek",
                Model = "Oil Cooler Kit for 2.0 TFSI",
                Price = 544.92m,
                ImageURL = "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1280/https://www.bar-tek-tuning.com/thumbnail/5a/a4/f2/1652886657/13_reiher_ea113b5d62_1280x1280.webp"
            };

            collection.Add(current);

            current = new OilCooler()
            {
                Id = 5,
                Manufacturer = "ECSTuning",
                Model = "Universal Oil Cooler With Thermostat",
                Price = 512.95m,
                ImageURL = "https://c1552172.ssl.cf0.rackcdn.com/1509007_x450.webp"
            };

            collection.Add(current);

            return collection;
        }
    }
}
//public int Id { get; set; }
//[Required]
//[MaxLength(ManufacturerMaxLength)]
//public string Manufacturer { get; set; } = null!;
//[Required]
//[MaxLength(ModelMaxLength)]
//public string Model { get; set; } = null!;
//[Required]
//public decimal Price { get; set; }
//[Required]
//[MaxLength(MaxImageUrlLength)]
//public string ImageURL { get; set; } = null!;