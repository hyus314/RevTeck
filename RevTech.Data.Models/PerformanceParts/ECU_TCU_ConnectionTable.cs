using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevTech.Data.Models.PerformanceParts
{
    public class ECU_TCU_ConnectionTable
    {
        [ForeignKey(nameof(ECUTuning))]
        public int ECUTuningId { get; set; }
        public virtual ECUTuning ECUTuning { get; set; } = null!;
        [ForeignKey(nameof(TCUTuning))]
        public int TCUTuningId { get; set; }
        public virtual TCUTuning TCUTuning { get; set; } = null!;
    }
}
