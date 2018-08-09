using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoyagePlanner
{
    public class Location : BaseClass
    {
        public string Country { get; set; }
        public string City { get; set; }
        public long PostalCode { get; set; }
        public string CompanyName { get; set; }
        public string LocationName { get; set; }
        public long LocationCode { get; set; }
    }
}
