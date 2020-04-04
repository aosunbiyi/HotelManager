using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
    public partial class AccountType: Entity
    {
        public AccountType()
        {
            Accounts = new HashSet<Account>();
        }
        public int AccountTypeID{ get; set; }
        public string Alias { get; set; }
        public string Name { get; set; }

        public ICollection<Account> Accounts { get; set; }
    }
}
