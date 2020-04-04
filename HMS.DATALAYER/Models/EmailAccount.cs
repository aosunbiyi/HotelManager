using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
    public partial class EmailAccount : Entity
    {
        public int EmailAccountID { get; set; }
        public string SenderName { get; set; }
        public string EmailAddress { get; set; }
        public string MailServer { get; set; }
        public string MailServerPort { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public byte? LoginUsingSsl { get; set; }
        public byte? UseProxySettings { get; set; }
    }
}
