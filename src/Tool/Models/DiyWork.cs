using System;
using System.Collections.Generic;

#nullable disable

namespace Tool.Models
{
    public partial class DiyWork
    {
        public string WorksId { get; set; }
        public string GoodsId { get; set; }
        public string UserId { get; set; }
        public string CoverFile { get; set; }
        public string Front { get; set; }
        public string Side { get; set; }
        public string Back { get; set; }
        public int IsOrder { get; set; }
        public DateTime CreationTime { get; set; }
        public string Version { get; set; }
        public string SkinList { get; set; }
    }
}
