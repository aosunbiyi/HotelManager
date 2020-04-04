using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
    public partial class RoomWeekDay: Entity
    {
        public int RoomID { get; set; }
        public int WeekDayID { get; set; }

        public Room Room { get; set; }
        public WeekDay WeekDay { get; set; }
    }
}
