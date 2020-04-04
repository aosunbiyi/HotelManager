using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
    public partial class RoomType : Entity
    {
        public RoomType()
        {
            Rooms = new HashSet<Room>();
            RoomTypeRates = new HashSet<RoomTypeRate>();
        }

        public int RoomTypeID { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string Description { get; set; }
        public int? MaxAdult { get; set; }
        public int? MaxChild { get; set; }
        public string BackColor { get; set; }
        public byte? Inactive { get; set; }

        public ICollection<Room> Rooms { set; get; }
        public ICollection<RoomTypeRate> RoomTypeRates { get; set; }
    }
}
