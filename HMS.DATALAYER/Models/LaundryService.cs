using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
    public partial class LaundryService :Entity
    {

        public LaundryService()
        {
            LaundryGuestTransactions = new HashSet<LaundryGuestTransaction>();
            LaundryHotelTransations = new HashSet<LaundryHotelTransation>();
            LaundryItemServices = new HashSet<LaundryItemService>();
        }
        public int LaundryServiceID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }

        public ICollection<LaundryGuestTransaction> LaundryGuestTransactions { get; set; }
        public ICollection<LaundryHotelTransation>  LaundryHotelTransations { get; set; }

        public ICollection<LaundryItemService>  LaundryItemServices { get; set; }
    }
}
