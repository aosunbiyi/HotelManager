using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
    public partial class BusinessSource: Entity
    {
        public BusinessSource()
        {
            BusinessSourceTypes = new HashSet<BusinessSourceType>();
            Reservations = new HashSet<Reservation>();
        }
        public int BusinessSourceID { get; set; }
        public int BusinessSourceTypeID { get; set; }
        public string Alias { get; set; }
        public string BusinessSourceName { get; set; }

        public ICollection<BusinessSourceType> BusinessSourceTypes { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
