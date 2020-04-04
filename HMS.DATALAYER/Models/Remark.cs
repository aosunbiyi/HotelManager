using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
    public partial class Remark:Entity
    {
        public int RemarkID { get; set; }
        public int RemarkCategoryID { get; set; }
        public string Alias { get; set; }
        public int? SortKey { get; set; }
        public string Reason { get; set; }
        public byte? Active { get; set; }

        public RemarkCategory RemarkCategory { get; set; }
    }
}
