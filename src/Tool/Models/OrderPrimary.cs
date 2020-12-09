using System;
using System.Collections.Generic;

#nullable disable

namespace Tool.Models
{
    public partial class OrderPrimary
    {
        public string PrimaryId { get; set; }
        public string Serial { get; set; }
        public string PaymentCode { get; set; }
        public string WebId { get; set; }
        public string UserId { get; set; }
        public string Email { get; set; }
        public int Status { get; set; }
        public string CurrencyId { get; set; }
        public decimal OrderMoney { get; set; }
        public decimal? Amount { get; set; }
        public decimal Postage { get; set; }
        public string PayCurrencyId { get; set; }
        public decimal PayMoney { get; set; }
        public decimal PayPostage { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal? DesignPrice { get; set; }
        public string ModeId { get; set; }
        public string LogisticsId { get; set; }
        public string CouponId { get; set; }
        public string CouponUserId { get; set; }
        public decimal? CouponReduction { get; set; }
        public decimal? Reduction { get; set; }
        public DateTime PostTime { get; set; }
        public DateTime? PayTime { get; set; }
        public DateTime? OrderTime { get; set; }
        public string UserRemark { get; set; }
        public string AdminRemark { get; set; }
        public int? IsAddress { get; set; }
        public int? IsSync { get; set; }
        public DateTime? SyncTime { get; set; }
        public int? IsPay { get; set; }
        public string Version { get; set; }
        public string PayModelName { get; set; }
    }
}
