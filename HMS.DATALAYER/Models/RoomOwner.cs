using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
     public partial class RoomOwner : Entity
    {
        public RoomOwner()
        {
            Rooms = new HashSet<Room>();
        }
        public int RoomOwnerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public string RoomPlan { get; set; }
        public decimal? Amount { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public ICollection<Room> Rooms { get; set; }
    }
}
