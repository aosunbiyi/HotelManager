using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
    public partial class RoomTypeRate : Entity
    {
        public int RoomTypeID { get; set; }
        public int RateID { get; set; }

        public Rate Rate { get; set; }
        public RoomType RoomType { get; set; }
    }
}
