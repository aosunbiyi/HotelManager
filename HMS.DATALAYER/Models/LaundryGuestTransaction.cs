using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
     public partial class LaundryGuestTransaction: Entity
    {

        public LaundryGuestTransaction()
        {
            LaundryGuestTransactionItems = new HashSet<LaundryGuestTransactionItem>();
            LaundryHotelTransationItems = new HashSet<LaundryHotelTransationItem>();
        }
        public int LaundryGuestTransactionID { get; set; }
        public string Code { get; set; }
        public int RoomID { get; set; }
        public int AccountID { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string TransactionTime { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string DeliveryTime { get; set; }
        public int LaundryPackagingTypeID { get; set; }
        public int LaundryServiceID { get; set; }
        public int LaundryHotelServiceID { get; set; }
        public decimal? TotalChages { get; set; }
        public string Status { get; set; }

        public Account Account { get; set; }
        public LaundryHotelService LaundryHotelService { get; set; }
        public LaundryPackagingType LaundryPackagingType { get; set; }
        public LaundryService LaundryService { get; set; }
        public Room Room { get; set; }

        public ICollection<LaundryGuestTransactionItem>  LaundryGuestTransactionItems { get; set; }
        public ICollection<LaundryHotelTransationItem> LaundryHotelTransationItems { get; set; }

    }
}
