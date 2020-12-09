using System;
using System.Collections.Generic;

#nullable disable

namespace Tool.Models
{
    public partial class GoodsReviewStatistic
    {
        public string StatisticsId { get; set; }
        public string GoodsId { get; set; }
        public int Star1 { get; set; }
        public int Star2 { get; set; }
        public int Star3 { get; set; }
        public int Star4 { get; set; }
        public int Star5 { get; set; }
        public int Total { get; set; }
        public decimal Average { get; set; }
        public DateTime StatisticsTime { get; set; }
        public string Version { get; set; }
    }
}
