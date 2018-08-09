using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoyagePlanner
{
    public class PathLocation : BaseClass
    {
        public long LocationId { get; set; }
        public long PathId { get; set; }
        public long SortNo { get; set; }
    }
}
