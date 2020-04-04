using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
    public partial class ArrivalDepartureLog: Entity
    {
        public int ArrivalDepartureLogID { get; set; }
        public int ReservationID { get; set; }
        public string TransactionType { get; set; }
        public DateTime? PickupDate { get; set; }
        public string PickupTime { get; set; }

        public Reservation Reservation { get; set; }
    }
}
