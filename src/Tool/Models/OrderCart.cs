using System;
using System.Collections.Generic;

#nullable disable

namespace Tool.Models
{
    public partial class OrderCart
    {
        public string CartId { get; set; }
        public string UserId { get; set; }
        public string GoodsId { get; set; }
        public string SkuId { get; set; }
        public string Num { get; set; }
        public int? IsVisitor { get; set; }
        public DateTime? AddTime { get; set; }
        public string Version { get; set; }
    }
}
