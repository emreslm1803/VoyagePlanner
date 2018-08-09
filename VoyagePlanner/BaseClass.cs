
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VoyagePlanner
{
    public abstract class BaseClass
    {
        public BaseClass()
        {

        }

        [Key]
        public long ID { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public void OnChanged(object oldValue, object newValue)
        {

        }

        public void OnSaved()
        {

        }

    
    }
}
