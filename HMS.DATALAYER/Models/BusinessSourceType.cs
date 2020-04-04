using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
    public partial class BusinessSourceType : Entity
    {

        public BusinessSourceType()
        {
            BusinessSources = new HashSet<BusinessSource>();
        }
        public int BusinessSourceTypeID { get; set; }
        public string Alias { get; set; }
        public string BusinessSourceTypeName { get; set; }

        public ICollection<BusinessSource> BusinessSources { get; set; }
    }
}
