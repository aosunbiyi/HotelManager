using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
    public partial  class LaundryItem: Entity
    {
        public int LaundryItemID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int? LaundryItemCategoryID { get; set; }
        public string ItemType { get; set; }
        public decimal? Charges { get; set; }
        public string Description { get; set; }

        public LaundryItemCategory LaundryItemCategory { get; set; }
    }
}
