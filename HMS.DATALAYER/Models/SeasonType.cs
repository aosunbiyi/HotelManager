using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
     public partial class SeasonType: Entity
    {
        public SeasonType()
        {
            Seasons = new HashSet<Season>();
        }
        public int SeasonTypeID { get; set; }
        public string Alias { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Season> Seasons { get; set; }
    }
}
