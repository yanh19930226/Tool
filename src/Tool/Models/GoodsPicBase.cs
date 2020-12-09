using System;
using System.Collections.Generic;

#nullable disable

namespace Tool.Models
{
    public partial class GoodsPicBase
    {
        public string PicId { get; set; }
        public string GoodsId { get; set; }
        public int? IsDefault { get; set; }
        public string Val { get; set; }
        public string FileId { get; set; }
        public int? Sno { get; set; }
        public string Version { get; set; }
    }
}
