using System;
using System.Collections.Generic;

#nullable disable

namespace Tool.Models
{
    public partial class DiyWorsImage
    {
        public string WorsImageId { get; set; }
        public string ScheduledId { get; set; }
        public string UserImageId { get; set; }
        public string ImageFile { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int H { get; set; }
        public int W { get; set; }
        public int Position { get; set; }
        public DateTime CreationTime { get; set; }
        public string Version { get; set; }
    }
}
