using System;
using System.Collections.Generic;

#nullable disable

namespace Tool.Models
{
    public partial class GoodsSort
    {
        public string SortId { get; set; }
        public string SortName { get; set; }
        public string SuperiorsId { get; set; }
        public string Path { get; set; }
        public int Depth { get; set; }
        public int Sno { get; set; }
        public string Version { get; set; }
    }
}
