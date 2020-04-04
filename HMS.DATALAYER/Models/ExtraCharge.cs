using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
    public partial class ExtraCharge: Entity
    {
        public int ExtraChargeID { get; set; }
        public string Alias { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ExtraChargeCategoryID { get; set; }
        public decimal? Rate { get; set; }

        public ExtraChargeCategory ExtraChargeCategory { get; set; }
    }
}
