using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VoyagePlanner
{
    public class VoyagePlanDetail : BaseClass
    {
        public long Location { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public VoyagePlan VoyagePlan { get; set; }
    }
}
