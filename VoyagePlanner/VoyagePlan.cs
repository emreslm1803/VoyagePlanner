using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VoyagePlanner
{
    public class VoyagePlan : BaseClass
    {
        public long LocationID { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public ICollection<VoyagePlanDetail> VoyagePlanDetails { get; set; }
    }
}
