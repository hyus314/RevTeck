﻿using RevTech.Data.Models.PerformanceParts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevTech.Data.Seeding
{
    public class SparkPlugKitSeeder
    {
        public ICollection<SparkPlugs> GenerateSparkPlugs()
        {
            var collection = new HashSet<SparkPlugs>();

            SparkPlugs current;

            /*SPARK PLUG KIT ID 1*/
            /******************************************/

            current = new SparkPlugs()
            {
                //1.8t
                Id = 1,
                Manufacturer = "NGK",
                Price = 44.42m,
                ImageURL = "https://i.ebayimg.com/images/g/ceQAAOSwiDFYQVzW/s-l1600.jpg",
                EngineId = 1
            };

            collection.Add(current);

            current = new SparkPlugs()
            {
                //1.8t
                Id = 2,
                Manufacturer = "NGK",
                Price = 44.42m,
                ImageURL = "https://i.ebayimg.com/images/g/ceQAAOSwiDFYQVzW/s-l1600.jpg",
                EngineId = 2
            };

            collection.Add(current);

            current = new SparkPlugs()
            {
                //1.8t
                Id = 3,
                Manufacturer = "NGK",
                Price = 44.42m,
                ImageURL = "https://i.ebayimg.com/images/g/ceQAAOSwiDFYQVzW/s-l1600.jpg",
                EngineId = 3
            };

            collection.Add(current);

            /*SPARK PLUG KIT ID 2*/
            /******************************************/


            current = new SparkPlugs()
            {
                //2.7tt
                Id = 4,
                Manufacturer = "NGK",
                Price = 130.55m,
                ImageURL = "https://strperformance.com/25328-large_default/ngk-iridium-ix-bkr8eix-high-performance-spark-plugs-for-audi-s4-b5-and-rs4-v6-27-biturbo.jpg",
                EngineId = 4
            };

            collection.Add(current);

            current = new SparkPlugs()
            {
                //2.7tt
                Id = 5,
                Manufacturer = "NGK",
                Price = 130.55m,
                ImageURL = "https://strperformance.com/25328-large_default/ngk-iridium-ix-bkr8eix-high-performance-spark-plugs-for-audi-s4-b5-and-rs4-v6-27-biturbo.jpg",
                EngineId = 5
            };

            collection.Add(current);


            /*SPARK PLUG KIT ID 3*/
            /******************************************/


            current = new SparkPlugs()
            {
                //4.2 FSI
                Id = 6,
                Manufacturer = "NGK",
                Price = 195.82m,
                ImageURL = "https://strperformance.com/24726-large_default/ngk-platinum-pfr7w-tg-high-performance-spark-plugs-for-audi-r8-v8-42-fsi-quattro-420hp.jpg",
                EngineId = 6
            };

            collection.Add(current);

            current = new SparkPlugs()
            {
                //4.2 FSI
                Id = 7,
                Manufacturer = "NGK",
                Price = 195.82m,
                ImageURL = "https://strperformance.com/24726-large_default/ngk-platinum-pfr7w-tg-high-performance-spark-plugs-for-audi-r8-v8-42-fsi-quattro-420hp.jpg",
                EngineId = 7
            };

            collection.Add(current);

            current = new SparkPlugs()
            {
                //4.2 FSI
                Id = 8,
                Manufacturer = "NGK",
                Price = 195.82m,
                ImageURL = "https://strperformance.com/24726-large_default/ngk-platinum-pfr7w-tg-high-performance-spark-plugs-for-audi-r8-v8-42-fsi-quattro-420hp.jpg",
                EngineId = 8
            };

            collection.Add(current);


            /*SPARK PLUG KIT ID 4*/
            /******************************************/

            current = new SparkPlugs()
            {
                //2.0 TFSI
                Id = 9,
                Manufacturer = "NGK",
                Price = 87.03m,
                ImageURL = "https://strperformance.com/24718-large_default/ngk-iridium-ix-bkr8eix-high-performance-spark-plugs-for-20-tfsi-ea113-20-tsi-ea8881-engine.jpg",
                EngineId = 9
            };

            collection.Add(current);

            current = new SparkPlugs()
            {
                //2.0 TFSI
                Id = 10,
                Manufacturer = "NGK",
                Price = 87.03m,
                ImageURL = "https://strperformance.com/24718-large_default/ngk-iridium-ix-bkr8eix-high-performance-spark-plugs-for-20-tfsi-ea113-20-tsi-ea8881-engine.jpg",
                EngineId = 10
            };

            collection.Add(current);


            /*SPARK PLUG KIT ID 5*/
            /******************************************/


            current = new SparkPlugs()
            {
                //4.0 TFSI
                Id = 11,
                Manufacturer = "NGK",
                Price = 489.55m,
                ImageURL = "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1280/https://www.bar-tek-tuning.com/thumbnail/90/17/7e/1652886624/kerzenspa1okj0ueef9c6svpg2c0pr6pb6970_1280x1280.webp",
                EngineId = 11
            };

            collection.Add(current);

            current = new SparkPlugs()
            {
                //4.0 TFSI
                Id = 12,
                Manufacturer = "NGK",
                Price = 489.55m,
                ImageURL = "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1280/https://www.bar-tek-tuning.com/thumbnail/90/17/7e/1652886624/kerzenspa1okj0ueef9c6svpg2c0pr6pb6970_1280x1280.webp",
                EngineId = 12
            };

            collection.Add(current);

            current = new SparkPlugs()
            {
                //4.0 TFSI
                Id = 13,
                Manufacturer = "NGK",
                Price = 489.55m,
                ImageURL = "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1280/https://www.bar-tek-tuning.com/thumbnail/90/17/7e/1652886624/kerzenspa1okj0ueef9c6svpg2c0pr6pb6970_1280x1280.webp",
                EngineId = 13
            };

            collection.Add(current);

            /*SPARK PLUG KIT ID 6*/
            /******************************************/


            current = new SparkPlugs()
            {
                //3.0 TFSI
                Id = 14,
                Manufacturer = "NGK",
                Price = 108.79m,
                ImageURL = "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1280/https://www.bar-tek-tuning.com/thumbnail/b8/30/1f/1652867091/3-0l-tfsi-audi-s4-s5-ngk-z-ndkerzen-race476dd_1280x1280.webp",
                EngineId = 14
            };
            collection.Add(current);

            current = new SparkPlugs()
            {
                //3.0 TFSI
                Id = 15,
                Manufacturer = "NGK",
                Price = 108.79m,
                ImageURL = "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1280/https://www.bar-tek-tuning.com/thumbnail/b8/30/1f/1652867091/3-0l-tfsi-audi-s4-s5-ngk-z-ndkerzen-race476dd_1280x1280.webp",
                EngineId = 15
            };
            collection.Add(current);

            current = new SparkPlugs()
            {
                //3.0 TFSI
                Id = 16,
                Manufacturer = "NGK",
                Price = 108.79m,
                ImageURL = "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1280/https://www.bar-tek-tuning.com/thumbnail/b8/30/1f/1652867091/3-0l-tfsi-audi-s4-s5-ngk-z-ndkerzen-race476dd_1280x1280.webp",
                EngineId = 16
            };
            collection.Add(current);


            return collection;
        }
    }
}
