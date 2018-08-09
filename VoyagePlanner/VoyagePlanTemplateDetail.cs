using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoyagePlanner
{
    public class VoyagePlanTemplateDetail : BaseClass
    {
        public long VoyagePlanNumber { get; set; }
        public string DepartureTime { get; set; }
        public DayOfWeek DayofWeekArrival { get; set; }
        public DayOfWeek DayofWeekDeparture { get; set; }
        public string ArrivalTime { get; set; }
        public long LocationID { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
    }
}