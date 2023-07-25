namespace RevTech.Data.Seeding
{
    using RevTech.Data.Models.Vehicles;
    public class CarModelSeeder
    {
        public ICollection<CarModel> GenerateModels()
        {
            ICollection<CarModel> models = new HashSet<CarModel>();

            CarModel current;

            current = new CarModel()
            {
                Id = 1,
                ModelName = "A6 C5",
                YearCreated_Start = 1997,
                YearCreated_End = 2004,
                ManufacturerId = 1,
                ImageURL = "https://img.favcars.com/audi/a6/photos_audi_a6_2001_2_b.jpg"
            };

            models.Add(current);

            current = new CarModel()
            {
                Id = 2,
                ModelName = "A4 B5",
                YearCreated_Start = 1996,
                YearCreated_End = 2001,
                ManufacturerId = 1,
                ImageURL = "https://i.ytimg.com/vi/AAfmxSRncBU/maxresdefault.jpg"
            };

            models.Add(current);

            current = new CarModel()
            {
                Id = 3,
                ModelName = "A4 B6",
                YearCreated_Start = 2002,
                YearCreated_End = 2004,
                ManufacturerId = 1,
                ImageURL = "https://stillrunningstrong.com/wp-content/uploads/2018/03/Audi-A4-b6-sport-model-S4-1024x466.jpg"
            };
            models.Add(current);

            current = new CarModel()
            {
                Id = 4,
                ModelName = "S4 B5",
                YearCreated_Start = 1997,
                YearCreated_End = 2001,
                ManufacturerId = 1,
                ImageURL = "https://images.fitmentindustries.com/web-compressed/1740944-1-2001-s4-audi-base-bc-racing-coilovers-bbs-ch-r-silver.jpg"
            };
            models.Add(current); current = new CarModel()
            {
                Id = 5,
                ModelName = "RS4 B7",
                YearCreated_Start = 2005,
                YearCreated_End = 2009,
                ManufacturerId = 1,
                ImageURL = "https://media.evo.co.uk/image/private/s--zWq7JwVH--/v1556260759/evo/images/dir_688/car_photo_344347.jpg"

            };
            models.Add(current); current = new CarModel()
            {
                Id = 6,
                ModelName = "S5 B8",
                YearCreated_Start = 2007,
                YearCreated_End = 2013,
                ManufacturerId= 1,
                ImageURL = "https://www.ast-suspension.com/imager/common/10988/Audi-S5-B8-3_ccc647699d3b878f33fab0fc43e2f880.jpg"
            };
            models.Add(current);

            models.Add(current); current = new CarModel()
            {
                Id = 7,
                ModelName = "S5 B8.5",
                YearCreated_Start = 2013,
                YearCreated_End = 2017,
                ManufacturerId = 1,
                ImageURL = "https://en.audiclub.eu/graphics/gallery/full/2178_13237385133-509f54d839-b.jpg"
            };
            models.Add(current);

            current = new CarModel()
            {
                Id = 8,
                ModelName = "RS5 B8.5",
                YearCreated_Start = 2013,
                YearCreated_End = 2017,
                ManufacturerId = 1,
                ImageURL = "https://cimg7.ibsrv.net/gimg/www.audiworld.com-vbulletin/1200x837/audi_driveway_725b6dcf65369cb5d7d45810f3e5e8d8c487097a.jpg"
            };
            models.Add(current);

            current = new CarModel()
            {
                Id = 9,
                ModelName = "A6 C6",
                YearCreated_Start = 2004,
                YearCreated_End = 2011,
                ManufacturerId = 1,
                ImageURL = "https://cdn.shopify.com/s/files/1/0570/5518/3000/collections/a6_c6.jpg?v=1648793950"
            };
            models.Add(current);

            current = new CarModel()
            {
                Id = 10,
                ModelName = "A4 B7",
                YearCreated_Start = 2004,
                YearCreated_End = 2008,
                ManufacturerId = 1,
                ImageURL = "https://i.pinimg.com/originals/e1/a2/32/e1a232889a2009dffca15f9b432ab3b8.jpg"
            };
            models.Add(current);

            current = new CarModel()
            {
                Id = 11,
                ModelName = "A4 B8.5",
                YearCreated_Start = 2012,
                YearCreated_End = 2015,
                ManufacturerId = 1,
                ImageURL = "https://i.pinimg.com/originals/4f/54/ea/4f54ea4597e4fc876df08c49bad03992.jpg"
            };
            models.Add(current);

            current = new CarModel()
            {
                Id = 12,
                ModelName = "S6 C7",
                YearCreated_Start = 2011,
                YearCreated_End = 2018,
                ManufacturerId = 1,
                ImageURL = "https://img.md-exclusive-cardesign.com/wp-content/uploads/2019/10/audi-a6-c7-limousine-breitbau-tuning-pd600r-widebody-kit-artform-af-401-felgen-in-105x21-md-exclusive-cardesign-16-455x179.jpg"
            };
            models.Add(current);

            current = new CarModel()
            {
                Id = 13,
                ModelName = "RS6 C7",
                YearCreated_Start = 2011,
                YearCreated_End = 2018,
                ManufacturerId = 1,
                ImageURL = "https://img.md-exclusive-cardesign.com/wp-content/uploads/2019/10/audi-a6-c7-limousine-breitbau-tuning-pd600r-widebody-kit-artform-af-401-felgen-in-105x21-md-exclusive-cardesign-16-455x179.jpg"
            };
            models.Add(current);

            current = new CarModel()
            {
                Id = 14,
                ModelName = "S8 D4",
                YearCreated_Start = 2012,
                YearCreated_End = 2015,
                ManufacturerId = 1,
                ImageURL = "https://www.tuning.bg/public/upload/gallery/extended/normal/1358582002.jpg"
            };
            models.Add(current);

            current = new CarModel()
            {
                Id = 15,
                ModelName = "S8+ D4.5",
                YearCreated_Start = 2015,
                YearCreated_End = 2018,
                ManufacturerId = 1,
                ImageURL = "https://cdn-0.carsopedia.com/files/generations/Audi-D4-498.jpg"
            };
            models.Add(current);

            current = new CarModel()
            {
                Id = 16,
                ModelName = "S7 C7",
                YearCreated_Start = 2012,
                YearCreated_End = 2017,
                ManufacturerId = 1,
                ImageURL = "https://www.auto-data.net/images/f4/file3193601.jpg"
            };
            models.Add(current);

            current = new CarModel()
            {
                Id = 17,
                ModelName = "RS7 C7",
                YearCreated_Start = 2013,
                YearCreated_End = 2019,
                ManufacturerId = 1,
                ImageURL = "https://www.autocar.co.uk/sites/autocar.co.uk/files/audi-rs7_1.jpg"
            };
            models.Add(current);

            current = new CarModel()
            {
                Id = 18,
                ModelName = "A6 C7",
                YearCreated_Start = 2011,
                YearCreated_End = 2018,
                ManufacturerId = 1,
                ImageURL = "https://upload.wikimedia.org/wikipedia/commons/8/85/Audi_A6_S-line_%28C7%29_%E2%80%93_Frontansicht%2C_1._Mai_2012%2C_D%C3%BCsseldorf.jpg"
            };
            models.Add(current);

            current = new CarModel()
            {
                Id = 19,
                ModelName = "Q7 4L",
                YearCreated_Start = 2005,
                YearCreated_End = 2015,
                ManufacturerId = 1,
                ImageURL = "https://mir-s3-cdn-cf.behance.net/project_modules/fs/b2ebb974237045.5c27acde184ed.jpg"
            };
            models.Add(current);


            return models;
        }
    }
}
