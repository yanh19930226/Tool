using System;
using System.Collections.Generic;

#nullable disable

namespace Tool.Models
{
    public partial class MetaArea
    {
        public string AreaId { get; set; }
        public string Name { get; set; }
        public string SuperiorsId { get; set; }
        public string Path { get; set; }
        public int Types { get; set; }
        public string LanguageId { get; set; }
        public string Version { get; set; }
    }
}
