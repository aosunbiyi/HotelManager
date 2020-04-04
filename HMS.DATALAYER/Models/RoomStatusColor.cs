using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
    public partial class RoomStatusColor: Entity
    {
        public int RoomStatusColorID { get; set; }
        public string StatusType { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
    }
}
