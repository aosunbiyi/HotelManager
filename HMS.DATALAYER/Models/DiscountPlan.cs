using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
    public partial class DiscountPlan : Entity
    {

        public DiscountPlan()
        {
            Reservations = new HashSet<Reservation>();
        }
        public int DiscountPlanID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Note { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }
}
