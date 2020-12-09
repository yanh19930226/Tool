using System;
using System.Collections.Generic;

#nullable disable

namespace Tool.Models
{
    public partial class GoodsKeyVal
    {
        public string RowId { get; set; }
        public string GoodsId { get; set; }
        public string KeyId { get; set; }
        public string Val { get; set; }
        public string Version { get; set; }
    }
}
