using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
    public partial class Wing :Entity
    {
        public Wing()
        {
            Floors = new HashSet<Floor>();
        }
        public int WingID { get; set; }
        public string Name { get; set; }

        public ICollection<Floor> Floors { get; set; }
    }
}
