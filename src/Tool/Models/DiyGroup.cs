using System;
using System.Collections.Generic;

#nullable disable

namespace Tool.Models
{
    public partial class DiyGroup
    {
        public string GroupId { get; set; }
        public string Title { get; set; }
        public string CoverFile { get; set; }
        public int? Sno { get; set; }
        public string Version { get; set; }
        public string GoodsId { get; set; }
    }
}
