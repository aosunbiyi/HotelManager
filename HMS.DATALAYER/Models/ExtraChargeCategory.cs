using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
    public partial class ExtraChargeCategory : Entity
    {

        public ExtraChargeCategory()
        {
            ExtraCharges = new HashSet<ExtraCharge>();
        }
        public int ExtraChargeCategoryID { get; set; }
        public string Alias { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<ExtraCharge> ExtraCharges { get; set; }
    }
}
