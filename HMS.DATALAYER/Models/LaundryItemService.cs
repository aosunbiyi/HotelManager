using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
    public partial class LaundryItemService : Entity
    {
        public int LaundryItemID { get; set; }
        public int LaundryServiceID { get; set; }

        public LaundryItem LaundryItem { get; set; }
        public LaundryService LaundryService { get; set; }
    }
}
