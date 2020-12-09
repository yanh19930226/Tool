using System;
using System.Collections.Generic;

#nullable disable

namespace Tool.Models
{
    public partial class DiySkin
    {
        public string SkinId { get; set; }
        public string Title { get; set; }
        public string GoodsId { get; set; }
        public string GroupId { get; set; }
        public string Front { get; set; }
        public string Side { get; set; }
        public string Back { get; set; }
        public string Demo { get; set; }
        public int Sno { get; set; }
        public string Version { get; set; }
        public string BackInfo { get; set; }
    }
}
