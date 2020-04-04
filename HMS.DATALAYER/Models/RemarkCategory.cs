using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
    public partial class RemarkCategory : Entity
    {
        public RemarkCategory()
        {
            Remarks = new HashSet<Remark>();
        }
        public int RemarkCategoryID { get; set; }
        public string Alias { get; set; }
        public int? SortKey { get; set; }
        public string Name { get; set; }

        public ICollection<Remark> Remarks { get; set; }
    }
}
