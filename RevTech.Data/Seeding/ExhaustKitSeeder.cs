using RevTech.Data.Models.PerformanceParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevTech.Data.Seeding
{
    public class ExhaustKitSeeder
    {
        public ICollection<ExhaustKit> GenerateExhausts()
        {
            ICollection<ExhaustKit> collection = new HashSet<ExhaustKit>();

            ExhaustKit current;

            current = new ExhaustKit()
            {
                Id = 1,
                Manufacturer = "Jetex",
                Model = "1.8t A6 C5 Exhaust Kit",
                Price = 800.85m,
                HorsePowerBoost = 10,
                TorqueBoost = 20,
                ImageURL = "https://www.dcperformance.co.uk/images/products/wm/a9fa2e54659e70c582722017b3c60776.jpg",
                EngineId = 1,
                CarModelId = 1,
            };

            collection.Add(current);

            current = new ExhaustKit()
            {
                Id = 2,
                Manufacturer = "Jetex",
                Model = "1.8t A6 C5 Exhaust Kit",
                Price = 800.85m,
                HorsePowerBoost = 10,
                TorqueBoost = 20,
                ImageURL = "https://www.dcperformance.co.uk/images/products/wm/a9fa2e54659e70c582722017b3c60776.jpg",
                EngineId = 3,
                CarModelId = 1,
            };

            collection.Add(current);

            current = new ExhaustKit()
            {
                Id = 3,
                Manufacturer = "B&B",
                Model = "2.7t A6 C5 Exhaust Kit",
                Price = 1292.40m,
                HorsePowerBoost = 15,
                TorqueBoost = 30,
                ImageURL = "https://www.vividracing.com/images/bbexhaust-a6-catback.jpg",
                EngineId = 4,
                CarModelId = 1,
            };

            collection.Add(current);

            current = new ExhaustKit()
            {
                Id = 4,
                Manufacturer = "B&B",
                Model = "2.7t A6 C5 Exhaust Kit",
                Price = 1292.40m,
                HorsePowerBoost = 15,
                TorqueBoost = 30,
                ImageURL = "https://www.vividracing.com/images/bbexhaust-a6-catback.jpg",
                EngineId = 5,
                CarModelId = 1,
            };

            collection.Add(current);

            current = new ExhaustKit()
            {
                Id = 5,
                Manufacturer = "Milltek",
                Model = "2.7t A6 C5 Exhaust Kit",
                Price = 1800.00m,
                HorsePowerBoost = 17,
                TorqueBoost = 35,
                ImageURL = "https://c1552172.ssl.cf0.rackcdn.com/697789_x450.webp",
                EngineId = 4,
                CarModelId = 1,
            };

            collection.Add(current);

            current = new ExhaustKit()
            {
                Id = 6,
                Manufacturer = "Milltek",
                Model = "2.7t A6 C5 Exhaust Kit",
                Price = 1800.00m,
                HorsePowerBoost = 17,
                TorqueBoost = 35,
                ImageURL = "https://c1552172.ssl.cf0.rackcdn.com/697789_x450.webp",
                EngineId = 5,
                CarModelId = 1,
            };

            collection.Add(current);

            current = new ExhaustKit()
            {
                Id = 7,
                Manufacturer = "Simons",
                Model = "1.8t A4 B5 Exhaust Kit",
                Price = 681.20m,
                HorsePowerBoost = 10,
                TorqueBoost = 20,
                ImageURL = "https://en.bsr.se/assets/images/products/big/737962_big.jpg",
                EngineId = 1,
                CarModelId = 2,
            };

            collection.Add(current);

            current = new ExhaustKit()
            {
                Id = 8,
                Manufacturer = "Simons",
                Model = "1.8t A4 B5 Exhaust Kit",
                Price = 681.20m,
                HorsePowerBoost = 10,
                TorqueBoost = 20,
                ImageURL = "https://en.bsr.se/assets/images/products/big/737962_big.jpg",
                EngineId = 3,
                CarModelId = 2,
            };

            collection.Add(current);

            current = new ExhaustKit()
            {
                Id = 9,
                Manufacturer = "Jetex",
                Model = "1.8t A4 B5 Exhaust Kit",
                Price = 528.14m,
                HorsePowerBoost = 10,
                TorqueBoost = 20,
                ImageURL = "https://i.ebayimg.com/images/g/1jAAAOSwXGxgQND4/s-l1600.jpg",
                EngineId = 1,
                CarModelId = 2,
            };

            collection.Add(current);

            current = new ExhaustKit()
            {
                Id = 10,
                Manufacturer = "Jetex",
                Model = "1.8t A4 B5 Exhaust Kit",
                Price = 528.14m,
                HorsePowerBoost = 10,
                TorqueBoost = 20,
                ImageURL = "https://i.ebayimg.com/images/g/1jAAAOSwXGxgQND4/s-l1600.jpg",
                EngineId = 3,
                CarModelId = 2,
            };

            collection.Add(current);

            current = new ExhaustKit()
            {
                Id = 11,
                Manufacturer = "Billy Boat Exhaust",
                Model = "2.7tt S4 B5 Exhaust Kit",
                Price = 1579.93m,
                HorsePowerBoost = 10,
                TorqueBoost = 20,
                ImageURL = "https://www.bbexhaust.com/wp-content/uploads/2016/05/FPIM-0530-2.jpg",
                EngineId = 4,
                CarModelId = 3,
            };

            collection.Add(current);

            current = new ExhaustKit()
            {
                Id = 12,
                Manufacturer = "Milltek",
                Model = "4.2FSI RS4 B7 Exhaust Kit",
                Price = 2234.31m,
                HorsePowerBoost = 20,
                TorqueBoost = 40,
                ImageURL = "https://cmwheels.com/wp-content/uploads/2018/01/products-SSXAU116.jpg",
                EngineId = 6,
                CarModelId = 5,
            };

            collection.Add(current);

            current = new ExhaustKit()
            {
                Id = 13,
                Manufacturer = "Milltek",
                Model = "4.2FSI RS4 B7 Exhaust Kit",
                Price = 1816.85m,
                HorsePowerBoost = 15,
                TorqueBoost = 30,
                ImageURL = "https://media.vwpartsinternational.com/wp-content/uploads/2018/05/21162655/Audi-RS4-B7-4.2-V8-Saloon-Avant-Milltek-Sport-Performance-Non-Resonated-Cat-Back-Exhaust-System-Inc-Satin-Sheen-Black-Tips-SSXAU218.jpeg",
                EngineId = 6,
                CarModelId = 5,
            };

            collection.Add(current);

            current = new ExhaustKit()
            {
                Id = 14,
                Manufacturer = "Milltek",
                Model = "4.2FSI S5 B8 Exhaust Kit",
                Price = 1105.44m,
                HorsePowerBoost = 15,
                TorqueBoost = 30,
                ImageURL = "https://cmwheels.com/wp-content/uploads/2018/04/SSXAU190.jpg",
                EngineId = 7,
                CarModelId = 6,
            };

            collection.Add(current);

            current = new ExhaustKit()
            {
                Id = 15,
                Manufacturer = "Milltek",
                Model = "4.2FSI S5 B8.5 Exhaust Kit",
                Price = 1105.44m,
                HorsePowerBoost = 15,
                TorqueBoost = 30,
                ImageURL = "https://cmwheels.com/wp-content/uploads/2018/04/SSXAU190.jpg",
                EngineId = 7,
                CarModelId = 7,
            };

            collection.Add(current);

            current = new ExhaustKit()
            {
                Id = 16,
                Manufacturer = "Milltek",
                Model = "3.0TFSI S5 B8.5 Exhaust Kit",
                Price = 2726.91m,
                HorsePowerBoost = 15,
                TorqueBoost = 30,
                ImageURL = "https://clptuning.co.uk/product/milltek-cat-back-exhaust-system-audi-s4-s5-b8-5-3-0tfsi/",
                EngineId = 14,
                CarModelId = 7,
            };

            collection.Add(current);

            current = new ExhaustKit()
            {
                Id = 17,
                Manufacturer = "Armytrix",
                Model = "4.2 FSI RS5 B8.5 VALVETRONIC Exhaust Kit",
                Price = 5440.69m,
                HorsePowerBoost = 13,
                TorqueBoost = 15,
                ImageURL = "https://www.armytrix.com/cdn/800_530_80_ff_cdn/audi-rs5-b8/audi-rs5-v8-exhaust-16.jpg",
                EngineId = 6,
                CarModelId = 8,
            };

            collection.Add(current);

            current = new ExhaustKit()
            {
                Id = 18,
                Manufacturer = "Milltek",
                Model = "4.2 FSI RS5 B8.5 Exhaust Kit",
                Price = 3341.50m,
                HorsePowerBoost = 13,
                TorqueBoost = 15,
                ImageURL = "https://clptuning.co.uk/wp-content/uploads/2018/01/SSXAU261_1-300x300.jpg",
                EngineId = 6,
                CarModelId = 8,
            };

            collection.Add(current);

            current = new ExhaustKit()
            {
                Id = 19,
                Manufacturer = "SuperSprint",
                Model = "4.2 FSI A6 C6 Centre Exhaust + X-Pipe",
                Price = 1665.06m,
                HorsePowerBoost = 5,
                TorqueBoost = 9,
                ImageURL = "https://balancemotorsport.co.uk/media/catalog/product/cache/58eb3c1ce7095e93eebc6663a89e40bb/4/4/44534_1.jpg",
                EngineId = 8,
                CarModelId = 9,
            };

            collection.Add(current);

            current = new ExhaustKit()
            {
                Id = 20,
                Manufacturer = "SuperSprint",
                Model = "3.0 TFSI A6 C6 Centre Exhaust + X-Pipe",
                Price = 1581.80m,
                HorsePowerBoost = 5,
                TorqueBoost = 9,
                ImageURL = "https://balancemotorsport.co.uk/media/catalog/product/cache/58eb3c1ce7095e93eebc6663a89e40bb/4/4/44534_1.jpg",
                EngineId = 15,
                CarModelId = 9,
            };

            collection.Add(current);

            current = new ExhaustKit()
            {
                Id = 21,
                Manufacturer = "JHM",
                Model = "3.0 TFSI A6 C6 Cat Back Exhaust",
                Price = 1750.59m,
                HorsePowerBoost = 7,
                TorqueBoost = 10,
                ImageURL = "https://cdn11.bigcommerce.com/s-ov4aejck1y/images/stencil/1920w/products/296179/35616535/840756122694944651_jhm-c6a630tcbe-thmb__05028.1668196184.jpg?c=1",
                EngineId = 15,
                CarModelId = 9,
            };

            collection.Add(current);

            current = new ExhaustKit()
            {
                Id = 22,
                Manufacturer = "Milltek",
                Model = "2.0 TFSI A4 B7 Cat Back Exhaust",
                Price = 1524.78m,
                HorsePowerBoost = 5,
                TorqueBoost = 8,
                ImageURL = "https://www.milltekexhaust-roadrunnermotorsport.co.uk/30048-large_default/milltek-exhaust-audi-a4-2-0-tfsi-b7-quattro-and-dtm-cat-back-exhaust-ssxau517.jpg",
                EngineId = 9,
                CarModelId = 10,
            };

            collection.Add(current);

            current = new ExhaustKit()
            {
                Id = 23,
                Manufacturer = "Jetex",
                Model = "2.0 TFSI A4 B7 Half Exhaust Kit",
                Price = 773.83m,
                HorsePowerBoost = 5,
                TorqueBoost = 8,
                ImageURL = "https://media.vwpartsinternational.com/wp-content/uploads/2018/03/14235412/Audi-A4-B7-1.8T-2.0TFSI-Quattro-Jetex-Performance-Stainless-Steel-Resonated-Half-Exhaust-System-with-Round-100mm-LR-Tail-Pipes-EC-44DH5R-416x258.jpg",
                EngineId = 9,
                CarModelId = 10,
            };

            collection.Add(current);

            current = new ExhaustKit()
            {
                Id = 24,
                Manufacturer = "Ferrita",
                Model = "2.0 TFSI A4 B7 Exhaust Kit",
                Price = 1144.67m,
                HorsePowerBoost = 7,
                TorqueBoost = 11,
                ImageURL = "https://en.bsr.se/assets/images/products/big/4383_big.jpg",
                EngineId = 9,
                CarModelId = 10,
            };

            collection.Add(current);


            current = new ExhaustKit()
            {
                Id = 25,
                Manufacturer = "Milltek",
                Model = "2.0 TFSI A4 B7 Cat Back Exhaust",
                Price = 1524.78m,
                HorsePowerBoost = 5,
                TorqueBoost = 8,
                ImageURL = "https://www.milltekexhaust-roadrunnermotorsport.co.uk/30048-large_default/milltek-exhaust-audi-a4-2-0-tfsi-b7-quattro-and-dtm-cat-back-exhaust-ssxau517.jpg",
                EngineId = 10,
                CarModelId = 11,
            };

            collection.Add(current);

            current = new ExhaustKit()
            {
                Id = 26,
                Manufacturer = "Jetex",
                Model = "2.0 TFSI A4 B7 Half Exhaust Kit",
                Price = 773.83m,
                HorsePowerBoost = 5,
                TorqueBoost = 8,
                ImageURL = "https://media.vwpartsinternational.com/wp-content/uploads/2018/03/14235412/Audi-A4-B7-1.8T-2.0TFSI-Quattro-Jetex-Performance-Stainless-Steel-Resonated-Half-Exhaust-System-with-Round-100mm-LR-Tail-Pipes-EC-44DH5R-416x258.jpg",
                EngineId = 10,
                CarModelId = 11,
            };

            collection.Add(current);

            current = new ExhaustKit()
            {
                Id = 27,
                Manufacturer = "Ferrita",
                Model = "2.0 TFSI A4 B7 Exhaust Kit",
                Price = 1144.67m,
                HorsePowerBoost = 7,
                TorqueBoost = 11,
                ImageURL = "https://en.bsr.se/assets/images/products/big/4383_big.jpg",
                EngineId = 10,
                CarModelId = 11,
            };

            collection.Add(current);

            current = new ExhaustKit()
            {
                Id = 28,
                Manufacturer = "TNEER",
                Model = "4.0 TFSI S6 C7 Exhaust Kit",
                Price = 7513.22m,
                HorsePowerBoost = 15,
                TorqueBoost = 20,
                ImageURL = "https://cdn.shopify.com/s/files/1/0070/1779/1577/products/DSC01072_53eeb7bc-42ea-4166-837b-1b16ee4022d2_1200x1200.jpg?v=1590075728",
                EngineId = 11,
                CarModelId = 12,
            };

            collection.Add(current);

            current = new ExhaustKit()
            {
                Id = 29,
                Manufacturer = "APR",
                Model = "4.0 TFSI S6 C7 Cat Back Exhaust ",
                Price = 3500.00m,
                HorsePowerBoost = 15,
                TorqueBoost = 20,
                ImageURL = "https://cdn.shopify.com/s/files/1/2493/0960/products/a9f1f012a32f87a8ca5b762158af25b7.jpg?v=1610140343",
                EngineId = 11,
                CarModelId = 12,
            };

            collection.Add(current);

            current = new ExhaustKit()
            {
                Id = 30,
                Manufacturer = "Akrapovic",
                Model = "4.0 TFSI RS6 C7 Cat Back Exhaust",
                Price = 10417.38m,
                HorsePowerBoost = 20,
                TorqueBoost = 25,
                ImageURL = "https://www.wrsauto.it/161-thickbox_default/akrapovic-evolution-exhaust-system-audi-rs6-avant-c7-2014-2018.jpg",
                EngineId = 12,
                CarModelId = 13,
            };

            collection.Add(current);

            current = new ExhaustKit()
            {
                Id = 31,
                Manufacturer = "Armytrix",
                Model = "4.0 TFSI RS6 C7 VALVETRONIC Exhaust Kit",
                Price = 7604.22m,
                HorsePowerBoost = 15,
                TorqueBoost = 25,
                ImageURL = "https://www.armytrix.com/cdn/800_530_80_ff_cdn/audi-rs6-rs7/audi-rs6-c7-armytrix-exhaust-1.jpg",
                EngineId = 12,
                CarModelId = 13,
            };

            collection.Add(current);

            current = new ExhaustKit()
            {
                Id = 32,
                Manufacturer = "FI",
                Model = "4.0 TFSI S7 C7 VALVETRONIC Exhaust Kit",
                Price = 4500.99m,
                HorsePowerBoost = 10,
                TorqueBoost = 15,
                ImageURL = "https://germanmuscle.co/wp-content/uploads/2022/05/FI-Exhaust-2012-2017-Audi-S6-C7-4.0T-Valvetronic-Exhaust-System-1.jpg",
                EngineId = 11,
                CarModelId = 16,
            };

            collection.Add(current);

            current = new ExhaustKit()
            {
                Id = 33,
                Manufacturer = "Akrapovic",
                Model = "4.0 TFSI S7 C7 VALVETRONIC Exhaust Kit",
                Price = 10344.74m,
                HorsePowerBoost = 10,
                TorqueBoost = 15,
                ImageURL = "https://www.futurez.fi/wp-content/uploads/76ae3060571a43ba82ef55d2f9617482-1.png",
                EngineId = 11,
                CarModelId = 16,
            };

            collection.Add(current);

            current = new ExhaustKit()
            {
                Id = 34,
                Manufacturer = "Armytrix",
                Model = "4.0 TFSI RS7 C7 VALVETRONIC Exhaust Kit",
                Price = 7804.22m,
                HorsePowerBoost = 10,
                TorqueBoost = 15,
                ImageURL = "https://www.armytrix.com/cdn/800_530_80_ff_cdn/audi-rs7/audi-rs7-c7-armytrix-exhaust-9.jpg",
                EngineId = 12,
                CarModelId = 17,
            };

            collection.Add(current);

            current = new ExhaustKit()
            {
                Id = 35,
                Manufacturer = "Akrapovic",
                Model = "4.0 TFSI RS7 C7 VALVETRONIC Exhaust Kit",
                Price = 11042.88m,
                HorsePowerBoost = 10,
                TorqueBoost = 15,
                ImageURL = "https://www.motorsport24.nl/wp-content/uploads/2022/04/SAUTI4H-1.png",
                EngineId = 12,
                CarModelId = 17,
            };

            collection.Add(current);

            current = new ExhaustKit()
            {
                Id = 36,
                Manufacturer = "Milltek",
                Model = "4.0 TFSI S8 D4 Exhaust Kit",
                Price = 11042.88m,
                HorsePowerBoost = 10,
                TorqueBoost = 15,
                ImageURL = "https://dtm-tuning.com/image/cache/catalog/goods_ad_eqip/milltek/a8-d4/milltek-ssxau466_1-1000x690.jpg",
                EngineId = 12,
                CarModelId = 14,
            };

            collection.Add(current);

            current = new ExhaustKit()
            {
                Id = 37,
                Manufacturer = "Capristo",
                Model = "4.0 TFSI S8 D4 Cat Back Exhaust",
                Price = 7300.00m,
                HorsePowerBoost = 10,
                TorqueBoost = 15,
                ImageURL = "https://cdn.capristoexhaust.com/wp-content/uploads/sites/3/IMG_0710-Audi-S8-20171109-600x400.jpg",
                EngineId = 12,
                CarModelId = 14,
            };

            collection.Add(current);

            current = new ExhaustKit()
            {
                Id = 38,
                Manufacturer = "Milltek",
                Model = "4.0 TFSI S8 D4 Exhaust Kit",
                Price = 11042.88m,
                HorsePowerBoost = 10,
                TorqueBoost = 15,
                ImageURL = "https://dtm-tuning.com/image/cache/catalog/goods_ad_eqip/milltek/a8-d4/milltek-ssxau466_1-1000x690.jpg",
                EngineId = 12,
                CarModelId = 14,
            };

            collection.Add(current);

            current = new ExhaustKit()
            {
                Id = 39,
                Manufacturer = "Capristo",
                Model = "4.0 TFSI S8 D4 Cat Back Exhaust",
                Price = 7300.00m,
                HorsePowerBoost = 10,
                TorqueBoost = 15,
                ImageURL = "https://cdn.capristoexhaust.com/wp-content/uploads/sites/3/IMG_0710-Audi-S8-20171109-600x400.jpg",
                EngineId = 13,
                CarModelId = 15,
            };

            collection.Add(current);

            current = new ExhaustKit()
            {
                Id = 40,
                Manufacturer = "Martellius",
                Model = "3.0 TFSI A6 C7 Cat Back Exhaust",
                Price = 1415.60m,
                HorsePowerBoost = 5,
                TorqueBoost = 8,
                ImageURL = "https://martelius.com/media/catalog/product/cache/c1e92043d4ce1e523c981de3ee6acbf8/5/3/530041.jpg",
                EngineId = 16,
                CarModelId = 18,
            };

            collection.Add(current);

            current = new ExhaustKit()
            {
                Id = 41,
                Manufacturer = "Milltek",
                Model = "4.2 FSI Q7 4L Exhaust Kit",
                Price = 2700.00m,
                HorsePowerBoost = 5,
                TorqueBoost = 8,
                ImageURL = "https://martelius.com/media/catalog/product/cache/c1e92043d4ce1e523c981de3ee6acbf8/5/3/530041.jpg",
                EngineId = 16,
                CarModelId = 18,
            };

            collection.Add(current);

            return collection;
        }
    }
}
