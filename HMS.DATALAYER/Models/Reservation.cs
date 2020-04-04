using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
    public partial class Reservation: Entity
    {

        public Reservation()
        {
            ArrivalDepartureLogs = new HashSet<ArrivalDepartureLog>();
            ReservationPayments = new HashSet<ReservationPayment>();
            ReservationTransactions = new HashSet<ReservationTransaction>();
            ReserveRooms = new HashSet<ReserveRoom>();
        }
        public int ReservationID { get; set; }
        public string ReservationNumber { get; set; }
        public string Code { get; set; }
        public DateTime? Arrival { get; set; }
        public string ArrivalTime { get; set; }
        public DateTime? Departure { get; set; }
        public string DepartureTime { get; set; }
        public int? NumberOfNight { get; set; }
        public int? NumberOfAdult { get; set; }
        public int? NumberOfChildren { get; set; }
        public int AccountID { get; set; }
        public string BookBy { get; set; }
        public DateTime? BookOn { get; set; }
        public int? BusinessSourceID { get; set; }
        public decimal? TotalBooking { get; set; }
        public decimal? AmountPaid { get; set; }
        public decimal? Balance { get; set; }
        public string ReservationStatus { get; set; }
        public string AccountNumber { get; set; }
        public byte? ApplyDiscount { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string Cheque { get; set; }
        public string DiscountCode { get; set; }
        public int? DiscountPlanID { get; set; }
        public decimal? DiscountValue { get; set; }
        public decimal DiscountAmount { get; set; }
        public string PaymentStatus { get; set; }
        public int LastPaymentID { get; set; }
        public decimal TotalAmountWithDiscount { get; set; }
        public decimal TotalBalanceWithDiscount { get; set; }

        public Account Account { get; set; }

        public BusinessSource BusinessSource { get; set; }
        public DiscountPlan DiscountPlan { get; set; }

        public ICollection<ArrivalDepartureLog>  ArrivalDepartureLogs { get; set; }

        public ICollection<ReservationPayment>  ReservationPayments { get; set; }

        public ICollection<ReservationTransaction>  ReservationTransactions { get; set; }

        public ICollection<ReserveRoom>  ReserveRooms { get; set; }

    }
}
