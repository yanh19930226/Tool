using System;
using System.Collections.Generic;

#nullable disable

namespace Tool.Models
{
    public partial class GoodsBaseInfo
    {
        public string GoodsId { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public int IsOpen { get; set; }
        public decimal Price { get; set; }
        public DateTime? EditTime { get; set; }
        public decimal? OldPrice { get; set; }
        public string SortId { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string Introduction { get; set; }
        public string ScheduledList { get; set; }
        public string MaterialList { get; set; }
        public string Vendor { get; set; }
        public string Tags { get; set; }
        public string Js { get; set; }
        public string Option1Name { get; set; }
        public string Option2Name { get; set; }
        public string Version { get; set; }
    }
}
