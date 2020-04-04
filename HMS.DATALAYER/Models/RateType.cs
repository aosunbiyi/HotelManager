using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
    public partial class RateType : Entity
    {
        public RateType()
        {
            Rates = new HashSet<Rate>();
        }
        public int RateTypeID { get; set; }
        public string Name { get; set; }

        public ICollection<Rate> Rates { get; set; }
    }

   
}
