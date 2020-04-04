using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
    public partial class Amenity : Entity
    {
        public Amenity()
        {
            RoomAmenities = new HashSet<RoomAmenity>();
        }

        public int AmenityID { get; set; }
        public int? AmenityTypeID { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }

        public ICollection<RoomAmenity> RoomAmenities { get; set; }
    }
}
