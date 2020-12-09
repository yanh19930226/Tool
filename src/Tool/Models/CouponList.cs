using System;
using System.Collections.Generic;

#nullable disable

namespace Tool.Models
{
    public partial class CouponList
    {
        public string CouponId { get; set; }
        public string Title { get; set; }
        public string CouponCode { get; set; }
        public int Consumption { get; set; }
        public decimal Discount { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Status { get; set; }
        public int CouponType { get; set; }
        public string Description { get; set; }
        public string Version { get; set; }
        public int? IsReduction { get; set; }
    }
}
