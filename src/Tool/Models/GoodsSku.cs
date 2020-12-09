using System;
using System.Collections.Generic;

#nullable disable

namespace Tool.Models
{
    public partial class GoodsSku
    {
        public string SkuId { get; set; }
        public string GoodsId { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Title { get; set; }
        public int IsOpen { get; set; }
        public decimal Price { get; set; }
        public decimal? OldPrice { get; set; }
        public string Version { get; set; }
    }
}
