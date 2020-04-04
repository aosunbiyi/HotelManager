using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
    public partial class LaundryHotelService: Entity
    {
        public int LaundryHotelServiceID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? ExtraCharge { get; set; }
    }
}
