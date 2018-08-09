using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace VoyagePlanner
{
    public class VoyagePlanTemplate : BaseClass
    {
        public long Path { get; set; }
        public ICollection<VoyagePlanTemplateDetail> VoyagePlanTemplateDetails { get; set; }
    }
}
