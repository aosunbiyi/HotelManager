using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
    public partial class LaundryHotelTransationItem: Entity
    {
        public int LaundryHotelTransationItemID { get; set; }
        public int LaundryGuestTransactionID { get; set; }
        public int LaundryItemID { get; set; }
        public int? Quantity { get; set; }
        public string Status { get; set; }
        public LaundryGuestTransaction LaundryGuestTransaction { get; set; }
        public LaundryItem LaundryItem { get; set; }
    }
}
