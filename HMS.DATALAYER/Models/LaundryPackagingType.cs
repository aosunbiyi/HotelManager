using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
    public partial class LaundryPackagingType : Entity
    {
        public int LaundryPackagingTypeID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
    }
}
