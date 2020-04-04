using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
    public partial class Season : Entity
    {
        public int SeasonID { get; set; }
        public int SeasonTypeID { get; set; }
        public string Alias { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? FromDay { get; set; }
        public int? ToDay { get; set; }
        public string FromMonth { get; set; }
        public string ToMonth { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public SeasonType SeasonType { get; set; }
    }
}
