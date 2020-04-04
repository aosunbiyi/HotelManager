using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
    public partial class ReservationPayment : Entity
    {
        public int ReservationPaymentID { get; set; }
        public int ReservationID { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? Paid { get; set; }
        public decimal? Balance { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string Status { get; set; }
        public string PaymentMethod { get; set; }
        public string TransactionType { get; set; }
        public byte OnDiscount { get; set; }
        public int DiscountType { get; set; }
        public string DiscountName  { get; set; }
        public decimal DiscountValue { get; set; }
        public decimal TotalAmountWithDiscount { get; set; }

        public Reservation Reservation { get; set; }
    }
}
