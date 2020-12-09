using System;
using System.Collections.Generic;

#nullable disable

namespace Tool.Models
{
    public partial class DiyUserImage
    {
        public string UserImageId { get; set; }
        public string UserId { get; set; }
        public string ImageFile { get; set; }
        public string ImageMiniFile { get; set; }
        public DateTime CreationTime { get; set; }
        public int IsOpen { get; set; }
        public string Version { get; set; }
    }
}
