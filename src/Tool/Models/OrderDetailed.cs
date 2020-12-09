using System;
using System.Collections.Generic;

#nullable disable

namespace Tool.Models
{
    public partial class OrderDetailed
    {
        public string DetailedId { get; set; }
        public string Title { get; set; }
        public string PrimaryId { get; set; }
        public string UserId { get; set; }
        public string GoodsId { get; set; }
        public string ImageUrl { get; set; }
        public string SkuName { get; set; }
        public string SkuId { get; set; }
        public decimal Price { get; set; }
        public decimal OldPrice { get; set; }
        public string DisId { get; set; }
        public int Num { get; set; }
        public DateTime CreateTime { get; set; }
        public string Remark { get; set; }
        public string Version { get; set; }
    }
}
