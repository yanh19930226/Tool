using System;
using System.Collections.Generic;

#nullable disable

namespace Tool.Models
{
    public partial class PayCurrency
    {
        public string CurrencyCodeId { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public decimal Rate { get; set; }
        public int IsStandard { get; set; }
        public string Version { get; set; }
    }
}
