﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
    public partial class LaundryHotelTransation: Entity
    {
        public int LaundryHotelTransationID { get; set; }
        public string Code { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string TransactionTime { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string DeliveryTime { get; set; }
        public int LaundryPackagingTypeID { get; set; }
        public int LaundryServiceID { get; set; }
        public int LaundryHotelServiceID { get; set; }
        public string Status { get; set; }

        public LaundryHotelService LaundryHotelService { get; set; }
        public LaundryPackagingType LaundryPackagingType { get; set; }
        public LaundryService LaundryService  { get; set; }
    }
}
