using System;
using System.Collections.Generic;

#nullable disable

namespace Tool.Models
{
    public partial class GoodsLink
    {
        public string LinkId { get; set; }
        public string GoodsId { get; set; }
        public string LinkGoodsId { get; set; }
        public int? Sno { get; set; }
        public string Version { get; set; }
    }
}
