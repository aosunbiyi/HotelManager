using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
    public partial class ReserveRoom: Entity
    {

        public ReserveRoom()
        {
            ReservationTransactions = new HashSet<ReservationTransaction>();
        }
        public int ReserveRoomID { get; set; }
        public int ReservationID { get; set; }
        public string SerialNumber { get; set; }
        public int RoomTypeID { get; set; }
        public int RoomID { get; set; }
        public string RoomTypeName { get; set; }
        public string RoomName { get; set; }
        public string OriginalOwner { get; set; }
        public string TransferOwner { get; set; }
        public string ReserveStatus { get; set; }
        public DateTime Arrival { get; set; }
        public string ArrivalTime { get; set; }
        public DateTime? Departure { get; set; }
        public string DepartureTime { get; set; }
        public int? NumberOfNight { get; set; }
        public int? NewAccountID { get; set; }
        public int? DisountPlanID { get; set; }
        public decimal? DiscountValue { get; set; }
        public decimal? Total { get; set; }
        public decimal? Paid { get; set; }
        public decimal? Balance { get; set; }
        public string Status { get; set; }
        public int? NumberOfAdult { get; set; }
        public int? NumberOfChildren { get; set; }

        public  Reservation Reservation { get; set; }
        public Room Room { get; set; }
        public ICollection<ReservationTransaction>  ReservationTransactions { get; set; }
    }
}
