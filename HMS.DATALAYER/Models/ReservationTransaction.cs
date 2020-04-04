using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
    public partial class ReservationTransaction : Entity
    {
        public int ReservationTransactionID { get; set; }
        public int ReservationID { get; set; }
        public int ReservedRoomID { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Total { get; set; }
        public decimal? TotalReservation { get; set; }
        public decimal? TotalAdult { get; set; }
        public decimal? TotalChildren { get; set; }
        public decimal? Paid { get; set; }
        public decimal? Balance { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string Status { get; set; }
        public string PaymentMethod { get; set; }
        public string RoomName { get; set; }
        public string RoomType { get; set; }
        public string RateType { get; set; }
        public string RateName { get; set; }

        public Reservation Reservation { get; set; }
        public ReserveRoom ReserveRoom { get; set; }
    }
}
