using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Models
{
    public partial class ApplicationConfiguration: Entity
    {
        public int ApplicationConfigurationID { get; set; }
        public string ApplicationName { get; set; }
        public string ApplicationLogo { get; set; }
        public string LoginBanner { get; set; }
        public string ApplicationTheme { get; set; }

        public DateTime? StartDate { get; set; }
        public string CountryName { get; set; }
        public string CountryAlias { get; set; }
        public string CurrncySign { get; set; }
        public string StateName { get; set; }
        public string Zip { get; set; }
        public int? FinancialPeriodFromDay { get; set; }
        public string FinancialPeriodFromMonth { get; set; }
        public int? FinancialPeriodToDay { get; set; }
        public string FinancialPeriodToMonth { get; set; }
    }
}
