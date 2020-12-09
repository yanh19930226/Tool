using System;
using System.Collections.Generic;

#nullable disable

namespace Tool.Models
{
    public partial class PayMode
    {
        public string ModeId { get; set; }
        public string ModeName { get; set; }
        public string FileId { get; set; }
        public string PayUrl { get; set; }
        public string PayArgs { get; set; }
        public int Sno { get; set; }
        public string Version { get; set; }
        public int? IsOpen { get; set; }
    }
}
