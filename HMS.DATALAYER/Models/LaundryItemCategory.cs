using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
    public partial class LaundryItemCategory: Entity
    {
        public LaundryItemCategory()
        {
            LaundryItems = new HashSet<LaundryItem>();
        }
        public int LaundryItemCategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CategoryImage { get; set; }

        public ICollection<LaundryItem> LaundryItems { get; set; }
    }
}
