using RevTech.Data.Models.PerformanceParts;
using static System.Net.WebRequestMethods;

namespace RevTech.Data.Seeding
{
    public class TurboKitSeeder
    {
        public ICollection<TurboKit> GenerateTurboKits()
        {
            TurboKit current;

            ICollection<TurboKit> collection = new HashSet<TurboKit>();

            current = new TurboKit()
            {
                Id = 1,
                ModelName = "GT2860RS",
                Manufacturer = "Garrett",
                HorsePowerBoost = 200,
                TorqueBoost = 250,
                PressureBoost = 1.8m,
                EngineId = 1,
                ImageURL = "https://www.turbozentrum.de/media/image/product/826/lg/garrett-turbokit-vw-golf-bora-audi-a3-tt-18t-350ps.jpg",
                Price = 2799.67m
            };

            collection.Add(current);

            current = new TurboKit()
            {
                Id = 2,
                ModelName = "Turbo-Total K04-001",
                Manufacturer = "BAR-TEK",
                HorsePowerBoost = 160,
                TorqueBoost = 200,
                PressureBoost = 1.6m,
                EngineId = 1,
                ImageURL = "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1920/https://www.bar-tek-tuning.com/thumbnail/fe/88/79/1683873716/2218t03-1.8T%20Tuning-Kit%20STUFE%203_1920x1920.webp",
                Price = 2115.26m
            };


            collection.Add(current);

            current = new TurboKit()
            {
                Id = 3,
                ModelName = "GTX B6A4",
                Manufacturer = "RAI",
                HorsePowerBoost = 280,
                TorqueBoost = 310,
                PressureBoost = 2.0m,
                EngineId = 2,
                ImageURL = "https://www.raimotorsport.com/v/vspfiles/photos/RAI_B6A4_1.8t_GTX-2.jpg",
                Price = 2675.00m
            };

            collection.Add(current);

            current = new TurboKit()
            {
                Id = 4,
                ModelName = "Turbo Concepts",
                Manufacturer = "RAI",
                HorsePowerBoost = 210,
                TorqueBoost = 270,
                PressureBoost = 1.9m,
                EngineId = 2,
                ImageURL = "https://turboconcepts.net/wp-content/uploads/2019/11/A4_18t_long_blackfridaypackage.gif",
                Price = 1679.00m
            };

            collection.Add(current);

            current = new TurboKit()
            {
                Id = 5,
                ModelName = "GT2876R",
                Manufacturer = "Garrett",
                HorsePowerBoost = 190,
                TorqueBoost = 250,
                PressureBoost = 1.8m,
                EngineId = 3,
                ImageURL = "https://www.turbo-parts.de/images/product_images/info_images/1.8T%20mit%20Downpipe.jpg",
                Price = 1851.98m
            };

            collection.Add(current);

            current = new TurboKit()
            {
                Id = 6,
                ModelName = "DZX-274",
                Manufacturer = "Turbo Concepts",
                HorsePowerBoost = 400,
                TorqueBoost = 500,
                PressureBoost = 2.2m,
                EngineId = 4,
                ImageURL = "https://turboconcepts.net/wp-content/uploads/2019/11/DZX-274a.gif",
                Price = 1995.00m
            };

            collection.Add(current);

            current = new TurboKit()
            {
                Id = 7,
                ModelName = "K04 Twin Turbo",
                Manufacturer = "034Motorsport",
                HorsePowerBoost = 400,
                TorqueBoost = 500,
                PressureBoost = 2.3m,
                EngineId = 4,
                ImageURL = "https://www.034motorsport.com/media/fishpig/webp/catalog/product/cache/1151afdc91a7a37549ca32dea82af8c6/0/3/034Motorsport_B5_S4_RS4_K04_Stage_3_Turbo_Kit_1.webp",
                Price = 3671.90m
            };

            collection.Add(current);

            current = new TurboKit()
            {
                Id = 8,
                ModelName = "TTE380+",
                Manufacturer = "The Turbo Engineers",
                HorsePowerBoost = 380,
                TorqueBoost = 450,
                PressureBoost = 2.1m,
                EngineId = 5,
                ImageURL = "https://www.tzr-motorsport.de/WebRoot/Store20/Shops/61911476/5F43/7DE0/D7D2/230B/A266/0A0C/6D10/D0F0/TTE380_Turbolader_Audi_A6_C5_TZR_Motorsport.jpg",
                Price = 2723.50m
            };

            collection.Add(current);

            current = new TurboKit()
            {
                Id = 9,
                ModelName = "GMC0501KT",
                Manufacturer = "GMC Racing",
                HorsePowerBoost = 250,
                TorqueBoost = 300,
                PressureBoost = 1.9m,
                EngineId = 9,
                ImageURL = "https://shop.gmcracing.com/1161-large_default/turbo-kit-audivw-20-tfsi-for-powers-up-to-450hp-with-tial-recirculation-wastegate.jpg",
                Price = 4182.85m
            };

            collection.Add(current);

            current = new TurboKit()
            {
                Id = 10,
                ModelName = "Tuning-Kit K04",
                Manufacturer = "BAR-TEK",
                HorsePowerBoost = 180,
                TorqueBoost = 250,
                PressureBoost = 1.8m,
                EngineId = 9,
                ImageURL = "https://shop.gmcracing.com/1161-large_default/turbo-kit-audivw-20-tfsi-for-powers-up-to-450hp-with-tial-recirculation-wastegate.jpg",
                Price = 2733.32m
            };

            collection.Add(current);

            current = new TurboKit()
            {
                Id = 11,
                ModelName = "TTE450",
                Manufacturer = "The Turbo Engineers",
                HorsePowerBoost = 150,
                TorqueBoost = 220,
                PressureBoost = 1.8m,
                EngineId = 9,
                ImageURL = "https://www.tte24.net/images/product_images/info_images/1130_0.JPG",
                Price = 1902.43m
            };

            collection.Add(current);

            current = new TurboKit()
            {
                Id = 12,
                ModelName = "GMC0501KT",
                Manufacturer = "GMC Racing",
                HorsePowerBoost = 250,
                TorqueBoost = 300,
                PressureBoost = 1.9m,
                EngineId = 10,
                ImageURL = "https://shop.gmcracing.com/1161-large_default/turbo-kit-audivw-20-tfsi-for-powers-up-to-450hp-with-tial-recirculation-wastegate.jpg",
                Price = 4182.85m
            };

            collection.Add(current);

            current = new TurboKit()
            {
                Id = 13,
                ModelName = "Tuning-Kit K04",
                Manufacturer = "BAR-TEK",
                HorsePowerBoost = 180,
                TorqueBoost = 250,
                PressureBoost = 1.8m,
                EngineId = 10,
                ImageURL = "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1280/https://www.bar-tek-tuning.com/thumbnail/52/d0/2c/1652867184/1460914175-17347gcxpvr99dwrhl_1280x1280.webp",
                Price = 2733.32m
            };

            collection.Add(current);

            current = new TurboKit()
            {
                Id = 14,
                ModelName = "TTE450",
                Manufacturer = "The Turbo Engineers",
                HorsePowerBoost = 150,
                TorqueBoost = 220,
                PressureBoost = 1.8m,
                EngineId = 10,
                ImageURL = "https://www.tte24.net/images/product_images/info_images/1130_0.JPG",
                Price = 1902.43m
            };

            collection.Add(current);

            current = new TurboKit()
            {
                Id = 15,
                ModelName = "TTE800+",
                Manufacturer = "The Turbo Engineers",
                HorsePowerBoost = 240,
                TorqueBoost = 280,
                PressureBoost = 2.2m,
                EngineId = 11,
                ImageURL = "https://tteglobal.com/media/image/f7/0f/4d/TTE800-2_600x600.jpg",
                Price = 2788.04m
            };

            collection.Add(current);

            current = new TurboKit()
            {
                Id = 16,
                ModelName = "TTE800+",
                Manufacturer = "The Turbo Engineers",
                HorsePowerBoost = 240,
                TorqueBoost = 280,
                PressureBoost = 2.2m,
                EngineId = 12,
                ImageURL = "https://tteglobal.com/media/image/f7/0f/4d/TTE800-2_600x600.jpg",
                Price = 2788.04m
            };

            collection.Add(current);

            current = new TurboKit()
            {
                Id = 17,
                ModelName = "TTE800+",
                Manufacturer = "The Turbo Engineers",
                HorsePowerBoost = 240,
                TorqueBoost = 280,
                PressureBoost = 2.2m,
                EngineId = 13,
                ImageURL = "https://tteglobal.com/media/image/f7/0f/4d/TTE800-2_600x600.jpg",
                Price = 2788.04m
            };

            collection.Add(current);

            current = new TurboKit()
            {
                Id = 18,
                ModelName = "HVA-246",
                Manufacturer = "HPA Motorsports",
                HorsePowerBoost = 180,
                TorqueBoost = 240,
                PressureBoost = 2.2m,
                EngineId = 11,
                ImageURL = "https://cdn.shopify.com/s/files/1/0451/1340/9690/products/DSC02364_1800x1800.jpg?v=1613506907",
                Price = 1799.00m
            };

            collection.Add(current);

            current = new TurboKit()
            {
                Id = 19,
                ModelName = "HVA-246",
                Manufacturer = "HPA Motorsports",
                HorsePowerBoost = 180,
                TorqueBoost = 240,
                PressureBoost = 2.2m,
                EngineId = 12,
                ImageURL = "https://cdn.shopify.com/s/files/1/0451/1340/9690/products/DSC02364_1800x1800.jpg?v=1613506907",
                Price = 1799.00m
            };

            collection.Add(current);

            current = new TurboKit()
            {
                Id = 20,
                ModelName = "HVA-246",
                Manufacturer = "HPA Motorsports",
                HorsePowerBoost = 180,
                TorqueBoost = 240,
                PressureBoost = 2.2m,
                EngineId = 13,
                ImageURL = "https://cdn.shopify.com/s/files/1/0451/1340/9690/products/DSC02364_1800x1800.jpg?v=1613506907",
                Price = 1799.00m
            };

            collection.Add(current);

            current = new TurboKit()
            {
                Id = 21,
                ModelName = "TSUTRSV2",
                Manufacturer = "Turbo Systems",
                HorsePowerBoost = 195,
                TorqueBoost = 280,
                PressureBoost = 2.2m,
                EngineId = 11,
                ImageURL = "https://static.wixstatic.com/media/16bf23_ed5ccc9846734ceca77e1d91994b4ef4~mv2_d_2000_1333_s_2.jpg/v1/fill/w_938,h_700,al_c,q_85,usm_0.66_1.00_0.01,enc_auto/16bf23_ed5ccc9846734ceca77e1d91994b4ef4~mv2_d_2000_1333_s_2.jpg",
                Price = 2137.50m
            };

            collection.Add(current);

            current = new TurboKit()
            {
                Id = 22,
                ModelName = "TSUTRSV2",
                Manufacturer = "Turbo Systems",
                HorsePowerBoost = 195,
                TorqueBoost = 280,
                PressureBoost = 2.2m,
                EngineId = 12,
                ImageURL = "https://static.wixstatic.com/media/16bf23_ed5ccc9846734ceca77e1d91994b4ef4~mv2_d_2000_1333_s_2.jpg/v1/fill/w_938,h_700,al_c,q_85,usm_0.66_1.00_0.01,enc_auto/16bf23_ed5ccc9846734ceca77e1d91994b4ef4~mv2_d_2000_1333_s_2.jpg",
                Price = 2137.50m
            };

            collection.Add(current);

            current = new TurboKit()
            {
                Id = 23,
                ModelName = "TSUTRSV2",
                Manufacturer = "Turbo Systems",
                HorsePowerBoost = 195,
                TorqueBoost = 280,
                PressureBoost = 2.2m,
                EngineId = 13,
                ImageURL = "https://static.wixstatic.com/media/16bf23_ed5ccc9846734ceca77e1d91994b4ef4~mv2_d_2000_1333_s_2.jpg/v1/fill/w_938,h_700,al_c,q_85,usm_0.66_1.00_0.01,enc_auto/16bf23_ed5ccc9846734ceca77e1d91994b4ef4~mv2_d_2000_1333_s_2.jpg",
                Price = 2137.50m
            };

            collection.Add(current);

            current = new TurboKit()
            {
                Id = 24,
                ModelName = "TTE1000+ Hybrid",
                Manufacturer = "The Turbo Engineers",
                HorsePowerBoost = 395,
                TorqueBoost = 450,
                PressureBoost = 2.5m,
                EngineId = 13,
                ImageURL = "https://www.tte24.net/images/product_images/popup_images/1272_1.JPG",
                Price = 8745.71m
            };

            collection.Add(current);

            return collection;
        }
    }
}
