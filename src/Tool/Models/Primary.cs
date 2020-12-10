using System;
using System.Collections.Generic;

#nullable disable

namespace Tool.Models
{
    public partial class Primary
    {
        public string PrimaryId { get; set; }
        public string OrderNo { get; set; }
        public string ClientIp { get; set; }
        public string Currency { get; set; }
        public string Subject { get; set; }
        public string Amount { get; set; }
        public string SuccessUri { get; set; }
        public string ReturnUri { get; set; }
        public string NotifyUrl { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string FromUrl { get; set; }
        public string SiteTitle { get; set; }
        public string InvoiceId { get; set; }
        public string Token { get; set; }
        public string Version { get; set; }
        public string PostTime { get; set; }
        public string WebId { get; set; }
        public string MerchantId { get; set; }
        public string IsPaid { get; set; }
        public string PayPalMail { get; set; }
        public string PayTime { get; set; }
        public string TxnId { get; set; }
        public string IsPaidSync { get; set; }
        public string IsPostSync { get; set; }
        public string UserPath { get; set; }
        public string IsHide { get; set; }
    }
}
