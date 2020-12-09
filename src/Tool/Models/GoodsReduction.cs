using System;
using System.Collections.Generic;

#nullable disable

namespace Tool.Models
{
    public partial class GoodsReduction
    {
        public string ReductionId { get; set; }
        public decimal? ReductionAmount { get; set; }
        public decimal? Num { get; set; }
        public decimal? Amount { get; set; }
        public string Msg { get; set; }
        public string GoodsId { get; set; }
        public string Version { get; set; }
    }
}
