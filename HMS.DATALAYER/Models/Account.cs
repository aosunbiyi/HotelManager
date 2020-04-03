using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
    public partial class Account
    {

        public int AccountID { get; set; }
        public int AccountTypeID { get; set; }
        public string Alias { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string AccountNumber { get; set; }
        public decimal? CreditLimit { get; set; }
        public decimal? OpenningBalance { get; set; }
        public decimal? PaymentTerm { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string CreaditCardType { get; set; }
        public string CardHolder { get; set; }
        public string CardNumber { get; set; }
        public DateTime? ExpDate { get; set; }
        public string GroupName { get; set; }
        public string RegNumber { get; set; }
        public string CreatedBy { get; set; }
        public string Remark { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }

        public AccountType AccountType { get; set; }
    }
}
