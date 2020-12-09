using System;
using System.Collections.Generic;

#nullable disable

namespace Tool.Models
{
    public partial class LogisticsConfig
    {
        public string ConfigId { get; set; }
        public string Title { get; set; }
        public string AreaId { get; set; }
        public string Url { get; set; }
        public decimal Based { get; set; }
        public int IsUnits { get; set; }
        public DateTime CreatedTime { get; set; }
        public int Status { get; set; }
        public int Sno { get; set; }
        public string Version { get; set; }
        public decimal? FreePrice { get; set; }
        public decimal? FreeQuantity { get; set; }
    }
}
