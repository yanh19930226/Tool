using System;
using System.Collections.Generic;

#nullable disable

namespace Tool.Models
{
    public partial class SysAccount
    {
        public string AdminId { get; set; }
        public string Account { get; set; }
        public string Pwd { get; set; }
        public string Mail { get; set; }
        public int IsOpen { get; set; }
        public string PurviewId { get; set; }
        public string Version { get; set; }
    }
}
