using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
    public partial class WeekDay:Entity
    {
        public WeekDay()
        {
            RoomWeekDays = new HashSet<RoomWeekDay>();
        }
        public int WeekDayID { get; set; }
        public string Name { get; set; }
        public bool Isweekday { get; set; }

        public ICollection<RoomWeekDay> RoomWeekDays { get; set; }
    }
}
