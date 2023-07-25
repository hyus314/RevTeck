using RevTech.Data.Models.PerformanceParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevTech.Data.Seeding
{
    public class TCUTuningSeeder
    {
        public ICollection<TCUTuning> GenerateTCUTunings()
        {
            ICollection<TCUTuning> collection = new HashSet<TCUTuning>();
            TCUTuning current;

            current = new TCUTuning()
            {
                Id = 1,
                Name = "Increase Top Speed",
                Description = "Once this selected TCU Option is installed, it will result in a higher Top Speed, but the acceleration rate will be reduced",
                ImageURL = "https://tuitionphysics.com/wp-content/uploads/2020/06/speed-velocity-and-acceleration-concepts-differences.jpg"
            };

            collection.Add(current);

            current = new TCUTuning()
            {
                Id = 2,
                Name = "Increase Acceleration",
                Description = "Once this selected TCU Option is installed, it will result in a faster Acceleration, but the Top Speed will be reduced",
                ImageURL = "https://grimmermotors.co.nz/wp-content/uploads/2018/03/high-rpm.jpg"
            };

            collection.Add(current);

            current = new TCUTuning()
            {
                Id = 3,
                Name = "Balanced",
                Description = "This TCU Option includes a balanced combination of both Acceleration and Top Speed",
                ImageURL = "https://cdn.hswstatic.com/gif/gears-1.jpg"
            };

            collection.Add(current);

            return collection;
        }
    }
}
