using System;
using System.Collections.Generic;

#nullable disable

namespace Tool.Models
{
    public partial class LogError
    {
        public string ErrorId { get; set; }
        public string UserId { get; set; }
        public string Pager { get; set; }
        public int LevelNum { get; set; }
        public string Msg { get; set; }
        public string Detailed { get; set; }
        public string Ip { get; set; }
        public DateTime? ErrorTime { get; set; }
        public string Version { get; set; }
    }
}
