using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
    public partial class Floor :Entity
    {
        public Floor()
        {
            Rooms = new HashSet<Room>();
        }
        public int FloorID { get; set; }
        public int WingID { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string Description { get; set; }

        public Wing Wing { get; set; }

        public ICollection<Room> Rooms { get; set; }
    }
}
