using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
    public partial class RoomImage :Entity
    {
        public int RoomImageID { get; set; }
        public int RoomID { get; set; }
        public string ImageUrl { get; set; }

        public Room Room { get; set; }
    }
}
