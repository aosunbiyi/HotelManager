using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
    public partial class Entity
    {


        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime? LastModified { get; set; }

        public string UniqueIndentifier { get; set; } = Guid.NewGuid().ToString();
    }
}
