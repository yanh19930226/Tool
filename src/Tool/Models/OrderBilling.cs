using System;
using System.Collections.Generic;

#nullable disable

namespace Tool.Models
{
    public partial class OrderBilling
    {
        public string BillingId { get; set; }
        public string PrimaryId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string AreaId { get; set; }
        public string AreaName { get; set; }
        public string CountryName { get; set; }
        public string CountryId { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string Version { get; set; }
    }
}
