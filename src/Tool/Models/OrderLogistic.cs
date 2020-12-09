using System;
using System.Collections.Generic;

#nullable disable

namespace Tool.Models
{
    public partial class OrderLogistic
    {
        public string LogisticsId { get; set; }
        public string PrimaryId { get; set; }
        public string UserId { get; set; }
        public int? Appellation { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string AreaId { get; set; }
        public string Villages { get; set; }
        public string CountryId { get; set; }
        public string ZipCode { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public string Telephone { get; set; }
        public int? IsShip { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? ShipTime { get; set; }
        public string LogisticsCode { get; set; }
        public string ConfigId { get; set; }
        public int? TotalWeight { get; set; }
        public string ConfigTitle { get; set; }
        public decimal? BasedMoney { get; set; }
        public string Version { get; set; }
        public string AreaName { get; set; }
        public string CountryName { get; set; }
    }
}
