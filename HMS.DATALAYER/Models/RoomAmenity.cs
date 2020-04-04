using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
    public partial class RoomAmenity: Entity
    {
        public int RoomID { get; set; }
        public int AmenityID { get; set; }

        public Amenity Amenity { get; set; }
        public Room Room { get; set; }
    }
}
