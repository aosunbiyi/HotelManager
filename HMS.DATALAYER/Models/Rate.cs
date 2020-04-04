using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
    public partial class Rate :Entity
    {
        public int  RateID { get; set; }
        public int RateTypeID { get; set; }
        public string Name { get; set; }
        public decimal? Amount { get; set; }
        public byte? Isweekday { get; set; }
        public byte? Isspecial { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public byte? Isactive { get; set; }
        public decimal? ExtrAdult { get; set; }
        public decimal? ExtraChild { get; set; }

        public RateType RateType { get; set; }
    }
}
