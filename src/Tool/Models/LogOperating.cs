using System;
using System.Collections.Generic;

#nullable disable

namespace Tool.Models
{
    public partial class LogOperating
    {
        public string LogId { get; set; }
        public string AdminId { get; set; }
        public int OpType { get; set; }
        public DateTime? OpTime { get; set; }
        public string Val { get; set; }
        public string ModelId { get; set; }
        public string OpPagePath { get; set; }
        public string ToUserId { get; set; }
        public string Version { get; set; }
    }
}
