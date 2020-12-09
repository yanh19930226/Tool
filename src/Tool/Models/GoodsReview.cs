using System;
using System.Collections.Generic;

#nullable disable

namespace Tool.Models
{
    public partial class GoodsReview
    {
        public string ReviewId { get; set; }
        public string GoodsId { get; set; }
        public string Name { get; set; }
        public int? Star { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreationTime { get; set; }
        public string Version { get; set; }
        public string PicList { get; set; }
    }
}
